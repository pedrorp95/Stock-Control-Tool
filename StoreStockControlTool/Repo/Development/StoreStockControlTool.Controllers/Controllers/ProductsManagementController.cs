using LinqKit;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VLStoreModel.Model;

namespace StoreStockControlTool.Controllers.Controllers
{
    public class ProductsManagementController
    {

        #region ChargeControls

        public List<ProductTypes> GetAllTypes()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.ProductTypes.ToList();
        }


        public List<Products> GetAllProducts(ExpressionStarter<Products> predicate)
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            try
            {
                List<Products> listProducts = dbcontext.Products.Where(predicate).ToList();
                return listProducts;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Products> GetWithoutenter()
        {
            //Connection to VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Products.ToList();
        }
        
        public List<ProductsProviders> GetProducts(string reference)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();

            try
            {
                List<ProductsProviders> listProductsProvider = dbcontext.ProductsProviders.Where(p => p.Reference == reference).ToList();
                return listProductsProvider;
            }
            catch (Exception)
            {

                return null;
            }
        }

        #endregion

        #region ProductsEvents
        private void AddProductsProviders(ProductsProviders productsproviders)
        {

            VLStoreManagementString dbcontext = new VLStoreManagementString();
            dbcontext.ProductsProviders.Where(i => i.Reference == productsproviders.Reference).FirstOrDefault();
            try
            {
                dbcontext.Entry(productsproviders).State = EntityState.Added;
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }

        //Button Edit
        public void EditProducts(Products products)
        {

            VLStoreManagementString dbcontext = new VLStoreManagementString();
            var productsInBD = dbcontext.Products.Where(i => i.Reference == products.Reference).FirstOrDefault();

            //ProductsInBD debe tener una lista distinta a products.
            productsInBD.ProductName = products.ProductName;
            productsInBD.IdType = products.IdType;
            productsInBD.StockMin = products.StockMin;
            productsInBD.QuantityInUse = products.QuantityInUse;
            productsInBD.UseExpirationDate = products.UseExpirationDate;
            productsInBD.WarningForMinStock = products.WarningForMinStock;
            productsInBD.UseLot = products.UseLot;
            productsInBD.Dimensions = products.Dimensions;


            foreach (var pp in products.ProductsProviders)
            {
                if (!productsInBD.ProductsProviders.Select(p => p.Temp_Providers.ProviderCode).Contains(pp.Temp_Providers.ProviderCode))
                {
                    ProductsProviders ppINBD = new ProductsProviders();
                    ppINBD.ProviderCode = pp.Temp_Providers.ProviderCode;
                    productsInBD.ProductsProviders.Add(ppINBD);
                }
            }
            dbcontext.Set<Products>().AddOrUpdate(productsInBD);
            dbcontext.SaveChanges();
        }

        public void EditProductsProviders(ProductsProviders productsProviders)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            var productsInBD = dbcontext.Products.Where(i => i.Reference == productsProviders.Reference).FirstOrDefault();
            productsInBD.Reference = productsProviders.Reference;
        }

        //Button Add
        public void AddProducts(Products products)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            dbcontext.Products.Where(i => i.Reference == products.Reference).FirstOrDefault();
            try
            {
                dbcontext.Entry(products).State = EntityState.Added;
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }
        public void SaveProductsProvider(Products products, Temp_Providers providers, ProductsProviders pp)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            dbcontext.ProductsProviders.Where(i => i.Reference == products.Reference && i.ProviderCode == providers.ProviderCode).FirstOrDefault();

            try
            {
                pp.Temp_Providers = providers;
                pp.Products = products;
                dbcontext.Entry(pp).State = EntityState.Added;
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {

            }
        }

        //Button delete
        public void DeleteProducts(Products products)
        {
            //Connection to db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            //Relation betweenp tables
            var productsInBD = dbcontext.Products.Where(i => i.Reference == products.Reference).FirstOrDefault();
            try
            {
                dbcontext.Products.Remove(productsInBD);
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }




        //Si devuelve true idtype coincide.Y hay en la bd. Para añadir tiene que existir idtype en la bd si no no deja
        //Se utiliza tanto en addproducts como editproducts.
        public bool CompareProductsIdType(int ptypes)
        {
            bool on = false;

            VLStoreManagementString dbcontext = new VLStoreManagementString();
            var IdTypeInBD = dbcontext.ProductTypes.Where(i => i.IdType == ptypes).FirstOrDefault();


            try
            {
                if (IdTypeInBD != null)
                {
                    on = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return on;

        }

        //Si da true es cuando se añade el producto porque no está en la base de datos. Porque esto se utiliza al añadir el producto.
        //Solo se utiliza en addproducts
        public bool CompareReference(String reference)
        {
            bool on = false;

            VLStoreManagementString dbcontext = new VLStoreManagementString();
            var productsInBD = dbcontext.Products.Where(i => i.Reference == reference).FirstOrDefault();

            try
            {
                if (productsInBD == null)
                {
                    on = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return on;
        }

        public void DeletePP(ProductsProviders pp)
        {
            //Connection to db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            //Relation betweenp tables
            var productsInBD = dbcontext.ProductsProviders.Where(i => i.Reference == pp.Reference).FirstOrDefault();
            try
            {
                dbcontext.ProductsProviders.Remove(productsInBD);
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
    }
}
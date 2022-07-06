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
    public class TempProvidersController
    {

        #region Chargecontrols
        public List<Temp_Providers> GetAllProviders(ExpressionStarter<Temp_Providers> predicate)
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();

            try
            {
                List<Temp_Providers> listProviders = dbcontext.Temp_Providers.Where(predicate).ToList();
                return listProviders;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Temp_Providers> GetWithoutEnter()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Temp_Providers.ToList();
        }

        public List<ProductsProviders> GetProductsProviders(string reference)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();

            try
            {
                List<ProductsProviders> listProductsProvider = dbcontext.ProductsProviders.Where(p => p.ProviderCode == reference).ToList();
                return listProductsProvider;
            }
            catch (Exception)
            {

                return null;
            }
        }

        #endregion

        #region TempProvidersEvents
        public void EditProviders(Temp_Providers providers)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            var providersInBD = dbcontext.Temp_Providers.Where(i => i.ProviderCode == providers.ProviderCode).FirstOrDefault();

            providersInBD.ProviderName = providers.ProviderName;
            providersInBD.SAPProvidercode = providers.SAPProvidercode;
            providersInBD.Address = providers.Address;
            providersInBD.City = providers.City;
            providersInBD.Active = providers.Active;
            providersInBD.PostalZip = providers.PostalZip;
            providersInBD.Country = providers.Country;
            providersInBD.CountryCode = providers.CountryCode;
            providersInBD.Telephone = providers.Telephone;

            foreach (var pp in providers.ProductsProviders) //Aqui va a comparar la lista products provider con la nueva
            {
                if (!providersInBD.ProductsProviders.Select(p => p.Products.Reference).Contains(pp.Products.Reference)) //Si la nueva lista contiene datos de la ultima
                {
                    ProductsProviders ppINBD = new ProductsProviders(); //Aqui es la nueva lista
                    ppINBD.Reference = pp.Products.Reference; //La referencia de la antigua lista la asocia con la "nueva lista"
                    providersInBD.ProductsProviders.Add(ppINBD); //La "nueva lista " la va acutalizar para la que habia en la base de datos.
                }
            }
            dbcontext.Set<Temp_Providers>().AddOrUpdate(providersInBD);
            dbcontext.SaveChanges();
        }

        public void AddProviders(Temp_Providers providers)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            var storeInBD = dbcontext.Temp_Providers.Where(i => i.ProviderCode == providers.ProviderCode).FirstOrDefault();
            try
            {
                dbcontext.Entry(providers).State = EntityState.Added;
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }


        public void DeleteProviders(Temp_Providers providers)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            var providersInBD = dbcontext.Temp_Providers.Where(i => i.ProviderCode == providers.ProviderCode).FirstOrDefault();

            try
            {
                dbcontext.Temp_Providers.Remove(providersInBD);
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }

        public bool CompareProviders(string providers)
        {
            bool on = false;
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            //Si está null significa que no existe en la base de datos con lo cual puede añadir un nuevo proveedor
            var storeInBD = dbcontext.Temp_Providers.Where(i => i.ProviderCode == providers).FirstOrDefault();

            try
            {
                if (storeInBD != null)
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

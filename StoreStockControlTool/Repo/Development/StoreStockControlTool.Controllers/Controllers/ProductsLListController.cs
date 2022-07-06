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
    public class ProductsListController
    {
        public List<Products> GetAllProducts()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Products.ToList();
        }


        public void AddProductsProviders(ProductsProviders products)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            dbcontext.ProductsProviders.Where(i => i.Reference == products.Reference).FirstOrDefault();

            try
            {
                dbcontext.Entry(products).State = EntityState.Added;
                dbcontext.SaveChanges();
            }
            catch (Exception)
            {
            }
        }
    }
}

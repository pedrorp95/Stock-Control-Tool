using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VLStoreModel.Model;

namespace StoreStockControlTool.Controllers.Controllers
{
    public class InventoryController
    {
        //                  ***COMBOS***
        public List<Stores> GetStores()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Stores.ToList();
        }

        public List<Temp_Employees> GetUsers()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Temp_Employees.ToList();
        }


        public List<Inventory> GetInventories(ExpressionStarter<Inventory> predicate)
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            try
            {
                List<Inventory> listInventory = dbcontext.Inventory.Where(predicate).ToList();


                //.OrderByDescending(e => e.InventoryDate).ToList();


                listInventory.OrderByDescending(x => x.InventoryDate).ToList();

                

                return listInventory;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<vInventoryProducts> GetInventoryProducts(ExpressionStarter<vInventoryProducts> predicate2)
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            try
            {
                List<vInventoryProducts> listInventoryProducts = dbcontext.vInventoryProducts.Where(predicate2).ToList();
                return listInventoryProducts;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Inventory> GetWithoutEnter()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Inventory.ToList();
        }

    }
}
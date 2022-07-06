using LinqKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VLStoreModel.Model;

namespace StoreStockControlTool.Controllers.Controllers
{
    public class RegularizationController
    {
        //                                 ***LOAD COMBOS***
        public List<Stores> GetStores()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Stores.ToList();
        }

        public List<Temp_Employees> GetOwners()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Temp_Employees.ToList();
        }

        //                                 ***LOAD CFG***
        public List<Regularizations> GetRegularizations(ExpressionStarter<Regularizations> predicate)
        {

            VLStoreManagementString dbcontext = new VLStoreManagementString();
            try
            {
                List<Regularizations> listproducts = dbcontext.Regularizations.Where(predicate).ToList();
                return listproducts;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<Regularizations> GetWithoutenter()
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Regularizations.ToList();
        }

        //                                 ***LOAD VIEW***
        public List<vRegularizationProducts> GetRegularizationProducts(ExpressionStarter<vRegularizationProducts> predicate2)
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            try
            {
                List<vRegularizationProducts> listrproducts = dbcontext.vRegularizationProducts.Where(predicate2).ToList();
                return listrproducts;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

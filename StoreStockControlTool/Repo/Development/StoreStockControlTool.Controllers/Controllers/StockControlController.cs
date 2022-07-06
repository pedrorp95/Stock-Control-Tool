using AutoMapper;
using LinqKit;
using StoreStockControlTool.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VLStoreModel.Model;

namespace StoreStockControlTool.Controllers.Controllers
{
    public class StockControlController
    {
        internal IMapper mapper;
        public List <Stores> GetStores()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Stores.ToList();
        }
        public List<StoreLocations> GetStoresLocations(int idStore)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            try
            {
                List<StoreLocations> listStoresLocations = dbcontext.StoreLocations.Where(l => l.IdStore == idStore).ToList();
                return listStoresLocations;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<VStockControl> GetProductsInStore(ExpressionStarter<VStockControl> predicate)
        {
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            try
            {
                List<VStockControl> scontrol = dbcontext.StockControl.ToList();

                return scontrol.Where(predicate).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<VStockControl> GetWithoutEnter()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.StockControl.ToList();
        }
    }
}
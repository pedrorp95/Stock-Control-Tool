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
    public class StoresManagementController
    {

        #region ChargeControls
        //ComboBox code
        public List<Temp_Employees> GetAllOwners()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Temp_Employees.ToList();
        }

        //ComboBox areas
        public List<Temp_Areas> GetAllAreas()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Temp_Areas.ToList();
        }

        //Search Filter
        public List<Stores> GetAllStores(ExpressionStarter<Stores> predicate)
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            try
            {
                List<Stores> listStores = dbcontext.Stores.Where(predicate).ToList();
                return listStores;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<Stores> GetWithoutEnter()
        {
            //Connection to  VLStoreManagement db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            return dbcontext.Stores.ToList();
        }
        //Locations
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
        #endregion

        #region StoreEvents
        //Button edit
        public void EditStores(Stores store)
        {

            VLStoreManagementString dbcontext = new VLStoreManagementString();
            var storeInBD = dbcontext.Stores.Where(i => i.IdStore == store.IdStore).FirstOrDefault();
            storeInBD.StoreName = store.StoreName;
            storeInBD.Owner = store.Owner;
            storeInBD.Area = store.Area;
            dbcontext.Set<Stores>().AddOrUpdate(storeInBD);
            dbcontext.SaveChanges();
        }

        //Button add
        public void AddStores(Stores store)
        {

            VLStoreManagementString dbcontext = new VLStoreManagementString();
            var storeInBD = dbcontext.Stores.Where(i => i.IdStore == store.IdStore).FirstOrDefault();
            try
            {
                dbcontext.Entry(store).State = EntityState.Added;


                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }
        //Button delete
        public void DeleteStores(Stores store)
        {
            //Connection to db
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            //Relation betweenp tables
            var storeInBD = dbcontext.Stores.Where(i => i.IdStore == store.IdStore).FirstOrDefault();
            try
            {
                dbcontext.Stores.Remove(storeInBD);
                dbcontext.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }

        public bool CompareStores(int store)
        {
            bool on = false;
            VLStoreManagementString dbcontext = new VLStoreManagementString();
            //Si está null significa que no se repite
            var storeInBD = dbcontext.Stores.Where(i => i.IdStore == store).FirstOrDefault();

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
        #endregion
    }
}
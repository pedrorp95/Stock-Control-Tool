using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VLStoreModel.Model;

namespace VLStoreModel.Infraestructure
{
    internal class DBFactory : Disposable, IDbFactory
    {
        #region Attributes
        VLStoreManagementString db;
        //Database db;
        #endregion Attributes

        public VLStoreManagementString Init()
        {
            //string conectionString = ReadConectionString(Constants.PATH_CONFIG_FILE);
            //return db ?? (db = new Database(ReadConectionString(Constants.PATH_CONFIG_FILE), DatabaseType.SqlServer2012));
            return db ?? (db = new VLStoreManagementString());
        }

        public VLStoreManagementString NewTemporaryConnection()
        {
            //string conectionString = ReadConectionString(Constants.PATH_CONFIG_FILE);
            //return db ?? (db = new Database(ReadConectionString(Constants.PATH_CONFIG_FILE), DatabaseType.SqlServer2012));
            return new VLStoreManagementString();
        }

        private static String GetConnectionString()
        {
            SqlConnectionStringBuilder scsb = new System.Data.SqlClient.SqlConnectionStringBuilder(ReadConectionString(Constants.PATH_CONFIG_FILE));

            EntityConnectionStringBuilder ecb = new EntityConnectionStringBuilder();
            ecb.Metadata = "res://*/Model.VLRGModel.csdl|res://*/Model.VLRGModel.ssdl|res://*/Model.VLRGModel.msl";
            ecb.Provider = "System.Data.SqlClient";
            ecb.ProviderConnectionString = scsb.ConnectionString;
            return ecb.ConnectionString;
        }

        public static string ReadConectionString(string prmStrPathConfig)
        {
            string conectionString = string.Empty;

            try
            {
                // Open the text file using a stream reader
                using (StreamReader sr = new StreamReader(prmStrPathConfig))
                {
                    // Read the stream to a string, and write the string to the console
                    string strConfig = Base64Utility.Base64Decode(sr.ReadToEnd());
                    XDocument doc = XDocument.Parse(strConfig);
                    var elementConnectionString = doc.Descendants("parameter").First(el => el.Attribute("name").Value == "CadenaDeConexion.NET.VirtualLab2019");
                    conectionString = string.Format(elementConnectionString.Attribute("value").Value, Constants.DB_USER, Constants.DB_PASS);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return conectionString;
        }

        protected override void DisposeCore()
        {
            if (db != null)
            {
                db.Dispose();
            }
        }
    }
}

using System;
using VLStoreModel.Model;

namespace VLStoreModel.Infraestructure
{
    internal interface IDbFactory : IDisposable
    {
        VLStoreManagementString Init();
        VLStoreManagementString NewTemporaryConnection();
    }
}

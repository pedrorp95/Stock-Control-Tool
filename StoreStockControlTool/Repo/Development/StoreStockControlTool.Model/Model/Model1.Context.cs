//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VLStoreModel.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class VLStoreManagementString : DbContext
    {
        public VLStoreManagementString()
            : base("name=VLStoreManagementString")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InventoryProducts> InventoryProducts { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<ProductsProviders> ProductsProviders { get; set; }
        public virtual DbSet<ProductTypes> ProductTypes { get; set; }
        public virtual DbSet<RegularizationProducts> RegularizationProducts { get; set; }
        public virtual DbSet<Regularizations> Regularizations { get; set; }
        public virtual DbSet<StoreLocations> StoreLocations { get; set; }
        public virtual DbSet<Stores> Stores { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Temp_Employees> Temp_Employees { get; set; }
        public virtual DbSet<Temp_Providers> Temp_Providers { get; set; }
        public virtual DbSet<Temp_Areas> Temp_Areas { get; set; }
        public virtual DbSet<VStockControl> StockControl { get; set; }
        public virtual DbSet<vInventoryProducts> vInventoryProducts { get; set; }
        public virtual DbSet<vRegularizationProducts> vRegularizationProducts { get; set; }
    }
}

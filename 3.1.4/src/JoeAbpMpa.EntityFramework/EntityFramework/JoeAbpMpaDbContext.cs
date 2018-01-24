using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using JoeAbpMpa.Authorization.Roles;
using JoeAbpMpa.Authorization.Users;
using JoeAbpMpa.Entities;
using JoeAbpMpa.MultiTenancy;

namespace JoeAbpMpa.EntityFramework
{
    public class JoeAbpMpaDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public IDbSet<Device> Devices { get; set; }

        public IDbSet<AssetCategory> AssetCategories { get; set; }

        public IDbSet<AssetStatus> AssetStatuses { get; set; }

        public IDbSet<Department> Department { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public JoeAbpMpaDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in JoeAbpMpaDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of JoeAbpMpaDbContext since ABP automatically handles it.
         */
        public JoeAbpMpaDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public JoeAbpMpaDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public JoeAbpMpaDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}

using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using JoeAbpMpa.EntityFramework;

namespace JoeAbpMpa
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(JoeAbpMpaCoreModule))]
    public class JoeAbpMpaDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<JoeAbpMpaDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

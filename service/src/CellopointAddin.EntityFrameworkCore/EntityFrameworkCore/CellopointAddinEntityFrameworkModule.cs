using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using CellopointAddin.EntityFrameworkCore.Seed;

namespace CellopointAddin.EntityFrameworkCore
{
    [DependsOn(
        typeof(CellopointAddinCoreModule),
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class CellopointAddinEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        public override void PreInitialize()
        {
            if (!SkipDbContextRegistration) {
                Configuration.Modules.AbpEfCore().AddDbContext<CellopointAddinDbContext>(options => {
                    if (options.ExistingConnection != null) {
                        CellopointAddinDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    } else {
                        CellopointAddinDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }
                });
            }

            Configuration.UnitOfWork.IsTransactional = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CellopointAddinEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            if (!SkipDbSeed) {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}

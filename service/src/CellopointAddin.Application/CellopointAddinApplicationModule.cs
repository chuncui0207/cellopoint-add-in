using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CellopointAddin.Authorization;

namespace CellopointAddin
{
    [DependsOn(
        typeof(CellopointAddinCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CellopointAddinApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CellopointAddinAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CellopointAddinApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

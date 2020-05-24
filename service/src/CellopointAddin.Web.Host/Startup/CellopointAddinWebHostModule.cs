using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CellopointAddin.Configuration;

namespace CellopointAddin.Web.Host.Startup
{
    [DependsOn(
       typeof(CellopointAddinWebCoreModule))]
    public class CellopointAddinWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CellopointAddinWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CellopointAddinWebHostModule).GetAssembly());
        }
    }
}

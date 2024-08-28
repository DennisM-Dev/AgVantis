using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AgVantis.Configuration;

namespace AgVantis.Web.Host.Startup
{
    [DependsOn(
       typeof(AgVantisWebCoreModule))]
    public class AgVantisWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AgVantisWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AgVantisWebHostModule).GetAssembly());
        }
    }
}

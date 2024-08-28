using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AgVantis.Authorization;

namespace AgVantis
{
    [DependsOn(
        typeof(AgVantisCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AgVantisApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AgVantisAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AgVantisApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AgVantis.EntityFrameworkCore;
using AgVantis.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AgVantis.Web.Tests
{
    [DependsOn(
        typeof(AgVantisWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AgVantisWebTestModule : AbpModule
    {
        public AgVantisWebTestModule(AgVantisEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AgVantisWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AgVantisWebMvcModule).Assembly);
        }
    }
}
using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AgVantis.Controllers
{
    public abstract class AgVantisControllerBase: AbpController
    {
        protected AgVantisControllerBase()
        {
            LocalizationSourceName = AgVantisConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

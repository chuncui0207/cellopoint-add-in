using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace CellopointAddin.Controllers
{
    public abstract class CellopointAddinControllerBase: AbpController
    {
        protected CellopointAddinControllerBase()
        {
            LocalizationSourceName = CellopointAddinConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

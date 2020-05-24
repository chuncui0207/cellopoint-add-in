using Abp.AspNetCore.Mvc.ViewComponents;

namespace CellopointAddin.Web.Views
{
    public abstract class CellopointAddinViewComponent : AbpViewComponent
    {
        protected CellopointAddinViewComponent()
        {
            LocalizationSourceName = CellopointAddinConsts.LocalizationSourceName;
        }
    }
}

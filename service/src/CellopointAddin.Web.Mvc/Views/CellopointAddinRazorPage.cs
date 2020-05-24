using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace CellopointAddin.Web.Views
{
    public abstract class CellopointAddinRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected CellopointAddinRazorPage()
        {
            LocalizationSourceName = CellopointAddinConsts.LocalizationSourceName;
        }
    }
}

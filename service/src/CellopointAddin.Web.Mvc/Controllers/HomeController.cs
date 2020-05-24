using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using CellopointAddin.Controllers;

namespace CellopointAddin.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : CellopointAddinControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}

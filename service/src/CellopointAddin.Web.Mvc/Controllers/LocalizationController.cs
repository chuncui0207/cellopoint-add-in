using CellopointAddin.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CellopointAddin.Web.Controllers
{
    public class LocalizationController: CellopointAddinControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

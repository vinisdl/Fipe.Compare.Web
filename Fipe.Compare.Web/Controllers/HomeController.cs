using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Fipe.Compare.IoC;
using Microsoft.AspNetCore.Mvc;

namespace Fipe.Compare.Web.Controllers
{
    public class HomeController : Controller
    {        
        public HomeController()
        {            
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}

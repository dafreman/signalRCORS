using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SignalRResearch.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FormsAuthentication.SetAuthCookie("sgrimes", true);
            
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
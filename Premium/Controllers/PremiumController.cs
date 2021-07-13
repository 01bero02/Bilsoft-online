using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Premium.Controllers
{
    public class PremiumController : Controller
    {
        // GET: Premium
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FeaturesPage()
        {
            return View();
        }

        public ActionResult ContactPage()
        {
            return View();
        }
    }
}
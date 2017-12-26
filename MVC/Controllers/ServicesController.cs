using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        public ActionResult Service()
        {
            return View();
        }
    }
}
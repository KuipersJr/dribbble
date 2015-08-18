using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dribbble.AspNetMvc.Controllers
{
    public class ShotController : Controller
    {
        // GET: Shot
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _Shot()
        {
            return PartialView();
        }
    }
}
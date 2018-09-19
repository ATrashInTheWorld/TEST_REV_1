using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TEST_REV_1.Models;

namespace TEST_REV_1.Controllers
{
    public class MainController : Controller
    {

        public ActionResult V1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult V1(FormCollection fc)
        {
            ViewData["theStr"] = fc["res"].ToString();
            ViewBag.radiRes = fc["na"].ToString();

            ModelA prints = new ModelA(fc["res"].ToString(), int.Parse(fc["num"]));
            
            return View(prints);
        }
        public ActionResult V2()
        {
            return View();
        }
        [HttpPost]
        public ActionResult V2(ModelB m)
        {
            ModelB mb = new ModelB(m.ans, m.ans2, m.ans3, m.ans4);
            return View("V3", mb);
        }

        public ActionResult V3()
        {
            return View();
        }
    }
}
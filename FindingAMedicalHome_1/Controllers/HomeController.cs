using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindingAMedicalHome_1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FindClinics()
        {
            ViewBag.Message = "Find Clinics page.";

            return View();
        }

        public ActionResult ViewDemographics()
        {
            ViewBag.Message = "Demographics page.";

            return View();
        }
    }
}
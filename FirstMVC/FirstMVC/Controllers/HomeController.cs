using FirstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var cars = HelloModel.GetCars();

            ViewBag.MainHeadline = "Main Headline";

            return View(cars);
        }
    }
}
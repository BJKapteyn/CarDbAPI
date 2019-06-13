using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {
        public CarsController carsController = new CarsController();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CarID(int id)
        {
            carsController.GetCar(id);
            return View($"~/api/{id}");
        }
    }
}

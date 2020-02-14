using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.repository;
using Travels.entity;


namespace MVC.Controllers
{
    public class TravelsController : Controller
    {
        TravelsRepository travelsRepository;

        public TravelsController()
        {
            travelsRepository = new TravelsRepository();
        }
        public ActionResult GetTravels()
        {
            IEnumerable<TravelsProperty> travels = travelsRepository.GetAllDetails();
            ViewData["travels"] = travels;
            ViewBag.travels = travels;
            TempData["travels"] = travels;
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;

namespace AutoBarn.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private SqlRepository<Make> _makeRepository;
        private SqlRepository<Model> _modelRepository;
        private SqlRepository<Service> _serviceRepository;

        public BookingController()
        {
            _makeRepository = new SqlRepository<Make>(new AutobarnContext());
            _modelRepository = new SqlRepository<Model>(new AutobarnContext());
            _serviceRepository = new SqlRepository<Service>(new AutobarnContext());
        }

        public JsonResult Makes()
        {
            var makes = _makeRepository.GetAll();
            return Json(makes, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Models(int id)
        {
            var models = _modelRepository.GetAll().Where(x => x.Make.Id == id);
            return Json(models, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Services(int id)
        {
            var services = _serviceRepository.GetAll().Where(x => x.Model.Id == id);
            return Json(services, JsonRequestBehavior.AllowGet);
        }

        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }
    }
}
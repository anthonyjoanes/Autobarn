using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;
using AutoBarn.WebUI.Models;

namespace AutoBarn.WebUI.Controllers
{
    public class BookingController : Controller
    {
        private readonly IRepository<Make> _makeRepository;
        private readonly IRepository<Model> _modelRepository;
        private readonly IRepository<Service> _serviceRepository;

        public BookingController(IRepository<Make> makeRepository, IRepository<Model> modelRepository, IRepository<Service> serviceRepository)
        {
            _makeRepository = makeRepository;
            _modelRepository = modelRepository;
            _serviceRepository = serviceRepository;
        }

        public JsonResult Makes()
        {
            var makes = _makeRepository.GetAll().ToList();
            return Json(makes, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Models(int id)
        {
            var models = _modelRepository.GetAll().Where(x => x.Make.Id == id).ToList();
            return Json(models, JsonRequestBehavior.AllowGet);
        }

        public JsonResult Services(int id)
        {
            var services = _serviceRepository.GetAll().Where(x => x.Model.Id == id).ToList();
            return Json(services, JsonRequestBehavior.AllowGet);
        }

        // GET: Booking
        public ActionResult New(int makeId = 0, int modelId = 0, int serviceId = 0)
        {
            var model = new BookingViewModel
            {   
                SelectedModel = new Model { Id=0, Make = new Make { Id=0} },
                SelectedService = new Service { Id = 0},
                Makes = _makeRepository.GetAll().ToList(),
                Models = _modelRepository.GetAll().ToList(),
                Services = _serviceRepository.GetAll().ToList()
            };

            if (makeId > 0)
            {
                var vehicleModel = _modelRepository.GetAll()
                    .Include(x => x.Make)
                    .Include(m => m.Services)
                    .First(x => x.Id == modelId);

                model.SelectedModel = vehicleModel;
                model.SelectedService = vehicleModel.Services.First(x => x.Id == serviceId);
            }

            return View(model);
        }
    }
}
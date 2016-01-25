using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;

namespace AutoBarn.WebUI.Areas.Admin.Controllers
{
    public class PricesController : Controller
    {
        private readonly IRepository<Model> _modelRepository;
        private readonly IRepository<Service> _serviceRepository;

        public PricesController(IRepository<Model> modelRepository, IRepository<Service> serviceRepository)
        {
            _serviceRepository = serviceRepository;
            _modelRepository = modelRepository;
        }

        // GET: Admin/Prices
        public ActionResult Index()
        {
            var fullModelList = _modelRepository.GetFullVehicleModel();
            return View(fullModelList);
        }

        public ActionResult Edit(int id)
        {
            var fullModelList = _modelRepository.GetFullVehicleModel().FirstOrDefault(x => x.Id == id);
            return View(fullModelList);
        }

        [HttpPost]
        public ActionResult Edit(Service model)
        {
            if (model == null)
                throw new ArgumentNullException();

            if (model.DealerPrice > 0 && model.Price > 0)
            {
                var service = _serviceRepository.Find(model.Id);

                service.DealerPrice = model.DealerPrice;
                service.Price = model.Price;

                _serviceRepository.Commit();

                return RedirectToAction("Index");
            }

            ModelState.AddModelError(string.Empty, "Please check there is a price for dealer and auto barn");

            return View();
        }
    }
}
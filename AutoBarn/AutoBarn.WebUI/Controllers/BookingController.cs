using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Caching;
using System.Web;
using System.Web.Mvc;
using AutoBarn.WebUI.Data;
using AutoBarn.WebUI.Data.Entities;
using AutoBarn.WebUI.Infrastructure;
using AutoBarn.WebUI.Infrastructure.Filters;
using AutoBarn.WebUI.Models;
using WebGrease.Css.Extensions;

namespace AutoBarn.WebUI.Controllers
{
    [ReviewInfoFilter]
    public class BookingController : Controller
    {
        private readonly IRepository<Make> _makeRepository;
        private readonly IRepository<Model> _modelRepository;
        private readonly IRepository<Service> _serviceRepository;
        private readonly IRepository<Contact> _contactRepository;
        private readonly IRepository<Booking> _bookingRepository;
        private readonly IBookingEmailService _bookingEmailService;
        private readonly IRepository<BlockDate> _blockDateRepository;

        public BookingController(IRepository<Make> makeRepository
            , IRepository<Model> modelRepository
            , IRepository<Service> serviceRepository
            , IRepository<Contact> contactRepository
            , IRepository<Booking> bookingRepository
            , IRepository<BlockDate> blockDateRepository
            , IBookingEmailService bookingEmailService)
        {
            _blockDateRepository = blockDateRepository;
            _bookingEmailService = bookingEmailService;
            _bookingRepository = bookingRepository;
            _makeRepository = makeRepository;
            _modelRepository = modelRepository;
            _serviceRepository = serviceRepository;
            _contactRepository = contactRepository;
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

        public JsonResult Service(int id)
        {
            var services = _serviceRepository.GetAll().First(x => x.Id == id);
            return Json(services, JsonRequestBehavior.AllowGet);
        }

        // GET: Booking
        public ActionResult New(int makeId = 0, int modelId = 0, int serviceId = 0)
        {
            ViewBag.CustomerReviews = MemoryCache.Default.Get("Review") as string;
            var model = new BookingViewModel
            {   
                SelectedModel = new Model { Id=0, Make = new Make { Id=0} },
                SelectedService = new Service { Id = 0},
                Makes = _makeRepository.GetAll().ToList(),
                Models = _modelRepository.GetAll().Where(x=>x.Make.Id== makeId).ToList(),
                Services = _serviceRepository.GetAll().Where(x=>x.Model.Id== modelId).ToList()
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

        public JsonResult BlockDates()
        {
            var queryDate = DateTime.Now.AddDays(-1);
            var format = "yyyy-MM-dd";
            var dates = _blockDateRepository.GetAll().ToList().Select(x => x.Date.ToString(format));

            
            
            //var dates = new string[] { DateTime.Now.ToString(format), DateTime.Now.AddDays(5).ToString(format), DateTime.Now.AddDays(3).ToString(format) };

            return Json(dates, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Save(NewBookingViewModel model)
        {
            ViewBag.CustomerReviews = MemoryCache.Default.Get("Review") as string;
            // See if its existing Contact

            var contact =
                _contactRepository
                    .GetAll().FirstOrDefault(c => c.Email == model.Contact.Email && c.Registration == model.Contact.Registration);

            if (contact == null)
            {
                contact = new Contact
                {
                    Firstname = model.Contact.Firstname,
                    Lastname = model.Contact.Lastname,
                    Email = model.Contact.Email,
                    Telephone = model.Contact.Telephone,
                    ModelId = model.SelectedModel.Id,
                    Registration = model.Contact.Registration
                };

                _contactRepository.Add(contact);
                _contactRepository.Commit();
            }

            var booking = new Booking
            {
                ModelId = model.SelectedModel.Id,
                ServiceId = model.SelectedService.Id,
                Date = model.BookingDate,
                Contact = contact,
                Notes = model.Notes
            };

            _bookingRepository.Add(booking);

            _bookingRepository.Commit();

            

            _bookingEmailService.SetHtmlString(Server.MapPath("~/App_Data/bookingconfirmation.html"));
            _bookingEmailService.SetPlaceholders(contact.Firstname, contact.Registration, booking.Date.ToShortDateString(), booking.Notes);
            _bookingEmailService.CreateMessage(contact.Email);
            _bookingEmailService.SendEmail();

            return RedirectToAction("ThankYou", new { id = booking.Id});
        }

        public ActionResult ThankYou(int id = 0)
        {
            ViewBag.CustomerReviews = MemoryCache.Default.Get("Review") as string;
            var booking = _bookingRepository.GetAll()
                .Include(x => x.Model)
                .Include(x => x.Model.Make)
                .Include(x => x.Service)
                .Include(x => x.Contact).FirstOrDefault(x => x.Id == id);


            return View(booking);
        }
    }
}
namespace AutoBarn.WebUI.Controllers
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Runtime.Caching;
    using System.Web.Mvc;
    using AutoBarn.WebUI.Data;
    using AutoBarn.WebUI.Data.Entities;
    using AutoBarn.WebUI.Models;
    using AutoBarn.WebUI.Services;

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
            
            return Json(dates, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Save a new booking submission from the Booking form page
        /// </summary>
        /// <param name="model">The Booking view model.</param>
        /// <returns></returns>
        public ActionResult Save(NewBookingViewModel model)
        {
            if (model.BookingDate == null)
            {
                throw new Exception("The booking date was null");
            }

            // obfuscate the identity fields for contacts now
            // we shouldn't store user data anymore as part of the
            // new GDPR rules, more work involved if we want to start
            // doing things with the users data
            var contact = new Contact
            {
                Firstname = "XXXXXXX",
                Lastname = "XXXXXXX",
                Email = "XXXXXXX",
                Telephone = "XXXXXXX",
                ModelId = model.SelectedModel.Id,
                Registration = "XXXXXXXXXX"
            };

            _contactRepository.Add(contact);
            _contactRepository.Commit();
            
            var booking = new Booking
            {
                ModelId = model.SelectedModel.Id,
                ServiceId = model.SelectedService.Id,
                Date = model.BookingDate,
                Contact = contact,
                Notes = string.IsNullOrEmpty(model.Notes) ? string.Empty : model.Notes
            };

            _bookingRepository.Add(booking);

            _bookingRepository.Commit();
           
            _bookingEmailService.SetHtmlString(Server.MapPath("~/App_Data/bookingconfirmation.html"));
            _bookingEmailService.SetPlaceholders(booking.Id, model.Contact.Firstname, model.Contact.Registration, booking.Date, booking.Notes);
            _bookingEmailService.CreateMessage(model.Contact.Email);
            _bookingEmailService.CreateAutoBarnMessage(model.Contact.Firstname, model.Contact.Lastname, model.Contact.Email, model.Contact.Telephone);
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoBarn.WebUI.Data.Entities;

namespace AutoBarn.WebUI.Models
{
    public class BookingViewModel
    {
        public Contact Contact { get; set; }
        public Booking Booking { get; set; }
        public Model SelectedModel { get; set; }
        public Service SelectedService { get; set; }
        public IList<Model> Models { get; set; }
        public IList<Make> Makes { get; set; }
        public IList<Service> Services { get; set; }
    }

    public class NewBookingViewModel
    {
        public Contact Contact { get; set; }
        public Model SelectedModel { get; set; }
        public Service SelectedService { get; set; }
        public DateTime BookingDate { get; set; }
        public string Notes { get; set; }
    }
}
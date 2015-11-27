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
    }
}
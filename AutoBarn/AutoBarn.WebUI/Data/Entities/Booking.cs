using System;

namespace AutoBarn.WebUI.Data.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public Model Model { get; set; }
        public Contact Contact { get; set; }
        public int ServiceId { get; set; }
        public Service Service { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
    }
}s
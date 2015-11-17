using System.Collections.Generic;
using System.Reflection;

namespace AutoBarn.WebUI.Data.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Make Make { get; set; }
        public ICollection<Service> Services { get; set; }
    }

    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal DealerPrice { get; set; }
        public Model Model { get; set; }
    }
}
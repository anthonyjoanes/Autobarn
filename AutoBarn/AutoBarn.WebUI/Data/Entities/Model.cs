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
}
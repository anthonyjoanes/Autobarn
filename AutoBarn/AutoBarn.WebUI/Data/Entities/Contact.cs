using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AutoBarn.WebUI.Data.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Registration { get; set; }
        public Model Model { get; set; }
        public Service Service { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CardSharkWebApp.Models
{
    public partial class Organization
    {
        public int id { get; set; }
        public List<Event> Events { get; set; }
        public string Name { get; set; }

        public Organization()
        {
            this.Events = new List<Event>();
        }
    }
}
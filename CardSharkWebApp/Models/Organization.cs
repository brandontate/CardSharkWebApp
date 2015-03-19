using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardSharkWebApp2.Models
{
    public partial class Organization
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Event> Events { get; set; }
        
        public Organization()
        {
            this.Events = new List<Event>();
        }
    }
}
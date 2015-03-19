using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardSharkWebApp2.Models
{
    public partial class Event
    {
        public int ID { get; set; }
        public List<Match> Matches { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

        public int OrganizationID { get; set; }

        public Event()
        {
            this.Matches = new List<Match>();
        }
    }
}
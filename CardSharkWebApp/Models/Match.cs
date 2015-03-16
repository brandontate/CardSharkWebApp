using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CardSharkWebApp.Models
{
    public partial class Match
    {
        public int ID { get; set; }
        public string FirstOppenent { get; set; }
        public string SecondOppenent { get; set; }
        public string Winner { get; set; }

        public int EventID { get; set; }


        public Match()
        {

        }
    }
}
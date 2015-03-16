using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CardSharkWebApp.Models
{
    public partial class Prediction
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string Guess { get; set; }

        public int MatchID { get; set; }

        public Prediction()
        {

        }
    }
}
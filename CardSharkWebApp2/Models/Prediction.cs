using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CardSharkWebApp2.Models
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
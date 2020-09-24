using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumDataProject.Models
{
    public class OccupationRatings
    {
        public int OccupationRatingId { get; set; }
        public string OccupationName { get; set; }
        public decimal Factor { get; set; }
    }
}
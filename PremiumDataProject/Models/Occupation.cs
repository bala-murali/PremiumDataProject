using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumDataProject.Models
{
    public class Occupation
    {
        public int Id { get; set; }
        public string OccupationName { get; set; }
        public decimal OccupationRating { get; set; }
    }
}
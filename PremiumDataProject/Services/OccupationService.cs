using PremiumDataProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PremiumDataProject.Services
{
    public class OccupationService
    {
        List<Occupation> occupations;
        List<OccupationRatings> occupationsRating;
        public IEnumerable<Occupation> GetOccupationsList()
        {
            occupations = new List<Occupation>();
            occupations.Add(new Occupation { Id = 1, OccupationName = "Cleaner", OccupationRating = 1.50M });
            occupations.Add(new Occupation { Id = 2, OccupationName = "Doctor", OccupationRating = 1M });
            occupations.Add(new Occupation { Id = 3, OccupationName = "Author", OccupationRating = 1.25M });
            occupations.Add(new Occupation { Id = 4, OccupationName = "Farmer", OccupationRating = 1.75M });
            occupations.Add(new Occupation { Id = 5, OccupationName = "Mechanic", OccupationRating = 1.75M });
            occupations.Add(new Occupation { Id = 6, OccupationName = "Florist", OccupationRating = 1.50M });

            return occupations;
        }

        public IEnumerable<OccupationRatings> GetOccupationsRatingList()
        {
            occupationsRating = new List<OccupationRatings>();
            occupationsRating.Add(new OccupationRatings { OccupationRatingId = 1, OccupationName = "Professional", Factor = 1.0M });
            occupationsRating.Add(new OccupationRatings { OccupationRatingId = 2, OccupationName = "White Collar", Factor = 1.25M });
            occupationsRating.Add(new OccupationRatings { OccupationRatingId = 3, OccupationName = "Light Manual", Factor = 1.5M });
            occupationsRating.Add(new OccupationRatings { OccupationRatingId = 4, OccupationName = "Heavy Manual", Factor = 1.75M });

            return occupationsRating;
        }

        public IEnumerable<Occupation> GetOccupationsById(int RateId)
        {
            var occupationList = GetOccupationsList();
            var result = occupationList.Where(_ => _.Id == RateId);
                           
            return result;
        }
    }
}
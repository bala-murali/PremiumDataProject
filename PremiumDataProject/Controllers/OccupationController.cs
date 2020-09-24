using PremiumDataProject.Models;
using PremiumDataProject.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PremiumDataProject.Controllers
{
    
    public class OccupationController : ApiController
    {
        List<Occupation> occupations;
        public OccupationController()
        {
            occupations = new List<Occupation>();
            occupations.Add(new Occupation { Id = 1, OccupationName = "Test1",  OccupationRating = 2 });
            occupations.Add(new Occupation { Id = 2, OccupationName = "Test2", OccupationRating = 3 });
        }

        [HttpGet, Route("api/occupation/get")]
        public IEnumerable<Occupation> Get()
        {
            OccupationService o = new OccupationService();
            return o.GetOccupationsList();
        }

        [HttpGet, Route("api/occupation/getbyid/{id:int}")]
        public IEnumerable<Occupation> GetById(int id)
        {
            OccupationService o = new OccupationService();
            var result = o.GetOccupationsById(id);
            return result;
        }
    }
}

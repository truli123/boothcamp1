using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication5.Controllers
{
    public class Club : ApiController
    {
        // GET: api/novo1
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/novo1/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/novo1
        

        public class Clubs

        {
            List<Club> clubs;

        }

        static List<Club> clubs = new List<Club>();
       
       [HttpPost]

        [Route("webapi/newclub")]
        /*
        public string InsertNewClub(Club newClub)
        {

            clubs.Add(newClub);
            Club club = new Club();
            club.ClubId = clubs.Last().ClubId;
            club.Name = clubs.Last().Name;
            club.City = clubs.Last().City;
            club.Country = clubs.Last().Country;
            club.Stadium = clubs.Last().Stadium;
            return $"A new club is  {club.Name} {club.city} from {club.Country}";
        }
        */
        // PUT: api/novo1/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/novo1/5
        public void Delete(int id)
        {
        }
    }
}

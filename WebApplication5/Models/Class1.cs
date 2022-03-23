using System;

namespace WebApplication1.Controllers
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string LastName { get; set; }

        public string PlayerClub { get; set; }
    }
   
     public class Club
    {
        public int ClubId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Counry { get; set; }

        public string Stadium { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {

        
        // GET api/values
        [HttpGet]

        [Route("api/players")]
        public string Get()

        {

            return $"There are {players.Count} playing football.";
        }

        // GET api/values/5
        
        [HttpGet]

        [Route("webapi/getplayer")]
        public string ReturnPlayerName(int id)
        {

            Player foundPlayer = players.Find(player => player.Id == id);
            return $"The Player with the id#{id} is {foundPlayer.Name} {foundPlayer.LastName}";

        }
        
        //POST api/values
       
        public class Players

        {
            List<Player> players;
        }

        static List<Player> players = new List<Player>();

        [HttpPost]

        [Route("webapi/newplayer")]
        public string InsertNewPlayer(Player newPlayer)  
        {
            players.Add(newPlayer);
            Player player = new Player();
            player.Id =players.Last().Id;
            player.Name = players.Last().Name;
            player.LastName = players.Last().LastName;
            player.PlayerClub = players.Last().PlayerClub;
            return $"A new player  {player.Name} {player.LastName} igra za klub {player.PlayerClub}" ;
        }


        
        // PUT api/values/5
        [HttpPut]

/*
        public string UpdatePlayerStatus(int id)
        {
            
        }
        */
        // DELETE api/values/5

        [HttpDelete]
        public string DeletePlayerFromRecords([FromBody] int id)
        {
            Player deletedEmployee = players.Find(player => player.Id == id);
            players.Remove(deletedEmployee);
            return "You have player!";
        }

    }
}


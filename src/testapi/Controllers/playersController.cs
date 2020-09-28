using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using testApi;

namespace testapi.Controllers
{
    [Route("api/players")]
    [ApiController]
    public class playersController : ControllerBase
    {
        // GET api/players
        [HttpGet]
        public ActionResult<IEnumerable<players>> Get()
        {
            List<players> playersList = getPlayerList();
            return playersList;
        }

        // GET api/players/5
        [HttpGet("{username}")]
        public ActionResult<players> Get(string username)
        {
            List<players> playersList = getPlayerList();
            return playersList.Find(i => i.UserName == username);


        }

        // PUT api/player/5
        /*[HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            
        }*/





        public List<players> getPlayerList()
        {
            List<players> playersList = new List<players>();

            var result = JObject.Parse(
                        System.IO.File.ReadAllText("../../players.json")
            );

            var items = result["players"].Children().ToList();


            foreach (var sub in items)
            {
                playersList.Add(sub.ToObject<players>());
                Console.WriteLine("\n\n\n" + sub + "\n\n\n");
            }
            return playersList;
        }

        
    }
}

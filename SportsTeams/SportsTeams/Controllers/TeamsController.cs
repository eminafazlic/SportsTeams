using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsTeams.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeamsController : ControllerBase
    {
     
        private static List<Teams> _teams;

        static TeamsController()
        {
            _teams = new List<Teams>()
            {
                 new Teams()
                {
                    Id=1,
                    Name="Team1"
                },
                new Teams()
                {
                    Id=2,
                    Name="Team2"
                }
            };

        }
        [HttpGet]
        public IEnumerable<Teams> Get()
        {
            return _teams;
        }
        [HttpGet(template:"{id}")]
        public Teams GetById(int id)
        {
            return _teams.FirstOrDefault(x => x.Id == id);
        }
        [HttpPost]
        public Teams Insert(Teams teams)
        {
            _teams.Add(teams);
            return teams;
        }
        [HttpPut(template:"{id}")]
        public Teams Update(int id, Teams teams)
        {
            var current= _teams.FirstOrDefault(x => x.Id == id);
            current.Name = teams.Name;
            return current;
        }
    }
    
}

//public class Teams
//{
//    public int Id { get; set; }

//    public string Name { get; set; }
//}
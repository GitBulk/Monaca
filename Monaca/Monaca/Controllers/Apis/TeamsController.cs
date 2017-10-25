using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Monaca.Models;

namespace Monaca.Controllers.Apis
{
    [Route("api/[controller]")]
    public class TeamsController : BaseApiController
    {
        // [HttpGet]
        // public IActionResult GetTeams()
        // {
        //     return OkContent(Enumerable.Empty<Team>());
        // }

        public IEnumerable<Team> GetTeams()
        {
            return new Team[]
            {
                new Team("one"),
                new Team("two")
            };
        }

        public void CreateTeam(Team newTeam)
        {
            throw new NotImplementedException();
        }
    }
}
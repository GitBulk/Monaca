using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Monaca.Models;

namespace Monaca.Controllers.Apis
{
    [Route("api/[controller]")]
    public class TeamsController : BaseApiController
    {
        [HttpGet]
        public IActionResult GetTeams()
        {
            return OkContent(Enumerable.Empty<Team>());
        }
    }
}
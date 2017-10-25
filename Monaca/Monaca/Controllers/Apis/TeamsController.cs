using Microsoft.AspNetCore.Mvc;

namespace Monaca.Controllers.Apis
{
    [Route("api/[controller]")]
    public class TeamsController : BaseApiController
    {
        [HttpGet]
        public IActionResult GetTeams()
        {
            return OkContent("kaka");
        }
    }
}
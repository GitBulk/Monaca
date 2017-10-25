using Microsoft.AspNetCore.Mvc;

namespace Monaca.Controllers.Apis
{
    public class BaseApiController : Controller
    {
        public IActionResult OkContent(string message)
        {
            var json = new
            {
                data = new
                {
                    message = message
                }
            };

            return Ok(json);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using WebBase.Api.Controllers.Base;

namespace WebBase.Api.Controllers
{
    [Route("api/main")]
    public class MainController : BaseController
    {
        public MainController()
        {
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
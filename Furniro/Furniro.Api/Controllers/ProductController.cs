using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Furniro.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult HelloWorld()
        {
            return Ok("HelloWorld");
        }
    }
}

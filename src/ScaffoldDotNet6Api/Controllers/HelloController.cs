using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ScaffoldDotNet6Api.Controllers
{

    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok("Hello World!");
        }
    }
}

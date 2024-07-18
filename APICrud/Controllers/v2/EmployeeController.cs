using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;

namespace APICrud.Controllers.v2
{
    [ApiVersion(2.0)]
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("User V2");
        }
    }
}

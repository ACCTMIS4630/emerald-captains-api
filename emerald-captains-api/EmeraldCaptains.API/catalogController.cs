using Microsoft.AspNetCore.Mvc;
using EmeraldCaptains.Domain.Catalog;

namespace EmeraldCaptains.API.Controllers 
{
    [ApiController]
    [Route("catalog")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("Hello World");
        }
    }
}

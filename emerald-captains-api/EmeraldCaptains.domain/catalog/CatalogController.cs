using Microsoft.AspNetCore.Mvc;
using EmeraldCaptains.Domain.Catalog;

namespace EmeraldCaptains.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetItems()
        {
            return Ok("Hello World!");
        }
    }
}
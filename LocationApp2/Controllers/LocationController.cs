using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationApp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        public LocationController()
        {

        }
        [HttpGet]
        public async Task<IActionResult> GetAllLocations()
        {
            await Task.CompletedTask;
            return Ok("test");
        }
    }
}

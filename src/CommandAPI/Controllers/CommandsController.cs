using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CommandAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"This", "is", "hard", "coded"};
        }

        [HttpGet]
        [Route("show-results")]
        public async Task<IActionResult> GetResultAsync()
        {
            string[] returnVal = new string[] {"This", "is", "hard", "coded"};
            return Ok(returnVal);
        }
    }
}
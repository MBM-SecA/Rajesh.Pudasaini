using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EMSApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //attribute routing
    public class ValueController : ControllerBase
    {
        

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] {"value1", "value2"};
        }
    }
}

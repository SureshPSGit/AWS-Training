using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AWS_Training.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        public HelloWorldController()
        {

        }

        [HttpGet]
        public string Get()
        {
            return "Hello World application is up and running";
        }
    }
}

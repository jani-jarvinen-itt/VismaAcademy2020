using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiTest.Controllers
{
    [Route("api/testi")]
    [ApiController]
    public class TestiApiController : ControllerBase
    {
        [HttpGet]
        [HttpPost]
        public string Hello()
        {
            return "Moi ASP.NET Web API:sta!";
        }

        [HttpPut]
        public string Hello2()
        {
            return "Toinen versio metodista";
        }
    }
}

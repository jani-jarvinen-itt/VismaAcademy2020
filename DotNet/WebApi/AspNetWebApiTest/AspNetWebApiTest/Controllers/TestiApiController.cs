using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiTest.Controllers
{
    [Route("api/v1/testi")]
    [Route("api/v2/testi")]
    [ApiController]
    public class TestiApiController : ControllerBase
    {
        /*
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
        */

        [Route("Metodi1")]
        [HttpPut]
        public string Metodi1()
        {
            return "Tämä on metodi 1";
        }

        [Route("Metodi2")]
        public string Metodi2()
        {
            return "Tämä on metodi 2";
        }

        [Route("Metodi3")]
        [Route("KummaMetodi")]
        public string Metodi3()
        {
            return "Tämä on metodi 3";
        }
    }
}

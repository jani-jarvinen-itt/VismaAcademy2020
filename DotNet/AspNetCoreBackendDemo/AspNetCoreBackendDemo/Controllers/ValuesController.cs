using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreBackendDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [Route("luvut")]
        [HttpGet]
        public int[] Luvut()
        {
            return new int[] { 1, 2, 3, 4 };
        }

        [Route("nimet")]
        [HttpPost]
        public string[] Nimet()
        {
            return new string[] { "Make", "Pena", "Kake" };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetWebApiTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiTest.Controllers
{
    [Route("api/asiakas")]
    [ApiController]
    public class AsiakasApiController : ControllerBase
    {
        [Route("")]
        [HttpGet]
        public List<Asiakas> KaikkiAsiakkaat()
        {
            return new List<Asiakas>()
            {
                new Asiakas()
                {
                    Id = 100,
                    Nimi = "Asiakas Oy 1",
                    Puhelin = "050 111111"
                },
                new Asiakas()
                {
                    Id = 101,
                    Nimi = "Asiakas Oy 2",
                    Puhelin = "050 2222222"
                }
            };
        }

        [Route("{id:int}")]
        [HttpGet]
        public Asiakas YksiAsiakas(int id)
        {
            return new Asiakas()
            {
                Id = id,
                Nimi = "Asiakas Oy " + id,
                Puhelin = "050 111111"
            };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetWebApiTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiTest.Controllers
{
    [Route("api/v1/testi")]
    [Route("api/v2/testi")]
    [ApiController]
    public class TestiApiController : ControllerBase
    {
        [Route("bool")]
        public bool KylläEi()
        {
            return true;
        }

        [Route("datetime")]
        public DateTime Nyt()
        {
            return DateTime.Now;
        }

        [Route("class")]
        public Asiakas Asiakas()
        {
            return new Asiakas()
            {
                Id = 1200,
                Nimi = "Yritys Oy",
                Puhelin = "019 200 480"
            };
        }


        /*
        [Route("parametrit/{id:int}")]
        public string ParametriTesti(int id)
        {
            return "Pyydetty luku-id: " + id;
        }

        [Route("parametrit/{id:alpha}")]
        public string ParametriTesti2(string id)
        {
            return "Pyydetty merkkijono-id: " + id;
        }

        [Route("kokeilu/{id}")]
        [HttpPost]
        public string ParametriKokeilu(string id)
        {
            bool isNumber = int.TryParse(id, out int idValue);
            if (isNumber)
            {
                return "Id-parametri on luku: " + idValue;
            }
            else
            {
                return "Id-parametri on merkkijono: " + id;
            }
        }
        */


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

        /*
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
        */

        /*
        [Route("ääkkönen")]
        public string Ääkköstesti()
        {
            return "Tämä on ääkköstesti-metodi 1";
        }

        [Route("Päällekkäinen")]
        public string Päällekkäinen2()
        {
            return "Tämä on päällekkäinen metodi 2";
        }
        */
    }
}

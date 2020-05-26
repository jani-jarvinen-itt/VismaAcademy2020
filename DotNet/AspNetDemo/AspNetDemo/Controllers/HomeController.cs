using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetDemo.Models;
using AspNetDemo.Logic;
using AspNetDemo.Interfaces;
using AspNetDemo.Entities;
using System.Net.Http;

namespace AspNetDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IDatabaseAccess db;

        public HomeController(ILogger<HomeController> logger,
            IDatabaseAccess database)
        {
            _logger = logger;
            db = database;
        }

        public IActionResult Index()
        {
            NorthwindContext context = new NorthwindContext();

            // List<Customers> asiakkaat = context.Customers.ToList();
            // query syntax
            List<Customers> suomalaiset = (from c in context.Customers
                                           where c.Country == "Finland"
                                           select c).ToList();

            // method syntax
            List<Customers> suomalaiset2 =
                context.Customers.Where(c => c.Country == "Finland").ToList();

            foreach (Customers asiakas in suomalaiset)
            {
                Console.WriteLine(asiakas.CompanyName);
            }


            //// IDatabaseAccess db = new DatabaseAccess();
            //Customer cust = db.FindById(1000);
            //// ...

            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            HttpClient client = new HttpClient();
            Task<string> taustatehtävä = client.GetStringAsync("https://www.gooogle.com/");

            int[] luvut = { 3, 8, 7, 10, 5, 4, 11, 6, 9 };

            // LINQ (query syntax)
            List<int> tulokset = (from l in luvut
                                  where l > 5
                                  orderby l
                                  select l).ToList();

            // LINQ (method syntax)
            List<int> tulokset2 = luvut.Where(l => l > 5).OrderBy(l => l).ToList();

            /*
            // hae viittä suuremmat numerojärjestyksessä
            List<int> tulokset = new List<int>();
            foreach (int luku in luvut)
            {
                if (luku > 5)
                {
                    tulokset.Add(luku);
                }
            }
            tulokset.Sort();
            foreach (int tulos in tulokset)
            {
                Console.WriteLine(tulos);
            }
            */


            string html = taustatehtävä.Result;


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

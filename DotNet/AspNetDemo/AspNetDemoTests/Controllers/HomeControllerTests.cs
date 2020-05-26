using Microsoft.VisualStudio.TestTools.UnitTesting;
using AspNetDemo.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using AspNetDemo.Logic;
using AspNetDemo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AspNetDemo.Models;

namespace AspNetDemo.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void IndexTest()
        {
            IDatabaseAccess db = new DatabaseAccess_Mock();
            HomeController controller = new HomeController(null, db);
            IActionResult result = controller.Index();
            Assert.IsNotNull(result);
        }
    }

    public class DatabaseAccess_Mock : IDatabaseAccess
    {
        public void AddNewCustomer(Customer customer)
        {
            return;
        }

        public Customer FindById(int id)
        {
            return new Customer()
            {
                CustomerId = id,
                CustomerName = "Yksikkötestaus Oy",
                Email = "info@yksikkotestaus.fi"
            };
        }
    }
}
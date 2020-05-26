using AspNetDemo.Interfaces;
using AspNetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetDemo.Logic
{
    public class DatabaseAccess : IDatabaseAccess
    {
        public Customer FindById(int id)
        {
            return new Customer()
            {
                CustomerId = id,
                CustomerName = "Yritys Oy",
                Email = "info@yritys.fi"
            };
        }

        public void AddNewCustomer(Customer customer)
        {
            // TODO: tietokantaan lisääminen
        }
    }
}

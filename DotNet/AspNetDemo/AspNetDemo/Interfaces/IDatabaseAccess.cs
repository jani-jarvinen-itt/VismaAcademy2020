using AspNetDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetDemo.Interfaces
{
    public interface IDatabaseAccess
    {
        public Customer FindById(int id);

        public void AddNewCustomer(Customer customer);
    }
}

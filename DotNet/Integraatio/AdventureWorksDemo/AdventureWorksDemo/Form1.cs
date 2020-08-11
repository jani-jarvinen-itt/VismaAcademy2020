using AdventureWorksDemo.Database.Adventure;
using AdventureWorksDemo.Database.Northwind;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddToLog(string message)
        {
            string line = $"{DateTime.Now.TimeOfDay}: {message}\r\n";
            logTextBox.Text += line;
            Application.DoEvents();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddToLog("Starting data copy.");

            AdventureWorks2016CTP3Entities adventureContext = new AdventureWorks2016CTP3Entities();
            NorthwindEntities northwindContext = new NorthwindEntities();

            int rows = 0;
            foreach (Database.Northwind.Customers nwCust in northwindContext.Customers)
            {
                string contact = nwCust.ContactName;
                string[] nameParts = contact.Split(' ');
                Database.Adventure.Person person = new Person()
                {
                    FirstName = nameParts[0],
                    LastName = nameParts[1],
                    // PersonPhone = nwCust.Phone
                    // ...
                };

                AddToLog($"Processing customer: {nwCust.CompanyName}...");
                adventureContext.Person.Add(person);
                rows++;

                if ((rows % 1000) == 0)
                {
                    //adventureContext.SaveChanges();
                }
            }

            //adventureContext.SaveChanges();
            AddToLog($"Data copy complete, {rows} rows copied.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdventureWorks2016CTP3Entities adventureContext = new AdventureWorks2016CTP3Entities();

            Vendor vendor = new Vendor
            {
                Name = "Uusi yritys Oy"
            };

            adventureContext.Vendor.Add(vendor);
            adventureContext.SaveChanges();

            /*
            Store newestStore = (from s in adventureContext.Store
                                 orderby s.BusinessEntityID descending
                                 select s).FirstOrDefault();
            */

            MessageBox.Show("Vendor ID = " + vendor.BusinessEntityID);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NorthwindEntities context = new NorthwindEntities();

            List<string> allCustomers =
                context.Customers.Select(c => c.CompanyName).ToList();

            listBox1.ItemsSource = allCustomers;
        }

        private void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string companyName = listBox1.SelectedItem.ToString();
            // MessageBox.Show(companyName);

            NorthwindEntities context = new NorthwindEntities();
            Customers customer = (from c in context.Customers
                                  where c.CompanyName == companyName
                                  select c).FirstOrDefault();

            this.DataContext = customer;

            //if (customer != null)
            //{
            //    customerIdTextBox.Text = customer.CustomerID;
            //    contactPersonTextBox.Text = customer.ContactName;
            //    cityTextBox.Text = customer.City;
            //}
        }
    }
}

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
using TestApp.Entities;

namespace TestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly List<Customer> _Customers = new List<Customer>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResetCustomer(object sender, RoutedEventArgs e)
        {
            TB_Id.Text = string.Empty;
            TB_Name.Text = string.Empty;
            TB_CustomerNumber.Text = string.Empty;
            TB_Country.Text = string.Empty;
            TB_City.Text = string.Empty;
            TB_Zipcode.Text = string.Empty;
            TB_Street.Text = string.Empty;
        }

        private void SaveCustomer(object sender, RoutedEventArgs e)
        {
            Customer customer = new Customer();
            bool isIdValid = int.TryParse(TB_Id.Text, out int parsedId);
            customer.Id = isIdValid ? parsedId : 0;
            customer.Name = TB_Name.Text;
            customer.CustomerNumber = TB_CustomerNumber.Text;
            customer.Street = TB_Street.Text;
            customer.Zipcode = TB_Zipcode.Text;
            customer.Country = TB_Country.Text;
            customer.City = TB_City.Text;

            _Customers.Add(customer);
            ResetCustomer(sender, e);
        }
    }
}

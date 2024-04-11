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
using System.Windows.Shapes;

namespace _5_labka
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void ProductCategories_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new ProductCategoriesPage();
        }

        private void Products_Click_1(object sender, RoutedEventArgs e)
        {
            Page.Content = new ProductsPage();
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new CustomersPage();
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new OrdersPage();
        }

        private void PromotionalCodes_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new PromotionalCodesPage();

        }

        private void OrderDetails_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new OrderDetailsPage();
        }

        private void Servis_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new ServisPage();

        }

        private void Returnss_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new ReturnssPage();
        }

        private void Roles_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new RolesPage();
        }

        private void Employees_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new EmployeesPage();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            Close();
        }
    }
}

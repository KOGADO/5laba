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
    /// Логика взаимодействия для User.xaml
    /// </summary>
    public partial class User : Window
    {
        public User()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
            Close();
        }

        private void Products_Click_1(object sender, RoutedEventArgs e)
        {
            Page.Content = new ProductsPageUser();
        }

        private void Customers_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new CustomersPageUser();
        }

        private void Orders_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new OrdersPageUser();
        }

        private void OrderDetails_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new OrderDetailsPageUser();
        }

        private void Servis_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new ServisPageUser();

        }

        private void Returnss_Click(object sender, RoutedEventArgs e)
        {
            Page.Content = new ReturnssPageUser();
        }
    }
}

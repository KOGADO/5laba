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

namespace _5_labka
{
    /// <summary>
    /// Логика взаимодействия для OrdersPageUser.xaml
    /// </summary>
    public partial class OrdersPageUser : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public OrdersPageUser()
        {
            InitializeComponent();
            OrdersDgr.ItemsSource = alcomarket.Orders.ToList();
            Cbx.ItemsSource = alcomarket.Customers.ToList();
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Orders Orders = new Orders();
            Orders.OrderDate = Convert.ToDateTime(Tbx.Text);

            alcomarket.Orders.Add(Orders);

            alcomarket.SaveChanges();

            OrdersDgr.ItemsSource = alcomarket.Orders.ToList();
        }

        private void OrdersDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrdersDgr.SelectedItem != null)
            {
                var selected = OrdersDgr.SelectedItem as Orders;
                Tbx.Text = Convert.ToString(selected.OrderID);
                Tbx3.Text = Convert.ToString(selected.OrderDate);
                Tbx4.Text = Convert.ToString(selected.TotalAmount);
            }

        }
    }
}

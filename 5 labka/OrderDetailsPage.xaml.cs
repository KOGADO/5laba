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
    /// Логика взаимодействия для OrderDetailsPage.xaml
    /// </summary>
    public partial class OrderDetailsPage : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public OrderDetailsPage()
        {
            InitializeComponent();
            OrderDetailsDgr.ItemsSource = alcomarket.OrderDetails.ToList();
            Cbx2.ItemsSource = alcomarket.Orders.ToList();
            Cbx3.ItemsSource = alcomarket.Products.ToList();
            Cbx4.ItemsSource = alcomarket.PromotionalCodes.ToList();
            Cbx6.ItemsSource = alcomarket.OrderDetails.ToList();

        }

        private void OrderDetailsDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderDetailsDgr.SelectedItem != null)
            {
                var selected = OrderDetailsDgr.SelectedItem as OrderDetails;
                Tbx.Text = Convert.ToString(selected.UnitPrice);
                Tbx5.Text = Convert.ToString(selected.Quantity);
            }
        }
        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            OrderDetails OrderDetails = new OrderDetails();
            OrderDetails.UnitPrice = Convert.ToInt32(Tbx.Text);


            alcomarket.SaveChanges();

            OrderDetailsDgr.ItemsSource = alcomarket.OrderDetails.ToList();

        }

        private void udal_Click(object sender, RoutedEventArgs e)
        {
            if (OrderDetailsDgr.SelectedItem != null)
            {
                alcomarket.OrderDetails.Remove(OrderDetailsDgr.SelectedItem as OrderDetails);

                alcomarket.SaveChanges();
                OrderDetailsDgr.ItemsSource = alcomarket.OrderDetails.ToList();
            }

        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (OrderDetailsDgr.SelectedItem != null)
            {
                var selected = OrderDetailsDgr.SelectedItem as OrderDetails;

                selected.UnitPrice = Convert.ToInt32(Tbx.Text);
                selected.Quantity = Convert.ToInt32(Tbx5.Text);

                alcomarket.SaveChanges();
                OrderDetailsDgr.ItemsSource = alcomarket.OrderDetails.ToList();
            }
        }
    }
}

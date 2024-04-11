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
    /// Логика взаимодействия для OrderDetailsPageUser.xaml
    /// </summary>
    public partial class OrderDetailsPageUser : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public OrderDetailsPageUser()
        {
            InitializeComponent();
            OrderDetailsDgr.ItemsSource = alcomarket.OrderDetails.ToList();
            Cbx2.ItemsSource = alcomarket.Orders.ToList();
            Cbx3.ItemsSource = alcomarket.Products.ToList();
            Cbx4.ItemsSource = alcomarket.PromotionalCodes.ToList();
        }

        private void OrderDetailsDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderDetailsDgr.SelectedItem != null)
            {
                var selected = OrderDetailsDgr.SelectedItem as OrderDetails;
                Tbx.Text = Convert.ToString(selected.OrderDetailID);
                Tbx2.Text = Convert.ToString(selected.Quantity);
                Tbx3.Text = Convert.ToString(selected.UnitPrice);
            }
        }
        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            OrderDetails OrderDetails = new OrderDetails();
            OrderDetails.UnitPrice = Convert.ToInt32(Tbx.Text);

            alcomarket.OrderDetails.Add(OrderDetails);

            alcomarket.SaveChanges();

            OrderDetailsDgr.ItemsSource = alcomarket.OrderDetails.ToList();

        }
    }
}

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
    /// Логика взаимодействия для ReturnssPage.xaml
    /// </summary>
    public partial class ReturnssPage : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public ReturnssPage()
        {
            InitializeComponent();
            ReturnssDgr.ItemsSource = alcomarket.Returnss.ToList();
            Cbx.ItemsSource = alcomarket.OrderDetails.ToList();
        }

        private void ReturnssDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ReturnssDgr.SelectedItem != null)
            {
                var selected = ReturnssDgr.SelectedItem as Returnss;
                Tbx.Text = Convert.ToString(selected.ReturnID);
                Tbx3.Text = selected.ReturnReason;
            }
        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (ReturnssDgr.SelectedItem != null)
            {
                var selected = ReturnssDgr.SelectedItem as Returnss;

                selected.ReturnID = Convert.ToInt32(Tbx.Text);
                selected.ReturnReason = Tbx3.Text;

                alcomarket.SaveChanges();
                ReturnssDgr.ItemsSource = alcomarket.Returnss.ToList();
            }
        }
        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Returnss Returnss = new Returnss();
            Returnss.ReturnReason = Tbx.Text;


            alcomarket.SaveChanges();

            ReturnssDgr.ItemsSource = alcomarket.Returnss.ToList();

        }

        private void udal_Click(object sender, RoutedEventArgs e)
        {
            if (ReturnssDgr.SelectedItem != null)
            {
                alcomarket.Returnss.Remove(ReturnssDgr.SelectedItem as Returnss);

                alcomarket.SaveChanges();
                ReturnssDgr.ItemsSource = alcomarket.Returnss.ToList();
            }

        }

    }
}

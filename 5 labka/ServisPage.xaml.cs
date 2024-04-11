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
    /// Логика взаимодействия для ServisPage.xaml
    /// </summary>
    public partial class ServisPage : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public ServisPage()
        {
            InitializeComponent();
            ServisDgr.ItemsSource = alcomarket.Servis.ToList();
            Cbx.ItemsSource = alcomarket.Customers.ToList();
        }
        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (ServisDgr.SelectedItem != null)
            {
                var selected = ServisDgr.SelectedItem as Servis;

                selected.ServisID = Convert.ToInt32(Tbx.Text);
                selected.Opisanie = Tbx3.Text;
                selected.Price = Convert.ToInt32(Tbx4.Text);

                alcomarket.SaveChanges();
                ServisDgr.ItemsSource = alcomarket.Servis.ToList();
            }
        }

        private void ServisDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ServisDgr.SelectedItem != null)
            {
                var selected = ServisDgr.SelectedItem as Servis;
                Tbx.Text = Convert.ToString(selected.ServisID);
                Tbx3.Text = selected.Opisanie;
                Tbx4.Text = Convert.ToString(selected.Price);
            }
        }
        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Servis Servis = new Servis();
            Servis.Opisanie = Tbx.Text;


            alcomarket.SaveChanges();

            ServisDgr.ItemsSource = alcomarket.Servis.ToList();

        }

        private void udal_Click(object sender, RoutedEventArgs e)
        {
            if (ServisDgr.SelectedItem != null)
            {
                alcomarket.Servis.Remove(ServisDgr.SelectedItem as Servis);

                alcomarket.SaveChanges();
                ServisDgr.ItemsSource = alcomarket.Servis.ToList();
            }

        }

    }
}

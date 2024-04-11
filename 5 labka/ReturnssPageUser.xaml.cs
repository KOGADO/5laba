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
    /// Логика взаимодействия для ReturnssPageUser.xaml
    /// </summary>
    public partial class ReturnssPageUser : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public ReturnssPageUser()
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

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Returnss Returnss = new Returnss();
            Returnss.ReturnReason = Tbx.Text;

            alcomarket.Returnss.Add(Returnss);

            alcomarket.SaveChanges();

            ReturnssDgr.ItemsSource = alcomarket.Returnss.ToList();

        }
    }
}

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
    /// Логика взаимодействия для PromotionalCodesPage.xaml
    /// </summary>
    public partial class PromotionalCodesPage : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public PromotionalCodesPage()
        {
            InitializeComponent();
            PromotionalCodesDgr.ItemsSource = alcomarket.PromotionalCodes.ToList();

        }

        private void PromotionalCodesDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PromotionalCodesDgr.SelectedItem != null)
            {
                var selected = PromotionalCodesDgr.SelectedItem as PromotionalCodes;
                Tbx.Text = Convert.ToString(selected.PromotionalCodeID);
                Tbx2.Text = selected.PromotionalCode;
                Tbx3.Text = Convert.ToString(selected.Discount);
            }
        }
        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (PromotionalCodesDgr.SelectedItem != null)
            {
                var selected = PromotionalCodesDgr.SelectedItem as PromotionalCodes;

                selected.PromotionalCodeID = Convert.ToInt32(Tbx.Text);
                selected.PromotionalCode = Tbx2.Text;
                selected.Discount = Convert.ToInt32(Tbx3.Text);

                alcomarket.SaveChanges();
                PromotionalCodesDgr.ItemsSource = alcomarket.PromotionalCodes.ToList();
            }
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            PromotionalCodes PromotionalCodes = new PromotionalCodes();
            PromotionalCodes.PromotionalCode = Tbx.Text;


            alcomarket.SaveChanges();

            PromotionalCodesDgr.ItemsSource = alcomarket.PromotionalCodes.ToList();

        }

        private void udal_Click(object sender, RoutedEventArgs e)
        {
            if (PromotionalCodesDgr.SelectedItem != null)
            {
                alcomarket.PromotionalCodes.Remove(PromotionalCodesDgr.SelectedItem as PromotionalCodes);

                alcomarket.SaveChanges();
                PromotionalCodesDgr.ItemsSource = alcomarket.PromotionalCodes.ToList();
            }

        }

    }
}

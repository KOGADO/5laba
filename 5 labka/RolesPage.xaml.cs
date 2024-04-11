using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для RolesPage.xaml
    /// </summary>
    public partial class RolesPage : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public RolesPage()
        {
            InitializeComponent();
            RolesDgr.ItemsSource = alcomarket.Roles.ToList();
        }

        private void RolesDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (RolesDgr.SelectedItem != null)
            {
                var selected = RolesDgr.SelectedItem as Roles;
                Tbx.Text = Convert.ToString(selected.RoleID);
                Tbx2.Text = selected.RoleName;
            }
        }
        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (RolesDgr.SelectedItem != null)
            {
                var selected = RolesDgr.SelectedItem as Roles;

                selected.RoleID = Convert.ToInt32(Tbx.Text);
                selected.RoleName = Tbx2.Text;

                alcomarket.SaveChanges();
                RolesDgr.ItemsSource = alcomarket.Roles.ToList();
            }
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Roles Roles = new Roles();
            Roles.RoleName = Tbx.Text;


            alcomarket.SaveChanges();

            RolesDgr.ItemsSource = alcomarket.Roles.ToList();

        }

        private void udal_Click(object sender, RoutedEventArgs e)
        {
            if (RolesDgr.SelectedItem != null)
            {
                alcomarket.Roles.Remove(RolesDgr.SelectedItem as Roles);

                alcomarket.SaveChanges();
                RolesDgr.ItemsSource = alcomarket.Roles.ToList();
            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _5_labka
{
    public partial class EmployeesPage : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public EmployeesPage()
        {
            InitializeComponent();
            EmployeesDgr.ItemsSource = alcomarket.Employees.ToList();
        }

        private void EmployeesDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (EmployeesDgr.SelectedItem != null)
            {
                var selected = EmployeesDgr.SelectedItem as Employees;
                Tbx.Text = Convert.ToString(selected.RoleID);
                Tbx2.Text = selected.FirstName;
                Tbx3.Text = selected.LastName;
                Tbx4.Text = selected.Position;
                Tbx5.Text = Convert.ToString(selected.HireDate);
                Cbx6.ItemsSource = alcomarket.Employees.ToList();
            }
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Employees Employees = new Employees();
            Employees.RoleID = Convert.ToInt32(Tbx.Text);
            Employees.FirstName = Tbx3.Text;
            Employees.LastName = Tbx4.Text;
            Employees.Position = Tbx5.Text;

            alcomarket.Employees.Add(Employees);

            alcomarket.SaveChanges();

            EmployeesDgr.ItemsSource = alcomarket.Employees.ToList();

        }

        private void udal_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesDgr.SelectedItem != null)
            {
                alcomarket.Employees.Remove(EmployeesDgr.SelectedItem as Employees);

                alcomarket.SaveChanges();
                EmployeesDgr.ItemsSource = alcomarket.Employees.ToList();
            }

        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeesDgr.SelectedItem != null)
            {
                var selected = EmployeesDgr.SelectedItem as Employees;
                selected.RoleID = Convert.ToInt32(Tbx.Text);
                selected.FirstName = Tbx2.Text;
                selected.LastName = Tbx3.Text;
                selected.Position = Tbx4.Text;
                selected.HireDate = Convert.ToDateTime(Tbx5.Text);


                alcomarket.SaveChanges();
                EmployeesDgr.ItemsSource = alcomarket.Employees.ToList();
            }
        }
    }
}

﻿using System;
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
    /// Логика взаимодействия для CustomersPageUser.xaml
    /// </summary>
    public partial class CustomersPageUser : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public CustomersPageUser()
        {
            InitializeComponent();
            CustomersDgr.ItemsSource = alcomarket.Customers.ToList();
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Customers Customers = new Customers();
            Customers.LastName = Tbx.Text;

            alcomarket.Customers.Add(Customers);

            alcomarket.SaveChanges();

            CustomersDgr.ItemsSource = alcomarket.Customers.ToList();

        }

        private void CustomersDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CustomersDgr.SelectedItem != null)
            {
                var selected = CustomersDgr.SelectedItem as Customers;
                Tbx.Text = Convert.ToString(selected.CustomerID);
                Tbx2.Text = Convert.ToString(selected.FirstName);
                Tbx3.Text = Convert.ToString(selected.LastName);
                Tbx4.Text = Convert.ToString(selected.Email);
                Tbx5.Text = Convert.ToString(selected.Phone);
            }
        }
    }
}

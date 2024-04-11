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
    /// Логика взаимодействия для ProductsPageUser.xaml
    /// </summary>
    public partial class ProductsPageUser : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public ProductsPageUser()
        {
            InitializeComponent();
            ProductsDgr.ItemsSource = alcomarket.Products.ToList();
            cbx.ItemsSource = alcomarket.ProductCategories.ToList();
        }

        private void ProductsDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductsDgr.SelectedItem != null)
            {
                var selected = ProductsDgr.SelectedItem as Products;
                Tbx.Text = selected.Namee;
                tbx5.Text = selected.Opisanie;
                tbx3.Text = Convert.ToString(selected.ProductID);
                tbx4.Text = Convert.ToString(selected.Price);
                tbx2.Text = Convert.ToString(selected.QuantityInStock);
            }
        }
        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Products Product = new Products();
            Product.Namee = Tbx.Text;
            Product.Opisanie = tbx5.Text;
            Product.ProductID = Convert.ToInt32(tbx3.Text);
            Product.Price = Convert.ToInt32(tbx4.Text);
            Product.QuantityInStock = Convert.ToInt32(tbx2.Text);
            if (string.IsNullOrWhiteSpace(Tbx.Text) || string.IsNullOrWhiteSpace(tbx2.Text) || string.IsNullOrWhiteSpace(tbx3.Text) ||
               string.IsNullOrWhiteSpace(tbx4.Text) || string.IsNullOrWhiteSpace(tbx5.Text))
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else if (!int.TryParse(tbx3.Text.ToString(), out _) || !int.TryParse(tbx4.Text.ToString(), out _)
            || !int.TryParse(tbx2.Text.ToString(), out _))
            {
                MessageBox.Show("Неверный формат введенных данных");
            }
            else if (Convert.ToInt32(tbx4.Text) < 0 || Convert.ToInt32(tbx2.Text) < 0)
            {
                MessageBox.Show("Цена и количество продукта не могут быть отрицательными");

            }
            alcomarket.Products.Add(Product);

            alcomarket.SaveChanges();

            ProductsDgr.ItemsSource = alcomarket.Products.ToList();
        }
        
        private void poisk_Click(object sender, RoutedEventArgs e)
        {
            ProductsDgr.ItemsSource = alcomarket.Products.ToList().Where(item => item.Namee.Contains(poisktxt.Text));
        }

        private void ochistka_Click(object sender, RoutedEventArgs e)
        {
            ProductsDgr.ItemsSource = alcomarket.Products.ToList();
        }

        private void cbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbx.SelectedItem != null)
            {
                var selected = cbx.SelectedItem as ProductCategories;
                ProductsDgr.ItemsSource = alcomarket.Products.ToList().Where(item => item.ProductID == selected.CategoryID);
            }
        }
    }
}

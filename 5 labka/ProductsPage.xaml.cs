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
using System.Xml.Linq;

namespace _5_labka
{
    public partial class ProductsPage : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public ProductsPage()
        {
            InitializeComponent();
            ProductsDgr.ItemsSource = alcomarket.Products.ToList();
            cbx.ItemsSource = alcomarket.ProductCategories.ToList();
            cbx2.ItemsSource = alcomarket.ProductCategories.ToList();
        }

        private void ProductsDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductsDgr.SelectedItem != null)
            {
                var selected = ProductsDgr.SelectedItem as Products;
                Tbx.Text = selected.Namee;
                tbx5.Text = selected.Opisanie;
                tbx4.Text = Convert.ToString(selected.Price);
                tbx2.Text = Convert.ToString(selected.QuantityInStock);
            }
        }
        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            Products Product = new Products();
            Product.Namee = Tbx.Text;
            Product.Opisanie = tbx5.Text;
            Product.CategoryID = Convert.ToInt32(cbx2.SelectedValue);
            Product.Price = Convert.ToInt32(tbx4.Text);
            Product.QuantityInStock = Convert.ToInt32(tbx2.Text);


            alcomarket.Products.Add(Product);
            alcomarket.SaveChanges();
            ProductsDgr.ItemsSource = alcomarket.Products.ToList();
        }
        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsDgr.SelectedItem != null)
            {
                var selected = ProductsDgr.SelectedItem as Products;

                selected.Namee = Tbx.Text;
                selected.Opisanie = tbx5.Text;
                selected.Price = Convert.ToInt32(tbx4.Text);
                selected.QuantityInStock = Convert.ToInt32(tbx2.Text);

                if (string.IsNullOrWhiteSpace(Tbx.Text) || string.IsNullOrWhiteSpace(tbx2.Text) ||
               string.IsNullOrWhiteSpace(tbx4.Text) || string.IsNullOrWhiteSpace(tbx5.Text))
                {
                    MessageBox.Show("Не все поля заполнены");
                }
                else if (!int.TryParse(tbx4.Text.ToString(), out _)
                || !int.TryParse(tbx2.Text.ToString(), out _))
                {
                    MessageBox.Show("Неверный формат введенных данных");
                }
                else if (Convert.ToInt32(tbx4.Text) < 0 || Convert.ToInt32(tbx2.Text) < 0)
                {
                    MessageBox.Show("Цена и количество продукта не могут быть отрицательными");

                }
                else
                {
                    alcomarket.SaveChanges();
                    ProductsDgr.ItemsSource = alcomarket.Products.ToList();
                }
            }
        }

        private void udal_Click(object sender, RoutedEventArgs e)
        {
            if (ProductsDgr.SelectedItem != null)
            {
                alcomarket.Products.Remove(ProductsDgr.SelectedItem as Products);

                alcomarket.SaveChanges();
                ProductsDgr.ItemsSource = alcomarket.Products.ToList();
            }
            else
            {
                MessageBox.Show("пусто");
            }

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

        private void cbx2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbx.SelectedItem != null)
            {
                var selected = cbx2.SelectedItem as ProductCategories;
                ProductsDgr.ItemsSource = alcomarket.ProductCategories.ToList().Where(item => Convert.ToInt32(item.CategoryName) == selected.CategoryID);
            }
        }
    }
}

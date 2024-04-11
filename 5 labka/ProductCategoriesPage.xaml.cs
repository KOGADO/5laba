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
    /// Логика взаимодействия для ProductCategoriesPage.xaml
    /// </summary>
    /// 
    public partial class ProductCategoriesPage : Page
    {
        private alcomarket4Entities alcomarket = new alcomarket4Entities();
        public ProductCategoriesPage()
        {
            InitializeComponent();
            ProductCategoriesDgr.ItemsSource = alcomarket.ProductCategories.ToList();
        }

        private void ProductCategoriesDgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ProductCategoriesDgr.SelectedItem != null)
            {
                var selected = ProductCategoriesDgr.SelectedItem as ProductCategories;
                Tbx.Text = selected.CategoryName;
            }
        }

        private void dobav_Click(object sender, RoutedEventArgs e)
        {
            ProductCategories Categories = new ProductCategories();
            Categories.CategoryName = Tbx.Text;

            alcomarket.ProductCategories.Add(Categories);

            alcomarket.SaveChanges();

            ProductCategoriesDgr.ItemsSource = alcomarket.ProductCategories.ToList();

        }

        private void udal_Click(object sender, RoutedEventArgs e)
        {
            if (ProductCategoriesDgr.SelectedItem != null)
            { 
                alcomarket.ProductCategories.Remove(ProductCategoriesDgr.SelectedItem as ProductCategories);

                alcomarket.SaveChanges();
                ProductCategoriesDgr.ItemsSource = alcomarket.ProductCategories.ToList();
            }

        }

        private void izm_Click(object sender, RoutedEventArgs e)
        {
            if(ProductCategoriesDgr.SelectedItem != null)
            {
                var selected = ProductCategoriesDgr.SelectedItem as ProductCategories;

                selected.CategoryName = Tbx.Text;

                alcomarket.SaveChanges();
                ProductCategoriesDgr.ItemsSource = alcomarket.ProductCategories.ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
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
using FinalCock.Database;

namespace FinalCock.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProductView.xaml
    /// </summary>
    public partial class ProductView : Page
    {
        DemoDbEntities db = new DemoDbEntities();
        List<Products> products= new List<Products>();
        public ProductView()
        {
            InitializeComponent();
            DgProduct.ItemsSource = db.Products.ToList();
            BtnToOrder.Visibility = Visibility.Hidden;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            BtnToOrder.Visibility = Visibility.Visible;
            Products SelectedProduct = DgProduct.SelectedItem as Products;
            if (SelectedProduct == null)
            {
                MessageBox.Show("Ничего не выбрано");
            }
            else
            {
                products.Add(SelectedProduct);

            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            DgProduct.ItemsSource = db.Products.ToList();
            
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void BtnToOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderPage orderpage = new OrderPage(products);
            orderpage.ShowDialog();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
           List <Products> SelectedProduct = db.Products.ToList();
            SelectedProduct = SelectedProduct.Where(d => d.Name.Contains(TxtSearch.Text)).ToList();
            if (SelectedProduct.Count == 0) 
            {
                MessageBox.Show("Поиск не дал результатов");
            }
            else { 
            DgProduct.ItemsSource = SelectedProduct;
            }
        }
    }
}

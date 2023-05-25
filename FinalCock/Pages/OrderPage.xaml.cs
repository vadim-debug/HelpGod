using FinalCock.Database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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



namespace FinalCock.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Window
    {
        public List<Products> GlobalPr = new List<Products>();
        DemoDbEntities db = new DemoDbEntities();
        Orders order = new Orders();    
        public OrderPage(List<Products> Pr)
        {
            InitializeComponent();
            GlobalPr = Pr;
            CmbPP.ItemsSource = db.PointIssues.ToList();
            DgProduct.ItemsSource = GlobalPr;


            BtnRegOrder.Visibility = Visibility.Hidden;
            txtDateOrder.Text = DateTime.Now.ToString();
            txtDateDel.Text = DateTime.Now.AddDays(3).ToString();
            txtSaleOrder.Text = GetSaleOrder().ToString();
            txtCostOrder.Text = GetCostOrder().ToString();
        }

        public decimal GetCostOrder() 
        {
            decimal CostOrder = 0;
            foreach (Products pr in GlobalPr)
            {
                CostOrder += (decimal)pr.Cost - (decimal)pr.Cost * (decimal)(pr.Sale / 100);
            }
            return CostOrder;
        }
        public decimal GetSaleOrder()
        {
            decimal SaleOrder = 0;
            foreach (Products pr in GlobalPr)
            {
                SaleOrder += (decimal)pr.Cost * (decimal)(pr.Sale / 100);
            }
            return SaleOrder;
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Products selectedProduct = DgProduct.SelectedItem as Products;
            if (selectedProduct == null)
            {
                MessageBox.Show("Ничего не выбрано");
            }
            else
            {
                MessageBox.Show("Товар будет удален и вы вернетесь к просмотру товаров", "", MessageBoxButton.OK);
                GlobalPr.Remove(selectedProduct);
                this.Close();
            }
        }

        private void BtnRegOrder_Click(object sender, RoutedEventArgs e)
        {
            order.CostOrder = decimal.Parse(txtCostOrder.Text);
            order.SumSale = decimal.Parse(txtSaleOrder.Text);
            order.DateOrder = DateTime.Now;
            order.DateDelievery = DateTime.Now.AddDays(3);
            order.PointIssues = CmbPP.SelectedItem as PointIssues;
            db.Orders.Add(order);
            db.SaveChanges();
            MessageBox.Show("Заказ подтверждён и сохранён в БД, талон находится в корневой папке проекта");
            GetTalon();
        }

        private void CmbPP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BtnRegOrder.Visibility = Visibility.Visible;
           
        }
        public void GetTalon()
        {
            Random random= new Random();
            int number = random.Next(100, 999);
            string path = "../../../talon.txt";
            string text = $"Номер заказа - {order.ID}\nСумма заказа - {order.CostOrder}\nКод получения заказа:{number}\n";
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                 writer.WriteLineAsync(text);
                
            }
            
        }
    }
}

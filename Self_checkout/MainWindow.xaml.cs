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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Self_checkout
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StoreAssortment storeAssortment;
        private User user;
        private SelfCheckout checkout;
        public MainWindow()
        {
            InitializeComponent();
            FillComboBox();
            user = new User(10000);
            checkout = SelfCheckout.CreateSelfCheckout();
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin("666");
            PasswordAdminWindow passwordAdminWindow = new PasswordAdminWindow();
            if (passwordAdminWindow.ShowDialog() == true)
            {
                if (passwordAdminWindow.Password == admin.Password)
                {
                    AdminWindow adminWindow = new AdminWindow();
                    adminWindow.Show();
                }
                else
                {
                    MessageBox.Show("Неверный пароль");
                }
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }

        

        private void FillComboBox()
        {
            storeAssortment = StoreAssortment.CreateStoreAssortment();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                (
                    "SELECT * FROM Products",
                    storeAssortment.sqlConnection
                );
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                ProductsList.Items.Add(
                    new Product 
                    { 
                        Title = row["Title"].ToString(),
                        Price = Convert.ToDouble(row["Price"]), 
                        Weight = Convert.ToDouble(row["Weight"]) 
                    });
            }
        }

        private void EnterProduct_Click(object sender, RoutedEventArgs e)
        {
            if(ProductsList.SelectedItem != null)
            {
                user.TakeProduct((IProduct)ProductsList.SelectedItem);
                if(user.ProductsBasket.Count != 0)
                {
                    SaleButton.Visibility = Visibility.Visible;
                    AbortButton.Visibility = Visibility.Visible;
                }
            }
            
        }

        private void ShowProductsBasketButton_Click(object sender, RoutedEventArgs e)
        {
            if(user.ProductsBasket.Count != 0)
            {
                string res = "Ваша корзина:\n";
                for(int i = 0; i < user.ProductsBasket.Count; i++)
                
                {
                    res += user.ProductsBasket[i].ToString() + "\n";
                }
                MessageBox.Show(res);
            }
            else
            {
                MessageBox.Show("Корзина пуста");
            }
        }

        private void SaleButton_Click(object sender, RoutedEventArgs e)
        {
            user.Pay(checkout.scanner.ScanProducts(user.ProductsBasket));
            user.ProductsBasket.Clear();
        }

        private void AbortButton_Click(object sender, RoutedEventArgs e)
        {
            user.ProductsBasket.Clear();
        }

        private void ShowUserCash_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Ваш остаток: {user.Cash}");
        }
    }
}

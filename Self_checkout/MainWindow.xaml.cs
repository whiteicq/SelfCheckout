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
        public MainWindow()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            PasswordAdminWindow passwordAdminWindow = new PasswordAdminWindow();
            if (passwordAdminWindow.ShowDialog() == true)
            {
                if (passwordAdminWindow.Password == "1234")
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

        private void ProductsList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void FillComboBox()
        {
            StoreAssortment storeAssortment = StoreAssortment.CreateStoreAssortment();
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
    }
}

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
using System.Windows.Shapes;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Self_checkout
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private StoreAssortment assortment;
        public AdminWindow()
        {
            InitializeComponent();
            assortment = StoreAssortment.CreateStoreAssortment();
            assortment.Notify += message => MessageBox.Show(message);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            assortment.AddProduct(TextBoxTitle.Text, Convert.ToDouble(TextBoxPrice.Text), Convert.ToDouble(TextBoxWeight.Text));
            TextBoxTitle.Text = string.Empty;
            TextBoxPrice.Text = string.Empty;
            TextBoxWeight.Text = string.Empty;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            assortment.DeleteProduct(TextBoxTitleDelete.Text, Convert.ToDouble(TextBoxPriceDelete.Text));
            TextBoxTitleDelete.Text = string.Empty;
            TextBoxPriceDelete.Text = string.Empty;
        }
    }
}

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

namespace SelfCheckout
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        StoreAssortment storeAssortment;
        public AdminWindow()
        {
            storeAssortment = StoreAssortment.CreateStoreAssortment();
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (TextBoxTitle.Text != string.Empty && TextBoxPrice.Text != string.Empty && TextBoxWeight.Text != string.Empty)
            {
                storeAssortment.AddProduct(TextBoxTitle.Text, Convert.ToDouble(TextBoxPrice.Text), Convert.ToDouble(TextBoxWeight.Text));
                TextBoxTitle.Text = string.Empty;
                TextBoxPrice.Text = string.Empty;
                TextBoxWeight.Text = string.Empty;
            }
        }

    }
}

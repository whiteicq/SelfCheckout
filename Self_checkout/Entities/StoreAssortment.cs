using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Self_checkout
{
    class StoreAssortment
    {
        public delegate void SendNotify(string message);
        public event SendNotify Notify;
        private SqlConnection sqlConnection;
        private static StoreAssortment isInstance;
        private StoreAssortment() 
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["Products"].ConnectionString);
            sqlConnection.Open();
        }
        public static StoreAssortment CreateStoreAssortment()
        {
            if(isInstance is null)
            {
                return new StoreAssortment();
            }
            return isInstance;
        }

        public void AddProduct(string title, double price, double weight)
        {
            SqlCommand sqlCommand = new SqlCommand
                (
                $"INSERT INTO [Products] (Title, Price, Weight) VALUES (N'{title}', '{price}', '{weight}')",
                sqlConnection
                );
            /*sqlCommand.ExecuteNonQuery();*/
            if(sqlCommand.ExecuteNonQuery() != 0)
            {
                Notify?.Invoke($"Добавлено {title}: {price} руб, {weight} гр");
            }
            else
            {
                Notify?.Invoke("Ошибка при добавлении");
            }
        }

        public void DeleteProduct(string title, double price)
        {
            SqlCommand sqlCommand = new SqlCommand
                (
                    $"DELETE FROM Products WHERE Title = N'{title}' AND Price = '{price}'", sqlConnection
                );
            if(sqlCommand.ExecuteNonQuery() != 0)
            {
                Notify?.Invoke($"Удалено {title}: {price} руб");
            }
            else
            {
                Notify?.Invoke("Ошибка при удалении");
            }
        }
    }
}

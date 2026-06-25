using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL.Database
{
    public class CustomerDBDL : ICustomer
    {
        private string ConnectionString;
        public CustomerDBDL(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public List<string> GetFeedbacksList()
        {
            List<String> Feedback = new List<String>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = "SELECT * FROM Customer";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Feedback.Add(Convert.ToString(reader["Feedback"]));
            }
            connection.Close();
            return Feedback;
        }

        public float GetTotalAmountSpend(string Gmail)
        {
            string TotalAmountSpendString = null;
            float TotalAmountSpend = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select TotalAmountSpend from Customer where Gmail = '{0}'", Gmail);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            object data = command.ExecuteScalar();
            if (data != null)
            {
                TotalAmountSpendString = data.ToString();
                connection.Close();
                TotalAmountSpend = float.Parse(TotalAmountSpendString);

            }

            connection.Close();
            return TotalAmountSpend;
        }

        public int GetTotalNumberOfProductsBought(string Gmail)
        {
            string TotalNumberOfProductsString = null;
            int TotalNumberOfProducts = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select TotalProductsPurchased from Customer where Gmail = '{0}'", Gmail);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            object data = command.ExecuteScalar();
            if (data != null)
            {
                TotalNumberOfProductsString = data.ToString();
                connection.Close();
                TotalNumberOfProducts = int.Parse(TotalNumberOfProductsString);

            }

            connection.Close();
            return TotalNumberOfProducts;
        }

        public bool StoreCustomerInfo(Customer customer)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("insert into Customer (Feedback, TotalProductsPurchased, TotalAmountSpend, Gmail) VALUES('{0}', '{1}', '{2}', '{3}')", customer.GetFeedBack(), customer.GetTotalProductsPurchased(), customer.GetTotalAmountSpend(), customer.GetGmail());
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateFeedback(string Feedback, string Gmail)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE Customer SET Feedback = '{1}' WHERE Gmail = '{0}'", Gmail, Feedback);
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateTotalAmountSpend(float AmountSpend, string Gmail)
        {
            AmountSpend = AmountSpend + GetTotalAmountSpend(Gmail);
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE Customer SET TotalAmountSpend = '{1}' WHERE Gmail = '{0}'", Gmail, AmountSpend);
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateTotalNumberOfProductsBought(int BoughtProducts, string Gmail)
        {
            BoughtProducts = BoughtProducts + GetTotalNumberOfProductsBought(Gmail);
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE Customer SET TotalProductsPurchased = '{1}' WHERE Gmail = '{0}'", Gmail, BoughtProducts);
            SqlCommand command = new SqlCommand(query, connection);
            int rowsAffected = command.ExecuteNonQuery();
            connection.Close();
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

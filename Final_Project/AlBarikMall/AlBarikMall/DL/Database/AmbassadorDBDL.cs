using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL.Database
{
    public class AmbassadorDBDL : IAmbassador
    {
        private string ConnectionString;
        public AmbassadorDBDL(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public bool DeleteAmbassadorInfo(string Gmail)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("DELETE FROM AmbassadorEntity WHERE Gmail = '{0}'", Gmail);
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
        public bool EnterAmbasadorInfo(BrandAmbassador brandAmbassador)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("insert into AmbassadorEntity (Fare, Gmail, BrandName, Sales) VALUES('{0}', '{1}', '{2}', '{3}')", brandAmbassador.GetFare(), brandAmbassador.GetGmail(), brandAmbassador.GetBrandName(), brandAmbassador.GetSales());
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

        public float GetSales(string Gmail)
        {
            string SalesString = null;
            float Sales = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select Sales from AmbassadorEntity where Gmail = '{0}'", Gmail);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            object data = command.ExecuteScalar();
            if (data != null)
            {
                SalesString = data.ToString();
                connection.Close();
                Sales = float.Parse(SalesString);

            }

            connection.Close();
            return Sales;
        }

        public bool IsBrandExists(string BrandName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select * from AmbassadorEntity where BrandName = '{0}'", BrandName);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            bool check = data.Read();
            connection.Close();
            return check;
        }
        private float GetSalesViaBrandName(string BrandName)
        {
            string SalesString = null;
            float Sales = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select Sales from AmbassadorEntity where BrandName = '{0}'", BrandName);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            object data = command.ExecuteScalar();
            if (data != null)
            {
                SalesString = data.ToString();
                connection.Close();
                Sales = float.Parse(SalesString);

            }

            connection.Close();
            return Sales;
        }
        public bool UpdateSales(float Sales, string BrandName)
        {
            float Sales1 = Sales + GetSalesViaBrandName(BrandName);
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE AmbassadorEntity SET Sales = '{1}' WHERE BrandName = '{0}'", BrandName, Sales1);
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

        public string GetBrandName(string Gmail)
        {

            string BrandName = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select BrandName from AmbassadorEntity where Gmail = '{0}'", Gmail);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            object data = command.ExecuteScalar();
            if (data != null)
            {
                BrandName = data.ToString();
                connection.Close();

            }

            connection.Close();
            return BrandName;
        }
        public double GetTotalFare()
        {
            string f = "Fare";
            string G = "AmbassadorEntity";
            string SalesString = null;
            double Sales = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("SELECT SUM(Fare) FROM  AmbassadorEntity");
            SqlCommand command = new SqlCommand(searchQuery, connection);
            object data = command.ExecuteScalar();
            if (data != null)
            {
                SalesString = data.ToString();
                connection.Close();
                Sales = float.Parse(SalesString);

            }

            connection.Close();
            return Sales;
        }
        public List<string> GetBrandsList()
        {
            List<String> Feedback = new List<String>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = "SELECT * FROM AmbassadorEntity";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Feedback.Add(Convert.ToString(reader["BrandName"]));
            }
            connection.Close();
            return Feedback;
        }
    }
}

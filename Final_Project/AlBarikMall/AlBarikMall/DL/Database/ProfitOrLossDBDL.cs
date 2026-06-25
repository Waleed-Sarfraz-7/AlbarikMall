using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL.Database
{
    public class ProfitOrLossDBDL : IProfitOrLoss
    {
        private string ConnectionString;
        public ProfitOrLossDBDL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public bool AddProfitOrLoss(ProfitOrLoss P)
        {
            if (!validateUser(P))
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string query = String.Format("insert into ProfitOrLoss (Month, Year, Amount, Tax, ElectricityBill, WaterBill, OtherExpenditures) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')", P.GetMonth(), P.GetYear(), P.GetAmount(), P.GetTax(), P.GetElectricityBill(), P.GetWaterBill(), P.GetOtherExpenditures());
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
            return false;
        }
        private bool validateUser(ProfitOrLoss p)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select * from ProfitOrLoss where Month = '{0}' AND Year ='{1}'", p.GetMonth(), p.GetYear());
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            bool check = data.Read();
            connection.Close();
            return check;
        }

        public ProfitOrLoss GetProfitOrLoss(string month, int Year)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("SELECT * FROM ProfitOrLoss where Month='{0}'AND Year='{1}'", month, Year);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                ProfitOrLoss product = new ProfitOrLoss(
                reader.GetString(0),
                int.Parse(reader.GetString(1)),
                float.Parse(reader.GetString(2)),
                float.Parse(reader.GetString(3)),
                float.Parse(reader.GetString(4)),
                float.Parse(reader.GetString(5)),
                float.Parse(reader.GetString(6)));
                connection.Close();
                return product;
            }
            connection.Close();
            return null;
        }
        public List<ProfitOrLoss> GetProfitOrLosses()
        {
            List<ProfitOrLoss> p=new List<ProfitOrLoss>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("SELECT * FROM ProfitOrLoss ");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ProfitOrLoss product = new ProfitOrLoss(
                reader.GetString(0),
                int.Parse(reader.GetString(1)),
                float.Parse(reader.GetString(2)),
                float.Parse(reader.GetString(3)),
                float.Parse(reader.GetString(4)),
                float.Parse(reader.GetString(5)),
                float.Parse(reader.GetString(6)));

            }
            connection.Close();
            return p;
        }
    }
}

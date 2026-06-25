using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL.Database
{
    public class AdminDBDL : IAdmin
    {
        private string ConnectionString;
        public AdminDBDL(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public bool AddAdminInfo(Admin m)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("insert into AdminEntities (Shops ,Gmail) VALUES('{0}', '{1}')", m.GetShops(), m.GetGmail());
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
        public bool AddShops(string Shops, string Gmail)
        {
            //DeleteShops();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("Update AdminEntities Set Shops='{0}' where Gmail='{1}'", (Shops), Gmail);
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
        public bool DeleteShops()
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("Delete From AdminEntities ");
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
        public int GetShops(string Gmail)
        {
            string ShopsString = null;
            int Shops = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string searchQuery = String.Format("Select Shops from AdminEntities where Gmail = '{0}'", Gmail);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            object data = command.ExecuteScalar();
            if (data != null)
            {
                ShopsString = data.ToString();
                connection.Close();
                Shops = int.Parse(ShopsString);

            }

            connection.Close();
            return Shops;
        }

       
    }

}

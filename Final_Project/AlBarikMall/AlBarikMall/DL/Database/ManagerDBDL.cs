using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL.Database
{
    public class ManagerDBDL : IManager
    {
        private string ConnectionString;
        public ManagerDBDL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string GetAnnouncement()
        {
            string Announcement = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select Announcement from ManagerEntities");
            SqlCommand command = new SqlCommand(searchQuery, connection);
            object data = command.ExecuteScalar();
            if (data != null)
            {
                Announcement = data.ToString();
                connection.Close();

            }
            connection.Close();
            return Announcement;
        }

        public float GetSalary(string Gmail)
        {
            string SalaryString = null;
            float Salary = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select Salary from ManagerEntities where Gmail = '{0}'", Gmail);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            object data = command.ExecuteScalar();
            if (data != null)
            {
                SalaryString = data.ToString();
                connection.Close();
                Salary = float.Parse(SalaryString);

            }

            connection.Close();
            return Salary;
        }

        public bool UpdateAnnouncement(string Announcement, string Gmail)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE ManagerEntities SET Announcement = '{1}' WHERE Gmail = '{0}'", Gmail, Announcement);
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

        public bool SetManagerInfo(Manager m)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("insert into ManagerEntities (Announcement, Salary, Gmail) VALUES('{0}', '{1}', '{2}')", m.GetAnnouncement(), m.GetSalary(), m.GetGmail());
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

        public bool DeleteManagerInfo(User user)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("DELETE FROM ManagerEntities WHERE Gmail = '{0}'", user.GetGmail());
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

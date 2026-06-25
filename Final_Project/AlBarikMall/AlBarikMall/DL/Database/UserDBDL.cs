using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlBarikMall.BL;

namespace AlBarikMall.DL.Database
{
    public class UserDBDL : IUser
    {
        private string ConnectionString;
        public UserDBDL(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }
        public User ConfirmUser(User user)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string searchQuery = String.Format("Select * from User1 where Gmail = '{0}' and Password = '{1}'", user.GetGmail(), user.GetPassword());
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();

            if (data.Read())
            {
                User storedUser = new User(data.GetString(0), data.GetString(1), data.GetString(2), data.GetString(5), data.GetString(3), data.GetString(4));
                connection.Close();
                return storedUser;
            }
            connection.Close();
            return null;
        }
        private bool validateUser(User user)
        {
            if (user == null) return false;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select * from User1 where Gmail = '{0}'", user.GetGmail());
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            bool check = data.Read();
            connection.Close();
            return check;
        }
        public bool AddUser(User user)
        {
            if (!validateUser(user))
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string query = String.Format("insert into User1 (Name, Gmail, Password, Role, CNIC, Gender) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", user.GetName(), user.GetGmail(), user.GetPassword(), user.GetRole(), user.GetCnic(), user.GetGender());
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

        public bool IsAdminExists()
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string searchQuery = String.Format("Select * from User1 where Role = '{0}'", "admin");
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            bool check = data.Read();
            connection.Close();
            return check;
        }
        public User IsUserExists(User user)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string searchQuery = String.Format("Select * from User1 where Gmail = '{0}' AND Password='{1}'", user.GetGmail(), user.GetPassword());
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            if (data.Read())
            {

                User storedUser = new User(data.GetString(0), data.GetString(1), data.GetString(2), data.GetString(5), data.GetString(3), data.GetString(4));
                connection.Close();
                return storedUser;
            }
            connection.Close();
            return null;
        }
        public bool IsManagerExists()
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string searchQuery = String.Format("Select * from User1 where Role = '{0}'", "manager");
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            bool check = data.Read();
            connection.Close();
            return check;
        }
        public bool IsManagerExists(string Gmail, string Password)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string searchQuery = String.Format("Select * from User1 where Role = '{0}' AND Gmail='{1}' ANd Password='{2}'", "manager", Gmail, Password);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            bool check = data.Read();
            connection.Close();
            return check;
        }
        public bool DeleteUser(User user)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("DELETE FROM User1 WHERE Gmail = '{0}' AND Password='{1}'", user.GetGmail(), user.GetPassword());
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
        public List<User> GetUserList()
        {
            List<User> userList = new List<User>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = "SELECT * FROM User1";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(5), reader.GetString(3), reader.GetString(4));
                userList.Add(user);
            }
            connection.Close();
            return userList;
        }
        public List<User> GetAmbassadorList()
        {
            string Role = "brand ambassador";
            List<User> userList = new List<User>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("SELECT * FROM User1 where Role='{0}'", Role);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(5), reader.GetString(3), reader.GetString(4));
                userList.Add(user);
            }
            connection.Close();
            return userList;
        }
        public bool UpdateCNIC(string Gmail, string CNIC)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE User1 SET CNIC = '{1}' WHERE Gmail = '{0}'", Gmail, CNIC);
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
        public bool UpdatePassword(string Gmail, string Password)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE User1 SET Password = '{1}' WHERE Gmail = '{0}'", Gmail, Password);
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

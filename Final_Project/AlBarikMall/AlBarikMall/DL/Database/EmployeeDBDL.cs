using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL.Database
{
    public class EmployeeDBDL : IEmployee
    {
        private string ConnectionString;
        public EmployeeDBDL(string connectionString)
        {
            ConnectionString = connectionString;
        }
        private bool validateUser(Employee employee)
        {
            if (employee == null) return false;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select * from Employee where EmployeeId = '{0}'", employee.GetEmployeeId());
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            bool check = data.Read();
            connection.Close();
            return check;
        }
        public bool AddEmployee(Employee employee)
        {
            if (!validateUser(employee))
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string query = String.Format("insert into Employee (Name, Role, Salary, OwnerGmail, EmployeeId) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", employee.GetName(), employee.GetRole(), employee.GetSalary(), employee.GetOwnerGmail(), employee.GetEmployeeId());
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

        public bool RemoveEmployee(string EmployeeId, string OwnerGmail)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("DELETE FROM Employee WHERE EmployeeId = '{0}' AND OwnerGmail='{1}'", EmployeeId, OwnerGmail);
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
        public bool RemoveEmployee(User user)
        {

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("DELETE FROM Employee WHERE OwnerGmail = '{0}'", user.GetGmail());
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
        public bool UpdateOwnerGmail(User user, string Gmail)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE Employee SET OwnerGmail = '{1}' WHERE OwnerGmail = '{0}'", Gmail, user.GetGmail());
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
         
        public List<Employee> GetEmployeeList(string OwnerGmail)
        {
            List<Employee> userList = new List<Employee>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = string.Format("SELECT * FROM Employee where OwnerGmail='{0}'", OwnerGmail);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                Employee user = new Employee(Convert.ToString(reader["Name"]), Convert.ToString(reader["Role"]), Convert.ToInt64(reader["Salary"]), Convert.ToString(reader["OwnerGmail"]), Convert.ToString(reader["EmployeeId"]));

                userList.Add(user);
            }
            connection.Close();
            return userList;
        }
        public double GetTotalSalary(string Gmail)
        {
            string SalesString = null;
            double Sales = 0;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("SELECT SUM(Salary) FROM Employee where OwnerGmail='{0}'", Gmail);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            object data = command.ExecuteScalar();
            if (data != null)
            {
                SalesString = data.ToString();
                connection.Close();
                if (SalesString != null)
                {

                    Sales = double.Parse(SalesString);
                }

            }

            connection.Close();
            return Sales;
        }
    }
}

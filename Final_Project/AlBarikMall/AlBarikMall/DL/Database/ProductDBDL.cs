using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL.Database
{
    public class ProductDBDL : IProduct
    {
        public string ConnectionString;
        public ProductDBDL(string connectionString)
        {
            ConnectionString = connectionString;
        }

        private bool validateProduct(string BrandName, string ProductName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            string searchQuery = String.Format("Select * from Product where Name = '{0}' AND BrandName='{1}'", ProductName, BrandName);
            SqlCommand command = new SqlCommand(searchQuery, connection);
            SqlDataReader data = command.ExecuteReader();
            bool check = data.Read();
            connection.Close();
            return check;
        }
        public bool AddProduct(Products product)
        {
            if (!validateProduct(product.GetBrandName(), product.GetName()))
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                string query = String.Format("insert into Product (Quantity, Name, Price, BrandName, Status) VALUES('{0}', '{1}', '{2}', '{3}', '{4}')", product.GetQuantity(), product.GetName(), product.GetPrice(), product.GetBrandName(), product.GetStatus());
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

        public bool RemoveProducts(string ProductName, string BrandName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("DELETE FROM Product WHERE Name = '{0}' AND BrandName='{1}'", ProductName, BrandName);
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
        public bool RemoveProducts(string BrandName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("DELETE FROM Product WHERE BrandName='{0}'", BrandName);
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

        public bool UpdateProductPrice(string ProductName, float Price, string BrandName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE Product SET Price = '{1}' WHERE BrandName = '{0}' AND Name='{2}'", BrandName, Price, ProductName);
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

        public bool UpdateProductQuantity(string ProductName, int Quantity, string BrandName)
        {
            string Status;
            if (Quantity >= 1)
            {
                Status = "InStock";
            }
            else
            {
                Status = "Out Of Stock";
            }
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE Product SET Quantity = '{1}' , Status='{3}' WHERE BrandName = '{0}' AND Name='{2}'", BrandName, Quantity, ProductName, Status);
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

        public List<Products> GetProducts(string BrandName)
        {
            List<Products> ProductList = new List<Products>();
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("SELECT * FROM Product where BrandName='{0}'", BrandName);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Products product = new Products(Convert.ToInt32(reader["Quantity"]), Convert.ToString(reader["Name"]), Convert.ToString(reader["BrandName"]), Convert.ToInt64(reader["Price"]));
                ProductList.Add(product);
            }
            connection.Close();
            return ProductList;
        }

        public Products GetProducts(string ProductName, string BrandName)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("SELECT * FROM Product where BrandName='{0}'AND Name='{1}'", BrandName, ProductName);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                Products product = new Products(Convert.ToInt32(reader["Quantity"]), Convert.ToString(reader["Name"]), Convert.ToString(reader["BrandName"]), Convert.ToInt64(reader["Price"]));
                connection.Close();
                return product;
            }
            connection.Close();
            return null;
        }
        public bool UpdateProduct(string ProductName, Products p)
        {
            if(p.GetQuantity()==0)
            {
                p.SetStatus("Out of Stock");
            }
            else
            {
                p.SetStatus("Instock");
            }
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string query = String.Format("UPDATE Product SET Name = '{1}', Price='{2}', Quantity='{3}' WHERE BrandName = '{0}' And Name='{4}'", p.GetBrandName(), p.GetName(), p.GetPrice(), p.GetQuantity(), ProductName);
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

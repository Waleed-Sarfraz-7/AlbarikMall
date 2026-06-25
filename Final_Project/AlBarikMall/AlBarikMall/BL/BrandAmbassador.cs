using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.BL
{
    public class BrandAmbassador : User,CURD
    {

        private string BrandName;
        private float Sales = 0;
        private float Fare = 0;
        private List<Products> products = new List<Products>();
        private List<Employee> employees = new List<Employee>();
        public BrandAmbassador(string name, string gmail, string password, string gender, string type, string cnic, string BrandName, float fare) : base(name, gmail, password, gender, type, cnic)
        {
            this.BrandName = BrandName;
            Fare = fare;
        }
        public BrandAmbassador(string name, string gmail, string password, string gender, string cnic, string BrandName, float fare) : base(name, gmail, password, gender, cnic)
        {
            this.BrandName = BrandName;
            Fare = fare;
        }
        public BrandAmbassador(string name, string gmail, string password, string gender, string type, string cnic) : base(name, gmail, password, gender, type, cnic)
        {

        }
        public void SetFare(float fare)
        {
            this.Fare = fare;
        }
        public float GetFare()
        {
            return this.Fare;
        }
        public void SetBrandName(string name)
        {
            this.BrandName = name;
        }
        public string GetBrandName()
        {
            return this.BrandName;
        }
        public void SetSales(float sales)
        {
            this.Sales = sales;
        }
        public void AddToSales(float Sales)
        {
            this.Sales += Sales;
        }
        public float GetSales()
        {
            return this.Sales;
        }
        public void AddProduct(Products p)
        {
            products.Add(p);
        }
        public void RemoveProduct(Products p)
        {
            products.Remove(p);
        }
        public List<Products> GetProductsList()
        {
            return products;
        }
        public void AddEmployee(Employee p)
        {
            employees.Add(p);
        }
        public void RemoveEmployee(Employee p)
        {
            employees.Remove(p);
        }
        public List<Employee> GetEmployeeList()
        {
            return employees;
        }
    }
}

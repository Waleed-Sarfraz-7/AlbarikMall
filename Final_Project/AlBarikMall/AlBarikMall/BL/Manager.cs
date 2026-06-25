using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.BL
{
    public class Manager : User
    {
        private string Announcement;
        private float Salary = 0;
        private List<Employee> Employees = new List<Employee>();
        private List<ProfitOrLoss> ProfitOrLossList = new List<ProfitOrLoss>();
        public Manager(string name, string gmail, string password, string gender, string type, string cnic, float salary) : base(name, gmail, password, gender, type, cnic)
        {
            Salary = salary;
        }
        public void SetSalary(float salary)
        {
            Salary = salary;
        }
        public float GetSalary()
        {
            return Salary;
        }
        public void SetAnnouncement(string A)
        {
            Announcement = A;
        }
        public string GetAnnouncement()
        {
            return Announcement;
        }
        public void AddEmployee(Employee e)
        {
            Employees.Add(e);
        }
        public List<Employee> GetEmployeeList()
        {
            return Employees;
        }
        public void AddProfitOrLoss(ProfitOrLoss profitOrLoss)
        {
            profitOrLoss.SetGmail(Gmail);
            this.ProfitOrLossList.Add(profitOrLoss);
        }
        public List<ProfitOrLoss> GetProfitOrLossList()
        {
            return ProfitOrLossList;
        }
    }
}

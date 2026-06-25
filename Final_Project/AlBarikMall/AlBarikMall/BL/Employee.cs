using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.BL
{
    public class Employee
    {
        private string Name;
        private string Role;
        private string EmployeeId;
        private float Salary = 0;
        private string OwnerGmail;
        public Employee(string name, string type, float Salary, string OwnerGmail, string employeeId)
        {
            Name = name;
            Role = type;
            this.Salary = Salary;
            this.OwnerGmail = OwnerGmail;
            EmployeeId = employeeId;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetEmployeeId(string name)
        {
            EmployeeId = name;
        }
        public string GetEmployeeId()
        {
            return EmployeeId;
        }
        public void SetRole(string name)
        {
            Role = name;
        }
        public string GetRole()
        {
            return Role;
        }
        public void SetSalary(int value)
        {
            this.Salary = value;
        }
        public float GetSalary()
        {
            return this.Salary;
        }
        public void SetOwnerGmail(string e)
        {
            this.OwnerGmail = e;
        }
        public string GetOwnerGmail()
        {
            return this.OwnerGmail;
        }
    }
}

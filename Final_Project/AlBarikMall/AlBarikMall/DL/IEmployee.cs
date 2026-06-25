using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL
{
    public interface IEmployee
    {
        bool AddEmployee(Employee employee);
        bool RemoveEmployee(string Gmail, string OwnerGmail);
        bool UpdateOwnerGmail(User user, string Gmail);
        bool RemoveEmployee(User user);
        List<Employee> GetEmployeeList(string OwnerGmail);
        double GetTotalSalary(string Gmail);
        bool UpdateEmployee(string a, string b, Employee employee);
    }
}

using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL
{
    public interface IUser
    {
        bool AddUser(User user);
        List<User> GetUserList();
        User ConfirmUser(User user);
        bool IsManagerExists();
        bool IsAdminExists();
        bool IsManagerExists(string Gmail, string Password);
        bool DeleteUser(User user);
        List<User> GetAmbassadorList();
        User IsUserExists(User user);
        bool UpdatePassword(string Gmail, string Password);
        bool UpdateCNIC(string Gmail, string Cnic);
    }
}

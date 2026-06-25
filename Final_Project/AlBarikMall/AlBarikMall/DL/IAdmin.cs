using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL
{
    public interface IAdmin
    {
        bool AddShops(string shops, string Gmail);
        int GetShops(string Gmail);
        bool AddAdminInfo(Admin A);
    }
}

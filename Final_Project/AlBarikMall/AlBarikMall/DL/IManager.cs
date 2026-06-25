using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL
{
    public interface IManager
    {
        string GetAnnouncement();
        bool UpdateAnnouncement(string Announcement, string Gmail);
        bool SetManagerInfo(Manager m);
        float GetSalary(string Gmail);
        bool DeleteManagerInfo(User user);

    }
}

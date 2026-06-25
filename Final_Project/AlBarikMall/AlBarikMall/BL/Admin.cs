using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.BL
{
     public class Admin : User
    {
        private Manager MangerInfo;
        private int Shops = 0;
        private List<BrandAmbassador> BrandAmbassadors = new List<BrandAmbassador>();
        public Admin(string name, string gmail, string password, string gender, string type, string cnic) : base(name, gmail, password, gender, type, cnic)
        {

        }
        public Admin(string name, string gmail, string password, string gender, string cnic) : base(name, gmail, password, gender, cnic)
        {

        }
        public void SetManager(Manager m)
        {
            MangerInfo = m;
        }
        public void AddAmbassador(BrandAmbassador b)
        {
            BrandAmbassadors.Add(b);
        }
        public void SetShops(int a)
        { Shops = a; }
        public int GetShops()
        {
            return Shops;
        }
        public Manager GetManagerInfo()

        { return MangerInfo; }
        public List<BrandAmbassador> GetBrandAmbassadorList()
        {
            return BrandAmbassadors;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlBarikMall.DL;
using AlBarikMall.DL.Database;
using AlBarikMall.Utility;

namespace AlBarilWindow
{
    public class ObjectHandler
    {
        static IAdmin ADB = new AdminDBDL(Utility.GetConnectionString());
        static IAmbassador AmbassadorDB=new AmbassadorDBDL(Utility.GetConnectionString());
        static ICustomer CDB=new CustomerDBDL(Utility.GetConnectionString());
        static IEmployee EDB=new EmployeeDBDL(Utility.GetConnectionString());
        static IManager MDB=new ManagerDBDL(Utility.GetConnectionString());
        static IProduct PDB=new ProductDBDL(Utility.GetConnectionString());
        static IProfitOrLoss ProfitDB = new ProfitOrLossDBDL(Utility.GetConnectionString());
        static IUser UDB=new UserDBDL(Utility.GetConnectionString());
        public static IAdmin GetAdminDBDL()
        {
            return ADB;
        }
        public static IAmbassador GetAmbassadorDBDL()
        {
            return AmbassadorDB;
        }
        public static ICustomer GetCustomerDBDL()
        {
            return CDB;
        }
        public static IEmployee GetEmployeeDBDL()
        {
            return EDB;
        }
        public static IManager GetManagerDBDL()
        {
            return MDB;
        }
        public static IProduct GetProductDBDL()
        {
            return PDB;
        }
        public static IProfitOrLoss GetProfitOrLossDBDL()
        {
            return ProfitDB;
        }
        public static IUser GetUserDBDL()
        {
            return UDB;
        }

    }
}

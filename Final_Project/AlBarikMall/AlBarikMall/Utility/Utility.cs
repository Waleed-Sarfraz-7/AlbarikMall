using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.Utility
{
    public class Utility
    {
        static string ConnectionString = "Server=DESKTOP-PDPI01H\\SQLEXPRESS;Database=IndigoFusion;Trusted_Connection=True";

        public static string GetConnectionString()
        {

            return ConnectionString;
        }
    }
}

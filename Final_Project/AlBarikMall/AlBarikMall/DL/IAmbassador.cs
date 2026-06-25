using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL
{
    public interface IAmbassador
    {
        bool EnterAmbasadorInfo(BrandAmbassador brandAmbassador);
        bool IsBrandExists(string BrandName);
        bool DeleteAmbassadorInfo(string Gmail);

        bool UpdateSales(float Sales, string BrandName);
        float GetSales(string Gmail);
        string GetBrandName(string BrandName);
        double GetTotalFare();
        List<string> GetBrandsList();
    }
}

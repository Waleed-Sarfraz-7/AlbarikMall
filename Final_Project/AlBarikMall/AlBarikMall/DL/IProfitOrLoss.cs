using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL
{
    public interface IProfitOrLoss
    {
        bool AddProfitOrLoss(ProfitOrLoss profitOrLoss);
        ProfitOrLoss GetProfitOrLoss(string month, int Year);
        List<ProfitOrLoss> GetProfitOrLosses();
    }
}

using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL
{
    public interface ICustomer
    {
        bool StoreCustomerInfo(Customer customer);
        int GetTotalNumberOfProductsBought(string Gmail);
        bool UpdateTotalNumberOfProductsBought(int BoughtProducts, string Gmail);
        float GetTotalAmountSpend(string Gmail);
        bool UpdateTotalAmountSpend(float AmountSpend, string Gmail);
        bool UpdateFeedback(string Feedback, string Gmail);
        List<String> GetFeedbacksList();

    }
}

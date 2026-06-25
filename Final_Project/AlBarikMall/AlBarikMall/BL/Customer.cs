using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.BL
{
    public class Customer : User
    {
        private string FeedBack = null;
        private int TotalProductsPurschased = 0;
        private float TotalAmountSpend = 0;

        public Customer(string name, string gmail, string password, string gender, string type, string cnic) : base(name, gmail, password, gender, type, cnic)
        {

        }

        public void SetFeedBack(string f)
        {
            FeedBack = f;
        }
        public string GetFeedBack()
        {
            return FeedBack;
        }
        public void SetTotalProductsPurchased(int purchase)
        {
            this.TotalProductsPurschased = purchase;
        }
        public void AddtoTotalProductsPurchased()
        {
            this.TotalProductsPurschased++;
        }
        public int GetTotalProductsPurchased()
        {
            return this.TotalProductsPurschased;
        }
        public void SetTotalAmountSpend(float purchase)
        {
            this.TotalAmountSpend = purchase;
        }
        public void AddtoTotalAmountSpend(float purchase)
        {
            this.TotalAmountSpend += purchase;
        }
        public float GetTotalAmountSpend()
        {
            return this.TotalAmountSpend;
        }
    }
}

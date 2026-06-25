using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.BL
{
    public class Products : CURD
    {
        private int Quantity;
        private string Name;
        private string BrandName;
        private float Price = 0;
        private string Status;
        public Products(int quantity, string name, string brandName, float price)
        {
            Quantity = quantity;
            Name = name;

            BrandName = brandName;
            if (Quantity > 0)
                Status = "InStock";
            else
                Status = "Out of Stock";

            Price = price;
        }
        public void SetPrice(float price)
        {
            Price = price;
        }
        public float GetPrice()
        {
            return Price;
        }
        public void SetBrandName(string brandName)
        {
            BrandName = brandName;
        }
        public void SetQuantity(int quantity)
        {
            this.Quantity = quantity;
        }
        public int GetQuantity()
        {
            return this.Quantity;
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }
        public string GetBrandName()
        {
            return this.BrandName;
        }
        public void SetStatus(string Status)
        {
            this.Status = Status;
        }
        public string GetStatus()
        {
            return this.Status;
        }
    }
}

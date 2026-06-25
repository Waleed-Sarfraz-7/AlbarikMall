using AlBarikMall.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.DL
{
    public interface IProduct
    {
        bool AddProduct(Products product);
        bool RemoveProducts(string ProductName, string BrandName);
        bool RemoveProducts(string BrandName);
        bool UpdateProductPrice(string ProductName, float Price, string BrandName);
        bool UpdateProductQuantity(string ProductName, int Quantity, string BrandName);
        List<Products> GetProducts(string BrandName);
          Products GetProducts(string ProductName, string BrandName);



    }

}

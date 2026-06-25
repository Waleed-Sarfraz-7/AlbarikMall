using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlBarikMall.BL
{
    public class ProfitOrLoss
    {
        private float Tax;
        private float ElectricityBill;
        private float WaterBill;
        private float OtherExpenditure;
        private string Month;
        private int Year;
        private float Amount;
        private string Gmail;
        public ProfitOrLoss(string month, int year, float amount)
        {
            Month = month;
            Year = year;
            Amount = amount;
        }
        public ProfitOrLoss(string month, int year, float amount, float tax, float electricityBill, float waterBill, float otherExpenditure)
        {
            Tax = tax;
            ElectricityBill = electricityBill;
            WaterBill = waterBill;
            OtherExpenditure = otherExpenditure;
            Month = month;
            Year = year;
            Amount = amount;
        }
        public void SetTax(float tax)
        {
            Tax = tax;
        }
        public float GetTax()
        {
            return Tax;
        }
        public void SetElectricityBill(float electricityBill)
        {
            ElectricityBill = electricityBill;
        }
        public float GetElectricityBill()
        {
            return ElectricityBill;
        }
        public void SetWaterBill(float waterBill)
        {
            WaterBill = waterBill;
        }
        public float GetWaterBill()

        { return WaterBill; }
        public void SetOtherExpenditures(float otherExpenditures)
        {
            OtherExpenditure = otherExpenditures;
        }
        public float GetOtherExpenditures()
        {
            return OtherExpenditure;
        }
        public void SetGmail(string mail)
        {
            Gmail = mail;
        }
        public string GetGmail()
        {
            return Gmail;
        }
        public void SetMonth(string mpnth)
        {
            this.Month = mpnth;
        }
        public void SetYear(int Year)
        {
            this.Year = Year;
        }
        public void SetAmount(float Amount)
        {
            this.Amount = Amount;
        }
        public string GetMonth()
        {
            return this.Month;
        }
        public int GetYear()
        {
            return this.Year;
        }
        public float GetAmount()
        {
            return this.Amount;
        }
    }
}

using AlBarilWindow.UI.SignInSignUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlBarilWindow.UI.Custome
{
    public partial class CustomerMenu : Form
    {
        private static int NoOfBoughtProduct = 0;
        private static float AmountSpend = 0;
        public static void SetNoOfBoughtProduct(int noOfBoughtProduct)
        {

            NoOfBoughtProduct = noOfBoughtProduct;
        }
        public static void SetAmountSpend(float noOfBoughtProduct)
        {

            AmountSpend = noOfBoughtProduct;
        }
        public static void UpdateNoOfBoughtProduct(int noOfBoughtProduct)
        {

            NoOfBoughtProduct = NoOfBoughtProduct + noOfBoughtProduct;
        }
        public static void UpdateAmountSpend(float noOfBoughtProduct)
        {

            AmountSpend = +AmountSpend + noOfBoughtProduct;
        }
        public static int GetNoOfBoughtProduct()
        {
            return NoOfBoughtProduct;
        }
        public static float GetAmountSpend()
        {
            return AmountSpend;
        }
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addfeedback addfeedback = new Addfeedback();
            this.Hide();

            addfeedback.ShowDialog();
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            this.Hide();
            buy.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            this.Hide();

            bill.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TransactionHistory transactionHistory = new TransactionHistory();
            this.Hide();
            transactionHistory.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CPCustomer cPCustomer = new CPCustomer();
            this.Hide();
            cPCustomer.ShowDialog();
        }
    }
}

using AlBarikMall.DL.Database;
using AlBarikMall.DL;
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
using AlBarikMall.Utility;

namespace AlBarilWindow.UI.Custome
{
    public partial class TransactionHistory : Form
    {
        public TransactionHistory()
        {
            InitializeComponent();
            ICustomer CDB = new CustomerDBDL(Utility.GetConnectionString());
            ProductsBoughttxt.Text = (CDB.GetTotalNumberOfProductsBought(SignIn.GetUserGmail()).ToString());
            AmountSpendtxt.Text = (CDB.GetTotalAmountSpend(SignIn.GetUserGmail()).ToString());
        }

        private void TransactionHistory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMenu = new CustomerMenu();
            this.Hide();
            customerMenu.ShowDialog();
        }
    }
}

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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            Numbertxt.Text = CustomerMenu.GetNoOfBoughtProduct().ToString();
            Billtxt.Text = CustomerMenu.GetAmountSpend().ToString();
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            CustomerMenu.SetNoOfBoughtProduct(0);
            CustomerMenu.SetAmountSpend(0);
            CustomerMenu customerMain = new CustomerMenu();
            this.Hide(); customerMain.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMain = new CustomerMenu();
            this.Hide(); customerMain.ShowDialog();
        }
    }
}

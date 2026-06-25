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

namespace AlBarilWindow.UI.Ambassador1
{
    public partial class SeeSalesAmbassador : Form
    {
        public SeeSalesAmbassador()
        {
            InitializeComponent();
            IAmbassador AmbassadorDB = new AmbassadorDBDL(Utility.GetConnectionString());
            textBox1.Text = AmbassadorDB.GetSales(SignIn.GetUserGmail()).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmbassadorMian ambassadorMian = new AmbassadorMian();
            this.Hide();
            ambassadorMian.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

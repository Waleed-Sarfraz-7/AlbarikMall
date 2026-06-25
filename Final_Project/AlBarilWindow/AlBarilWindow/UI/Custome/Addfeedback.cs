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

namespace AlBarilWindow.UI.Custome
{
    public partial class Addfeedback : Form
    {
        public Addfeedback()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ICustomer CDB = ObjectHandler.GetCustomerDBDL();

            if (CDB.UpdateFeedback(textBox1.Text, SignIn.GetUserGmail()))
            {
                MessageBox.Show("Your Feedback Is stored");
            }
            else
            {
                MessageBox.Show("Feedback Does not Stored");
            }
            CustomerMenu customerMain = new CustomerMenu();
            this.Hide(); customerMain.ShowDialog();
        }

        private void Addfeedback_Load(object sender, EventArgs e)
        {

        }
    }
}

using AlBarikMall.DL;
using AlBarilWindow.UI.AdminUI;
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
    public partial class ChangeCnicCustomer : Form
    {
        IUser UDB = ObjectHandler.GetUserDBDL();

        public ChangeCnicCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UDB.UpdateCNIC(SignIn.GetUserGmail(), textBox2.Text))
            {
                MessageBox.Show("Cnic Updated successfully");
            }
            else
            {
                MessageBox.Show("CNIC does not Updated");
            }
            CustomerMenu u = new CustomerMenu();
            this.Hide();
            u.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ChangeCnicCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}

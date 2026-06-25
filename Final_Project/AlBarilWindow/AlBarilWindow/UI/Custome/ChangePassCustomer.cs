using AlBarikMall.BL;
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
    public partial class ChangePassCustomer : Form
    {
        IUser UDB = ObjectHandler.GetUserDBDL();

        public ChangePassCustomer()
        {
            InitializeComponent();
        }

        private void ChangePassCustomer_Load(object sender, EventArgs e)
        {
            User user = new User(SignIn.GetUserGmail(), PreviosPasswordtxt.Text);
            user = UDB.ConfirmUser(user);
            if (user != null)
            {
                if (UDB.UpdatePassword(SignIn.GetUserGmail(), NewPasswordtxt.Text))
                {
                    MessageBox.Show("Password Updated successfully");
                }
                else
                {
                    MessageBox.Show("Password does not Updated");
                }
            }
            else
            {
                MessageBox.Show("Wrong Previous Password");
            }
            CustomerMenu u = new CustomerMenu();
            this.Hide();
            u.ShowDialog();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {

        }
    }
}

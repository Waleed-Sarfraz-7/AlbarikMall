using AlBarikMall.BL;
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

namespace AlBarilWindow.UI.Manager1
{
    public partial class ChangePassword : Form
    {
        IUser UDB = ObjectHandler.GetUserDBDL();
        IManager MDB = ObjectHandler.GetManagerDBDL();
        IAdmin ADB = ObjectHandler.GetAdminDBDL();
        IEmployee EDB = ObjectHandler.GetEmployeeDBDL();
        IProduct PDB = ObjectHandler.GetProductDBDL();
        IAmbassador AmbassadorDB = ObjectHandler.GetAmbassadorDBDL();
        ICustomer CDB = ObjectHandler.GetCustomerDBDL();
        IProfitOrLoss ProfirDB = ObjectHandler.GetProfitOrLossDBDL();
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
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
            ManagerMenu managerMenu = new ManagerMenu();
            this.Hide();
            managerMenu.ShowDialog();

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }
    }
}

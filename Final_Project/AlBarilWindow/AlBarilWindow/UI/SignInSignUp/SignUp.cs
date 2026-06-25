using AlBarikMall.BL;
using AlBarikMall.DL.Database;
using AlBarikMall.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlBarilWindow.UI.SignInSignUp
{
    public partial class SignUp : Form
    {
        IUser UDB = ObjectHandler.GetUserDBDL();
        IManager MDB =ObjectHandler.GetManagerDBDL();
        IAdmin ADB = ObjectHandler.GetAdminDBDL();
        IEmployee EDB = ObjectHandler.GetEmployeeDBDL();
        IProduct PDB = ObjectHandler.GetProductDBDL();
        IAmbassador AmbassadorDB = ObjectHandler.GetAmbassadorDBDL();
        ICustomer CDB=ObjectHandler.GetCustomerDBDL();
        IProfitOrLoss ProfirDB=ObjectHandler.GetProfitOrLossDBDL();




        public SignUp()
        {
            InitializeComponent();
            Gender.Items.Add("male");
            Gender.Items.Add("female");
            Gender.Items.Add("custom");
            Role.Items.Add("admin");
            Role.Items.Add("customer");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Name1.Text);
            User user1 = null;
            IUser user = ObjectHandler.GetUserDBDL();

            if (Role.Text == "admin" && user.IsAdminExists() == false)
            {
                user1 = new Admin(Name1.Text, Gmail.Text, Password.Text, Gender.Text, "admin", CNIC.Text);
                Admin admin = (Admin)user1;
                ADB.AddAdminInfo(admin);
            }
            else if (Role.Text == "customer")
            {
                user1 = new Customer(Name1.Text, Gmail.Text, Password.Text, Gender.Text, "customer", CNIC.Text);
                Customer customer = (Customer)user1;

                CDB.StoreCustomerInfo(customer);
            }



            bool b = user.AddUser(user1);
            if (b == true)
            {
                MessageBox.Show("User Added Successfully");
            }
            else
            {
                MessageBox.Show("User Not Added");
            }

            SignIn s = new SignIn();
            this.Hide();
            s.ShowDialog();
        }
    }
}

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

namespace AlBarilWindow.UI.AdminUI
{
    public partial class AddShops : Form
    {
        IUser UDB = ObjectHandler.GetUserDBDL();
        IManager MDB = ObjectHandler.GetManagerDBDL();
        IAdmin ADB = ObjectHandler.GetAdminDBDL();
        IEmployee EDB = ObjectHandler.GetEmployeeDBDL();
        IProduct PDB = ObjectHandler.GetProductDBDL();
        IAmbassador AmbassadorDB = ObjectHandler.GetAmbassadorDBDL();
        ICustomer CDB = ObjectHandler.GetCustomerDBDL();
        IProfitOrLoss ProfirDB = ObjectHandler.GetProfitOrLossDBDL();
        int SelectedRow = 0;
        public AddShops()
        {
            InitializeComponent();
            MessageBox.Show(ADB.GetShops(SignIn.GetUserGmail()).ToString());
            Shopstxt.Text = ADB.GetShops(SignIn.GetUserGmail()).ToString();
            int n=UDB.GetAmbassadorList().Count;
            Availabletxt.Text = (ADB.GetShops(SignIn.GetUserGmail()) - n).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddShops_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if(int.Parse(Shopstxt.Text)> int.Parse(Availabletxt.Text))
            {
                if (ADB.AddShops((Shopstxt.Text), SignIn.GetUserGmail()))
                { MessageBox.Show("Shops Added Successfully"); }
            }
            else
            {
                MessageBox.Show("Shops Not Added.We will count previous Shops");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu= new AdminMenu();
            this.Hide();
            adminMenu.ShowDialog();
        }
    }
}

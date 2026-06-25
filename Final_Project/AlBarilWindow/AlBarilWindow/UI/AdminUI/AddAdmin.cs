using AlBarikMall.BL;
using AlBarikMall.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlBarilWindow.UI.AdminUI
{
    public partial class AddAdmin : Form
    {
        IUser UDB = ObjectHandler.GetUserDBDL();
        IManager MDB = ObjectHandler.GetManagerDBDL();
        IAdmin ADB = ObjectHandler.GetAdminDBDL();
        IEmployee EDB = ObjectHandler.GetEmployeeDBDL();
        IProduct PDB = ObjectHandler.GetProductDBDL();
        IAmbassador AmbassadorDB = ObjectHandler.GetAmbassadorDBDL();
        ICustomer CDB = ObjectHandler.GetCustomerDBDL();
        IProfitOrLoss ProfirDB = ObjectHandler.GetProfitOrLossDBDL();
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager m = new Manager(Name1.Text, Gmail.Text, Password.Text, Gender.Text, "manager", CNIC.Text, float.Parse(Salary.Text));


            if (UDB.AddUser(m) == true)
            {
                MDB.SetManagerInfo(m);
                MessageBox.Show("Manager Added Successfully");
            }
            else
            {
                MessageBox.Show("Manager Does not Added");
            }
            AdminMenu u = new AdminMenu();
            this.Hide();
            u.ShowDialog();
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}

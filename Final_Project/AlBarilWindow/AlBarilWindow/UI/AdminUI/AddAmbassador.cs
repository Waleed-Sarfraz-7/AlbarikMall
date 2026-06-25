using AlBarikMall.BL;
using AlBarikMall.DL;
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
    public partial class AddAmbassador : Form
    {


        IUser UDB = ObjectHandler.GetUserDBDL();
        IManager MDB = ObjectHandler.GetManagerDBDL();
        IAdmin ADB = ObjectHandler.GetAdminDBDL();
        IEmployee EDB = ObjectHandler.GetEmployeeDBDL();
        IProduct PDB = ObjectHandler.GetProductDBDL();
        IAmbassador AmbassadorDB = ObjectHandler.GetAmbassadorDBDL();
        ICustomer CDB = ObjectHandler.GetCustomerDBDL();
        IProfitOrLoss ProfirDB = ObjectHandler.GetProfitOrLossDBDL();
        DataTable datatable=new DataTable();
        public AddAmbassador()
        {
            InitializeComponent();
            
        }

        private void AddAmbassador_Load(object sender, EventArgs e)
        {

        }

        private void List1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void List1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BrandAmbassador m = new BrandAmbassador(Name1.Text, Gmail.Text, Password.Text, Gender.Text, "brand ambassador", CNIC.Text, BrandName.Text, float.Parse(Fare.Text));

            if (AmbassadorDB.IsBrandExists(BrandName.Text) == false)
            {
                if (UDB.AddUser(m))
                {
                    AmbassadorDB.EnterAmbasadorInfo(m);
                    MessageBox.Show("Ambassador Successfully ADDEd");
                }
                else
                {
                    MessageBox.Show("Ambassador Not Added");
                }
            }
            else
            {
                MessageBox.Show("Brand AMbassador of this brand already exists");
            }
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.ShowDialog();
        }
    }
}

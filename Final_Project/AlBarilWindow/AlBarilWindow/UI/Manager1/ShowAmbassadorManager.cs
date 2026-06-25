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

namespace AlBarilWindow.UI.Manager1
{
    public partial class ShowAmbassadorManager : Form
    {
        IUser UDB = ObjectHandler.GetUserDBDL();
        IManager MDB = ObjectHandler.GetManagerDBDL();
        IAdmin ADB = ObjectHandler.GetAdminDBDL();
        IEmployee EDB = ObjectHandler.GetEmployeeDBDL();
        IProduct PDB = ObjectHandler.GetProductDBDL();
        IAmbassador AmbassadorDB = ObjectHandler.GetAmbassadorDBDL();
        ICustomer CDB = ObjectHandler.GetCustomerDBDL();
        IProfitOrLoss ProfirDB = ObjectHandler.GetProfitOrLossDBDL();
        public ShowAmbassadorManager()
        {
            InitializeComponent();
            DataTable datatable = new DataTable();
            datatable.Columns.Add("Name");
            datatable.Columns.Add("Gmail");
            datatable.Columns.Add("Gender");
            datatable.Columns.Add("Cnic");

            List<User> list = UDB.GetAmbassadorList();
            foreach (User m in list)
            {
                datatable.Rows.Add(m.GetName(), m.GetGmail(), m.GetGender(), m.GetCnic());
            }
            List1.DataSource = datatable;
        }

        private void ShowAmbassadorManager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerMenu managerMenu = new ManagerMenu();
            this.Hide();
            managerMenu.ShowDialog();
        }
    }
}

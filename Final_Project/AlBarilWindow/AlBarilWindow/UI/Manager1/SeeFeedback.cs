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
    public partial class SeeFeedback : Form
    {

        IUser UDB = ObjectHandler.GetUserDBDL();
        IManager MDB = ObjectHandler.GetManagerDBDL();
        IAdmin ADB = ObjectHandler.GetAdminDBDL();
        IEmployee EDB = ObjectHandler.GetEmployeeDBDL();
        IProduct PDB = ObjectHandler.GetProductDBDL();
        IAmbassador AmbassadorDB = ObjectHandler.GetAmbassadorDBDL();
        ICustomer CDB = ObjectHandler.GetCustomerDBDL();

        IProfitOrLoss ProfirDB = ObjectHandler.GetProfitOrLossDBDL();
        public SeeFeedback()
        {
            InitializeComponent();
            DataTable datatable = new DataTable();
            datatable.Columns.Add("Sr No");
            datatable.Columns.Add("FeedBack");
            int i = 1;
            List<string> list = CDB.GetFeedbacksList();
            foreach (String m in list)
            {
                datatable.Rows.Add(i, m);
                i++;
            }
            List1.DataSource = datatable;
        }

        private void List1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagerMenu managerMenu = new ManagerMenu();
            this.Hide();
            managerMenu.ShowDialog();
        }

        private void SeeFeedback_Load(object sender, EventArgs e)
        {

        }
    }
}

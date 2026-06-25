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

namespace AlBarilWindow.UI.Ambassador1
{
    public partial class AddEmployeeAmbassador : Form
    {
        IUser UDB = ObjectHandler.GetUserDBDL();
        IManager MDB = ObjectHandler.GetManagerDBDL();
        IAdmin ADB = ObjectHandler.GetAdminDBDL();
        IEmployee EDB = ObjectHandler.GetEmployeeDBDL();
        IProduct PDB = ObjectHandler.GetProductDBDL();
        IAmbassador AmbassadorDB = ObjectHandler.GetAmbassadorDBDL();
        ICustomer CDB = ObjectHandler.GetCustomerDBDL();
        IProfitOrLoss ProfirDB = ObjectHandler.GetProfitOrLossDBDL();
        DataTable dataTable = new DataTable();
        int SelectedRow = 0;
        public AddEmployeeAmbassador()
        {
            InitializeComponent();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("EmployeeId");
            dataTable.Columns.Add("Salary");
            dataTable.Columns.Add("Role");
            List<Employee> list;
            list = EDB.GetEmployeeList(SignInSignUp.SignIn.GetUserGmail());

            foreach (Employee m in list)
            {
                dataTable.Rows.Add(m.GetName(), m.GetEmployeeId(), m.GetSalary(), m.GetRole());
            }
            Table1.DataSource = dataTable;
        }

        private void AddEmployeeAmbassador_Load(object sender, EventArgs e)
        {

        }

        private void Table1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = Table1.CurrentCell.RowIndex;
            if (SelectedRow >= 0)
            {
                DataGridViewRow row = Table1.Rows[SelectedRow];
                Nametxt.Text = row.Cells[0].Value.ToString();
                EmployeeIdtxt.Text = row.Cells[1].Value.ToString();
                Salarytxt.Text = row.Cells[2].Value.ToString();
                Roletxt.Text = row.Cells[3].Value.ToString();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Employee m = new Employee(Nametxt.Text, Roletxt.Text, float.Parse(Salarytxt.Text), SignIn.GetUserGmail(), EmployeeIdtxt.Text);
            if (ObjectHandler.GetEmployeeDBDL().AddEmployee(m))
            {
                dataTable.Rows.Add(m.GetName(), m.GetEmployeeId(), m.GetSalary().ToString(), m.GetRole());
                Table1.DataSource = dataTable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedRow = Table1.CurrentCell.RowIndex;
            DataGridViewRow row = Table1.Rows[SelectedRow];
            Employee m = new Employee(Nametxt.Text, Roletxt.Text, float.Parse(Salarytxt.Text), SignIn.GetUserGmail(), EmployeeIdtxt.Text);

            if (EDB.UpdateEmployee(row.Cells[1].Value.ToString(), SignIn.GetUserGmail(), m))
            {
                row.Cells[0].Value = Nametxt.Text;
                row.Cells[1].Value = EmployeeIdtxt.Text;
                row.Cells[2].Value = Salarytxt.Text;
                row.Cells[3].Value = Roletxt.Text;
                Nametxt.Text = null;
                EmployeeIdtxt.Text = null;
                Salarytxt.Text = null;
                Roletxt.Text = null;

            }
            else
            {
                MessageBox.Show("Sorry");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectedRow = Table1.CurrentCell.RowIndex;
            DataGridViewRow row = Table1.Rows[SelectedRow];
            Employee m = new Employee(row.Cells[0].Value.ToString(), row.Cells[3].Value.ToString(), float.Parse(row.Cells[2].Value.ToString()), SignIn.GetUserGmail(), row.Cells[1].Value.ToString());
            if (ObjectHandler.GetEmployeeDBDL().RemoveEmployee(m.GetEmployeeId(), SignIn.GetUserGmail()))
            {
                Table1.Rows.RemoveAt(SelectedRow);
                Nametxt.Text = null; Salarytxt.Text = null;
                EmployeeIdtxt.Text = null;
                Roletxt.Text = null;
            }
            else
            {
                MessageBox.Show("An occured in deleting Medicine");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AmbassadorMian ambassadorMian = new AmbassadorMian();
            this.Hide();
            ambassadorMian.ShowDialog();
        }
    }
}

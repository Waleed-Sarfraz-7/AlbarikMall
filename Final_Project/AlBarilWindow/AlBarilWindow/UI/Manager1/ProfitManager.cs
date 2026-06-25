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
    public partial class ProfitManager : Form
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
        int SelectedRow=0;
        public ProfitManager()
        {
            InitializeComponent();
            dataTable.Columns.Add("Month");
            dataTable.Columns.Add("Year");
            dataTable.Columns.Add("Profit");
            dataTable.Columns.Add("Loss");
            dataTable.Columns.Add("ElectricityBill");
            dataTable.Columns.Add("WaterBill");
            dataTable.Columns.Add("OtherExpenditures");
            dataTable.Columns.Add("Tax");


            List<ProfitOrLoss> list;
            list = ProfirDB.GetProfitOrLosses();
            float Profit = 0;
            float Loss = 0;
            foreach (ProfitOrLoss m in list)
            {
                if (m.GetAmount() >= 0)
                {
                    Profit = m.GetAmount();
                    Loss = 0;

                }
                if (m.GetAmount() < 0)
                {
                    Loss = -1 * m.GetAmount();
                    Profit = 0;
                }
                dataTable.Rows.Add(m.GetMonth(), m.GetYear(), Profit, Loss, m.GetElectricityBill(), m.GetWaterBill(), m.GetOtherExpenditures(), m.GetTax());
            }
            Table1.DataSource = dataTable;
        }

        private void Table1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = Table1.CurrentCell.RowIndex;
            if (SelectedRow >= 0)
            {
                DataGridViewRow row = Table1.Rows[SelectedRow];
                Monthtxt.Text = row.Cells[0].Value.ToString();
                Yeartxt.Text = row.Cells[1].Value.ToString();
                Electricitytxt.Text = row.Cells[4].Value.ToString();
                Watertxt.Text = row.Cells[5].Value.ToString();
                Otxt.Text = row.Cells[6].Value.ToString();
                Taxtxt.Text = row.Cells[7].Value.ToString();

            }
        }

        private void Table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float Sales = 0;
            float Salary = 0;
            float Amount;
            float Profit = 0;
            float Loss = 0;

            if (Monthtxt.Text != null && Yeartxt.Text != null && Taxtxt.Text != null && Electricitytxt.Text != null && Watertxt.Text != null && Otxt.Text != null)
            {
                Sales = (float)AmbassadorDB.GetTotalFare();
                Salary = (float)ObjectHandler.GetEmployeeDBDL().GetTotalSalary(SignIn.GetUserGmail());
                Amount = Sales - (Salary + float.Parse(Electricitytxt.Text) + float.Parse(Watertxt.Text) + float.Parse(Taxtxt.Text) + float.Parse(Otxt.Text));
                ProfitOrLoss m = new ProfitOrLoss(Monthtxt.Text, int.Parse(Yeartxt.Text), Amount, float.Parse(Taxtxt.Text), float.Parse(Electricitytxt.Text), float.Parse(Watertxt.Text), float.Parse(Otxt.Text));
                if (ObjectHandler.GetProfitOrLossDBDL().AddProfitOrLoss(m))
                {
                    if (m.GetAmount() >= 0)
                    {
                        Profit = m.GetAmount();
                        Loss = 0;

                    }
                    if (m.GetAmount() < 0)
                    {
                        Loss = -1 * m.GetAmount();
                        Profit = 0;
                    }
                    dataTable.Rows.Add(m.GetMonth(), m.GetYear(), Profit, Loss, m.GetElectricityBill(), m.GetWaterBill(), m.GetOtherExpenditures(), m.GetTax());
                    Table1.DataSource = dataTable;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManagerMenu managerMenu = new ManagerMenu();
            this.Hide();
            managerMenu.ShowDialog();
        }

        private void ProfitManager_Load(object sender, EventArgs e)
        {

        }
    }
}

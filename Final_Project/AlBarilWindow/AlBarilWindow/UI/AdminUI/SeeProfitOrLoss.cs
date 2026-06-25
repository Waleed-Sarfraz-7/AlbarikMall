using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlBarikMall.BL;
using AlBarikMall.DL;
using AlBarikMall.DL.Database;
using AlBarikMall.Utility;

namespace AlBarilWindow.UI.AdminUI
{
    public partial class SeeProfitOrLoss : Form
    {
        DataTable dataTable=new DataTable();
        IUser UDB = ObjectHandler.GetUserDBDL();
        IManager MDB = ObjectHandler.GetManagerDBDL();
        IAdmin ADB = ObjectHandler.GetAdminDBDL();
        IEmployee EDB = ObjectHandler.GetEmployeeDBDL();
        IProduct PDB = ObjectHandler.GetProductDBDL();
        IAmbassador AmbassadorDB = ObjectHandler.GetAmbassadorDBDL();
        ICustomer CDB = ObjectHandler.GetCustomerDBDL();
        IProfitOrLoss ProfirDB = ObjectHandler.GetProfitOrLossDBDL();
        int SelectedRow = 0;
        public SeeProfitOrLoss()
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
            list = ObjectHandler.GetProfitOrLossDBDL().GetProfitOrLosses();
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
            dataGridView1.DataSource = dataTable;
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = dataGridView1.CurrentCell.RowIndex;
            if (SelectedRow >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[SelectedRow];
                Monthtxt.Text = row.Cells[0].Value.ToString();
                Yeartxt.Text = row.Cells[1].Value.ToString();
                Electricitytxt.Text = row.Cells[4].Value.ToString();
                Watertxt.Text = row.Cells[5].Value.ToString();
                Otxt.Text = row.Cells[6].Value.ToString();
                Taxtxt.Text = row.Cells[7].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu=new AdminMenu();
            this.Hide();
            adminMenu.ShowDialog();
        }

        private void SeeProfitOrLoss_Load(object sender, EventArgs e)
        {

        }
    }
}

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
using AlBarikMall.BL;

namespace AlBarilWindow.UI.Ambassador1
{
    public partial class ProductManager : Form
    {
        IUser UDB = ObjectHandler.GetUserDBDL();
        IManager MDB = ObjectHandler.GetManagerDBDL();
        IAdmin ADB = ObjectHandler.GetAdminDBDL();
        IEmployee EDB = ObjectHandler.GetEmployeeDBDL();
        IProduct PDB = ObjectHandler.GetProductDBDL();
        IAmbassador AmbassadorDB = ObjectHandler.GetAmbassadorDBDL();
        ICustomer CDB = ObjectHandler.GetCustomerDBDL();
        IProfitOrLoss ProfirDB = ObjectHandler.GetProfitOrLossDBDL();
        DataTable dataTable=new DataTable();
        int SelectedRow = 0;
        public ProductManager()
        {
            InitializeComponent();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Brand Name");
           
            List<Products> list;
            list = PDB.GetProducts(AmbassadorMian.GetUserBrandName());

            foreach (Products m in list)
            {
                dataTable.Rows.Add(m.GetName(), m.GetPrice(), m.GetQuantity(), m.GetBrandName());
            }
            Table1.DataSource = dataTable;
        }

        private void Table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
             Products m = new Products( int.Parse(Quantitytxt.Text), Nametxt.Text, AmbassadorMian.GetUserBrandName(),float.Parse(Pricetxt.Text) );
            if (PDB.AddProduct(m))
            {
                dataTable.Rows.Add(m.GetName(), m.GetPrice(), m.GetQuantity(), m.GetBrandName());
                Table1.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Not Added");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectedRow = Table1.CurrentCell.RowIndex;
            if (SelectedRow >= 0)
            {
                DataGridViewRow row = Table1.Rows[SelectedRow];
                Products m = new Products(int.Parse(Quantitytxt.Text), Nametxt.Text, AmbassadorMian.GetUserBrandName(), float.Parse(Pricetxt.Text));
                if (PDB.UpdateProduct(row.Cells[0].Value.ToString(), m))
                {
                    row.Cells[0].Value = Nametxt.Text;
                    row.Cells[1].Value = Pricetxt.Text;
                    row.Cells[2].Value = Quantitytxt.Text;

                    Nametxt.Text = null; Pricetxt.Text = null;
                    Quantitytxt.Text = null;
                }
                else
                {
                    MessageBox.Show("Error in Updating");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectedRow = Table1.CurrentCell.RowIndex;
            DataGridViewRow row = Table1.Rows[SelectedRow];
            Products m = new Products(int.Parse(row.Cells[2].Value.ToString()), (row.Cells[0].Value.ToString()),AmbassadorMian.GetUserBrandName(), float.Parse(row.Cells[1].Value.ToString()));
            if (PDB.RemoveProducts(m.GetName(), m.GetBrandName()))
            {
                Table1.Rows.RemoveAt(SelectedRow);
                Nametxt.Text = null; Pricetxt.Text = null;
                Quantitytxt.Text = null;
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

        private void Table1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = Table1.CurrentCell.RowIndex;
            if (SelectedRow >= 0)
            {
                DataGridViewRow row = Table1.Rows[SelectedRow];
                Nametxt.Text = row.Cells[0].Value.ToString();
                Pricetxt.Text = row.Cells[1].Value.ToString();
                Quantitytxt.Text = row.Cells[2].Value.ToString();

            }
        }
    }
}

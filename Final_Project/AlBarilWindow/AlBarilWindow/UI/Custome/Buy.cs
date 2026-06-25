using AlBarikMall.BL;
using AlBarikMall.DL;
using AlBarilWindow.UI.Ambassador1;
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

namespace AlBarilWindow.UI.Custome
{
    public partial class Buy : Form
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
        public Buy()
        {
            InitializeComponent();
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Price");
            dataTable.Columns.Add("Available Stock");
            dataTable.Columns.Add("Brand Name");

            List<Products> list;
            list = PDB.GetProducts(AmbassadorMian.GetUserBrandName());

            foreach (Products m in list)
            {
                dataTable.Rows.Add(m.GetName(), m.GetPrice(), m.GetQuantity(), m.GetBrandName()); 
            }
            Table1.DataSource = dataTable;
        }

        private void Table1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = Table1.CurrentCell.RowIndex;
            if (SelectedRow >= 0)
            {
                DataGridViewRow row = Table1.Rows[SelectedRow];
                Nametxt.Text = row.Cells[0].Value.ToString();
                Pricetxt.Text = row.Cells[1].Value.ToString();
                BrandNametxt.Text = row.Cells[3].Value.ToString();  

            }
        }

        private void Table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buy_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Products p = PDB.GetProducts(Nametxt.Text, BrandNametxt.Text);
            if (p != null)
            {
                if (p.GetQuantity() >= int.Parse(Quantitytxt.Text))
                {
                    PDB.UpdateProductQuantity(p.GetName(), p.GetQuantity() - int.Parse(Quantitytxt.Text), p.GetBrandName());
                    CustomerMenu.UpdateNoOfBoughtProduct(int.Parse(Quantitytxt.Text));
                    CustomerMenu.UpdateAmountSpend(p.GetPrice()* int.Parse(Quantitytxt.Text));
                    CDB.UpdateTotalAmountSpend(p.GetPrice()* int.Parse(Quantitytxt.Text), SignIn.GetUserGmail());
                    CDB.UpdateTotalNumberOfProductsBought(int.Parse(Quantitytxt.Text), SignIn.GetUserGmail());
                    AmbassadorDB.UpdateSales(p.GetPrice() * int.Parse(Quantitytxt.Text), p.GetBrandName());
                    SelectedRow = Table1.CurrentCell.RowIndex;
                    DataGridViewRow row = Table1.Rows[SelectedRow];
                    row.Cells[2].Value = (p.GetQuantity() - int.Parse(Quantitytxt.Text));



                    MessageBox.Show("Product Bought");
                }
                else
                {
                    MessageBox.Show("Out Of Stock");
                }
            }
            else
            {
                MessageBox.Show("This Product is not available");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CustomerMenu customerMain = new CustomerMenu();
            this.Hide(); customerMain.ShowDialog();
        }
    }
}

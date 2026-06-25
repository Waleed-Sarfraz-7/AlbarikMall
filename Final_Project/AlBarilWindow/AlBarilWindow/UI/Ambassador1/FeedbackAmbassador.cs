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

namespace AlBarilWindow.UI.Ambassador1
{
    public partial class FeedbackAmbassador : Form
    {
        public FeedbackAmbassador()
        {
            InitializeComponent();
            ICustomer CDB = ObjectHandler.GetCustomerDBDL();
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

        private void FeedbackAmbassador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AmbassadorMian ambassadorMian = new AmbassadorMian();
            this.Hide();
            ambassadorMian.ShowDialog();
        }
    }
}

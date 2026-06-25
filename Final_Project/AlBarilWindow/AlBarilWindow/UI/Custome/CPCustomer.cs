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
    public partial class CPCustomer : Form
    {
        public CPCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassCustomer changePassCustomer = new ChangePassCustomer();
            this.Hide();
            changePassCustomer.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeCnicCustomer changeCnicCustomer = new ChangeCnicCustomer();
            this.Hide();
            changeCnicCustomer.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerMenu menu = new CustomerMenu();
            this.Hide();
            menu.ShowDialog();
        }
    }
}

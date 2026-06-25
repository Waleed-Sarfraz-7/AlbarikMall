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
    public partial class ChangeProfile : Form
    {
        public ChangeProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword changePassword = new ChangePassword();
            this.Hide();
            changePassword.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeCnic changeCnic = new ChangeCnic();
            this.Hide();
            changeCnic.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.ShowDialog();
        }
    }
}

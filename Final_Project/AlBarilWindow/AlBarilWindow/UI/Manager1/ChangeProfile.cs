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
    public partial class ChangeProfile : Form
    {
        public ChangeProfile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerMenu managerMenu = new ManagerMenu();
            this.Hide();
            managerMenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeCnicMAnager changeCnicMAnager = new ChangeCnicMAnager();
            this.Hide();
            changeCnicMAnager.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ChangePassword  changePassword = new ChangePassword();
            this.Hide();
            changePassword.ShowDialog();
        }

        private void ChangeProfile_Load(object sender, EventArgs e)
        {

        }
    }
}

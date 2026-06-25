using AlBarikMall.DL;
using AlBarilWindow.UI.SignInSignUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlBarilWindow.UI.Manager1
{
    public partial class GiveAnnouncement : Form
    {
        IManager MDB = ObjectHandler.GetManagerDBDL();

        public GiveAnnouncement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MDB.UpdateAnnouncement(Announcementtxt.Text, SignIn.GetUserGmail()))
            {
                MessageBox.Show("Announcement Added For Brand Ambassador");
            }
            else
            {
                MessageBox.Show("Error Occured");
            }
            ManagerMenu managerMenu = new ManagerMenu();
            this.Hide();
            managerMenu.ShowDialog();
        }

        private void GiveAnnouncement_Load(object sender, EventArgs e)
        {

        }
    }
}

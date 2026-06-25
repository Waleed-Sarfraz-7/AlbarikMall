using AlBarikMall.DL.Database;
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
using AlBarikMall.Utility;

namespace AlBarilWindow.UI.Ambassador1
{
    public partial class SeeAnnouncement : Form
    {
        public SeeAnnouncement()
        {
            InitializeComponent();
            IManager MDB = new ManagerDBDL(Utility.GetConnectionString());
            textBox1.Text = MDB.GetAnnouncement();
        }

        private void SeeAnnouncement_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AmbassadorMian ambassadorMian = new AmbassadorMian();
            this.Hide();
            ambassadorMian.ShowDialog();
        }
    }
}

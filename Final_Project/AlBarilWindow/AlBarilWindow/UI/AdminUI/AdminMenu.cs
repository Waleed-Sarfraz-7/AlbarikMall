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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddAdmin addAdmin = new AddAdmin();
            this.Hide();
            addAdmin.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SeeProfitOrLoss seeProfitOrLoss = new SeeProfitOrLoss();
            this.Hide();
            seeProfitOrLoss.ShowDialog();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddShops addShops= new AddShops();
            this.Hide();
            addShops.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SeeAmbassador seeAmbassador = new SeeAmbassador();
            this.Hide();
            seeAmbassador.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeProfile changeProfile = new ChangeProfile();
            this.Hide();
            changeProfile.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SignInSignUp.SignIn signIn = new SignInSignUp.SignIn();
            this.Hide();
            signIn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddAmbassador addAmbassador= new AddAmbassador();
            this.Hide();
            addAmbassador.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

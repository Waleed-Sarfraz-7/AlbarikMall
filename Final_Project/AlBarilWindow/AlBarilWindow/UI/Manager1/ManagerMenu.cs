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
    public partial class ManagerMenu : Form
    {
        public ManagerMenu()
        {
            InitializeComponent();
        }

        private void ManagerMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAmbassadorManager showAmbassadorManager = new ShowAmbassadorManager();
            this.Hide();
            showAmbassadorManager.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalculateTotalFare calculateTotalFare = new CalculateTotalFare();
            this.Hide();
            calculateTotalFare.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeManager employeeManager = new EmployeeManager();
            this.Hide();
            employeeManager.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProfitManager profitManager = new ProfitManager();
            this.Hide();
            profitManager.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SeeFeedback seeFeedback= new SeeFeedback();
            this.Hide();
            seeFeedback.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GiveAnnouncement giveAnnouncement = new GiveAnnouncement();
            this.Hide();
            giveAnnouncement.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeProfile changeProfile= new ChangeProfile();
            this.Hide();
            changeProfile.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SignInSignUp.SignIn signIn = new SignInSignUp.SignIn();
            this.Hide();
            signIn.ShowDialog();
        }
    }
}

using AlBarikMall.DL.Database;
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
using AlBarikMall.Utility;

namespace AlBarilWindow.UI.Ambassador1
{
    public partial class AmbassadorMian : Form
    {
        private static string UserBrandName;
        static IAmbassador AmbassadorDB = new AmbassadorDBDL(Utility.GetConnectionString());
        public static void SetUserBrandName()
        {
            UserBrandName = AmbassadorDB.GetBrandName(SignIn.GetUserGmail());
        }
        public static string GetUserBrandName()
        {
            return UserBrandName;
        }
        public AmbassadorMian()
        {
            InitializeComponent();
            SetUserBrandName();
        }

        private void AmbassadorMian_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddEmployeeAmbassador addEmployeeAmbassador = new AddEmployeeAmbassador();
            this.Hide();
            addEmployeeAmbassador.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductManager productManager = new ProductManager();
            this.Hide();
            productManager.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeeSalesAmbassador seeSalesAmbassador=new SeeSalesAmbassador();
            this.Hide();
            seeSalesAmbassador.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FeedbackAmbassador feedbackAmbassador= new FeedbackAmbassador();
            this.Hide();
            feedbackAmbassador.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SeeAnnouncement seeAnnouncement= new SeeAnnouncement();
            this.Hide();
            seeAnnouncement.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SignIn signIn= new SignIn();    
            this.Hide
                ();
            signIn.ShowDialog();
        }
    }
}

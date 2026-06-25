using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlBarikMall.BL;
using AlBarilWindow.UI.AdminUI;
using AlBarilWindow.UI.Ambassador1;
using AlBarilWindow.UI.Custome;
using AlBarilWindow.UI.Manager1;

namespace AlBarilWindow.UI.SignInSignUp
{
    public partial class SignIn : Form
    {
        private static string UserGmail;
        public static void SetUserGmail(string usergamil)
        {
             UserGmail=usergamil;
        }
        public static string GetUserGmail()
        {
            return UserGmail;

        }




        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u=new User(Gmailtxt.Text, Passwordtxt.Text);
            u=ObjectHandler.GetUserDBDL().ConfirmUser(u);
            if (u!=null)
            {
                if(u.GetRole()=="admin")
                {
                    SetUserGmail(u.GetGmail());

                    AdminMenu adminMenu = new AdminMenu();
                    this.Hide();
                    adminMenu.ShowDialog();
                }
                else if(u.GetRole()=="manager")
                {
                    SetUserGmail(u.GetGmail());

                    ManagerMenu managerMenu
                        = new ManagerMenu();
                    this.Hide();
                    managerMenu.ShowDialog();
                }
                else if(u.GetRole()=="brand ambassador")
                {
                    SetUserGmail(u.GetGmail());

                    AmbassadorMian ambassadorMian = new AmbassadorMian();
                    this.Hide();
                    ambassadorMian.ShowDialog();
                }
                else if(u.GetRole()=="customer")
                {
                    SetUserGmail(u.GetGmail());

                    CustomerMenu customerMenu = new CustomerMenu();
                    this.Hide(); customerMenu.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("User does not exists");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Gmailtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Namelabel_Click(object sender, EventArgs e)
        {

        }
    }
}

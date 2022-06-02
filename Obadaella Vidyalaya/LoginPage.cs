using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obadaella_Vidyalaya
{
    public partial class LoginPage : Form
    {
        Obadaella_VidyalayaEntities dbcontext = new Obadaella_VidyalayaEntities();
        Users_Table ut = new Users_Table();

        public LoginPage()
        {
            InitializeComponent();
        }

        //Login Validation (check Admin Or User)
        private void btcLog_Click(object sender, EventArgs e)
        {
            try
            {
                if(dbcontext.Users_Table.Where( x => x.USERNAME == txtLoginUsername.Text && x.PASSWORD == txtLoginPassword.Text).Count() > 0)
                {
                        this.Hide();
                        MainHomePage obj = new MainHomePage(txtLoginUsername.Text, txtLoginPassword.Text);
                        obj.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User!");
                }
            }
            catch (Exception ert)
            {

            }
        }

        //Password Hide
        private void ShowPWbtn2_Click(object sender, EventArgs e)
        {
            if(txtLoginPassword.PasswordChar == '*')
            {
                HidePWbtn1.BringToFront();
                txtLoginPassword.PasswordChar = '\0';
            }
        }

        private void HidePWbtn1_Click(object sender, EventArgs e)
        {
            if (txtLoginPassword.PasswordChar == '\0')
            {
                ShowPWbtn2.BringToFront();
                txtLoginPassword.PasswordChar = '*';
            }
        }
    }
}

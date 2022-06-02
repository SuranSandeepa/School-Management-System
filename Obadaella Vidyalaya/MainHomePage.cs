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
    public partial class MainHomePage : Form
    {
        public MainHomePage()
        {
            InitializeComponent();
        }

        public static String username,password;
        public MainHomePage(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }

        void VisibleBtn()
        {
            try
            {
                if ((username != "admin" || password != "12345") && (username != "principal" || password != "12345"))
                {
                    PaymentMainBtn.Enabled = false;
                    PaymentMainBtn.BackColor = Color.LightYellow;
                    EmployeeMainBtn.Enabled = false;
                    EmployeeMainBtn.BackColor = Color.LightYellow;
                    btnLoginCredintialsMH.Enabled = false;
                    btnLoginCredintialsMH.BackColor = Color.LightYellow;
                }
                else
                {
                    PaymentMainBtn.Enabled = true;
                    PaymentMainBtn.BackColor = Color.Yellow;
                    EmployeeMainBtn.Enabled = true;
                    EmployeeMainBtn.BackColor = Color.Yellow;
                    btnLoginCredintialsMH.Enabled = true;
                    btnLoginCredintialsMH.BackColor = Color.Yellow;
                }
            }
            catch(Exception ert)
            {
                MessageBox.Show(ert.Message);
            }
        }

        
        private void MainHomePage_Load(object sender, EventArgs e)
        {
            VisibleBtn();
        }
        
        private void EmployeeMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage obj = new EmployeeHomePage(username,password);
            obj.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            username = "";
            password = "";
            this.Hide();
            LoginPage obj = new LoginPage();
            obj.Show();
        }

        private void btnLoginCredintialsMH_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginRegisterPage obj = new LoginRegisterPage(username, password);
            obj.Show();
        }

        private void TimetableMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        private void ExaminationMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamHomeManagement exam = new ExamHomeManagement();
            exam.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamHomeManagement exam = new ExamHomeManagement();
            exam.ShowDialog();
        }

        private void EventMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventManagementHome exam = new EventManagementHome();
            exam.ShowDialog();
        }

        private void PaymentMainBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHome obj = new PaymentHome(username, password);
            obj.Show();
        }

    }
}

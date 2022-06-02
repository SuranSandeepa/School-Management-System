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
    public partial class EmployeeHomePage : Form
    {
        public EmployeeHomePage()
        {
            InitializeComponent();
        }

        public static String username, password;
        public EmployeeHomePage(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }


        private void btnEmpTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeTaskPage taskFrm = new EmployeeTaskPage(username, password);
            taskFrm.Show();
        }

        private void btnEmpCreateAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeAttendancePage taskFrm = new EmployeeAttendancePage(username, password);
            taskFrm.Show();
        }

        private void btnEmpAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeRegisterPage taskFrm = new EmployeeRegisterPage(username, password);
            taskFrm.Show();
        }

        private void backMainHomePB_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            MainHomePage obj = new MainHomePage();
            obj.Show();
        }

        private void btnEmpAttendanceView_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeesAttendanceView obj = new EmployeesAttendanceView();
            obj.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        private void btnEmpView_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeesDetailsView obj = new EmployeesDetailsView();
            obj.Show();
        }



    }
}

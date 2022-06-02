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
    public partial class EmployeesAttendanceView : Form
    {
        public EmployeesAttendanceView()
        {
            InitializeComponent();
        }
        public static String username, password;
        public EmployeesAttendanceView(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }


        void dataGridViewDisplay()
        {
            dgvEmployeeAttendanceDetails.AutoGenerateColumns = false;

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmployeeAttendanceDetails.DataSource = db.Employee_Attendance.ToList<Employee_Attendance>();
            }
        }

        private void EmployeesAttendanceView_Load(object sender, EventArgs e)
        {
            dataGridViewDisplay();
        }

        //Search Attenance
        private void dtpSearchAttendanceView_ValueChanged(object sender, EventArgs e)
        {
            txtSearchEmpAttendanceView.Text = dtpSearchAttendanceView.Text;
        }

        private void txtSearchEmpAttendanceView_TextChanged(object sender, EventArgs e)
        {

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                if (String.IsNullOrEmpty(txtSearchEmpAttendanceView.Text))
                {
                    dgvEmployeeAttendanceDetails.DataSource = null;
                }
                dgvEmployeeAttendanceDetails.DataSource = db.Employee_Attendance.Where(x => x.DATE.Contains(txtSearchEmpAttendanceView.Text)).ToList();
            }
        }

        private void btnPrintAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpAttendanceReports obj = new EmpAttendanceReports(txtSearchEmpAttendanceView.Text);
            obj.Show();
        }

        private void backArrowAV_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeAttendancePage obj = new EmployeeAttendancePage();
            obj.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        private void AVempPB_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage obj = new EmployeeHomePage();
            obj.Show();
        }
    }
}

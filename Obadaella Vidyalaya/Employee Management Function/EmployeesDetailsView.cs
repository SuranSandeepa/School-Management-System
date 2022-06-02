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
    public partial class EmployeesDetailsView : Form
    {
        public EmployeesDetailsView()
        {
            InitializeComponent();
        }

        public static String username, password;
        public EmployeesDetailsView(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }

        void dataGridViewDisplay()
        {
            dgvEmployeeDetails.AutoGenerateColumns = false;

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmployeeDetails.DataSource = db.Employee_Register.ToList<Employee_Register>();
            }
        }

        private void EmployeesDetailsView_Load(object sender, EventArgs e)
        {
            dataGridViewDisplay();
        }

        //Search Employee
        private void txtSearchEmpViewPage_TextChanged(object sender, EventArgs e)
        {

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                if (String.IsNullOrEmpty(txtSearchEmpViewPage.Text))
                {
                    dgvEmployeeDetails.DataSource = null;
                }
                dgvEmployeeDetails.DataSource = db.Employee_Register.Where(x => x.EMPCODE.Contains(txtSearchEmpViewPage.Text)).ToList();
            }
        }

        //Print btn
        private void btnPrintReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeReports obj = new EmployeeReports(txtSearchEmpViewPage.Text);
            obj.Show();
        }

        //PB click back to EmpHome
        private void EVempPB_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage obj = new EmployeeHomePage();
            obj.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        //Arrow click back to EmpRegister
        private void backArrowEV_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeRegisterPage obj = new EmployeeRegisterPage();
            obj.Show();
        }
    }
}

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
    public partial class EmployeeSalarysDetailsView : Form
    {
        public EmployeeSalarysDetailsView()
        {
            InitializeComponent();
        }

        public static String username, password;
        public EmployeeSalarysDetailsView(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }

        void dataGridViewDisplay()
        {
            dgvEmployeeSalaryView.AutoGenerateColumns = false;

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmployeeSalaryView.DataSource = db.EmployeeSalaryDetails.ToList<EmployeeSalaryDetail>();
            }
        }

        private void EmployeeSalarysDetailsView_Load(object sender, EventArgs e)
        {
            dataGridViewDisplay();
        }

        //Search
        private void txtEmpSalSearch_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                if (String.IsNullOrEmpty(txtEmpSalSearch.Text))
                {
                    dgvEmployeeSalaryView.DataSource = null;
                }
                dgvEmployeeSalaryView.DataSource = db.EmployeeSalaryDetails.Where(x => x.EmployeeID.Contains(txtEmpSalSearch.Text)).ToList();
            }
        }

        //Print btn
        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpSalaryRepors obj = new EmpSalaryRepors(txtEmpSalSearch.Text);
            obj.Show();
        }

        //PB click back to Payment Home
        private void pictureBox19_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHome obj = new PaymentHome();
            obj.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        //Arrow click back to Employee Salary Add
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeSalary obj = new EmployeeSalary();
            obj.Show();
        }
    }
}

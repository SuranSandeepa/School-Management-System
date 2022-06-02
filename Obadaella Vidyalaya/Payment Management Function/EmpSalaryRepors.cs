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
    public partial class EmpSalaryRepors : Form
    {
        public EmpSalaryRepors(string empMessage)
        {
            InitializeComponent();
            txtSearchEmpSalReport.Text = empMessage;
            Shown += btnEmpSalReport_Click;
        }

        private void txtSearchEmpSalReport_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEmpSalReport_Click(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmpSalReports.DataSource = db.EmployeeSalaryDetails.Where(x => x.EmployeeID.Contains(txtSearchEmpSalReport.Text)).ToList();
            }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Payment ID", typeof(string));
            dt.Columns.Add("Employee ID", typeof(string));
            dt.Columns.Add("Bank", typeof(string));
            dt.Columns.Add("Branch", typeof(string));
            dt.Columns.Add("Account No", typeof(string));
            dt.Columns.Add("Basic", typeof(int));
            dt.Columns.Add("Allowances", typeof(int));
            dt.Columns.Add("Loan", typeof(int));
            dt.Columns.Add("Total Salary", typeof(int));

            foreach (DataGridViewRow dgv in dgvEmpSalReports.Rows)
            {
                dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value, dgv.Cells[9].Value);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("empSalaryDetails.xml");

            CrystalReportEmpSalaryDetails cr = new CrystalReportEmpSalaryDetails();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeSalarysDetailsView obj = new EmployeeSalarysDetailsView();
            obj.Show();
        }
    }
}

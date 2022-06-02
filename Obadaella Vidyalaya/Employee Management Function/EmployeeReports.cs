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
    public partial class EmployeeReports : Form
    {
        public EmployeeReports(string empMessage)
        {
            InitializeComponent();
            txtEmpViewCR.Text = empMessage;
            Shown += btnEmpViewCR_TextChanged_Click;
        }

        private void txtEmpViewCR_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                if (String.IsNullOrEmpty(txtEmpViewCR.Text))
                {
                    dgvEmpViewCR.DataSource = null;
                }
                dgvEmpViewCR.DataSource = db.Employee_Register.Where(x => x.EMPCODE.Contains(txtEmpViewCR.Text)).ToList();
            }
        }

        private void btnEmpViewCR_TextChanged_Click(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmpViewCR.DataSource = db.Employee_Register.Where(x => x.EMPCODE.Contains(txtEmpViewCR.Text)).ToList();
            }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Employee ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Designation", typeof(string));
            dt.Columns.Add("NIC", typeof(string));
            dt.Columns.Add("Address", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Dath of Birth", typeof(string));
            dt.Columns.Add("Contact", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Joined", typeof(string));

            foreach (DataGridViewRow dgv in dgvEmpViewCR.Rows)
            {
                dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value, dgv.Cells[7].Value, dgv.Cells[8].Value, dgv.Cells[9].Value, dgv.Cells[10].Value);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("empDetails.xml");

            CrystalReportEmployeeDetails cr = new CrystalReportEmployeeDetails();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            EmployeesDetailsView obj = new EmployeesDetailsView();
            obj.Show();
        }
    }
}

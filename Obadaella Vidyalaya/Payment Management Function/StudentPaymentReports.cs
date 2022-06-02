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
    public partial class StudentPaymentReports : Form
    {
        public StudentPaymentReports(string empMessage)
        {
            InitializeComponent();
            txtSPR.Text = empMessage;
            Shown += btnSPR_Click;
        }

        private void btnSPR_Click(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvSPR.DataSource = db.StudentPayments.Where(x => x.StudentID.Contains(txtSPR.Text)).ToList();
            }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Student ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Grade", typeof(string));
            dt.Columns.Add("Exam Fee", typeof(string));
            dt.Columns.Add("Facility Fee", typeof(string));
            dt.Columns.Add("Total Fee", typeof(string));

            foreach (DataGridViewRow dgv in dgvSPR.Rows)
            {
                dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("studentPamentDetails.xml");

            CrystalReportStdPaymentDetails cr = new CrystalReportStdPaymentDetails();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentPaymentView obj = new StudentPaymentView();
            obj.Show();
        }
    }
}

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
    public partial class ExamTimetableReports : Form
    {
        public ExamTimetableReports(string empMessage)
        {
            InitializeComponent();
            txtETR.Text = empMessage;
            Shown += btnETR_Click;
        }

        private void txtETR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnETR_Click(object sender, EventArgs e)
        {
            
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvETR.DataSource = db.Timetables.Where(x => x.Date.Contains(txtETR.Text)).ToList();
            }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Date", typeof(string));
            dt.Columns.Add("8.00-9.00", typeof(string));
            dt.Columns.Add("9.00-10.00", typeof(string));
            dt.Columns.Add("10.30-11.30", typeof(string));
            dt.Columns.Add("11.30-12.30", typeof(string));
            dt.Columns.Add("12.30-01.30", typeof(string));


            foreach (DataGridViewRow dgv in dgvETR.Rows)
            {
                dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value, dgv.Cells[6].Value);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("ExamTimetableDetails.xml");

            
            CrystalReportExamTimetable cr = new CrystalReportExamTimetable();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamTimetableManagement objt = new ExamTimetableManagement();
            objt.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamHomeManagement objt = new ExamHomeManagement();
            objt.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage objt = new EmployeeHomePage();
            objt.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHome objt = new PaymentHome();
            objt.Show();
        }
    }
}

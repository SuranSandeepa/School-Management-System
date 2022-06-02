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
    public partial class EmpAttendanceReports : Form
    {
        public EmpAttendanceReports(string empMessage)
        {
            InitializeComponent();
            txtSearchCREMPAttendance.Text = empMessage;
            Shown += btnEmpAttendanceCR_Click;
        }

        private void btnEmpAttendanceCR_Click(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmployeeAttendanceCR.DataSource = db.Employee_Attendance.Where(x => x.DATE.Contains(txtSearchCREMPAttendance.Text)).ToList();
            }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Employee ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Designation", typeof(string));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Date", typeof(string));

            foreach (DataGridViewRow dgv in dgvEmployeeAttendanceCR.Rows)
            {
                dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("empAttendance.xml");

            CrystalReportEmpAttendance cr = new CrystalReportEmpAttendance();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeesAttendanceView obj = new EmployeesAttendanceView();
            obj.Show();
        }
    } 
}

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
    public partial class SNReport : Form
    {
        public SNReport(string N)
        {
            InitializeComponent();
            txtSN.Text = N;
            Shown += btnSN_Click;
        }
        private void txtSN_TextChanged(object sender, EventArgs e) 
        {

        }

        private void btnSN_Click (object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                SNReportdgv.DataSource = db.Notice_Create.Where(x => x.NOTICEID.Contains(txtSN.Text)).ToList();
            }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Notice ID", typeof(string));
            dt.Columns.Add("Notice", typeof(string));

            foreach (DataGridViewRow dgv in SNReportdgv.Rows)
            {
                dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("NoticeDetails.xml");

            CrystalReportSpecialNotice cr = new CrystalReportSpecialNotice();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void SNReport_Load(object sender, EventArgs e)
        {

        }

        /*private void btnBack1_Click(object sender, EventArgs e)
        {
            AddSpecialNotices obj = new AddSpecialNotices();
            obj.Show();
            this.Hide();
        }*/

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AddSpecialNotices obj = new AddSpecialNotices();
            obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

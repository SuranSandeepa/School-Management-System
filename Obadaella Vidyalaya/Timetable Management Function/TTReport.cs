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
    public partial class TTReport : Form
    {
        public TTReport(string rmsg)
        {
            InitializeComponent();
            textSearchReport.Text = rmsg;
            Shown += buttonSearchReport_Click;
        }

        private void Report_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainNew = new TTMainPage();
            tTMainNew.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainNew = new TTMainPage();
            tTMainNew.ShowDialog();
        }

        private void buttonSearchReport_Click(object sender, EventArgs e)
        {
            dgvR.AutoGenerateColumns = false;
            using (Obadaella_VidyalayaEntities crud = new Obadaella_VidyalayaEntities())
            {
                dgvR.DataSource = crud.TTs.Where(x => x.ClassPeriod.Contains(textSearchReport.Text)).ToList();
            }

            label2.Text = textSearchReport.Text;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Monday", typeof(string));
            dt.Columns.Add("Tuesday", typeof(string));
            dt.Columns.Add("Wednesday", typeof(string));
            dt.Columns.Add("Thursday", typeof(string));
            dt.Columns.Add("Friday", typeof(string));

            foreach (DataGridViewRow dgv in dgvR.Rows)
            {
                dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value, dgv.Cells[5].Value);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("TTSample.xml");

            CrystalReportTT cr = new CrystalReportTT();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



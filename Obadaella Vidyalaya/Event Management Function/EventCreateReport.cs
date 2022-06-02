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
    public partial class EventCreateReport : Form
    {
        public EventCreateReport(string E)
        {
            InitializeComponent();
            txtECR.Text = E;
            Shown += btnECR_Click;
        }
        private void txtECR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnECR_Click(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                ECreportdgv.DataSource = db.Events_Create.Where(x => x.EVENTID.Contains(txtECR.Text)).ToList();
            }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt.Columns.Add("Event ID", typeof(string));
            dt.Columns.Add("Event Name", typeof(string));
            dt.Columns.Add("venue", typeof(string));
            dt.Columns.Add("Discription", typeof(string));

            foreach (DataGridViewRow dgv in ECreportdgv.Rows)
            {
                dt.Rows.Add(dgv.Cells[1].Value, dgv.Cells[2].Value, dgv.Cells[3].Value, dgv.Cells[4].Value);
            }

            ds.Tables.Add(dt);
            ds.WriteXmlSchema("EventDetails.xml");

            CrystalReportEventCreate cr = new CrystalReportEventCreate();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            EventCreatePage obj = new EventCreatePage();
            obj.Show();
            this.Hide();

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            EventCreatePage obj = new EventCreatePage();
            obj.Show();
            this.Hide();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EventCreatePage obj = new EventCreatePage();
            obj.Show();
            this.Hide();
        }
    }
}

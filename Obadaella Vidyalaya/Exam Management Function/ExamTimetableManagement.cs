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
    public partial class ExamTimetableManagement : Form
    {

        Timetable model = new Timetable();

        public ExamTimetableManagement()
        {
            InitializeComponent();
        }

        private void btnlo1save_Click(object sender, EventArgs e)
        {
            model.Date = txtDate.Text.Trim();
            model.A = txtA.Text.Trim();
            model.B = txtB.Text.Trim();
            model.C = txtC.Text.Trim();
            model.D = txtD.Text.Trim();
            model.E = txtE.Text.Trim();

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                if (model.T_id == 0) // Inserting data
                    db.Timetables.Add(model);
                else //upade data
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridView();
            MessageBox.Show("Saved Successfully");
        }

        private void ExamTimetableManagement_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnlo1clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtDate.Text = txtA.Text = txtB.Text = txtC.Text = txtD.Text = txtE.Text = "";
            btnlo1save.Text = "Save";
            // btnlo1delete.Enabled = false;
            model.T_id = 0;
        }

        //Binding data to the data-grid-view
        //create the populate method

        void PopulateDataGridView()
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {

                dgvtime.DataSource = db.Timetables.ToList<Timetable>();
            }
        }

        private void dgvtime_DoubleClick(object sender, EventArgs e)
        {
            if (dgvtime.CurrentRow.Index != -1)
            {
                model.T_id = Convert.ToInt32(dgvtime.CurrentRow.Cells["T_id"].Value);

                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    model = db.Timetables.Where(x => x.T_id == model.T_id).FirstOrDefault();
                    txtDate.Text = model.Date;
                    txtA.Text = model.A;
                    txtB.Text = model.B;
                    txtC.Text = model.C;
                    txtD.Text = model.D;
                    txtE.Text = model.E;
                }

                btnlo1save.Text = "Update";
                //btnlo1delete.Enabled = true;
            }
        }

        // searching by date
        /*
        private void dtptime_ValueChanged(object sender, EventArgs e)
        {
            txtSearch1.Text = dtptime.Text;
        }
        */
        private void txtSearch1_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {

                dgvtime.DataSource = db.Timetables.Where(x => x.Date.Contains(txtSearch1.Text)).ToList();


            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamTimetableReports obj = new ExamTimetableReports(txtSearch1.Text);
            obj.Show();
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamHomeManagement ob = new ExamHomeManagement();
            ob.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage obj = new EmployeeHomePage();
            obj.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHome objd = new PaymentHome();
            objd.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage obj = new TTMainPage();
            obj.Show();
        }
    }
}

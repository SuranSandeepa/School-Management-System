using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Obadaella_Vidyalaya
{
    public partial class AddSpecialNotices : Form
    {
        Notice_Create model = new Notice_Create();
        public AddSpecialNotices()
        {
            InitializeComponent();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            EventManagementHome obj = new EventManagementHome();
            obj.Show();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txtNoticeID.Text = txtSpecialNotice.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.NOTICENO = 0;
        }

        private void AddSpecialNotices_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridview();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /*Form Validaton
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNoticeID.Text, "^[signature]*$"))
            {
                MessageBox.Show("Cant use symbole", "eroor");
                return;
            }*/

            model.NOTICEID = txtNoticeID.Text.Trim();
            model.NOTICE = txtSpecialNotice.Text.Trim();
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                if (model.NOTICENO == 0)//Insert
                    db.Notice_Create.Add(model);
                else//Update
                    db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
            Clear();
            PopulateDataGridview();
            MessageBox.Show("Notice Submited");
        }

        void PopulateDataGridview()
        {
            dgvNotice_Create.AutoGenerateColumns = false;
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvNotice_Create.DataSource = db.Notice_Create.ToList<Notice_Create>();
            }
        }

        private void dgvNotice_Create_DoubleClick(object sender, EventArgs e)
        {
            if (dgvNotice_Create.CurrentRow.Index != -1)
            {
                model.NOTICENO = Convert.ToInt32(dgvNotice_Create.CurrentRow.Cells["NOTICENO"].Value);
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    model = db.Notice_Create.Where(x => x.NOTICENO == model.NOTICENO).FirstOrDefault();
                    txtNoticeID.Text = model.NOTICEID;
                    txtSpecialNotice.Text = model.NOTICE;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Dlete this Notice?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Notice_Create.Attach(model);
                    db.Notice_Create.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridview();
                    Clear();
                    MessageBox.Show("Deleted");


                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvNotice_Create.DataSource = db.Notice_Create.Where(x => x.NOTICEID.Contains(txtSearch.Text)).ToList();
            }
        }

        private void btnPrintSN_Click(object sender, EventArgs e)
        {
            
            SNReport obj = new SNReport(txtSearch.Text);
            obj.Show();
            this.Hide();
            
        }

        private void btnDEMO_Click(object sender, EventArgs e)
        {
            txtNoticeID.Text = "SID2";
            txtSpecialNotice.Text = "Football match canceled";
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            EventManagementHome obj = new EventManagementHome();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EventManagementHome obj = new EventManagementHome();
            obj.Show();
            this.Hide();
        }
    }
}

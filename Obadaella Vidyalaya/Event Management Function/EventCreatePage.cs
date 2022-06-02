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
    public partial class EventCreatePage : Form
    {
        Events_Create model = new Events_Create();
        public EventCreatePage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            txtEventId.Enabled = true;
            txtEventId.BackColor = Color.White;
        }

        void Clear()
        {
            txtEventName.Text = txtEventVenue.Text = txtDiscription.Text = txtEventId.Text = "";
            btnSave.Text = "save";
            btnDelete.Enabled = false;
            model.EVENTNO = 0;
        }

        private void EventCreatePage_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEventName.Text == string.Empty || txtEventId.Text == string.Empty || txtEventVenue.Text == string.Empty || txtDiscription.Text == string.Empty)
            {
                MessageBox.Show("All Data Required!");
            }
            else
            {
                txtEventId.Enabled = true;
                txtEventId.BackColor = Color.White;
                model.EVENTNAME = txtEventName.Text.Trim();
                model.EVENTVENUE = txtEventVenue.Text.Trim();
                model.EVENTDISCRIPTION = txtDiscription.Text.Trim();
                model.EVENTID = txtEventId.Text.Trim();

                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    if (model.EVENTNO == 0)//Insert
                        db.Events_Create.Add(model);
                    else//Update
                        db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Submitted Successfully");
            }
        }

        //populate data grid view code
        void PopulateDataGridView()
        {
            dgvEvents_Create.AutoGenerateColumns = false;
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEvents_Create.DataSource = db.Events_Create.ToList<Events_Create>();
            }

        }

        private void dgvEvents_Create_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEvents_Create.CurrentRow.Index != -1)
            {
                model.EVENTNO = Convert.ToInt32(dgvEvents_Create.CurrentRow.Cells["EVENTNO"].Value);
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    txtEventId.Enabled = false;
                    txtEventId.BackColor = Color.Gray;
                    model = db.Events_Create.Where(x => x.EVENTNO == model.EVENTNO).FirstOrDefault();
                    txtEventId.Text = model.EVENTID;
                    txtEventName.Text = model.EVENTNAME;
                    txtEventVenue.Text = model.EVENTVENUE;
                    txtDiscription.Text = model.EVENTDISCRIPTION;
                }
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to Delete this?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                        db.Events_Create.Attach(model);
                    db.Events_Create.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted");
                    txtEventId.Enabled = true;
                    txtEventId.BackColor = Color.White;
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            EventManagementHome obj = new EventManagementHome();
            obj.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            EventManagementHome obj = new EventManagementHome();
            obj.Show();
            this.Hide();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEvents_Create.DataSource = db.Events_Create.Where(x => x.EVENTID.Contains(txtSearch.Text)).ToList();
            }
        }

        private void btnprintEC_Click(object sender, EventArgs e)
        {
            
            EventCreateReport obj = new EventCreateReport(txtSearch.Text);
            obj.Show();
            this.Hide();
            

        }

        //validation


        private void txtEventName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEventId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            txtEventName.Text = " Fooball match";
            txtEventId.Text = "EID3";
            txtEventVenue.Text = "School play ground";
            txtDiscription.Text = "Under 15 Students";
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            EventManagementHome obj = new EventManagementHome();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            EventManagementHome obj = new EventManagementHome();
            obj.Show();
            this.Hide();
        }
    }
}

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
    public partial class ExamHallManagement : Form
    {
        
        Hall model = new Hall();
        public ExamHallManagement()
        {
            InitializeComponent();
        }

        private void ExamHallManagement_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView1();
        }

        private void btnlocancel2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            txthall_id2.Text = txthall_name1.Text = txtclass_id2.Text = "";
            btnlosave2.Text = "Save";
            btnlodelete2.Enabled = false;
            model.id = 0;
        }

        private void btnlosave2_Click(object sender, EventArgs e)
        {
            model.Hall_id = txthall_id2.Text.Trim();
            model.Hall_name = txthall_name1.Text.Trim();
            model.Class = txtclass_id2.Text.Trim();

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                if (model.id == 0) //insert
                    db.Halls.Add(model);
                else //update
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

            Clear();
            PopulateDataGridView1();
            MessageBox.Show("Saved Successfully");
        }

        void PopulateDataGridView1()
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvhall.DataSource = db.Halls.ToList<Hall>();
            }
        }

        private void dgvhall_DoubleClick(object sender, EventArgs e)
        {
            if (dgvhall.CurrentRow.Index != -1)
            {
                model.id = Convert.ToInt32(dgvhall.CurrentRow.Cells["id"].Value);
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    model = db.Halls.Where(x => x.id == model.id).FirstOrDefault();
                    txthall_id2.Text = model.Hall_id;
                    txthall_name1.Text = model.Hall_name;
                    txtclass_id2.Text = model.Class;
                }
                btnlosave2.Text = "Update";
                btnlodelete2.Enabled = true;
            }
        }

        private void btnlodelete2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Halls.Attach(model);
                    db.Halls.Remove(model);
                    db.SaveChanges();
                    PopulateDataGridView1();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void txtSearch2_TextChanged(object sender, EventArgs e)
        {

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvhall.DataSource = db.Halls.Where(x => x.Hall_name.Contains(txtSearch2.Text)).ToList();
            }
        }



        //validations
        private void txthall_id2_TextChanged(object sender, EventArgs e)
        {
            /*
             if (txthall_id2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Exam Hall ID cannot be empty", "Error Message");
                return;
            }*/
        }

        //validations
        private void txthall_name1_TextChanged(object sender, EventArgs e)
        {
            /*
            if (txthall_name1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Hall Name cannot be empty", "Error Message");
                return;
            }
            */
        }
        //validations
        private void txtclass_id2_TextChanged(object sender, EventArgs e)
        {
            /*
            if (txtclass_id2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Class Name cannot be empty", "Error Message");
                return;
            }
            */
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamHomeManagement objt = new ExamHomeManagement();
            objt.Show();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamHomeManagement objt = new ExamHomeManagement();
            objt.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panello3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }
    }

}

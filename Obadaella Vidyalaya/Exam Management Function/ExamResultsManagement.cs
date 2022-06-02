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
    public partial class ExamResultsManagement : Form
    { //Create an object
        Result model = new Result();

        //Declare variables 
        int sinhala, buddhism, maths, science, english, aesthetic, total, average;

        public ExamResultsManagement()
        {
            InitializeComponent();
        }

        //clear button 
        private void btncancel3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //deletion  part
        private void btndelete3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Results.Attach(model);
                    db.Results.Remove(model);
                    db.SaveChanges();
                    PopulatedataGridView3();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }


        // searching part
        private void txtSearchResult_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvresult.DataSource = db.Results.Where(x => x.Class.Contains(txtSearchResult.Text)).ToList();
            }

        }

       

        void Clear()
        {
            txtsid.Text = txtSname.Text = txtClass.Text = txtSinhala.Text = txtBuddhism.Text = txtMaths.Text = txtScience.Text
            = txtEnglish.Text = TxtEasthetic.Text = txtTotal.Text = txtAvg.Text = txtGrade.Text = null;
            btnsave3.Text = "Save";
            btndelete3.Enabled = false;
            model.R_ID = 0;
        }



        //form load event
        private void ExamResultsManagement_Load(object sender, EventArgs e)
        {
            Clear(); //textboxes are empty
            PopulatedataGridView3(); //load the previous added details
        }

        
            //Save button
            private void btnsave3_Click(object sender, EventArgs e)
            {
                model.S_ID = txtsid.Text.Trim();
                model.Name = txtSname.Text.Trim();
                model.Class = txtClass.Text.Trim();
                model.Sinhala = Convert.ToInt32(txtSinhala.Text);
                model.Buddhism = Convert.ToInt32(txtBuddhism.Text);
                model.Maths = Convert.ToInt32(txtMaths.Text);
                model.Science = Convert.ToInt32(txtScience.Text);
                model.English = Convert.ToInt32(txtEnglish.Text);
                model.Easthetic = Convert.ToInt32(TxtEasthetic.Text);
                model.Total = Convert.ToInt32(txtTotal.Text);
                model.Average = Convert.ToInt32(txtAvg.Text);
                model.Grade = txtGrade.Text.Trim();


                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    if (model.R_ID == 0) //insertdetails
                        db.Results.Add(model);

                    else //update details
                        db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                Clear();
                PopulatedataGridView3();
                MessageBox.Show("Saved Successfully");
            }

       

        void PopulatedataGridView3()
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvresult.DataSource = db.Results.ToList<Result>();
            }
        }

        


        //calculate total marks
        private void btnTotal_Click(object sender, EventArgs e)
        {
            sinhala = int.Parse(txtSinhala.Text);
            buddhism = int.Parse(txtBuddhism.Text);
            maths = int.Parse(txtSinhala.Text);
            science = int.Parse(txtSinhala.Text);
            english = int.Parse(txtSinhala.Text);
            aesthetic = int.Parse(txtSinhala.Text);

            //Calculation
            total = (sinhala + buddhism + maths + science + english + aesthetic);
            txtTotal.Text = total.ToString();

            model.Total = Convert.ToInt32(txtTotal.Text);

        }


        //Calculate Average of students marks
        private void tbnAvg_Click(object sender, EventArgs e)
        {
            total = int.Parse(txtTotal.Text);

            //calculation
            average = (total / 6);
            txtAvg.Text = average.ToString();

            model.Average = Convert.ToInt32(txtAvg.Text);

        }

        //updating details by doubleclicking rows

        private void dgvresult_DoubleClick(object sender, EventArgs e)
        {

            if (dgvresult.CurrentRow.Index != -1)
            {
                model.R_ID = Convert.ToInt32(dgvresult.CurrentRow.Cells["R_id"].Value);
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    model = db.Results.Where(x => x.R_ID == model.R_ID).FirstOrDefault();
                    txtsid.Text = model.S_ID;
                    txtSname.Text = model.Name;
                    txtClass.Text = model.Class;
                    txtSinhala.Text = model.Sinhala.ToString();
                    txtBuddhism.Text = model.Buddhism.ToString();
                    txtMaths.Text = model.Maths.ToString();
                    txtScience.Text = model.Science.ToString();
                    txtEnglish.Text = model.English.ToString();
                    TxtEasthetic.Text = model.Easthetic.ToString();
                    txtTotal.Text = model.Total.ToString();
                    txtAvg.Text = model.Average.ToString();
                    txtGrade.Text = model.Grade;


                }
                btnsave3.Text = "Update";
                btndelete3.Enabled = true;

            }




        }

        //side bar navigations

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            this.Hide();
            ExamHomeManagement ex = new ExamHomeManagement();
            ex.Show();

        }


        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHome tt = new PaymentHome();
            tt.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tm = new TTMainPage();
            tm.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage home = new EmployeeHomePage();
            home.Show();
        }

        private void txtSname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


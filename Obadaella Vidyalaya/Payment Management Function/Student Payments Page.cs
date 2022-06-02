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
    public partial class Student_Payments_Page : Form
    {
        //create object
        StudentPayment studentPayment = new StudentPayment();

        //Declare variables
        int exam, facility, total;

        public Student_Payments_Page()
        {
            InitializeComponent();
        }
        //Cancel Button
        private void btnStuCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //Clear form details
        void Clear()
        {
            txtStudentID.Text = txtStudentName.Text = txtStudentGrade.Text = txtStudentExamFee.Text = txtStudentFacilityFee.Text = txtStudentTotal.Text = null;
            btnStuSave.Text = "Save";
            btnStuDelete.Enabled = false;
            studentPayment.StudentPayNo = 0;
        }

        //Load Form
        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();

        }

        //Save Button
        private void btnStuSave_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == string.Empty || txtStudentName.Text == string.Empty || txtStudentGrade.Text == string.Empty || txtStudentExamFee.Text == string.Empty || txtStudentFacilityFee.Text == string.Empty || txtStudentTotal.Text == string.Empty)
            {
                MessageBox.Show("All Details Reqired !");
            }
            else
            {

                studentPayment.StudentID = txtStudentID.Text.Trim();
                studentPayment.StudentName = txtStudentName.Text.Trim();
                studentPayment.StudentGrade = txtStudentGrade.Text.Trim();
                studentPayment.ExamFee = txtStudentExamFee.Text.Trim();
                studentPayment.FacilityFee = txtStudentFacilityFee.Text.Trim();
                studentPayment.TotalFee = txtStudentTotal.Text.Trim();

                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    if (studentPayment.StudentPayNo == 0)//Insert details
                    {
                        db.StudentPayments.Add(studentPayment);
                    }
                    else //Update details
                    {
                        db.Entry(studentPayment).State = EntityState.Modified;
                    }

                    db.SaveChanges();
                }
                Clear();
                PopulateDataGridView();
                MessageBox.Show("Submitted Successfully");
            }
        }

        //Dispay Student payments details
        void PopulateDataGridView()
        {
            dgvStudentPayment.AutoGenerateColumns = false;
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvStudentPayment.DataSource = db.StudentPayments.ToList<StudentPayment>();

            }
        }

        // Calulate Button
        private void btnStuCalculate_Click(object sender, EventArgs e)
        {
            exam = int.Parse(txtStudentExamFee.Text);
            facility = int.Parse(txtStudentFacilityFee.Text);

            total = exam + facility; // Calculation

            txtStudentTotal.Text = total.ToString();

            studentPayment.TotalFee = txtStudentTotal.Text;
        }

        //Display Updated Student Payments Details
        private void dgvStudentPayment_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudentPayment.CurrentRow.Index != -1)
            {
                studentPayment.StudentPayNo = Convert.ToInt32(dgvStudentPayment.CurrentRow.Cells["StudentPayNo"].Value);

                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    studentPayment = db.StudentPayments.Where(x => x.StudentPayNo == studentPayment.StudentPayNo).FirstOrDefault();
                    txtStudentID.Text = studentPayment.StudentID;
                    txtStudentName.Text = studentPayment.StudentName;
                    txtStudentGrade.Text = studentPayment.StudentGrade;
                    txtStudentExamFee.Text = studentPayment.ExamFee;
                    txtStudentFacilityFee.Text = studentPayment.FacilityFee;
                    txtStudentTotal.Text = studentPayment.TotalFee;

                }
                btnStuSave.Text = "Update";
                btnStuDelete.Enabled = true;
            }
        }

        //Delete Button
        private void btnStuDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record ?", "Obadaella Vidyalaya", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    var entry = db.Entry(studentPayment);
                    if (entry.State == EntityState.Detached)
                        db.StudentPayments.Attach(studentPayment);
                    db.StudentPayments.Remove(studentPayment);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        //Search with Student ID
        private void txtStuPaySearch_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvStudentPayment.DataSource = db.StudentPayments.Where(x => x.StudentID.Contains(txtStuPaySearch.Text)).ToList();
            }
        }


        //StudentID validation
        private void txtStudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits and Letters Only!");
            }

        }

        //Student Name Validation
        private void txtStudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Letters and whitespace only
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Letters Only!");
            }
        }


        //Student Grade Validation
        private void txtStudentGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits and Letters Only!");
            }

        }

        //Student Exam Fee Validation
        private void txtStudentExamFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits only
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits Only!");
            }
        }

        //Student Facility Fee Validation
        private void txtStudentFacilityFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits only
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits Only!");
            }
        }

        //Student Total Fee Validation
        private void txtStudentTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits only
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits Only!");
            }
        }

        //Connect to homepage
        private void pictureBox19_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHome home1 = new PaymentHome();
            home1.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHome home1 = new PaymentHome();
            home1.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        //connect to student payments view
        private void btnStuView_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            StudentPaymentView studentPaymentView = new StudentPaymentView();
            studentPaymentView.Show();
        }

        //Demo btn
        private void btnDemoSP_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "STD006";
            txtStudentName.Text = "Shashi Nawodya";
            txtStudentGrade.Text = "12B";
            txtStudentExamFee.Text = "400";
            txtStudentFacilityFee.Text = "750";
        }
    }
}



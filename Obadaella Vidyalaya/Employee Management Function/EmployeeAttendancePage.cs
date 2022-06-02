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
    public partial class EmployeeAttendancePage : Form
    {
        Employee_Attendance modelA = new Employee_Attendance();

        public EmployeeAttendancePage()
        {
            InitializeComponent();
        }

        public static String username, password;
        public EmployeeAttendancePage(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }

 // ---------------------------------------------------------------------------------------------------
 //Navigation
        //Arrow Icon
        private void backArrowEA_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage obj = new EmployeeHomePage();
            obj.Show();
        }

        //Icon Click Event
        private void EAempPB_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage empHome = new EmployeeHomePage();
            empHome.Show();
        }

        //Navigate to EmployeesAttendanceView
        private void btnPrintAttendance_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeesAttendanceView obj = new EmployeesAttendanceView();
            obj.Show();
        }
//--------------------------------------------------------------------------------------

//CRUD

        //Cancel btn
        private void btnCancelAttendance_Click(object sender, EventArgs e)
        {
            clearAttendance();
        }

        //Clear text boxes
        void clearAttendance()
        {
            txtEmpCodeAttendance.Text = txtEmpNameAttendance.Text = txtEmpDesiAttendance.Text = "";
            PresentRbtn.Checked = false;
            AbsentRbtn.Checked = false;
            btnSaveAttendance.Text = "Save";
            btnDeleteAttendance.Enabled = false;

            modelA.ATTENDID = 0;
        }

        private void EmployeeAttendance_Load(object sender, EventArgs e)
        {
            clearAttendance();
            DisplayDataGridViewAttendance();
        }

        //Save btn
        private void btnSaveAttendance_Click(object sender, EventArgs e)
        {
            if(txtEmpCodeAttendance.Text == string.Empty || txtEmpNameAttendance.Text == string.Empty || txtEmpDesiAttendance.Text == string.Empty)
            {
                MessageBox.Show("All Details Required!");
            }
            else
            {
                modelA.EMPCODE = txtEmpCodeAttendance.Text.Trim();
                modelA.EMPNAME = txtEmpNameAttendance.Text.Trim();
                modelA.DESIGNATION = txtEmpDesiAttendance.Text.Trim();
                modelA.DATE = DateTime.Now.ToString();
                if (PresentRbtn.Checked)
                {
                    modelA.STATUS = "Present";
                }
                else
                {
                    modelA.STATUS = "Absent";
                }

                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    if (modelA.ATTENDID == 0)//Insert
                    {
                        db.Employee_Attendance.Add(modelA);
                    }
                    else //update
                    {
                        db.Entry(modelA).State = EntityState.Modified;
                    }

                    db.SaveChanges();
                }
                clearAttendance();
                DisplayDataGridViewAttendance();
                MessageBox.Show("Submitted Successfully");
            }

        }

        //Display data on dgv
        void DisplayDataGridViewAttendance()
        {
            dgvEmpAttendance.AutoGenerateColumns = false;

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmpAttendance.DataSource = db.Employee_Attendance.ToList<Employee_Attendance>();
            }
        }

        //Update and Delete data from dvg
        private void dgvEmpAttendance_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmpAttendance.CurrentRow.Index != -1)
            {
                modelA.ATTENDID = Convert.ToInt32(dgvEmpAttendance.CurrentRow.Cells["AttendanceID"].Value);
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    modelA = db.Employee_Attendance.Where(x => x.ATTENDID == modelA.ATTENDID).FirstOrDefault();
                    txtEmpCodeAttendance.Text = modelA.EMPCODE;
                    txtEmpNameAttendance.Text = modelA.EMPNAME;
                    txtEmpDesiAttendance.Text = modelA.DESIGNATION;
                    if(modelA.STATUS == "Present")
                    {
                        PresentRbtn.Checked = true;
                    }
                    else
                    {
                        AbsentRbtn.Checked = true;
                    }
                }
                btnSaveAttendance.Text = "Update";
                btnDeleteAttendance.Enabled = true;
            }
        }

        //Delete btn
        private void btnDeleteAttendance_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure to Delete ? ", "Employee Attendance", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    var entry = db.Entry(modelA);

                    if (entry.State == EntityState.Detached)
                    {
                        db.Employee_Attendance.Attach(modelA);
                    }

                    db.Employee_Attendance.Remove(modelA);
                    db.SaveChanges();
                    DisplayDataGridViewAttendance();
                    clearAttendance();
                    MessageBox.Show("Deleted Succesdsfully");
                }
            }
        }

 //Search
        //Search Attendance
        private void dtpSearchAttendance_ValueChanged(object sender, EventArgs e)
        {
            txtSearchAttendance.Text = dtpSearchAttendance.Text;
        }

        private void txtSearchAttendance_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmpAttendance.DataSource = db.Employee_Attendance.Where(x => x.DATE.Contains(txtSearchAttendance.Text)).ToList();
            }
        }

//Validation
        //Employee Code txtbox Validation
        private void txtEmpCodeAttendance_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits and Letters Only!");
            }
        }

        //Employee Name txtbox Validation
        private void txtEmpNameAttendance_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Letters and whitespace only
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Letters Only!");
            }
        }

        //Designation txtbox Validation
        private void txtEmpDesiAttendance_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits and Letters Only!");
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        //Demo Btn
        private void btnDemoAttendance_Click(object sender, EventArgs e)
        {
            txtEmpCodeAttendance.Text = "EMP006";
            txtEmpDesiAttendance.Text = "Cleaner";
            txtEmpNameAttendance.Text = "Mahninda Rajapaksha";
            AbsentRbtn.Checked = true;
        }

    }
}

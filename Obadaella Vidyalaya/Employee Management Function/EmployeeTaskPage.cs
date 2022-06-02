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
    public partial class EmployeeTaskPage : Form
    {
        Employee_Tasks model = new Employee_Tasks();

        public EmployeeTaskPage()
        {
            InitializeComponent();
        }

        public static String username, password;
        public EmployeeTaskPage(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }

//-----------------------------------------------------------------------------------------------------------
//Navigation
        //Arrow Icon
        private void backArrowET_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage empHome = new EmployeeHomePage();
            empHome.Show();
        }

        //Icon Click Event
        private void ETempPB_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage empHome = new EmployeeHomePage();
            empHome.Show();
        }
//-------------------------------------------------------------------------------------------------------------
//CRUD
        //Cancel btn
        private void btnCancel_Click(object sender, EventArgs e)
        {
            TaskClear();
        }

        //Clear Text Boxes
        void TaskClear()
        {
            txtTask.Text = txtTaskEMPName.Text = txtTaskEMPCode.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;

            model.TASKID = 0;
        }

        //Task Page Load  Event
        private void TaskManage_Load(object sender, EventArgs e)
        {
            TaskClear();
            DisplayDataGridView();
        }


        //Save btn
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTask.Text == string.Empty || txtTaskEMPName.Text == string.Empty || txtTaskEMPCode.Text == string.Empty)
            {
                MessageBox.Show("All Details Reqired!");
            }
            else 
            {
                model.EMPCODE = txtTaskEMPCode.Text.Trim();
                model.TASKNAME = txtTask.Text.Trim();
                model.EMPLOYEENAME = txtTaskEMPName.Text.Trim();
                model.TASKDATE = DateTime.Now;

                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    if (model.TASKID == 0)//Insert
                        db.Employee_Tasks.Add(model);
                    else//Update
                        db.Entry(model).State = EntityState.Modified;
                    db.SaveChanges();

                }

                TaskClear();
                DisplayDataGridView();
                MessageBox.Show("Submitted Successfully");
            }
            
        }

        //Display Data on DGV
        void DisplayDataGridView()
        {
            dgvEmpTask.AutoGenerateColumns = false;

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmpTask.DataSource = db.Employee_Tasks.ToList<Employee_Tasks>();
            }

        }


        //DGV Data Update and Delete
        private void dgvEmpTask_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmpTask.CurrentRow.Index != -1) //check click data raw or not 
            {
                model.TASKID = Convert.ToInt32(dgvEmpTask.CurrentRow.Cells["TASKID"].Value); //select task record using task id

                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    model = db.Employee_Tasks.Where(x => x.TASKID == model.TASKID).FirstOrDefault();
                    txtTaskEMPCode.Text = model.EMPCODE;
                    txtTaskEMPName.Text = model.EMPLOYEENAME;
                    txtTask.Text = model.TASKNAME;
                }

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }

        //Delete btn
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete ?", "Employee Task Management", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == EntityState.Detached)
                    {
                        db.Employee_Tasks.Attach(model);
                    }
                    db.Employee_Tasks.Remove(model);
                    db.SaveChanges();
                    DisplayDataGridView();
                    TaskClear();
                    MessageBox.Show("Deleted Sucessfully");
                }

            }
        }

//Search
        //Search Task
        private void txtSearchTask_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmpTask.DataSource = db.Employee_Tasks.Where(x => x.EMPCODE.Contains(txtSearchTask.Text)).ToList();
            }
        }

//Validation        

        //Employee Code txtbox Validation
        private void txtTaskEMPCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits and Letters Only!");
            }
        }

        //Employee Name txtbox Validation
        private void txtTaskEMPName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Letters and whitespace only
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Letters Only!");
            }
        }

        //Task Name txtbox Validation
        private void txtTask_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits and Letters Only!");
            }
        }

        //Demo btn
        private void btnDemoTask_Click(object sender, EventArgs e)
        {
            txtTaskEMPCode.Text = "EMP006";
            txtTaskEMPName.Text = "Mahinda Rajapaksha";
            txtTask.Text = "Main Building Clean";
        }

        //Mouse Hover Color Change
        private void txtTaskEMPName_MouseHover(object sender, EventArgs e) // Mouse Hover text box
        {
            txtTaskEMPName.BackColor = Color.White;
        }


        private void txtTask_MouseHover(object sender, EventArgs e)
        {
            txtTask.BackColor = Color.White;
        }

        private void txtTaskEMPName_MouseEnter(object sender, EventArgs e) // Mouse Hover tex box
        {
            txtTaskEMPName.BackColor = Color.LightSkyBlue;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        private void txtTask_MouseEnter(object sender, EventArgs e)
        {
            txtTask.BackColor = Color.LightSkyBlue;
        }
    }
}

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
using System.Text.RegularExpressions;

namespace Obadaella_Vidyalaya
{
    public partial class EmployeeRegisterPage : Form
    {
        //Create Obj from Emoployee Register class
        Employee_Register modelR = new Employee_Register();

        public EmployeeRegisterPage()
        {
            InitializeComponent();
        }

        public static String username, password;
        public EmployeeRegisterPage(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }
//-----------------------------------------------------------------------------------------------------
//Navigation
        //Arrow Icon
        private void backArrowER_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage empHome = new EmployeeHomePage();
            empHome.Show();
        }

        //Icon Page Change
        private void ERempPB_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage empHome = new EmployeeHomePage();
            empHome.Show();
        }

        //Print Btn
        private void btnPrintEmpReg_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeesDetailsView empHome = new EmployeesDetailsView();
            empHome.Show();
        }
//------------------------------------------------------------------------------------
//CRUD

        //Cancel btn
        private void btnCancelReg_Click(object sender, EventArgs e)
        {
            txtEmpCodeReg.Enabled = true;
            txtEmpCodeReg.BackColor = Color.White;
            clearRegForm();
            DisplayDataGridView();
        }

        void clearRegForm()
        {
            txtEmpCodeReg.Text = txtEmpNameReg.Text = txtNicReg.Text = txtAddressReg.Text = dtpEmpDOB.Text = txtContactReg.Text = txtEmailReg.Text = txtDesignationReg.Text = "";
            MaleRbtn.Checked = false;
            FemaleRbtn.Checked = false;
            btnRegisterReg.Text = "Save";
            btnDeleteReg.Enabled = false;
            modelR.EMPNO = 0;
        }

        private void EmployeeRegister_Load(object sender, EventArgs e)
        {
            clearRegForm();
            DisplayDataGridView();
        }

        //Register btn
        private void btnRegisterReg_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtEmpCodeReg.Text == string.Empty || txtEmpNameReg.Text == string.Empty || txtNicReg.Text == string.Empty || txtAddressReg.Text == string.Empty || txtContactReg.Text == string.Empty || txtEmailReg.Text == string.Empty || txtDesignationReg.Text == string.Empty)
                {
                    MessageBox.Show("All Details Reqired!");
                }
                else
                {
                    txtEmpCodeReg.Enabled = true;
                    txtEmpCodeReg.BackColor = Color.White;
                    modelR.EMPCODE = txtEmpCodeReg.Text.Trim();
                    modelR.EMPNAME = txtEmpNameReg.Text.Trim();
                    modelR.EMPNIC = txtNicReg.Text.Trim();
                    modelR.EMPDOB = dtpEmpDOB.Text.Trim();
                    modelR.EMPCONTACT = txtContactReg.Text.Trim();
                    modelR.EMPEMAIL = txtEmailReg.Text.Trim();
                    modelR.EMPADDRESS = txtAddressReg.Text.Trim();
                    modelR.EMPDESIGNATION = txtDesignationReg.Text.Trim();
                    modelR.EMPDATE = DateTime.Now;

                    try
                    {
                        if (MaleRbtn.Checked)
                        {
                            modelR.EMPGENDER = "Male";
                        }
                        else
                        {
                            modelR.EMPGENDER = "Female";
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }

                    using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                    {
                        if (modelR.EMPNO == 0)//Insert
                        {
                            db.Employee_Register.Add(modelR);// Insert new Employee Usng modelR (Employee Register obj)
                        }
                        else//update
                        {
                            db.Entry(modelR).State = EntityState.Modified;
                        }
                        db.SaveChanges();
                    }

                    clearRegForm();
                    DisplayDataGridView();
                    MessageBox.Show("Submitted Successfully");
                }
            }
            catch(Exception x)
            {
               MessageBox.Show("Can't Give Already Used EMPLOYEE CODE & Can't Change EMPLOYEE CODE!!");
            }
        }

        void DisplayDataGridView()
        {
            dgvRegister.AutoGenerateColumns = false;
            
            using(Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvRegister.DataSource = db.Employee_Register.ToList<Employee_Register>();//convert Employee list
            }
        }

        private void dgvRegister_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvRegister.CurrentRow.Index != -1)
                {
                    modelR.EMPNO = Convert.ToInt32(dgvRegister.CurrentRow.Cells["EMPNO"].Value); //select record using EMPNO adn retrieve data to txt boxes

                    using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                    {
                        modelR = db.Employee_Register.Where(x => x.EMPNO == modelR.EMPNO).FirstOrDefault();
                        txtEmpCodeReg.Enabled = false;
                        txtEmpCodeReg.BackColor = Color.Gray;
                        txtEmpCodeReg.Text = modelR.EMPCODE;
                        txtEmpNameReg.Text = modelR.EMPNAME;
                        txtNicReg.Text = modelR.EMPNIC;
                        txtAddressReg.Text = modelR.EMPADDRESS;
                        dtpEmpDOB.Text = modelR.EMPDOB;
                        txtContactReg.Text = modelR.EMPCONTACT;
                        txtEmailReg.Text = modelR.EMPEMAIL;
                        txtDesignationReg.Text = modelR.EMPDESIGNATION;
                        if (modelR.EMPGENDER == "Male")
                        {
                            MaleRbtn.Checked = true;
                        }
                        else
                        {
                            FemaleRbtn.Checked = true;
                        }
                    }

                    btnRegisterReg.Text = "Update";
                    btnDeleteReg.Enabled = true;
                }
            }
            catch(Exception x)
            {
                //MessageBox.Show("Can't Give Same EMPLOYEE CODE & Can't Change EMPLOYEE CODE!!" + x);
            }
        }

        //Delete btn
        private void btnDeleteReg_Click(object sender, EventArgs e)
        {
            //confirm the operation
            if(MessageBox.Show("Delete ? ", "Employee Registration",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using(Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    var entry = db.Entry(modelR);
                    if (entry.State == EntityState.Detached) //detached
                        db.Employee_Register.Attach(modelR); //attached emplreg obj into the employee list
                    db.Employee_Register.Remove(modelR);
                    db.SaveChanges();
                    DisplayDataGridView();
                    clearRegForm();
                    MessageBox.Show("Deleted Successfully");
                    txtEmpCodeReg.Enabled = true;
                    txtEmpCodeReg.BackColor = Color.White;
                }
            }
        }

        //Search Employee
        private void txtSearchRegister_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvRegister.DataSource = db.Employee_Register.Where(x => x.EMPCODE.Contains(txtSearchEmpRegister.Text)).ToList();
            }
        }


 //Validation Parts------------------------------------------------------------------------------------------------------------------------------------------------ 

        //Email Validation txtbox
        private void txtEmailReg_Leave(object sender, EventArgs e)
        {
            EmailValidation();
        }

        void EmailValidation()
        {
            if (txtEmailReg.Text.Length > 0)
            {
                Regex REgexEmail = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!REgexEmail.IsMatch(txtEmailReg.Text.Trim()))
                {
                    MessageBox.Show("Email is not valid, Please provide a valid Email!");
                    txtEmailReg.Focus();
                    return;
                }
            }
        }

//Date Time Picker Validation
        private void dtpEmpDOB_ValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Now < dtpEmpDOB.Value)
            {
                MessageBox.Show("You Selected Date Is Invalid!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpEmpDOB.Value = DateTime.Today;
            }
        }

        //Employee Name txtbox Validation
        private void txtEmpNameReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Letters and whitespace only
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Letters Only!");
            }
        }

        //Employee Code txtbox Validation
        private void txtEmpCodeReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if(!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Letters & Digits Only!");
            }

        }

        //NIC txtbox Validation
        private void txtNicReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Letters & Digits Only!");
            }
        }

        //Contact txtbox Validation
        private void txtContactReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error, A Phone number cannot contain letters!");
            }
        }

        //Contact Validation
        private void txtContactReg_TextChanged(object sender, EventArgs e)
        {
            if(txtContactReg.TextLength == 10)
            {
                txtContactReg.ForeColor = Color.Black;
            }
            else
            {
                txtContactReg.ForeColor = Color.Red;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        //Demo btn
        private void btnDemoReg_Click(object sender, EventArgs e)
        {
            txtEmpCodeReg.Text = "EMP007";
            txtEmpNameReg.Text = "Mahinda Rajapaksha";
            txtNicReg.Text = "602200657V";
            txtAddressReg.Text = "calton house, Tangalle";
            txtDesignationReg.Text = "Teacher";
            txtContactReg.Text = "0714245765";
            txtEmailReg.Text = "MahindaHora@gmail.com";
            MaleRbtn.Checked = true;

        }












        //Insert Image and Browse Image 
        /*
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openedlg = new OpenFileDialog();

            if (openedlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openedlg.FileName);
         

            }
        }*/
    }
}

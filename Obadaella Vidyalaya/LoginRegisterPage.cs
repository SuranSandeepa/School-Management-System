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
    public partial class LoginRegisterPage : Form
    {
        Users_Table users = new Users_Table();

        public LoginRegisterPage()
        {
            InitializeComponent();
        }

        public static String username, password;
        public LoginRegisterPage(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }

        private void btnCancelLR_Click(object sender, EventArgs e)
        {
            clearRegForm();
            DisplayDataGridView();
            txtEmpIdLoginReg.Enabled = true;
            txtEmpIdLoginReg.BackColor = Color.White;
            btnSaveLR.Enabled = true;
            btnDeleteLR.Enabled = true;
        }

        void clearRegForm()
        {
            txtEmpIdLoginReg.Text = txtUNLoginReg.Text = txtPWLoginReg.Text = "";
            btnSaveLR.Text = "Save";
            btnDeleteLR.Enabled = false;
            users.USERNO = 0;
        }

        private void LoginRegisterPage_Load(object sender, EventArgs e)
        {
            clearRegForm();
            DisplayDataGridView();
        }

        private void btnSaveLR_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtEmpIdLoginReg.Text == string.Empty || txtUNLoginReg.Text == string.Empty || txtPWLoginReg.Text == string.Empty)
                {
                    MessageBox.Show("All Details Reqired!");
                }
                else
                {
                    users.EMPLOYEEID = txtEmpIdLoginReg.Text.Trim();
                    users.USERNAME = txtUNLoginReg.Text.Trim();
                    users.PASSWORD = txtPWLoginReg.Text.Trim();

                    using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                    {
                        if (users.USERNO == 0)//Insert
                        {
                            db.Users_Table.Add(users);
                        }
                        else//update
                        {
                            db.Entry(users).State = EntityState.Modified;
                        }
                        db.SaveChanges();
                    }

                    clearRegForm();
                    DisplayDataGridView();
                    MessageBox.Show("Submitted Successfully");
                    txtEmpIdLoginReg.Enabled = true;
                    txtEmpIdLoginReg.BackColor = Color.White;
                }
            }
            catch
            {
                MessageBox.Show("Can't Give Same EMPLOYEE CODE & Can't Change EMPLOYEE CODE!!");
            }
        }

        void DisplayDataGridView()
        {
            dgvLoginRegister.AutoGenerateColumns = false;

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvLoginRegister.DataSource = db.Users_Table.ToList<Users_Table>();
            }
        }

        private void dgvRegister_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvLoginRegister.CurrentRow.Index != -1)
                {
                    users.USERNO = Convert.ToInt32(dgvLoginRegister.CurrentRow.Cells["USERNO"].Value); //select task record using USER No

                    using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                    {
                        txtEmpIdLoginReg.Enabled = false;
                        txtEmpIdLoginReg.BackColor = Color.Gray;

                        users = db.Users_Table.Where(x => x.USERNO == users.USERNO).FirstOrDefault();
                        txtEmpIdLoginReg.Text = users.EMPLOYEEID;
                        txtUNLoginReg.Text = users.USERNAME;
                        txtPWLoginReg.Text = users.PASSWORD;

                        btnSaveLR.Enabled = false;
                    }

                    if(txtEmpIdLoginReg.Text == "EMP001" || txtEmpIdLoginReg.Text == "EMP002")
                    {
                        MessageBox.Show("Can't Change Admin's or Principal's Details!");
                    }
                    else
                    {
                        btnSaveLR.Enabled = true;
                        btnSaveLR.Text = "Update";
                        btnDeleteLR.Enabled = true;
                    }

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error" + x);
            }
        }

        //Delete btn
        private void btnDeleteReg_Click(object sender, EventArgs e)
        {
            if (users.EMPLOYEEID == "EMP001" || users.EMPLOYEEID == "EMP002")
            {
                MessageBox.Show("Can't Change Admin's or Principal's Details!");
            }
            else
            {
                if (MessageBox.Show("Delete ? ", "Login Creditials", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                    {
                        var entry = db.Entry(users);
                        if (entry.State == EntityState.Detached)
                            db.Users_Table.Attach(users);
                        db.Users_Table.Remove(users);
                        db.SaveChanges();
                        DisplayDataGridView();
                        clearRegForm();
                        MessageBox.Show("Deleted Successfully");
                        txtEmpIdLoginReg.Enabled = true;
                        txtEmpIdLoginReg.BackColor = Color.White;

                    }
                }
            }
        }

        //Search Employee
        private void txtSearchRegister_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvLoginRegister.DataSource = db.Users_Table.Where(x => x.EMPLOYEEID.Contains(txtSearchLoginD.Text)).ToList();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        private void backArrowLC_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainHomePage obj = new MainHomePage();
            obj.Show();
        }
    }
}

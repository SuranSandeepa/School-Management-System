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
    public partial class EmployeeSalary : Form
    {
        //Create an object
        EmployeeSalaryDetail employeeSalaryDetail = new EmployeeSalaryDetail();

        //Declare variables
        int basic, allowances, loan, totalSalary;

        public EmployeeSalary()
        {
            InitializeComponent();
        }

        //Cancel Button
        private void btnSalCacel_Click(object sender, EventArgs e)
        {
            Clear();
            txtEmpPayID.Enabled = true;
            txtEmpPayID.BackColor = Color.White;
        }

        void Clear()
        {
            txtEmpPayID.Text = txtEmployeeID.Text = txtBank.Text = txtBrach.Text = txtAccount.Text = txtBasicSalary.Text = txtAllowances.Text = txtLoanInstallments.Text = txtTotalSalary.Text = null;
            btnSalSave.Text = "Save";
            btnSalDelete.Enabled = false;
            employeeSalaryDetail.EmpSalNo = 0;
        }

        //Save Button
        private void btnSalSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpPayID.Text == string.Empty || txtEmployeeID.Text == string.Empty || txtBank.Text == string.Empty || txtBrach.Text == string.Empty || txtAccount.Text == string.Empty || txtBasicSalary.Text == string.Empty || txtAllowances.Text == string.Empty || txtTotalSalary.Text == string.Empty)
                {
                    MessageBox.Show("All Details Reqired..");
                }
                else
                {
                    txtEmpPayID.Enabled = true;
                    txtEmpPayID.BackColor = Color.White;
                    employeeSalaryDetail.EmpPayID = txtEmpPayID.Text.Trim();
                    employeeSalaryDetail.EmployeeID = txtEmployeeID.Text.Trim();
                    employeeSalaryDetail.Bank = txtBank.Text.Trim();
                    employeeSalaryDetail.Branch = txtBrach.Text.Trim();
                    employeeSalaryDetail.Account = txtAccount.Text.Trim();
                    employeeSalaryDetail.Basic = Convert.ToInt32(txtBasicSalary.Text);
                    employeeSalaryDetail.Allowances = Convert.ToInt32(txtAllowances.Text);

                    if (txtLoanInstallments.Text == string.Empty)
                    {
                        employeeSalaryDetail.Loan = null;
                    }
                    else
                    {
                        employeeSalaryDetail.Loan = Convert.ToInt32(txtLoanInstallments.Text);
                    }

                    employeeSalaryDetail.TotalSalary = Convert.ToInt32(txtTotalSalary.Text);

                    using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                    {

                        if (employeeSalaryDetail.EmpSalNo == 0)//insert details
                        {
                            db.EmployeeSalaryDetails.Add(employeeSalaryDetail);
                        }
                        else //updates details
                        {
                            db.Entry(employeeSalaryDetail).State = EntityState.Modified;
                        }

                        db.SaveChanges();
                    }
                    Clear();
                    PopulateDataGridView();
                    MessageBox.Show("Submitted Successfully");
                }
            }
            catch (Exception ex)
            {

                // loan = 0;
                //string zero = "0";
                //txtLoanInstallments.Text = zero.Trim();
                MessageBox.Show("Can't give already used payment ID");

            }


        }
        //Calculate Button
        private void btnSalCalculate_Click(object sender, EventArgs e)
        {
            basic = int.Parse(txtBasicSalary.Text);
            allowances = int.Parse(txtAllowances.Text);
            if (txtLoanInstallments.Text == string.Empty)
            {
                loan = 0;
                string zero = "0";
                txtLoanInstallments.Text = zero.Trim();
            }
            else
            {
                loan = int.Parse(txtLoanInstallments.Text);
            }
            totalSalary = (basic + allowances) - loan; //Calculation

            txtTotalSalary.Text = totalSalary.ToString();

            employeeSalaryDetail.TotalSalary = Convert.ToInt32(txtTotalSalary.Text);
        }

        //Load the form
        private void EmployeeSalary_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }


        //Display Employee Salary Details
        void PopulateDataGridView()
        {
            dgvEmployeeSalary.AutoGenerateColumns = false;
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmployeeSalary.DataSource = db.EmployeeSalaryDetails.ToList<EmployeeSalaryDetail>();

            }

        }


        //Display Updated Student Payments Details
        private void dgvEmployeeSalary_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmployeeSalary.CurrentRow.Index != -1)
            {
                employeeSalaryDetail.EmpSalNo = Convert.ToInt32(dgvEmployeeSalary.CurrentRow.Cells["EmpSalNo"].Value);

                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    employeeSalaryDetail = db.EmployeeSalaryDetails.Where(x => x.EmpSalNo == employeeSalaryDetail.EmpSalNo).FirstOrDefault();

                    txtEmpPayID.Text = employeeSalaryDetail.EmpPayID;
                    txtEmpPayID.Enabled = false; // Employee Payment ID textbox can't edit
                    txtEmpPayID.BackColor = Color.Gray;
                    txtEmployeeID.Text = employeeSalaryDetail.EmployeeID;
                    txtBank.Text = employeeSalaryDetail.Bank;
                    txtBrach.Text = employeeSalaryDetail.Branch;
                    txtAccount.Text = employeeSalaryDetail.Account;
                    txtBasicSalary.Text = employeeSalaryDetail.Basic.ToString();
                    txtAllowances.Text = employeeSalaryDetail.Allowances.ToString();
                    txtLoanInstallments.Text = employeeSalaryDetail.Loan.ToString();
                    txtTotalSalary.Text = employeeSalaryDetail.TotalSalary.ToString();

                }
                btnSalSave.Text = "Update";
                btnSalDelete.Enabled = true;
            }
        }

        //Delete Button
        private void btnSalDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete this record ?", "Obadaella Vidyalaya", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    var entry = db.Entry(employeeSalaryDetail);
                    if (entry.State == EntityState.Detached)
                        db.EmployeeSalaryDetails.Attach(employeeSalaryDetail);
                    db.EmployeeSalaryDetails.Remove(employeeSalaryDetail);
                    db.SaveChanges();
                    PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                    txtEmpPayID.Enabled = true;
                    txtEmpPayID.BackColor = Color.White;
                }
            }
        }

        //Search with Employee ID
        private void txtEmpSal_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvEmployeeSalary.DataSource = db.EmployeeSalaryDetails.Where(x => x.EmployeeID.Contains(txtEmpSalSearch.Text)).ToList();

            }
        }


        //Employee Payment ID validation
        private void txtEmpPayID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits and Letters Only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits and Letters Only!");
            }
        }


        //Employee ID validation
        private void txtEmployeeID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits & Letters only
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits and Letters Only!");
            }

        }

        //Employee Bank validation
        private void txtBank_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Allow Letters and whitespace only
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Letters Only!");
            }
        }

        //Employee Bank Branch validation
        private void txtBrach_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Letters and whitespace only
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Letters Only!");
            }
        }

        //Employee Bank Account validation
        private void txtAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits only
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits Only!");
            }
        }

        //Employee Basic Salary validation
        private void txtBasicSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits only
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits Only!");
            }
        }

        //Employee Bank Allowances validation
        private void txtAllowances_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits only
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits Only!");
            }
        }

        //Employee Loan Installments validation
        private void txtLoanInstallments_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits only
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits Only!");
            }
        }

        //Employee Total validation
        private void txtTotalSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow Digits only
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Allow Digits Only!");
            }
        }

        //Connect to Homepage
        private void pictureBox19_DoubleClick(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHome home1 = new PaymentHome();
            home1.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeSalarysDetailsView home1 = new EmployeeSalarysDetailsView();
            home1.Show();
        }

        //Demo btn
        private void btnDemoEmpSal_Click(object sender, EventArgs e)
        {
            txtEmpPayID.Text = "EPID0006";
            txtEmployeeID.Text = "EMP006";
            txtBank.Text = "HNB";
            txtBrach.Text = "Kaduwela";
            txtAccount.Text = "001010011327";
            txtBasicSalary.Text = 50000.ToString();
            txtAllowances.Text = 20000.ToString();
            txtLoanInstallments.Text = 8000.ToString();

        }

    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Obadaella_Vidyalaya
{
    public partial class TTMainPage : Form
    {
        public TTMainPage()
        {
            InitializeComponent();
            Shown += run_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTEdit tTCreateNew = new TTEdit(textSearchMain.Text);
            tTCreateNew.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTReport tTReportNew = new TTReport(textSearchMain.Text);
            tTReportNew.ShowDialog();
        }
        private void dgvTTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void labelClass_Click(object sender, EventArgs e)
        {

        }
        void disable()
        {
            if (dgvTTT.Rows.Count < 8)
            {
                button4.Enabled = false;
                button2.Text = "Create New";
            }
            else
            {
                button4.Enabled = true;
                button2.Text = "Edit Timetable";
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void buttonSearchMain_Click(object sender, EventArgs e)
        {
            dgvTTT.AutoGenerateColumns = false;
            using (Obadaella_VidyalayaEntities crud = new Obadaella_VidyalayaEntities())
            {
                dgvTTT.DataSource = crud.TTs.Where(x => x.ClassPeriod.Contains(textSearchMain.Text)).ToList();
                //dgvTTT.Columns["CLassPeriod"].Visible = false;
            }

            labelClass.Text = textSearchMain.Text;

            if (String.IsNullOrEmpty(textSearchMain.Text) || !Regex.IsMatch(textSearchMain.Text, @"[a-zA-Z]") || !Regex.IsMatch(textSearchMain.Text, @"[1-9]") || dgvTTT.Rows.Count < 2)
            {
                dgvTTT.DataSource = null;
                labelClass.Text = null;
                MessageBox.Show("Enter a valid class name", "Error");
                textSearchMain.Text = null;
                //disable();
            }

            disable();
        }

        private void textSearchMain_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textSearchMain.Text))
            {
                dgvTTT.DataSource = null;
                labelClass.Text = null;
                disable();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage employeeHomePage = new EmployeeHomePage();
            employeeHomePage.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainHomePage mainHomePage = new MainHomePage();
            mainHomePage.ShowDialog();
        }
    }
}
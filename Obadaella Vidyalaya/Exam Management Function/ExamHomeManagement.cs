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
    public partial class ExamHomeManagement : Form
    {
        public ExamHomeManagement()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnlohall_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamHallManagement exam1 = new ExamHallManagement();
            exam1.Show();
        }

        private void btnloresult_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamResultsManagement exam2 = new ExamResultsManagement();
            exam2.Show();
        }

        private void btnlotimetbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            ExamTimetableManagement fexam3 = new ExamTimetableManagement();
            fexam3.Show();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainHomePage home = new MainHomePage();
            home.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage home = new EmployeeHomePage();
            home.Show();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tt = new TTMainPage();
            tt.Show();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHome tt = new PaymentHome();
            tt.Show();
        }
    }
}

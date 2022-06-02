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
    public partial class StudentPaymentView : Form
    {
        public StudentPaymentView()
        {
            InitializeComponent();
        }

        public static String username, password;
        public StudentPaymentView(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }

        void dataGridViewDisplay()
        {
            dgvStudentPaymentView.AutoGenerateColumns = false;

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvStudentPaymentView.DataSource = db.StudentPayments.ToList<StudentPayment>();
            }
        }

        private void StudentPaymentView_Load(object sender, EventArgs e)
        {
            dataGridViewDisplay();
        }

        //Search
        private void txtStuPaySearch_TextChanged(object sender, EventArgs e)
        {
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                if (String.IsNullOrEmpty(txtStuPaySearch.Text))
                {
                    dgvStudentPaymentView.DataSource = null;
                }
                dgvStudentPaymentView.DataSource = db.StudentPayments.Where(x => x.StudentID.Contains(txtStuPaySearch.Text)).ToList();
            }
        }


        //Print btn
        private void btnStuPrint_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentPaymentReports obj = new StudentPaymentReports(txtStuPaySearch.Text);
            obj.Show();
        }

        //PB click back to Payment Home
        private void pictureBox19_DoubleClick_1(object sender, EventArgs e)
        {
            this.Hide();
            PaymentHome obj = new PaymentHome();
            obj.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        //Arrow click back to Employee Salary Add
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Payments_Page obj = new Student_Payments_Page();
            obj.Show();
        }

    }
}

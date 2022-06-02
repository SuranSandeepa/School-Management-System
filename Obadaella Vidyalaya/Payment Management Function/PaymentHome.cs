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
    public partial class PaymentHome : Form
    {
        public PaymentHome()
        {
            InitializeComponent();
        }

        public static String username, password;
        public PaymentHome(String s, String p)
        {
            InitializeComponent();
            username = s;
            password = p;
        }

        private void btnStudentPayments_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Payments_Page obj = new Student_Payments_Page();
            obj.Show();

        }
        private void btnEmployeeSalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeSalary obj = new EmployeeSalary();
            obj.Show();
        }

        private void btnESD_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeSalarysDetailsView obj = new EmployeeSalarysDetailsView();
            obj.Show();
        }

        private void btnSPD_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentPaymentView obj = new StudentPaymentView();
            obj.Show();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        private void pictureBox3_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            MainHomePage frm = new MainHomePage();
            frm.Show();
        }


    }
}

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
    public partial class EventManagementHome : Form
    {
        public EventManagementHome()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_addEvent_Click_1(object sender, EventArgs e)
        {
           
            EventCreatePage obj = new EventCreatePage();
            obj.Show();
            this.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddSpecialNotices obj = new AddSpecialNotices();
            obj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MainHomePage obj = new MainHomePage();
            obj.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainHomePage obj = new MainHomePage();
            obj.Show();
            this.Hide();
        }
    }
}

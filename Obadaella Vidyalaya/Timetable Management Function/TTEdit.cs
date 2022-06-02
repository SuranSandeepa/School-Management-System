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
    public partial class TTEdit : Form
    {
        TT model = new TT();
        public TTEdit(string msg)
        {
            InitializeComponent();
            textSearch.Text = msg;
            Shown += buttonHidden_Click;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Add(textMonday.Text, textTuesday.Text, textWednesday.Text, textThursday.Text, textFriday.Text);

            if (textClassPeriod.Text.Trim() == string.Empty || textMonday.Text.Trim() == string.Empty || textTuesday.Text.Trim() == string.Empty || textWednesday.Text.Trim() == string.Empty || textThursday.Text.Trim() == string.Empty || textFriday.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Textboxes cannot be empty", "Error");
                return;
            }

            if (!Regex.IsMatch(textMonday.Text, "^[a-zA-Z ]*$") || !Regex.IsMatch(textTuesday.Text, "^[a-zA-Z ]*$") || !Regex.IsMatch(textWednesday.Text, "^[a-zA-Z ]*$") || !Regex.IsMatch(textThursday.Text, "^[a-zA-Z ]*$") || !Regex.IsMatch(textFriday.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("You may only enter letters", "Error");
                return;
            }

            if (!Regex.IsMatch(textClassPeriod.Text, @"[a-zA-Z]"))
            {
                MessageBox.Show("Please enter the relevant letter for class-period combination", "Error");
                return;
            }
            if (!Regex.IsMatch(textClassPeriod.Text, @"[1-9]"))
            {
                MessageBox.Show("Please enter the relevant number for class-period combination", "Error");
                return;
            }

            model.ClassPeriod = textClassPeriod.Text.Trim();
            model.Monday = textMonday.Text.Trim();
            model.Tuesday = textTuesday.Text.Trim();
            model.Wednesday = textWednesday.Text.Trim();
            model.Thursday = textThursday.Text.Trim();
            model.Friday = textFriday.Text.Trim();

            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                if (model.CountP == 0) //insert
                    db.TTs.Add(model);
                else //update
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Cannot enter an existing primary key. Change class name and period combination.", "Error");
                    return;
                }
            }
            Clear();
            //PopulateDataGridView();
            MessageBox.Show("Submitted the Record");
            textSearch_TextChanged(sender, e);

            if (dgvTT.Rows.Count > 2)
            {
                buttonSearch_Click(sender, e);
            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();
            if (dgvTT.Rows.Count > 2)
            {
                buttonSearch_Click(sender, e);
            }
        }

        void Clear()
        {
            textClassPeriod.Text = textMonday.Text = textTuesday.Text = textWednesday.Text = textThursday.Text = textFriday.Text = "";
            buttonAdd.Text = "Add the row";
            buttonDelete.Enabled = false;
            model.CountP = 0;
            textClassPeriod.ReadOnly = false;
            textClassPeriod.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete this row?", "Timetable System", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    var entry = db.Entry(model);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.TTs.Attach(model);
                    db.TTs.Remove(model);
                    db.SaveChanges();
                    //PopulateDataGridView();
                    Clear();
                    MessageBox.Show("Deleted Successfully.");
                    textSearch_TextChanged(sender, e);
                }

            if (dgvTT.Rows.Count > 2)
            {
                buttonSearch_Click(sender, e);
            }
        }

        private void TTCreateNew_Load(object sender, EventArgs e)
        {
            Clear();
            PopulateDataGridView();
        }

        void PopulateDataGridView()
        {
            dgvTT.AutoGenerateColumns = false;
            using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
            {
                dgvTT.DataSource = db.TTs.ToList<TT>();
            }
        }

        private void dgvTT_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTT.CurrentRow.Index != -1)
            {
                model.CountP = Convert.ToInt32(dgvTT.CurrentRow.Cells["CountP"].Value);
                using (Obadaella_VidyalayaEntities db = new Obadaella_VidyalayaEntities())
                {
                    model = db.TTs.Where(x => x.CountP == model.CountP).FirstOrDefault();
                    textClassPeriod.Text = model.ClassPeriod;
                    textMonday.Text = model.Monday;
                    textTuesday.Text = model.Tuesday;
                    textWednesday.Text = model.Wednesday;
                    textThursday.Text = model.Thursday;
                    textFriday.Text = model.Friday;
                }
                buttonAdd.Text = "Update";
                textClassPeriod.ReadOnly = true;
                textClassPeriod.BackColor = Color.Gray;
                buttonDelete.Enabled = true;
            }
            if (textClassPeriod.Text.Trim() == string.Empty || textMonday.Text.Trim() == string.Empty || textTuesday.Text.Trim() == string.Empty || textWednesday.Text.Trim() == string.Empty || textThursday.Text.Trim() == string.Empty || textFriday.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Textboxes cannot be empty", "Error");
                return;
            }

            if (!Regex.IsMatch(textMonday.Text, "^[a-zA-Z ]*$") || !Regex.IsMatch(textTuesday.Text, "^[a-zA-Z ]*$") || !Regex.IsMatch(textWednesday.Text, "^[a-zA-Z ]*$") || !Regex.IsMatch(textThursday.Text, "^[a-zA-Z ]*$") || !Regex.IsMatch(textFriday.Text, "^[a-zA-Z ]*$"))
            {
                MessageBox.Show("You may only enter letters", "Error");
                return;
            }
        }

        private void textClassPeriod_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            TTMainPage tTMainPage = new TTMainPage();
            tTMainPage.ShowDialog();
        }

        private void textMonday_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textSearch.Text))
            {
                dgvTT.DataSource = null;
                labelClass.Text = null;
                textClassPeriod.Text = textMonday.Text = textTuesday.Text = textWednesday.Text = textThursday.Text = textFriday.Text = null;
                buttonAdd.Text = "Add the row";
                textClassPeriod.ReadOnly = false;
                textClassPeriod.BackColor = Color.White;
                buttonDelete.Enabled = false;
                label2.Text = "Create New";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelClass_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dgvTT.AutoGenerateColumns = false;
            using (Obadaella_VidyalayaEntities crud = new Obadaella_VidyalayaEntities())
            {
                dgvTT.DataSource = crud.TTs.Where(x => x.ClassPeriod.Contains(textSearch.Text)).ToList();
            }

            if (dgvTT.Rows.Count != 0)
            {
                labelClass.Text = textSearch.Text;
                label2.Text = "Timetable Edit";
            }

            if (String.IsNullOrEmpty(textSearch.Text) || !Regex.IsMatch(textSearch.Text, @"[a-zA-Z]") || !Regex.IsMatch(textSearch.Text, @"[1-9]") || dgvTT.Rows.Count < 2)
            {
                dgvTT.DataSource = null;
                labelClass.Text = null;
                MessageBox.Show("Enter a valid class name", "Error");
                textSearch.Text = null;
            }
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            dgvTT.AutoGenerateColumns = false;
            using (Obadaella_VidyalayaEntities crud = new Obadaella_VidyalayaEntities())
            {
                dgvTT.DataSource = crud.TTs.Where(x => x.ClassPeriod.Contains(textSearch.Text)).ToList();
            }

            if (dgvTT.Rows.Count != 0)
            {
                labelClass.Text = textSearch.Text;
            }

            if (String.IsNullOrEmpty(textSearch.Text))
            {
                dgvTT.DataSource = null;
                label2.Text = "Create New";
            }
        }

        private void buttonInterval_Click(object sender, EventArgs e)
        {
            textMonday.Text = "IN";
            textTuesday.Text = "T";
            textWednesday.Text = "ER";
            textThursday.Text = "V";
            textFriday.Text = "AL";
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeHomePage employeeHomePage = new EmployeeHomePage();
            employeeHomePage.ShowDialog();
        }
    }
}

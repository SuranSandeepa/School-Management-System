
namespace Obadaella_Vidyalaya
{
    partial class EmployeesAttendanceView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeesAttendanceView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpSearchAttendanceView = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchEmpAttendanceView = new System.Windows.Forms.TextBox();
            this.dgvEmployeeAttendanceDetails = new System.Windows.Forms.DataGridView();
            this.ATTENDID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESIGNATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrintAttendance = new System.Windows.Forms.Button();
            this.backArrowAV = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.AVempPB = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAttendanceDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowAV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVempPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.dtpSearchAttendanceView);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtSearchEmpAttendanceView);
            this.panel1.Controls.Add(this.dgvEmployeeAttendanceDetails);
            this.panel1.Controls.Add(this.btnPrintAttendance);
            this.panel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(62, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 580);
            this.panel1.TabIndex = 79;
            // 
            // dtpSearchAttendanceView
            // 
            this.dtpSearchAttendanceView.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchAttendanceView.Location = new System.Drawing.Point(837, 8);
            this.dtpSearchAttendanceView.Name = "dtpSearchAttendanceView";
            this.dtpSearchAttendanceView.Size = new System.Drawing.Size(198, 23);
            this.dtpSearchAttendanceView.TabIndex = 82;
            this.dtpSearchAttendanceView.ValueChanged += new System.EventHandler(this.dtpSearchAttendanceView_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(807, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchEmpAttendanceView
            // 
            this.txtSearchEmpAttendanceView.Location = new System.Drawing.Point(850, 8);
            this.txtSearchEmpAttendanceView.Name = "txtSearchEmpAttendanceView";
            this.txtSearchEmpAttendanceView.Size = new System.Drawing.Size(185, 23);
            this.txtSearchEmpAttendanceView.TabIndex = 73;
            this.txtSearchEmpAttendanceView.Visible = false;
            this.txtSearchEmpAttendanceView.TextChanged += new System.EventHandler(this.txtSearchEmpAttendanceView_TextChanged);
            // 
            // dgvEmployeeAttendanceDetails
            // 
            this.dgvEmployeeAttendanceDetails.AllowUserToDeleteRows = false;
            this.dgvEmployeeAttendanceDetails.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvEmployeeAttendanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeAttendanceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ATTENDID,
            this.EMPCODE,
            this.EMPNAME,
            this.DESIGNATION,
            this.STATUS,
            this.DATE});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeAttendanceDetails.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeAttendanceDetails.Location = new System.Drawing.Point(18, 34);
            this.dgvEmployeeAttendanceDetails.Name = "dgvEmployeeAttendanceDetails";
            this.dgvEmployeeAttendanceDetails.ReadOnly = true;
            this.dgvEmployeeAttendanceDetails.RowHeadersVisible = false;
            this.dgvEmployeeAttendanceDetails.RowHeadersWidth = 51;
            this.dgvEmployeeAttendanceDetails.Size = new System.Drawing.Size(1017, 489);
            this.dgvEmployeeAttendanceDetails.TabIndex = 32;
            // 
            // ATTENDID
            // 
            this.ATTENDID.HeaderText = "AttendID";
            this.ATTENDID.MinimumWidth = 6;
            this.ATTENDID.Name = "ATTENDID";
            this.ATTENDID.ReadOnly = true;
            this.ATTENDID.Visible = false;
            this.ATTENDID.Width = 125;
            // 
            // EMPCODE
            // 
            this.EMPCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPCODE.DataPropertyName = "EMPCODE";
            this.EMPCODE.HeaderText = "Employee ID";
            this.EMPCODE.MinimumWidth = 6;
            this.EMPCODE.Name = "EMPCODE";
            this.EMPCODE.ReadOnly = true;
            // 
            // EMPNAME
            // 
            this.EMPNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPNAME.DataPropertyName = "EMPNAME";
            this.EMPNAME.HeaderText = "Name";
            this.EMPNAME.MinimumWidth = 6;
            this.EMPNAME.Name = "EMPNAME";
            this.EMPNAME.ReadOnly = true;
            // 
            // DESIGNATION
            // 
            this.DESIGNATION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESIGNATION.DataPropertyName = "DESIGNATION";
            this.DESIGNATION.HeaderText = "Designation";
            this.DESIGNATION.MinimumWidth = 6;
            this.DESIGNATION.Name = "DESIGNATION";
            this.DESIGNATION.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Status";
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // DATE
            // 
            this.DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DATE.DataPropertyName = "DATE";
            this.DATE.HeaderText = "Date";
            this.DATE.MinimumWidth = 6;
            this.DATE.Name = "DATE";
            this.DATE.ReadOnly = true;
            // 
            // btnPrintAttendance
            // 
            this.btnPrintAttendance.BackColor = System.Drawing.Color.Yellow;
            this.btnPrintAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnPrintAttendance.Location = new System.Drawing.Point(390, 526);
            this.btnPrintAttendance.Name = "btnPrintAttendance";
            this.btnPrintAttendance.Size = new System.Drawing.Size(274, 46);
            this.btnPrintAttendance.TabIndex = 31;
            this.btnPrintAttendance.Text = "Print";
            this.btnPrintAttendance.UseVisualStyleBackColor = false;
            this.btnPrintAttendance.Click += new System.EventHandler(this.btnPrintAttendance_Click);
            // 
            // backArrowAV
            // 
            this.backArrowAV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backArrowAV.BackColor = System.Drawing.Color.Maroon;
            this.backArrowAV.Image = ((System.Drawing.Image)(resources.GetObject("backArrowAV.Image")));
            this.backArrowAV.Location = new System.Drawing.Point(9, 5);
            this.backArrowAV.Name = "backArrowAV";
            this.backArrowAV.Size = new System.Drawing.Size(30, 23);
            this.backArrowAV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backArrowAV.TabIndex = 82;
            this.backArrowAV.TabStop = false;
            this.backArrowAV.Click += new System.EventHandler(this.backArrowAV_Click);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.Maroon;
            this.label11.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(-3, -2);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1117, 37);
            this.label11.TabIndex = 81;
            this.label11.Text = "Employee Attendance";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.AVempPB);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(-3, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 610);
            this.panel2.TabIndex = 80;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 545);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(36, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 337);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(36, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 41);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(12, 410);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(36, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(12, 477);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.MaximumSize = new System.Drawing.Size(36, 41);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(36, 41);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(12, 258);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox6.MaximumSize = new System.Drawing.Size(36, 41);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(36, 41);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(12, 109);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.MaximumSize = new System.Drawing.Size(36, 41);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // AVempPB
            // 
            this.AVempPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AVempPB.Image = ((System.Drawing.Image)(resources.GetObject("AVempPB.Image")));
            this.AVempPB.Location = new System.Drawing.Point(12, 30);
            this.AVempPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AVempPB.MaximumSize = new System.Drawing.Size(36, 41);
            this.AVempPB.Name = "AVempPB";
            this.AVempPB.Size = new System.Drawing.Size(36, 41);
            this.AVempPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AVempPB.TabIndex = 4;
            this.AVempPB.TabStop = false;
            this.AVempPB.DoubleClick += new System.EventHandler(this.AVempPB_DoubleClick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(11, 184);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox9.MaximumSize = new System.Drawing.Size(36, 41);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 41);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // EmployeesAttendanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 639);
            this.Controls.Add(this.backArrowAV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "EmployeesAttendanceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeesAttendanceView";
            this.Load += new System.EventHandler(this.EmployeesAttendanceView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeAttendanceDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowAV)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AVempPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearchEmpAttendanceView;
        private System.Windows.Forms.DataGridView dgvEmployeeAttendanceDetails;
        private System.Windows.Forms.Button btnPrintAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATTENDID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESIGNATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE;
        private System.Windows.Forms.PictureBox backArrowAV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox AVempPB;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpSearchAttendanceView;
    }
}

namespace Obadaella_Vidyalaya
{
    partial class EmployeeReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeReports));
            this.txtEmpViewCR = new System.Windows.Forms.TextBox();
            this.btnEmpViewCR = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dgvEmpViewCR = new System.Windows.Forms.DataGridView();
            this.EMPNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPDESIGNATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPGENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPAGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPCONTACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPEMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpViewCR)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmpViewCR
            // 
            this.txtEmpViewCR.Location = new System.Drawing.Point(1009, 2);
            this.txtEmpViewCR.Name = "txtEmpViewCR";
            this.txtEmpViewCR.Size = new System.Drawing.Size(10, 20);
            this.txtEmpViewCR.TabIndex = 1;
            this.txtEmpViewCR.Visible = false;
            this.txtEmpViewCR.TextChanged += new System.EventHandler(this.txtEmpViewCR_TextChanged);
            // 
            // btnEmpViewCR
            // 
            this.btnEmpViewCR.Location = new System.Drawing.Point(1041, 6);
            this.btnEmpViewCR.Name = "btnEmpViewCR";
            this.btnEmpViewCR.Size = new System.Drawing.Size(10, 10);
            this.btnEmpViewCR.TabIndex = 2;
            this.btnEmpViewCR.Text = "button1";
            this.btnEmpViewCR.UseVisualStyleBackColor = true;
            this.btnEmpViewCR.Visible = false;
            this.btnEmpViewCR.Click += new System.EventHandler(this.btnEmpViewCR_TextChanged_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-1, 113);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1112, 524);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // dgvEmpViewCR
            // 
            this.dgvEmpViewCR.AllowUserToDeleteRows = false;
            this.dgvEmpViewCR.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvEmpViewCR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpViewCR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EMPNO,
            this.EMPCODE,
            this.EMPNAME,
            this.EMPDESIGNATION,
            this.EMPNIC,
            this.EMPADDRESS,
            this.EMPGENDER,
            this.EMPAGE,
            this.EMPCONTACT,
            this.EMPEMAIL,
            this.EMPDATE});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpViewCR.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpViewCR.Location = new System.Drawing.Point(1025, 6);
            this.dgvEmpViewCR.Name = "dgvEmpViewCR";
            this.dgvEmpViewCR.ReadOnly = true;
            this.dgvEmpViewCR.RowHeadersVisible = false;
            this.dgvEmpViewCR.Size = new System.Drawing.Size(10, 10);
            this.dgvEmpViewCR.TabIndex = 33;
            // 
            // EMPNO
            // 
            this.EMPNO.DataPropertyName = "EMPNO";
            this.EMPNO.HeaderText = "ID";
            this.EMPNO.Name = "EMPNO";
            this.EMPNO.ReadOnly = true;
            this.EMPNO.Visible = false;
            // 
            // EMPCODE
            // 
            this.EMPCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPCODE.DataPropertyName = "EMPCODE";
            this.EMPCODE.HeaderText = "Employee ID";
            this.EMPCODE.Name = "EMPCODE";
            this.EMPCODE.ReadOnly = true;
            // 
            // EMPNAME
            // 
            this.EMPNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPNAME.DataPropertyName = "EMPNAME";
            this.EMPNAME.HeaderText = "Name";
            this.EMPNAME.Name = "EMPNAME";
            this.EMPNAME.ReadOnly = true;
            // 
            // EMPDESIGNATION
            // 
            this.EMPDESIGNATION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPDESIGNATION.DataPropertyName = "EMPDESIGNATION";
            this.EMPDESIGNATION.HeaderText = "Designation";
            this.EMPDESIGNATION.Name = "EMPDESIGNATION";
            this.EMPDESIGNATION.ReadOnly = true;
            // 
            // EMPNIC
            // 
            this.EMPNIC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPNIC.DataPropertyName = "EMPNIC";
            this.EMPNIC.HeaderText = "NIC";
            this.EMPNIC.Name = "EMPNIC";
            this.EMPNIC.ReadOnly = true;
            // 
            // EMPADDRESS
            // 
            this.EMPADDRESS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPADDRESS.DataPropertyName = "EMPADDRESS";
            this.EMPADDRESS.HeaderText = "Address";
            this.EMPADDRESS.Name = "EMPADDRESS";
            this.EMPADDRESS.ReadOnly = true;
            // 
            // EMPGENDER
            // 
            this.EMPGENDER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPGENDER.DataPropertyName = "EMPGENDER";
            this.EMPGENDER.HeaderText = "Gender";
            this.EMPGENDER.Name = "EMPGENDER";
            this.EMPGENDER.ReadOnly = true;
            // 
            // EMPAGE
            // 
            this.EMPAGE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPAGE.DataPropertyName = "EMPDOB";
            this.EMPAGE.HeaderText = "Date Of Birth";
            this.EMPAGE.Name = "EMPAGE";
            this.EMPAGE.ReadOnly = true;
            // 
            // EMPCONTACT
            // 
            this.EMPCONTACT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPCONTACT.DataPropertyName = "EMPCONTACT";
            this.EMPCONTACT.HeaderText = "Contact";
            this.EMPCONTACT.Name = "EMPCONTACT";
            this.EMPCONTACT.ReadOnly = true;
            // 
            // EMPEMAIL
            // 
            this.EMPEMAIL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPEMAIL.DataPropertyName = "EMPEMAIL";
            this.EMPEMAIL.HeaderText = "Email";
            this.EMPEMAIL.Name = "EMPEMAIL";
            this.EMPEMAIL.ReadOnly = true;
            // 
            // EMPDATE
            // 
            this.EMPDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EMPDATE.DataPropertyName = "EMPDATE";
            this.EMPDATE.HeaderText = "Joined Date";
            this.EMPDATE.Name = "EMPDATE";
            this.EMPDATE.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox19);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.MaximumSize = new System.Drawing.Size(1115, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 112);
            this.panel3.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(334, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "ඕබඩඇල්ල විද්‍යාලය,බණ්ඩාරවෙල";
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(511, 2);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox19.MaximumSize = new System.Drawing.Size(91, 89);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(77, 63);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox19.TabIndex = 0;
            this.pictureBox19.TabStop = false;
            // 
            // EmployeeReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 639);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvEmpViewCR);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnEmpViewCR);
            this.Controls.Add(this.txtEmpViewCR);
            this.MaximizeBox = false;
            this.Name = "EmployeeReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeReports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpViewCR)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmpViewCR;
        private System.Windows.Forms.Button btnEmpViewCR;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DataGridView dgvEmpViewCR;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPDESIGNATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPGENDER;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPAGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPCONTACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPEMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPDATE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox19;
    }
}
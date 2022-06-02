
namespace Obadaella_Vidyalaya
{
    partial class EmployeeAttendancePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAttendancePage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchAttendance = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpSearchAttendance = new System.Windows.Forms.DateTimePicker();
            this.btnDemoAttendance = new System.Windows.Forms.Button();
            this.AbsentRbtn = new System.Windows.Forms.RadioButton();
            this.PresentRbtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpCodeAttendance = new System.Windows.Forms.TextBox();
            this.btnPrintAttendance = new System.Windows.Forms.Button();
            this.btnCancelAttendance = new System.Windows.Forms.Button();
            this.btnDeleteAttendance = new System.Windows.Forms.Button();
            this.btnSaveAttendance = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpDesiAttendance = new System.Windows.Forms.TextBox();
            this.txtEmpNameAttendance = new System.Windows.Forms.TextBox();
            this.dgvEmpAttendance = new System.Windows.Forms.DataGridView();
            this.AttendanceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmpDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.EAempPB = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.backArrowEA = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpAttendance)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EAempPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowEA)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(798, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchAttendance
            // 
            this.txtSearchAttendance.Location = new System.Drawing.Point(827, 12);
            this.txtSearchAttendance.Name = "txtSearchAttendance";
            this.txtSearchAttendance.Size = new System.Drawing.Size(198, 23);
            this.txtSearchAttendance.TabIndex = 72;
            this.txtSearchAttendance.Visible = false;
            this.txtSearchAttendance.TextChanged += new System.EventHandler(this.txtSearchAttendance_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.dtpSearchAttendance);
            this.panel1.Controls.Add(this.btnDemoAttendance);
            this.panel1.Controls.Add(this.AbsentRbtn);
            this.panel1.Controls.Add(this.PresentRbtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtEmpCodeAttendance);
            this.panel1.Controls.Add(this.txtSearchAttendance);
            this.panel1.Controls.Add(this.btnPrintAttendance);
            this.panel1.Controls.Add(this.btnCancelAttendance);
            this.panel1.Controls.Add(this.btnDeleteAttendance);
            this.panel1.Controls.Add(this.btnSaveAttendance);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmpDesiAttendance);
            this.panel1.Controls.Add(this.txtEmpNameAttendance);
            this.panel1.Controls.Add(this.dgvEmpAttendance);
            this.panel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(71, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 486);
            this.panel1.TabIndex = 70;
            // 
            // dtpSearchAttendance
            // 
            this.dtpSearchAttendance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSearchAttendance.Location = new System.Drawing.Point(827, 12);
            this.dtpSearchAttendance.Name = "dtpSearchAttendance";
            this.dtpSearchAttendance.Size = new System.Drawing.Size(198, 23);
            this.dtpSearchAttendance.TabIndex = 81;
            this.dtpSearchAttendance.ValueChanged += new System.EventHandler(this.dtpSearchAttendance_ValueChanged);
            // 
            // btnDemoAttendance
            // 
            this.btnDemoAttendance.BackColor = System.Drawing.Color.Yellow;
            this.btnDemoAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemoAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnDemoAttendance.Location = new System.Drawing.Point(11, 442);
            this.btnDemoAttendance.Name = "btnDemoAttendance";
            this.btnDemoAttendance.Size = new System.Drawing.Size(62, 29);
            this.btnDemoAttendance.TabIndex = 76;
            this.btnDemoAttendance.Text = "Demo";
            this.btnDemoAttendance.UseVisualStyleBackColor = false;
            this.btnDemoAttendance.Click += new System.EventHandler(this.btnDemoAttendance_Click);
            // 
            // AbsentRbtn
            // 
            this.AbsentRbtn.AutoSize = true;
            this.AbsentRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsentRbtn.Location = new System.Drawing.Point(310, 215);
            this.AbsentRbtn.Name = "AbsentRbtn";
            this.AbsentRbtn.Size = new System.Drawing.Size(68, 19);
            this.AbsentRbtn.TabIndex = 75;
            this.AbsentRbtn.TabStop = true;
            this.AbsentRbtn.Text = "Absent";
            this.AbsentRbtn.UseVisualStyleBackColor = true;
            // 
            // PresentRbtn
            // 
            this.PresentRbtn.AutoSize = true;
            this.PresentRbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PresentRbtn.Location = new System.Drawing.Point(203, 215);
            this.PresentRbtn.Name = "PresentRbtn";
            this.PresentRbtn.Size = new System.Drawing.Size(74, 19);
            this.PresentRbtn.TabIndex = 74;
            this.PresentRbtn.TabStop = true;
            this.PresentRbtn.Text = "Present";
            this.PresentRbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 64;
            this.label3.Text = "Employee Code";
            // 
            // txtEmpCodeAttendance
            // 
            this.txtEmpCodeAttendance.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpCodeAttendance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpCodeAttendance.Location = new System.Drawing.Point(203, 46);
            this.txtEmpCodeAttendance.Multiline = true;
            this.txtEmpCodeAttendance.Name = "txtEmpCodeAttendance";
            this.txtEmpCodeAttendance.Size = new System.Drawing.Size(203, 39);
            this.txtEmpCodeAttendance.TabIndex = 63;
            this.txtEmpCodeAttendance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpCodeAttendance_KeyPress);
            // 
            // btnPrintAttendance
            // 
            this.btnPrintAttendance.BackColor = System.Drawing.Color.Yellow;
            this.btnPrintAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnPrintAttendance.Location = new System.Drawing.Point(94, 360);
            this.btnPrintAttendance.Name = "btnPrintAttendance";
            this.btnPrintAttendance.Size = new System.Drawing.Size(251, 48);
            this.btnPrintAttendance.TabIndex = 13;
            this.btnPrintAttendance.Text = "Print";
            this.btnPrintAttendance.UseVisualStyleBackColor = false;
            this.btnPrintAttendance.Click += new System.EventHandler(this.btnPrintAttendance_Click);
            // 
            // btnCancelAttendance
            // 
            this.btnCancelAttendance.BackColor = System.Drawing.Color.Yellow;
            this.btnCancelAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnCancelAttendance.Location = new System.Drawing.Point(292, 295);
            this.btnCancelAttendance.Name = "btnCancelAttendance";
            this.btnCancelAttendance.Size = new System.Drawing.Size(91, 48);
            this.btnCancelAttendance.TabIndex = 12;
            this.btnCancelAttendance.Text = "Cancel";
            this.btnCancelAttendance.UseVisualStyleBackColor = false;
            this.btnCancelAttendance.Click += new System.EventHandler(this.btnCancelAttendance_Click);
            // 
            // btnDeleteAttendance
            // 
            this.btnDeleteAttendance.BackColor = System.Drawing.Color.Yellow;
            this.btnDeleteAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteAttendance.Location = new System.Drawing.Point(173, 295);
            this.btnDeleteAttendance.Name = "btnDeleteAttendance";
            this.btnDeleteAttendance.Size = new System.Drawing.Size(91, 48);
            this.btnDeleteAttendance.TabIndex = 11;
            this.btnDeleteAttendance.Text = "Delete";
            this.btnDeleteAttendance.UseVisualStyleBackColor = false;
            this.btnDeleteAttendance.Click += new System.EventHandler(this.btnDeleteAttendance_Click);
            // 
            // btnSaveAttendance
            // 
            this.btnSaveAttendance.BackColor = System.Drawing.Color.Yellow;
            this.btnSaveAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAttendance.ForeColor = System.Drawing.Color.Black;
            this.btnSaveAttendance.Location = new System.Drawing.Point(51, 295);
            this.btnSaveAttendance.Name = "btnSaveAttendance";
            this.btnSaveAttendance.Size = new System.Drawing.Size(91, 48);
            this.btnSaveAttendance.TabIndex = 10;
            this.btnSaveAttendance.Text = "Save";
            this.btnSaveAttendance.UseVisualStyleBackColor = false;
            this.btnSaveAttendance.Click += new System.EventHandler(this.btnSaveAttendance_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 206);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label6.Size = new System.Drawing.Size(66, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 143);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label5.Size = new System.Drawing.Size(192, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Employee Designation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 91);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.label4.Size = new System.Drawing.Size(145, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Name";
            // 
            // txtEmpDesiAttendance
            // 
            this.txtEmpDesiAttendance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpDesiAttendance.Location = new System.Drawing.Point(203, 145);
            this.txtEmpDesiAttendance.Multiline = true;
            this.txtEmpDesiAttendance.Name = "txtEmpDesiAttendance";
            this.txtEmpDesiAttendance.Size = new System.Drawing.Size(203, 43);
            this.txtEmpDesiAttendance.TabIndex = 3;
            this.txtEmpDesiAttendance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpDesiAttendance_KeyPress);
            // 
            // txtEmpNameAttendance
            // 
            this.txtEmpNameAttendance.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpNameAttendance.Location = new System.Drawing.Point(203, 91);
            this.txtEmpNameAttendance.Multiline = true;
            this.txtEmpNameAttendance.Name = "txtEmpNameAttendance";
            this.txtEmpNameAttendance.Size = new System.Drawing.Size(203, 39);
            this.txtEmpNameAttendance.TabIndex = 2;
            this.txtEmpNameAttendance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpNameAttendance_KeyPress);
            // 
            // dgvEmpAttendance
            // 
            this.dgvEmpAttendance.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvEmpAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttendanceID,
            this.EmployeeCode,
            this.EmployeeName,
            this.EmpDesignation,
            this.AttendStatus,
            this.AttendDate});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmpAttendance.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmpAttendance.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgvEmpAttendance.Location = new System.Drawing.Point(419, 46);
            this.dgvEmpAttendance.Name = "dgvEmpAttendance";
            this.dgvEmpAttendance.ReadOnly = true;
            this.dgvEmpAttendance.RowHeadersVisible = false;
            this.dgvEmpAttendance.RowHeadersWidth = 51;
            this.dgvEmpAttendance.Size = new System.Drawing.Size(606, 425);
            this.dgvEmpAttendance.TabIndex = 0;
            this.dgvEmpAttendance.DoubleClick += new System.EventHandler(this.dgvEmpAttendance_DoubleClick);
            // 
            // AttendanceID
            // 
            this.AttendanceID.DataPropertyName = "ATTENDID";
            this.AttendanceID.HeaderText = "AttendanceID";
            this.AttendanceID.MinimumWidth = 6;
            this.AttendanceID.Name = "AttendanceID";
            this.AttendanceID.ReadOnly = true;
            this.AttendanceID.Visible = false;
            this.AttendanceID.Width = 125;
            // 
            // EmployeeCode
            // 
            this.EmployeeCode.DataPropertyName = "EMPCODE";
            this.EmployeeCode.HeaderText = "Emp Code";
            this.EmployeeCode.MinimumWidth = 6;
            this.EmployeeCode.Name = "EmployeeCode";
            this.EmployeeCode.ReadOnly = true;
            this.EmployeeCode.Width = 125;
            // 
            // EmployeeName
            // 
            this.EmployeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmployeeName.DataPropertyName = "EMPNAME";
            this.EmployeeName.HeaderText = "Employee Name";
            this.EmployeeName.MinimumWidth = 6;
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // EmpDesignation
            // 
            this.EmpDesignation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EmpDesignation.DataPropertyName = "DESIGNATION";
            this.EmpDesignation.HeaderText = "Designation";
            this.EmpDesignation.MinimumWidth = 6;
            this.EmpDesignation.Name = "EmpDesignation";
            this.EmpDesignation.ReadOnly = true;
            // 
            // AttendStatus
            // 
            this.AttendStatus.DataPropertyName = "STATUS";
            this.AttendStatus.HeaderText = "Status";
            this.AttendStatus.MinimumWidth = 6;
            this.AttendStatus.Name = "AttendStatus";
            this.AttendStatus.ReadOnly = true;
            this.AttendStatus.Width = 125;
            // 
            // AttendDate
            // 
            this.AttendDate.DataPropertyName = "DATE";
            this.AttendDate.HeaderText = "Date";
            this.AttendDate.MinimumWidth = 6;
            this.AttendDate.Name = "AttendDate";
            this.AttendDate.ReadOnly = true;
            this.AttendDate.Width = 125;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(-2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1114, 37);
            this.label2.TabIndex = 61;
            this.label2.Text = "EMPLOYEE ATTENDANCE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel2.Controls.Add(this.EAempPB);
            this.panel2.Controls.Add(this.pictureBox9);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(-2, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 610);
            this.panel2.TabIndex = 69;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 549);
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
            this.pictureBox3.Location = new System.Drawing.Point(11, 328);
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
            this.pictureBox4.Location = new System.Drawing.Point(11, 394);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.MaximumSize = new System.Drawing.Size(36, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(36, 41);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 469);
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
            this.pictureBox6.Location = new System.Drawing.Point(11, 248);
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
            this.pictureBox7.Location = new System.Drawing.Point(9, 111);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox7.MaximumSize = new System.Drawing.Size(36, 41);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(36, 41);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // EAempPB
            // 
            this.EAempPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EAempPB.Image = ((System.Drawing.Image)(resources.GetObject("EAempPB.Image")));
            this.EAempPB.Location = new System.Drawing.Point(9, 44);
            this.EAempPB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EAempPB.MaximumSize = new System.Drawing.Size(36, 41);
            this.EAempPB.Name = "EAempPB";
            this.EAempPB.Size = new System.Drawing.Size(36, 41);
            this.EAempPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EAempPB.TabIndex = 4;
            this.EAempPB.TabStop = false;
            this.EAempPB.DoubleClick += new System.EventHandler(this.EAempPB_DoubleClick);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(11, 182);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox9.MaximumSize = new System.Drawing.Size(36, 41);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(36, 41);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 3;
            this.pictureBox9.TabStop = false;
            // 
            // backArrowEA
            // 
            this.backArrowEA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backArrowEA.BackColor = System.Drawing.Color.Maroon;
            this.backArrowEA.Image = ((System.Drawing.Image)(resources.GetObject("backArrowEA.Image")));
            this.backArrowEA.Location = new System.Drawing.Point(13, 6);
            this.backArrowEA.Name = "backArrowEA";
            this.backArrowEA.Size = new System.Drawing.Size(30, 23);
            this.backArrowEA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backArrowEA.TabIndex = 71;
            this.backArrowEA.TabStop = false;
            this.backArrowEA.Click += new System.EventHandler(this.backArrowEA_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // EmployeeAttendancePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1111, 639);
            this.Controls.Add(this.backArrowEA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.Name = "EmployeeAttendancePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeAttendancePage";
            this.Load += new System.EventHandler(this.EmployeeAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpAttendance)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EAempPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backArrowEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchAttendance;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpCodeAttendance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelAttendance;
        private System.Windows.Forms.Button btnDeleteAttendance;
        private System.Windows.Forms.Button btnSaveAttendance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpDesiAttendance;
        private System.Windows.Forms.TextBox txtEmpNameAttendance;
        private System.Windows.Forms.DataGridView dgvEmpAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendanceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmpDesignation;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttendDate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox EAempPB;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox backArrowEA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RadioButton AbsentRbtn;
        private System.Windows.Forms.RadioButton PresentRbtn;
        private System.Windows.Forms.Button btnPrintAttendance;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnDemoAttendance;
        private System.Windows.Forms.DateTimePicker dtpSearchAttendance;
    }
}
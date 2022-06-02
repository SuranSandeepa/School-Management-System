
namespace Obadaella_Vidyalaya
{
    partial class TTReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTReport));
            this.button1 = new System.Windows.Forms.Button();
            this.dgvR = new System.Windows.Forms.DataGridView();
            this.CidPeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearchReport = new System.Windows.Forms.Button();
            this.textSearchReport = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvR)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(700, 704);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back to Main Page";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvR
            // 
            this.dgvR.AllowUserToDeleteRows = false;
            this.dgvR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvR.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvR.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvR.ColumnHeadersHeight = 40;
            this.dgvR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CidPeriod,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.CountP});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSlateGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvR.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvR.GridColor = System.Drawing.Color.DarkGray;
            this.dgvR.Location = new System.Drawing.Point(-1, 774);
            this.dgvR.Margin = new System.Windows.Forms.Padding(8);
            this.dgvR.Name = "dgvR";
            this.dgvR.ReadOnly = true;
            this.dgvR.RowHeadersWidth = 51;
            this.dgvR.RowTemplate.Height = 24;
            this.dgvR.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvR.Size = new System.Drawing.Size(10, 10);
            this.dgvR.TabIndex = 38;
            this.dgvR.Visible = false;
            // 
            // CidPeriod
            // 
            this.CidPeriod.DataPropertyName = "CidPeriod";
            this.CidPeriod.HeaderText = "CidPeriod";
            this.CidPeriod.MinimumWidth = 6;
            this.CidPeriod.Name = "CidPeriod";
            this.CidPeriod.ReadOnly = true;
            this.CidPeriod.Visible = false;
            // 
            // Monday
            // 
            this.Monday.DataPropertyName = "Monday";
            this.Monday.HeaderText = "Monday";
            this.Monday.MinimumWidth = 6;
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            // 
            // Tuesday
            // 
            this.Tuesday.DataPropertyName = "Tuesday";
            this.Tuesday.HeaderText = "Tuesday";
            this.Tuesday.MinimumWidth = 6;
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            // 
            // Wednesday
            // 
            this.Wednesday.DataPropertyName = "Wednesday";
            this.Wednesday.HeaderText = "Wednesday";
            this.Wednesday.MinimumWidth = 6;
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            // 
            // Thursday
            // 
            this.Thursday.DataPropertyName = "Thursday";
            this.Thursday.HeaderText = "Thursday";
            this.Thursday.MinimumWidth = 6;
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            // 
            // Friday
            // 
            this.Friday.DataPropertyName = "Friday";
            this.Friday.HeaderText = "Friday";
            this.Friday.MinimumWidth = 6;
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            // 
            // CountP
            // 
            this.CountP.DataPropertyName = "CountP";
            this.CountP.HeaderText = "Count";
            this.CountP.MinimumWidth = 6;
            this.CountP.Name = "CountP";
            this.CountP.ReadOnly = true;
            this.CountP.Visible = false;
            // 
            // buttonSearchReport
            // 
            this.buttonSearchReport.BackColor = System.Drawing.Color.Yellow;
            this.buttonSearchReport.ForeColor = System.Drawing.Color.Black;
            this.buttonSearchReport.Location = new System.Drawing.Point(20, 774);
            this.buttonSearchReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchReport.Name = "buttonSearchReport";
            this.buttonSearchReport.Size = new System.Drawing.Size(10, 10);
            this.buttonSearchReport.TabIndex = 56;
            this.buttonSearchReport.Text = "Search";
            this.buttonSearchReport.UseVisualStyleBackColor = false;
            this.buttonSearchReport.Visible = false;
            this.buttonSearchReport.Click += new System.EventHandler(this.buttonSearchReport_Click);
            // 
            // textSearchReport
            // 
            this.textSearchReport.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textSearchReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearchReport.Location = new System.Drawing.Point(9, 758);
            this.textSearchReport.Name = "textSearchReport";
            this.textSearchReport.Size = new System.Drawing.Size(10, 26);
            this.textSearchReport.TabIndex = 57;
            this.textSearchReport.Visible = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-1, 259);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ShowCloseButton = false;
            this.crystalReportViewer1.ShowCopyButton = false;
            this.crystalReportViewer1.ShowGotoPageButton = false;
            this.crystalReportViewer1.ShowGroupTreeButton = false;
            this.crystalReportViewer1.ShowLogo = false;
            this.crystalReportViewer1.ShowPageNavigateButtons = false;
            this.crystalReportViewer1.ShowParameterPanelButton = false;
            this.crystalReportViewer1.ShowTextSearchButton = false;
            this.crystalReportViewer1.ShowZoomButton = false;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1481, 413);
            this.crystalReportViewer1.TabIndex = 58;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(1487, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1487, 180);
            this.panel1.TabIndex = 59;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(681, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.MaximumSize = new System.Drawing.Size(121, 110);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(461, 126);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "ඹ්බඩඇල්ල විද්‍යාලය , බණ්ඩාරවෙල";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(681, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(121, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(1, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 357);
            this.panel2.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(113, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1373, 77);
            this.panel3.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(636, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 44);
            this.label2.TabIndex = 63;
            this.label2.Text = "CN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Location = new System.Drawing.Point(1270, 294);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 357);
            this.panel4.TabIndex = 61;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(-1, 624);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1487, 66);
            this.panel5.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Maroon;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(566, 199);
            this.label3.MaximumSize = new System.Drawing.Size(611, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 46);
            this.label3.TabIndex = 63;
            this.label3.Text = "TIMETABLE MANAGEMENT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1480, 783);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.textSearchReport);
            this.Controls.Add(this.buttonSearchReport);
            this.Controls.Add(this.dgvR);
            this.Name = "TTReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvR)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvR;
        private System.Windows.Forms.DataGridViewTextBoxColumn CidPeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountP;
        private System.Windows.Forms.Button buttonSearchReport;
        public System.Windows.Forms.TextBox textSearchReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
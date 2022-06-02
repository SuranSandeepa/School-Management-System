
namespace Obadaella_Vidyalaya
{
    partial class StudentPaymentReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentPaymentReports));
            this.dgvSPR = new System.Windows.Forms.DataGridView();
            this.btnSPR = new System.Windows.Forms.Button();
            this.txtSPR = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPR)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSPR
            // 
            this.dgvSPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPR.Location = new System.Drawing.Point(1052, 12);
            this.dgvSPR.Name = "dgvSPR";
            this.dgvSPR.Size = new System.Drawing.Size(8, 8);
            this.dgvSPR.TabIndex = 0;
            this.dgvSPR.Visible = false;
            // 
            // btnSPR
            // 
            this.btnSPR.Location = new System.Drawing.Point(1080, 12);
            this.btnSPR.Name = "btnSPR";
            this.btnSPR.Size = new System.Drawing.Size(10, 10);
            this.btnSPR.TabIndex = 1;
            this.btnSPR.Text = "button1";
            this.btnSPR.UseVisualStyleBackColor = true;
            this.btnSPR.Visible = false;
            this.btnSPR.Click += new System.EventHandler(this.btnSPR_Click);
            // 
            // txtSPR
            // 
            this.txtSPR.Location = new System.Drawing.Point(1066, 12);
            this.txtSPR.Name = "txtSPR";
            this.txtSPR.Size = new System.Drawing.Size(8, 20);
            this.txtSPR.TabIndex = 2;
            this.txtSPR.Visible = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 110);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1114, 529);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox19);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.MaximumSize = new System.Drawing.Size(1115, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1115, 112);
            this.panel3.TabIndex = 68;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 19);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StudentPaymentReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 639);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtSPR);
            this.Controls.Add(this.btnSPR);
            this.Controls.Add(this.dgvSPR);
            this.Name = "StudentPaymentReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentPaymentReports";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPR)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSPR;
        private System.Windows.Forms.Button btnSPR;
        private System.Windows.Forms.TextBox txtSPR;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
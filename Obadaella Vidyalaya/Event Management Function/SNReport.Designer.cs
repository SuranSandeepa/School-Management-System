
namespace Obadaella_Vidyalaya
{
    partial class SNReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SNReport));
            this.SNReportdgv = new System.Windows.Forms.DataGridView();
            this.btnSN = new System.Windows.Forms.Button();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SNReportdgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SNReportdgv
            // 
            this.SNReportdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SNReportdgv.Location = new System.Drawing.Point(1459, 12);
            this.SNReportdgv.Name = "SNReportdgv";
            this.SNReportdgv.RowHeadersWidth = 51;
            this.SNReportdgv.RowTemplate.Height = 24;
            this.SNReportdgv.Size = new System.Drawing.Size(10, 10);
            this.SNReportdgv.TabIndex = 0;
            this.SNReportdgv.Visible = false;
            // 
            // btnSN
            // 
            this.btnSN.Location = new System.Drawing.Point(1459, 39);
            this.btnSN.Name = "btnSN";
            this.btnSN.Size = new System.Drawing.Size(10, 10);
            this.btnSN.TabIndex = 1;
            this.btnSN.Text = "button1";
            this.btnSN.UseVisualStyleBackColor = true;
            this.btnSN.Visible = false;
            this.btnSN.Click += new System.EventHandler(this.btnSN_Click);
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(1459, 55);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(10, 22);
            this.txtSN.TabIndex = 2;
            this.txtSN.WordWrap = false;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 151);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1480, 627);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1478, 150);
            this.panel2.TabIndex = 17;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(439, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 46);
            this.label1.TabIndex = 1;
            this.label1.Tag = "";
            this.label1.Text = "ඕබඩඇල්ල විද්‍යාලය, බණ්ඩාරවෙල";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(681, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(109, 88);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 23);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SNReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 786);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.btnSN);
            this.Controls.Add(this.SNReportdgv);
            this.Name = "SNReport";
            this.Text = "SNReport";
            this.Load += new System.EventHandler(this.SNReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SNReportdgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SNReportdgv;
        private System.Windows.Forms.Button btnSN;
        private System.Windows.Forms.TextBox txtSN;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
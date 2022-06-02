
namespace Obadaella_Vidyalaya
{
    partial class EventCreateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventCreateReport));
            this.ECreportdgv = new System.Windows.Forms.DataGridView();
            this.txtECR = new System.Windows.Forms.TextBox();
            this.btnECR = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ECreportdgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // ECreportdgv
            // 
            this.ECreportdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ECreportdgv.Location = new System.Drawing.Point(1459, 12);
            this.ECreportdgv.Name = "ECreportdgv";
            this.ECreportdgv.RowHeadersWidth = 51;
            this.ECreportdgv.RowTemplate.Height = 24;
            this.ECreportdgv.Size = new System.Drawing.Size(10, 10);
            this.ECreportdgv.TabIndex = 0;
            this.ECreportdgv.Visible = false;
            // 
            // txtECR
            // 
            this.txtECR.Location = new System.Drawing.Point(1459, 46);
            this.txtECR.Name = "txtECR";
            this.txtECR.Size = new System.Drawing.Size(10, 22);
            this.txtECR.TabIndex = 1;
            this.txtECR.Visible = false;
            // 
            // btnECR
            // 
            this.btnECR.Location = new System.Drawing.Point(1459, 74);
            this.btnECR.Name = "btnECR";
            this.btnECR.Size = new System.Drawing.Size(10, 10);
            this.btnECR.TabIndex = 2;
            this.btnECR.Text = "button1";
            this.btnECR.UseVisualStyleBackColor = true;
            this.btnECR.Visible = false;
            this.btnECR.Click += new System.EventHandler(this.btnECR_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 148);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1482, 635);
            this.crystalReportViewer1.TabIndex = 3;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox10);
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1478, 150);
            this.panel2.TabIndex = 18;
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
            // 
            // EventCreateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 786);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnECR);
            this.Controls.Add(this.txtECR);
            this.Controls.Add(this.ECreportdgv);
            this.Name = "EventCreateReport";
            this.Text = "EventCreateReport";
            ((System.ComponentModel.ISupportInitialize)(this.ECreportdgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ECreportdgv;
        private System.Windows.Forms.TextBox txtECR;
        private System.Windows.Forms.Button btnECR;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}
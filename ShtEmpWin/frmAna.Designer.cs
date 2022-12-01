
namespace ShtEmpWin
{
    partial class frmAna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblKasa = new System.Windows.Forms.Label();
            this.btnMusteri = new System.Windows.Forms.Button();
            this.lblAnlikInsan = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblOda3AnlikNumune = new System.Windows.Forms.Label();
            this.lblOda3Musaitlik = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOda2AnlikNumune = new System.Windows.Forms.Label();
            this.lblOda2Musaitlik = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOda1AnlikNumune = new System.Windows.Forms.Label();
            this.lblOda1Musaitlik = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.lblStatus);
            this.pnlMain.Controls.Add(this.lblKasa);
            this.pnlMain.Controls.Add(this.btnMusteri);
            this.pnlMain.Controls.Add(this.lblAnlikInsan);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(456, 378);
            this.pnlMain.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(239, 349);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 15);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Durum";
            // 
            // lblKasa
            // 
            this.lblKasa.AutoSize = true;
            this.lblKasa.Location = new System.Drawing.Point(358, 4);
            this.lblKasa.Name = "lblKasa";
            this.lblKasa.Size = new System.Drawing.Size(31, 15);
            this.lblKasa.TabIndex = 5;
            this.lblKasa.Text = "Kasa";
            // 
            // btnMusteri
            // 
            this.btnMusteri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMusteri.Location = new System.Drawing.Point(23, 341);
            this.btnMusteri.Name = "btnMusteri";
            this.btnMusteri.Size = new System.Drawing.Size(75, 23);
            this.btnMusteri.TabIndex = 4;
            this.btnMusteri.Text = "Yeni Musteri";
            this.btnMusteri.UseVisualStyleBackColor = true;
            this.btnMusteri.Click += new System.EventHandler(this.btnMusteri_Click);
            // 
            // lblAnlikInsan
            // 
            this.lblAnlikInsan.AutoSize = true;
            this.lblAnlikInsan.Location = new System.Drawing.Point(4, 4);
            this.lblAnlikInsan.Name = "lblAnlikInsan";
            this.lblAnlikInsan.Size = new System.Drawing.Size(65, 15);
            this.lblAnlikInsan.TabIndex = 3;
            this.lblAnlikInsan.Text = "Anlık İnsan";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.lblOda3AnlikNumune);
            this.panel3.Controls.Add(this.lblOda3Musaitlik);
            this.panel3.Location = new System.Drawing.Point(271, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 108);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDoubleClick);
            // 
            // lblOda3AnlikNumune
            // 
            this.lblOda3AnlikNumune.AutoSize = true;
            this.lblOda3AnlikNumune.Location = new System.Drawing.Point(3, 35);
            this.lblOda3AnlikNumune.Name = "lblOda3AnlikNumune";
            this.lblOda3AnlikNumune.Size = new System.Drawing.Size(58, 15);
            this.lblOda3AnlikNumune.TabIndex = 2;
            this.lblOda3AnlikNumune.Text = "An. Num.";
            // 
            // lblOda3Musaitlik
            // 
            this.lblOda3Musaitlik.AutoSize = true;
            this.lblOda3Musaitlik.Location = new System.Drawing.Point(3, 11);
            this.lblOda3Musaitlik.Name = "lblOda3Musaitlik";
            this.lblOda3Musaitlik.Size = new System.Drawing.Size(43, 15);
            this.lblOda3Musaitlik.TabIndex = 1;
            this.lblOda3Musaitlik.Text = "Müsait";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.lblOda2AnlikNumune);
            this.panel2.Controls.Add(this.lblOda2Musaitlik);
            this.panel2.Location = new System.Drawing.Point(149, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 108);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDoubleClick);
            // 
            // lblOda2AnlikNumune
            // 
            this.lblOda2AnlikNumune.AutoSize = true;
            this.lblOda2AnlikNumune.Location = new System.Drawing.Point(3, 35);
            this.lblOda2AnlikNumune.Name = "lblOda2AnlikNumune";
            this.lblOda2AnlikNumune.Size = new System.Drawing.Size(58, 15);
            this.lblOda2AnlikNumune.TabIndex = 2;
            this.lblOda2AnlikNumune.Text = "An. Num.";
            // 
            // lblOda2Musaitlik
            // 
            this.lblOda2Musaitlik.AutoSize = true;
            this.lblOda2Musaitlik.Location = new System.Drawing.Point(0, 11);
            this.lblOda2Musaitlik.Name = "lblOda2Musaitlik";
            this.lblOda2Musaitlik.Size = new System.Drawing.Size(43, 15);
            this.lblOda2Musaitlik.TabIndex = 1;
            this.lblOda2Musaitlik.Text = "Müsait";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblOda1AnlikNumune);
            this.panel1.Controls.Add(this.lblOda1Musaitlik);
            this.panel1.Location = new System.Drawing.Point(23, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 108);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDoubleClick);
            // 
            // lblOda1AnlikNumune
            // 
            this.lblOda1AnlikNumune.AutoSize = true;
            this.lblOda1AnlikNumune.Location = new System.Drawing.Point(3, 35);
            this.lblOda1AnlikNumune.Name = "lblOda1AnlikNumune";
            this.lblOda1AnlikNumune.Size = new System.Drawing.Size(58, 15);
            this.lblOda1AnlikNumune.TabIndex = 1;
            this.lblOda1AnlikNumune.Text = "An. Num.";
            // 
            // lblOda1Musaitlik
            // 
            this.lblOda1Musaitlik.AutoSize = true;
            this.lblOda1Musaitlik.Location = new System.Drawing.Point(3, 11);
            this.lblOda1Musaitlik.Name = "lblOda1Musaitlik";
            this.lblOda1Musaitlik.Size = new System.Drawing.Size(43, 15);
            this.lblOda1Musaitlik.TabIndex = 0;
            this.lblOda1Musaitlik.Text = "Müsait";
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 402);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmAna";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAna_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAna_FormClosed);
            this.Load += new System.EventHandler(this.frmAna_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblOda3Musaitlik;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOda2Musaitlik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblOda1Musaitlik;
        private System.Windows.Forms.Label lblAnlikInsan;
        private System.Windows.Forms.Button btnMusteri;
        private System.Windows.Forms.Label lblOda3AnlikNumune;
        private System.Windows.Forms.Label lblOda2AnlikNumune;
        private System.Windows.Forms.Label lblOda1AnlikNumune;
        private System.Windows.Forms.Label lblKasa;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button button1;
    }
}


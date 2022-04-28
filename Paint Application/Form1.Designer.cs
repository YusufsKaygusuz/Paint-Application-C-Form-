
namespace Paint_Application
{
    partial class Form1
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
            this.KırmızıLabel = new System.Windows.Forms.Label();
            this.SarıLabel = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.SiyahLabel = new System.Windows.Forms.Label();
            this.MaviLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SilgiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KırmızıLabel
            // 
            this.KırmızıLabel.AutoSize = true;
            this.KırmızıLabel.BackColor = System.Drawing.Color.Red;
            this.KırmızıLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.KırmızıLabel.Location = new System.Drawing.Point(81, 28);
            this.KırmızıLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.KırmızıLabel.Name = "KırmızıLabel";
            this.KırmızıLabel.Size = new System.Drawing.Size(86, 29);
            this.KırmızıLabel.TabIndex = 0;
            this.KırmızıLabel.Text = "Kırmızı";
            this.KırmızıLabel.Click += new System.EventHandler(this.LabelBasildi);
            // 
            // SarıLabel
            // 
            this.SarıLabel.AutoSize = true;
            this.SarıLabel.BackColor = System.Drawing.Color.Gold;
            this.SarıLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SarıLabel.Location = new System.Drawing.Point(182, 87);
            this.SarıLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SarıLabel.Name = "SarıLabel";
            this.SarıLabel.Size = new System.Drawing.Size(56, 29);
            this.SarıLabel.TabIndex = 1;
            this.SarıLabel.Text = "Sarı";
            this.SarıLabel.Click += new System.EventHandler(this.LabelBasildi);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(273, 12);
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(210, 56);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 4;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // SiyahLabel
            // 
            this.SiyahLabel.AutoSize = true;
            this.SiyahLabel.BackColor = System.Drawing.Color.Black;
            this.SiyahLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SiyahLabel.Location = new System.Drawing.Point(182, 28);
            this.SiyahLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SiyahLabel.Name = "SiyahLabel";
            this.SiyahLabel.Size = new System.Drawing.Size(72, 29);
            this.SiyahLabel.TabIndex = 3;
            this.SiyahLabel.Text = "Siyah";
            this.SiyahLabel.Click += new System.EventHandler(this.LabelBasildi);
            // 
            // MaviLabel
            // 
            this.MaviLabel.AutoSize = true;
            this.MaviLabel.BackColor = System.Drawing.Color.Blue;
            this.MaviLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaviLabel.Location = new System.Drawing.Point(81, 87);
            this.MaviLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MaviLabel.Name = "MaviLabel";
            this.MaviLabel.Size = new System.Drawing.Size(63, 29);
            this.MaviLabel.TabIndex = 4;
            this.MaviLabel.Text = "Mavi";
            this.MaviLabel.Click += new System.EventHandler(this.LabelBasildi);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(20, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 253);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(43, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 303);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çizim Alanı";
            // 
            // SilgiLabel
            // 
            this.SilgiLabel.AutoSize = true;
            this.SilgiLabel.BackColor = System.Drawing.Color.White;
            this.SilgiLabel.ForeColor = System.Drawing.Color.Black;
            this.SilgiLabel.Location = new System.Drawing.Point(556, 115);
            this.SilgiLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.SilgiLabel.Name = "SilgiLabel";
            this.SilgiLabel.Size = new System.Drawing.Size(61, 29);
            this.SilgiLabel.TabIndex = 7;
            this.SilgiLabel.Text = "Silgi";
            this.SilgiLabel.Click += new System.EventHandler(this.LabelBasildi);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 507);
            this.Controls.Add(this.SilgiLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.MaviLabel);
            this.Controls.Add(this.SiyahLabel);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.SarıLabel);
            this.Controls.Add(this.KırmızıLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KırmızıLabel;
        private System.Windows.Forms.Label SarıLabel;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label SiyahLabel;
        private System.Windows.Forms.Label MaviLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SilgiLabel;
    }
}


namespace UInvcapcao
{
    partial class frmGiaoDienBanVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDienBanVe));
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.directorySearcher2 = new System.DirectoryServices.DirectorySearcher();
            this.btnclose = new System.Windows.Forms.Button();
            this.ptbP4 = new System.Windows.Forms.PictureBox();
            this.ptbP5 = new System.Windows.Forms.PictureBox();
            this.ptbP6 = new System.Windows.Forms.PictureBox();
            this.ptbP3 = new System.Windows.Forms.PictureBox();
            this.ptbP2 = new System.Windows.Forms.PictureBox();
            this.ptbP1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // directorySearcher2
            // 
            this.directorySearcher2.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher2.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Firebrick;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(11, 496);
            this.btnclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(94, 54);
            this.btnclose.TabIndex = 1;
            this.btnclose.Text = "Exit";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // ptbP4
            // 
            this.ptbP4.Image = global::UInvcapcao.Properties.Resources.fastandfurious;
            this.ptbP4.Location = new System.Drawing.Point(260, 280);
            this.ptbP4.Margin = new System.Windows.Forms.Padding(2);
            this.ptbP4.Name = "ptbP4";
            this.ptbP4.Size = new System.Drawing.Size(107, 128);
            this.ptbP4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbP4.TabIndex = 2;
            this.ptbP4.TabStop = false;
            this.ptbP4.Tag = "P4";
            this.ptbP4.Click += new System.EventHandler(this.ptbP4_Click);
            // 
            // ptbP5
            // 
            this.ptbP5.Image = global::UInvcapcao.Properties.Resources.avengers;
            this.ptbP5.Location = new System.Drawing.Point(434, 280);
            this.ptbP5.Margin = new System.Windows.Forms.Padding(2);
            this.ptbP5.Name = "ptbP5";
            this.ptbP5.Size = new System.Drawing.Size(106, 128);
            this.ptbP5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbP5.TabIndex = 2;
            this.ptbP5.TabStop = false;
            this.ptbP5.Tag = "P5";
            this.ptbP5.Click += new System.EventHandler(this.ptbP5_Click);
            // 
            // ptbP6
            // 
            this.ptbP6.Image = global::UInvcapcao.Properties.Resources.YournamePoster;
            this.ptbP6.Location = new System.Drawing.Point(607, 280);
            this.ptbP6.Margin = new System.Windows.Forms.Padding(2);
            this.ptbP6.Name = "ptbP6";
            this.ptbP6.Size = new System.Drawing.Size(106, 128);
            this.ptbP6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbP6.TabIndex = 2;
            this.ptbP6.TabStop = false;
            this.ptbP6.Tag = "P6";
            this.ptbP6.Click += new System.EventHandler(this.ptbP6_Click);
            // 
            // ptbP3
            // 
            this.ptbP3.Image = global::UInvcapcao.Properties.Resources.shin;
            this.ptbP3.Location = new System.Drawing.Point(607, 115);
            this.ptbP3.Margin = new System.Windows.Forms.Padding(2);
            this.ptbP3.Name = "ptbP3";
            this.ptbP3.Size = new System.Drawing.Size(106, 128);
            this.ptbP3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbP3.TabIndex = 2;
            this.ptbP3.TabStop = false;
            this.ptbP3.Tag = "P3";
            this.ptbP3.Click += new System.EventHandler(this.ptbP3_Click);
            // 
            // ptbP2
            // 
            this.ptbP2.Image = global::UInvcapcao.Properties.Resources.conan;
            this.ptbP2.Location = new System.Drawing.Point(434, 115);
            this.ptbP2.Margin = new System.Windows.Forms.Padding(2);
            this.ptbP2.Name = "ptbP2";
            this.ptbP2.Size = new System.Drawing.Size(106, 128);
            this.ptbP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbP2.TabIndex = 2;
            this.ptbP2.TabStop = false;
            this.ptbP2.Tag = "P2";
            this.ptbP2.Click += new System.EventHandler(this.ptbP2_Click);
            // 
            // ptbP1
            // 
            this.ptbP1.Image = global::UInvcapcao.Properties.Resources.Baking_Bad;
            this.ptbP1.Location = new System.Drawing.Point(260, 115);
            this.ptbP1.Margin = new System.Windows.Forms.Padding(2);
            this.ptbP1.Name = "ptbP1";
            this.ptbP1.Size = new System.Drawing.Size(107, 128);
            this.ptbP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbP1.TabIndex = 2;
            this.ptbP1.TabStop = false;
            this.ptbP1.Tag = "P1";
            this.ptbP1.Click += new System.EventHandler(this.ptbP1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.pictureBox1.Image = global::UInvcapcao.Properties.Resources.logowithwords;
            this.pictureBox1.Location = new System.Drawing.Point(408, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmGiaoDienBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.ptbP4);
            this.Controls.Add(this.ptbP5);
            this.Controls.Add(this.ptbP6);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.ptbP3);
            this.Controls.Add(this.ptbP2);
            this.Controls.Add(this.ptbP1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGiaoDienBanVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Diện Bán Vé";
            ((System.ComponentModel.ISupportInitialize)(this.ptbP4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbP1;
        private System.Windows.Forms.PictureBox ptbP2;
        private System.Windows.Forms.PictureBox ptbP3;
        private System.Windows.Forms.PictureBox ptbP6;
        private System.Windows.Forms.PictureBox ptbP5;
        private System.Windows.Forms.PictureBox ptbP4;
        private System.Windows.Forms.Button btnclose;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.DirectoryServices.DirectorySearcher directorySearcher2;
    }
}
using System.Windows.Forms;

namespace UInvcapcao
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
            this.components = new System.ComponentModel.Container();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCosovatchat = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThongke = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlPhim = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.phimTimer = new System.Windows.Forms.Timer(this.components);
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.btnPhim = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.pnlPhim.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.pnlPhim);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(181, 439);
            this.sidebar.MinimumSize = new System.Drawing.Size(47, 439);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(181, 439);
            this.sidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 74);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.btnPhim);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 48);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCosovatchat);
            this.panel4.Location = new System.Drawing.Point(3, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 48);
            this.panel4.TabIndex = 1;
            // 
            // btnCosovatchat
            // 
            this.btnCosovatchat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCosovatchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCosovatchat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosovatchat.ForeColor = System.Drawing.Color.White;
            this.btnCosovatchat.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnCosovatchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCosovatchat.Location = new System.Drawing.Point(-12, -9);
            this.btnCosovatchat.Name = "btnCosovatchat";
            this.btnCosovatchat.Size = new System.Drawing.Size(198, 66);
            this.btnCosovatchat.TabIndex = 1;
            this.btnCosovatchat.Text = "             Cơ sở vật chất";
            this.btnCosovatchat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCosovatchat.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnNhanvien);
            this.panel5.Location = new System.Drawing.Point(3, 136);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 48);
            this.panel5.TabIndex = 1;
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnNhanvien.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(-12, -9);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(198, 66);
            this.btnNhanvien.TabIndex = 1;
            this.btnNhanvien.Text = "             Nhân viên";
            this.btnNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnThongke);
            this.panel6.Location = new System.Drawing.Point(3, 244);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 48);
            this.panel6.TabIndex = 1;
            // 
            // btnThongke
            // 
            this.btnThongke.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(-12, -9);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(198, 66);
            this.btnThongke.TabIndex = 1;
            this.btnThongke.Text = "             Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnExit);
            this.panel7.Location = new System.Drawing.Point(3, 298);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 48);
            this.panel7.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-12, -9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(198, 66);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "             Exit ";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pnlPhim
            // 
            this.pnlPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.pnlPhim.Controls.Add(this.panel3);
            this.pnlPhim.Controls.Add(this.panel11);
            this.pnlPhim.Controls.Add(this.panel10);
            this.pnlPhim.Controls.Add(this.panel9);
            this.pnlPhim.Location = new System.Drawing.Point(3, 83);
            this.pnlPhim.MaximumSize = new System.Drawing.Size(175, 169);
            this.pnlPhim.MinimumSize = new System.Drawing.Size(175, 47);
            this.pnlPhim.Name = "pnlPhim";
            this.pnlPhim.Size = new System.Drawing.Size(175, 47);
            this.pnlPhim.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel9.Controls.Add(this.button8);
            this.panel9.Location = new System.Drawing.Point(3, 54);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(175, 35);
            this.panel9.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel10.Controls.Add(this.button2);
            this.panel10.Location = new System.Drawing.Point(3, 95);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(175, 35);
            this.panel10.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel11.Controls.Add(this.button9);
            this.panel11.Location = new System.Drawing.Point(3, 136);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(175, 35);
            this.panel11.TabIndex = 1;
            // 
            // phimTimer
            // 
            this.phimTimer.Interval = 10;
            this.phimTimer.Tick += new System.EventHandler(this.phimTimer_Tick);
            // 
            // btnMenu
            // 
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = global::UInvcapcao.Properties.Resources.sidebar_button5;
            this.btnMenu.Location = new System.Drawing.Point(3, 20);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(34, 30);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnPhim
            // 
            this.btnPhim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhim.ForeColor = System.Drawing.Color.White;
            this.btnPhim.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhim.Location = new System.Drawing.Point(-15, -2);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnPhim.Size = new System.Drawing.Size(198, 66);
            this.btnPhim.TabIndex = 1;
            this.btnPhim.Text = "             Phim";
            this.btnPhim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhim.UseVisualStyleBackColor = true;
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Image = global::UInvcapcao.Properties.Resources.bullet_point_icon;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(-12, -24);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(198, 63);
            this.button9.TabIndex = 1;
            this.button9.Text = "             Đã chiếu";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::UInvcapcao.Properties.Resources.bullet_point_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-12, -25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(198, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "             Đang chiếu";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Image = global::UInvcapcao.Properties.Resources.bullet_point_icon;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(-12, -25);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(198, 63);
            this.button8.TabIndex = 1;
            this.button8.Text = "             Sắp chiếu";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 457);
            this.Controls.Add(this.sidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.pnlPhim.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private Panel panel3;
        private Button btnPhim;
        private Panel panel4;
        private Button btnCosovatchat;
        private Panel panel5;
        private Button btnNhanvien;
        private Panel panel6;
        private Button btnThongke;
        private Panel panel7;
        private Button btnExit;
        private PictureBox btnMenu;
        private Label label1;
        private Timer sidebarTimer;
        private Panel pnlPhim;
        private Panel panel9;
        private Button button8;
        private Panel panel11;
        private Button button9;
        private Panel panel10;
        private Button button2;
        private Timer phimTimer;
    }
}


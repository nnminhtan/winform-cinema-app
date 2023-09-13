using System.Windows.Forms;

namespace UInvcapcao
{
    partial class frmQuanLy
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
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pnlPhim = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnPhim = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCoSoVatChat = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pnlPhim.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.pnlPhim);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.MaximumSize = new System.Drawing.Size(181, 800);
            this.sidebar.MinimumSize = new System.Drawing.Size(47, 800);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(47, 800);
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
            this.label1.Size = new System.Drawing.Size(54, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = " Menu";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel3.Controls.Add(this.btnPhim);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 48);
            this.panel3.TabIndex = 1;
            // 
            // btnPhim
            // 
            this.btnPhim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhim.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhim.ForeColor = System.Drawing.Color.White;
            this.btnPhim.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhim.Location = new System.Drawing.Point(-26, -11);
            this.btnPhim.Name = "btnPhim";
            this.btnPhim.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnPhim.Size = new System.Drawing.Size(209, 75);
            this.btnPhim.TabIndex = 1;
            this.btnPhim.Text = "                Phim";
            this.btnPhim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhim.UseVisualStyleBackColor = true;
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
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel10.Controls.Add(this.button2);
            this.panel10.Location = new System.Drawing.Point(3, 95);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(175, 35);
            this.panel10.TabIndex = 1;
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
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel9.Controls.Add(this.button8);
            this.panel9.Location = new System.Drawing.Point(3, 54);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(175, 35);
            this.panel9.TabIndex = 1;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCoSoVatChat);
            this.panel4.Location = new System.Drawing.Point(3, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 48);
            this.panel4.TabIndex = 1;
            // 
            // btnCoSoVatChat
            // 
            this.btnCoSoVatChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCoSoVatChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoSoVatChat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoSoVatChat.ForeColor = System.Drawing.Color.White;
            this.btnCoSoVatChat.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnCoSoVatChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoSoVatChat.Location = new System.Drawing.Point(-23, -9);
            this.btnCoSoVatChat.Name = "btnCoSoVatChat";
            this.btnCoSoVatChat.Size = new System.Drawing.Size(209, 66);
            this.btnCoSoVatChat.TabIndex = 1;
            this.btnCoSoVatChat.Text = "                Cơ sở vật chất";
            this.btnCoSoVatChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoSoVatChat.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnNhanVien);
            this.panel5.Location = new System.Drawing.Point(3, 190);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 48);
            this.panel5.TabIndex = 1;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.Location = new System.Drawing.Point(-23, -9);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(209, 66);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "                Nhân viên";
            this.btnNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnThongKe);
            this.panel6.Location = new System.Drawing.Point(3, 244);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 48);
            this.panel6.TabIndex = 1;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.Location = new System.Drawing.Point(-23, -14);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(208, 75);
            this.btnThongKe.TabIndex = 1;
            this.btnThongKe.Text = "                Thống kê";
            this.btnThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongKe.UseVisualStyleBackColor = true;
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
            this.btnExit.Location = new System.Drawing.Point(-23, -13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(212, 74);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "                 Exit ";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.sidebar);
            this.Name = "frmQuanLy";
            this.Text = "Quản Lý";
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pnlPhim.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private Panel panel3;
        private Button btnPhim;
        private Panel panel4;
        private Button btnCoSoVatChat;
        private Panel panel5;
        private Button btnNhanVien;
        private Panel panel6;
        private Button btnThongKe;
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
 //       private Timer phimTimer;
    }
}


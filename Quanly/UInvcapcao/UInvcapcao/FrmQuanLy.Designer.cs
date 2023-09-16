﻿using System.Windows.Forms;

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
            this.pnlNhanVien = new System.Windows.Forms.Panel();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.btnCancelUpdate = new System.Windows.Forms.Button();
            this.btnConfirmUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaNVUpdate = new System.Windows.Forms.TextBox();
            this.txtMaRapUpdate = new System.Windows.Forms.TextBox();
            this.txtTenNVUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMKUpdate = new System.Windows.Forms.TextBox();
            this.txtLuongUpdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChucVuUpdate = new System.Windows.Forms.TextBox();
            this.pnlDel = new System.Windows.Forms.Panel();
            this.btnCancelDel = new System.Windows.Forms.Button();
            this.btnConfirmDel = new System.Windows.Forms.Button();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.pnlAddDetails = new System.Windows.Forms.Panel();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.txtMaRap = new System.Windows.Forms.TextBox();
            this.lblMaRap = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.btnShowList = new System.Windows.Forms.Button();
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
            this.pnlNhanVien.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlDel.SuspendLayout();
            this.pnlAddDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
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
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
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
            // pnlNhanVien
            // 
            this.pnlNhanVien.Controls.Add(this.pnlUpdate);
            this.pnlNhanVien.Controls.Add(this.pnlDel);
            this.pnlNhanVien.Controls.Add(this.pnlAddDetails);
            this.pnlNhanVien.Controls.Add(this.btnDelete);
            this.pnlNhanVien.Controls.Add(this.btnUpdate);
            this.pnlNhanVien.Controls.Add(this.btnAdd);
            this.pnlNhanVien.Controls.Add(this.dgvData);
            this.pnlNhanVien.Controls.Add(this.btnShowList);
            this.pnlNhanVien.Location = new System.Drawing.Point(65, 5);
            this.pnlNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNhanVien.Name = "pnlNhanVien";
            this.pnlNhanVien.Size = new System.Drawing.Size(908, 545);
            this.pnlNhanVien.TabIndex = 1;
            this.pnlNhanVien.Visible = false;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.btnCancelUpdate);
            this.pnlUpdate.Controls.Add(this.btnConfirmUpdate);
            this.pnlUpdate.Controls.Add(this.label3);
            this.pnlUpdate.Controls.Add(this.label2);
            this.pnlUpdate.Controls.Add(this.label7);
            this.pnlUpdate.Controls.Add(this.txtMaNVUpdate);
            this.pnlUpdate.Controls.Add(this.txtMaRapUpdate);
            this.pnlUpdate.Controls.Add(this.txtTenNVUpdate);
            this.pnlUpdate.Controls.Add(this.label6);
            this.pnlUpdate.Controls.Add(this.txtMKUpdate);
            this.pnlUpdate.Controls.Add(this.txtLuongUpdate);
            this.pnlUpdate.Controls.Add(this.label4);
            this.pnlUpdate.Controls.Add(this.label5);
            this.pnlUpdate.Controls.Add(this.txtChucVuUpdate);
            this.pnlUpdate.Location = new System.Drawing.Point(655, 148);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.Size = new System.Drawing.Size(250, 262);
            this.pnlUpdate.TabIndex = 4;
            this.pnlUpdate.Visible = false;
            // 
            // btnCancelUpdate
            // 
            this.btnCancelUpdate.Location = new System.Drawing.Point(135, 183);
            this.btnCancelUpdate.Name = "btnCancelUpdate";
            this.btnCancelUpdate.Size = new System.Drawing.Size(82, 21);
            this.btnCancelUpdate.TabIndex = 6;
            this.btnCancelUpdate.Text = "Cancel";
            this.btnCancelUpdate.UseVisualStyleBackColor = true;
            this.btnCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnConfirmUpdate
            // 
            this.btnConfirmUpdate.Location = new System.Drawing.Point(18, 185);
            this.btnConfirmUpdate.Name = "btnConfirmUpdate";
            this.btnConfirmUpdate.Size = new System.Drawing.Size(82, 21);
            this.btnConfirmUpdate.TabIndex = 6;
            this.btnConfirmUpdate.Text = "Confirm";
            this.btnConfirmUpdate.UseVisualStyleBackColor = true;
            this.btnConfirmUpdate.Click += new System.EventHandler(this.btnConfirmUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ten Nhan Vien:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã Nhân Viên:";
            // 
            // txtMaNVUpdate
            // 
            this.txtMaNVUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNVUpdate.Location = new System.Drawing.Point(112, 13);
            this.txtMaNVUpdate.Name = "txtMaNVUpdate";
            this.txtMaNVUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtMaNVUpdate.TabIndex = 1;
            // 
            // txtMaRapUpdate
            // 
            this.txtMaRapUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaRapUpdate.Location = new System.Drawing.Point(112, 153);
            this.txtMaRapUpdate.Name = "txtMaRapUpdate";
            this.txtMaRapUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtMaRapUpdate.TabIndex = 5;
            // 
            // txtTenNVUpdate
            // 
            this.txtTenNVUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNVUpdate.Location = new System.Drawing.Point(112, 41);
            this.txtTenNVUpdate.Name = "txtTenNVUpdate";
            this.txtTenNVUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtTenNVUpdate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Rạp:";
            // 
            // txtMKUpdate
            // 
            this.txtMKUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMKUpdate.Location = new System.Drawing.Point(112, 69);
            this.txtMKUpdate.Name = "txtMKUpdate";
            this.txtMKUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtMKUpdate.TabIndex = 2;
            // 
            // txtLuongUpdate
            // 
            this.txtLuongUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLuongUpdate.Location = new System.Drawing.Point(112, 125);
            this.txtLuongUpdate.Name = "txtLuongUpdate";
            this.txtLuongUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtLuongUpdate.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chức Vụ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lương:";
            // 
            // txtChucVuUpdate
            // 
            this.txtChucVuUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChucVuUpdate.Location = new System.Drawing.Point(112, 97);
            this.txtChucVuUpdate.Name = "txtChucVuUpdate";
            this.txtChucVuUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtChucVuUpdate.TabIndex = 3;
            // 
            // pnlDel
            // 
            this.pnlDel.Controls.Add(this.btnCancelDel);
            this.pnlDel.Controls.Add(this.btnConfirmDel);
            this.pnlDel.Controls.Add(this.lblMaNV);
            this.pnlDel.Controls.Add(this.txtMaNV);
            this.pnlDel.Location = new System.Drawing.Point(655, 156);
            this.pnlDel.Name = "pnlDel";
            this.pnlDel.Size = new System.Drawing.Size(238, 115);
            this.pnlDel.TabIndex = 4;
            this.pnlDel.Visible = false;
            // 
            // btnCancelDel
            // 
            this.btnCancelDel.Location = new System.Drawing.Point(126, 49);
            this.btnCancelDel.Name = "btnCancelDel";
            this.btnCancelDel.Size = new System.Drawing.Size(82, 26);
            this.btnCancelDel.TabIndex = 2;
            this.btnCancelDel.Text = "Cancel";
            this.btnCancelDel.UseVisualStyleBackColor = true;
            this.btnCancelDel.Click += new System.EventHandler(this.btnCancelDel_Click);
            // 
            // btnConfirmDel
            // 
            this.btnConfirmDel.Location = new System.Drawing.Point(18, 49);
            this.btnConfirmDel.Name = "btnConfirmDel";
            this.btnConfirmDel.Size = new System.Drawing.Size(82, 26);
            this.btnConfirmDel.TabIndex = 2;
            this.btnConfirmDel.Text = "Confirm";
            this.btnConfirmDel.UseVisualStyleBackColor = true;
            this.btnConfirmDel.Click += new System.EventHandler(this.btnConfirmDel_Click);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(15, 20);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(78, 13);
            this.lblMaNV.TabIndex = 0;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaNV.Location = new System.Drawing.Point(103, 20);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(105, 13);
            this.txtMaNV.TabIndex = 1;
            // 
            // pnlAddDetails
            // 
            this.pnlAddDetails.Controls.Add(this.btnCancelAdd);
            this.pnlAddDetails.Controls.Add(this.btnConfirmAdd);
            this.pnlAddDetails.Controls.Add(this.txtMaRap);
            this.pnlAddDetails.Controls.Add(this.lblMaRap);
            this.pnlAddDetails.Controls.Add(this.txtLuong);
            this.pnlAddDetails.Controls.Add(this.lblLuong);
            this.pnlAddDetails.Controls.Add(this.txtChucVu);
            this.pnlAddDetails.Controls.Add(this.lblChucVu);
            this.pnlAddDetails.Controls.Add(this.txtMK);
            this.pnlAddDetails.Controls.Add(this.lblMatKhau);
            this.pnlAddDetails.Controls.Add(this.txtTenNV);
            this.pnlAddDetails.Controls.Add(this.lblTenNhanVien);
            this.pnlAddDetails.Location = new System.Drawing.Point(661, 156);
            this.pnlAddDetails.Name = "pnlAddDetails";
            this.pnlAddDetails.Size = new System.Drawing.Size(232, 386);
            this.pnlAddDetails.TabIndex = 2;
            this.pnlAddDetails.Visible = false;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.Location = new System.Drawing.Point(118, 172);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(90, 26);
            this.btnCancelAdd.TabIndex = 7;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = true;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Location = new System.Drawing.Point(18, 172);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(90, 26);
            this.btnConfirmAdd.TabIndex = 6;
            this.btnConfirmAdd.Text = "Confirm";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtMaRap
            // 
            this.txtMaRap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaRap.Location = new System.Drawing.Point(103, 136);
            this.txtMaRap.Name = "txtMaRap";
            this.txtMaRap.Size = new System.Drawing.Size(105, 13);
            this.txtMaRap.TabIndex = 5;
            // 
            // lblMaRap
            // 
            this.lblMaRap.AutoSize = true;
            this.lblMaRap.Location = new System.Drawing.Point(15, 136);
            this.lblMaRap.Name = "lblMaRap";
            this.lblMaRap.Size = new System.Drawing.Size(48, 13);
            this.lblMaRap.TabIndex = 0;
            this.lblMaRap.Text = "Mã Rạp:";
            // 
            // txtLuong
            // 
            this.txtLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLuong.Location = new System.Drawing.Point(103, 107);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(105, 13);
            this.txtLuong.TabIndex = 4;
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(15, 107);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(40, 13);
            this.lblLuong.TabIndex = 0;
            this.lblLuong.Text = "Lương:";
            // 
            // txtChucVu
            // 
            this.txtChucVu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChucVu.Location = new System.Drawing.Point(103, 78);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(105, 13);
            this.txtChucVu.TabIndex = 3;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(15, 78);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(51, 13);
            this.lblChucVu.TabIndex = 0;
            this.lblChucVu.Text = "Chức Vụ:";
            // 
            // txtMK
            // 
            this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMK.Location = new System.Drawing.Point(103, 49);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(105, 13);
            this.txtMK.TabIndex = 2;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(15, 49);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(85, 13);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Nhập Mật Khẩu:";
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNV.Location = new System.Drawing.Point(103, 20);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(105, 13);
            this.txtTenNV.TabIndex = 1;
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(15, 20);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(82, 13);
            this.lblTenNhanVien.TabIndex = 0;
            this.lblTenNhanVien.Text = "Ten Nhan Vien:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(803, 107);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 26);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(661, 107);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 26);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(803, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 26);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvData
            // 
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(2, 67);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersWidth = 82;
            this.dgvData.RowTemplate.Height = 33;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(633, 476);
            this.dgvData.TabIndex = 1;
            this.dgvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(661, 67);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(90, 29);
            this.btnShowList.TabIndex = 0;
            this.btnShowList.Text = "Show List";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnlNhanVien);
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
            this.pnlNhanVien.ResumeLayout(false);
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.pnlDel.ResumeLayout(false);
            this.pnlDel.PerformLayout();
            this.pnlAddDetails.ResumeLayout(false);
            this.pnlAddDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
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
        private Panel pnlNhanVien;
        private DataGridView dgvData;
        private Button btnShowList;
        private Panel pnlAddDetails;
        private TextBox txtTenNV;
        private Label lblTenNhanVien;
        private TextBox txtLuong;
        private Label lblLuong;
        private TextBox txtChucVu;
        private Label lblChucVu;
        private TextBox txtMK;
        private Label lblMatKhau;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Button btnCancelAdd;
        private Button btnConfirmAdd;
        private TextBox txtMaRap;
        private Label lblMaRap;
        private Panel pnlDel;
        private Label lblMaNV;
        private TextBox txtMaNV;
        private Button btnCancelDel;
        private Button btnConfirmDel;
        private Panel pnlUpdate;
        private Label label3;
        private Label label2;
        private TextBox txtMaRapUpdate;
        private TextBox txtTenNVUpdate;
        private Label label6;
        private TextBox txtMKUpdate;
        private TextBox txtLuongUpdate;
        private Label label4;
        private Label label5;
        private TextBox txtChucVuUpdate;
        private Button btnCancelUpdate;
        private Button btnConfirmUpdate;
        private Label label7;
        private TextBox txtMaNVUpdate;
        //       private Timer phimTimer;
    }
}

using System.Windows.Forms;

namespace UInvcapcao.Forms
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
            this.btnLichChieu = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlNhanVien = new System.Windows.Forms.Panel();
            this.lblQuanLyNhanVien = new System.Windows.Forms.Label();
            this.btnThongKeNV = new System.Windows.Forms.Button();
            this.btnNvDelete = new System.Windows.Forms.Button();
            this.btnNvUpdate = new System.Windows.Forms.Button();
            this.btnNvAdd = new System.Windows.Forms.Button();
            this.dgvNvData = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhauNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaRap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNvShowList = new System.Windows.Forms.Button();
            this.pnlNvUpdate = new System.Windows.Forms.Panel();
            this.btnNvCancelUpdate = new System.Windows.Forms.Button();
            this.btnNvConfirmUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaRapUpdate = new System.Windows.Forms.TextBox();
            this.txtTenNVUpdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMKUpdate = new System.Windows.Forms.TextBox();
            this.txtLuongUpdate = new System.Windows.Forms.TextBox();
            this.txtMaCNUpdate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMaCNUpdate = new System.Windows.Forms.Label();
            this.pnlNvAddDetails = new System.Windows.Forms.Panel();
            this.btnCancelAdd = new System.Windows.Forms.Button();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.txtMaRap = new System.Windows.Forms.TextBox();
            this.lblMaRap = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtMaCN = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.lblMaCN = new System.Windows.Forms.Label();
            this.lblTenNhanVien = new System.Windows.Forms.Label();
            this.pnlNvDel = new System.Windows.Forms.Panel();
            this.lblDelWarning2 = new System.Windows.Forms.Label();
            this.lblDelWarning1 = new System.Windows.Forms.Label();
            this.btnCancelDel = new System.Windows.Forms.Button();
            this.btnConfirmDel = new System.Windows.Forms.Button();
            this.pnlThongKe = new System.Windows.Forms.Panel();
            this.lblQuanLyDoanhThu = new System.Windows.Forms.Label();
            this.btnThongKeDoanhThuRap = new System.Windows.Forms.Button();
            this.btnXuatDoanhThuRap = new System.Windows.Forms.Button();
            this.dgvDoanhThuRap = new System.Windows.Forms.DataGridView();
            this.btnXuatDoanhThuPhim = new System.Windows.Forms.Button();
            this.dgvDoanhThuPhim = new System.Windows.Forms.DataGridView();
            this.btnThongKeDoanhThuPhim = new System.Windows.Forms.Button();
            this.pnlQuanLyPhim = new System.Windows.Forms.Panel();
            this.lblQuanLyPhim = new System.Windows.Forms.Label();
            this.btnThongKePhim = new System.Windows.Forms.Button();
            this.grbQuanLyPhim = new System.Windows.Forms.GroupBox();
            this.btnPhimDel = new System.Windows.Forms.Button();
            this.btnPhimUpdate = new System.Windows.Forms.Button();
            this.btnPosterAdd = new System.Windows.Forms.Button();
            this.btnShowdgvPhim = new System.Windows.Forms.Button();
            this.btnPhimAdd = new System.Windows.Forms.Button();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKhoiChieu = new System.Windows.Forms.DateTimePicker();
            this.cmbTheLoai = new System.Windows.Forms.ComboBox();
            this.txtTongChiPhi = new System.Windows.Forms.TextBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtTenPhim = new System.Windows.Forms.TextBox();
            this.txtMaPhim = new System.Windows.Forms.TextBox();
            this.lblPosterPhim = new System.Windows.Forms.Label();
            this.lblTongChiPhi = new System.Windows.Forms.Label();
            this.lblThoiLuong = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.lblNgayKhoiChieu = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblTenPhim = new System.Windows.Forms.Label();
            this.lblMaPhim = new System.Windows.Forms.Label();
            this.ptbPosterPhim = new System.Windows.Forms.PictureBox();
            this.dgvQuanLyPhim = new System.Windows.Forms.DataGridView();
            this.MaPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlLichChieu = new System.Windows.Forms.Panel();
            this.lblQuanLyLichChieu = new System.Windows.Forms.Label();
            this.btnThongKeLichChieu = new System.Windows.Forms.Button();
            this.grbThongTinLichChieu = new System.Windows.Forms.GroupBox();
            this.btnLcDelete = new System.Windows.Forms.Button();
            this.btnLcUpdate = new System.Windows.Forms.Button();
            this.btnLcAdd = new System.Windows.Forms.Button();
            this.btndgvLichChieuShowList = new System.Windows.Forms.Button();
            this.cmbTenPhongLC = new System.Windows.Forms.ComboBox();
            this.txtGiaVeLC = new System.Windows.Forms.TextBox();
            this.dtpNgayChieuLC = new System.Windows.Forms.DateTimePicker();
            this.cmbGioChieuLC = new System.Windows.Forms.ComboBox();
            this.cmbMaRapLC = new System.Windows.Forms.ComboBox();
            this.lblGiaVe = new System.Windows.Forms.Label();
            this.cmbTenPhimLC = new System.Windows.Forms.ComboBox();
            this.txtMaShow = new System.Windows.Forms.TextBox();
            this.lblGioChieu = new System.Windows.Forms.Label();
            this.lblTenPhimLC = new System.Windows.Forms.Label();
            this.lblNgayChieu = new System.Windows.Forms.Label();
            this.lblMaRapLC = new System.Windows.Forms.Label();
            this.lblMaShow = new System.Windows.Forms.Label();
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.dgvLichChieu = new System.Windows.Forms.DataGridView();
            this.MaShow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel2.SuspendLayout();
            this.pnlNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNvData)).BeginInit();
            this.pnlNvUpdate.SuspendLayout();
            this.pnlNvAddDetails.SuspendLayout();
            this.pnlNvDel.SuspendLayout();
            this.pnlThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuRap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuPhim)).BeginInit();
            this.pnlQuanLyPhim.SuspendLayout();
            this.grbQuanLyPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPosterPhim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhim)).BeginInit();
            this.pnlLichChieu.SuspendLayout();
            this.grbThongTinLichChieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).BeginInit();
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
            this.sidebar.Controls.Add(this.panel2);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btnPhim.Click += new System.EventHandler(this.btnPhim_Click);
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
            this.panel4.Controls.Add(this.btnLichChieu);
            this.panel4.Location = new System.Drawing.Point(3, 136);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 48);
            this.panel4.TabIndex = 1;
            // 
            // btnLichChieu
            // 
            this.btnLichChieu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLichChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichChieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichChieu.ForeColor = System.Drawing.Color.White;
            this.btnLichChieu.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnLichChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichChieu.Location = new System.Drawing.Point(-23, -9);
            this.btnLichChieu.Name = "btnLichChieu";
            this.btnLichChieu.Size = new System.Drawing.Size(209, 66);
            this.btnLichChieu.TabIndex = 1;
            this.btnLichChieu.Text = "                Lịch Chiếu";
            this.btnLichChieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichChieu.UseVisualStyleBackColor = true;
            this.btnLichChieu.Click += new System.EventHandler(this.btnLichChieu_Click);
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
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnLogout);
            this.panel7.Location = new System.Drawing.Point(3, 298);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 48);
            this.panel7.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::UInvcapcao.Properties.Resources.dot_icon4;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(-23, -11);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(212, 74);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "                Đăng Xuất ";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUser);
            this.panel2.Location = new System.Drawing.Point(3, 352);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 48);
            this.panel2.TabIndex = 7;
            // 
            // btnUser
            // 
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Image = global::UInvcapcao.Properties.Resources.Image_User4_jpg;
            this.btnUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.Location = new System.Drawing.Point(-23, -7);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(212, 74);
            this.btnUser.TabIndex = 7;
            this.btnUser.Text = "                User ";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // pnlNhanVien
            // 
            this.pnlNhanVien.Controls.Add(this.lblQuanLyNhanVien);
            this.pnlNhanVien.Controls.Add(this.btnThongKeNV);
            this.pnlNhanVien.Controls.Add(this.btnNvDelete);
            this.pnlNhanVien.Controls.Add(this.btnNvUpdate);
            this.pnlNhanVien.Controls.Add(this.btnNvAdd);
            this.pnlNhanVien.Controls.Add(this.dgvNvData);
            this.pnlNhanVien.Controls.Add(this.btnNvShowList);
            this.pnlNhanVien.Controls.Add(this.pnlNvUpdate);
            this.pnlNhanVien.Controls.Add(this.pnlNvAddDetails);
            this.pnlNhanVien.Controls.Add(this.pnlNvDel);
            this.pnlNhanVien.Location = new System.Drawing.Point(65, 5);
            this.pnlNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.pnlNhanVien.Name = "pnlNhanVien";
            this.pnlNhanVien.Size = new System.Drawing.Size(908, 545);
            this.pnlNhanVien.TabIndex = 1;
            this.pnlNhanVien.Visible = false;
            // 
            // lblQuanLyNhanVien
            // 
            this.lblQuanLyNhanVien.AutoSize = true;
            this.lblQuanLyNhanVien.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyNhanVien.Location = new System.Drawing.Point(330, 19);
            this.lblQuanLyNhanVien.Name = "lblQuanLyNhanVien";
            this.lblQuanLyNhanVien.Size = new System.Drawing.Size(294, 29);
            this.lblQuanLyNhanVien.TabIndex = 6;
            this.lblQuanLyNhanVien.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // btnThongKeNV
            // 
            this.btnThongKeNV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongKeNV.Location = new System.Drawing.Point(556, 348);
            this.btnThongKeNV.Name = "btnThongKeNV";
            this.btnThongKeNV.Size = new System.Drawing.Size(88, 23);
            this.btnThongKeNV.TabIndex = 5;
            this.btnThongKeNV.Text = "In Báo Cáo";
            this.btnThongKeNV.UseVisualStyleBackColor = false;
            this.btnThongKeNV.Click += new System.EventHandler(this.btnThongKePhim_Click);
            // 
            // btnNvDelete
            // 
            this.btnNvDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNvDelete.Location = new System.Drawing.Point(803, 107);
            this.btnNvDelete.Name = "btnNvDelete";
            this.btnNvDelete.Size = new System.Drawing.Size(90, 26);
            this.btnNvDelete.TabIndex = 3;
            this.btnNvDelete.Text = "Delete";
            this.btnNvDelete.UseVisualStyleBackColor = false;
            this.btnNvDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNvUpdate
            // 
            this.btnNvUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNvUpdate.Location = new System.Drawing.Point(661, 107);
            this.btnNvUpdate.Name = "btnNvUpdate";
            this.btnNvUpdate.Size = new System.Drawing.Size(90, 26);
            this.btnNvUpdate.TabIndex = 2;
            this.btnNvUpdate.Text = "Update";
            this.btnNvUpdate.UseVisualStyleBackColor = false;
            this.btnNvUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnNvAdd
            // 
            this.btnNvAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNvAdd.Location = new System.Drawing.Point(803, 68);
            this.btnNvAdd.Name = "btnNvAdd";
            this.btnNvAdd.Size = new System.Drawing.Size(90, 26);
            this.btnNvAdd.TabIndex = 1;
            this.btnNvAdd.Text = "Add";
            this.btnNvAdd.UseVisualStyleBackColor = false;
            this.btnNvAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvNvData
            // 
            this.dgvNvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.MatKhauNV,
            this.ChucVu,
            this.Luong,
            this.MaRap,
            this.QuyenHan});
            this.dgvNvData.Location = new System.Drawing.Point(10, 70);
            this.dgvNvData.Margin = new System.Windows.Forms.Padding(2);
            this.dgvNvData.Name = "dgvNvData";
            this.dgvNvData.RowHeadersWidth = 82;
            this.dgvNvData.RowTemplate.Height = 33;
            this.dgvNvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNvData.Size = new System.Drawing.Size(633, 273);
            this.dgvNvData.TabIndex = 1;
            this.dgvNvData.SelectionChanged += new System.EventHandler(this.dgvData_SelectionChanged);
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNV.HeaderText = "MaNV";
            this.MaNV.MinimumWidth = 10;
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 62;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenNV.HeaderText = "TenNV";
            this.TenNV.MinimumWidth = 10;
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 66;
            // 
            // MatKhauNV
            // 
            this.MatKhauNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MatKhauNV.HeaderText = "MatKhauNV";
            this.MatKhauNV.MinimumWidth = 10;
            this.MatKhauNV.Name = "MatKhauNV";
            this.MatKhauNV.Width = 90;
            // 
            // ChucVu
            // 
            this.ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ChucVu.HeaderText = "ChucVu";
            this.ChucVu.MinimumWidth = 10;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.Width = 70;
            // 
            // Luong
            // 
            this.Luong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Luong.HeaderText = "Luong";
            this.Luong.MinimumWidth = 10;
            this.Luong.Name = "Luong";
            this.Luong.Width = 62;
            // 
            // MaRap
            // 
            this.MaRap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaRap.HeaderText = "MaRap";
            this.MaRap.MinimumWidth = 10;
            this.MaRap.Name = "MaRap";
            this.MaRap.Width = 67;
            // 
            // QuyenHan
            // 
            this.QuyenHan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuyenHan.HeaderText = "QuyenHan";
            this.QuyenHan.MinimumWidth = 10;
            this.QuyenHan.Name = "QuyenHan";
            this.QuyenHan.Width = 83;
            // 
            // btnNvShowList
            // 
            this.btnNvShowList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNvShowList.Location = new System.Drawing.Point(661, 67);
            this.btnNvShowList.Margin = new System.Windows.Forms.Padding(2);
            this.btnNvShowList.Name = "btnNvShowList";
            this.btnNvShowList.Size = new System.Drawing.Size(90, 29);
            this.btnNvShowList.TabIndex = 0;
            this.btnNvShowList.Text = "Show List";
            this.btnNvShowList.UseVisualStyleBackColor = false;
            this.btnNvShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // pnlNvUpdate
            // 
            this.pnlNvUpdate.Controls.Add(this.btnNvCancelUpdate);
            this.pnlNvUpdate.Controls.Add(this.btnNvConfirmUpdate);
            this.pnlNvUpdate.Controls.Add(this.label3);
            this.pnlNvUpdate.Controls.Add(this.label2);
            this.pnlNvUpdate.Controls.Add(this.txtMaRapUpdate);
            this.pnlNvUpdate.Controls.Add(this.txtTenNVUpdate);
            this.pnlNvUpdate.Controls.Add(this.label6);
            this.pnlNvUpdate.Controls.Add(this.txtMKUpdate);
            this.pnlNvUpdate.Controls.Add(this.txtLuongUpdate);
            this.pnlNvUpdate.Controls.Add(this.txtMaCNUpdate);
            this.pnlNvUpdate.Controls.Add(this.label5);
            this.pnlNvUpdate.Controls.Add(this.lblMaCNUpdate);
            this.pnlNvUpdate.Location = new System.Drawing.Point(654, 159);
            this.pnlNvUpdate.Name = "pnlNvUpdate";
            this.pnlNvUpdate.Size = new System.Drawing.Size(250, 262);
            this.pnlNvUpdate.TabIndex = 4;
            this.pnlNvUpdate.Visible = false;
            // 
            // btnNvCancelUpdate
            // 
            this.btnNvCancelUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNvCancelUpdate.Location = new System.Drawing.Point(136, 150);
            this.btnNvCancelUpdate.Name = "btnNvCancelUpdate";
            this.btnNvCancelUpdate.Size = new System.Drawing.Size(82, 21);
            this.btnNvCancelUpdate.TabIndex = 6;
            this.btnNvCancelUpdate.Text = "Cancel";
            this.btnNvCancelUpdate.UseVisualStyleBackColor = false;
            this.btnNvCancelUpdate.Click += new System.EventHandler(this.btnCancelUpdate_Click);
            // 
            // btnNvConfirmUpdate
            // 
            this.btnNvConfirmUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnNvConfirmUpdate.Location = new System.Drawing.Point(18, 152);
            this.btnNvConfirmUpdate.Name = "btnNvConfirmUpdate";
            this.btnNvConfirmUpdate.Size = new System.Drawing.Size(82, 21);
            this.btnNvConfirmUpdate.TabIndex = 6;
            this.btnNvConfirmUpdate.Text = "Confirm";
            this.btnNvConfirmUpdate.UseVisualStyleBackColor = false;
            this.btnNvConfirmUpdate.Click += new System.EventHandler(this.btnConfirmUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ten Nhan Vien:";
            // 
            // txtMaRapUpdate
            // 
            this.txtMaRapUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaRapUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaRapUpdate.Location = new System.Drawing.Point(112, 118);
            this.txtMaRapUpdate.Name = "txtMaRapUpdate";
            this.txtMaRapUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtMaRapUpdate.TabIndex = 4;
            // 
            // txtTenNVUpdate
            // 
            this.txtTenNVUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenNVUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNVUpdate.Location = new System.Drawing.Point(112, 40);
            this.txtTenNVUpdate.Name = "txtTenNVUpdate";
            this.txtTenNVUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtTenNVUpdate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Rạp:";
            // 
            // txtMKUpdate
            // 
            this.txtMKUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMKUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMKUpdate.Location = new System.Drawing.Point(112, 66);
            this.txtMKUpdate.Name = "txtMKUpdate";
            this.txtMKUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtMKUpdate.TabIndex = 2;
            // 
            // txtLuongUpdate
            // 
            this.txtLuongUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLuongUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLuongUpdate.Location = new System.Drawing.Point(112, 92);
            this.txtLuongUpdate.Name = "txtLuongUpdate";
            this.txtLuongUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtLuongUpdate.TabIndex = 3;
            // 
            // txtMaCNUpdate
            // 
            this.txtMaCNUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaCNUpdate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaCNUpdate.Location = new System.Drawing.Point(112, 14);
            this.txtMaCNUpdate.Name = "txtMaCNUpdate";
            this.txtMaCNUpdate.Size = new System.Drawing.Size(105, 13);
            this.txtMaCNUpdate.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Lương:";
            // 
            // lblMaCNUpdate
            // 
            this.lblMaCNUpdate.AutoSize = true;
            this.lblMaCNUpdate.Location = new System.Drawing.Point(24, 14);
            this.lblMaCNUpdate.Name = "lblMaCNUpdate";
            this.lblMaCNUpdate.Size = new System.Drawing.Size(82, 13);
            this.lblMaCNUpdate.TabIndex = 0;
            this.lblMaCNUpdate.Text = "Mã Chức Năng:";
            // 
            // pnlNvAddDetails
            // 
            this.pnlNvAddDetails.Controls.Add(this.btnCancelAdd);
            this.pnlNvAddDetails.Controls.Add(this.btnConfirmAdd);
            this.pnlNvAddDetails.Controls.Add(this.txtMaRap);
            this.pnlNvAddDetails.Controls.Add(this.lblMaRap);
            this.pnlNvAddDetails.Controls.Add(this.txtLuong);
            this.pnlNvAddDetails.Controls.Add(this.lblLuong);
            this.pnlNvAddDetails.Controls.Add(this.txtMK);
            this.pnlNvAddDetails.Controls.Add(this.lblMatKhau);
            this.pnlNvAddDetails.Controls.Add(this.txtMaCN);
            this.pnlNvAddDetails.Controls.Add(this.txtTenNV);
            this.pnlNvAddDetails.Controls.Add(this.lblMaCN);
            this.pnlNvAddDetails.Controls.Add(this.lblTenNhanVien);
            this.pnlNvAddDetails.Location = new System.Drawing.Point(661, 156);
            this.pnlNvAddDetails.Name = "pnlNvAddDetails";
            this.pnlNvAddDetails.Size = new System.Drawing.Size(232, 386);
            this.pnlNvAddDetails.TabIndex = 2;
            this.pnlNvAddDetails.Visible = false;
            // 
            // btnCancelAdd
            // 
            this.btnCancelAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelAdd.Location = new System.Drawing.Point(122, 168);
            this.btnCancelAdd.Name = "btnCancelAdd";
            this.btnCancelAdd.Size = new System.Drawing.Size(90, 26);
            this.btnCancelAdd.TabIndex = 7;
            this.btnCancelAdd.Text = "Cancel";
            this.btnCancelAdd.UseVisualStyleBackColor = false;
            this.btnCancelAdd.Click += new System.EventHandler(this.btnCancelAdd_Click);
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmAdd.Location = new System.Drawing.Point(22, 168);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(90, 26);
            this.btnConfirmAdd.TabIndex = 6;
            this.btnConfirmAdd.Text = "Confirm";
            this.btnConfirmAdd.UseVisualStyleBackColor = false;
            this.btnConfirmAdd.Click += new System.EventHandler(this.btnConfirmAdd_Click);
            // 
            // txtMaRap
            // 
            this.txtMaRap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaRap.Location = new System.Drawing.Point(107, 132);
            this.txtMaRap.Name = "txtMaRap";
            this.txtMaRap.Size = new System.Drawing.Size(105, 13);
            this.txtMaRap.TabIndex = 4;
            // 
            // lblMaRap
            // 
            this.lblMaRap.AutoSize = true;
            this.lblMaRap.Location = new System.Drawing.Point(19, 132);
            this.lblMaRap.Name = "lblMaRap";
            this.lblMaRap.Size = new System.Drawing.Size(48, 13);
            this.lblMaRap.TabIndex = 0;
            this.lblMaRap.Text = "Mã Rạp:";
            // 
            // txtLuong
            // 
            this.txtLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLuong.Location = new System.Drawing.Point(107, 104);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(105, 13);
            this.txtLuong.TabIndex = 3;
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(19, 104);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(40, 13);
            this.lblLuong.TabIndex = 0;
            this.lblLuong.Text = "Lương:";
            // 
            // txtMK
            // 
            this.txtMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMK.Location = new System.Drawing.Point(107, 76);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(105, 13);
            this.txtMK.TabIndex = 2;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(19, 76);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(85, 13);
            this.lblMatKhau.TabIndex = 0;
            this.lblMatKhau.Text = "Nhập Mật Khẩu:";
            // 
            // txtMaCN
            // 
            this.txtMaCN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaCN.Location = new System.Drawing.Point(107, 20);
            this.txtMaCN.Name = "txtMaCN";
            this.txtMaCN.Size = new System.Drawing.Size(105, 13);
            this.txtMaCN.TabIndex = 0;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenNV.Location = new System.Drawing.Point(107, 48);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(105, 13);
            this.txtTenNV.TabIndex = 1;
            // 
            // lblMaCN
            // 
            this.lblMaCN.AutoSize = true;
            this.lblMaCN.Location = new System.Drawing.Point(19, 20);
            this.lblMaCN.Name = "lblMaCN";
            this.lblMaCN.Size = new System.Drawing.Size(82, 13);
            this.lblMaCN.TabIndex = 0;
            this.lblMaCN.Text = "Mã Chức Năng:";
            // 
            // lblTenNhanVien
            // 
            this.lblTenNhanVien.AutoSize = true;
            this.lblTenNhanVien.Location = new System.Drawing.Point(19, 48);
            this.lblTenNhanVien.Name = "lblTenNhanVien";
            this.lblTenNhanVien.Size = new System.Drawing.Size(82, 13);
            this.lblTenNhanVien.TabIndex = 0;
            this.lblTenNhanVien.Text = "Ten Nhan Vien:";
            // 
            // pnlNvDel
            // 
            this.pnlNvDel.Controls.Add(this.lblDelWarning2);
            this.pnlNvDel.Controls.Add(this.lblDelWarning1);
            this.pnlNvDel.Controls.Add(this.btnCancelDel);
            this.pnlNvDel.Controls.Add(this.btnConfirmDel);
            this.pnlNvDel.Location = new System.Drawing.Point(652, 173);
            this.pnlNvDel.Name = "pnlNvDel";
            this.pnlNvDel.Size = new System.Drawing.Size(238, 115);
            this.pnlNvDel.TabIndex = 4;
            this.pnlNvDel.Visible = false;
            // 
            // lblDelWarning2
            // 
            this.lblDelWarning2.AutoSize = true;
            this.lblDelWarning2.Location = new System.Drawing.Point(14, 42);
            this.lblDelWarning2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelWarning2.Name = "lblDelWarning2";
            this.lblDelWarning2.Size = new System.Drawing.Size(196, 13);
            this.lblDelWarning2.TabIndex = 3;
            this.lblDelWarning2.Text = "Một khi xóa data sẽ không được restore";
            // 
            // lblDelWarning1
            // 
            this.lblDelWarning1.AutoSize = true;
            this.lblDelWarning1.Location = new System.Drawing.Point(28, 17);
            this.lblDelWarning1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelWarning1.Name = "lblDelWarning1";
            this.lblDelWarning1.Size = new System.Drawing.Size(170, 13);
            this.lblDelWarning1.TabIndex = 3;
            this.lblDelWarning1.Text = "Bạn có chắc là muốn xóa không ?";
            // 
            // btnCancelDel
            // 
            this.btnCancelDel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelDel.Location = new System.Drawing.Point(126, 73);
            this.btnCancelDel.Name = "btnCancelDel";
            this.btnCancelDel.Size = new System.Drawing.Size(82, 26);
            this.btnCancelDel.TabIndex = 2;
            this.btnCancelDel.Text = "Cancel";
            this.btnCancelDel.UseVisualStyleBackColor = false;
            this.btnCancelDel.Click += new System.EventHandler(this.btnCancelDel_Click);
            // 
            // btnConfirmDel
            // 
            this.btnConfirmDel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirmDel.Location = new System.Drawing.Point(18, 73);
            this.btnConfirmDel.Name = "btnConfirmDel";
            this.btnConfirmDel.Size = new System.Drawing.Size(82, 26);
            this.btnConfirmDel.TabIndex = 2;
            this.btnConfirmDel.Text = "Confirm";
            this.btnConfirmDel.UseVisualStyleBackColor = false;
            this.btnConfirmDel.Click += new System.EventHandler(this.btnConfirmDel_Click);
            // 
            // pnlThongKe
            // 
            this.pnlThongKe.Controls.Add(this.lblQuanLyDoanhThu);
            this.pnlThongKe.Controls.Add(this.btnThongKeDoanhThuRap);
            this.pnlThongKe.Controls.Add(this.btnXuatDoanhThuRap);
            this.pnlThongKe.Controls.Add(this.dgvDoanhThuRap);
            this.pnlThongKe.Controls.Add(this.btnXuatDoanhThuPhim);
            this.pnlThongKe.Controls.Add(this.dgvDoanhThuPhim);
            this.pnlThongKe.Controls.Add(this.btnThongKeDoanhThuPhim);
            this.pnlThongKe.Location = new System.Drawing.Point(58, 3);
            this.pnlThongKe.Name = "pnlThongKe";
            this.pnlThongKe.Size = new System.Drawing.Size(912, 544);
            this.pnlThongKe.TabIndex = 2;
            this.pnlThongKe.Visible = false;
            // 
            // lblQuanLyDoanhThu
            // 
            this.lblQuanLyDoanhThu.AutoSize = true;
            this.lblQuanLyDoanhThu.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyDoanhThu.Location = new System.Drawing.Point(314, 17);
            this.lblQuanLyDoanhThu.Name = "lblQuanLyDoanhThu";
            this.lblQuanLyDoanhThu.Size = new System.Drawing.Size(302, 29);
            this.lblQuanLyDoanhThu.TabIndex = 7;
            this.lblQuanLyDoanhThu.Text = "QUẢN LÝ DOANH THU";
            // 
            // btnThongKeDoanhThuRap
            // 
            this.btnThongKeDoanhThuRap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongKeDoanhThuRap.Location = new System.Drawing.Point(729, 314);
            this.btnThongKeDoanhThuRap.Name = "btnThongKeDoanhThuRap";
            this.btnThongKeDoanhThuRap.Size = new System.Drawing.Size(106, 23);
            this.btnThongKeDoanhThuRap.TabIndex = 6;
            this.btnThongKeDoanhThuRap.Text = "In ra Excel";
            this.btnThongKeDoanhThuRap.UseVisualStyleBackColor = false;
            this.btnThongKeDoanhThuRap.Click += new System.EventHandler(this.btnThongKePhim_Click);
            // 
            // btnXuatDoanhThuRap
            // 
            this.btnXuatDoanhThuRap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXuatDoanhThuRap.Location = new System.Drawing.Point(729, 284);
            this.btnXuatDoanhThuRap.Name = "btnXuatDoanhThuRap";
            this.btnXuatDoanhThuRap.Size = new System.Drawing.Size(106, 23);
            this.btnXuatDoanhThuRap.TabIndex = 5;
            this.btnXuatDoanhThuRap.Text = "Doanh thu rạp";
            this.btnXuatDoanhThuRap.UseVisualStyleBackColor = false;
            this.btnXuatDoanhThuRap.Click += new System.EventHandler(this.btnXuatDoanhThuRap_Click);
            // 
            // dgvDoanhThuRap
            // 
            this.dgvDoanhThuRap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuRap.Location = new System.Drawing.Point(181, 286);
            this.dgvDoanhThuRap.Name = "dgvDoanhThuRap";
            this.dgvDoanhThuRap.Size = new System.Drawing.Size(542, 174);
            this.dgvDoanhThuRap.TabIndex = 4;
            // 
            // btnXuatDoanhThuPhim
            // 
            this.btnXuatDoanhThuPhim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnXuatDoanhThuPhim.Location = new System.Drawing.Point(729, 61);
            this.btnXuatDoanhThuPhim.Name = "btnXuatDoanhThuPhim";
            this.btnXuatDoanhThuPhim.Size = new System.Drawing.Size(106, 23);
            this.btnXuatDoanhThuPhim.TabIndex = 3;
            this.btnXuatDoanhThuPhim.Text = "Doanh thu Phim";
            this.btnXuatDoanhThuPhim.UseVisualStyleBackColor = false;
            this.btnXuatDoanhThuPhim.Click += new System.EventHandler(this.btnXuatDoanhThuPhim_Click);
            // 
            // dgvDoanhThuPhim
            // 
            this.dgvDoanhThuPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoanhThuPhim.Location = new System.Drawing.Point(181, 61);
            this.dgvDoanhThuPhim.Name = "dgvDoanhThuPhim";
            this.dgvDoanhThuPhim.Size = new System.Drawing.Size(542, 183);
            this.dgvDoanhThuPhim.TabIndex = 2;
            // 
            // btnThongKeDoanhThuPhim
            // 
            this.btnThongKeDoanhThuPhim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongKeDoanhThuPhim.Location = new System.Drawing.Point(729, 94);
            this.btnThongKeDoanhThuPhim.Name = "btnThongKeDoanhThuPhim";
            this.btnThongKeDoanhThuPhim.Size = new System.Drawing.Size(106, 23);
            this.btnThongKeDoanhThuPhim.TabIndex = 0;
            this.btnThongKeDoanhThuPhim.Text = "In ra Excel";
            this.btnThongKeDoanhThuPhim.UseVisualStyleBackColor = false;
            this.btnThongKeDoanhThuPhim.Click += new System.EventHandler(this.btnThongKePhim_Click);
            // 
            // pnlQuanLyPhim
            // 
            this.pnlQuanLyPhim.Controls.Add(this.lblQuanLyPhim);
            this.pnlQuanLyPhim.Controls.Add(this.btnThongKePhim);
            this.pnlQuanLyPhim.Controls.Add(this.grbQuanLyPhim);
            this.pnlQuanLyPhim.Controls.Add(this.dgvQuanLyPhim);
            this.pnlQuanLyPhim.Location = new System.Drawing.Point(53, 2);
            this.pnlQuanLyPhim.Name = "pnlQuanLyPhim";
            this.pnlQuanLyPhim.Size = new System.Drawing.Size(913, 545);
            this.pnlQuanLyPhim.TabIndex = 0;
            this.pnlQuanLyPhim.Visible = false;
            // 
            // lblQuanLyPhim
            // 
            this.lblQuanLyPhim.AutoSize = true;
            this.lblQuanLyPhim.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyPhim.Location = new System.Drawing.Point(363, 21);
            this.lblQuanLyPhim.Name = "lblQuanLyPhim";
            this.lblQuanLyPhim.Size = new System.Drawing.Size(214, 29);
            this.lblQuanLyPhim.TabIndex = 7;
            this.lblQuanLyPhim.Text = "QUẢN LÝ PHIM";
            // 
            // btnThongKePhim
            // 
            this.btnThongKePhim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongKePhim.Location = new System.Drawing.Point(493, 479);
            this.btnThongKePhim.Name = "btnThongKePhim";
            this.btnThongKePhim.Size = new System.Drawing.Size(75, 23);
            this.btnThongKePhim.TabIndex = 6;
            this.btnThongKePhim.Text = "In Báo Cáo";
            this.btnThongKePhim.UseVisualStyleBackColor = false;
            this.btnThongKePhim.Click += new System.EventHandler(this.btnThongKePhim_Click);
            // 
            // grbQuanLyPhim
            // 
            this.grbQuanLyPhim.Controls.Add(this.btnPhimDel);
            this.grbQuanLyPhim.Controls.Add(this.btnPhimUpdate);
            this.grbQuanLyPhim.Controls.Add(this.btnPosterAdd);
            this.grbQuanLyPhim.Controls.Add(this.btnShowdgvPhim);
            this.grbQuanLyPhim.Controls.Add(this.btnPhimAdd);
            this.grbQuanLyPhim.Controls.Add(this.dtpNgayKetThuc);
            this.grbQuanLyPhim.Controls.Add(this.dtpNgayKhoiChieu);
            this.grbQuanLyPhim.Controls.Add(this.cmbTheLoai);
            this.grbQuanLyPhim.Controls.Add(this.txtTongChiPhi);
            this.grbQuanLyPhim.Controls.Add(this.txtThoiLuong);
            this.grbQuanLyPhim.Controls.Add(this.txtTenPhim);
            this.grbQuanLyPhim.Controls.Add(this.txtMaPhim);
            this.grbQuanLyPhim.Controls.Add(this.lblPosterPhim);
            this.grbQuanLyPhim.Controls.Add(this.lblTongChiPhi);
            this.grbQuanLyPhim.Controls.Add(this.lblThoiLuong);
            this.grbQuanLyPhim.Controls.Add(this.lblNgayKetThuc);
            this.grbQuanLyPhim.Controls.Add(this.lblNgayKhoiChieu);
            this.grbQuanLyPhim.Controls.Add(this.lblTheLoai);
            this.grbQuanLyPhim.Controls.Add(this.lblTenPhim);
            this.grbQuanLyPhim.Controls.Add(this.lblMaPhim);
            this.grbQuanLyPhim.Controls.Add(this.ptbPosterPhim);
            this.grbQuanLyPhim.Location = new System.Drawing.Point(573, 70);
            this.grbQuanLyPhim.Name = "grbQuanLyPhim";
            this.grbQuanLyPhim.Size = new System.Drawing.Size(336, 403);
            this.grbQuanLyPhim.TabIndex = 1;
            this.grbQuanLyPhim.TabStop = false;
            this.grbQuanLyPhim.Text = "Thông tin phim";
            // 
            // btnPhimDel
            // 
            this.btnPhimDel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhimDel.Location = new System.Drawing.Point(253, 376);
            this.btnPhimDel.Name = "btnPhimDel";
            this.btnPhimDel.Size = new System.Drawing.Size(75, 23);
            this.btnPhimDel.TabIndex = 5;
            this.btnPhimDel.Text = "Xóa";
            this.btnPhimDel.UseVisualStyleBackColor = false;
            this.btnPhimDel.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnPhimUpdate
            // 
            this.btnPhimUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhimUpdate.Location = new System.Drawing.Point(172, 376);
            this.btnPhimUpdate.Name = "btnPhimUpdate";
            this.btnPhimUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnPhimUpdate.TabIndex = 5;
            this.btnPhimUpdate.Text = "Sửa";
            this.btnPhimUpdate.UseVisualStyleBackColor = false;
            this.btnPhimUpdate.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnPosterAdd
            // 
            this.btnPosterAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPosterAdd.Location = new System.Drawing.Point(41, 281);
            this.btnPosterAdd.Name = "btnPosterAdd";
            this.btnPosterAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPosterAdd.TabIndex = 5;
            this.btnPosterAdd.Text = "Chọn Hình";
            this.btnPosterAdd.UseVisualStyleBackColor = false;
            this.btnPosterAdd.Click += new System.EventHandler(this.btnPosterAdd_Click);
            // 
            // btnShowdgvPhim
            // 
            this.btnShowdgvPhim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShowdgvPhim.Location = new System.Drawing.Point(8, 376);
            this.btnShowdgvPhim.Name = "btnShowdgvPhim";
            this.btnShowdgvPhim.Size = new System.Drawing.Size(75, 23);
            this.btnShowdgvPhim.TabIndex = 5;
            this.btnShowdgvPhim.Text = "Show List";
            this.btnShowdgvPhim.UseVisualStyleBackColor = false;
            this.btnShowdgvPhim.Click += new System.EventHandler(this.btnShowdgvPhim_Click);
            // 
            // btnPhimAdd
            // 
            this.btnPhimAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhimAdd.Location = new System.Drawing.Point(89, 376);
            this.btnPhimAdd.Name = "btnPhimAdd";
            this.btnPhimAdd.Size = new System.Drawing.Size(75, 23);
            this.btnPhimAdd.TabIndex = 5;
            this.btnPhimAdd.Text = "Thêm";
            this.btnPhimAdd.UseVisualStyleBackColor = false;
            this.btnPhimAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(146, 148);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(182, 20);
            this.dtpNgayKetThuc.TabIndex = 4;
            // 
            // dtpNgayKhoiChieu
            // 
            this.dtpNgayKhoiChieu.Location = new System.Drawing.Point(146, 113);
            this.dtpNgayKhoiChieu.Name = "dtpNgayKhoiChieu";
            this.dtpNgayKhoiChieu.Size = new System.Drawing.Size(183, 20);
            this.dtpNgayKhoiChieu.TabIndex = 4;
            // 
            // cmbTheLoai
            // 
            this.cmbTheLoai.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTheLoai.FormattingEnabled = true;
            this.cmbTheLoai.Location = new System.Drawing.Point(146, 83);
            this.cmbTheLoai.Name = "cmbTheLoai";
            this.cmbTheLoai.Size = new System.Drawing.Size(121, 21);
            this.cmbTheLoai.TabIndex = 3;
            // 
            // txtTongChiPhi
            // 
            this.txtTongChiPhi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongChiPhi.Location = new System.Drawing.Point(146, 215);
            this.txtTongChiPhi.Name = "txtTongChiPhi";
            this.txtTongChiPhi.Size = new System.Drawing.Size(100, 20);
            this.txtTongChiPhi.TabIndex = 2;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtThoiLuong.Location = new System.Drawing.Point(146, 184);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(100, 20);
            this.txtThoiLuong.TabIndex = 2;
            // 
            // txtTenPhim
            // 
            this.txtTenPhim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenPhim.Location = new System.Drawing.Point(146, 50);
            this.txtTenPhim.Name = "txtTenPhim";
            this.txtTenPhim.Size = new System.Drawing.Size(100, 20);
            this.txtTenPhim.TabIndex = 2;
            // 
            // txtMaPhim
            // 
            this.txtMaPhim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaPhim.Location = new System.Drawing.Point(146, 18);
            this.txtMaPhim.Name = "txtMaPhim";
            this.txtMaPhim.Size = new System.Drawing.Size(100, 20);
            this.txtMaPhim.TabIndex = 2;
            // 
            // lblPosterPhim
            // 
            this.lblPosterPhim.AutoSize = true;
            this.lblPosterPhim.Location = new System.Drawing.Point(39, 248);
            this.lblPosterPhim.Name = "lblPosterPhim";
            this.lblPosterPhim.Size = new System.Drawing.Size(63, 13);
            this.lblPosterPhim.TabIndex = 1;
            this.lblPosterPhim.Text = "Poster Phim";
            // 
            // lblTongChiPhi
            // 
            this.lblTongChiPhi.AutoSize = true;
            this.lblTongChiPhi.Location = new System.Drawing.Point(39, 219);
            this.lblTongChiPhi.Name = "lblTongChiPhi";
            this.lblTongChiPhi.Size = new System.Drawing.Size(70, 13);
            this.lblTongChiPhi.TabIndex = 1;
            this.lblTongChiPhi.Text = "Tổng Chi Phí";
            // 
            // lblThoiLuong
            // 
            this.lblThoiLuong.AutoSize = true;
            this.lblThoiLuong.Location = new System.Drawing.Point(39, 188);
            this.lblThoiLuong.Name = "lblThoiLuong";
            this.lblThoiLuong.Size = new System.Drawing.Size(61, 13);
            this.lblThoiLuong.TabIndex = 1;
            this.lblThoiLuong.Text = "Thời Lượng";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(39, 154);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(79, 13);
            this.lblNgayKetThuc.TabIndex = 1;
            this.lblNgayKetThuc.Text = "Ngày Kết Thúc";
            // 
            // lblNgayKhoiChieu
            // 
            this.lblNgayKhoiChieu.AutoSize = true;
            this.lblNgayKhoiChieu.Location = new System.Drawing.Point(39, 119);
            this.lblNgayKhoiChieu.Name = "lblNgayKhoiChieu";
            this.lblNgayKhoiChieu.Size = new System.Drawing.Size(86, 13);
            this.lblNgayKhoiChieu.TabIndex = 1;
            this.lblNgayKhoiChieu.Text = "Ngày Khởi Chiếu";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(38, 86);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(49, 13);
            this.lblTheLoai.TabIndex = 1;
            this.lblTheLoai.Text = "Thể Loại";
            // 
            // lblTenPhim
            // 
            this.lblTenPhim.AutoSize = true;
            this.lblTenPhim.Location = new System.Drawing.Point(39, 53);
            this.lblTenPhim.Name = "lblTenPhim";
            this.lblTenPhim.Size = new System.Drawing.Size(52, 13);
            this.lblTenPhim.TabIndex = 1;
            this.lblTenPhim.Text = "Tên Phim";
            // 
            // lblMaPhim
            // 
            this.lblMaPhim.AutoSize = true;
            this.lblMaPhim.Location = new System.Drawing.Point(39, 21);
            this.lblMaPhim.Name = "lblMaPhim";
            this.lblMaPhim.Size = new System.Drawing.Size(48, 13);
            this.lblMaPhim.TabIndex = 1;
            this.lblMaPhim.Text = "Mã Phim";
            // 
            // ptbPosterPhim
            // 
            this.ptbPosterPhim.Location = new System.Drawing.Point(146, 245);
            this.ptbPosterPhim.Name = "ptbPosterPhim";
            this.ptbPosterPhim.Size = new System.Drawing.Size(163, 115);
            this.ptbPosterPhim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPosterPhim.TabIndex = 0;
            this.ptbPosterPhim.TabStop = false;
            // 
            // dgvQuanLyPhim
            // 
            this.dgvQuanLyPhim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyPhim.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhim,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvQuanLyPhim.Location = new System.Drawing.Point(15, 70);
            this.dgvQuanLyPhim.Name = "dgvQuanLyPhim";
            this.dgvQuanLyPhim.Size = new System.Drawing.Size(553, 403);
            this.dgvQuanLyPhim.TabIndex = 0;
            this.dgvQuanLyPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyPhim_CellClick);
            this.dgvQuanLyPhim.SelectionChanged += new System.EventHandler(this.dgvQuanLyPhim_SelectionChanged);
            // 
            // MaPhim
            // 
            this.MaPhim.HeaderText = "Mã phim";
            this.MaPhim.Name = "MaPhim";
            this.MaPhim.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên phim";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thể loại";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày khởi chiếu";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Ngày kết thúc";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Thời lượng";
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tổng chi phí";
            this.Column7.Name = "Column7";
            this.Column7.Width = 70;
            // 
            // pnlLichChieu
            // 
            this.pnlLichChieu.Controls.Add(this.lblQuanLyLichChieu);
            this.pnlLichChieu.Controls.Add(this.btnThongKeLichChieu);
            this.pnlLichChieu.Controls.Add(this.grbThongTinLichChieu);
            this.pnlLichChieu.Controls.Add(this.dgvLichChieu);
            this.pnlLichChieu.Location = new System.Drawing.Point(50, 5);
            this.pnlLichChieu.Name = "pnlLichChieu";
            this.pnlLichChieu.Size = new System.Drawing.Size(915, 545);
            this.pnlLichChieu.TabIndex = 4;
            this.pnlLichChieu.Visible = false;
            // 
            // lblQuanLyLichChieu
            // 
            this.lblQuanLyLichChieu.AutoSize = true;
            this.lblQuanLyLichChieu.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLyLichChieu.Location = new System.Drawing.Point(322, 21);
            this.lblQuanLyLichChieu.Name = "lblQuanLyLichChieu";
            this.lblQuanLyLichChieu.Size = new System.Drawing.Size(298, 29);
            this.lblQuanLyLichChieu.TabIndex = 3;
            this.lblQuanLyLichChieu.Text = "QUẢN LÝ LỊCH CHIẾU";
            // 
            // btnThongKeLichChieu
            // 
            this.btnThongKeLichChieu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnThongKeLichChieu.Location = new System.Drawing.Point(509, 368);
            this.btnThongKeLichChieu.Name = "btnThongKeLichChieu";
            this.btnThongKeLichChieu.Size = new System.Drawing.Size(75, 23);
            this.btnThongKeLichChieu.TabIndex = 2;
            this.btnThongKeLichChieu.Text = "In Báo Cáo";
            this.btnThongKeLichChieu.UseVisualStyleBackColor = false;
            this.btnThongKeLichChieu.Click += new System.EventHandler(this.btnThongKePhim_Click);
            // 
            // grbThongTinLichChieu
            // 
            this.grbThongTinLichChieu.Controls.Add(this.btnLcDelete);
            this.grbThongTinLichChieu.Controls.Add(this.btnLcUpdate);
            this.grbThongTinLichChieu.Controls.Add(this.btnLcAdd);
            this.grbThongTinLichChieu.Controls.Add(this.btndgvLichChieuShowList);
            this.grbThongTinLichChieu.Controls.Add(this.cmbTenPhongLC);
            this.grbThongTinLichChieu.Controls.Add(this.txtGiaVeLC);
            this.grbThongTinLichChieu.Controls.Add(this.dtpNgayChieuLC);
            this.grbThongTinLichChieu.Controls.Add(this.cmbGioChieuLC);
            this.grbThongTinLichChieu.Controls.Add(this.cmbMaRapLC);
            this.grbThongTinLichChieu.Controls.Add(this.lblGiaVe);
            this.grbThongTinLichChieu.Controls.Add(this.cmbTenPhimLC);
            this.grbThongTinLichChieu.Controls.Add(this.txtMaShow);
            this.grbThongTinLichChieu.Controls.Add(this.lblGioChieu);
            this.grbThongTinLichChieu.Controls.Add(this.lblTenPhimLC);
            this.grbThongTinLichChieu.Controls.Add(this.lblNgayChieu);
            this.grbThongTinLichChieu.Controls.Add(this.lblMaRapLC);
            this.grbThongTinLichChieu.Controls.Add(this.lblMaShow);
            this.grbThongTinLichChieu.Controls.Add(this.lblTenPhong);
            this.grbThongTinLichChieu.Location = new System.Drawing.Point(586, 70);
            this.grbThongTinLichChieu.Name = "grbThongTinLichChieu";
            this.grbThongTinLichChieu.Size = new System.Drawing.Size(326, 292);
            this.grbThongTinLichChieu.TabIndex = 1;
            this.grbThongTinLichChieu.TabStop = false;
            this.grbThongTinLichChieu.Text = "Thông tin lịch chiếu";
            // 
            // btnLcDelete
            // 
            this.btnLcDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLcDelete.Location = new System.Drawing.Point(251, 259);
            this.btnLcDelete.Name = "btnLcDelete";
            this.btnLcDelete.Size = new System.Drawing.Size(75, 23);
            this.btnLcDelete.TabIndex = 13;
            this.btnLcDelete.Text = "Xóa";
            this.btnLcDelete.UseVisualStyleBackColor = false;
            this.btnLcDelete.Click += new System.EventHandler(this.btnLcDelete_Click);
            // 
            // btnLcUpdate
            // 
            this.btnLcUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLcUpdate.Location = new System.Drawing.Point(169, 259);
            this.btnLcUpdate.Name = "btnLcUpdate";
            this.btnLcUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnLcUpdate.TabIndex = 12;
            this.btnLcUpdate.Text = "Sứa";
            this.btnLcUpdate.UseVisualStyleBackColor = false;
            this.btnLcUpdate.Click += new System.EventHandler(this.btnLcUpdate_Click);
            // 
            // btnLcAdd
            // 
            this.btnLcAdd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLcAdd.Location = new System.Drawing.Point(88, 259);
            this.btnLcAdd.Name = "btnLcAdd";
            this.btnLcAdd.Size = new System.Drawing.Size(75, 23);
            this.btnLcAdd.TabIndex = 11;
            this.btnLcAdd.Text = "Thêm";
            this.btnLcAdd.UseVisualStyleBackColor = false;
            this.btnLcAdd.Click += new System.EventHandler(this.btnLcAdd_Click);
            // 
            // btndgvLichChieuShowList
            // 
            this.btndgvLichChieuShowList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btndgvLichChieuShowList.Location = new System.Drawing.Point(7, 259);
            this.btndgvLichChieuShowList.Name = "btndgvLichChieuShowList";
            this.btndgvLichChieuShowList.Size = new System.Drawing.Size(75, 23);
            this.btndgvLichChieuShowList.TabIndex = 10;
            this.btndgvLichChieuShowList.Text = "Show List";
            this.btndgvLichChieuShowList.UseVisualStyleBackColor = false;
            this.btndgvLichChieuShowList.Click += new System.EventHandler(this.btndgvLichChieuShowList_Click);
            // 
            // cmbTenPhongLC
            // 
            this.cmbTenPhongLC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTenPhongLC.FormattingEnabled = true;
            this.cmbTenPhongLC.Location = new System.Drawing.Point(93, 120);
            this.cmbTenPhongLC.Name = "cmbTenPhongLC";
            this.cmbTenPhongLC.Size = new System.Drawing.Size(121, 21);
            this.cmbTenPhongLC.TabIndex = 9;
            // 
            // txtGiaVeLC
            // 
            this.txtGiaVeLC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiaVeLC.Location = new System.Drawing.Point(93, 228);
            this.txtGiaVeLC.Name = "txtGiaVeLC";
            this.txtGiaVeLC.Size = new System.Drawing.Size(121, 20);
            this.txtGiaVeLC.TabIndex = 8;
            // 
            // dtpNgayChieuLC
            // 
            this.dtpNgayChieuLC.Location = new System.Drawing.Point(93, 156);
            this.dtpNgayChieuLC.Name = "dtpNgayChieuLC";
            this.dtpNgayChieuLC.Size = new System.Drawing.Size(183, 20);
            this.dtpNgayChieuLC.TabIndex = 5;
            // 
            // cmbGioChieuLC
            // 
            this.cmbGioChieuLC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbGioChieuLC.FormattingEnabled = true;
            this.cmbGioChieuLC.Location = new System.Drawing.Point(93, 197);
            this.cmbGioChieuLC.Name = "cmbGioChieuLC";
            this.cmbGioChieuLC.Size = new System.Drawing.Size(121, 21);
            this.cmbGioChieuLC.TabIndex = 4;
            // 
            // cmbMaRapLC
            // 
            this.cmbMaRapLC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbMaRapLC.FormattingEnabled = true;
            this.cmbMaRapLC.Location = new System.Drawing.Point(93, 89);
            this.cmbMaRapLC.Name = "cmbMaRapLC";
            this.cmbMaRapLC.Size = new System.Drawing.Size(121, 21);
            this.cmbMaRapLC.TabIndex = 3;
            this.cmbMaRapLC.SelectedIndexChanged += new System.EventHandler(this.cmbMaRapLC_SelectedIndexChanged);
            // 
            // lblGiaVe
            // 
            this.lblGiaVe.AutoSize = true;
            this.lblGiaVe.Location = new System.Drawing.Point(23, 232);
            this.lblGiaVe.Name = "lblGiaVe";
            this.lblGiaVe.Size = new System.Drawing.Size(39, 13);
            this.lblGiaVe.TabIndex = 0;
            this.lblGiaVe.Text = "Giá Vé";
            // 
            // cmbTenPhimLC
            // 
            this.cmbTenPhimLC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTenPhimLC.FormattingEnabled = true;
            this.cmbTenPhimLC.Location = new System.Drawing.Point(93, 57);
            this.cmbTenPhimLC.Name = "cmbTenPhimLC";
            this.cmbTenPhimLC.Size = new System.Drawing.Size(121, 21);
            this.cmbTenPhimLC.TabIndex = 2;
            // 
            // txtMaShow
            // 
            this.txtMaShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaShow.Location = new System.Drawing.Point(93, 27);
            this.txtMaShow.Name = "txtMaShow";
            this.txtMaShow.Size = new System.Drawing.Size(121, 20);
            this.txtMaShow.TabIndex = 1;
            // 
            // lblGioChieu
            // 
            this.lblGioChieu.AutoSize = true;
            this.lblGioChieu.Location = new System.Drawing.Point(23, 195);
            this.lblGioChieu.Name = "lblGioChieu";
            this.lblGioChieu.Size = new System.Drawing.Size(53, 13);
            this.lblGioChieu.TabIndex = 0;
            this.lblGioChieu.Text = "Giờ Chiếu";
            // 
            // lblTenPhimLC
            // 
            this.lblTenPhimLC.AutoSize = true;
            this.lblTenPhimLC.Location = new System.Drawing.Point(23, 58);
            this.lblTenPhimLC.Name = "lblTenPhimLC";
            this.lblTenPhimLC.Size = new System.Drawing.Size(52, 13);
            this.lblTenPhimLC.TabIndex = 0;
            this.lblTenPhimLC.Text = "Tên Phim";
            // 
            // lblNgayChieu
            // 
            this.lblNgayChieu.AutoSize = true;
            this.lblNgayChieu.Location = new System.Drawing.Point(23, 157);
            this.lblNgayChieu.Name = "lblNgayChieu";
            this.lblNgayChieu.Size = new System.Drawing.Size(62, 13);
            this.lblNgayChieu.TabIndex = 0;
            this.lblNgayChieu.Text = "Ngày Chiếu";
            // 
            // lblMaRapLC
            // 
            this.lblMaRapLC.AutoSize = true;
            this.lblMaRapLC.Location = new System.Drawing.Point(23, 92);
            this.lblMaRapLC.Name = "lblMaRapLC";
            this.lblMaRapLC.Size = new System.Drawing.Size(45, 13);
            this.lblMaRapLC.TabIndex = 0;
            this.lblMaRapLC.Text = "Mã Rạp";
            // 
            // lblMaShow
            // 
            this.lblMaShow.AutoSize = true;
            this.lblMaShow.Location = new System.Drawing.Point(23, 27);
            this.lblMaShow.Name = "lblMaShow";
            this.lblMaShow.Size = new System.Drawing.Size(52, 13);
            this.lblMaShow.TabIndex = 0;
            this.lblMaShow.Text = "Mã Show";
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.AutoSize = true;
            this.lblTenPhong.Location = new System.Drawing.Point(23, 122);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(60, 13);
            this.lblTenPhong.TabIndex = 0;
            this.lblTenPhong.Text = "Tên Phòng";
            // 
            // dgvLichChieu
            // 
            this.dgvLichChieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichChieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaShow,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dgvLichChieu.Location = new System.Drawing.Point(11, 70);
            this.dgvLichChieu.Name = "dgvLichChieu";
            this.dgvLichChieu.Size = new System.Drawing.Size(573, 292);
            this.dgvLichChieu.TabIndex = 0;
            this.dgvLichChieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichChieu_CellClick);
            // 
            // MaShow
            // 
            this.MaShow.HeaderText = "Mã Show";
            this.MaShow.Name = "MaShow";
            this.MaShow.Width = 50;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tên Phim";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Mã Rạp";
            this.Column10.Name = "Column10";
            this.Column10.Width = 60;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Tên Phòng";
            this.Column11.Name = "Column11";
            this.Column11.Width = 60;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Ngày Chiếu";
            this.Column12.Name = "Column12";
            this.Column12.Width = 80;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Giờ Chiếu";
            this.Column13.Name = "Column13";
            this.Column13.Width = 90;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Giá Vé";
            this.Column14.Name = "Column14";
            this.Column14.Width = 90;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.BackgroundImage = global::UInvcapcao.Properties.Resources.logowithwords;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(994, 479);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.pnlNhanVien);
            this.Controls.Add(this.pnlQuanLyPhim);
            this.Controls.Add(this.pnlLichChieu);
            this.Controls.Add(this.pnlThongKe);
            this.DoubleBuffered = true;
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.panel2.ResumeLayout(false);
            this.pnlNhanVien.ResumeLayout(false);
            this.pnlNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNvData)).EndInit();
            this.pnlNvUpdate.ResumeLayout(false);
            this.pnlNvUpdate.PerformLayout();
            this.pnlNvAddDetails.ResumeLayout(false);
            this.pnlNvAddDetails.PerformLayout();
            this.pnlNvDel.ResumeLayout(false);
            this.pnlNvDel.PerformLayout();
            this.pnlThongKe.ResumeLayout(false);
            this.pnlThongKe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuRap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThuPhim)).EndInit();
            this.pnlQuanLyPhim.ResumeLayout(false);
            this.pnlQuanLyPhim.PerformLayout();
            this.grbQuanLyPhim.ResumeLayout(false);
            this.grbQuanLyPhim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPosterPhim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhim)).EndInit();
            this.pnlLichChieu.ResumeLayout(false);
            this.pnlLichChieu.PerformLayout();
            this.grbThongTinLichChieu.ResumeLayout(false);
            this.grbThongTinLichChieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichChieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private Panel panel3;
        private Button btnPhim;
        private Panel panel4;
        private Button btnLichChieu;
        private Panel panel5;
        private Button btnNhanVien;
        private Panel panel6;
        private Button btnThongKe;
        private Panel panel7;
        private Button btnLogout;
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
        private DataGridView dgvNvData;
        private Button btnNvShowList;
        private Panel pnlNvAddDetails;
        private TextBox txtTenNV;
        private Label lblTenNhanVien;
        private TextBox txtLuong;
        private Label lblLuong;
        private TextBox txtMK;
        private Label lblMatKhau;
        private Button btnNvDelete;
        private Button btnNvUpdate;
        private Button btnNvAdd;
        private Button btnCancelAdd;
        private Button btnConfirmAdd;
        private TextBox txtMaRap;
        private Label lblMaRap;
        private Panel pnlNvDel;
        private Button btnCancelDel;
        private Button btnConfirmDel;
        private Panel pnlNvUpdate;
        private Label label3;
        private Label label2;
        private TextBox txtMaRapUpdate;
        private TextBox txtTenNVUpdate;
        private Label label6;
        private TextBox txtMKUpdate;
        private TextBox txtLuongUpdate;
        private Label label5;
        private Button btnNvCancelUpdate;
        private Button btnNvConfirmUpdate;
        private Label lblDelWarning2;
        private Label lblDelWarning1;
        private Panel pnlThongKe;
        private TextBox txtMaCN;
        private Label lblMaCN;
        private TextBox txtMaCNUpdate;
        private Label lblMaCNUpdate;
        private DataGridViewTextBoxColumn MaNV;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn MatKhauNV;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn Luong;
        private DataGridViewTextBoxColumn MaRap;
        private DataGridViewTextBoxColumn QuyenHan;
        private Panel pnlQuanLyPhim;
        private DataGridView dgvQuanLyPhim;
        private GroupBox grbQuanLyPhim;
        private Label lblNgayKhoiChieu;
        private Label lblTheLoai;
        private Label lblTenPhim;
        private Label lblMaPhim;
        private PictureBox ptbPosterPhim;
        private Label lblTongChiPhi;
        private Label lblThoiLuong;
        private Label lblNgayKetThuc;
        private DateTimePicker dtpNgayKhoiChieu;
        private ComboBox cmbTheLoai;
        private TextBox txtTongChiPhi;
        private TextBox txtThoiLuong;
        private TextBox txtTenPhim;
        private TextBox txtMaPhim;
        private DateTimePicker dtpNgayKetThuc;
        private Button btnPhimDel;
        private Button btnPhimUpdate;
        private Button btnPhimAdd;
        private Button btnPosterAdd;
        private Button btnShowdgvPhim;
        private Label lblPosterPhim;
        private Button btnThongKePhim;
        private Button btnThongKeNV;
        private Button btnThongKeDoanhThuPhim;
        private Button btnXuatDoanhThuPhim;
        private DataGridView dgvDoanhThuPhim;
        private Panel pnlLichChieu;
        private DataGridView dgvLichChieu;
        private GroupBox grbThongTinLichChieu;
        private Label lblMaShow;
        private DateTimePicker dtpNgayChieuLC;
        private ComboBox cmbGioChieuLC;
        private ComboBox cmbMaRapLC;
        private ComboBox cmbTenPhimLC;
        private TextBox txtMaShow;
        private Label lblTenPhimLC;
        private Label lblMaRapLC;
        private Label lblGiaVe;
        private Label lblGioChieu;
        private Label lblTenPhong;
        private Label lblNgayChieu;
        private TextBox txtGiaVeLC;
        private ComboBox cmbTenPhongLC;
        private Button btndgvLichChieuShowList;
        private Button btnLcAdd;
        private Button btnLcUpdate;
        private DataGridViewTextBoxColumn MaShow;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private Button btnLcDelete;
        private Button btnThongKeLichChieu;
        private DataGridViewTextBoxColumn MaPhim;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnXuatDoanhThuRap;
        private DataGridView dgvDoanhThuRap;
        private Button btnThongKeDoanhThuRap;
        private Label lblQuanLyPhim;
        private Label lblQuanLyLichChieu;
        private Label lblQuanLyNhanVien;
        private Label lblQuanLyDoanhThu;
        private Panel panel2;
        private Button btnUser;
        //       private Timer phimTimer;
    }
}


namespace UInvcapcao.Forms
{
    partial class frmVe
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
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.lblKachHang = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblPhieuDatVe = new System.Windows.Forms.Label();
            this.lblHTTT = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.TenPhim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioChieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaVe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(28, 21);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(64, 16);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số Phiếu:";
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(28, 61);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(66, 16);
            this.lblNgayDat.TabIndex = 0;
            this.lblNgayDat.Text = "Ngày Đặt:";
            // 
            // lblKachHang
            // 
            this.lblKachHang.AutoSize = true;
            this.lblKachHang.Location = new System.Drawing.Point(28, 185);
            this.lblKachHang.Name = "lblKachHang";
            this.lblKachHang.Size = new System.Drawing.Size(83, 16);
            this.lblKachHang.TabIndex = 0;
            this.lblKachHang.Text = "Khách Hàng:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(28, 259);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(37, 16);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "SĐT:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(766, 35);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(143, 16);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa Chỉ: B Talk Cinema";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(654, 259);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(72, 16);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblPhieuDatVe
            // 
            this.lblPhieuDatVe.AutoSize = true;
            this.lblPhieuDatVe.Location = new System.Drawing.Point(460, 88);
            this.lblPhieuDatVe.Name = "lblPhieuDatVe";
            this.lblPhieuDatVe.Size = new System.Drawing.Size(84, 16);
            this.lblPhieuDatVe.TabIndex = 0;
            this.lblPhieuDatVe.Text = "Phiếu Đặt Vé";
            // 
            // lblHTTT
            // 
            this.lblHTTT.AutoSize = true;
            this.lblHTTT.Location = new System.Drawing.Point(654, 185);
            this.lblHTTT.Name = "lblHTTT";
            this.lblHTTT.Size = new System.Drawing.Size(146, 16);
            this.lblHTTT.TabIndex = 0;
            this.lblHTTT.Text = "Hình Thức Thanh Toán:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(128, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(844, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 22);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(142, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(157, 22);
            this.textBox2.TabIndex = 3;
            // 
            // dgvVe
            // 
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhim,
            this.NgayChieu,
            this.GioChieu,
            this.Ghe,
            this.GiaVe});
            this.dgvVe.Location = new System.Drawing.Point(2, 302);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.RowHeadersWidth = 51;
            this.dgvVe.RowTemplate.Height = 24;
            this.dgvVe.Size = new System.Drawing.Size(1042, 213);
            this.dgvVe.TabIndex = 4;
            // 
            // TenPhim
            // 
            this.TenPhim.HeaderText = "Tên Phim";
            this.TenPhim.MinimumWidth = 6;
            this.TenPhim.Name = "TenPhim";
            this.TenPhim.Width = 200;
            // 
            // NgayChieu
            // 
            this.NgayChieu.HeaderText = "Ngày Chiếu";
            this.NgayChieu.MinimumWidth = 6;
            this.NgayChieu.Name = "NgayChieu";
            this.NgayChieu.Width = 150;
            // 
            // GioChieu
            // 
            this.GioChieu.HeaderText = "Giờ Chiếu";
            this.GioChieu.MinimumWidth = 6;
            this.GioChieu.Name = "GioChieu";
            this.GioChieu.Width = 125;
            // 
            // Ghe
            // 
            this.Ghe.HeaderText = "Ghế";
            this.Ghe.MinimumWidth = 6;
            this.Ghe.Name = "Ghe";
            this.Ghe.Width = 125;
            // 
            // GiaVe
            // 
            this.GiaVe.HeaderText = "Giá Vé";
            this.GiaVe.MinimumWidth = 6;
            this.GiaVe.Name = "GiaVe";
            this.GiaVe.Width = 125;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(834, 532);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(929, 532);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(104, 23);
            this.btnHoanTat.TabIndex = 5;
            this.btnHoanTat.Text = "Hoàn Tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // frmVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblHTTT);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblPhieuDatVe);
            this.Controls.Add(this.lblKachHang);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblNgayDat);
            this.Controls.Add(this.lblSoPhieu);
            this.Name = "frmVe";
            this.Text = "Xuất Vé";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblKachHang;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblPhieuDatVe;
        private System.Windows.Forms.Label lblHTTT;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhim;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioChieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnHoanTat;
    }
}
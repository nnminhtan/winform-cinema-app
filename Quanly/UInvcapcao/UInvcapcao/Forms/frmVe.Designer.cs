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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVe));
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.lblNgayDat = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblPhieuDatVe = new System.Windows.Forms.Label();
            this.lblHTTT = new System.Windows.Forms.Label();
            this.cmbHTTT = new System.Windows.Forms.ComboBox();
            this.dgvVe = new System.Windows.Forms.DataGridView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnHoanTat = new System.Windows.Forms.Button();
            this.lblTongTienShow = new System.Windows.Forms.Label();
            this.lblNgayDatShow = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenPhimShow = new System.Windows.Forms.Label();
            this.lblPhongChieu = new System.Windows.Forms.Label();
            this.lblPhongChieuShow = new System.Windows.Forms.Label();
            this.lblMaVeShow = new System.Windows.Forms.Label();
            this.lblGioChieu = new System.Windows.Forms.Label();
            this.lblGioChieuShow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(21, 17);
            this.lblSoPhieu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(41, 13);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Mã Vé:";
            // 
            // lblNgayDat
            // 
            this.lblNgayDat.AutoSize = true;
            this.lblNgayDat.Location = new System.Drawing.Point(21, 50);
            this.lblNgayDat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayDat.Name = "lblNgayDat";
            this.lblNgayDat.Size = new System.Drawing.Size(55, 13);
            this.lblNgayDat.TabIndex = 0;
            this.lblNgayDat.Text = "Ngày Đặt:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(349, 17);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(116, 13);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa Chỉ: B Talk Cinema";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(21, 240);
            this.lblTongTien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(59, 13);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblPhieuDatVe
            // 
            this.lblPhieuDatVe.AutoSize = true;
            this.lblPhieuDatVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhieuDatVe.Location = new System.Drawing.Point(179, 84);
            this.lblPhieuDatVe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhieuDatVe.Name = "lblPhieuDatVe";
            this.lblPhieuDatVe.Size = new System.Drawing.Size(152, 29);
            this.lblPhieuDatVe.TabIndex = 0;
            this.lblPhieuDatVe.Text = "Phiếu Đặt Vé";
            // 
            // lblHTTT
            // 
            this.lblHTTT.AutoSize = true;
            this.lblHTTT.Location = new System.Drawing.Point(349, 138);
            this.lblHTTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHTTT.Name = "lblHTTT";
            this.lblHTTT.Size = new System.Drawing.Size(122, 13);
            this.lblHTTT.TabIndex = 0;
            this.lblHTTT.Text = "Hình Thức Thanh Toán:";
            // 
            // cmbHTTT
            // 
            this.cmbHTTT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbHTTT.FormattingEnabled = true;
            this.cmbHTTT.Items.AddRange(new object[] {
            "Thẻ",
            "Tiền Mặt"});
            this.cmbHTTT.Location = new System.Drawing.Point(350, 160);
            this.cmbHTTT.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHTTT.Name = "cmbHTTT";
            this.cmbHTTT.Size = new System.Drawing.Size(121, 21);
            this.cmbHTTT.TabIndex = 2;
            // 
            // dgvVe
            // 
            this.dgvVe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVe.Location = new System.Drawing.Point(72, 298);
            this.dgvVe.Margin = new System.Windows.Forms.Padding(2);
            this.dgvVe.Name = "dgvVe";
            this.dgvVe.RowHeadersWidth = 51;
            this.dgvVe.RowTemplate.Height = 24;
            this.dgvVe.Size = new System.Drawing.Size(352, 173);
            this.dgvVe.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(275, 540);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(56, 19);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnHoanTat
            // 
            this.btnHoanTat.Location = new System.Drawing.Point(346, 540);
            this.btnHoanTat.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoanTat.Name = "btnHoanTat";
            this.btnHoanTat.Size = new System.Drawing.Size(78, 19);
            this.btnHoanTat.TabIndex = 5;
            this.btnHoanTat.Text = "Hoàn Tất";
            this.btnHoanTat.UseVisualStyleBackColor = true;
            this.btnHoanTat.Click += new System.EventHandler(this.btnHoanTat_Click);
            // 
            // lblTongTienShow
            // 
            this.lblTongTienShow.AutoSize = true;
            this.lblTongTienShow.Location = new System.Drawing.Point(118, 240);
            this.lblTongTienShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongTienShow.Name = "lblTongTienShow";
            this.lblTongTienShow.Size = new System.Drawing.Size(35, 13);
            this.lblTongTienShow.TabIndex = 6;
            this.lblTongTienShow.Text = "label1";
            // 
            // lblNgayDatShow
            // 
            this.lblNgayDatShow.AutoSize = true;
            this.lblNgayDatShow.Location = new System.Drawing.Point(85, 50);
            this.lblNgayDatShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayDatShow.Name = "lblNgayDatShow";
            this.lblNgayDatShow.Size = new System.Drawing.Size(35, 13);
            this.lblNgayDatShow.TabIndex = 6;
            this.lblNgayDatShow.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên Phim";
            // 
            // lblTenPhimShow
            // 
            this.lblTenPhimShow.AutoSize = true;
            this.lblTenPhimShow.Location = new System.Drawing.Point(118, 138);
            this.lblTenPhimShow.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenPhimShow.Name = "lblTenPhimShow";
            this.lblTenPhimShow.Size = new System.Drawing.Size(35, 13);
            this.lblTenPhimShow.TabIndex = 8;
            this.lblTenPhimShow.Text = "label5";
            // 
            // lblPhongChieu
            // 
            this.lblPhongChieu.AutoSize = true;
            this.lblPhongChieu.Location = new System.Drawing.Point(21, 172);
            this.lblPhongChieu.Name = "lblPhongChieu";
            this.lblPhongChieu.Size = new System.Drawing.Size(68, 13);
            this.lblPhongChieu.TabIndex = 9;
            this.lblPhongChieu.Text = "Phòng Chiếu";
            // 
            // lblPhongChieuShow
            // 
            this.lblPhongChieuShow.AutoSize = true;
            this.lblPhongChieuShow.Location = new System.Drawing.Point(118, 172);
            this.lblPhongChieuShow.Name = "lblPhongChieuShow";
            this.lblPhongChieuShow.Size = new System.Drawing.Size(19, 13);
            this.lblPhongChieuShow.TabIndex = 9;
            this.lblPhongChieuShow.Text = "pc";
            // 
            // lblMaVeShow
            // 
            this.lblMaVeShow.AutoSize = true;
            this.lblMaVeShow.Location = new System.Drawing.Point(85, 17);
            this.lblMaVeShow.Name = "lblMaVeShow";
            this.lblMaVeShow.Size = new System.Drawing.Size(35, 13);
            this.lblMaVeShow.TabIndex = 10;
            this.lblMaVeShow.Text = "label3";
            // 
            // lblGioChieu
            // 
            this.lblGioChieu.AutoSize = true;
            this.lblGioChieu.Location = new System.Drawing.Point(21, 206);
            this.lblGioChieu.Name = "lblGioChieu";
            this.lblGioChieu.Size = new System.Drawing.Size(53, 13);
            this.lblGioChieu.TabIndex = 11;
            this.lblGioChieu.Text = "Giờ Chiếu";
            // 
            // lblGioChieuShow
            // 
            this.lblGioChieuShow.AutoSize = true;
            this.lblGioChieuShow.Location = new System.Drawing.Point(118, 206);
            this.lblGioChieuShow.Name = "lblGioChieuShow";
            this.lblGioChieuShow.Size = new System.Drawing.Size(35, 13);
            this.lblGioChieuShow.TabIndex = 12;
            this.lblGioChieuShow.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UInvcapcao.Properties.Resources.logowithwords;
            this.pictureBox1.Location = new System.Drawing.Point(344, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(129, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(497, 601);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblGioChieuShow);
            this.Controls.Add(this.lblGioChieu);
            this.Controls.Add(this.lblMaVeShow);
            this.Controls.Add(this.lblPhongChieuShow);
            this.Controls.Add(this.lblPhongChieu);
            this.Controls.Add(this.lblTenPhimShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNgayDatShow);
            this.Controls.Add(this.lblTongTienShow);
            this.Controls.Add(this.btnHoanTat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.dgvVe);
            this.Controls.Add(this.cmbHTTT);
            this.Controls.Add(this.lblHTTT);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblPhieuDatVe);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblNgayDat);
            this.Controls.Add(this.lblSoPhieu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Vé";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmVe_FormClosing);
            this.Load += new System.EventHandler(this.frmVe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.Label lblNgayDat;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblPhieuDatVe;
        private System.Windows.Forms.Label lblHTTT;
        private System.Windows.Forms.ComboBox cmbHTTT;
        private System.Windows.Forms.DataGridView dgvVe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnHoanTat;
        private System.Windows.Forms.Label lblTongTienShow;
        private System.Windows.Forms.Label lblNgayDatShow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenPhimShow;
        private System.Windows.Forms.Label lblPhongChieu;
        private System.Windows.Forms.Label lblPhongChieuShow;
        private System.Windows.Forms.Label lblMaVeShow;
        private System.Windows.Forms.Label lblGioChieu;
        private System.Windows.Forms.Label lblGioChieuShow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace UInvcapcao
{
    public partial class frmQuanLy : Form
    {
        QUANLYRAPCHIEUPHIMEntities db = new QUANLYRAPCHIEUPHIMEntities();
        bool sidebarExpand;
        //       bool phimCollapse;
        public frmQuanLy()
        {
            InitializeComponent();
        }

        //void AddBinding()
        //{
        //    txtMaNV.DataBindings.Add(new Binding("Text", dgvData.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
        //    txtTenNV.DataBindings.Add(new Binding("Text", dgvData.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
        //    txtMK.DataBindings.Add(new Binding("Text", dgvData.DataSource, "MatKhauNV", true, DataSourceUpdateMode.Never));
        //    txtChucVu.DataBindings.Add(new Binding("Text", dgvData.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));
        //    txtLuong.DataBindings.Add(new Binding("Text", dgvData.DataSource, "Luong", true, DataSourceUpdateMode.Never));
        //    txtMaRap.DataBindings.Add(new Binding("Text", dgvData.DataSource, "MaRap", true, DataSourceUpdateMode.Never));
        //}

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            //set the minimum and maximum of sidebar panel

            if (sidebarExpand)
            {
                //if sidebar expand, minimize
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            //set timer interval to lowest 
            sidebarTimer.Start();
        }

        //private void phimTimer_Tick(object sender, EventArgs e)
        //{
        //    //if sidebar expand, minimize
        //    if (phimCollapse)
        //    {
        //        pnlPhim.Height += 30;
        //        if (pnlPhim.Height == pnlPhim.MaximumSize.Height)
        //        {
        //            phimCollapse = false;
        //            phimTimer.Stop();
        //        }
        //    }
        //    else
        //    {
        //        pnlPhim.Height -= 30;
        //        if (pnlPhim.Height == pnlPhim.MinimumSize.Height)
        //        {
        //            phimCollapse = true;
        //            phimTimer.Stop();
        //        }
        //    }
        //}

        //private void btnPhim_Click(object sender, EventArgs e)
        //{
        //    //set timer interval to lowest 
        //    phimTimer.Start();
        //}
        #region "nhanvien"
        private void RefreshNv()
        {
            List<tblNhanVien> dsnv = db.tblNhanViens.ToList();
            List<tblQuyenHan> dsqh = db.tblQuyenHans.ToList();
            BindGird(dsnv);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

            this.Close();
        }
     
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            //var result = db.tblNhanViens.Select(x => new { x.MaNV, x.TenNV, x.ChucVu, x.Luong, x.MaRap })
            //    .Where(x => x.ChucVu == "Nhân Viên").ToList();
            //dgvData.DataSource = result;
            ////AddBinding();
            try
            {
                List<tblNhanVien> dsnv = db.tblNhanViens.ToList();
                List<tblQuyenHan> dsqh = db.tblQuyenHans.ToList();
                BindGird(dsnv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BindGird(List<tblNhanVien> dsnv)
        {
            dgvNvData.Rows.Clear();
            foreach (var item in dsnv)
            {
                //bind data into the datagridview
                int index = dgvNvData.Rows.Add();
                dgvNvData.Rows[index].Cells[0].Value = item.MaNV;
                dgvNvData.Rows[index].Cells[1].Value = item.TenNV;
                dgvNvData.Rows[index].Cells[2].Value = item.MatKhauNV;
                dgvNvData.Rows[index].Cells[3].Value = item.ChucVu;
                dgvNvData.Rows[index].Cells[4].Value = item.Luong;
                dgvNvData.Rows[index].Cells[5].Value = item.MaRap;
                dgvNvData.Rows[index].Cells[6].Value = GetRelationshipPermissionId(item.MaNV);
            }
        }
        private int GetRelationshipPermissionId(string employeeId)
        {
            // Get the relationship permission from the database.
            var relationshipPermission = db.tblQuyenHans.FirstOrDefault(rp => rp.MaNV == employeeId);

            // If the relationship permission is null, then return 0.
            if (relationshipPermission == null)
            {
                return 0;
            }

            // Return the relationship permission ID.
            return relationshipPermission.MaChucNang;
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        { 
            pnlNhanVien.Visible = true;
            pnlQuanLyPhim.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlNvAddDetails.Visible = true;
            pnlNvDel.Visible = false;
            pnlNvUpdate.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlNvAddDetails.Visible = false;
            pnlNvDel.Visible = false;
            pnlNvUpdate.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlNvDel.Visible = true;
            pnlNvAddDetails.Visible = false;
            pnlNvUpdate.Visible = false;
        }
        //adding
        private void btnConfirmAdd_Click(object sender, EventArgs e)
        {
            //old
            ////create a nhan vien to add to the table
            //tblNhanVien nv = new tblNhanVien() { MaNV = (Ma01 + Ma02.ToString()),
            //    TenNV = txtTenNV.Text, MatKhauNV = txtMK.Text, ChucVu = txtChucVu.Text,
            //    Luong = Convert.ToInt32(txtLuong.Text), MaRap = txtMaRap.Text };
            //db.tblNhanViens.Add(nv);
            //db.SaveChanges();
            //string ID = GenerateID(txtMaCN.Text).ToString();
            int Ma01 = db.tblNhanViens.Select(x => x.ChucVu).Count() + 1;
            if (txtMaCN.Text == "1" || txtMaCN.Text == "2")
            {
                //new
                tblNhanVien nv = new tblNhanVien()
                {
                    MaNV = Ma01.ToString(), //adding the MaNV by counting the list and adding 1
                    TenNV = txtTenNV.Text,
                    MatKhauNV = txtMK.Text,
                    ChucVu = GetChucVu(txtMaCN.Text),
                    Luong = Convert.ToInt32(txtLuong.Text),
                    MaRap = txtMaRap.Text
                };
                int MaQuyen1 = db.tblQuyenHans.Select(x => x.MaQuyen).Count() + 1;
                tblQuyenHan qh = new tblQuyenHan()
                {
                    MaQuyen = MaQuyen1,
                    MaNV = Ma01.ToString(),
                    MaChucNang = Convert.ToInt32(txtMaCN.Text),

                };
                db.tblNhanViens.Add(nv);
                db.tblQuyenHans.Add(qh);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Sai dinh dang", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaCN.Clear();
                txtMaCN.Focus();
            }
            //clear txtbox
            txtMaCN.Clear();
            txtTenNV.Clear();
            txtMK.Clear();
            txtLuong.Clear();
            txtMaRap.Clear();
            pnlNvAddDetails.Visible = false;
            RefreshNv();
        }
        public string GetChucVu(string textCN)
        {
            string ChucVu;
            if(textCN == "1")
            {
                ChucVu = "Quản Lý";
                return ChucVu;
            }
            else
            {
                ChucVu = "Nhân Viên";
                return ChucVu;
            }
        }
        //not used
        //public string GenerateID(string text)
        //{
        //    while (text == "1" || text == "2") 
        //    {
        //        if (text == "2")
        //        {
        //            //string Ma01 = "NhanVien";
        //            //count the list of the nhan vien
        //            int Ma02 = db.tblNhanViens.Count(x => x.ChucVu.Equals("Nhân Viên", StringComparison.OrdinalIgnoreCase)) + 1;
        //            return (Ma02).ToString();
        //        }
        //        else
        //        {
        //            //string Ma01 = "QuanLy";
        //            //count the list of the nhan vien
        //            int Ma02 = db.tblNhanViens.Count(x => x.ChucVu.Equals("Quản Lý", StringComparison.OrdinalIgnoreCase)) + 1;
        //            return (Ma02).ToString();
        //        }
        //    }
        //    return "InvalidInput";
        //}
        private void btnCancelAdd_Click(object sender, EventArgs e)
        {
            pnlNvAddDetails.Visible = false;
        }

        private void btnConfirmDel_Click(object sender, EventArgs e)
        {
            //delete the nhanvien by the row that you select
            var rowData = dgvNvData.SelectedRows[0].Cells["MaNV"].Value.ToString();
            tblNhanVien nv = db.tblNhanViens.Find(rowData);
            tblQuyenHan qh = db.tblQuyenHans.SingleOrDefault(x => x.MaNV == nv.MaNV);

            db.tblQuyenHans.Remove(qh);
            db.tblNhanViens.Remove(nv);
            db.SaveChanges();
            pnlNvDel.Visible = false;
            RefreshNv();

            //foreach (DataGridViewRow item in dgvData.SelectedRows)
            //{
            //    dgvData.Rows.RemoveAt(item.Index);
            //}
        }

        private void btnCancelDel_Click(object sender, EventArgs e)
        {
            pnlNvDel.Visible = false;
        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            String id = (dgvNvData.SelectedRows[0].Cells["MaNV"].Value.ToString());
            tblNhanVien nv = db.tblNhanViens.Find(id);
            tblQuyenHan qh = db.tblQuyenHans.SingleOrDefault(x => x.MaNV == nv.MaNV);
            //if finded the nv
            if (nv != null)
            {
                nv.TenNV = txtTenNVUpdate.Text;
                nv.MatKhauNV = txtMKUpdate.Text;
                nv.ChucVu = GetChucVu(txtMaCNUpdate.Text);
                nv.Luong = Convert.ToInt32(txtLuongUpdate.Text);
                nv.TenNV = txtTenNVUpdate.Text;
                nv.MaRap = txtMaRapUpdate.Text;
                qh.MaChucNang = Convert.ToInt32(txtMaCNUpdate.Text);
                db.SaveChanges();
            }
            //txtbox clear
            txtMaCNUpdate.Clear();
            txtTenNVUpdate.Clear();
            txtMKUpdate.Clear();
            txtMaRapUpdate.Clear();
            txtLuongUpdate.Clear();
            pnlNvUpdate.Visible = false;
            RefreshNv();
        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlNvUpdate.Visible = false;
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            var indexAt = dgvNvData.CurrentCell.RowIndex;
        }
        #endregion "nhan vien"

        #region "thong ke"
        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }
        #endregion "thong ke"

        #region "phim"
        private void btnPhim_Click(object sender, EventArgs e)
        {
            pnlQuanLyPhim.Visible = true;
            List<tblTheLoai> dstl = db.tblTheLoais.ToList();
            FillGenreCombobox(dstl);
            pnlNhanVien.Visible = false;
        }
        private void FillGenreCombobox(List<tblTheLoai> listGenre)
        {
            this.cmbTheLoai.DataSource = listGenre;
            this.cmbTheLoai.DisplayMember = "TenTheLoai";
            this.cmbTheLoai.ValueMember = "MaTheLoai";
        }
        private void BindGirddgvPhim(List<tblPhim> dsp)
        {
            dgvQuanLyPhim.Rows.Clear();
            foreach (var item in dsp)
            {
                //bind data into the datagridview
                int index = dgvQuanLyPhim.Rows.Add();
                // Format the date value in day-month-year format.
                string ngayKhoiChieu = item.NgayKhoiChieu?.ToString("d", CultureInfo.InvariantCulture);
                string ngayKetThuc = item.NgayKetThuc?.ToString("d", CultureInfo.InvariantCulture);
                dgvQuanLyPhim.Rows[index].Cells[0].Value = item.MaPhim;
                dgvQuanLyPhim.Rows[index].Cells[1].Value = item.TenPhim;
                dgvQuanLyPhim.Rows[index].Cells[2].Value = item.tblTheLoai.TenTheLoai;
                dgvQuanLyPhim.Rows[index].Cells[3].Value = ngayKhoiChieu;
                dgvQuanLyPhim.Rows[index].Cells[4].Value = ngayKetThuc;
                dgvQuanLyPhim.Rows[index].Cells[5].Value = item.ThoiLuong;
                dgvQuanLyPhim.Rows[index].Cells[6].Value = item.TongChiPhi;
                dgvQuanLyPhim.Rows[index].Cells[7].Value = item.TongThu;
            }
        }

        private void btnShowdgvPhim_Click(object sender, EventArgs e)
        {
            List<tblPhim> dsp = db.tblPhims.ToList();
            BindGirddgvPhim(dsp);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maTheLoai = db.tblTheLoais.First(tl => tl.TenTheLoai == cmbTheLoai.Text).MaTheLoai;
            tblPhim ph = new tblPhim()
            {
                MaPhim = txtMaPhim.Text,
                TenPhim = txtTenPhim.Text,
                MaTheLoai = maTheLoai,
                NgayKhoiChieu = dtpNgayKhoiChieu.Value,
                NgayKetThuc = dtpNgayKetThuc.Value,
                ThoiLuong = txtThoiLuong.Text,
                TongChiPhi = Convert.ToInt32(txtTongChiPhi.Text),
                TongThu = Convert.ToInt32(txtTongThu.Text),
            };
            if (db.tblTheLoais.Find(ph.MaTheLoai) == null)
            {
                // The MaTheLoai column does not exist in the tblTheLoai table.
                // Show an error message to the user.
                MessageBox.Show("The selected genre does not exist. Please select a valid genre.");
                return;
            }
            db.tblPhims.Add(ph);
            db.SaveChanges();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rowData = dgvQuanLyPhim.SelectedRows[0].Cells["Column1"].Value.ToString();
            tblPhim p = db.tblPhims.Find(rowData);
            db.tblPhims.Remove(p);
            db.SaveChanges();
            MessageBox.Show("Xoa thanh cong");
        }

        private void dgvQuanLyPhim_SelectionChanged(object sender, EventArgs e)
        {
            var indexAt = dgvQuanLyPhim.CurrentCell.RowIndex;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maTheLoai = db.tblTheLoais.First(tl => tl.TenTheLoai == cmbTheLoai.Text).MaTheLoai;
            String id = (dgvQuanLyPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString());
            tblPhim p = db.tblPhims.Find(id);
            if (p != null)
            {
                p.TenPhim = txtTenPhim.Text;
                p.MaTheLoai = maTheLoai;
                p.NgayKhoiChieu = dtpNgayKhoiChieu.Value;
                p.NgayKetThuc = dtpNgayKetThuc.Value;
                p.ThoiLuong = txtThoiLuong.Text;
                p.TongChiPhi = Convert.ToInt32(txtTongChiPhi.Text);
                p.TongThu = Convert.ToInt32(txtTongThu.Text);
                db.SaveChanges();
            }
        }
        private void dgvQuanLyPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvQuanLyPhim.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtMaPhim.Text = row.Cells[0].Value.ToString();
                txtTenPhim.Text = row.Cells[1].Value.ToString();
                cmbTheLoai.Text = row.Cells[2].Value.ToString();
                // Try to parse the value of the NgayKhoiChieu cell to a DateTime object.
                DateTime ngayKhoiChieu;
                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out ngayKhoiChieu))
                {
                    dtpNgayKhoiChieu.Value = ngayKhoiChieu;
                }

                // Try to parse the value of the NgayKetThuc cell to a DateTime object.
                DateTime ngayKetThuc;
                if (DateTime.TryParse(row.Cells[4].Value.ToString(), out ngayKetThuc))
                {
                    dtpNgayKetThuc.Value = ngayKetThuc;
                }
                txtThoiLuong.Text = row.Cells[5].Value.ToString();
                txtTongChiPhi.Text = row.Cells[5].Value.ToString();
                txtTongThu.Text = row.Cells[5].Value.ToString();
            }
        }

        #endregion "phim"
    }
}

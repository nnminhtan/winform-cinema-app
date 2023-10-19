using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace UInvcapcao.Forms
{
    public partial class frmQuanLy : Form
    {
        QUANLYRAPCHIEUPHIMEntities db = new QUANLYRAPCHIEUPHIMEntities();
        bool sidebarExpand;
        public frmQuanLy()
        {
            InitializeComponent();
        }
        #region "sidebar"
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
        #endregion "sidebar"

        #region "Export to Excel"
        private void AddExcelColumnsNamePhim(Microsoft.Office.Interop.Excel.Worksheet oSheet)
        {
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Phim";
            cl1.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên Phim";
            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Thể Loại ";
            cl3.ColumnWidth = 19.5;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Ngày Khởi Chiếu";
            cl4.ColumnWidth = 22;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Ngày Kết Thúc";
            cl5.ColumnWidth = 20.5;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Thời Lượng";
            cl6.ColumnWidth = 22;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Tổng Chi Phí";
            cl7.ColumnWidth = 22;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void AddExcelColumnsNameNV(Microsoft.Office.Interop.Excel.Worksheet oSheet)
        {
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã NV";
            cl1.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên NV";
            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Chức Vụ";
            cl3.ColumnWidth = 12.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Lương";
            cl4.ColumnWidth = 22;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Mã Rạp";
            cl5.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void AddExcelColumnsNameDoanhThuPhim(Microsoft.Office.Interop.Excel.Worksheet oSheet)
        {
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã phim";
            cl1.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên Phim";
            cl2.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Số vé đã bán";
            cl3.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Tổng Tiền";
            cl4.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Lời/Lỗ";
            cl5.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }

        private void AddExcelColumnsNameLichChieu(Microsoft.Office.Interop.Excel.Worksheet oSheet)
        {
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Show";
            cl1.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên Phim";
            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Mã Rạp";
            cl3.ColumnWidth = 19.5;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "Tên Phòng";
            cl4.ColumnWidth = 22;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Ngày Chiếu";
            cl5.ColumnWidth = 20.5;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");
            cl6.Value2 = "Giờ Chiếu";
            cl6.ColumnWidth = 22;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");
            cl7.Value2 = "Giá Vé";
            cl7.ColumnWidth = 22;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        private void AddExcelColumnsNameDoanhThuRap(Microsoft.Office.Interop.Excel.Worksheet oSheet)
        {
            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");
            cl1.Value2 = "Mã Rạp";
            cl1.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");
            cl2.Value2 = "Tên Rạp";
            cl2.ColumnWidth = 25.0;
            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");
            cl3.Value2 = "Địa Chỉ";
            cl3.ColumnWidth = 12.0;
            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");
            cl4.Value2 = "SĐT";
            cl4.ColumnWidth = 22;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");
            cl5.Value2 = "Doanh Thu";
            cl5.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;
            // Thiết lập màu nền
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title, string obj)
        {
            //Tạo các đối tượng Excel
            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks oBooks;
            Microsoft.Office.Interop.Excel.Sheets oSheets;
            Microsoft.Office.Interop.Excel.Workbook oBook;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 
            oExcel.Visible = true;
            oExcel.DisplayAlerts = false;
            oExcel.Application.SheetsInNewWorkbook = 1;
            oBooks = oExcel.Workbooks;
            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));
            oSheets = oBook.Worksheets;
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);
            oSheet.Name = sheetName;

            //Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "20";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            //tìm tham số truyền vào để thêm tên cột của đúng datagridview đó  
            string decided = obj;
            if (decided == "phim")
            {
                AddExcelColumnsNamePhim(oSheet);
            }
            if (decided == "nv")
            {
                AddExcelColumnsNameNV(oSheet);
            }
            if (decided == "dtp")
            {
                AddExcelColumnsNameDoanhThuPhim(oSheet);
            }
            if (decided == "lc")
            {
                AddExcelColumnsNameLichChieu(oSheet);
            }
            if (decided == "dtr")
            {
                AddExcelColumnsNameDoanhThuRap(oSheet);
            }
            // Tạo mảng theo datatable
            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng
            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu
            int rowStart = 4;
            int columnStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu
            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập
            range.Value2 = arr;

            // Kẻ viền
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
        }
        #endregion "Export to Excel"

        #region "nhan vien"
        private void RefreshNv()
        {
            List<tblNhanVien> dsnv = db.tblNhanViens.ToList();
            List<tblQuyenHan> dsqh = db.tblQuyenHans.ToList();
            BindGriddgvNV(dsnv);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();

            this.Close();
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
                BindGriddgvNV(dsnv);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGriddgvNV(List<tblNhanVien> dsnv)
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
            pnlThongKe.Visible = false;
            pnlLichChieu.Visible = false;
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
            if (textCN == "1")
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
            pnlThongKe.Visible = true;
            pnlNhanVien.Visible = false;
            pnlQuanLyPhim.Visible = false;
            pnlLichChieu.Visible = false;
        }
        DataTable datatbl2 = new DataTable();
        private void btnXuatDoanhThuPhim_Click(object sender, EventArgs e)
        {
            // Create a new DataTable.
            //DataTable dataTable = new DataTable();
            // Add the columns to the DataTable.
            datatbl2.Columns.Add("MaPhim");
            datatbl2.Columns.Add("TenPhim");
            datatbl2.Columns.Add("SoVeDaBan");
            datatbl2.Columns.Add("TongTien");
            datatbl2.Columns.Add("Loi/Lo");

            // Write a LINQ query to join the two tables on the MaPhim column and group the results by MaPhim.
            var query = (from phim in db.tblPhims
                         join lichChieu in db.tblLichChieux on phim.MaPhim equals lichChieu.MaPhim
                         group lichChieu by phim.MaPhim
                        into g
                         select new
                         {
                             MaPhim = g.Key,
                             TenPhim = db.tblPhims.Where(x => x.MaPhim == g.Key).Select(p => p.TenPhim).FirstOrDefault(),
                             SoVeDaBan = g.Sum(x => x.SoVeDaBan),
                             TongTien = g.Sum(x => x.TongTien),
                             LoiLo = g.Sum(x => x.TongTien) - db.tblPhims.Where(x => x.MaPhim == g.Key).Select(p => p.TongChiPhi).FirstOrDefault(),
                         }).ToList();

            // Populate the DataTable with the results of the LINQ query.
            foreach (var item in query)
            {
                tblPhim p = db.tblPhims.Find(item.MaPhim);
                if (p != null)
                {
                    p.TongThu = item.TongTien;
                    db.SaveChanges();
                }
                DataRow row = datatbl2.NewRow();
                row["MaPhim"] = item.MaPhim;
                row["TenPhim"] = item.TenPhim;
                row["SoVeDaBan"] = item.SoVeDaBan;
                row["TongTien"] = item.TongTien;
                row["Loi/Lo"] = item.LoiLo;
                datatbl2.Rows.Add(row);
            }

            // Bind the DataTable to the DataGridView.
            dgvDoanhThuPhim.DataSource = datatbl2;
        }
        DataTable datatbl4 = new DataTable();
        private void btnXuatDoanhThuRap_Click(object sender, EventArgs e)
        {
            // Create a new DataTable.
            //DataTable dataTable = new DataTable();
            // Add the columns to the DataTable.
            datatbl4.Columns.Add("MaRap");
            datatbl4.Columns.Add("TenRap");
            datatbl4.Columns.Add("DiaChi");
            datatbl4.Columns.Add("SDT");
            datatbl4.Columns.Add("DoanhThu");
            // Write a LINQ query to join the two tables on the MaPhim column and group the results by MaPhim.
            var query = (from rap in db.tblRaps
                         join lichChieu in db.tblLichChieux on rap.MaRap equals lichChieu.MaRap
                         group lichChieu by rap.MaRap
                        into g
                         select new
                         {
                             MaRap = g.Key,
                             TenRap = db.tblRaps.Where(x => x.MaRap == g.Key).Select(p => p.TenRap).FirstOrDefault(),
                             DiaChi = db.tblRaps.Where(x => x.MaRap == g.Key).Select(p => p.DiaChi).FirstOrDefault(),
                             SDT = db.tblRaps.Where(x => x.MaRap == g.Key).Select(p => p.DienThoai).FirstOrDefault(),
                             DoanhThu = g.Sum(x => x.TongTien)
                         }).ToList();
            // Populate the DataTable with the results of the LINQ query.
            foreach (var item in query)
            {
                DataRow row = datatbl4.NewRow();
                row["MaRap"] = item.MaRap;
                row["TenRap"] = item.TenRap;
                row["DiaChi"] = item.DiaChi;
                row["SDT"] = item.SDT;
                row["DoanhThu"] = item.DoanhThu;
                datatbl4.Rows.Add(row);
            }
            // Bind the DataTable to the DataGridView.
            dgvDoanhThuRap.DataSource = datatbl4;
        }
        #endregion "thong ke"

        #region "phim"
        private void btnPhim_Click(object sender, EventArgs e)
        {
            pnlQuanLyPhim.Visible = true;
            List<tblTheLoai> dstl = db.tblTheLoais.ToList();
            FillGenreCombobox(dstl);
            pnlNhanVien.Visible = false;
            pnlThongKe.Visible = false;
            pnlLichChieu.Visible = false;
        }
        private void FillGenreCombobox(List<tblTheLoai> listGenre)
        {
            this.cmbTheLoai.DataSource = listGenre;
            this.cmbTheLoai.DisplayMember = "TenTheLoai";
            this.cmbTheLoai.ValueMember = "MaTheLoai";
        }
        private void BindGriddgvPhim(List<tblPhim> dsp)
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

            }
        }
        private void RefreshPhim()
        {
            List<tblTheLoai> dstl = db.tblTheLoais.ToList();
            List<tblPhim> dsp = db.tblPhims.ToList();
            FillGenreCombobox(dstl);
            BindGriddgvPhim(dsp);
        }
        private void btnShowdgvPhim_Click(object sender, EventArgs e)
        {
            List<tblPhim> dsp = db.tblPhims.ToList();
            BindGriddgvPhim(dsp);
            //Clear after click again
            txtMaPhim.Clear();
            txtTenPhim.Clear();
            List<tblTheLoai> dstl = db.tblTheLoais.ToList();
            FillGenreCombobox(dstl);
            dtpNgayKhoiChieu.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            txtThoiLuong.Clear();
            txtTongChiPhi.Clear();
            ptbPosterPhim.Image = null;
            RefreshPhim();
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
                Poster = imageBytes
            };
            //if (db.tblTheLoais.Find(ph.MaTheLoai) == null)
            //{
            //    // The MaTheLoai column does not exist in the tblTheLoai table.
            //    // Show an error message to the user.
            //    MessageBox.Show("The selected genre does not exist. Please select a valid genre.");
            //    return;
            //}
            // Get the MaPhim value of the new record.
            string maPhim = txtMaPhim.Text;
            // Check if there is already a record with the same MaPhim value.
            if (db.tblPhims.Any(p => p.MaPhim == maPhim))
            {
                // There is already a record with the same MaPhim value.
                // Show an error message to the user.
                MessageBox.Show("Đã có phim này rồi!");
            }
            else
            {
                db.tblPhims.Add(ph);
                db.SaveChanges();
                txtMaPhim.Clear();
                txtTenPhim.Clear();
                List<tblTheLoai> dstl = db.tblTheLoais.ToList();
                FillGenreCombobox(dstl);
                dtpNgayKhoiChieu.Value = DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                txtThoiLuong.Clear();
                txtTongChiPhi.Clear();
                ptbPosterPhim.Image = null;
                RefreshPhim();
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            var rowData = dgvQuanLyPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString();
            tblPhim p = db.tblPhims.Find(rowData);
            var lc = db.tblLichChieux.Where(x => x.MaPhim == p.MaPhim).ToList();
            DialogResult result = MessageBox.Show("Xóa phim sẽ đồng nghĩa với việc sẽ xóa hết lịch chiếu liên quan tới phim!" +
                " Có muốn xóa?", "Thông Báo Xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.tblPhims.Remove(p);
                db.tblLichChieux.RemoveRange(lc);
                db.SaveChanges();
                txtMaPhim.Clear();
                txtTenPhim.Clear();
                List<tblTheLoai> dstl = db.tblTheLoais.ToList();
                FillGenreCombobox(dstl);
                dtpNgayKhoiChieu.Value = DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                txtThoiLuong.Clear();
                txtTongChiPhi.Clear();
                ptbPosterPhim.Image = null;
                RefreshPhim();
            }
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
                p.Poster = imageBytes;
                db.SaveChanges();
                txtMaPhim.Clear();
                txtTenPhim.Clear();
                List<tblTheLoai> dstl = db.tblTheLoais.ToList();
                FillGenreCombobox(dstl);
                dtpNgayKhoiChieu.Value = DateTime.Now;
                dtpNgayKetThuc.Value = DateTime.Now;
                txtThoiLuong.Clear();
                txtTongChiPhi.Clear();
                ptbPosterPhim.Image = null;
                RefreshPhim();
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
                txtTongChiPhi.Text = row.Cells[6].Value.ToString();
                ptbPosterPhim.Image = null;
                // Get the phim object for the selected row.
                tblPhim p = db.tblPhims.Find(dgvQuanLyPhim.SelectedRows[0].Cells[0].Value);
                // If the phim has an image, display it in the picturebox.
                if (p.Poster != null)
                {
                    ptbPosterPhim.Image = new Bitmap(new MemoryStream(p.Poster));
                }
            }
        }
        byte[] imageBytes;
        private void btnPosterAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png,*.jpg,*.jpeg) |*.png;*.jpg;*.jpeg";

            // If the user selects an image, save it to the SQL table.
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the image bytes.
                imageBytes = File.ReadAllBytes(openFileDialog.FileName);

                // Save the image bytes to the SQL table.
                //string maTheLoai = db.tblTheLoais.First(tl => tl.TenTheLoai == cmbTheLoai.Text).MaTheLoai;
                //String id = (dgvQuanLyPhim.SelectedRows[0].Cells["MaPhim"].Value.ToString());
                //tblPhim p = db.tblPhims.Find(id);
                //if (p != null)
                //{
                //    p.Poster = imageBytes;
                //    db.SaveChanges();
                //}
                ptbPosterPhim.Image = new Bitmap(new MemoryStream(imageBytes));
            }
        }
        private void btnThongKePhim_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Name == "btnThongKePhim")
            {
                //Add columns to datatable
                List<tblPhim> dsp = db.tblPhims.ToList();
                BindGriddgvPhim(dsp);
                DataTable datatbl = new DataTable();
                DataColumn Col1 = new DataColumn("Mã Phim");
                DataColumn Col2 = new DataColumn("Tên Phim");
                DataColumn Col3 = new DataColumn("Thể Loại");
                DataColumn Col4 = new DataColumn("Ngày Khởi Chiếu");
                DataColumn Col5 = new DataColumn("Ngày Kết Thúc");
                DataColumn Col6 = new DataColumn("Thời Lượng");
                DataColumn Col7 = new DataColumn("Tổng Chi Phí");
                datatbl.Columns.Add(Col1);
                datatbl.Columns.Add(Col2);
                datatbl.Columns.Add(Col3);
                datatbl.Columns.Add(Col4);
                datatbl.Columns.Add(Col5);
                datatbl.Columns.Add(Col6);
                datatbl.Columns.Add(Col7);
                
                //Add rows to datatable
                foreach (DataGridViewRow dgvrow in dgvQuanLyPhim.Rows)
                {
                    DataRow dtrow = datatbl.NewRow();
                    dtrow[0] = dgvrow.Cells[0].Value;
                    dtrow[1] = dgvrow.Cells[1].Value;
                    dtrow[2] = dgvrow.Cells[2].Value;
                    dtrow[3] = dgvrow.Cells[3].Value;
                    dtrow[4] = dgvrow.Cells[4].Value;
                    dtrow[5] = dgvrow.Cells[5].Value;
                    dtrow[6] = dgvrow.Cells[6].Value;
                    datatbl.Rows.Add(dtrow);
                }
                ExportFile(datatbl, "phim", "Báo Cáo Phim", "phim");
            }
            else if (button.Name == "btnThongKeNV")
            {
                //Add columns to datatable
                List<tblNhanVien> dsnv = db.tblNhanViens.ToList();
                BindGriddgvNV(dsnv);
                DataTable datatbl1 = new DataTable();
                DataColumn Col1 = new DataColumn("Mã NV");
                DataColumn Col2 = new DataColumn("Tên NV");
                DataColumn Col3 = new DataColumn("Chức Vụ");
                DataColumn Col4 = new DataColumn("Lương");
                DataColumn Col5 = new DataColumn("Mã Rạp");
                datatbl1.Columns.Add(Col1);
                datatbl1.Columns.Add(Col2);
                datatbl1.Columns.Add(Col3);
                datatbl1.Columns.Add(Col4);
                datatbl1.Columns.Add(Col5);

                //Add rows to datatable
                foreach (DataGridViewRow dgvrow in dgvNvData.Rows)
                {
                    DataRow dtrow = datatbl1.NewRow();
                    dtrow[0] = dgvrow.Cells[0].Value;
                    dtrow[1] = dgvrow.Cells[1].Value;
                    dtrow[2] = dgvrow.Cells[3].Value;
                    dtrow[3] = dgvrow.Cells[4].Value;
                    dtrow[4] = dgvrow.Cells[5].Value;
                    datatbl1.Rows.Add(dtrow);
                }
                ExportFile(datatbl1, "nhân viên", "Báo cáo nhân viên", "nv");
            }
            else if (button.Name == "btnThongKeDoanhThuPhim")
            {
                ExportFile(datatbl2, "doanh thu phim", "Thống kê doanh thu phim", "dtp");
            }
            else if (button.Name == "btnThongKeLichChieu")
            {
                //Add columns to datatable
                List<tblLichChieu> dslc = db.tblLichChieux.ToList();
                BindGriddgvLichChieu(dslc);
                DataTable datatbl3 = new DataTable();
                DataColumn Col1 = new DataColumn("Mã Phim");
                DataColumn Col2 = new DataColumn("Tên Phim");
                DataColumn Col3 = new DataColumn("Thể Loại");
                DataColumn Col4 = new DataColumn("Ngày Khởi Chiếu");
                DataColumn Col5 = new DataColumn("Ngày Kết Thúc");
                DataColumn Col6 = new DataColumn("Thời Lượng");
                DataColumn Col7 = new DataColumn("Tổng Chi Phí");
                datatbl3.Columns.Add(Col1);
                datatbl3.Columns.Add(Col2);
                datatbl3.Columns.Add(Col3);
                datatbl3.Columns.Add(Col4);
                datatbl3.Columns.Add(Col5);
                datatbl3.Columns.Add(Col6);
                datatbl3.Columns.Add(Col7);

                //Add rows to datatable
                foreach (DataGridViewRow dgvrow in dgvLichChieu.Rows)
                {
                    DataRow dtrow = datatbl3.NewRow();
                    dtrow[0] = dgvrow.Cells[0].Value;
                    dtrow[1] = dgvrow.Cells[1].Value;
                    dtrow[2] = dgvrow.Cells[2].Value;
                    dtrow[3] = dgvrow.Cells[3].Value;
                    dtrow[4] = dgvrow.Cells[4].Value;
                    dtrow[5] = dgvrow.Cells[5].Value;
                    dtrow[6] = dgvrow.Cells[6].Value;
                    datatbl3.Rows.Add(dtrow);
                }
                ExportFile(datatbl3, "lịch chiếu", "Báo Cáo lịch chiếu", "lc");
            }
            else if (button.Name == "btnThongKeDoanhThuRap")
            {
                ExportFile(datatbl4, "doanh thu rạp", "Thống kê doanh thu rạp", "dtr");
            }
        }
        #endregion "phim"

        #region "lich chieu"
        private void btnLichChieu_Click(object sender, EventArgs e)
        {
            pnlLichChieu.Visible = true;
            List<tblPhim> dsp = db.tblPhims.ToList();
            FillMovieNameCombobox(dsp);
            List<tblRap> dsr = db.tblRaps.ToList();
            FillCinemaCombobox(dsr);
            //List<tblPhongChieu> dspc = db.tblPhongChieux.ToList();
            //FillRoomCombobox(dspc);
            //List<tblGioChieu> dsgc = db.tblGioChieux.ToList();
            //FillTimeCombobox(dsgc);
            pnlQuanLyPhim.Visible = false;
            pnlNhanVien.Visible = false;
            pnlThongKe.Visible = false;
        }
        private void FillMovieNameCombobox(List<tblPhim> listMovie)
        {
            this.cmbTenPhimLC.DataSource = listMovie;
            this.cmbTenPhimLC.DisplayMember = "TenPhim";
            this.cmbTenPhimLC.ValueMember = "MaPhim";
        }
        private void FillCinemaCombobox(List<tblRap> listCinema)
        {
            this.cmbMaRapLC.DataSource = listCinema;
            this.cmbMaRapLC.DisplayMember = "MaRap";
            this.cmbMaRapLC.ValueMember = "MaRap";
        }
        private void FillRoomCombobox(List<tblPhongChieu> listRoom)
        {
            this.cmbTenPhongLC.DataSource = listRoom;
            this.cmbTenPhongLC.DisplayMember = "TenPhong";
            this.cmbTenPhongLC.ValueMember = "MaPhong";
        }
        private void FillTimeCombobox(List<tblGioChieu> listTime)
        {
            this.cmbGioChieuLC.DataSource = listTime;
            this.cmbGioChieuLC.DisplayMember = "GioChieu";
            this.cmbGioChieuLC.ValueMember = "MaGioChieu";
        }
        private void BindGriddgvLichChieu(List<tblLichChieu> dslc)
        {
            dgvLichChieu.Rows.Clear();
            foreach (var item in dslc)
            {
                //bind data into the datagridview
                int index = dgvLichChieu.Rows.Add();
                // Format the date value in day-month-year format.
                string ngayChieu = item.NgayChieu?.ToString("d", CultureInfo.InvariantCulture);
                dgvLichChieu.Rows[index].Cells[0].Value = item.MaShow;
                dgvLichChieu.Rows[index].Cells[1].Value = item.tblPhim.TenPhim;
                dgvLichChieu.Rows[index].Cells[2].Value = item.MaRap;
                dgvLichChieu.Rows[index].Cells[3].Value = item.tblPhongChieu.TenPhong;
                dgvLichChieu.Rows[index].Cells[4].Value = ngayChieu;
                dgvLichChieu.Rows[index].Cells[5].Value = item.tblGioChieu.GioChieu;
                dgvLichChieu.Rows[index].Cells[6].Value = item.GiaVe;
            }
        }
        private void btndgvLichChieuShowList_Click(object sender, EventArgs e)
        {
            List<tblLichChieu> dslc = db.tblLichChieux.ToList();
            BindGriddgvLichChieu(dslc);
            //Clear textbox if click again
            txtMaShow.Clear();
            cmbTenPhimLC.SelectedIndex = 0;
            cmbMaRapLC.SelectedIndex = 0;
            cmbTenPhongLC.SelectedIndex = 0;
            dtpNgayChieuLC.Value = DateTime.Now;
            cmbGioChieuLC.SelectedIndex = 0;
            txtGiaVeLC.Clear();
        }
        public List<tblPhongChieu> GetAllRoomByCinema(string CinemaId)
        {
            return db.tblPhongChieux.Where(p => p.MaRap.Contains(CinemaId)).ToList();
        }
        public List<tblGioChieu> GetAllTimeByCinema(string CinemaId)
        {
            return db.tblGioChieux.Where(p => p.MaRap.Contains(CinemaId)).ToList();
        }
        private void cmbMaRapLC_SelectedIndexChanged(object sender, EventArgs e)
        {
            tblRap selectedCinema = cmbMaRapLC.SelectedItem as tblRap;
            if (selectedCinema != null)
            {
                var listroom = GetAllRoomByCinema(selectedCinema.MaRap);
                FillRoomCombobox(listroom);
                var listtime = GetAllTimeByCinema(selectedCinema.MaRap);
                FillTimeCombobox(listtime);
            }
        }
        private void dgvLichChieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dgvLichChieu.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtMaShow.Text = row.Cells[0].Value.ToString();
                cmbTenPhimLC.Text = row.Cells[1].Value.ToString();
                cmbMaRapLC.Text = row.Cells[2].Value.ToString();
                cmbTenPhongLC.Text = row.Cells[3].Value.ToString();
                // Try to parse the value of the NgayKhoiChieu cell to a DateTime object.
                DateTime ngayChieu;
                if (DateTime.TryParse(row.Cells[4].Value.ToString(), out ngayChieu))
                {
                    dtpNgayChieuLC.Value = ngayChieu;
                }
                cmbGioChieuLC.Text = row.Cells[5].Value.ToString();
                txtGiaVeLC.Text = row.Cells[6].Value.ToString();
            }
        }
        private void RefreshLichChieu()
        {
            List<tblLichChieu> dslc = db.tblLichChieux.ToList();
            List<tblPhim> dsp = db.tblPhims.ToList();
            FillMovieNameCombobox(dsp);
            List<tblRap> dsr = db.tblRaps.ToList();
            FillCinemaCombobox(dsr);
            BindGriddgvLichChieu(dslc);
        }
        private void btnLcAdd_Click(object sender, EventArgs e)
        {
            string maPhim = db.tblPhims.First(t => t.TenPhim == cmbTenPhimLC.Text).MaPhim;
            string maRap = db.tblRaps.First(t => t.MaRap == cmbMaRapLC.Text).MaRap;
            string maPhong = db.tblPhongChieux.First(t => t.TenPhong == cmbTenPhongLC.Text).MaPhong;
            // Get the time string from the cmbGioChieu.Text control.
            string timeString = cmbGioChieuLC.Text;
            // Convert the time string to a TimeSpan object.
            TimeSpan time = TimeSpan.Parse(timeString);
            // Find the GioChieu object with the same time as the time string.
            string maGioChieu = db.tblGioChieux.Where(t => t.GioChieu == time && t.MaRap == maRap).Select(t => t.MaGioChieu).FirstOrDefault();
            tblLichChieu lc = new tblLichChieu()
            {
                MaShow = txtMaShow.Text,
                MaPhim = maPhim,
                MaRap = maRap,
                MaPhong = maPhong,
                NgayChieu = dtpNgayChieuLC.Value,
                MaGioChieu = maGioChieu,
                GiaVe = Convert.ToInt32(txtGiaVeLC.Text)
            };
            // Get the MaPhim value of the new record.
            string maShow = txtMaShow.Text;
            // Check if there is already a record with the same MaPhim value.
            if (db.tblLichChieux.Any(p => p.MaShow == maShow))
            {
                // There is already a record with the same MaPhim value.
                // Show an error message to the user.
                MessageBox.Show("Đã có lịch chiếu này rồi!");
            }
            else
            {
                db.tblLichChieux.Add(lc);
                db.SaveChanges();
                txtMaShow.Clear();
                cmbTenPhimLC.SelectedIndex = 0;
                cmbMaRapLC.SelectedIndex = 0;
                cmbTenPhongLC.SelectedIndex = 0;
                dtpNgayChieuLC.Value = DateTime.Now;
                cmbGioChieuLC.SelectedIndex = 0;
                txtGiaVeLC.Clear();
                RefreshPhim();
            }
        }
        private void btnLcUpdate_Click(object sender, EventArgs e)
        {
            string maPhim = db.tblPhims.First(t => t.TenPhim == cmbTenPhimLC.Text).MaPhim;
            string maRap = db.tblRaps.First(t => t.MaRap == cmbMaRapLC.Text).MaRap;
            string maPhong = db.tblPhongChieux.First(t => t.TenPhong == cmbTenPhongLC.Text).MaPhong;
            // Get the time string from the cmbGioChieu.Text control.
            string timeString = cmbGioChieuLC.Text;
            // Convert the time string to a TimeSpan object.
            TimeSpan time = TimeSpan.Parse(timeString);
            // Find the GioChieu object with the same time as the time string.
            string maGioChieu = db.tblGioChieux.Where(t => t.GioChieu == time && t.MaRap == maRap).Select(t => t.MaGioChieu).FirstOrDefault();
            String id = (dgvLichChieu.SelectedRows[0].Cells["MaShow"].Value.ToString());
            tblLichChieu lc = db.tblLichChieux.Find(id);
            if (lc != null)
            {
                lc.MaPhim = maPhim;
                lc.MaRap = maRap;
                lc.MaPhong = maPhong;
                lc.NgayChieu = dtpNgayChieuLC.Value;
                lc.MaGioChieu = maGioChieu;
                lc.GiaVe = Convert.ToInt32(txtGiaVeLC.Text);
                db.SaveChanges();
                txtMaShow.Clear();
                cmbTenPhimLC.SelectedIndex = 0;
                cmbMaRapLC.SelectedIndex = 0;
                cmbTenPhongLC.SelectedIndex = 0;
                dtpNgayChieuLC.Value = DateTime.Now;
                cmbGioChieuLC.SelectedIndex = 0;
                txtGiaVeLC.Clear();
                RefreshLichChieu();
            }
        }
        private void btnLcDelete_Click(object sender, EventArgs e)
        {
            var rowData = dgvLichChieu.SelectedRows[0].Cells["MaShow"].Value.ToString();
            tblLichChieu lc = db.tblLichChieux.Find(rowData);
            DialogResult result = MessageBox.Show("Có muốn xóa?", "Thông Báo Xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.tblLichChieux.Remove(lc);
                db.SaveChanges();
                txtMaShow.Clear();
                cmbTenPhimLC.SelectedIndex = 0;
                cmbMaRapLC.SelectedIndex = 0;
                cmbTenPhongLC.SelectedIndex = 0;
                dtpNgayChieuLC.Value = DateTime.Now;
                cmbGioChieuLC.SelectedIndex = 0;
                txtGiaVeLC.Clear();
                RefreshLichChieu();
            }
        }
        #endregion "lich chieu"
    }
}

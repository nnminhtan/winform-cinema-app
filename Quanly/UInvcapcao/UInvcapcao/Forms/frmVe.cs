using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UInvcapcao.Forms
{
    public partial class frmVe : Form
    {
        string gioChieu;
        string GetselectedCinema;
        QUANLYRAPCHIEUPHIMEntities db = new QUANLYRAPCHIEUPHIMEntities();

        public frmVe(DataTable dtb, string maRap)
        {
            InitializeComponent();
            //db.Configuration.ProxyCreationEnabled = false;
            cmbHTTT.SelectedIndex = 0;
            GetselectedCinema = maRap;
            DataTable dtbVe = dtb;
            int total = 0;
            foreach (DataRow dataRow in dtbVe.Rows)
            {
                // Get the NgayChieu value from the dataRow.
                DateTime ngayChieu = (DateTime)dataRow["NgayChieu"];
                gioChieu = (string)dataRow["GioChieu"];
                string phongChieu = (string)dataRow["PhongChieu"];
                int maVe = (int)dataRow["MaVe"];
                string tenPhim = (string)dataRow["TenPhim"];
                int giaVe = (int)dataRow["GiaVe"];
                // Set the Text property of the lblNgayDatShow label.
                lblNgayDatShow.Text = ngayChieu.ToString("dd/MM/yyyy");
                lblGioChieuShow.Text = db.tblGioChieux.Where(p => p.MaGioChieu == gioChieu).Select(x => x.GioChieu).FirstOrDefault().ToString();
                lblPhongChieuShow.Text = phongChieu.ToString();
                lblMaVeShow.Text = maVe.ToString();
                lblTenPhimShow.Text = tenPhim.ToString();
                total += giaVe;
            }
            lblTongTienShow.Text = total.ToString();
            // Filter the rows you want to show.
            //var filteredRows = dtbVe.AsEnumerable()
            //    .Where(row => !HideRow(row))
            //    .CopyToDataTable();

            // Set the DataGridView's DataSource to the filtered DataTable.
            dgvVe.DataSource = dtbVe;
            dgvVe.Columns["STT"].Visible = false;
            dgvVe.Columns["NgayChieu"].Visible = false;
            dgvVe.Columns["TenPhim"].Visible = false;
            dgvVe.Columns["GioChieu"].Visible = false;
            dgvVe.Columns["PhongChieu"].Visible = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmGiaoDienBanVe frmGiaoDienBanVe = new frmGiaoDienBanVe(GetselectedCinema);
            this.Hide();
            frmGiaoDienBanVe.ShowDialog();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvVe.Rows)
            {
                if (row.Cells["STT"].Value != null && row.Cells["MaVe"].Value != null)
                {
                    int STT = Convert.ToInt32(row.Cells["STT"].Value);
                    int maVe = Convert.ToInt32(row.Cells["MaVe"].Value);
                    // Check if a record with the same MaVe already exists in tblVe
                    bool veExists = db.tblVes.Any(v => v.MaVe == maVe);

                    if (!veExists)
                    {
                        tblVe v = new tblVe()
                        {
                            MaVe = maVe,
                            MaShow = db.tblLichChieux.Where(p => p.MaGioChieu == gioChieu).Select(x => x.MaShow).FirstOrDefault(),
                        };
                        db.tblVes.Add(v);
                    }

                    tblThongTinVe ttv = new tblThongTinVe()
                    {
                        //IdTTVe = Convert.ToInt32(row.Cells["STT"].Value),
                        IdTTVe = STT,
                        MaVe = Convert.ToInt32(row.Cells["MaVe"].Value),
                        MaGhe = row.Cells["MaGhe"].Value.ToString(),
                        TenPhim = row.Cells["TenPhim"].Value.ToString(),
                        NgayChieu = DateTime.Parse(row.Cells["NgayChieu"].Value.ToString()),
                        GioChieu = row.Cells["GioChieu"].Value.ToString(),
                        GiaVe = Convert.ToInt32(row.Cells["GiaVe"].Value),
                        PhongChieu = row.Cells["PhongChieu"].Value.ToString(),
                        HinhThucThanhToan = cmbHTTT.Text,
                        MaShow = db.tblLichChieux.Where(p => p.MaGioChieu == gioChieu).Select(x => x.MaShow).FirstOrDefault(),
                        TrangThai = true
                    };
                    //string ghe = row.Cells["MaGhe"].Value.ToString();
                    //tblGhePhongChieu g = db.tblGhePhongChieux.FirstOrDefault(item => item.MaGhe == ghe);
                    //if (g != null)
                    //{
                    //    g.TrangThai = true;
                    //}
                    db.tblThongTinVes.Add(ttv);
                }
                db.SaveChanges();
            }
            frmGiaoDienBanVe frmGiaoDienBanVe = new frmGiaoDienBanVe(GetselectedCinema);
            this.Hide();
            frmGiaoDienBanVe.ShowDialog();
        }
        private void frmVe_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lblNgayDatShow.Text = now.ToString("dd/MM/yyyy");
        }

        private void frmVe_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

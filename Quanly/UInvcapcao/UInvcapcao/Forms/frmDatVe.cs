using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UInvcapcao.Forms;

namespace UInvcapcao
{
    public partial class frmDatVe : Form
    {
        QUANLYRAPCHIEUPHIMEntities db = new QUANLYRAPCHIEUPHIMEntities();
        List<Button> selectedSeats = new List<Button>();
        string GetSelectedPhim;
        string GetSelectedCinema;
        string phongChieu;

        public frmDatVe(string SelectedPhim, string SelectedCinema)
        {
            InitializeComponent();
            GetSelectedPhim = SelectedPhim;
            GetSelectedCinema = SelectedCinema;

        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            var tenPhim = db.tblPhims.Where(p => p.MaPhim == GetSelectedPhim).Select(x => x.TenPhim).FirstOrDefault();
            var maPhong = db.tblLichChieux.Where(p => p.MaPhim == GetSelectedPhim).Select(x => x.MaPhong).FirstOrDefault();
            phongChieu = db.tblPhongChieux.Where(p => p.MaRap == GetSelectedCinema && p.MaPhong == maPhong).Select(x => x.TenPhong).FirstOrDefault();
            lblfilm.Text = tenPhim;
            lblPhongChieu.Text = phongChieu;
            tblPhim phim = db.tblPhims.Find(GetSelectedPhim);
            ptbPosterPhim.Image = new Bitmap(new MemoryStream(phim.Poster));
            DateTime now = DateTime.Now;
            lblNgayChieuShow.Text = now.ToString("dd/MM/yyyy");
            loadCbo();
            string maGioChieu = cboGioChieu.SelectedValue.ToString();
            CheckTrangThai(maGioChieu);
        }

        public void loadCbo()
        {
            var selectedMaGioChieu = db.tblLichChieux
            .Where(p => p.MaPhim == GetSelectedPhim)
            .Select(p => p.MaGioChieu)
            .FirstOrDefault();

            var ListLichChieu = db.tblLichChieux
                .Where(x => x.MaPhim == GetSelectedPhim)
                .Select(p => p.MaGioChieu)
                .ToList();

            cboGioChieu.DataSource = db.tblGioChieux
                .Where(x => ListLichChieu.Contains(x.MaGioChieu))
                .ToList();
            cboGioChieu.DisplayMember = "GioChieu";
            cboGioChieu.ValueMember = "MaGioChieu";
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            frmGiaoDienBanVe frmGiaoDienBanVe = new frmGiaoDienBanVe(GetSelectedCinema);
            this.Hide();
            frmGiaoDienBanVe.ShowDialog();
        }

        //Ghe Ban Da Chon

        private void SeatButton_Click(object sender, EventArgs e)
        {
            //Button seatButton = sender as Button;
            //if (seatButton != null)
            //{
            //    if (seatButton.BackColor == Color.Pink)
            //    {
            //        selectedSeats.Remove(seatButton);
            //        seatButton.BackColor = Color.White;
            //    }
            //    else
            //    {
            //        selectedSeats.Add(seatButton);
            //        seatButton.BackColor = Color.Pink;
            //    }
            //}
            Button seatButton = sender as Button;
            if (seatButton != null)
            {
                if (seatButton.BackColor == Color.Pink)
                {
                    selectedSeats.Remove(seatButton);
                    seatButton.BackColor = Color.White;
                }
                else if (!selectedSeats.Contains(seatButton))
                {
                    selectedSeats.Add(seatButton);
                    seatButton.BackColor = Color.Pink;
                }
            }
        }
        private void AttachEventHandlersToSeatButtons()
        {
            foreach (Control control in pnlGhe.Controls) // Assuming your buttons are in 'panel1'
            {
                if (control is Button)
                {
                    Button seatButton = (Button)control;
                    seatButton.Click += new EventHandler(SeatButton_Click);
                }
            }
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            foreach (Button seatButton in selectedSeats)
            {
                if (seatButton != null)
                {
                    btnOk.Enabled = true;
                    this.Hide();
                    frmVe frmVe = new frmVe(GetSelectedSeats(), GetSelectedCinema);
                    frmVe.ShowDialog();
                }
                else
                {
                    btnOk.Enabled = false;
                }
            }
        }

        public void UpdateStatus()
        {
            foreach (Button seatButton in selectedSeats)
            {
                string maGhe = seatButton.Name; // Assuming the button name is the unique identifier
                var seat = db.tblGhePhongChieux.FirstOrDefault(s => s.MaGhe == maGhe);

                if (seat != null)
                {
                    seat.TrangThai = true; // Mark the seat as reserved
                }
            }
            db.SaveChanges();
        }
        private DataTable GetSelectedSeats()
        {
            int countTTve = db.tblThongTinVes.Count();
            int countVe = db.tblVes.Count();
            // Create a new DataTable object.
            DataTable dataTable = new DataTable();

            // Add the following columns to the DataTable object.
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("MaVe", typeof(int));
            dataTable.Columns.Add("PhongChieu", typeof(string));
            dataTable.Columns.Add("MaGhe", typeof(string));
            dataTable.Columns.Add("TenPhim", typeof(string));
            dataTable.Columns.Add("NgayChieu", typeof(DateTime));
            dataTable.Columns.Add("GioChieu", typeof(string));
            dataTable.Columns.Add("GiaVe", typeof(int));

            // Add STT for IdTTVe
            int STT = countTTve + 1;
            string maPc = db.tblPhongChieux.Where(p => p.MaRap == GetSelectedCinema).Select(x => x.MaPhong).FirstOrDefault();
            // Remove the space from the maPc variable.
            maPc = maPc.Trim();
            // Iterate through the selected seats and add each seat to the DataTable object.
            foreach (Button seat in selectedSeats)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["STT"] = STT;
                dataRow["MaVe"] = countVe + 1;
                dataRow["PhongChieu"] = phongChieu;
                dataRow["MaGhe"] = maPc + "_" + seat.Text;
                dataRow["TenPhim"] = db.tblPhims.Where(p => p.MaPhim == GetSelectedPhim).Select(x => x.TenPhim).FirstOrDefault();
                dataRow["NgayChieu"] = DateTime.Now;
                dataRow["GioChieu"] = cboGioChieu.SelectedValue.ToString();
                dataRow["GiaVe"] = db.tblLichChieux.Where(p => p.MaPhim == GetSelectedPhim).Select(x => x.GiaVe).FirstOrDefault();
                dataTable.Rows.Add(dataRow);
                STT++;
            }
            // Return the DataTable object.
            return dataTable;
        }

        private void CheckTrangThai(string maGioChieu)
        {
            string maShow = db.tblLichChieux.Where(p => p.MaPhim == GetSelectedPhim && p.MaGioChieu == maGioChieu).Select(x => x.MaShow).FirstOrDefault();
            string maPc = db.tblPhongChieux.Where(p => p.MaRap == GetSelectedCinema).Select(x => x.MaPhong).FirstOrDefault();
            maPc = maPc.Trim();
            foreach (Control control in pnlGhe.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;

                    // Get the MaGhe value for the current seat.
                    string maGhe = maPc + "_" + button.Text;

                    // Get the TrangThai value for the current seat.
                    var trangThai = db.tblThongTinVes.Where(p => p.MaShow == maShow && p.MaGhe == maGhe).Select(x => x.TrangThai).FirstOrDefault();

                    // Disable the button if the seat is occupied.
                    if (trangThai == true)
                    {
                        button.Enabled = false;
                        button.BackColor = Color.Gray;
                    }
                    else
                    {
                        button.Enabled = true;
                        button.BackColor = Color.White;
                    }
                }
            }
        }

        private void cboGioChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maGioChieu = cboGioChieu.SelectedValue.ToString();
            CheckTrangThai(maGioChieu);
        }
    }
}
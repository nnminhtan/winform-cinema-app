using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
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
        public frmDatVe(string SelectedPhim)
        {
            InitializeComponent();
            GetSelectedPhim = SelectedPhim;
        }

        private void frmDatVe_Load(object sender, EventArgs e)
        {
            db.tblPhims.FirstOrDefault(p => p.MaPhim == GetSelectedPhim);
            lblfilm.Text = GetSelectedPhim;
            loadCbo();
        }

        public void loadCbo()
        {
            //var selectedMaGioChieu = db.tblLichChieux
            //.Where(p => p.MaPhim == GetSelectedPhim)
            //.Select(p => p.MaGioChieu)
            //.FirstOrDefault();
            //var ListLichChieu = db.tblLichChieux.Where(x => x.MaPhim.Equals(GetSelectedPhim)).ToList();
            //cboNgayChieu.DataSource = db.tblGioChieux.Where(x => x.MaGioChieu == ListLichChieu.Select(p => p.MaGioChieu).ToString());
            //cboNgayChieu.DisplayMember = "GioChieu";
            //cboNgayChieu.ValueMember = "MaGioChieu";



        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //Ghe Ban Da Chon

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button seatButton = sender as Button;
            if (seatButton != null)
            {
                if (seatButton.BackColor == Color.Pink)
                {
                    selectedSeats.Remove(seatButton);
                    seatButton.BackColor = Color.White;
                }
                else
                {
                    selectedSeats.Add(seatButton);
                    seatButton.BackColor = Color.Pink;
                }
            }
        }
        private void AttachEventHandlersToSeatButtons()
        {
            foreach (Control control in panel1.Controls) // Assuming your buttons are in 'panel1'
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
            this.Hide();
            frmVe frmVe = new frmVe();
            frmVe.ShowDialog();
            //int Ma01 = db.tblVes.Select(x => x.MaGhe).Count() + 1;
            //if (txtMaCN.Text == "1" || txtMaCN.Text == "2")
            //{
            //    //new
            //    tblNhanVien nv = new tblNhanVien()
            //    {
            //        MaNV = Ma01.ToString(), //adding the MaNV by counting the list and adding 1
            //        TenNV = txtTenNV.Text,
            //        MatKhauNV = txtMK.Text,
            //        ChucVu = GetChucVu(txtMaCN.Text),
            //        Luong = Convert.ToInt32(txtLuong.Text),
            //        MaRap = txtMaRap.Text
            //    };
            //}
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
        private void pnlGhe_Paint(object sender, PaintEventArgs e)
        {

        }


        private void lblNgayChieu_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
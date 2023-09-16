using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

             if(sidebarExpand)
            {
                //if sidebar expand, minimize
                sidebar.Width -= 10;
                if(sidebar.Width == sidebar.MinimumSize.Width) 
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true  ;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
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
            var result = db.tblNhanViens.Select(x => new { x.MaNV, x.TenNV, x.ChucVu, x.Luong, x.MaRap })
                .Where(x => x.ChucVu == "Nhan Vien").ToList();
            dgvData.DataSource = result;
            //AddBinding();
          
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            pnlNhanVien.Visible = true;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAddDetails.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            pnlDel.Visible = true;
            //int MaNV = Convert.ToInt32(txtMaNV.Text);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string Ma01 = "NhanVien";
            //count the list of the nhan vien
            int Ma02 = db.tblNhanViens.Select(x => x.ChucVu == "Nhan Vien").Count();

            //create a nhan vien to add to the table
            tblNhanVien nv = new tblNhanVien() { MaNV = (Ma01 + Ma02.ToString()),
                TenNV = txtTenNV.Text, MatKhauNV = txtMK.Text, ChucVu = txtChucVu.Text,
                Luong = Convert.ToInt32(txtLuong.Text), MaRap = txtMaRap.Text };
            db.tblNhanViens.Add(nv);
            db.SaveChanges();

            pnlAddDetails.Visible=false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddDetails.Visible=false;
        }

        private void btnConfirmDel_Click(object sender, EventArgs e)
        {
            //delete the nhanvien by the manv
            tblNhanVien nv = db.tblNhanViens.Where(x => x.MaNV == txtMaNV.Text).SingleOrDefault();
            db.tblNhanViens.Remove(nv);
            db.SaveChanges();
            pnlDel.Visible = false;

            //foreach (DataGridViewRow item in dgvData.SelectedRows)
            //{
            //    dgvData.Rows.RemoveAt(item.Index);
            //}
        }

        private void btnCancelDel_Click(object sender, EventArgs e)
        {
            pnlDel.Visible=false;
        }

        private void btnConfirmUpdate_Click(object sender, EventArgs e)
        {
            //find nhan vien by the MaNV entered
            String id = (dgvData.SelectedRows[0].Cells["MaNV"].Value.ToString());
            tblNhanVien nv = db.tblNhanViens.Find(id);
            nv.TenNV = txtTenNVUpdate.Text;
            nv.MatKhauNV = txtMKUpdate.Text;
            nv.ChucVu = txtChucVuUpdate.Text;
            nv.Luong = Convert.ToInt32(txtLuongUpdate.Text);
            nv.TenNV = txtTenNVUpdate.Text;
            nv.MaRap = txtMaRapUpdate.Text;
            db.SaveChanges();
            pnlUpdate.Visible = false;

        }

        private void btnCancelUpdate_Click(object sender, EventArgs e)
        {
            pnlUpdate.Visible = false;
        }

        private void dgvData_SelectionChanged(object sender, EventArgs e)
        {
            var indexAt = dgvData.CurrentCell.RowIndex;
        }
    }
}

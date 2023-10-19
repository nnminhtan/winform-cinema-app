using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UInvcapcao
{
    public partial class frmGiaoDienBanVe : Form
    {
        bool sidebarExpand;
        public frmGiaoDienBanVe()
        {
            InitializeComponent();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void btnabout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
        }

        private void menubuttom_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void ptbP1_Click(object sender, EventArgs e)
        {
            string selectedValue = ptbP1.Tag.ToString();
            frmDatVe frmDatVe = new frmDatVe(selectedValue);
            frmDatVe.ShowDialog();
        }

        private void ptbP2_Click(object sender, EventArgs e)
        {
            string selectedValue = ptbP2.Tag.ToString();
            frmDatVe frmDatVe = new frmDatVe(selectedValue);
            frmDatVe.ShowDialog();
        }

        private void ptbP3_Click(object sender, EventArgs e)
        {
            string selectedValue = ptbP3.Tag.ToString();
            frmDatVe frmDatVe = new frmDatVe(selectedValue);
            frmDatVe.ShowDialog();
        }

        private void ptbP4_Click(object sender, EventArgs e)
        {
            string selectedValue = ptbP4.Tag.ToString();
            frmDatVe frmDatVe = new frmDatVe(selectedValue);
            frmDatVe.ShowDialog();
        }

        private void ptbP5_Click(object sender, EventArgs e)
        {
            string selectedValue = ptbP5.Tag.ToString();
            frmDatVe frmDatVe = new frmDatVe(selectedValue);
            frmDatVe.ShowDialog();
        }

        private void ptbP6_Click(object sender, EventArgs e)
        {
            string selectedValue = ptbP6.Tag.ToString();
            frmDatVe frmDatVe = new frmDatVe(selectedValue);
            frmDatVe.ShowDialog();
        }
    }
}

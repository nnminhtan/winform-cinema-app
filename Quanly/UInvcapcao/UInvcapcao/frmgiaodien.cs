﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UInvcapcao
{
    public partial class frmGiaoDien : Form
    {
        bool sidebarExpand;
        public frmGiaoDien()
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            frmDatVe frmDatVe = new frmDatVe();
            frmDatVe.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDatVe frmDatVe = new frmDatVe();
            frmDatVe.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmDatVe frmDatVe = new frmDatVe();
            frmDatVe.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmDatVe frmDatVe = new frmDatVe();
            frmDatVe.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            frmDatVe frmDatVe = new frmDatVe();
            frmDatVe.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmDatVe frmDatVe = new frmDatVe();
            frmDatVe.ShowDialog();
        }
    }
}

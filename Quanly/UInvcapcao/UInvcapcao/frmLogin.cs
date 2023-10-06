using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UInvcapcao
{
    public partial class frmLogin : Form
    {
        QUANLYRAPCHIEUPHIMEntities db = new QUANLYRAPCHIEUPHIMEntities();
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (CheckHopLe())
            {
                try
                {
                    bool ISTK, ISMK;
                    int ACCESSKEY;
                    CheckIDNV(out ISTK, out ISMK, out ACCESSKEY);
                    if(ISTK && ISMK)
                    {
                        if(ACCESSKEY == 1)
                        {
                            this.Hide();
                            frmQuanLy frmQuanLy = new frmQuanLy();
                            frmQuanLy.ShowDialog();
                        }
                        if(ACCESSKEY == 2)
                        {
                            this.Hide();
                            frmGiaoDien frmgiaodien = new frmGiaoDien();
                            frmgiaodien.ShowDialog();
                        }
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            

        }

        private void CheckIDNV(out bool iSTK, out bool iSMK, out int aCCESSKEY)
        {
            var parameters = new[]
             {
            new SqlParameter("@ISTK", SqlDbType.Bit) { Direction = ParameterDirection.Output },
            new SqlParameter("@ISMK", SqlDbType.Bit) { Direction = ParameterDirection.Output },
            new SqlParameter("@TK", SqlDbType.NVarChar) { Value = txtTK.Text },
            new SqlParameter("@MK", SqlDbType.NVarChar) { Value = txtMK.Text },
            new SqlParameter("@ACCESSKEY", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };
            try
            {
                // Execute the stored procedure
                db.Database.ExecuteSqlCommand("CheckIDNV @ISTK OUT, @ISMK OUT, @TK, @MK, @ACCESSKEY OUT", parameters);

                // Retrieve the output parameter values
                iSTK = (bool)parameters[0].Value;
                iSMK = (bool)parameters[1].Value;
                aCCESSKEY = (int)parameters[4].Value;
            }
            catch (Exception ex)
            {
                // Handle the exception, e.g., display an error message to the user
                MessageBox.Show("Sai tai khoan hoac mat khau. Xin hay kiem tra lai thong tin ca nhan! \n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //+ex.Message
                //set focus to txtbox tk
                txtTK.Focus();
                // Set output parameters to default values or indicate failure
                iSTK = false;
                iSMK = false;
                aCCESSKEY = -1; // Or another appropriate default value
            }

        }


        private bool CheckHopLe()
        {
            if(txtTK.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui Lòng Nhập TK!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTK.Clear();
                txtMK.Clear();
                txtTK.Focus();
                return false;
            }
            if (txtMK.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Vui Lòng Nhập MK!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMK.Clear();
                txtTK.Focus();
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {

        }
    }
}

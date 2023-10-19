using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private SqlConnection _connection;
        private SqlCommand _command;
        public frmVe()
        {
            InitializeComponent();
            _command = new SqlCommand("INSERT INTO Customers (Name, Address) VALUES (@Name, @Address)", _connection);
            _connection = new SqlConnection("Data Source=localhost;Initial Catalog=MyDatabase;Integrated Security=True");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            frmGiaoDienBanVe frmGiaoDienBanVe = new frmGiaoDienBanVe();
            this.Hide();
            frmGiaoDienBanVe.ShowDialog();
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            //string name = txtName.Text;
            //string address = txtAddress.Text;

            // Gắn dữ liệu vào câu lệnh SQL
            //_command.Parameters.AddWithValue("@Name", name);
            //_command.Parameters.AddWithValue("@Address", address);

            // Thực thi câu lệnh SQL
            //_command.ExecuteNonQuery();

            // Thông báo lưu trữ thành công
            //MessageBox.Show("Lưu trữ thành công!");
        }
    }
}

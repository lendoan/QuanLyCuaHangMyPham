using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;
namespace QLMyPham
{
    public partial class frmBanHang : Form
    {
        string str = "";
         SqlConnection cnn;
        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            str = " Server =.; Database = QuanLyCuaHang ; Integrated Security = true";
            cnn = new SqlConnection(str);
             dgvDobHang.DataSource = GetDonHang();
        }
        private List<DonHang_DTO> GetDonHang()
        {
            string sql = " SELECT * FROM DonHang";
            return new DonHangBUS().GetDonHang(sql);
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            string  mahd,manv, makh, ndat, ngiao;
            mahd = txtmaHD.Text.Trim();
      
            makh = txtKH.Text.Trim();
            manv = txtNV.Text.Trim();
            ndat = txtNgayDat.Text.Trim();
            ngiao = txtGiaoHang.Text.Trim();

            DonHang_DTO dhg = new DonHang_DTO(mahd, makh,manv, ndat, ngiao);
            try
            {
                int i = new DonHangBUS().Add(dhg);
                dgvDobHang.DataSource = GetDonHang();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            string s = "UPDATE DonHang set MaDH='" + txtmaHD.Text + "',MaKH='" + txtKH.Text + "' ,MaNV ='" + txtNV.Text + "',NgayDatHang ='" + txtNgayDat.Text + "',NgayGiaoHang ='" + txtGiaoHang.Text +   "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvDobHang.DataSource = GetDonHang();
            cnn.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            string s = "DELETE FROM DonHang where MaDH='" + txtmaHD.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvDobHang.DataSource = GetDonHang();
            cnn.Close();
        }

        private void btTongtien_Click(object sender, EventArgs e)
        {
            txtDongia.Text
        }
    }
}

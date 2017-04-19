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

using BUS;
using DTO;
namespace QLMyPham
{
    public partial class QuanLy : Form
    {
        string str = "";
        SqlConnection cnn;
        public QuanLy()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEmployee.DataSource = GetEmployee();
            }
            catch (SqlException ex)
            {
                
                throw ex;
            }
        }
        private List<EmployeeDTO> GetEmployee()
        {
            string sql = "SELECT* FROM NhanVien";
            return new EmployeeBUS().GetEmployee(sql);
        }

        private void btADD_Click(object sender, EventArgs e)
        {
            
            string id,lastname, firstname,chucvu,gt,birthday, ngaylamviec,  phone,ad;
            id = txtID.Text.Trim();
            lastname = txtHo.Text.Trim();
            firstname = txtTen.Text.Trim();
            chucvu = txtChucVu.Text.Trim();
            gt = txtGT.Text.Trim();
            birthday = txtNgaySinhNV.Text.Trim();
            ngaylamviec =txtNgayLamViecNV.Text.Trim();
            
            phone = txtDT.Text.Trim();
            ad = txtDC.Text.Trim();
            EmployeeDTO emp = new EmployeeDTO(id, lastname, firstname,chucvu,gt,birthday,ngaylamviec, phone,ad);
            try
            {
                int i = new EmployeeBUS().Add(emp);
                dgvEmployee.DataSource = GetEmployee();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void QuanLy_Load(object sender, EventArgs e)
        {
            try
            {
                str = " Server =.; Database = QuanLyCuaHang ; Integrated Security = true";
                cnn = new SqlConnection(str);
                dgvEmployee.DataSource = GetEmployee();
                dgvCustomer.DataSource = GetCustomer();
                dgvsp.DataSource = GetSanPham();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        private List<CustomerDTO> GetCustomer()
        {
            string sql = "SELECT* FROM KhachHang";
            return new CustomerBUS().GetCustomer(sql);
        }

        private void btAddKH_Click(object sender, EventArgs e)
        {
             
            string id,name, ad, phone,namsinhKH,gtKH;
            id = txtMaKH.Text.Trim();
            name = txtTenKH.Text.Trim();
            ad = txtadrKH.Text.Trim();
            phone = txtPhoneKH.Text.Trim();
            namsinhKH = txtNamSinhKH.Text.Trim();
            gtKH = txtgtKH.Text.Trim();

            CustomerDTO cus = new CustomerDTO(id,name, ad, phone,namsinhKH,gtKH);
            try
            {
                int i = new CustomerBUS().Add(cus);
                dgvCustomer.DataSource = GetCustomer();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void btXoaKH_Click_1(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            string s = "DELETE FROM KhachHang where MaKH='" + txtMaKH.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvCustomer.DataSource = GetCustomer();
            cnn.Close();
        }

        private void btXoaNV_Click(object sender, EventArgs e)
        {

            cnn = new SqlConnection(str);
            string s = "DELETE FROM NhanVien where MaNV='" + txtID.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvEmployee.DataSource = GetEmployee();
            cnn.Close();
        }

        private void btSuaNV_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            string s = "UPDATE NhanVien set HoNV='" + txtHo.Text + "',TenNV='" + txtTen.Text + "' ,MaCV ='" + txtChucVu.Text + "',GioiTinh ='" + txtGT.Text + "',NgaySinh ='" + txtNgaySinhNV.Text + "',NgayLamViec ='" + txtNgayLamViecNV + "',SoDienThoai='" + txtDT.Text + "' , DiaChi='" + txtDC.Text + "'   where MaNV='" + txtID.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s,cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvEmployee.DataSource = GetEmployee();
            cnn.Close();
        }

        private void btSuaKH_Click(object sender, EventArgs e)
        {
            cnn = new SqlConnection(str);
            string s = "UPDATE KhachHang set TenKH='" + txtTenKH.Text + "' ,DiaChi='" + txtadrKH.Text + "' ,DienThoai='" + txtPhoneKH.Text + "' ,NamSinh ='" + txtNamSinhKH.Text + "',GioiTinh='" + txtgtKH.Text + "'  where MaKH='" + txtMaKH.Text + "'";
            cnn.Open();
            SqlCommand cmd = new SqlCommand(s, cnn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            dgvCustomer.DataSource = GetCustomer();
            cnn.Close();
        }

    

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string masanpham;
            masanpham = txtmasp.Text.Trim();
            try
            {
                int i = new SanPhamBUS().xoaSP(masanpham);
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            dgvsp.DataSource = GetSanPham();
        }
        private List<SanPhamDTO> GetSanPham()
        {
            string sql = "SELECT* FROM SanPham";
            return new SanPhamBUS().Getsanpham(sql);
        }
        private void btthemsp_Click(object sender, EventArgs e)
        {
            string masp,tensp, mota, tinhtrang, manguoncungcap, maloaisp;
            double dongia;
            masp = txtmasp.Text.Trim();
            tensp = txttensp.Text.Trim();
            mota = txtmota.Text.Trim();
            dongia = Double.Parse(txtdongia.Text.Trim());
            tinhtrang = txttinhtrang.Text.Trim();
            manguoncungcap = txtmncc.Text.Trim();
            maloaisp = txtmlsp.Text.Trim();

            SanPhamDTO sp = new SanPhamDTO(masp,tensp, mota, dongia,tinhtrang, manguoncungcap,maloaisp);
            try
            {
                int i = new SanPhamBUS().Add(sp);
                dgvsp.DataSource = GetSanPham();
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btsuasp_Click(object sender, EventArgs e)
        {
            string masp, tensp, mota, tinhtrang, manguoncungcap, maloaisp;
            double dongia;
            masp = txtmasp.Text.Trim();
            tensp = txttensp.Text.Trim();
            mota = txtmota.Text.Trim();
            dongia = double.Parse(txtdongia.Text.Trim());
            tinhtrang = txttinhtrang.Text.Trim();
            manguoncungcap = txtmncc.Text.Trim();
            maloaisp = txtmlsp.Text.Trim();
            SanPhamDTO sp = new SanPhamDTO(masp, tensp, mota, dongia, tinhtrang, manguoncungcap, maloaisp);
            try
            {
                int i = new SanPhamBUS().SuaSP(sp);
                if (i == -2)
                {
                    throw new Exception();
                }

            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            dgvsp.DataSource = GetSanPham(); 
        }
        

    }
}

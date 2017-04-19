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

namespace QLMyPham
{
    public partial class frmDangnhap : Form
    {
        string str = "";
         SqlConnection cnn;
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            str = " Server =.; Database = QuanLyCuaHang ; Integrated Security = true";
            cnn = new SqlConnection(str);
        }
        public DataTable checkLogin(string user, string pass)
        {


            string sql = " SELECT * FROM TaiKhoan Where TenDangNhap = '" + user + "'and MatKhau = '" + pass + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;



        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = checkLogin(this.txtDangnhap.Text, this.txtPass.Text);
            if (dt.Rows.Count > 0)
            {
                this.Hide();

                frmhethong fql = new frmhethong(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());

                fql.Show();
            }
            else
            {
                MessageBox.Show("mat khau khong dung, dang nhap lai");

            }
           
            
        }
    }
}

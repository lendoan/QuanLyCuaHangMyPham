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


namespace QLCHMyPham
{
    public partial class frmDangNhap : Form
    {
        string cnStr = "";
        SqlConnection cn;
        
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

            cnStr = @"Server =HAMBAEKGU-PC\SQLEXPRESS ;Database=QuanLyCuaHangMP;Integrated Security= true; ";
            cn = new SqlConnection(cnStr);

        }
        private void Connect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                    cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Disconnect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Closed)
                    cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = checkLogin(this.txtUser.Text, this.txtPass.Text);
            if (dt.Rows.Count > 0)
            {
                this.Hide();

                frmMain fmain = new frmMain(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
               

                fmain.Show();
            }
            else
            {
                MessageBox.Show("mat khau khong dung, dang nhap lai");

            }

        }
        public DataTable checkLogin(string user, string pass)
        {


            string sql = " SELECT * FROM TaiKhoan Where TenDangNhap = '" + user + "'and MatKhau = '" + pass + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;



        }
    

    }
 
 }
      
        



       
       
       
    


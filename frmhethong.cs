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
    public partial class frmhethong : Form
    {
        string matk = "", machucvu = "", tendangnhap = "", matkhau = "";
        string str = "";
        SqlConnection cnn;
        public frmhethong()
        {
            InitializeComponent();
        }
        public frmhethong(string matk, string machucvu, string tendangnhap, string matkhau)
        {
            InitializeComponent();
            this.matk = matk;
            this.machucvu = machucvu;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
        }


        private void frmhethong_Load(object sender, EventArgs e)
        {
            str = " Server =.; Database = QuanLyCuaHang ; Integrated Security = true";
            cnn = new SqlConnection(str);
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLy fql = new frmQuanLy();
            fql.StartPosition = FormStartPosition.CenterScreen;
            fql.WindowState = FormWindowState.Maximized;
            fql.MdiParent = this;
            fql.Show();

        }

        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBanHang fbh = new frmBanHang();
            fbh.StartPosition = FormStartPosition.CenterScreen;
            fbh.WindowState = FormWindowState.Maximized;
            fbh.MdiParent = this;
            fbh.Show();
        }

        private void frmhethong_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bạn có chắc muốn thoát không?",
                "Error", MessageBoxButtons.YesNoCancel);
            Application.Exit();
        }
    }
}

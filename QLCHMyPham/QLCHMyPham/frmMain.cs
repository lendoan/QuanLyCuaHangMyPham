using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHMyPham
{
    public partial class frmMain : Form
    {
        string matk = "", machucvu = "", tendangnhap = "", matkhau = "";
        public frmMain(string matk, string machucvu, string tendangnhap, string matkhau)
        {
            this.matk = matk;
            this.machucvu = machucvu;
            this.tendangnhap = tendangnhap;
            this.matkhau = matkhau;
            InitializeComponent();
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmBanHang fBH = new frmBanHang();
            fBH.StartPosition = FormStartPosition.CenterScreen;
            fBH.WindowState = FormWindowState.Maximized;
            fBH.MdiParent = this;
            fBH.Show();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien fNv = new frmNhanVien();
            fNv.StartPosition = FormStartPosition.CenterScreen;
            fNv.WindowState = FormWindowState.Maximized;
            fNv.MdiParent = this;
            if (machucvu == "QL")
            {

                fNv.Show();
            }
            else
            {


                fNv.Hide();
                MessageBox.Show("ban khong duoc quyen truy cap ");

            }
        }
    }
}

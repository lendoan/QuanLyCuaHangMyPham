using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Microsoft.VisualBasic;

namespace QLCHMyPham
{
    public partial class frmBanHang : Form
    {
        #region ham
        private void KhoiTao()
        {
            try 
            {
                lbDSSanPhamMua.Items.Clear();
                lbThanhTien.Items.Clear();
                
            }
            catch (Exception)
            { }


        }
        public static string DoiSo_TienTe(object _ob)
        {
            try
            {
                if (_ob.ToString().Trim().Length == 0)
                {
                    return " ";

                }
                if (_ob.ToString() == "0")
                {
                    return "0.000";
 
                }
                decimal dThanhTien = Convert.ToDecimal(_ob);
                string strThanhTien = string.Format("0:#,#.",dThanhTien);
            }
            catch (Exception)
            { }
            return "0.000";
        }
        private void TongTien()
        {
            try
            {
                if (lbThanhTien.Items.Count == 0)
                {
                    return;
                }
                float ThanhTien = 0;
                float TongTien = 0;
                for(int i = 0;i<lbThanhTien.Items.Count;i++)
                { ThanhTien = Convert.ToSingle(lbThanhTien.Items[i].ToString().Replace(",", ""));
                TongTien += ThanhTien;

                }
                numericTongTien.Value = Convert.ToDecimal(TongTien);

            }
            catch (Exception)
            { }
        }

        #endregion

        public frmBanHang()
        {
            InitializeComponent();
        }
        #region quan ly form
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            KhoiTao();
        }

        private void frmBanHang_Shown(object sender, EventArgs e)
        {
            if (Opacity ==0)
            { Opacity = 100; }
        }

        private void frmBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                          Close();
            break;
                    }
                case Keys.Enter:
                    {
                        btThemSPDS_Click(null, null);
                        break;
                    }
              
            }
        }
    #endregion
        #region thao tac
        private void lbDSSanPhamMua_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDSSanPhamMua.SelectedIndex = lbDSSanPhamMua.SelectedIndex;
        }

        private void ThanhTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbThanhTien.SelectedIndex = lbThanhTien.SelectedIndex;
        }

        private void btThemSPDS_Click(object sender, EventArgs e)
        {
            try
            {

                lbDSSanPhamMua.Items.Add(txtSPThemvao.Text);
                string tmp = DoiSo_TienTe(numericDonGia.Value.ToString());
                lbThanhTien.Items.Add(tmp);
                TongTien();

            }
            catch (Exception)
            {
            }
        }
             private void btXoaSPDS_Click(object sender, EventArgs e)
        {

            try
            {

                int index = lbDSSanPhamMua.SelectedIndex;
                lbDSSanPhamMua.Items.RemoveAt(index);
                lbThanhTien.Items.RemoveAt(index);
                TongTien();

            }
            catch (Exception)
            {
            }
        }
        
        #endregion

             private void numericTienKhach_ValueChanged(object sender, EventArgs e)
             {
                 numericTienThua.Value = numericTienKhach.Value - numericTongTien.Value;
             }

       

       
    }
}

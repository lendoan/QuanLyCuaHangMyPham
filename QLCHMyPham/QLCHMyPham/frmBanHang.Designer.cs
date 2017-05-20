namespace QLCHMyPham
{
    partial class frmBanHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btXoaSPDS = new System.Windows.Forms.Button();
            this.btInHD = new System.Windows.Forms.Button();
            this.btThemSPDS = new System.Windows.Forms.Button();
            this.numericTienKhach = new System.Windows.Forms.NumericUpDown();
            this.numericTienThua = new System.Windows.Forms.NumericUpDown();
            this.numericTongTien = new System.Windows.Forms.NumericUpDown();
            this.lbThanhTien = new System.Windows.Forms.ListBox();
            this.txtSPThemvao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDSSanPhamMua = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.txtSoDT = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHoadon = new System.Windows.Forms.DataGridView();
            this.btIn = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.numericDonGia = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTienKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTienThua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTongTien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtNgayLapHD);
            this.groupBox1.Controls.Add(this.txtSoDT);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn hàng";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.numericDonGia);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btXoaSPDS);
            this.panel1.Controls.Add(this.btInHD);
            this.panel1.Controls.Add(this.btThemSPDS);
            this.panel1.Controls.Add(this.numericTienKhach);
            this.panel1.Controls.Add(this.numericTienThua);
            this.panel1.Controls.Add(this.numericTongTien);
            this.panel1.Controls.Add(this.lbThanhTien);
            this.panel1.Controls.Add(this.txtSPThemvao);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbDSSanPhamMua);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(25, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 259);
            this.panel1.TabIndex = 6;
            // 
            // btXoaSPDS
            // 
            this.btXoaSPDS.Location = new System.Drawing.Point(424, 185);
            this.btXoaSPDS.Name = "btXoaSPDS";
            this.btXoaSPDS.Size = new System.Drawing.Size(75, 44);
            this.btXoaSPDS.TabIndex = 8;
            this.btXoaSPDS.Text = "Xóa";
            this.btXoaSPDS.UseVisualStyleBackColor = true;
            this.btXoaSPDS.Click += new System.EventHandler(this.btXoaSPDS_Click);
            // 
            // btInHD
            // 
            this.btInHD.Location = new System.Drawing.Point(532, 185);
            this.btInHD.Name = "btInHD";
            this.btInHD.Size = new System.Drawing.Size(75, 44);
            this.btInHD.TabIndex = 8;
            this.btInHD.Text = "In";
            this.btInHD.UseVisualStyleBackColor = true;
            // 
            // btThemSPDS
            // 
            this.btThemSPDS.Location = new System.Drawing.Point(322, 185);
            this.btThemSPDS.Name = "btThemSPDS";
            this.btThemSPDS.Size = new System.Drawing.Size(75, 44);
            this.btThemSPDS.TabIndex = 8;
            this.btThemSPDS.Text = "Thêm";
            this.btThemSPDS.UseVisualStyleBackColor = true;
            this.btThemSPDS.Click += new System.EventHandler(this.btThemSPDS_Click);
            // 
            // numericTienKhach
            // 
            this.numericTienKhach.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericTienKhach.Location = new System.Drawing.Point(361, 112);
            this.numericTienKhach.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericTienKhach.Name = "numericTienKhach";
            this.numericTienKhach.Size = new System.Drawing.Size(138, 20);
            this.numericTienKhach.TabIndex = 7;
            this.numericTienKhach.ThousandsSeparator = true;
            this.numericTienKhach.ValueChanged += new System.EventHandler(this.numericTienKhach_ValueChanged);
            // 
            // numericTienThua
            // 
            this.numericTienThua.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTienThua.Location = new System.Drawing.Point(361, 148);
            this.numericTienThua.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericTienThua.Name = "numericTienThua";
            this.numericTienThua.ReadOnly = true;
            this.numericTienThua.Size = new System.Drawing.Size(138, 20);
            this.numericTienThua.TabIndex = 7;
            this.numericTienThua.ThousandsSeparator = true;
            // 
            // numericTongTien
            // 
            this.numericTongTien.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericTongTien.Location = new System.Drawing.Point(361, 79);
            this.numericTongTien.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericTongTien.Name = "numericTongTien";
            this.numericTongTien.ReadOnly = true;
            this.numericTongTien.Size = new System.Drawing.Size(138, 20);
            this.numericTongTien.TabIndex = 7;
            this.numericTongTien.ThousandsSeparator = true;
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.FormattingEnabled = true;
            this.lbThanhTien.Location = new System.Drawing.Point(135, 16);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(120, 225);
            this.lbThanhTien.TabIndex = 6;
            this.lbThanhTien.SelectedIndexChanged += new System.EventHandler(this.ThanhTien_SelectedIndexChanged);
            // 
            // txtSPThemvao
            // 
            this.txtSPThemvao.AutoCompleteCustomSource.AddRange(new string[] {
            "Wax Tạo Kiểu Tóc HELIONAS WAX 80g",
            "Kem Chống Nắng SOLARINE",
            "Kem nền HWANSAENGGO GOLD ESSENCE BB SPF35 PA++",
            "Kem dưỡng chiết xuất từ ốc Sên GOODAL",
            "Kem Mụn TOPAL Extra Strong 10g"});
            this.txtSPThemvao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSPThemvao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSPThemvao.Location = new System.Drawing.Point(361, 13);
            this.txtSPThemvao.Name = "txtSPThemvao";
            this.txtSPThemvao.Size = new System.Drawing.Size(276, 20);
            this.txtSPThemvao.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(293, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tiền Khách";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(303, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Tiền thừa";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Tổng tiền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(280, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Tên sản phẩm";
            // 
            // lbDSSanPhamMua
            // 
            this.lbDSSanPhamMua.FormattingEnabled = true;
            this.lbDSSanPhamMua.Location = new System.Drawing.Point(3, 16);
            this.lbDSSanPhamMua.Name = "lbDSSanPhamMua";
            this.lbDSSanPhamMua.Size = new System.Drawing.Size(126, 225);
            this.lbDSSanPhamMua.TabIndex = 2;
            this.lbDSSanPhamMua.Tag = "lbDS";
            this.lbDSSanPhamMua.SelectedIndexChanged += new System.EventHandler(this.lbDSSanPhamMua_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Danh sách sản phẩm mua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Ngày lập HD:";
            // 
            // dtNgayLapHD
            // 
            this.dtNgayLapHD.Location = new System.Drawing.Point(114, 159);
            this.dtNgayLapHD.Name = "dtNgayLapHD";
            this.dtNgayLapHD.Size = new System.Drawing.Size(189, 20);
            this.dtNgayLapHD.TabIndex = 4;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(424, 122);
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.Size = new System.Drawing.Size(148, 20);
            this.txtSoDT.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(424, 78);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(148, 20);
            this.textBox5.TabIndex = 1;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(424, 40);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(148, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(114, 122);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(189, 20);
            this.txtTenNV.TabIndex = 1;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(114, 78);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(189, 20);
            this.txtMaNV.TabIndex = 1;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(114, 40);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(189, 20);
            this.txtMaHD.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(335, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên KH:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHoadon);
            this.groupBox2.Controls.Add(this.btIn);
            this.groupBox2.Controls.Add(this.btXoa);
            this.groupBox2.Controls.Add(this.btSua);
            this.groupBox2.Controls.Add(this.btThem);
            this.groupBox2.Location = new System.Drawing.Point(753, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 447);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin hóa đơn";
            // 
            // dgvHoadon
            // 
            this.dgvHoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoadon.Location = new System.Drawing.Point(60, 40);
            this.dgvHoadon.Name = "dgvHoadon";
            this.dgvHoadon.Size = new System.Drawing.Size(385, 276);
            this.dgvHoadon.TabIndex = 1;
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(388, 347);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(75, 23);
            this.btIn.TabIndex = 0;
            this.btIn.Text = "In";
            this.btIn.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(274, 347);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(160, 347);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 0;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(37, 347);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 0;
            this.btThem.Text = "Thêm ";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Đơn giá";
            // 
            // numericDonGia
            // 
            this.numericDonGia.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericDonGia.Location = new System.Drawing.Point(361, 53);
            this.numericDonGia.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericDonGia.Name = "numericDonGia";
            this.numericDonGia.Size = new System.Drawing.Size(138, 20);
            this.numericDonGia.TabIndex = 10;
            this.numericDonGia.ThousandsSeparator = true;
            // 
            // frmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBanHang";
            this.Text = "frmBanHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBanHang_FormClosing);
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.Shown += new System.EventHandler(this.frmBanHang_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmBanHang_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericTienKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTienThua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTongTien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDonGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtNgayLapHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbDSSanPhamMua;
        private System.Windows.Forms.TextBox txtSoDT;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvHoadon;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btXoaSPDS;
        private System.Windows.Forms.Button btInHD;
        private System.Windows.Forms.Button btThemSPDS;
        private System.Windows.Forms.NumericUpDown numericTienKhach;
        private System.Windows.Forms.NumericUpDown numericTienThua;
        private System.Windows.Forms.NumericUpDown numericTongTien;
        private System.Windows.Forms.ListBox lbThanhTien;
        private System.Windows.Forms.TextBox txtSPThemvao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericDonGia;
        private System.Windows.Forms.Label label13;
    }
}
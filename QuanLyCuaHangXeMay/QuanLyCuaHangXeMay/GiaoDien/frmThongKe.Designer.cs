namespace QuanLyCuaHangXeMay
{
    partial class frmThongKe
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
            this.btThoat = new System.Windows.Forms.Button();
            this.dGVThongKe = new System.Windows.Forms.DataGridView();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.ManHinhChinh = new System.Windows.Forms.MenuStrip();
            this.mnsTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsXemThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyXe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuanLyNhaCungCap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsThongKeDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThongKe)).BeginInit();
            this.ManHinhChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThoat.Location = new System.Drawing.Point(343, 545);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(119, 45);
            this.btThoat.TabIndex = 38;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // dGVThongKe
            // 
            this.dGVThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVThongKe.Location = new System.Drawing.Point(42, 203);
            this.dGVThongKe.Name = "dGVThongKe";
            this.dGVThongKe.RowHeadersWidth = 51;
            this.dGVThongKe.RowTemplate.Height = 24;
            this.dGVThongKe.Size = new System.Drawing.Size(792, 315);
            this.dGVThongKe.TabIndex = 5;
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTenNhanVien.BackColor = System.Drawing.SystemColors.Info;
            this.lbTenNhanVien.Location = new System.Drawing.Point(626, 0);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(264, 23);
            this.lbTenNhanVien.TabIndex = 9;
            // 
            // ManHinhChinh
            // 
            this.ManHinhChinh.AutoSize = false;
            this.ManHinhChinh.BackColor = System.Drawing.SystemColors.Control;
            this.ManHinhChinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManHinhChinh.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.ManHinhChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsTaiKhoan,
            this.mnsQuanLy,
            this.mnsThongKe});
            this.ManHinhChinh.Location = new System.Drawing.Point(0, 0);
            this.ManHinhChinh.Name = "ManHinhChinh";
            this.ManHinhChinh.Size = new System.Drawing.Size(891, 36);
            this.ManHinhChinh.TabIndex = 47;
            this.ManHinhChinh.Text = "menuStrip1";
            // 
            // mnsTaiKhoan
            // 
            this.mnsTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsXemThongTinTaiKhoan,
            this.mnsDangXuat});
            this.mnsTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsTaiKhoan.Name = "mnsTaiKhoan";
            this.mnsTaiKhoan.Size = new System.Drawing.Size(107, 32);
            this.mnsTaiKhoan.Text = "Tài Khoản";
            // 
            // mnsXemThongTinTaiKhoan
            // 
            this.mnsXemThongTinTaiKhoan.Name = "mnsXemThongTinTaiKhoan";
            this.mnsXemThongTinTaiKhoan.Size = new System.Drawing.Size(304, 26);
            this.mnsXemThongTinTaiKhoan.Text = "Xem Thông Tin Tài Khoản";
            // 
            // mnsDangXuat
            // 
            this.mnsDangXuat.Name = "mnsDangXuat";
            this.mnsDangXuat.Size = new System.Drawing.Size(304, 26);
            this.mnsDangXuat.Text = "Đăng Xuất";
            // 
            // mnsQuanLy
            // 
            this.mnsQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsQuanLyXe,
            this.mnsQuanLyKhachHang,
            this.mnsQuanLyHoaDon,
            this.mnsQuanLyNhanVien,
            this.mnsQuanLyNhaCungCap});
            this.mnsQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.mnsQuanLy.Name = "mnsQuanLy";
            this.mnsQuanLy.Size = new System.Drawing.Size(91, 32);
            this.mnsQuanLy.Text = "Quản Lý";
            // 
            // mnsQuanLyXe
            // 
            this.mnsQuanLyXe.Name = "mnsQuanLyXe";
            this.mnsQuanLyXe.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyXe.Text = "Quản Lý Xe";
            // 
            // mnsQuanLyKhachHang
            // 
            this.mnsQuanLyKhachHang.Name = "mnsQuanLyKhachHang";
            this.mnsQuanLyKhachHang.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyKhachHang.Text = "Quản Lý Khách Hàng";
            // 
            // mnsQuanLyHoaDon
            // 
            this.mnsQuanLyHoaDon.Name = "mnsQuanLyHoaDon";
            this.mnsQuanLyHoaDon.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyHoaDon.Text = "Quản Lý Hóa Đơn";
            // 
            // mnsQuanLyNhanVien
            // 
            this.mnsQuanLyNhanVien.Name = "mnsQuanLyNhanVien";
            this.mnsQuanLyNhanVien.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyNhanVien.Text = "Quản Lý Nhân Viên";
            // 
            // mnsQuanLyNhaCungCap
            // 
            this.mnsQuanLyNhaCungCap.Name = "mnsQuanLyNhaCungCap";
            this.mnsQuanLyNhaCungCap.Size = new System.Drawing.Size(280, 26);
            this.mnsQuanLyNhaCungCap.Text = "Quản Lý Nhà Cung Cấp";
            // 
            // mnsThongKe
            // 
            this.mnsThongKe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsThongKeDoanhThu});
            this.mnsThongKe.Name = "mnsThongKe";
            this.mnsThongKe.Size = new System.Drawing.Size(101, 32);
            this.mnsThongKe.Text = "Thống Kê";
            // 
            // mnsThongKeDoanhThu
            // 
            this.mnsThongKeDoanhThu.Name = "mnsThongKeDoanhThu";
            this.mnsThongKeDoanhThu.Size = new System.Drawing.Size(262, 26);
            this.mnsThongKeDoanhThu.Text = "Thống Kê Doanh Thu";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(42, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 128);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Doanh Thu";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 619);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.dGVThongKe);
            this.Controls.Add(this.lbTenNhanVien);
            this.Controls.Add(this.ManHinhChinh);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa Hàng Bán Xe Máy Anh Tuấn";
            ((System.ComponentModel.ISupportInitialize)(this.dGVThongKe)).EndInit();
            this.ManHinhChinh.ResumeLayout(false);
            this.ManHinhChinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dGVThongKe;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Label lbTenNhanVien;
        private System.Windows.Forms.MenuStrip ManHinhChinh;
        private System.Windows.Forms.ToolStripMenuItem mnsTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsXemThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnsDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyXe;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnsQuanLyNhaCungCap;
        private System.Windows.Forms.ToolStripMenuItem mnsThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnsThongKeDoanhThu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
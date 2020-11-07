namespace QuanLyCuaHangXeMay.GiaoDien
{
    partial class ThemXe
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
            this.label18 = new System.Windows.Forms.Label();
            this.cbNhanHang = new System.Windows.Forms.ComboBox();
            this.domainSL = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(194, 232);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(234, 20);
            this.label18.TabIndex = 30;
            // 
            // cbNhanHang
            // 
            this.cbNhanHang.FormattingEnabled = true;
            this.cbNhanHang.Location = new System.Drawing.Point(198, 134);
            this.cbNhanHang.Name = "cbNhanHang";
            this.cbNhanHang.Size = new System.Drawing.Size(234, 24);
            this.cbNhanHang.TabIndex = 29;
            // 
            // domainSL
            // 
            this.domainSL.Location = new System.Drawing.Point(198, 184);
            this.domainSL.Name = "domainSL";
            this.domainSL.Size = new System.Drawing.Size(72, 22);
            this.domainSL.TabIndex = 28;
            this.domainSL.Text = "domainUpDown1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(71, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Đơn Giá:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(71, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Số Lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(71, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nhãn Hàng:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(2, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(537, 42);
            this.label6.TabIndex = 31;
            this.label6.Text = "Hóa Đơn Bán Hàng";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btThoat
            // 
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThoat.Location = new System.Drawing.Point(312, 294);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 45);
            this.btThoat.TabIndex = 33;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btThem.Location = new System.Drawing.Point(73, 294);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(100, 45);
            this.btThem.TabIndex = 32;
            this.btThem.Text = "Thêm Xe";
            this.btThem.UseVisualStyleBackColor = true;
            // 
            // ThemXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 377);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.cbNhanHang);
            this.Controls.Add(this.domainSL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ThemXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemXe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cbNhanHang;
        private System.Windows.Forms.DomainUpDown domainSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThem;
    }
}
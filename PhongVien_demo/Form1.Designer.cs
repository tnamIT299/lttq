namespace PhongVien_demo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_infBonus = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_thuongTru = new System.Windows.Forms.RadioButton();
            this.rad_Toasoan = new System.Windows.Forms.RadioButton();
            this.dtp_nvl = new System.Windows.Forms.DateTimePicker();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad_nu = new System.Windows.Forms.RadioButton();
            this.rad_nam = new System.Windows.Forms.RadioButton();
            this.lb_InforBonus = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_Excel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lv_pv = new System.Windows.Forms.ListView();
            this.cotMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotHoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotGt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cotNgayVL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ptb_Avatar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ PHÓNG VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txt_infBonus);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dtp_nvl);
            this.groupBox1.Controls.Add(this.txt_phone);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.txt_maNV);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lb_InforBonus);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 431);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phóng viên";
            // 
            // txt_infBonus
            // 
            this.txt_infBonus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_infBonus.Location = new System.Drawing.Point(153, 386);
            this.txt_infBonus.Name = "txt_infBonus";
            this.txt_infBonus.Size = new System.Drawing.Size(300, 27);
            this.txt_infBonus.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rad_thuongTru);
            this.groupBox3.Controls.Add(this.rad_Toasoan);
            this.groupBox3.Location = new System.Drawing.Point(117, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 40);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            // 
            // rad_thuongTru
            // 
            this.rad_thuongTru.AutoSize = true;
            this.rad_thuongTru.Location = new System.Drawing.Point(184, 12);
            this.rad_thuongTru.Name = "rad_thuongTru";
            this.rad_thuongTru.Size = new System.Drawing.Size(116, 26);
            this.rad_thuongTru.TabIndex = 10;
            this.rad_thuongTru.TabStop = true;
            this.rad_thuongTru.Text = "Thường trú";
            this.rad_thuongTru.UseVisualStyleBackColor = true;
            this.rad_thuongTru.CheckedChanged += new System.EventHandler(this.rad_thuongTru_CheckedChanged);
            // 
            // rad_Toasoan
            // 
            this.rad_Toasoan.AutoSize = true;
            this.rad_Toasoan.Location = new System.Drawing.Point(6, 12);
            this.rad_Toasoan.Name = "rad_Toasoan";
            this.rad_Toasoan.Size = new System.Drawing.Size(128, 26);
            this.rad_Toasoan.TabIndex = 0;
            this.rad_Toasoan.TabStop = true;
            this.rad_Toasoan.Text = "Tại toà soạn";
            this.rad_Toasoan.UseVisualStyleBackColor = true;
            this.rad_Toasoan.CheckedChanged += new System.EventHandler(this.rad_Toasoan_CheckedChanged);
            // 
            // dtp_nvl
            // 
            this.dtp_nvl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_nvl.CustomFormat = "dd/MM/yyyy";
            this.dtp_nvl.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_nvl.Location = new System.Drawing.Point(153, 271);
            this.dtp_nvl.Name = "dtp_nvl";
            this.dtp_nvl.Size = new System.Drawing.Size(300, 27);
            this.dtp_nvl.TabIndex = 11;
            // 
            // txt_phone
            // 
            this.txt_phone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_phone.Location = new System.Drawing.Point(115, 209);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(338, 27);
            this.txt_phone.TabIndex = 10;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hoten.Location = new System.Drawing.Point(88, 99);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(365, 27);
            this.txt_hoten.TabIndex = 9;
            // 
            // txt_maNV
            // 
            this.txt_maNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_maNV.Location = new System.Drawing.Point(88, 47);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(365, 27);
            this.txt_maNV.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.rad_nu);
            this.groupBox2.Controls.Add(this.rad_nam);
            this.groupBox2.Location = new System.Drawing.Point(117, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 40);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // rad_nu
            // 
            this.rad_nu.AutoSize = true;
            this.rad_nu.Location = new System.Drawing.Point(151, 11);
            this.rad_nu.Name = "rad_nu";
            this.rad_nu.Size = new System.Drawing.Size(51, 26);
            this.rad_nu.TabIndex = 10;
            this.rad_nu.TabStop = true;
            this.rad_nu.Text = "Nữ";
            this.rad_nu.UseVisualStyleBackColor = true;
            // 
            // rad_nam
            // 
            this.rad_nam.AutoSize = true;
            this.rad_nam.Location = new System.Drawing.Point(6, 12);
            this.rad_nam.Name = "rad_nam";
            this.rad_nam.Size = new System.Drawing.Size(65, 26);
            this.rad_nam.TabIndex = 0;
            this.rad_nam.TabStop = true;
            this.rad_nam.Text = "Nam";
            this.rad_nam.UseVisualStyleBackColor = true;
            // 
            // lb_InforBonus
            // 
            this.lb_InforBonus.AutoSize = true;
            this.lb_InforBonus.Location = new System.Drawing.Point(18, 391);
            this.lb_InforBonus.Name = "lb_InforBonus";
            this.lb_InforBonus.Size = new System.Drawing.Size(80, 22);
            this.lb_InforBonus.TabIndex = 6;
            this.lb_InforBonus.Text = "Phụ Cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Loại PV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Vào Làm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.btn_thongke);
            this.groupBox4.Controls.Add(this.btn_sort);
            this.groupBox4.Controls.Add(this.btn_sua);
            this.groupBox4.Controls.Add(this.btn_xoa);
            this.groupBox4.Controls.Add(this.btn_luu);
            this.groupBox4.Controls.Add(this.btn_them);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(543, 43);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(208, 431);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tác Vụ";
            // 
            // btn_thongke
            // 
            this.btn_thongke.Location = new System.Drawing.Point(62, 378);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(107, 38);
            this.btn_thongke.TabIndex = 5;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(62, 310);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(107, 38);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "Sắp xếp";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(62, 242);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(107, 38);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(62, 174);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(107, 38);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(62, 106);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(107, 38);
            this.btn_luu.TabIndex = 1;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(62, 38);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(107, 38);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_Excel
            // 
            this.btn_Excel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excel.Location = new System.Drawing.Point(632, 12);
            this.btn_Excel.Name = "btn_Excel";
            this.btn_Excel.Size = new System.Drawing.Size(107, 38);
            this.btn_Excel.TabIndex = 6;
            this.btn_Excel.Text = "In Excel";
            this.btn_Excel.UseVisualStyleBackColor = true;
            this.btn_Excel.Click += new System.EventHandler(this.btn_Excel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.lv_pv);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 480);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(738, 229);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách phóng viên";
            // 
            // lv_pv
            // 
            this.lv_pv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lv_pv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cotMaNV,
            this.cotHoten,
            this.cotGt,
            this.cotNgayVL});
            this.lv_pv.HideSelection = false;
            this.lv_pv.Location = new System.Drawing.Point(7, 26);
            this.lv_pv.Name = "lv_pv";
            this.lv_pv.Size = new System.Drawing.Size(731, 197);
            this.lv_pv.TabIndex = 0;
            this.lv_pv.UseCompatibleStateImageBehavior = false;
            this.lv_pv.View = System.Windows.Forms.View.Details;
            this.lv_pv.SelectedIndexChanged += new System.EventHandler(this.lv_pv_SelectedIndexChanged);
            // 
            // cotMaNV
            // 
            this.cotMaNV.Text = "Mã NV";
            this.cotMaNV.Width = 114;
            // 
            // cotHoten
            // 
            this.cotHoten.Text = "Họ Tên";
            this.cotHoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cotHoten.Width = 224;
            // 
            // cotGt
            // 
            this.cotGt.Text = "Giới Tính";
            this.cotGt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cotGt.Width = 156;
            // 
            // cotNgayVL
            // 
            this.cotNgayVL.Text = "Ngày Vào Làm";
            this.cotNgayVL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cotNgayVL.Width = 240;
            // 
            // ptb_Avatar
            // 
            this.ptb_Avatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptb_Avatar.Location = new System.Drawing.Point(88, 12);
            this.ptb_Avatar.Name = "ptb_Avatar";
            this.ptb_Avatar.Size = new System.Drawing.Size(58, 29);
            this.ptb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_Avatar.TabIndex = 7;
            this.ptb_Avatar.TabStop = false;
            this.ptb_Avatar.Click += new System.EventHandler(this.ptb_Avatar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 736);
            this.Controls.Add(this.ptb_Avatar);
            this.Controls.Add(this.btn_Excel);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad_nu;
        private System.Windows.Forms.RadioButton rad_nam;
        private System.Windows.Forms.Label lb_InforBonus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_infBonus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_thuongTru;
        private System.Windows.Forms.RadioButton rad_Toasoan;
        private System.Windows.Forms.DateTimePicker dtp_nvl;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_Excel;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lv_pv;
        private System.Windows.Forms.ColumnHeader cotMaNV;
        private System.Windows.Forms.ColumnHeader cotHoten;
        private System.Windows.Forms.ColumnHeader cotGt;
        private System.Windows.Forms.ColumnHeader cotNgayVL;
        private System.Windows.Forms.PictureBox ptb_Avatar;
    }
}


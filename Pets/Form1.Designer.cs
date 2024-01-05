namespace Pets
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rad_chuaBenh = new System.Windows.Forms.RadioButton();
            this.rad_chamSoc = new System.Windows.Forms.RadioButton();
            this.txt_inforBonus = new System.Windows.Forms.TextBox();
            this.lb_inforBonus = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tinhTrang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_ngayNhan = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cannang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_chungloai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenthucung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_madon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lv_pets = new System.Windows.Forms.ListView();
            this.cl_madon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_excel = new System.Windows.Forms.Button();
            this.btn_thongKe = new System.Windows.Forms.Button();
            this.btn_sapXep = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ DOANH THU  DỊCH VỤ CHĂM SÓC THÚ CƯNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.txt_inforBonus);
            this.groupBox1.Controls.Add(this.lb_inforBonus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_tinhTrang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtp_ngayNhan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_cannang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_chungloai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_tenthucung);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_madon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 453);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thú cưng";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.rad_chuaBenh);
            this.groupBox4.Controls.Add(this.rad_chamSoc);
            this.groupBox4.Location = new System.Drawing.Point(116, 336);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(343, 47);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // rad_chuaBenh
            // 
            this.rad_chuaBenh.AutoSize = true;
            this.rad_chuaBenh.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rad_chuaBenh.Location = new System.Drawing.Point(17, 17);
            this.rad_chuaBenh.Name = "rad_chuaBenh";
            this.rad_chuaBenh.Size = new System.Drawing.Size(105, 24);
            this.rad_chuaBenh.TabIndex = 13;
            this.rad_chuaBenh.TabStop = true;
            this.rad_chuaBenh.Text = "Chữa bệnh";
            this.rad_chuaBenh.UseVisualStyleBackColor = true;
            this.rad_chuaBenh.CheckedChanged += new System.EventHandler(this.rad_chuaBenh_CheckedChanged);
            // 
            // rad_chamSoc
            // 
            this.rad_chamSoc.AutoSize = true;
            this.rad_chamSoc.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rad_chamSoc.Location = new System.Drawing.Point(188, 17);
            this.rad_chamSoc.Name = "rad_chamSoc";
            this.rad_chamSoc.Size = new System.Drawing.Size(120, 24);
            this.rad_chamSoc.TabIndex = 14;
            this.rad_chamSoc.TabStop = true;
            this.rad_chamSoc.Text = "Chăm sóc hộ";
            this.rad_chamSoc.UseVisualStyleBackColor = true;
            this.rad_chamSoc.CheckedChanged += new System.EventHandler(this.rad_chamSoc_CheckedChanged);
            // 
            // txt_inforBonus
            // 
            this.txt_inforBonus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_inforBonus.Location = new System.Drawing.Point(116, 402);
            this.txt_inforBonus.Name = "txt_inforBonus";
            this.txt_inforBonus.Size = new System.Drawing.Size(340, 26);
            this.txt_inforBonus.TabIndex = 16;
            // 
            // lb_inforBonus
            // 
            this.lb_inforBonus.AutoSize = true;
            this.lb_inforBonus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lb_inforBonus.Location = new System.Drawing.Point(8, 405);
            this.lb_inforBonus.Name = "lb_inforBonus";
            this.lb_inforBonus.Size = new System.Drawing.Size(67, 20);
            this.lb_inforBonus.TabIndex = 15;
            this.lb_inforBonus.Text = "Số ngày";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(8, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Dịch vụ";
            // 
            // txt_tinhTrang
            // 
            this.txt_tinhTrang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tinhTrang.Location = new System.Drawing.Point(116, 294);
            this.txt_tinhTrang.Name = "txt_tinhTrang";
            this.txt_tinhTrang.Size = new System.Drawing.Size(343, 26);
            this.txt_tinhTrang.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(8, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tình trạng";
            // 
            // dtp_ngayNhan
            // 
            this.dtp_ngayNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_ngayNhan.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayNhan.Location = new System.Drawing.Point(116, 240);
            this.dtp_ngayNhan.Name = "dtp_ngayNhan";
            this.dtp_ngayNhan.Size = new System.Drawing.Size(343, 26);
            this.dtp_ngayNhan.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(8, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày nhận";
            // 
            // txt_cannang
            // 
            this.txt_cannang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cannang.Location = new System.Drawing.Point(116, 183);
            this.txt_cannang.Name = "txt_cannang";
            this.txt_cannang.Size = new System.Drawing.Size(343, 26);
            this.txt_cannang.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(8, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Cân nặng";
            // 
            // txt_chungloai
            // 
            this.txt_chungloai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_chungloai.Location = new System.Drawing.Point(116, 130);
            this.txt_chungloai.Name = "txt_chungloai";
            this.txt_chungloai.Size = new System.Drawing.Size(343, 26);
            this.txt_chungloai.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(8, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Chủng loại";
            // 
            // txt_tenthucung
            // 
            this.txt_tenthucung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenthucung.Location = new System.Drawing.Point(116, 88);
            this.txt_tenthucung.Name = "txt_tenthucung";
            this.txt_tenthucung.Size = new System.Drawing.Size(343, 26);
            this.txt_tenthucung.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(8, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên thú cưng";
            // 
            // txt_madon
            // 
            this.txt_madon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_madon.Location = new System.Drawing.Point(116, 37);
            this.txt_madon.Name = "txt_madon";
            this.txt_madon.Size = new System.Drawing.Size(343, 26);
            this.txt_madon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(7, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn";
            // 
            // lv_pets
            // 
            this.lv_pets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_pets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_madon,
            this.cl_name,
            this.cl_type,
            this.cl_date});
            this.lv_pets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_pets.HideSelection = false;
            this.lv_pets.Location = new System.Drawing.Point(10, 25);
            this.lv_pets.Name = "lv_pets";
            this.lv_pets.Size = new System.Drawing.Size(517, 410);
            this.lv_pets.TabIndex = 3;
            this.lv_pets.UseCompatibleStateImageBehavior = false;
            this.lv_pets.View = System.Windows.Forms.View.Details;
            this.lv_pets.SelectedIndexChanged += new System.EventHandler(this.lv_pets_SelectedIndexChanged);
            // 
            // cl_madon
            // 
            this.cl_madon.Text = "Mã Đơn";
            this.cl_madon.Width = 90;
            // 
            // cl_name
            // 
            this.cl_name.Text = "Tên Thú Cưng";
            this.cl_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_name.Width = 150;
            // 
            // cl_type
            // 
            this.cl_type.Text = "Chủng Loại";
            this.cl_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_type.Width = 150;
            // 
            // cl_date
            // 
            this.cl_date.Text = "Ngày Nhận";
            this.cl_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_date.Width = 120;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lv_pets);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(502, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 453);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách thú cưng";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_excel);
            this.groupBox2.Controls.Add(this.btn_thongKe);
            this.groupBox2.Controls.Add(this.btn_sapXep);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_luu);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 531);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 111);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác vụ";
            // 
            // btn_excel
            // 
            this.btn_excel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_excel.Location = new System.Drawing.Point(891, 43);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(97, 44);
            this.btn_excel.TabIndex = 6;
            this.btn_excel.Text = "In Excel";
            this.btn_excel.UseVisualStyleBackColor = true;
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click_1);
            // 
            // btn_thongKe
            // 
            this.btn_thongKe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_thongKe.Location = new System.Drawing.Point(746, 43);
            this.btn_thongKe.Name = "btn_thongKe";
            this.btn_thongKe.Size = new System.Drawing.Size(97, 44);
            this.btn_thongKe.TabIndex = 5;
            this.btn_thongKe.Text = "Thống kê";
            this.btn_thongKe.UseVisualStyleBackColor = true;
            this.btn_thongKe.Click += new System.EventHandler(this.btn_thongKe_Click_1);
            // 
            // btn_sapXep
            // 
            this.btn_sapXep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sapXep.Location = new System.Drawing.Point(601, 43);
            this.btn_sapXep.Name = "btn_sapXep";
            this.btn_sapXep.Size = new System.Drawing.Size(97, 44);
            this.btn_sapXep.TabIndex = 4;
            this.btn_sapXep.Text = "Sắp xếp";
            this.btn_sapXep.UseVisualStyleBackColor = true;
            this.btn_sapXep.Click += new System.EventHandler(this.btn_sapXep_Click_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_xoa.Location = new System.Drawing.Point(456, 43);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(97, 44);
            this.btn_xoa.TabIndex = 3;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click_1);
            // 
            // btn_sua
            // 
            this.btn_sua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_sua.Location = new System.Drawing.Point(311, 43);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(97, 44);
            this.btn_sua.TabIndex = 2;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click_1);
            // 
            // btn_luu
            // 
            this.btn_luu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_luu.Location = new System.Drawing.Point(166, 43);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(97, 44);
            this.btn_luu.TabIndex = 1;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click_1);
            // 
            // btn_them
            // 
            this.btn_them.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_them.Location = new System.Drawing.Point(21, 43);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(97, 44);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 661);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenthucung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_madon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_ngayNhan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cannang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_chungloai;
        private System.Windows.Forms.TextBox txt_inforBonus;
        private System.Windows.Forms.Label lb_inforBonus;
        private System.Windows.Forms.RadioButton rad_chamSoc;
        private System.Windows.Forms.RadioButton rad_chuaBenh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tinhTrang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lv_pets;
        private System.Windows.Forms.ColumnHeader cl_madon;
        private System.Windows.Forms.ColumnHeader cl_name;
        private System.Windows.Forms.ColumnHeader cl_type;
        private System.Windows.Forms.ColumnHeader cl_date;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_excel;
        private System.Windows.Forms.Button btn_thongKe;
        private System.Windows.Forms.Button btn_sapXep;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_them;
    }
}


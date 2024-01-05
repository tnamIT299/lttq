namespace PhongVien
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
            this.rad_toaSoan = new System.Windows.Forms.RadioButton();
            this.rad_thuongTru = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.txt_addText = new System.Windows.Forms.TextBox();
            this.dtp_ngayVaolam = new System.Windows.Forms.DateTimePicker();
            this.txt_dienThoai = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_maPV = new System.Windows.Forms.TextBox();
            this.lb_addText = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_sapxep = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lv_phongvien = new System.Windows.Forms.ListView();
            this.cl_maPV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_hoten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_gioitinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_ngayVaolam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ PHÓNG VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txt_addText);
            this.groupBox1.Controls.Add(this.dtp_ngayVaolam);
            this.groupBox1.Controls.Add(this.txt_dienThoai);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.txt_maPV);
            this.groupBox1.Controls.Add(this.lb_addText);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(450, 372);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phóng viên ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rad_toaSoan);
            this.groupBox4.Controls.Add(this.rad_thuongTru);
            this.groupBox4.Location = new System.Drawing.Point(104, 269);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(340, 44);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // rad_toaSoan
            // 
            this.rad_toaSoan.AutoSize = true;
            this.rad_toaSoan.Checked = true;
            this.rad_toaSoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_toaSoan.ForeColor = System.Drawing.Color.Black;
            this.rad_toaSoan.Location = new System.Drawing.Point(35, 16);
            this.rad_toaSoan.Name = "rad_toaSoan";
            this.rad_toaSoan.Size = new System.Drawing.Size(114, 24);
            this.rad_toaSoan.TabIndex = 13;
            this.rad_toaSoan.TabStop = true;
            this.rad_toaSoan.Text = "Tại toà soạn";
            this.rad_toaSoan.UseVisualStyleBackColor = true;
            this.rad_toaSoan.CheckedChanged += new System.EventHandler(this.rad_toaSoan_CheckedChanged);
            // 
            // rad_thuongTru
            // 
            this.rad_thuongTru.AutoSize = true;
            this.rad_thuongTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_thuongTru.ForeColor = System.Drawing.Color.Black;
            this.rad_thuongTru.Location = new System.Drawing.Point(198, 15);
            this.rad_thuongTru.Name = "rad_thuongTru";
            this.rad_thuongTru.Size = new System.Drawing.Size(108, 24);
            this.rad_thuongTru.TabIndex = 14;
            this.rad_thuongTru.Text = "Thường trú ";
            this.rad_thuongTru.UseVisualStyleBackColor = true;
            this.rad_thuongTru.CheckedChanged += new System.EventHandler(this.rad_thuongTru_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_male);
            this.groupBox3.Controls.Add(this.rad_female);
            this.groupBox3.Location = new System.Drawing.Point(104, 123);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(337, 44);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_male.ForeColor = System.Drawing.Color.Black;
            this.rad_male.Location = new System.Drawing.Point(17, 15);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(60, 24);
            this.rad_male.TabIndex = 9;
            this.rad_male.Text = "Nam";
            this.rad_male.UseVisualStyleBackColor = true;
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_female.ForeColor = System.Drawing.Color.Black;
            this.rad_female.Location = new System.Drawing.Point(180, 16);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(47, 24);
            this.rad_female.TabIndex = 10;
            this.rad_female.Text = "Nữ";
            this.rad_female.UseVisualStyleBackColor = true;
            // 
            // txt_addText
            // 
            this.txt_addText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addText.Location = new System.Drawing.Point(151, 334);
            this.txt_addText.Name = "txt_addText";
            this.txt_addText.Size = new System.Drawing.Size(293, 24);
            this.txt_addText.TabIndex = 15;
            // 
            // dtp_ngayVaolam
            // 
            this.dtp_ngayVaolam.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayVaolam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayVaolam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayVaolam.Location = new System.Drawing.Point(141, 234);
            this.dtp_ngayVaolam.Name = "dtp_ngayVaolam";
            this.dtp_ngayVaolam.Size = new System.Drawing.Size(303, 24);
            this.dtp_ngayVaolam.TabIndex = 12;
            // 
            // txt_dienThoai
            // 
            this.txt_dienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dienThoai.Location = new System.Drawing.Point(104, 187);
            this.txt_dienThoai.Name = "txt_dienThoai";
            this.txt_dienThoai.Size = new System.Drawing.Size(340, 24);
            this.txt_dienThoai.TabIndex = 11;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hoten.Location = new System.Drawing.Point(95, 89);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(349, 24);
            this.txt_hoten.TabIndex = 8;
            // 
            // txt_maPV
            // 
            this.txt_maPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_maPV.Location = new System.Drawing.Point(95, 40);
            this.txt_maPV.Name = "txt_maPV";
            this.txt_maPV.Size = new System.Drawing.Size(349, 24);
            this.txt_maPV.TabIndex = 7;
            // 
            // lb_addText
            // 
            this.lb_addText.AutoSize = true;
            this.lb_addText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_addText.ForeColor = System.Drawing.Color.Black;
            this.lb_addText.Location = new System.Drawing.Point(7, 334);
            this.lb_addText.Name = "lb_addText";
            this.lb_addText.Size = new System.Drawing.Size(138, 22);
            this.lb_addText.TabIndex = 6;
            this.lb_addText.Text = "Số giờ làm thêm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Loại PV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày Vào Làm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Điện Thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giới Tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã NV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_thongke);
            this.groupBox2.Controls.Add(this.btn_sapxep);
            this.groupBox2.Controls.Add(this.btn_sua);
            this.groupBox2.Controls.Add(this.btn_xoa);
            this.groupBox2.Controls.Add(this.btn_luu);
            this.groupBox2.Controls.Add(this.btn_them);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(489, 57);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 372);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác Vụ";
            // 
            // btn_thongke
            // 
            this.btn_thongke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_thongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongke.ForeColor = System.Drawing.Color.Black;
            this.btn_thongke.Location = new System.Drawing.Point(70, 325);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(110, 34);
            this.btn_thongke.TabIndex = 5;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.UseVisualStyleBackColor = false;
            this.btn_thongke.Click += new System.EventHandler(this.btn_thongke_Click);
            // 
            // btn_sapxep
            // 
            this.btn_sapxep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sapxep.ForeColor = System.Drawing.Color.Black;
            this.btn_sapxep.Location = new System.Drawing.Point(70, 268);
            this.btn_sapxep.Name = "btn_sapxep";
            this.btn_sapxep.Size = new System.Drawing.Size(110, 34);
            this.btn_sapxep.TabIndex = 4;
            this.btn_sapxep.Text = "Sắp xếp";
            this.btn_sapxep.UseVisualStyleBackColor = false;
            this.btn_sapxep.Click += new System.EventHandler(this.btn_sapxep_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(70, 211);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(110, 34);
            this.btn_sua.TabIndex = 3;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(70, 154);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(110, 34);
            this.btn_xoa.TabIndex = 2;
            this.btn_xoa.Text = "Xoá";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.ForeColor = System.Drawing.Color.Black;
            this.btn_luu.Location = new System.Drawing.Point(70, 97);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(110, 34);
            this.btn_luu.TabIndex = 1;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(70, 40);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(110, 34);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label9.Location = new System.Drawing.Point(12, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Danh sách phóng viên";
            // 
            // lv_phongvien
            // 
            this.lv_phongvien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_maPV,
            this.cl_hoten,
            this.cl_gioitinh,
            this.cl_ngayVaolam});
            this.lv_phongvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_phongvien.HideSelection = false;
            this.lv_phongvien.Location = new System.Drawing.Point(13, 470);
            this.lv_phongvien.Name = "lv_phongvien";
            this.lv_phongvien.Size = new System.Drawing.Size(714, 202);
            this.lv_phongvien.TabIndex = 4;
            this.lv_phongvien.UseCompatibleStateImageBehavior = false;
            this.lv_phongvien.View = System.Windows.Forms.View.Details;
            this.lv_phongvien.SelectedIndexChanged += new System.EventHandler(this.lv_phongvien_SelectedIndexChanged);
            // 
            // cl_maPV
            // 
            this.cl_maPV.Text = "Mã PV";
            this.cl_maPV.Width = 100;
            // 
            // cl_hoten
            // 
            this.cl_hoten.Text = "Họ Tên";
            this.cl_hoten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_hoten.Width = 220;
            // 
            // cl_gioitinh
            // 
            this.cl_gioitinh.Text = "Giới Tính";
            this.cl_gioitinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_gioitinh.Width = 180;
            // 
            // cl_ngayVaolam
            // 
            this.cl_ngayVaolam.Text = "Ngày Vào Làm";
            this.cl_ngayVaolam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_ngayVaolam.Width = 220;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 679);
            this.Controls.Add(this.lv_phongvien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_maPV;
        private System.Windows.Forms.Label lb_addText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rad_female;
        private System.Windows.Forms.RadioButton rad_male;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.RadioButton rad_thuongTru;
        private System.Windows.Forms.RadioButton rad_toaSoan;
        private System.Windows.Forms.DateTimePicker dtp_ngayVaolam;
        private System.Windows.Forms.TextBox txt_dienThoai;
        private System.Windows.Forms.TextBox txt_addText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_sapxep;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lv_phongvien;
        private System.Windows.Forms.ColumnHeader cl_maPV;
        private System.Windows.Forms.ColumnHeader cl_hoten;
        private System.Windows.Forms.ColumnHeader cl_gioitinh;
        private System.Windows.Forms.ColumnHeader cl_ngayVaolam;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}


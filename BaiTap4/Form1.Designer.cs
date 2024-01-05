namespace BaiTap4
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
            this.txt_phuthu = new System.Windows.Forms.TextBox();
            this.lb_phuthu = new System.Windows.Forms.Label();
            this.grb_view = new System.Windows.Forms.GroupBox();
            this.rad_2D = new System.Windows.Forms.RadioButton();
            this.rad_3D = new System.Windows.Forms.RadioButton();
            this.grb_type = new System.Windows.Forms.GroupBox();
            this.rad_Romantic = new System.Windows.Forms.RadioButton();
            this.rad_Action = new System.Windows.Forms.RadioButton();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_country = new System.Windows.Forms.TextBox();
            this.txt_tenPhim = new System.Windows.Forms.TextBox();
            this.txt_madon = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_analyze = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lv_phim = new System.Windows.Forms.ListView();
            this.cot_Madon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cot_tenPhim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cot_Theloai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cot_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.grb_view.SuspendLayout();
            this.grb_type.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Honeydew;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(707, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ DOANH THU PHIM CHIẾU RẠP ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox1.Controls.Add(this.txt_phuthu);
            this.groupBox1.Controls.Add(this.lb_phuthu);
            this.groupBox1.Controls.Add(this.grb_view);
            this.groupBox1.Controls.Add(this.grb_type);
            this.groupBox1.Controls.Add(this.txt_age);
            this.groupBox1.Controls.Add(this.txt_country);
            this.groupBox1.Controls.Add(this.txt_tenPhim);
            this.groupBox1.Controls.Add(this.txt_madon);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtp_start);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 398);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phim";
            // 
            // txt_phuthu
            // 
            this.txt_phuthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phuthu.Location = new System.Drawing.Point(159, 364);
            this.txt_phuthu.Name = "txt_phuthu";
            this.txt_phuthu.Size = new System.Drawing.Size(226, 23);
            this.txt_phuthu.TabIndex = 21;
            // 
            // lb_phuthu
            // 
            this.lb_phuthu.AutoSize = true;
            this.lb_phuthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phuthu.Location = new System.Drawing.Point(5, 367);
            this.lb_phuthu.Name = "lb_phuthu";
            this.lb_phuthu.Size = new System.Drawing.Size(116, 17);
            this.lb_phuthu.TabIndex = 20;
            this.lb_phuthu.Text = "Phụ thu ghế đôi: ";
            // 
            // grb_view
            // 
            this.grb_view.Controls.Add(this.rad_2D);
            this.grb_view.Controls.Add(this.rad_3D);
            this.grb_view.Location = new System.Drawing.Point(91, 308);
            this.grb_view.Name = "grb_view";
            this.grb_view.Size = new System.Drawing.Size(262, 41);
            this.grb_view.TabIndex = 19;
            this.grb_view.TabStop = false;
            // 
            // rad_2D
            // 
            this.rad_2D.AutoSize = true;
            this.rad_2D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_2D.Location = new System.Drawing.Point(8, 17);
            this.rad_2D.Name = "rad_2D";
            this.rad_2D.Size = new System.Drawing.Size(44, 21);
            this.rad_2D.TabIndex = 10;
            this.rad_2D.TabStop = true;
            this.rad_2D.Text = "2D";
            this.rad_2D.UseVisualStyleBackColor = true;
            this.rad_2D.CheckedChanged += new System.EventHandler(this.rad_2D_CheckedChanged);
            // 
            // rad_3D
            // 
            this.rad_3D.AutoSize = true;
            this.rad_3D.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_3D.Location = new System.Drawing.Point(101, 18);
            this.rad_3D.Name = "rad_3D";
            this.rad_3D.Size = new System.Drawing.Size(44, 21);
            this.rad_3D.TabIndex = 11;
            this.rad_3D.TabStop = true;
            this.rad_3D.Text = "3D";
            this.rad_3D.UseVisualStyleBackColor = true;
            this.rad_3D.CheckedChanged += new System.EventHandler(this.rad_3D_CheckedChanged);
            // 
            // grb_type
            // 
            this.grb_type.Controls.Add(this.rad_Romantic);
            this.grb_type.Controls.Add(this.rad_Action);
            this.grb_type.Location = new System.Drawing.Point(84, 180);
            this.grb_type.Name = "grb_type";
            this.grb_type.Size = new System.Drawing.Size(269, 41);
            this.grb_type.TabIndex = 18;
            this.grb_type.TabStop = false;
            // 
            // rad_Romantic
            // 
            this.rad_Romantic.AutoSize = true;
            this.rad_Romantic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Romantic.Location = new System.Drawing.Point(15, 15);
            this.rad_Romantic.Name = "rad_Romantic";
            this.rad_Romantic.Size = new System.Drawing.Size(84, 21);
            this.rad_Romantic.TabIndex = 4;
            this.rad_Romantic.TabStop = true;
            this.rad_Romantic.Text = "Tình cảm";
            this.rad_Romantic.UseVisualStyleBackColor = true;
            // 
            // rad_Action
            // 
            this.rad_Action.AutoSize = true;
            this.rad_Action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rad_Action.Location = new System.Drawing.Point(148, 15);
            this.rad_Action.Name = "rad_Action";
            this.rad_Action.Size = new System.Drawing.Size(96, 21);
            this.rad_Action.TabIndex = 5;
            this.rad_Action.TabStop = true;
            this.rad_Action.Text = "Hành động";
            this.rad_Action.UseVisualStyleBackColor = true;
            // 
            // txt_age
            // 
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(127, 280);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(226, 23);
            this.txt_age.TabIndex = 16;
            // 
            // txt_country
            // 
            this.txt_country.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_country.Location = new System.Drawing.Point(84, 151);
            this.txt_country.Name = "txt_country";
            this.txt_country.Size = new System.Drawing.Size(269, 23);
            this.txt_country.TabIndex = 15;
            // 
            // txt_tenPhim
            // 
            this.txt_tenPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenPhim.Location = new System.Drawing.Point(86, 101);
            this.txt_tenPhim.Name = "txt_tenPhim";
            this.txt_tenPhim.Size = new System.Drawing.Size(267, 23);
            this.txt_tenPhim.TabIndex = 14;
            // 
            // txt_madon
            // 
            this.txt_madon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_madon.Location = new System.Drawing.Point(86, 49);
            this.txt_madon.Name = "txt_madon";
            this.txt_madon.Size = new System.Drawing.Size(267, 23);
            this.txt_madon.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Định dạng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Độ tuổi quy định:";
            // 
            // dtp_start
            // 
            this.dtp_start.CustomFormat = "dd/MM/yyyy";
            this.dtp_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_start.Location = new System.Drawing.Point(127, 237);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(226, 23);
            this.dtp_start.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày công chiếu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thể loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Quốc gia:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên phim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.btn_analyze);
            this.groupBox2.Controls.Add(this.btn_sort);
            this.groupBox2.Controls.Add(this.btn_edit);
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.btn_save);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1063, 87);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tác Vụ";
            // 
            // btn_analyze
            // 
            this.btn_analyze.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_analyze.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analyze.Location = new System.Drawing.Point(941, 42);
            this.btn_analyze.Name = "btn_analyze";
            this.btn_analyze.Size = new System.Drawing.Size(116, 37);
            this.btn_analyze.TabIndex = 6;
            this.btn_analyze.Text = "Thống kê";
            this.btn_analyze.UseVisualStyleBackColor = false;
            this.btn_analyze.Click += new System.EventHandler(this.btn_analyze_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sort.Location = new System.Drawing.Point(762, 42);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(116, 37);
            this.btn_sort.TabIndex = 5;
            this.btn_sort.Text = "Sắp xếp";
            this.btn_sort.UseVisualStyleBackColor = false;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(582, 42);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(116, 37);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(402, 42);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(116, 37);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Xoá";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(222, 42);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(116, 37);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(42, 42);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(116, 37);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-138, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lv_phim
            // 
            this.lv_phim.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lv_phim.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cot_Madon,
            this.cot_tenPhim,
            this.cot_Theloai,
            this.cot_Date});
            this.lv_phim.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_phim.HideSelection = false;
            this.lv_phim.Location = new System.Drawing.Point(414, 72);
            this.lv_phim.Name = "lv_phim";
            this.lv_phim.Size = new System.Drawing.Size(684, 393);
            this.lv_phim.TabIndex = 3;
            this.lv_phim.UseCompatibleStateImageBehavior = false;
            this.lv_phim.View = System.Windows.Forms.View.Details;
            this.lv_phim.SelectedIndexChanged += new System.EventHandler(this.lv_phim_SelectedIndexChanged);
            // 
            // cot_Madon
            // 
            this.cot_Madon.Text = "Mã đơn";
            this.cot_Madon.Width = 90;
            // 
            // cot_tenPhim
            // 
            this.cot_tenPhim.Text = "Tên phim";
            this.cot_tenPhim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cot_tenPhim.Width = 200;
            // 
            // cot_Theloai
            // 
            this.cot_Theloai.Text = "Thể loại";
            this.cot_Theloai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cot_Theloai.Width = 190;
            // 
            // cot_Date
            // 
            this.cot_Date.Text = "Ngày công chiếu";
            this.cot_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cot_Date.Width = 250;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1104, 594);
            this.Controls.Add(this.lv_phim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grb_view.ResumeLayout(false);
            this.grb_view.PerformLayout();
            this.grb_type.ResumeLayout(false);
            this.grb_type.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rad_Action;
        private System.Windows.Forms.RadioButton rad_Romantic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rad_3D;
        private System.Windows.Forms.RadioButton rad_2D;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.TextBox txt_tenPhim;
        private System.Windows.Forms.TextBox txt_madon;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_country;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_analyze;
        private System.Windows.Forms.ListView lv_phim;
        private System.Windows.Forms.ColumnHeader cot_Madon;
        private System.Windows.Forms.ColumnHeader cot_tenPhim;
        private System.Windows.Forms.ColumnHeader cot_Theloai;
        private System.Windows.Forms.ColumnHeader cot_Date;
        private System.Windows.Forms.GroupBox grb_type;
        private System.Windows.Forms.GroupBox grb_view;
        private System.Windows.Forms.TextBox txt_phuthu;
        private System.Windows.Forms.Label lb_phuthu;
    }
}


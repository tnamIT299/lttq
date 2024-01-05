
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BOPHIMEntities1 db = new BOPHIMEntities1();

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Tạo một LinearGradientBrush
            LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,      // Khu vực vẽ gradient
                Color.White,                // Màu bắt đầu
                Color.LightGreen,               // Màu kết thúc
                LinearGradientMode.Vertical); // Hướng gradient (dọc)

            // Vẽ gradient lên form
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            reset();
           
        }
        void reset()
    {
        txt_madon.Clear();
        txt_madon.Focus();
        txt_tenPhim.Clear();
        txt_country.Clear();
        txt_age.Clear();
        txt_phuthu.Clear();

    }
        private bool CheckMaDon(string maDon)
        {
           
            return db.PHIMs.Any(p => p.MADON == maDon);
        }
        private void btn_save_Click(object sender, EventArgs e)
        {

            string maDon = txt_madon.Text;
            string tenPhim = txt_tenPhim.Text;
            string quocGia = txt_country.Text;
            string age_Permiss = txt_age.Text;
            string phuthu  = txt_phuthu.Text;
            DateTime ngayCongchieu = dtp_start.Value;
            bool romantic = rad_Romantic.Checked;
            bool film_2D = rad_2D.Checked;

            if (string.IsNullOrEmpty(maDon) || string.IsNullOrEmpty(tenPhim) || string.IsNullOrEmpty(quocGia) || string.IsNullOrEmpty(age_Permiss))
            {
                MessageBox.Show("Mã đơn , tên phim , tên quốc gia không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckMaDon(maDon))
            {
                MessageBox.Show("Mã đơn đã tồn tại trong cơ sở dữ liệu. Vui lòng chọn mã đơn khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            PHIM f = new PHIM();
            f.MADON = maDon;
            f.TENPHIM = tenPhim;
            f.QUOCGIA = quocGia;
            if (romantic) { f.THELOAI = "Tình cảm"; }
            else { f.THELOAI = "Hành động"; }
            f.NGAYCONGCHIEU = ngayCongchieu;
            f.TUOIQUYDINH = Convert.ToInt32(age_Permiss);
            if (film_2D)
            {
                f.MADINHDANG = 0;
                f.GIA= 110000 + float.Parse(phuthu);
            }
            else if (rad_3D.Checked)
            {
                f.MADINHDANG = 1;
                f.GIA = 210000 + float.Parse(phuthu);
            }

            db.PHIMs.Add(f);
            db.SaveChanges();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetDataFromDatabase();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string maDon = txt_madon.Text;
            PHIM filmUpdate = db.PHIMs.SingleOrDefault(f => f.MADON == maDon);
            bool romantic = rad_Romantic.Checked;
            bool film_2D = rad_2D.Checked;
            if (filmUpdate != null)
            {
                filmUpdate.MADON = txt_madon.Text;
                filmUpdate.TENPHIM = txt_tenPhim.Text;
                filmUpdate.QUOCGIA = txt_country.Text;
                if (romantic)
                {
                    filmUpdate.THELOAI = "Tình cảm";
                }
                else
                {
                    filmUpdate.THELOAI = "Hành động";
                }

                
                filmUpdate.NGAYCONGCHIEU = dtp_start.Value;
                filmUpdate.TUOIQUYDINH = Convert.ToInt32(txt_age.Text);
                if (film_2D)
                {
                    filmUpdate.MADINHDANG = 0;
                }
                else
                {
                    filmUpdate.MADINHDANG = 1;
                }
                filmUpdate.GIA = Convert.ToDouble(txt_phuthu.Text);
                db.SaveChanges();
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetDataFromDatabase();
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {

            var sortedFilm = db.PHIMs
            .OrderByDescending(f => DateTime.Now.Year -  f.NGAYCONGCHIEU.Year)
            .ThenBy(f => f.TUOIQUYDINH)
            .ToList();

            lv_phim.Items.Clear();
            foreach (var item in sortedFilm)
            {
                ListViewItem listViewItem = new ListViewItem(item.MADON);
                listViewItem.SubItems.Add(item.TENPHIM);
                listViewItem.SubItems.Add(item.THELOAI);
                listViewItem.SubItems.Add(item.NGAYCONGCHIEU.ToString("dd/MM/yyyy"));

                TimeSpan thoiGian = DateTime.Now - item.NGAYCONGCHIEU;
                if (thoiGian.TotalDays <= 7)
                {
                    listViewItem.BackColor = Color.Yellow;
                }

                lv_phim.Items.Add(listViewItem);
            }
        }


        private void btn_analyze_Click(object sender, EventArgs e)
        {
            var loaiPhimList = db.PHIMs.ToList();

            int count_2D = 0;
            int count_3D = 0;
            double totalPrice_2D = 0;
            double totalPrice_3D = 0;

            foreach (var loaiPhim in loaiPhimList)
            {

                if (loaiPhim.MADINHDANG == 0)
                {
                    count_2D++;
                    totalPrice_2D = totalPrice_2D + loaiPhim.GIA;
                }
                else if (loaiPhim.MADINHDANG == 1)
                {
                    count_3D++;
                    totalPrice_3D += loaiPhim.GIA;
                }
            }
            MessageBox.Show("Thống kê : " +
            "Tổng có " + count_2D + " phim 2D và " + count_3D + " phim 3D." + "\n" +
            "Tổng doanh thu : " + "\n" + "Phim 2D : " + totalPrice_2D.ToString("N2") + " VNĐ "
                                + "\n" + "Phim 3D : " + totalPrice_3D.ToString("N2") + " VNĐ "
            , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lv_phim.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa bộ phim này?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string madon_delete = lv_phim.SelectedItems[0].Text;
                    lv_phim.Items.Remove(lv_phim.SelectedItems[0]);
                    PHIM selectedFilm = db.PHIMs.Where(p => p.MADON == madon_delete).SingleOrDefault();
                    db.PHIMs.Remove(selectedFilm);
                    db.SaveChanges();
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn bộ phim nào để xoá!", "Thông báo");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rad_Romantic.Checked = true;
            rad_2D.Checked = true;
            lb_phuthu.Text = "Tổng thu";

            foreach (var item in db.PHIMs)
            {
                ListViewItem listViewItem = new ListViewItem(item.MADON);
                listViewItem.SubItems.Add(item.TENPHIM);
                listViewItem.SubItems.Add(item.THELOAI);
                listViewItem.SubItems.Add(item.NGAYCONGCHIEU.ToString("dd/MM/yyyy"));


                int comingSoon = DateTime.Now.Year - item.NGAYCONGCHIEU.Year;
                TimeSpan thoiGian = DateTime.Now - item.NGAYCONGCHIEU;
                if (thoiGian.TotalDays <= 7)
                {
                    listViewItem.BackColor = Color.Yellow; 
                }

                lv_phim.Items.Add(listViewItem);
            }
        }

       
        private void rad_2D_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_2D.Checked)
            {
                lb_phuthu.Text = "Phụ thu ghế đôi";
            }
        }

        private void rad_3D_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_3D.Checked)
            {
                lb_phuthu.Text = "Phụ thu suất chiếu ĐB";
            }
        }
        private void GetDataFromDatabase()
        {
            lv_phim.Items.Clear();
            foreach (var item in db.PHIMs)
            {
                ListViewItem listViewItem = new ListViewItem(item.MADON);
                listViewItem.SubItems.Add(item.TENPHIM);
                listViewItem.SubItems.Add(item.THELOAI);
                listViewItem.SubItems.Add(item.NGAYCONGCHIEU.ToString("dd/MM/yyyy"));

                TimeSpan thoiGian = DateTime.Now - item.NGAYCONGCHIEU;
                if (thoiGian.TotalDays <= 7)
                {
                    listViewItem.BackColor = Color.Yellow;
                }

                lv_phim.Items.Add(listViewItem);
            }
        }

        private void lv_phim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_phim.SelectedItems.Count > 0)
            {
                txt_madon.Text = lv_phim.SelectedItems[0].Text;
                txt_tenPhim.Text = lv_phim.SelectedItems[0].SubItems[1].Text;
               // txt_country.Text = lv_phim.SelectedItems[0].SubItems[2].Text;
                string theLoai = lv_phim.SelectedItems[0].SubItems[2].Text;
                dtp_start.Text = lv_phim.SelectedItems[0].SubItems[3].Text;
                

                if (theLoai == "Tình cảm")
                {
                    rad_Romantic.Checked = true;
                    rad_Action.Checked = false;
                    
                }
                else if (theLoai == "Hành động")
                {
                    rad_Romantic.Checked = false;
                    rad_Action.Checked = true;
                   
                }

                var gia = db.PHIMs
                               .Where(f => f.MADON == txt_madon.Text)
                               .Select(f => f.GIA)
                               .FirstOrDefault();
                txt_phuthu.Text = gia.ToString();

                var type = db.PHIMs
                              .Where(f => f.MADON == txt_madon.Text)
                              .Select(f => f.MADINHDANG)
                              .FirstOrDefault();

                var age = db.PHIMs
                              .Where(f => f.MADON == txt_madon.Text)
                              .Select(f => f.TUOIQUYDINH)
                              .FirstOrDefault();
                txt_age.Text = age.ToString();

                var quocGia = db.PHIMs
                              .Where(f => f.MADON == txt_madon.Text)
                              .Select(f => f.QUOCGIA)
                              .FirstOrDefault();
                txt_country.Text = quocGia.ToString();

                switch (type)
                {
                    case 0:
                        rad_2D.Checked = true;
                        rad_3D.Checked = false;
                       
                        break;
                    case 1:
                        rad_2D.Checked = false;
                        rad_3D.Checked = true;
                       
                        break;
                    default:
                        rad_2D.Checked = false;
                        rad_3D.Checked = false;
                        
                        break;
                }
            }
            }
    }
 }


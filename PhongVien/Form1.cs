using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PHONGVIENEntities2 db = new PHONGVIENEntities2();

        private void Form1_Load(object sender, EventArgs e)
        {
            rad_male.Checked = true;
            rad_toaSoan.Checked = true;
            lb_addText.Text = "Số giờ làm thêm";
            GetFromDatabase();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Xác nhận thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void rad_toaSoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_toaSoan.Checked)
            {
                lb_addText.Text = "Số giờ làm thêm";
            }
        }

        private void rad_thuongTru_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_thuongTru.Checked)
            {
                lb_addText.Text = "Phụ cấp";
            }
        }

        void reset()
        {
            txt_maPV.Clear();
            txt_maPV.Focus();
            txt_hoten.Clear();
            txt_dienThoai.Clear();
            txt_addText.Clear ();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            reset();
        }
        private bool CheckMaPV(string maPV)
        {

            return db.PHONGVIENs.Any(p => p.MaPV == maPV);
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            string maPV = txt_maPV.Text;
            string hoTen = txt_hoten.Text;
            string dienThoai = txt_dienThoai.Text;
            decimal bonus = Convert.ToDecimal(txt_addText.Text);
            DateTime ngayVaolam = dtp_ngayVaolam.Value;
            bool male = rad_male.Checked;
            bool thuongTru = rad_thuongTru.Checked;
            if (string.IsNullOrEmpty(maPV) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Mã PV , Họ tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CheckMaPV(maPV))
            {
                MessageBox.Show("Mã PV đã tồn tại trong cơ sở dữ liệu. Vui lòng chọn mã đơn khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(ngayVaolam > DateTime.Now)
            {
                MessageBox.Show("Ngày vào làm không được lớn hơn ngày hiện tại ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PHONGVIEN pv = new PHONGVIEN();
            pv.MaPV = maPV;
            pv.HoTen = hoTen;
            pv.DienThoai = dienThoai;
            pv.NgayVaoLam = ngayVaolam;
            pv.Luong = bonus;
            if (male)
            {
                pv.GioiTinh = "Nam";
            }
            else if (rad_female.Checked)
            {
                pv.GioiTinh = "Nữ";

            }
            if (thuongTru)
            {
                pv.MaLoaiPV = 1;
                pv.Luong = 12000000 + bonus;
            }
            else if (rad_toaSoan.Checked)
            {
                pv.MaLoaiPV = 0;
                pv.Luong = 12000000 + 100000 * 1.5m * (decimal)bonus;

            }
            db.PHONGVIENs.Add(pv);
            db.SaveChanges();
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetFromDatabase();

        }

        //Lấy dữ liệu từ database 
        private void GetFromDatabase()
        {
            lv_phongvien.Items.Clear();
            foreach(var item in db.PHONGVIENs)
            {
                ListViewItem lvItem = new ListViewItem(item.MaPV);
                lvItem.SubItems.Add(item.HoTen);
                lvItem.SubItems.Add(item.GioiTinh);
                lvItem.SubItems.Add(item.NgayVaoLam.ToString("dd/MM/yyyy"));
                TimeSpan time = DateTime.Now - item.NgayVaoLam;
                if(time.TotalDays > 5 * 365)
                {
                    lvItem.BackColor = Color.Yellow;
                }
                lv_phongvien.Items.Add(lvItem);

            }
        }

        private void lv_phongvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_phongvien.SelectedItems.Count > 0)
            {
                txt_maPV.Text = lv_phongvien.SelectedItems[0].Text;
                txt_hoten.Text = lv_phongvien.SelectedItems[0].SubItems[1].Text;
                string gioiTinh = lv_phongvien.SelectedItems[0].SubItems[2].Text;
                dtp_ngayVaolam.Text = lv_phongvien.SelectedItems[0].SubItems[3].Text;
                

                if(gioiTinh == "Nam")
                {
                    rad_male.Checked= true;
                    rad_female.Checked= false;
                }else if (gioiTinh == "Nữ")
                {
                    rad_male.Checked = false;
                    rad_female.Checked = true;
                }

                var type = db.PHONGVIENs
                             .Where(pv => pv.MaPV == txt_maPV.Text)
                             .Select(pv => pv.MaLoaiPV)
                             .FirstOrDefault();
                var salary = db.PHONGVIENs
                           .Where(pv => pv.MaPV == txt_maPV.Text)
                           .Select(pv => pv.Luong)
                           .FirstOrDefault();
                txt_addText.Text = salary.ToString();
                var phone = db.PHONGVIENs
                            .Where(pv => pv.MaPV == txt_maPV.Text)
                            .Select(pv => pv.DienThoai)
                            .FirstOrDefault();
                txt_dienThoai.Text = phone;
                switch (type)
                {
                    case 0:
                        rad_toaSoan.Checked = true;
                        rad_thuongTru.Checked = false;
                        break;
                    case 1:
                        rad_toaSoan.Checked = false;
                        rad_thuongTru.Checked = true;
                        break;

                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (lv_phongvien.SelectedItems.Count > 0)
            {
                DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn xoá phóng viên này", "Xác nhận xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    string maPV_delete = lv_phongvien.SelectedItems[0].Text;
                    lv_phongvien.Items.Remove(lv_phongvien.SelectedItems[0]);
                    PHONGVIEN pv_selected = db.PHONGVIENs.Where(pv => pv.MaPV == maPV_delete).SingleOrDefault();
                    db.PHONGVIENs.Remove(pv_selected);
                    db.SaveChanges();
                    MessageBox.Show("Xoá thành công", "Thông báo" , MessageBoxButtons.OK , MessageBoxIcon.Information );
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maPV = txt_maPV.Text;
            PHONGVIEN pv_update = db.PHONGVIENs.SingleOrDefault(pv => pv.MaPV == maPV);
            bool male = rad_male.Checked;
            bool thuongTru = rad_thuongTru.Checked;
            if(pv_update != null)
            {
                pv_update.MaPV = txt_maPV.Text;
                pv_update.HoTen = txt_hoten.Text;
                pv_update.DienThoai = txt_dienThoai.Text;
                pv_update.NgayVaoLam = dtp_ngayVaolam.Value;
                pv_update.Luong = Convert.ToDecimal(txt_addText.Text);

                if (male)
                {
                    pv_update.GioiTinh = "Nam";
                }
                else
                {
                    pv_update.GioiTinh = "Nữ";
                }

                if (thuongTru)
                {
                    pv_update.MaLoaiPV = 1;
                }
                else
                {
                    pv_update.MaLoaiPV = 0;
                }
                db.SaveChanges();
                MessageBox.Show("Sửa thông tin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetFromDatabase();

            }
        }

        private void btn_sapxep_Click(object sender, EventArgs e)
        {
            var sortedPhongViens = db.PHONGVIENs
            .OrderByDescending(pv => DateTime.Now.Year - pv.NgayVaoLam.Year)
            .ThenBy(pv => pv.HoTen)
            .ToList();

            lv_phongvien.Items.Clear();

            foreach (var item in sortedPhongViens)
            {
                ListViewItem lvItem = new ListViewItem(item.MaPV);
                lvItem.SubItems.Add(item.HoTen);
                lvItem.SubItems.Add(item.GioiTinh);
                lvItem.SubItems.Add(item.NgayVaoLam.ToString("dd/MM/yyyy"));
                TimeSpan time = DateTime.Now - item.NgayVaoLam;
                if (time.TotalDays > 5 * 365)
                {
                    lvItem.BackColor = Color.Yellow;
                }
                lv_phongvien.Items.Add(lvItem);

            }
        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            var DSPhongVien = db.PHONGVIENs.ToList();

            int pv_ts = 0;
            int pv_tt = 0;
            decimal totalSalary_ts = 0;
            decimal totalSalary_tt = 0;

            foreach (var loaiPV in DSPhongVien)
            {

                if (loaiPV.MaLoaiPV == 0)
                {
                    pv_ts++;
                    totalSalary_ts += loaiPV.Luong;
                }
                else if (loaiPV.MaLoaiPV == 1)
                {
                    pv_tt++;
                    totalSalary_tt += loaiPV.Luong;
                }
            }
            MessageBox.Show("Thống kê : " +
            "Tổng có " + pv_ts + " phóng viên toà soạn và " + pv_tt + " phóng viên thường trú" + "\n" +
            "Tổng doanh thu : " + "\n" + "PVTS : " + totalSalary_ts.ToString("N2") + " VNĐ "
                                + "\n" + "PVTT : " + totalSalary_tt.ToString("N2") + " VNĐ "
            , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

using Microsoft.Office.Interop.Excel;
using Pets.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Excel = Microsoft.Office.Interop.Excel;
namespace Pets
{
    public partial class Form1 : Form
    {
        PetEntities2 db = new PetEntities2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rad_chuaBenh.Checked = true;
            dtp_ngayNhan.Value = DateTime.Now;
            GetDataFromDB();
        }
        //Hỏi xác nhận khi đóng chương trình
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (MessageBox.Show("Bạn muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo , MessageBoxIcon.Question)== DialogResult.No)
            //{
            //    e.Cancel = true;
            //}
           if(MessageBox.Show("Bạn muốn thoát chương trình ?","Thông báo",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }

        }



        private void rad_chuaBenh_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_chuaBenh.Checked)
            {
                lb_inforBonus.Text = "Chi phí thuốc";
            }
        }

        private void rad_chamSoc_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_chamSoc.Checked)
            {
                lb_inforBonus.Text = "Số ngày";
            }
        }

        private void btn_them_Click_1(object sender, EventArgs e)
        {
            rad_chuaBenh.Checked = true;
            dtp_ngayNhan.Value = DateTime.Now;
            txt_madon.Clear();
            txt_madon.Focus();
            txt_tenthucung.Clear();
            txt_chungloai.Clear();
            txt_inforBonus.Clear();
            txt_tinhTrang.Clear();
            txt_cannang.Clear();
        }

        private void GetDataFromDB()
        {
            //lv_pets.Items.Clear();
            //foreach( var item in db.ThuCungs)
            // {
            //     ListViewItem lv_item = new ListViewItem(item.MaDon);
            //     lv_item.SubItems.Add(item.TenThuCung);
            //     lv_item.SubItems.Add(item.ChungLoai);
            //     lv_item.SubItems.Add(item.NgayNhan.ToString("dd/MM/yyyy"));
            //     if( item.CanNang > 40)
            //     {
            //         lv_item.BackColor = Color.Yellow;
            //     }
            //     lv_pets.Items.Add(lv_item);
            // }


            lv_pets.Items.Clear();
            foreach(var item in db.ThuCungs)
            {
                ListViewItem lv_item = new ListViewItem(item.MaDon);
                lv_item.SubItems.Add(item.TenThuCung);
                lv_item.SubItems.Add(item.ChungLoai);
                lv_item.SubItems.Add(item.NgayNhan.ToString("dd/MM/yyyy"));
                //Trường hợp ngày gửi TC ở trung tâm quá 10day sẽ tô màu vàng
                TimeSpan time = DateTime.Now -item.NgayNhan;
                if(item.CanNang > 40)
                {
                    lv_item.BackColor = Color.Yellow;

                }
                lv_pets.Items.Add(lv_item);
         
            }

        }
        //Chức năng lưu
        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            //string maDon = txt_madon.Text;
            //string tenThucung = txt_tenthucung.Text;
            //string chungLoai = txt_chungloai.Text;
            //string canNang =txt_cannang.Text;
            //DateTime ngayNhan = dtp_ngayNhan.Value;
            //string tinhTrang = txt_tinhTrang.Text;
            //int inforBonus = Convert.ToInt32(txt_inforBonus.Text);
            //bool chuabenh = rad_chuaBenh.Checked;
            //if (string.IsNullOrEmpty(maDon) || string.IsNullOrEmpty(tenThucung) || string.IsNullOrEmpty(chungLoai) || string.IsNullOrEmpty(canNang))
            //{
            //    MessageBox.Show("Mã đơn , Tên thú cưng , chủng loại , cân nặng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if(ngayNhan > DateTime.Now)
            //{
            //    MessageBox.Show("Ngày nhận không được lớn hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //ThuCung tc = new ThuCung();
            //tc.MaDon = maDon;
            //tc.TenThuCung = tenThucung;
            //tc.ChungLoai = chungLoai;
            //tc.CanNang = int.Parse(canNang);
            //tc.NgayNhan = ngayNhan;
            //tc.TinhTrang = tinhTrang;
            //if (chuabenh)
            //{
            //    tc.MaDV = 0;
            //    tc.Phi = 100000;
            //}
            //else
            //{
            //    tc.MaDV = 1;
            //    tc.Phi = 200000 * inforBonus;
            //    tc.SoNgay = int.Parse(txt_inforBonus.Text);
            //}
            //db.ThuCungs.Add(tc);
            //db.SaveChanges();
            //MessageBox.Show("Lưu Thành Công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //GetDataFromDB();


            string madon = txt_madon.Text;
            string tenThucung = txt_tenthucung.Text;
            string chungLoai = txt_chungloai.Text;
            string canNang = txt_cannang.Text;
            DateTime ngayNhan = dtp_ngayNhan.Value;
            string tinhTrang = txt_tinhTrang.Text;
            bool chuabenh = rad_chuaBenh.Checked;
            if (string.IsNullOrEmpty(madon) || string.IsNullOrEmpty(tenThucung) || string.IsNullOrEmpty(chungLoai) || string.IsNullOrEmpty(canNang))
            {
                MessageBox.Show("Mã đơn , Tên thú cưng , chủng loại , cân nặng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ngayNhan > DateTime.Now)
            {
                MessageBox.Show("Ngày nhận không được lớn hơn ngày hiện tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ThuCung tc = new ThuCung();
            tc.MaDon = madon;
            tc.TenThuCung = tenThucung;
            tc.ChungLoai = chungLoai;
            tc.CanNang = int.Parse(canNang);
            tc.NgayNhan = ngayNhan;
            tc.TinhTrang = tinhTrang;
            if (chuabenh)
            {
                tc.MaDV = 0;
            }
            else { tc.MaDV = 1; }
            db.ThuCungs.Add(tc);
            db.SaveChanges();
            ListViewItem lv_item = new ListViewItem(madon);
            lv_item.SubItems.Add(tenThucung);
            lv_item.SubItems.Add(chungLoai);
            lv_item.SubItems.Add(ngayNhan.ToString("dd/MM/yyyy"));
            if (int.Parse(canNang) > 40)
            {
                lv_item.BackColor = Color.Yellow;

            }
            lv_pets.Items.Add(lv_item);
            lv_item.Selected = true;
            MessageBox.Show("Luu thanh cong", "tb", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lv_pets_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lv_pets.SelectedItems.Count > 0)
            //{
            //    txt_madon.Text = lv_pets.SelectedItems[0].Text;
            //    txt_tenthucung.Text = lv_pets.SelectedItems[0].SubItems[1].Text;
            //    txt_chungloai.Text = lv_pets.SelectedItems[0].SubItems[2].Text;
            //    dtp_ngayNhan.Text = lv_pets.SelectedItems[0].SubItems[3].Text;

            //    var canNang = db.ThuCungs
            //        .Where(tc => tc.MaDon == txt_madon.Text)
            //        .Select(tc => tc.CanNang)
            //        .FirstOrDefault();
            //    txt_cannang.Text = canNang.ToString();

            //    var tinhTrang = db.ThuCungs
            //        .Where(tc => tc.MaDon == txt_madon.Text)
            //        .Select(tc => tc.TinhTrang)
            //        .FirstOrDefault();
            //    txt_tinhTrang.Text = tinhTrang.ToString();

            //    var dichVu = db.ThuCungs
            //        .Where(tc => tc.MaDon == txt_madon.Text)
            //        .Select(tc => tc.MaDV)
            //        .FirstOrDefault();

            //    switch (dichVu)
            //    {
            //        case 0:
            //            rad_chuaBenh.Checked = true;
            //            rad_chamSoc.Checked = false;
            //            var phi = db.ThuCungs
            //           .Where(tc => tc.MaDon == txt_madon.Text)
            //           .Select(tc => tc.Phi)
            //           .FirstOrDefault();
            //            txt_inforBonus.Text = phi.ToString();
            //            break;
            //        case 1:
            //            rad_chuaBenh.Checked = false;
            //            rad_chamSoc.Checked = true;
            //            var day = db.ThuCungs
            //            .Where(tc => tc.MaDon == txt_madon.Text)
            //            .Select(tc => tc.SoNgay)
            //            .FirstOrDefault();
            //            txt_inforBonus.Text = day.ToString();
            //            break;
            //    }

            //}

            if(lv_pets.SelectedItems.Count > 0)
            {
                txt_madon.Text = lv_pets.SelectedItems[0].Text;
                txt_tenthucung.Text = lv_pets.SelectedItems[0].SubItems[1].Text;
                txt_chungloai.Text = lv_pets.SelectedItems[0].SubItems[2].Text;
                //dtp_ngayNhan.Text = lv_pets.SelectedItems[0].SubItems[3].Text;

                var canNang = db.ThuCungs 
                               .Where(tc => tc.MaDon == txt_madon.Text)
                               .Select(tc => tc.CanNang)
                               .FirstOrDefault();
                txt_cannang.Text = canNang.ToString();

                var ngayNhan = db.ThuCungs
                                .Where(tc => tc.MaDon == txt_madon.Text)
                                .Select(tc => tc.NgayNhan)
                                .FirstOrDefault();
                dtp_ngayNhan.Text = ngayNhan.ToString("dd/MM/yyyy");

                var tinhTrang = db.ThuCungs
                              .Where(tc => tc.MaDon == txt_madon.Text)
                              .Select(tc => tc.TinhTrang)
                              .FirstOrDefault();
                txt_tinhTrang.Text = tinhTrang.ToString();

                var dichVu = db.ThuCungs
                              .Where(tc => tc.MaDon == txt_madon.Text)
                              .Select(tc => tc.MaDV)
                              .FirstOrDefault();
                switch (dichVu)
                {
                    case 0:
                        rad_chuaBenh.Checked = true;
                        rad_chamSoc.Checked = false;
                        break;
                    case 1:
                        rad_chuaBenh.Checked = false;
                        rad_chamSoc.Checked = true;
                        break;
                }
            }
        }

        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
           //if(lv_pets.SelectedItems.Count > 0)
           //{
           //     DialogResult rs = MessageBox.Show("Ban chac chan muon xoa ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           //     if(rs == DialogResult.Yes)
           //     {
           //         string madon_delete = lv_pets.SelectedItems[0].Text;
           //         int index_delete = lv_pets.SelectedItems[0].Index;
           //         ThuCung tc_delete = db.ThuCungs.Where(tc => tc.MaDon == madon_delete).SingleOrDefault();
           //         lv_pets.Items.Remove(lv_pets.SelectedItems[0]);
           //         if (lv_pets.Items.Count > 0)
           //         {
           //             // Nếu còn dòng dữ liệu, chọn dòng tiếp theo
           //             if (index_delete < lv_pets.Items.Count)
           //             {
           //                 lv_pets.Items[index_delete].Selected = true;
           //             }
           //             else
           //             {
           //                 // Nếu index_delete là dòng cuối cùng, chọn dòng trước đó
           //                 lv_pets.Items[lv_pets.Items.Count - 1].Selected = true;
           //             }
           //         }
           //         else
           //         {
           //             MessageBox.Show("Xoá thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //             rad_chuaBenh.Checked = true;
           //             dtp_ngayNhan.Value = DateTime.Now;
           //             txt_madon.Clear();
           //             txt_madon.Focus();
           //             txt_tenthucung.Clear();
           //             txt_chungloai.Clear();
           //             txt_inforBonus.Clear();
           //             txt_tinhTrang.Clear();
           //             txt_cannang.Clear();
           //         }
           //         db.ThuCungs.Remove(tc_delete);
           //         db.SaveChanges();
           //         MessageBox.Show("Không còn dữ liệu để xoá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //         GetDataFromDB();
           //     }
           //}
           if (lv_pets.SelectedItems.Count > 0)
            {
                string madon_delete = lv_pets.SelectedItems[0].Text;
                int index_delete = lv_pets.SelectedItems[0].Index;
                ThuCung tc_delete = db.ThuCungs.Where(tc => tc.MaDon == madon_delete).SingleOrDefault();
                lv_pets.Items.Remove(lv_pets.SelectedItems[0]);
                if(lv_pets.Items.Count > 0)
                {
                    if(index_delete < lv_pets.Items.Count)
                    {
                        lv_pets.Items[index_delete].Selected = true;
                    }
                    else
                    {
                        lv_pets.Items[lv_pets.Items.Count - 1].Selected = true;
                    }
                }
                else
                {
                    MessageBox.Show("Xoa thanhh congggg", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rad_chuaBenh.Checked = true;
                    dtp_ngayNhan.Value = DateTime.Now;
                    txt_madon.Clear();
                    txt_madon.Focus();
                    txt_tenthucung.Clear();
                    txt_chungloai.Clear();
                    txt_inforBonus.Clear();
                    txt_tinhTrang.Clear();
                    txt_cannang.Clear();
                }
                db.ThuCungs.Remove(tc_delete);
                db.SaveChanges();
                MessageBox.Show("Emptyy", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetDataFromDB();
            }



        }

        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            //string maDon_update = txt_madon.Text;
            //ThuCung tc_update = db.ThuCungs.SingleOrDefault(tc => tc.MaDon == maDon_update);
            //bool chuaBenh = rad_chuaBenh.Checked;
            //if (tc_update != null)
            //{
            //    tc_update.MaDon = txt_madon.Text;
            //    tc_update.TenThuCung = txt_tenthucung.Text;
            //    tc_update.ChungLoai = txt_chungloai.Text;
            //    tc_update.CanNang = Convert.ToInt32(txt_cannang.Text);
            //    tc_update.NgayNhan = dtp_ngayNhan.Value;
            //    tc_update.TinhTrang = txt_tinhTrang.Text;
            //    if (chuaBenh)
            //    {
            //        tc_update.Phi = Convert.ToDecimal(txt_inforBonus.Text);
            //        tc_update.MaDV = 0;
            //    }
            //    else
            //    {
            //        tc_update.SoNgay = Convert.ToInt32(txt_inforBonus.Text);
            //        tc_update.MaDV = 1;
            //    }
            //    db.SaveChanges();
            //    MessageBox.Show("Đã sửa thành công thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    GetDataFromDB();

            //}
            string madon_update = txt_madon.Text;
            bool chuabenh = rad_chuaBenh.Checked;
            ThuCung tc_update = db.ThuCungs.SingleOrDefault(tc => tc.MaDon == madon_update);
            if(madon_update != null)
            {
                tc_update.MaDon = txt_madon.Text;
                tc_update.TenThuCung = txt_tenthucung.Text;
                tc_update.ChungLoai = txt_chungloai.Text;
                tc_update.CanNang =int.Parse( txt_cannang.Text);
                tc_update.NgayNhan = dtp_ngayNhan.Value;
                tc_update.TinhTrang = txt_tinhTrang.Text;
                if (chuabenh)
                {
                    tc_update.MaDV = 0;

                }
                else
                {
                    tc_update.MaDV = 1;
                }
                db.SaveChanges();
                MessageBox.Show("Suar thanh congg", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetDataFromDB();

            }


        }

        private void btn_sapXep_Click_1(object sender, EventArgs e)
        {
            //var sortList = db.ThuCungs
            //    .OrderByDescending(tc => DateTime.Now.Year - tc.NgayNhan.Year)
            //    .ThenBy(tc => tc.CanNang)
            //    .ToList();

            //lv_pets.Items.Clear();
            //foreach (var item in sortList)
            //{
            //    ListViewItem lvItem = new ListViewItem(item.MaDon);
            //    lvItem.SubItems.Add(item.TenThuCung);
            //    lvItem.SubItems.Add(item.ChungLoai);
            //    lvItem.SubItems.Add(item.NgayNhan.ToString("dd/MM/yyyy"));
            //    if (item.CanNang > 40)
            //    {
            //        lvItem.BackColor = Color.Yellow;
            //    }
            //    lv_pets.Items.Add(lvItem);
            //}

            var sortList = db.ThuCungs
                           .OrderByDescending(tc => tc.NgayNhan)
                           .ThenBy(tc => tc.CanNang)
                           .ToList();
            lv_pets.Items.Clear();
            foreach (var item in sortList)
            {
                ListViewItem lv_item = new ListViewItem(item.MaDon);
                lv_item.SubItems.Add(item.TenThuCung);
                lv_item.SubItems.Add(item.ChungLoai);
                lv_item.SubItems.Add(item.NgayNhan.ToString("dd/MM/yyyy"));
                //Trường hợp ngày gửi TC ở trung tâm quá 10day sẽ tô màu vàng
                TimeSpan time = DateTime.Now - item.NgayNhan;
                if (item.CanNang > 40)
                {
                    lv_item.BackColor = Color.Yellow;

                }
                lv_pets.Items.Add(lv_item);

            }

        }

        private void btn_thongKe_Click_1(object sender, EventArgs e)
        {
            int count_DVchuabenh = 0;
            int count_DVchamsoc = 0;
            decimal total_Revenue_cb = 0;
            decimal total_Revenue_cs = 0;
            foreach (var loaiDV in db.ThuCungs)
            {
                if (loaiDV.MaDV == 0)
                {
                    count_DVchuabenh++;
                    total_Revenue_cb += loaiDV.Phi;

                }
                else
                {
                    count_DVchamsoc++;
                    total_Revenue_cs += loaiDV.Phi;
                }
            }
            MessageBox.Show("Số lượng dịch vụ chữa bệnh " + count_DVchuabenh + "\n" +
                            "Số lượng dịch vụ chăm sóc " + count_DVchamsoc + "\n" +
                            "Doanh thu " + "\n" +
                            "DV chăm sóc : " + total_Revenue_cs + "\n" +
                             "DV chữa bệnh : " + total_Revenue_cb + "\n",
                 "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_excel_Click_1(object sender, EventArgs e)
        {
            //Excel.Application excelApp = new Excel.Application();
            //excelApp.Visible = true;

            //// Tạo một Workbook và một Worksheet mới
            //Excel.Workbook workbook = excelApp.Workbooks.Add();
            //Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            //// Thêm tiêu đề cho từng cột
            //for (int i = 0; i < lv_pets.Columns.Count; i++)
            //{
            //    worksheet.Cells[1, i + 1] = lv_pets.Columns[i].Text;
            //}

            //// Thêm dữ liệu từ ListView vào Worksheet
            //for (int i = 0; i < lv_pets.Items.Count; i++)
            //{
            //    for (int j = 0; j < lv_pets.Items[i].SubItems.Count; j++)
            //    {
            //        worksheet.Cells[i + 2, j + 1] = lv_pets.Items[i].SubItems[j].Text;
            //    }
            //}

            ////Luu
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //if (saveFileDialog.ShowDialog() == DialogResult.OK) workbook.SaveAs(saveFileDialog.FileName);
            //excelApp.Quit();

            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            //tao workbook
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            //title
            for(int i = 0; i < lv_pets.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = lv_pets.Columns[i].Text;

            }

            //data 
            for (int i = 0; i < lv_pets.Items.Count; i++)
            {
                for (int j = 0; j < lv_pets.Items[i].SubItems.Count; j++)
                {
                    worksheet.Cells[i+2, j + 1] = lv_pets.Items[i].SubItems[j].Text;
                }
            }

            //luu
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK) workbook.SaveAs(saveFileDialog.FileName);
            excelApp.Quit();
        }

        

       

     
    }
}

using PhongVien_demo.Context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace PhongVien_demo
{
    public partial class Form1 : Form
    {
        PHONGVIENEntities2 db = new PHONGVIENEntities2();
        public Form1()
        {
            InitializeComponent();
        }

        private void rad_thuongTru_CheckedChanged(object sender, EventArgs e)
        {
            lb_InforBonus.Text = "Phụ Cấp";
        }

        private void rad_Toasoan_CheckedChanged(object sender, EventArgs e)
        {
            lb_InforBonus.Text = "Số giờ làm thêm";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn muốn thoát chương trình ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rad_nam.Checked = true;
            dtp_nvl.Value = DateTime.Now;
            rad_Toasoan.Checked = true;
            GetDataFromDB();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            rad_nam.Checked = true;
            dtp_nvl.Value = DateTime.Now;
            rad_Toasoan.Checked = true;
            txt_maNV.Clear();
            txt_maNV.Focus();
            txt_hoten.Clear();
            txt_phone.Clear();
            txt_infBonus.Clear();

        }

        private void GetDataFromDB()
        {
            //lv_pv.Items.Clear();
            //foreach(var item in db.PHONGVIENs)
            //{
            //    ListViewItem lv_item = new ListViewItem(item.MaPV);
            //    lv_item.SubItems.Add(item.HoTen);
            //    lv_item.SubItems.Add(item.GioiTinh);
            //    lv_item.SubItems.Add(item.NgayVaoLam.ToString("dd/MM/yyyy"));
            //    TimeSpan time = DateTime.Now - item.NgayVaoLam;
            //    if(time.TotalDays > 5 * 365)
            //    {
            //        lv_item.BackColor = Color.Yellow;
            //    }
            //    lv_pv.Items.Add(lv_item);
            //}

            lv_pv.Items.Clear();
            foreach(var item in db.PHONGVIENs)
            {
                ListViewItem lv_item = new ListViewItem(item.MaPV);
                lv_item.SubItems.Add(item.HoTen);
                lv_item.SubItems.Add(item.GioiTinh);
                lv_item.SubItems.Add(item.NgayVaoLam.ToString("dd/MM/yyyy"));
                TimeSpan time = DateTime.Now - item.NgayVaoLam;
                if(time.TotalDays > 5 * 365)
                {
                    lv_item.BackColor = Color.Yellow;
                }
                lv_pv.Items.Add(lv_item);
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            string mapv = txt_maNV.Text;
            string hoten = txt_hoten.Text;
            string phone = txt_phone.Text;
            bool male = rad_nam.Checked;
            DateTime ngayVL = dtp_nvl.Value;
            bool Toasoan = rad_Toasoan.Checked;
            string infor_Bonus = txt_infBonus.Text;
            //MemoryStream ms = new MemoryStream();
            //ptb_Avatar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //byte[] imageBytes = ms.ToArray();

            MemoryStream ms = new MemoryStream();
            ptb_Avatar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] imageBytes = ms.ToArray();
            if (string.IsNullOrEmpty(mapv) || string.IsNullOrEmpty(hoten))
            {
                MessageBox.Show("Mã phóng viên , họ tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ngayVL > DateTime.Now)
            {
                MessageBox.Show("Ngày vào làm không được lớn hơn hiện tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            

            PHONGVIEN pv = new PHONGVIEN();
            pv.MaPV = mapv;
            pv.HoTen = hoten;
            if (male)
            {
                pv.GioiTinh = "Nam";
            }
            else { pv.GioiTinh = "Nữ"; }
            pv.DienThoai = phone;
            pv.NgayVaoLam = ngayVL;
            pv.AvatarURL = imageBytes;
            if (Toasoan)
            {
                pv.MaLoaiPV = 0;
                pv.SoGioLamThem = int.Parse(infor_Bonus);
                pv.Luong = 12000000 + 100000 * 1.5m * int.Parse(infor_Bonus);
            }
            else
            {
                pv.MaLoaiPV = 1;
                pv.PhuCap = Decimal.Parse(infor_Bonus);
                pv.Luong = 12000000 + Decimal.Parse(infor_Bonus);
            }
            db.PHONGVIENs.Add(pv);
            db.SaveChanges();
            ListViewItem lv_item = new ListViewItem(mapv);
            lv_item.SubItems.Add(hoten);
            if (male)
            {
                lv_item.SubItems.Add("Nam");
            }
            else { lv_item.SubItems.Add("Nữ"); }
            lv_item.SubItems.Add(ngayVL.ToString("dd/MM/yyyy"));
            TimeSpan time = DateTime.Now - ngayVL;
            if (time.TotalDays > 5 * 365)
            {
                lv_item.BackColor = Color.Yellow;
            }
            lv_item.Selected = true;
            lv_pv.Items.Add(lv_item);
            lv_pv.Select();
            MessageBox.Show("Luu thanh conggg", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            //if (lv_pv.SelectedItems.Count > 0)
            //{
            //    DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xoá ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (rs == DialogResult.Yes)
            //    {
            //        string ma_pv_delete = lv_pv.SelectedItems[0].Text;
            //        int index_delete = lv_pv.SelectedItems[0].Index;
            //        PHONGVIEN pv_delete = db.PHONGVIENs.Where(pv => pv.MaPV == ma_pv_delete).SingleOrDefault();
            //        lv_pv.Items.Remove(lv_pv.SelectedItems[0]);
            //        if (lv_pv.Items.Count > 0)
            //        {
            //            if (index_delete < lv_pv.Items.Count)
            //            {
            //                lv_pv.Items[index_delete].Selected = true;
            //            }
            //            else
            //            {
            //                lv_pv.Items[lv_pv.Items.Count - 1].Selected = true;
            //            }
            //        }
            //        else
            //        {
            //            rad_nam.Checked = true;
            //            dtp_nvl.Value = DateTime.Now;
            //            rad_Toasoan.Checked = true;
            //            txt_maNV.Clear();
            //            txt_maNV.Focus();
            //            txt_hoten.Clear();
            //            txt_phone.Clear();
            //            txt_infBonus.Clear();
            //        }
            //        db.PHONGVIENs.Remove(pv_delete);
            //        db.SaveChanges();
            //        MessageBox.Show("Xoa thanh conggg", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        GetDataFromDB();
            //    }

            //}

            if (lv_pv.SelectedItems.Count > 0)
            {
                DialogResult rs = MessageBox.Show("Bajn cos chawsc chawsn muosn xoas ?", "Thoong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    string mapv_delete = lv_pv.SelectedItems[0].Text;
                    int index_delete = lv_pv.SelectedItems[0].Index;
                    PHONGVIEN pv_delete = db.PHONGVIENs.Where(pv => pv.MaPV == mapv_delete).SingleOrDefault();
                    lv_pv.Items.Remove(lv_pv.SelectedItems[0]);
                    if (lv_pv.Items.Count > 0)
                    {
                        if (index_delete < lv_pv.Items.Count)
                        {
                            lv_pv.Items[index_delete].Selected = true;
                        }
                        else
                        {
                            lv_pv.Items[lv_pv.Items.Count - 1].Selected = true;
                        }
                    }
                    else
                    {
                        rad_nam.Checked = true;
                        dtp_nvl.Value = DateTime.Now;
                        rad_Toasoan.Checked = true;
                        txt_maNV.Clear();
                        txt_maNV.Focus();
                        txt_hoten.Clear();
                        txt_phone.Clear();
                        txt_infBonus.Clear();
                    }
                    db.PHONGVIENs.Remove(pv_delete);
                    db.SaveChanges();
                    MessageBox.Show("Xoas thanfh coong ", "Thoong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetDataFromDB();
                }
            }
        }

        private void lv_pv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_pv.SelectedItems.Count > 0)
            {
                txt_maNV.Text = lv_pv.SelectedItems[0].Text;
                txt_hoten.Text = lv_pv.SelectedItems[0].SubItems[1].Text;
                string gt = lv_pv.SelectedItems[0].SubItems[2].Text;
                dtp_nvl.Text = lv_pv.SelectedItems[0].SubItems[3].Text;
               
                if (gt == "Nam")
                {
                    rad_nam.Checked = true;
                    rad_nu.Checked = false;
                }
                else if (gt == "Nữ")
                {
                    rad_nam.Checked = false;
                    rad_nu.Checked = true;
                }

                var phone = db.PHONGVIENs
                        .Where(pv => pv.MaPV == txt_maNV.Text)
                        .Select(pv => pv.DienThoai)
                        .FirstOrDefault();
                txt_phone.Text = phone.ToString();

                var loaiPV = db.PHONGVIENs
                        .Where(pv => pv.MaPV == txt_maNV.Text)
                        .Select(pv => pv.MaLoaiPV)
                        .FirstOrDefault();

                byte[] imageData = db.PHONGVIENs
                       .Where(pv => pv.MaPV == txt_maNV.Text)
                       .Select(pv => pv.AvatarURL)
                       .FirstOrDefault();


                //MemoryStream ms = new MemoryStream(imageData);
                // ptb_Avatar.Image = Image.FromStream(ms); 

                MemoryStream ms = new MemoryStream(imageData);
                ptb_Avatar.Image = Image.FromStream(ms);
                switch (loaiPV)
                {
                    case 0:
                        rad_Toasoan.Checked = true;
                        rad_thuongTru.Checked = false;
                        var gioLamthem = db.PHONGVIENs
                       .Where(pv => pv.MaPV == txt_maNV.Text)
                       .Select(pv => pv.SoGioLamThem)
                       .FirstOrDefault();
                        txt_infBonus.Text = gioLamthem.ToString();
                        break;
                    case 1:
                        rad_Toasoan.Checked = false;
                        rad_thuongTru.Checked = true;
                        var phuCap = db.PHONGVIENs
                       .Where(pv => pv.MaPV == txt_maNV.Text)
                       .Select(pv => pv.PhuCap)
                       .FirstOrDefault();
                        txt_infBonus.Text = phuCap.ToString();
                        break;
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string mapv_update = txt_maNV.Text;
            bool male = rad_nam.Checked;
            bool ts = rad_Toasoan.Checked;
            PHONGVIEN pv_update = db.PHONGVIENs.SingleOrDefault(pv => pv.MaPV == mapv_update);
            if(mapv_update != null)
            {
                MemoryStream ms = new MemoryStream();
                ptb_Avatar.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();
                pv_update.AvatarURL = imageBytes;
                pv_update.MaPV = txt_maNV.Text;
                pv_update.HoTen = txt_hoten.Text;
                if (male) { pv_update.GioiTinh = "Nam"; }
                else { pv_update.GioiTinh = "Nữ"; }

                pv_update.DienThoai = txt_phone.Text;
                pv_update.NgayVaoLam = dtp_nvl.Value;
                if (ts) 
                {
                    pv_update.MaLoaiPV = 0;
                    pv_update.SoGioLamThem = int.Parse(txt_infBonus.Text);
                    pv_update.Luong = 12000000 + 100000 * 1.5m * int.Parse(txt_infBonus.Text);
                }
                else 
                { 
                    pv_update.MaLoaiPV = 1;
                    pv_update.PhuCap = Decimal.Parse(txt_infBonus.Text);
                    pv_update.Luong = 12000000 + Decimal.Parse(txt_infBonus.Text);

                }
                db.SaveChanges();
                MessageBox.Show("Suaa thanh congg", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetDataFromDB();
            }

        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            var sortList = db.PHONGVIENs
                        .OrderByDescending(pv => pv.NgayVaoLam)
                        .ThenBy(pv => pv.HoTen)
                        .ToList();
            lv_pv.Items.Clear();
            foreach (var item in sortList)
            {
                ListViewItem lv_item = new ListViewItem(item.MaPV);
                lv_item.SubItems.Add(item.HoTen);
                lv_item.SubItems.Add(item.GioiTinh);
                lv_item.SubItems.Add(item.NgayVaoLam.ToString("dd/MM/yyyy"));
                TimeSpan time = DateTime.Now - item.NgayVaoLam;
                if (time.TotalDays > 5 * 365)
                {
                    lv_item.BackColor = Color.Yellow;
                }
                lv_pv.Items.Add(lv_item);
            }

        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            var ds_PV = db.PHONGVIENs.ToList();
           int count_ts = 0;
           int count_tt = 0;
            decimal totalRevenue_TS = 0;
            decimal totalRevenue_TT = 0;

        foreach(var loaiPV in ds_PV)
            {
                if (loaiPV.MaLoaiPV == 0)
                {
                    count_ts++;
                    totalRevenue_TS += loaiPV.Luong;
                }
                else if (loaiPV.MaLoaiPV == 1)
                {
                    count_tt++;
                    totalRevenue_TT += loaiPV.Luong;
                }
            }
            MessageBox.Show("THỐNG KÊ: " + "\n" +
                            "Tổng có " + count_ts + " phóng viên toà soạn và " + count_tt
                            + " phóng viên thường trú"+ "\n" +
                            "Tổng chi:" +"\n"+
                            "Phóng viên toà soạn :" + totalRevenue_TS + "đ" + "\n"+
                             "Phóng viên thường trú :" + totalRevenue_TT + "đ", "THỐNG KÊ"

                );

        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            //Excel.Application excelApp = new Excel.Application();
            //excelApp.Visible = true;

            ////tao workbook
            //Excel.Workbook workbook = excelApp.Workbooks.Add();
            //Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            ////title 
            //for(int i = 0; i< lv_pv.Columns.Count; i++)
            //{
            //    worksheet.Cells[1, i + 1] = lv_pv.Columns[i].Text;
            //}

            ////data
            //for (int i = 0; i < lv_pv.Items.Count; i++)
            //{
            //    for (int j = 0; j < lv_pv.Items[i].SubItems.Count; j++)
            //    {
            //        worksheet.Cells[i+2, j + 1] = lv_pv.Items[i].SubItems[j].Text;
            //    }
            //}

            ////luu
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //if (saveFileDialog.ShowDialog() == DialogResult.OK) workbook.SaveAs(saveFileDialog.FileName);
            //excelApp.Quit();
           



            //Excel.Application excelApp = new Excel.Application();
            //Excel.Workbook excelWb = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            //Excel.Worksheet excelWs = excelWb.Worksheets[1];

            //Excel.Range excelRange = excelWs.Cells[1, 1];
            //excelRange.Font.Color = Color.Red;
            //excelRange.Font.Size = 16;
            //excelRange.Font.Bold = true;
            //excelRange.Value = "DANH SÁCH PHÓNG VIÊN";

            //int row = 2;
            //excelWs.Range["A" + row].Font.Bold = true;
            //excelWs.Range["A" + row].Value = "Toà Soạn";
            //row++;
            //List<PHONGVIEN> listPVTS = db.PHONGVIENs.Where(tc => tc.MaLoaiPV == 0).ToList();
            //foreach (PHONGVIEN pv in listPVTS)
            //{
            //    excelWs.Range["A" + row].Value = pv.MaPV;
            //    excelWs.Range["B" + row].Value = pv.HoTen;
            //    excelWs.Range["C" + row].Value = pv.Luong;
            //    row++;
            //}
            //excelWs.Range["A" + row].Font.Bold = true;
            //excelWs.Range["A" + row].Value = "Thườngg trú";
            //row++;
            //List<PHONGVIEN> listPVTT = db.PHONGVIENs.Where(tc => tc.MaLoaiPV == 1).ToList();
            //foreach (PHONGVIEN pv in listPVTT)
            //{
            //    excelWs.Range["A" + row].Value = pv.MaPV;
            //    excelWs.Range["B" + row].Value = pv.HoTen;
            //    excelWs.Range["C" + row].Value = pv.Luong;
            //    row++;
            //}
            //excelWs.Name = "DanhSachPhongVien";
            //excelWb.Activate();
            //SaveFileDialog sfd = new SaveFileDialog();
            //if (sfd.ShowDialog() == DialogResult.OK)
            //{
            //    excelWb.SaveAs(sfd.FileName);
            //}
            //excelApp.Quit();


            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;

            //wb , ws
            Excel.Workbook wb = excelApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet ws = wb.Worksheets[1];

            Excel.Range excelRange = ws.Cells[1, 1];
            excelRange.Font.Bold = true;
            excelRange.Font.Color = Color.Red;
            excelRange.Font.Size = 16;
            excelRange.Value = "DANH SACH PHONG VIEN";

            int row = 2;
            ws.Range["A" + row].Font.Bold = true;
            ws.Range["A" + row].Value = "Toa soan";
            row++;
            List<PHONGVIEN> DSPVTS = db.PHONGVIENs.Where(pv => pv.MaLoaiPV == 0).ToList();
            foreach(var pvts in DSPVTS)
            {
                ws.Range["A" + row].Value = pvts.MaPV;
                ws.Range["B" + row].Value = pvts.HoTen;
                ws.Range["C" + row].Value = pvts.Luong;
                row++;
            }

            ws.Range["A" + row].Font.Bold = true;
            ws.Range["A" + row].Value = "Thuong tru";
            row++;
            List<PHONGVIEN> DSPVTT = db.PHONGVIENs.Where(pv => pv.MaLoaiPV == 1).ToList();
            foreach (var pvtt in DSPVTT)
            {
                ws.Range["A" + row].Value = pvtt.MaPV;
                ws.Range["B" + row].Value = pvtt.HoTen;
                ws.Range["C" + row].Value = pvtt.Luong;
                row++;
            }

            ws.Name = "DANHSACHPHONGVIEN";
            wb.Activate();
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK) wb.SaveAs(sfd.FileName);
            excelApp.Quit();


        }

        private void ptb_Avatar_Click(object sender, EventArgs e)
        {
            //OpenFileDialog ofd = new OpenFileDialog();
            //ofd.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp";
            //if (ofd.ShowDialog() == DialogResult.OK)
            //{
            //    ptb_Avatar.Image = new Bitmap(ofd.FileName);
            //}

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.png ; *.jpg;*.bmp;*.jpeg) |*.png ; *.jpg;*.bmp;*.jpeg ";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                ptb_Avatar.Image = new Bitmap(ofd.FileName);
            }
        }

        private void txt_infBonus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }
    }
}

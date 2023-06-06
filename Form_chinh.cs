using D67.DAO;
using Quanlytinhtrangsanxuat.DAO;
using ServiceStack.Script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D67
{
    public partial class Form_chinh : Form
    {
        public Form_chinh()
        {
            InitializeComponent();
        }

        string may;
        string tenlinhkien;
        float tilenhuanghientrenbanve;
        float tilenhuanghiendathunghiemok;
        float socavity;
        float loaimayduc;
        float cycletime;
        string loainhua;
        string tennguyenlieu;
        string capdonguyenlieu;
        string mamau;
        float nhietdosay;
        float thoigiansay;
        float thoigianupkhuon;
        float thoigianhakhuon;
        float thoigianchaymay;
        float thoigiandungmay;
        float songuoithaotac;
        float thoigianlennhietmayduc;
        float thoigianlennhiethotrunner;
        float thoigianlennhietkhuon;
        float thoigianvesinhmaysay;
        float trongluongsanpham;
        float trongluongrunnergate;
        float tongtrongluongsanpham;
        float soluongfirstshotmotlan;

        public DateTime thoidiemdukienbatdausanxuat;
        public string ngaygionhapdulieu;
        public string tongsoshotduc;

        
        public bool kiemTraThongTin()
        {
            if (txtMay2.Text == "")
            {
                //MessageBox.Show("Chưa điền thông tin mã linh kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMay2.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
                return false; //dừng lại.
            }
            if (txtMaLinhKien.Text == "")
            {
                //MessageBox.Show("Chưa điền thông tin mã linh kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLinhKien.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
                return false; //dừng lại.
            }

            if (txtKeHoachSanXuat.Text == "")
            {
                //MessageBox.Show("Chưa nhập thông tin kế hoạch sản xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKeHoachSanXuat.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
                return false; //dừng lại.
            }

            return true; //tiếp tục thực thi chương trình.
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult1 = MessageBox.Show("Xác nhận thông tin vừa nhập chính xác?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult1 == DialogResult.Yes)
            {
                string ngaygionhapdulieu = DateTime.Now.ToString("dd/MM/yyyy");
                string may = txtMay2.Text;
                string malinhkien = txtMaLinhKien.Text;
                string tenlinhkien = txtTenLinhKien.Text;
                string trongluongsanpham = txtTrongLuongSanPham.Text;
                string trongluongrunner = txtTrongLuongRuner.Text;
                string kehoachsanxuat = txtKeHoachSanXuat.Text;
                string thoidiemdukienbatdausanxuat = dtp1.Value.ToString("dd/MM/yyyy hh:mm tt");
                string tongsoshotduc = "";
                string tongtrongluong1pcs = txtTongTrongLuong.Text;
                string cycletimeduc = txtCycletime.Text;
                string thoigianvesinhmaysaytieuchuan = "";
                string thoigianvesinhmaysaythucte = "";
                string tennguyenlieudukiensudung = "";
                string tennguyenlieuthuctesudung = "";
                string capdonguyenlieudukiensudung = "";
                string capdonguyenlieuthuctesudung = "";
                string mamaunguyenlieudukiensudung = "";
                string mamaunguyenlieuthuctesudung = "";
                string nhietdosay = "";
                string nhietdosaythucte = "";
                string thoigiansay = "";
                string thoigiansaythucte = "";
                string tilenhuanghientrenfile = "";
                string tilenhuanghienthucte = "";
                string luongnhuatinhcandungdukien = "";
                string luongnhuatinhcandungthucte = "";
                string luongnhuanghiencandungdukien = "";
                string luongnhuanghiencandungthucte = "";
                string thoidiemdukienbatdauvesinhmaysay = "";
                string thoidiemthuctebatdauvesinhmaysay = "";
                string thoidiemdukienbatdausaynhua = "";
                string thoidiemthuctebatdausaynhua = "";
                string khuoncanhadukien = "";
                string khuoncanhathucte = "";
                string khuoncanupdukien = "";
                string khuoncanupthucte = "";
                string thoigianthaykhuondukien = "";
                string thoigianthaykhuonthucte = "";
                string thoigianchaymaydukien = "";
                string thoigianchaymaythucte = "";
                string thoigianlennhietdukien = "";
                string thoigianlennhietthucte = "";
                string thoidiemdukienbatdaulenkhuon = "";
                string thoidiemthuctebatdaulenkhuon = "";
                string songuoithaotacdukien = "";
                string songuoithaotacthucte = "";
                string thoigiansanxuatdukien = "";
                string thoigiansanxuatthucte = "";
                string sanluongducdukien = "";
                string sanluongducthucte = "";
                string thoidiemthuctebatdausanxuat = "";
                string sanluongok = "";
                string soluongfirstshot = "";
                string soluongng = "";
                string tilelinhkienok = "";
                string solandungmay = "";
                string thoigiandungmay = "";
                string tilehoatdongmay = "";
                string tilehoanthanhkehoach = "";
                string kehoachsanxuatsq1 = "";
                string kehoachsanxuatsq2 = "";
                string kehoachsanxuatsq3 = "";
                string kehoachsanxuatsq4 = "";
                string kehoachsanxuatcq1 = "";
                string kehoachsanxuatcq2 = "";
                string kehoachsanxuatcq3 = "";
                string kehoachsanxuatcq4 = "";

                string soshotducsq1 = "";
                string soshotducsq2 = "";
                string soshotducsq3 = "";
                string soshotducsq4 = "";
                string soshotduccq1 = "";
                string soshotduccq2 = "";
                string soshotduccq3 = "";
                string soshotduccq4 = "";
                string sanluongthuctesq1 = "";
                string sanluongthuctesq2 = "";
                string sanluongthuctesq3 = "";
                string sanluongthuctesq4 = "";
                string sanluongthuctecq1 = "";
                string sanluongthuctecq2 = "";
                string sanluongthuctecq3 = "";
                string sanluongthuctecq4 = "";
                string soluongfirstshotsq1 = "";
                string soluongfirstshotsq2 = "";
                string soluongfirstshotsq3 = "";
                string soluongfirstshotsq4 = "";
                string soluongfirstshotcq1 = "";
                string soluongfirstshotcq2 = "";
                string soluongfirstshotcq3 = "";
                string soluongfirstshotcq4 = "";
                string soluongngsq1 = "";
                string soluongngsq2 = "";
                string soluongngsq3 = "";
                string soluongngsq4 = "";
                string soluongngcq1 = "";
                string soluongngcq2 = "";
                string soluongngcq3 = "";
                string soluongngcq4 = "";
                string tilelinhkienoksq1 = "";
                string tilelinhkienoksq2 = "";
                string tilelinhkienoksq3 = "";
                string tilelinhkienoksq4 = "";
                string tilelinhkienokcq1 = "";
                string tilelinhkienokcq2 = "";
                string tilelinhkienokcq3 = "";
                string tilelinhkienokcq4 = "";

                string tilehoanthanhkehoachsq1 = "";
                string tilehoanthanhkehoachsq2 = "";
                string tilehoanthanhkehoachsq3 = "";
                string tilehoanthanhkehoachsq4 = "";
                string tilehoanthanhkehoachcq1 = "";
                string tilehoanthanhkehoachcq2 = "";
                string tilehoanthanhkehoachcq3 = "";
                string tilehoanthanhkehoachcq4 = "";

                if (kiemTraThongTin())
                {
                    QuanlytinhtrangsanxuatDAO.Instance.insertlichsu(ngaygionhapdulieu, may, malinhkien, tenlinhkien, trongluongsanpham, trongluongrunner, kehoachsanxuat, thoidiemdukienbatdausanxuat, tongsoshotduc, tongtrongluong1pcs, cycletimeduc, thoigianvesinhmaysaytieuchuan, thoigianvesinhmaysaythucte, tennguyenlieudukiensudung, tennguyenlieuthuctesudung, capdonguyenlieudukiensudung, capdonguyenlieuthuctesudung, mamaunguyenlieudukiensudung, mamaunguyenlieuthuctesudung, nhietdosay, nhietdosaythucte, thoigiansay, thoigiansaythucte, tilenhuanghientrenfile, tilenhuanghienthucte, luongnhuatinhcandungdukien, luongnhuatinhcandungthucte, luongnhuanghiencandungdukien, luongnhuanghiencandungthucte, thoidiemdukienbatdauvesinhmaysay, thoidiemthuctebatdauvesinhmaysay, thoidiemdukienbatdausaynhua, thoidiemthuctebatdausaynhua, khuoncanhadukien, khuoncanhathucte, khuoncanupdukien, khuoncanupthucte, thoigianthaykhuondukien, thoigianthaykhuonthucte, thoigianchaymaydukien, thoigianchaymaythucte, thoigianlennhietdukien, thoigianlennhietthucte, thoidiemdukienbatdaulenkhuon, thoidiemthuctebatdaulenkhuon, songuoithaotacdukien, songuoithaotacthucte, thoigiansanxuatdukien, thoigiansanxuatthucte, sanluongducdukien, sanluongducthucte, thoidiemthuctebatdausanxuat, sanluongok, soluongfirstshot, soluongng, tilelinhkienok, solandungmay, thoigiandungmay, tilehoatdongmay, tilehoanthanhkehoach, kehoachsanxuatsq1, kehoachsanxuatsq2, kehoachsanxuatsq3, kehoachsanxuatsq4, kehoachsanxuatcq1, kehoachsanxuatcq2, kehoachsanxuatcq3, kehoachsanxuatcq4, soshotducsq1, soshotducsq2, soshotducsq3, soshotducsq4, soshotduccq1, soshotduccq2, soshotduccq3, soshotduccq4, sanluongthuctesq1, sanluongthuctesq2, sanluongthuctesq3, sanluongthuctesq4, sanluongthuctecq1, sanluongthuctecq2, sanluongthuctecq3, sanluongthuctecq4, soluongfirstshotsq1, soluongfirstshotsq2, soluongfirstshotsq3, soluongfirstshotsq4, soluongfirstshotcq1, soluongfirstshotcq2, soluongfirstshotcq3, soluongfirstshotcq4, soluongngsq1, soluongngsq2, soluongngsq3, soluongngsq4, soluongngcq1, soluongngcq2, soluongngcq3, soluongngcq4, tilelinhkienoksq1, tilelinhkienoksq2, tilelinhkienoksq3, tilelinhkienoksq4, tilelinhkienokcq1, tilelinhkienokcq2, tilelinhkienokcq3, tilelinhkienokcq4, tilehoanthanhkehoachsq1, tilehoanthanhkehoachsq2, tilehoanthanhkehoachsq3, tilehoanthanhkehoachsq4, tilehoanthanhkehoachcq1, tilehoanthanhkehoachcq2, tilehoanthanhkehoachcq3, tilehoanthanhkehoachcq4);
                    btnChuanBiNhua.Enabled = true;
                    btnChuanDucLinhKien.Enabled = true;
                    btnDucLinhKien.Enabled = true;
                    btnXacNhan.Enabled = false;
                    btnXacNhan.Text = "";
                    btnXacNhan.BackColor = Color.Gray;

                    txtMay2.Enabled = false;
                    txtMaLinhKien.Enabled = false;
                    txtKeHoachSanXuat.Enabled = false;
                    dtp1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Chưa điền đẩy đủ thông tin");
                }
            }
            else
            {
                //else code here.... 
            }
            
        }

        private void btnChuanBiNhua_Click(object sender, EventArgs e)
        {
            if (kiemTraThongTin())
            {
                using (FormChuanBiNhua ChuanBiNhua = new FormChuanBiNhua())
                {
                    ChuanBiNhua.ngaygionhapdulieu = DateTime.Now.ToString("dd/MM/yyyy");
                    ChuanBiNhua.malinhkien = txtMaLinhKien.Text;
                    ChuanBiNhua.kehoachsanxuat = (float)Convert.ToDouble(txtKeHoachSanXuat.Text);
                    ChuanBiNhua.thoidiemdukienbatdausanxuat = dtp1.Value;
                    ChuanBiNhua.may = txtMay2.Text;
                    ChuanBiNhua.may5 = txtMay2.Text;
                    ChuanBiNhua.ShowDialog();
                    //btnChuanBiNhua.Enabled = false;
                    //btnChuanDucLinhKien.Enabled = true;
                    //btnDucLinhKien.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Chưa điền đẩy đủ thông tin");
            }
               
        }

        private void btnChuanDucLinhKien_Click(object sender, EventArgs e)
        {
            if (kiemTraThongTin())
            {
                using (FormChuanDucLinhKien ChuanDucLinhKien = new FormChuanDucLinhKien())
                {
                    ChuanDucLinhKien.ngaygionhapdulieu = DateTime.Now.ToString("dd/MM/yyyy");
                    ChuanDucLinhKien.malinhkien = txtMaLinhKien.Text;
                    ChuanDucLinhKien.kehoachsanxuat = txtKeHoachSanXuat.Text;
                    ChuanDucLinhKien.thoidiemdukienbatdausanxuat = dtp1.Value;
                    ChuanDucLinhKien.may = txtMay2.Text;
                    ChuanDucLinhKien.ShowDialog();
                    //btnChuanBiNhua.Enabled = false;
                    //btnChuanDucLinhKien.Enabled = false;
                    //btnDucLinhKien.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Chưa điền đẩy đủ thông tin");
            }
        }
        private void LoadData(string data1, string data2, string data3, string data4, string data5, string data6, string data7, string data8,string data9, string data10, string data11, string data12, string data13, string data14, string data15, string data17, string data18, string data19, string data20, string data21, string data22, string data23, string data24, string data25, string data26, string data27, string data28, string data29, string data30, string data31, string data32)
        {
            txtSlttSq1.Text = "";
            txtSlttSq1.Text = data1;
            txtSlttSq2.Text = "";
            txtSlttSq2.Text = data2;
            txtSlttSq3.Text = "";
            txtSlttSq3.Text = data3;
            txtSlttSq4.Text = "";
            txtSlttSq4.Text = data4;
            txtSlttCq1.Text = "";
            txtSlttCq1.Text = data5;
            txtSlttCq2.Text = "";
            txtSlttCq2.Text = data6;
            txtSlttCq3.Text = "";
            txtSlttCq3.Text = data7;
            txtSlttCq4.Text = "";
            txtSlttCq4.Text = data8;
            txtTongSoShotDuc.Text = "";
            txtTongSoShotDuc.Text = data9;
            txtSanLuongOk.Text = "";
            txtSanLuongOk.Text = data10;
            txtSanLuongNg.Text = "";
            txtSanLuongNg.Text = data11;
            txtTiLeLinhKienOk.Text = "";
            txtTiLeLinhKienOk.Text = data12;
            txtThoiGianSanXuatThucTe.Text = "";
            txtThoiGianSanXuatThucTe.Text = data13;
            txtThoiGianDungMay.Text = "";
            txtThoiGianDungMay.Text = data14;
            txtSoNguoiThaoTac.Text = "";
            txtSoNguoiThaoTac.Text = data15;
            txtKhsxSq1.Text = "";
            txtKhsxSq1.Text = data17;
            txtKhsxSq2.Text = "";
            txtKhsxSq2.Text = data18;
            txtKhsxSq3.Text = "";
            txtKhsxSq3.Text = data19;
            txtKhsxSq4.Text = "";
            txtKhsxSq4.Text = data20;
            txtKhsxCq1.Text = "";
            txtKhsxCq1.Text = data21;
            txtKhsxCq2.Text = "";
            txtKhsxCq2.Text = data22;
            txtKhsxCq3.Text = "";
            txtKhsxCq3.Text = data23;
            txtKhsxCq4.Text = "";
            txtKhsxCq4.Text = data24;
            txttlhtkhSq1.Text = "";
            txttlhtkhSq1.Text = data25;
            txttlhtkhSq2.Text = "";
            txttlhtkhSq2.Text = data26;
            txttlhtkhSq3.Text = "";
            txttlhtkhSq3.Text = data27;
            txttlhtkhSq4.Text = "";
            txttlhtkhSq4.Text = data28;
            txttlhtkhCq1.Text = "";
            txttlhtkhCq1.Text = data29;
            txttlhtkhCq2.Text = "";
            txttlhtkhCq2.Text = data30;
            txttlhtkhCq3.Text = "";
            txttlhtkhCq3.Text = data31;
            txttlhtkhCq4.Text = "";
            txttlhtkhCq4.Text = data32;
        }
       
        private void btnDucLinhKien_Click(object sender, EventArgs e)
        {
            if (kiemTraThongTin())
            {
                using (FormDucLinhKien DucLinhKien = new FormDucLinhKien())
                {
                    //DucLinhKien.tongsoshotduc1 = (float)Convert.ToDouble(txtTongSoShotDuc.Text);
                    DucLinhKien.ngaygionhapdulieu1 = DateTime.Now.ToString("dd/MM/yyyy");
                    DucLinhKien.malinhkien1 = txtMaLinhKien.Text;
                    DucLinhKien.kehoachsanxuat1 = txtKeHoachSanXuat.Text;
                    DucLinhKien.thoidiemdukienbatdausanxuat1 = dtp1.Value;
                    DucLinhKien.may1 = txtMay2.Text;
                    DucLinhKien.kehoachsanxuatdukien = (float)Convert.ToDouble(txtKeHoachSanXuat.Text);

                    TimeSpan timeofday = dtp1.Value.TimeOfDay;
                    DucLinhKien.TIMEOFDAYthoidiemdukienbatdausanxuat = timeofday;
                    DucLinhKien.SOGIOthoidiemdukienbatdausanxuat = dtp1.Value.Hour;
                    DucLinhKien.SOPHUTthoidiemdukienbatdausanxuat = dtp1.Value.Minute;

                    DucLinhKien.truyenData = new FormDucLinhKien.TRUYENDULIEU(LoadData);

                    DucLinhKien.ShowDialog();
                    //btnChuanBiNhua.Enabled = false;
                    //btnChuanDucLinhKien.Enabled = false;
                    //btnDucLinhKien.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Chưa điền đẩy đủ thông tin");
            }

        }

        private void Form_chinh_Load(object sender, EventArgs e)
        {
            btnChuanBiNhua.Enabled = false;
            btnChuanDucLinhKien.Enabled = false;
            btnDucLinhKien.Enabled = false;
            timer1.Enabled = true;
            button1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNgayThangNam.Text = DateTime.Now.ToString("f");
        }
        bool checkBody(string malinhkien)
        {
            return QuanlytinhtrangsanxuatDAO.Instance.checkmalinhkien(malinhkien);
        }
        private bool Kiemtratrungmalinhkien()
        {
            string malinhkien = txtMaLinhKien.Text;
            if (checkBody(malinhkien))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        private void txtMay_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtMay2.Text != ""))
            {
                txtMaLinhKien.Focus();
            }
        }

        private void txtMaLinhKien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + txtMaLinhKien.Text + "'");
                if (Kiemtratrungmalinhkien())
                {
                    tenlinhkien = data.Rows[0][2].ToString();
                    tilenhuanghientrenbanve = (float)Convert.ToDouble(data.Rows[0][3].ToString());
                    tilenhuanghiendathunghiemok = (float)Convert.ToDouble(data.Rows[0][4].ToString());
                    socavity = (float)Convert.ToDouble(data.Rows[0][5].ToString());
                    loaimayduc = (float)Convert.ToDouble(data.Rows[0][6].ToString()); 
                    cycletime = (float)Convert.ToDouble(data.Rows[0][7].ToString());
                    loainhua = data.Rows[0][8].ToString();
                    tennguyenlieu = data.Rows[0][9].ToString();
                    capdonguyenlieu = data.Rows[0][10].ToString();
                    mamau = data.Rows[0][11].ToString();
                    nhietdosay = (float)Convert.ToDouble(data.Rows[0][12].ToString());
                    thoigiansay = (float)Convert.ToDouble(data.Rows[0][13].ToString());
                    thoigianupkhuon = (float)Convert.ToDouble(data.Rows[0][14].ToString());
                    thoigianhakhuon = (float)Convert.ToDouble(data.Rows[0][15].ToString());
                    thoigianchaymay = (float)Convert.ToDouble(data.Rows[0][16].ToString());
                    thoigiandungmay = (float)Convert.ToDouble(data.Rows[0][17].ToString());
                    songuoithaotac = (float)Convert.ToDouble(data.Rows[0][18].ToString());
                    thoigianlennhietmayduc = (float)Convert.ToDouble(data.Rows[0][19].ToString());
                    thoigianlennhiethotrunner = (float)Convert.ToDouble(data.Rows[0][20].ToString());
                    thoigianlennhietkhuon = (float)Convert.ToDouble(data.Rows[0][21].ToString());
                    thoigianvesinhmaysay = (float)Convert.ToDouble(data.Rows[0][22].ToString());
                    trongluongsanpham = (float)Convert.ToDouble(data.Rows[0][23].ToString());
                    trongluongrunnergate = (float)Convert.ToDouble(data.Rows[0][24].ToString());
                    tongtrongluongsanpham = (float)Convert.ToDouble(data.Rows[0][25].ToString());
                    soluongfirstshotmotlan = (float)Convert.ToDouble(data.Rows[0][26].ToString());

                    txtTenLinhKien.Text = tenlinhkien;
                    txtTrongLuongSanPham.Text = trongluongsanpham.ToString();
                    txtTrongLuongRuner.Text = trongluongrunnergate.ToString();
                    txtCycletime.Text = cycletime.ToString();
                    txtTongTrongLuong.Text = (((trongluongsanpham * socavity) + trongluongrunnergate) / socavity).ToString();
                    txtKeHoachSanXuat.Focus();
                    //btnChuanBiNhua.Enabled = true;
                }  
            }
            
        }

        private void txtKeHoachSanXuat_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtKeHoachSanXuat.Text != ""))
            {
                dtp1.Focus();
            }
        }
        private void dtp1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnChuanBiNhua.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận hoàn thành và lưu toàn bộ dữ liệu? (Không thể hoàn tác)", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Controls.Clear();
                this.InitializeComponent();
                btnChuanBiNhua.Enabled = false;
                btnChuanDucLinhKien.Enabled = false;
                btnDucLinhKien.Enabled = false;
                button1.Enabled = false;
                timer1.Enabled = true;
            }
            else
            {
                //else code here.... 
            }
        }

        private void txtKeHoachSanXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Nếu bạn muốn, bạn có thể cho phép nhập số thực với dấu chấm
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }    
        private void button3_Click(object sender, EventArgs e)
        {
            using (FormLichSu LichSu = new FormLichSu())
            {
                LichSu.ShowDialog();
            }
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "@MO123")
            {
                button1.Enabled = true;
            }

        }

        private void btnChinhSuaDuLieu_Click(object sender, EventArgs e)
        {
            using (frmLoginChinhSuaDuLieuDatabase frmLoginChinhSuaDuLieuDatabase = new frmLoginChinhSuaDuLieuDatabase())
            {
                frmLoginChinhSuaDuLieuDatabase.ShowDialog();
            }
        }

        private void Form_chinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("KIỂM TRA LẠI DỮ LIỆU ĐÃ ĐƯỢC LƯU CHƯA TRƯỚC KHI THOÁT!", "BAN MUỐN THOÁT?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {

            }
        }
    }
}

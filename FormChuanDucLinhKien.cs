 using D67.DAO;
using Quanlytinhtrangsanxuat.DAO;
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
    public partial class FormChuanDucLinhKien : Form
    {
        public FormChuanDucLinhKien()
        {
            InitializeComponent();
        }
        public DateTime thoidiemdukienbatdausanxuat;
        public string malinhkien;
        public string may;
        public string kehoachsanxuat;
        public string ngaygionhapdulieu;
        private float thoigianupkhuon1;

        private void FormChuanDucLinhKien_Load(object sender, EventArgs e)
        {

            DataTable load = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Lichsu WHERE malinhkien='" + malinhkien + "' AND may='" + may + "' AND ngaygionhapdulieu='" + ngaygionhapdulieu + "' ");

            string loadid;
            string loadngaygionhapdulieu;
            string loadmay;
            string loadmalinhkien;
            string loadtenlinhkien;
            string loadtrongluongsanpham;
            string loadtrongluongrunner;
            string loadkehoachsanxuat;
            string loadthoidiemdukienbatdausanxuat;
            string loadtongsoshotduc;
            string loadtongtrongluong1pcs;
            string loadcycletimeduc;
            string loadthoigianvesinhmaysaytieuchuan;
            string loadthoigianvesinhmaysaythucte;
            string loadtennguyenlieudukiensudung;
            string loadtennguyenlieuthuctesudung;
            string loadcapdonguyenlieudukiensudung;
            string loadcapdonguyenlieuthuctesudung;
            string loadmamaunguyenlieudukiensudung;
            string loadmamaunguyenlieuthuctesudung;
            string loadnhietdosay;
            string loadnhietdosaythucte;
            string loadthoigiansay;
            string loadthoigiansaythucte;
            string loadtilenhuanghientrenfile;
            string loadtilenhuanghienthucte;
            string loadluongnhuatinhcandungdukien;
            string loadluongnhuatinhcandungthucte;
            string loadluongnhuanghiencandungdukien;
            string loadluongnhuanghiencandungthucte;
            string loadthoidiemdukienbatdauvesinhmaysay;
            string loadthoidiemthuctebatdauvesinhmaysay;
            string loadthoidiemdukienbatdausaynhua;
            string loadthoidiemthuctebatdausaynhua;
            string loadkhuoncanhadukien;
            string loadkhuoncanhathucte;
            string loadkhuoncanupdukien;
            string loadkhuoncanupthucte;
            string loadthoigianthaykhuondukien;
            string loadthoigianthaykhuonthucte;
            string loadthoigianchaymaydukien;
            string loadthoigianchaymaythucte;
            string loadthoigianlennhietdukien;
            string loadthoigianlennhietthucte;
            string loadthoidiemdukienbatdaulenkhuon;
            string loadthoidiemthuctebatdaulenkhuon;
            string loadsonguoithaotacdukien;
            string loadsonguoithaotacthucte;
            string loadthoigiansanxuatdukien;
            string loadthoigiansanxuatthucte;
            string loadsanluongducdukien;
            string loadsanluongducthucte;
            string loadthoidiemthuctebatdausanxuat;
            string loadsanluongok;
            string loadsoluongfirstshot;
            string loadsoluongng;
            string loadtilelinhkienok;
            string loadsolandungmay;
            string loadthoigiandungmay;
            string loadtilehoatdongmay;
            string loadtilehoanthanhkehoach;
            string loadkehoachsanxuatsq1;
            string loadkehoachsanxuatsq2;
            string loadkehoachsanxuatsq3;
            string loadkehoachsanxuatsq4;
            string loadkehoachsanxuatcq1;
            string loadkehoachsanxuatcq2;
            string loadkehoachsanxuatcq3;
            string loadkehoachsanxuatcq4;
            string loadsanluongthuctesq1;
            string loadsanluongthuctesq2;
            string loadsanluongthuctesq3;
            string loadsanluongthuctesq4;
            string loadsanluongthuctecq1;
            string loadsanluongthuctecq2;
            string loadsanluongthuctecq3;
            string loadsanluongthuctecq4;
            string loadtilehoanthanhkehoachsq1;
            string loadtilehoanthanhkehoachsq2;
            string loadtilehoanthanhkehoachsq3;
            string loadtilehoanthanhkehoachsq4;
            string loadtilehoanthanhkehoachcq1;
            string loadtilehoanthanhkehoachcq2;
            string loadtilehoanthanhkehoachcq3;
            string loadtilehoanthanhkehoachcq4;

            loadid = load.Rows[0][0].ToString();
            loadngaygionhapdulieu = load.Rows[0][1].ToString();
            loadmay = load.Rows[0][2].ToString();
            loadmalinhkien = load.Rows[0][3].ToString();
            loadtenlinhkien = load.Rows[0][4].ToString();
            loadtrongluongsanpham = load.Rows[0][5].ToString();
            loadtrongluongrunner = load.Rows[0][6].ToString();
            loadkehoachsanxuat = load.Rows[0][7].ToString();
            loadthoidiemdukienbatdausanxuat = load.Rows[0][8].ToString();
            loadtongsoshotduc = load.Rows[0][9].ToString();
            loadtongtrongluong1pcs = load.Rows[0][10].ToString();
            loadcycletimeduc = load.Rows[0][11].ToString();
            loadthoigianvesinhmaysaytieuchuan = load.Rows[0][12].ToString();
            loadthoigianvesinhmaysaythucte = load.Rows[0][13].ToString();
            loadtennguyenlieudukiensudung = load.Rows[0][14].ToString();
            loadtennguyenlieuthuctesudung = load.Rows[0][15].ToString();
            loadcapdonguyenlieudukiensudung = load.Rows[0][16].ToString();
            loadcapdonguyenlieuthuctesudung = load.Rows[0][17].ToString();
            loadmamaunguyenlieudukiensudung = load.Rows[0][18].ToString();
            loadmamaunguyenlieuthuctesudung = load.Rows[0][19].ToString();
            loadnhietdosay = load.Rows[0][20].ToString();
            loadnhietdosaythucte = load.Rows[0][21].ToString();
            loadthoigiansay = load.Rows[0][22].ToString();
            loadthoigiansaythucte = load.Rows[0][23].ToString();
            loadtilenhuanghientrenfile = load.Rows[0][24].ToString();
            loadtilenhuanghienthucte = load.Rows[0][25].ToString();
            loadluongnhuatinhcandungdukien = load.Rows[0][26].ToString();
            loadluongnhuatinhcandungthucte = load.Rows[0][27].ToString();
            loadluongnhuanghiencandungdukien = load.Rows[0][28].ToString();
            loadluongnhuanghiencandungthucte = load.Rows[0][29].ToString();
            loadthoidiemdukienbatdauvesinhmaysay = load.Rows[0][30].ToString();
            loadthoidiemthuctebatdauvesinhmaysay = load.Rows[0][31].ToString();
            loadthoidiemdukienbatdausaynhua = load.Rows[0][32].ToString();
            loadthoidiemthuctebatdausaynhua = load.Rows[0][33].ToString();
            loadkhuoncanhadukien = load.Rows[0][34].ToString();
            loadkhuoncanhathucte = load.Rows[0][35].ToString();
            loadkhuoncanupdukien = load.Rows[0][36].ToString();
            loadkhuoncanupthucte = load.Rows[0][37].ToString();
            loadthoigianthaykhuondukien = load.Rows[0][38].ToString();
            loadthoigianthaykhuonthucte = load.Rows[0][39].ToString();
            loadthoigianchaymaydukien = load.Rows[0][40].ToString();
            loadthoigianchaymaythucte = load.Rows[0][41].ToString();
            loadthoigianlennhietdukien = load.Rows[0][42].ToString();
            loadthoigianlennhietthucte = load.Rows[0][43].ToString();
            loadthoidiemdukienbatdaulenkhuon = load.Rows[0][44].ToString();
            loadthoidiemthuctebatdaulenkhuon = load.Rows[0][45].ToString();
            loadsonguoithaotacdukien = load.Rows[0][46].ToString();
            loadsonguoithaotacthucte = load.Rows[0][47].ToString();
            loadthoigiansanxuatdukien = load.Rows[0][48].ToString();
            loadthoigiansanxuatthucte = load.Rows[0][49].ToString();
            loadsanluongducdukien = load.Rows[0][50].ToString();
            loadsanluongducthucte = load.Rows[0][51].ToString();
            loadthoidiemthuctebatdausanxuat = load.Rows[0][52].ToString();
            loadsanluongok = load.Rows[0][53].ToString();
            loadsoluongfirstshot = load.Rows[0][54].ToString();
            loadsoluongng = load.Rows[0][55].ToString();
            loadtilelinhkienok = load.Rows[0][56].ToString();
            loadsolandungmay = load.Rows[0][57].ToString();
            loadthoigiandungmay = load.Rows[0][58].ToString();
            loadtilehoatdongmay = load.Rows[0][59].ToString();
            loadtilehoanthanhkehoach = load.Rows[0][60].ToString();
            loadkehoachsanxuatsq1 = load.Rows[0][61].ToString();
            loadkehoachsanxuatsq2 = load.Rows[0][62].ToString();
            loadkehoachsanxuatsq3 = load.Rows[0][63].ToString();
            loadkehoachsanxuatsq4 = load.Rows[0][64].ToString();
            loadkehoachsanxuatcq1 = load.Rows[0][65].ToString();
            loadkehoachsanxuatcq2 = load.Rows[0][66].ToString();
            loadkehoachsanxuatcq3 = load.Rows[0][67].ToString();
            loadkehoachsanxuatcq4 = load.Rows[0][68].ToString();
            loadsanluongthuctesq1 = load.Rows[0][69].ToString();
            loadsanluongthuctesq2 = load.Rows[0][70].ToString();
            loadsanluongthuctesq3 = load.Rows[0][71].ToString();
            loadsanluongthuctesq4 = load.Rows[0][72].ToString();
            loadsanluongthuctecq1 = load.Rows[0][73].ToString();
            loadsanluongthuctecq2 = load.Rows[0][74].ToString();
            loadsanluongthuctecq3 = load.Rows[0][75].ToString();
            loadsanluongthuctecq4 = load.Rows[0][76].ToString();
            loadtilehoanthanhkehoachsq1 = load.Rows[0][77].ToString();
            loadtilehoanthanhkehoachsq2 = load.Rows[0][78].ToString();
            loadtilehoanthanhkehoachsq3 = load.Rows[0][79].ToString();
            loadtilehoanthanhkehoachsq4 = load.Rows[0][80].ToString();
            loadtilehoanthanhkehoachcq1 = load.Rows[0][81].ToString();
            loadtilehoanthanhkehoachcq2 = load.Rows[0][82].ToString();
            loadtilehoanthanhkehoachcq3 = load.Rows[0][83].ToString();
            loadtilehoanthanhkehoachcq4 = load.Rows[0][84].ToString();

            txtKhuonCanHaDuKien.Text = loadkhuoncanhadukien.ToString();
            txtKhuocCanUpDuKien.Text = loadkhuoncanupdukien.ToString();
            txtThoiGianThayKhuonDuKien.Text = loadthoigianthaykhuondukien.ToString();
            txtThoiGianChayMayDuKien.Text = loadthoigianchaymaydukien.ToString();
            txtThoiGianLenNhietDuKien.Text = loadthoigianlennhietdukien.ToString();
            txtThoiDiemDuKienBatDauLenKhuon.Text = loadthoidiemdukienbatdaulenkhuon.ToString();
            txtKhuonCanHaThucTe.Text = loadkhuoncanhathucte.ToString();
            txtKhuocCanUpThucTe.Text = loadkhuoncanupthucte.ToString();
            txtThoiGianThayKhuonThucTe.Text = loadthoigianthaykhuonthucte.ToString();
            txtThoiGianChayMayThucTe.Text = loadthoigianchaymaythucte.ToString();
            txtThoiGianLenNhietThucTe.Text = loadthoigianlennhietthucte.ToString();

            try
            {
                DataTable data2 = DataProvider.Instance.ExecuteQuery("SELECT TOP 2 * FROM dbo.Lichsu WHERE may='" + may + "' ORDER BY id DESC");
                string khuoncanhadukien;
                khuoncanhadukien = data2.Rows[1][3].ToString();
                txtKhuonCanHaDuKien.Text = khuoncanhadukien.ToString();
                DataTable data3 = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + khuoncanhadukien + "'");
                
                thoigianupkhuon1 = (float)Convert.ToDouble(data3.Rows[0][13].ToString());
            }
            catch
            {
                txtKhuonCanHaDuKien.Text = "Không có dữ liệu";
                thoigianupkhuon1 = 0;

            }

            timer1.Enabled = true;
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + malinhkien + "'");
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

            txtKhuocCanUpDuKien.Text = malinhkien;
            txtThoiGianChayMayDuKien.Text = thoigianchaymay.ToString();

            txtThoiGianThayKhuonDuKien.Text = (thoigianupkhuon1 + thoigianhakhuon).ToString();

            txtThoiGianLenNhietDuKien.Text  = (thoigianlennhiethotrunner > thoigianlennhietmayduc ? thoigianlennhiethotrunner > thoigianlennhietkhuon ? thoigianlennhiethotrunner : thoigianlennhietkhuon : thoigianlennhietmayduc).ToString();
            float thoigianlennhietdukien = (float)Convert.ToDouble(txtThoiGianLenNhietDuKien.Text);
            txtThoiDiemDuKienBatDauLenKhuon.Text = thoidiemdukienbatdausanxuat.AddMinutes(-(thoigianlennhietdukien+thoigianchaymay+thoigiandungmay)).ToString("dd/MM/yyyy hh:mm tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNGayThangNam.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void txtKhuonCanHaThucTe_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtKhuonCanHaThucTe.Text != ""))
            {
                txtKhuocCanUpThucTe.Focus();
                if(txtKhuonCanHaThucTe.Text == txtKhuonCanHaDuKien.Text)
                {
                    lblKetQuaKhuonCanHaThucTe.Text = "OK";
                    lblKetQuaKhuonCanHaThucTe.ForeColor = Color.Green;
                }
                else
                {
                    lblKetQuaKhuonCanHaThucTe.Text = "NG";
                    lblKetQuaKhuonCanHaThucTe.ForeColor = Color.Red;
                }
            }
        }

        private void txtKhuocCanUpThucTe_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtKhuocCanUpThucTe.Text != ""))
            {
                txtThoiGianThayKhuonThucTe.Focus();
                if (txtKhuocCanUpThucTe.Text == txtKhuocCanUpDuKien.Text)
                {
                    lblKetQuaKhuocCanUpThucTe.Text = "OK";
                    lblKetQuaKhuocCanUpThucTe.ForeColor = Color.Green;
                }
                else
                {
                    lblKetQuaKhuocCanUpThucTe.Text = "NG";
                    lblKetQuaKhuocCanUpThucTe.ForeColor = Color.Red;
                }
            }
        }

        private void txtThoiGianThayKhuonThucTe_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtThoiGianThayKhuonThucTe.Text != ""))
            {
                txtThoiGianChayMayThucTe.Focus();
            }
        }

        private void txtThoiGianChayMayThucTe_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtThoiGianChayMayThucTe.Text != ""))
            {
                txtThoiGianLenNhietThucTe.Focus();
            }
        }
        private void txtThoiGianLenNhietThucTe_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtThoiGianLenNhietThucTe.Text != ""))
            {
                dateTimePicker1.Focus();
            }
        }
        private void txtThoiGianThayKhuonThucTe_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtThoiGianChayMayThucTe_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtThoiGianLenNhietThucTe_KeyPress(object sender, KeyPressEventArgs e)
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
        //public bool kiemTraThongTin()
        //{
        //    if (txtKhuonCanHaThucTe.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtKhuonCanHaThucTe.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }

        //    if (txtKhuocCanUpThucTe.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtKhuocCanUpThucTe.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }
        //    if (txtThoiGianThayKhuonThucTe.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtThoiGianThayKhuonThucTe.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }

        //    if (txtThoiGianChayMayThucTe.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtThoiGianChayMayThucTe.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }

        //    if (txtThoiGianLenNhietThucTe.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        txtThoiGianLenNhietThucTe.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }
        //    return true; //tiếp tục thực thi chương trình.
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            string khuoncanhadukien = txtKhuonCanHaDuKien.Text;
            string khuoncanhathucte = txtKhuonCanHaThucTe.Text;
            string khuoncanupdukien = txtKhuocCanUpDuKien.Text;
            string khuoncanupthucte = txtKhuocCanUpThucTe.Text;
            string thoigianthaykhuondukien = txtThoiGianThayKhuonDuKien.Text;
            string thoigianthaykhuonthucte = txtThoiGianThayKhuonThucTe.Text;
            string thoigianchaymaydukien = txtThoiGianChayMayDuKien.Text;
            string thoigianchaymaythucte = txtThoiGianChayMayThucTe.Text;
            string thoigianlennhietdukien = txtThoiGianLenNhietDuKien.Text;
            string thoigianlennhietthucte = txtThoiGianLenNhietThucTe.Text;
            string thoidiemdukienbatdaulenkhuon = txtThoiDiemDuKienBatDauLenKhuon.Text;
            string thoidiemthuctebatdaulenkhuon = dateTimePicker1.Value.ToString("dd/MM/yyyy hh:mm tt");

            QuanlytinhtrangsanxuatDAO.Instance.insertchuanbiduclinhkien(may, malinhkien, ngaygionhapdulieu, kehoachsanxuat, khuoncanhadukien, khuoncanhathucte, khuoncanupdukien, khuoncanupthucte, thoigianthaykhuondukien, thoigianthaykhuonthucte, thoigianchaymaydukien, thoigianchaymaythucte, thoigianlennhietdukien, thoigianlennhietthucte, thoidiemdukienbatdaulenkhuon, thoidiemthuctebatdaulenkhuon);

            //btnChuanBiNhua.Enabled = false;
            //btnChuanDucLinhKien.Enabled = false;
            //btnDucLinhKien.Enabled = false;
            //MessageBox.Show("Đã lưu dữ liệu vào Database!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }


    }
}

﻿using D67.DAO;
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
    public partial class FormLichSu : Form
    {
       

        public static string may2;
        public static string malinhkien2;
        public static string ngaygionhapdulieu2;

        public FormLichSu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtMayS.Text != "") && (txtMaLinhKienS.Text != ""))
            {
                try
                {

                    string ngaygionhapdulieu1 = dtp1.Value.ToString("dd/MM/yyyy");
                    string malinhkien1 = txtMaLinhKienS.Text;
                    string may1 = txtMayS.Text;

                    DataTable load = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Lichsu WHERE malinhkien='" + malinhkien1 + "' AND may='" + may1 + "' AND ngaygionhapdulieu='" + ngaygionhapdulieu1 + "' ");

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
                    string loadsoshotducsq1;
                    string loadsoshotducsq2;
                    string loadsoshotducsq3;
                    string loadsoshotducsq4;
                    string loadsoshotduccq1;
                    string loadsoshotduccq2;
                    string loadsoshotduccq3;
                    string loadsoshotduccq4;
                    string loadsanluongthuctesq1;
                    string loadsanluongthuctesq2;
                    string loadsanluongthuctesq3;
                    string loadsanluongthuctesq4;
                    string loadsanluongthuctecq1;
                    string loadsanluongthuctecq2;
                    string loadsanluongthuctecq3;
                    string loadsanluongthuctecq4;
                    string loadsoluongfirstshotsq1;
                    string loadsoluongfirstshotsq2;
                    string loadsoluongfirstshotsq3;
                    string loadsoluongfirstshotsq4;
                    string loadsoluongfirstshotcq1;
                    string loadsoluongfirstshotcq2;
                    string loadsoluongfirstshotcq3;
                    string loadsoluongfirstshotcq4;
                    string loadsoluongngsq1;
                    string loadsoluongngsq2;
                    string loadsoluongngsq3;
                    string loadsoluongngsq4;
                    string loadsoluongngcq1;
                    string loadsoluongngcq2;
                    string loadsoluongngcq3;
                    string loadsoluongngcq4;
                    string loadtilelinhkienoksq1;
                    string loadtilelinhkienoksq2;
                    string loadtilelinhkienoksq3;
                    string loadtilelinhkienoksq4;
                    string loadtilelinhkienokcq1;
                    string loadtilelinhkienokcq2;
                    string loadtilelinhkienokcq3;
                    string loadtilelinhkienokcq4;
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
                    loadsoshotducsq1 = load.Rows[0][69].ToString();
                    loadsoshotducsq2 = load.Rows[0][70].ToString();
                    loadsoshotducsq3 = load.Rows[0][71].ToString();
                    loadsoshotducsq4 = load.Rows[0][72].ToString();
                    loadsoshotduccq1 = load.Rows[0][73].ToString();
                    loadsoshotduccq2 = load.Rows[0][74].ToString();
                    loadsoshotduccq3 = load.Rows[0][75].ToString();
                    loadsoshotduccq4 = load.Rows[0][76].ToString();
                    loadsanluongthuctesq1 = load.Rows[0][77].ToString();
                    loadsanluongthuctesq2 = load.Rows[0][78].ToString();
                    loadsanluongthuctesq3 = load.Rows[0][79].ToString();
                    loadsanluongthuctesq4 = load.Rows[0][80].ToString();
                    loadsanluongthuctecq1 = load.Rows[0][81].ToString();
                    loadsanluongthuctecq2 = load.Rows[0][82].ToString();
                    loadsanluongthuctecq3 = load.Rows[0][83].ToString();
                    loadsanluongthuctecq4 = load.Rows[0][84].ToString();
                    loadsoluongfirstshotsq1 = load.Rows[0][85].ToString();
                    loadsoluongfirstshotsq2 = load.Rows[0][86].ToString();
                    loadsoluongfirstshotsq3 = load.Rows[0][87].ToString();
                    loadsoluongfirstshotsq4 = load.Rows[0][88].ToString();
                    loadsoluongfirstshotcq1 = load.Rows[0][89].ToString();
                    loadsoluongfirstshotcq2 = load.Rows[0][90].ToString();
                    loadsoluongfirstshotcq3 = load.Rows[0][91].ToString();
                    loadsoluongfirstshotcq4 = load.Rows[0][92].ToString();
                    loadsoluongngsq1 = load.Rows[0][93].ToString();
                    loadsoluongngsq2 = load.Rows[0][94].ToString();
                    loadsoluongngsq3 = load.Rows[0][95].ToString();
                    loadsoluongngsq4 = load.Rows[0][96].ToString();
                    loadsoluongngcq1 = load.Rows[0][97].ToString();
                    loadsoluongngcq2 = load.Rows[0][98].ToString();
                    loadsoluongngcq3 = load.Rows[0][99].ToString();
                    loadsoluongngcq4 = load.Rows[0][100].ToString();
                    loadtilelinhkienoksq1 = load.Rows[0][101].ToString();
                    loadtilelinhkienoksq2 = load.Rows[0][102].ToString();
                    loadtilelinhkienoksq3 = load.Rows[0][103].ToString();
                    loadtilelinhkienoksq4 = load.Rows[0][104].ToString();
                    loadtilelinhkienokcq1 = load.Rows[0][105].ToString();
                    loadtilelinhkienokcq2 = load.Rows[0][106].ToString();
                    loadtilelinhkienokcq3 = load.Rows[0][107].ToString();
                    loadtilelinhkienokcq4 = load.Rows[0][108].ToString();
                    loadtilehoanthanhkehoachsq1 = load.Rows[0][109].ToString();
                    loadtilehoanthanhkehoachsq2 = load.Rows[0][110].ToString();
                    loadtilehoanthanhkehoachsq3 = load.Rows[0][111].ToString();
                    loadtilehoanthanhkehoachsq4 = load.Rows[0][112].ToString();
                    loadtilehoanthanhkehoachcq1 = load.Rows[0][113].ToString();
                    loadtilehoanthanhkehoachcq2 = load.Rows[0][114].ToString();
                    loadtilehoanthanhkehoachcq3 = load.Rows[0][115].ToString();
                    loadtilehoanthanhkehoachcq4 = load.Rows[0][116].ToString();

                    txtMay.Text = loadmay.ToString();
                    txtMaLinhKien.Text = loadmalinhkien.ToString();
                    txtTenLinhKien.Text = loadtenlinhkien.ToString();
                    txtTrongLuongSanPham.Text = loadtrongluongsanpham.ToString();
                    txtTrongLuongRuner.Text = loadtrongluongrunner.ToString();
                    txtKeHoachSanXuat.Text = loadkehoachsanxuat.ToString();
                    txtthoidiemdukienbatdausanxuat.Text = loadthoidiemdukienbatdausanxuat.ToString();
                    txtTongSoShotDuc.Text = loadtongsoshotduc.ToString();
                    txtTongTrongLuong.Text = loadtongtrongluong1pcs.ToString();
                    txtCycletime.Text = loadcycletimeduc.ToString();
                }
                catch
                {
                    MessageBox.Show("Không tìm thấy dữ liệu");
                }


            }

            else
            {
                MessageBox.Show("Chưa nhập đủ thông tin để tìm kiếm dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        

            private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChuanBiNhua_Click(object sender, EventArgs e)
        {
            try
            {
                FormLichSu.may2 = txtMay.Text.ToString();
                FormLichSu.malinhkien2 = txtMaLinhKien.Text.ToString();
                FormLichSu.ngaygionhapdulieu2 = dtp1.Value.ToString("dd/MM/yyyy");

                loadform(new LSchuanbinhua());
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }



      
        }


        public void loadform(Form frm)
        {
            panel2.Controls.Clear();
            AddOwnedForm(frm);
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panel2.Tag = frm;
            panel2.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnChuanDucLinhKien_Click(object sender, EventArgs e)
        {
            try
            {
                FormLichSu.may2 = txtMay.Text.ToString();
                FormLichSu.malinhkien2 = txtMaLinhKien.Text.ToString();
                FormLichSu.ngaygionhapdulieu2 = dtp1.Value.ToString("dd/MM/yyyy");


                loadform(new LSchuanbiduclinhkien());
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }


        
        }

        private void btnDucLinhKien_Click(object sender, EventArgs e)
        {
            try
            {
                FormLichSu.may2 = txtMay.Text.ToString();
                FormLichSu.malinhkien2 = txtMaLinhKien.Text.ToString();
                FormLichSu.ngaygionhapdulieu2 = dtp1.Value.ToString("dd/MM/yyyy");


                loadform(new LSduclinhkien());
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FormLichSu.may2 = txtMay.Text.ToString();
                FormLichSu.malinhkien2 = txtMaLinhKien.Text.ToString();
                FormLichSu.ngaygionhapdulieu2 = dtp1.Value.ToString("dd/MM/yyyy");


                loadform(new LSkehoachsanluong());
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
            
        }

        private void txtMayS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMaLinhKienS.Focus();
            }

            
        }
    }
}
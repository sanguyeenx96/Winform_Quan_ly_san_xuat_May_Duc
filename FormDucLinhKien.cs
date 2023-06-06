using D67.DAO;
using Quanlytinhtrangsanxuat.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D67
{
    public partial class FormDucLinhKien : Form
    {

        public delegate void TRUYENDULIEU(string data1, string data2, string data3, string data4, string data5, string data6, string data7, string data8, string data9, string data10, string data11, string data12, string data13, string data14, string data15, string data17, string data18, string data19, string data20, string data21, string data22, string data23, string data24, string data25, string data26, string data27, string data28, string data29, string data30, string data31, string data32);
        public TRUYENDULIEU truyenData;
        public FormDucLinhKien()
        {
            InitializeComponent();
        }

        string malinhkien;
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

        public string may1;
        public string malinhkien1;
        public DateTime thoidiemdukienbatdausanxuat1;
        public string ngaygionhapdulieu1;
        public string kehoachsanxuat1;
        public float kehoachsanxuatdukien;



        //Tinh toan ke hoach sna xuat theo thoi gian
        public TimeSpan TIMEOFDAYthoidiemdukienbatdausanxuat;
        public float SOGIOthoidiemdukienbatdausanxuat;
        public float SOPHUTthoidiemdukienbatdausanxuat;
        float GIOconlai;
        float PHUTconlai;
        float GIAYtongthoigian;

       


        private void FormDucLinhKien_Load(object sender, EventArgs e)
        {
            txtKeHoachSanXuatDuKien.Text = kehoachsanxuat1.ToString();
            txtThoiDiemDuKienBatDauSanXuat.Text = thoidiemdukienbatdausanxuat1.ToString();
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
            loadsoshotducsq1          = load.Rows[0][69].ToString();
            loadsoshotducsq2          = load.Rows[0][70].ToString();
            loadsoshotducsq3          = load.Rows[0][71].ToString();
            loadsoshotducsq4          = load.Rows[0][72].ToString();
            loadsoshotduccq1          = load.Rows[0][73].ToString();
            loadsoshotduccq2          = load.Rows[0][74].ToString();
            loadsoshotduccq3          = load.Rows[0][75].ToString();
            loadsoshotduccq4          = load.Rows[0][76].ToString();
            loadsanluongthuctesq1     = load.Rows[0][77].ToString();
            loadsanluongthuctesq2     = load.Rows[0][78].ToString();
            loadsanluongthuctesq3     = load.Rows[0][79].ToString();
            loadsanluongthuctesq4     = load.Rows[0][80].ToString();
            loadsanluongthuctecq1     = load.Rows[0][81].ToString();
            loadsanluongthuctecq2     = load.Rows[0][82].ToString();
            loadsanluongthuctecq3     = load.Rows[0][83].ToString();
            loadsanluongthuctecq4     = load.Rows[0][84].ToString();
            loadsoluongfirstshotsq1   = load.Rows[0][85].ToString();
            loadsoluongfirstshotsq2   = load.Rows[0][86].ToString();
            loadsoluongfirstshotsq3   = load.Rows[0][87].ToString();
            loadsoluongfirstshotsq4   = load.Rows[0][88].ToString();
            loadsoluongfirstshotcq1   = load.Rows[0][89].ToString();
            loadsoluongfirstshotcq2   = load.Rows[0][90].ToString();
            loadsoluongfirstshotcq3   = load.Rows[0][91].ToString();
            loadsoluongfirstshotcq4   = load.Rows[0][92].ToString();
            loadsoluongngsq1          = load.Rows[0][93].ToString();
            loadsoluongngsq2          = load.Rows[0][94].ToString();
            loadsoluongngsq3          = load.Rows[0][95].ToString();
            loadsoluongngsq4          = load.Rows[0][96].ToString();
            loadsoluongngcq1          = load.Rows[0][97].ToString();
            loadsoluongngcq2          = load.Rows[0][98].ToString();
            loadsoluongngcq3          = load.Rows[0][99].ToString();
            loadsoluongngcq4          = load.Rows[0][100].ToString();
            loadtilelinhkienoksq1     = load.Rows[0][101].ToString();
            loadtilelinhkienoksq2     = load.Rows[0][102].ToString();
            loadtilelinhkienoksq3     = load.Rows[0][103].ToString();
            loadtilelinhkienoksq4     = load.Rows[0][104].ToString();
            loadtilelinhkienokcq1     = load.Rows[0][105].ToString();
            loadtilelinhkienokcq2     = load.Rows[0][106].ToString();
            loadtilelinhkienokcq3     = load.Rows[0][107].ToString();
            loadtilelinhkienokcq4     = load.Rows[0][108].ToString();
            loadtilehoanthanhkehoachsq1 = load.Rows[0][109].ToString();
            loadtilehoanthanhkehoachsq2 = load.Rows[0][110].ToString();
            loadtilehoanthanhkehoachsq3 = load.Rows[0][111].ToString();
            loadtilehoanthanhkehoachsq4 = load.Rows[0][112].ToString();
            loadtilehoanthanhkehoachcq1 = load.Rows[0][113].ToString();
            loadtilehoanthanhkehoachcq2 = load.Rows[0][114].ToString();
            loadtilehoanthanhkehoachcq3 = load.Rows[0][115].ToString();
            loadtilehoanthanhkehoachcq4 = load.Rows[0][116].ToString();
            txtSoNguoiThaoTacDuKien.Text = loadsonguoithaotacdukien.ToString();
            txtThoiGianSanXuatDuKien.Text = loadthoigiansanxuatdukien.ToString();
            txtThoiDiemDuKienBatDauSanXuat.Text = loadthoidiemdukienbatdausanxuat.ToString();
            txtSanLuongOK.Text = loadsanluongok.ToString();
            txtTongSoLuongFirsrShot.Text = loadsoluongfirstshot.ToString();
            txtSoLuongNG.Text = loadsoluongng.ToString();
            txtTiLeLinhKienOK.Text = loadtilelinhkienok.ToString();
            txtSoNguoiThaoTacThucTe.Text = loadsonguoithaotacthucte.ToString();
            txtThoiGianSanXuatThucTe.Text= loadthoigiansanxuatthucte.ToString();
            txtThoiGianDungMay.Text = loadthoigiandungmay.ToString();
            txtTiLeHoanThanhKeHoach.Text = loadtilehoanthanhkehoach.ToString();
            txtTongSoShotDuc.Text = loadtongsoshotduc.ToString();
            txtKhsxSq1.Text = loadkehoachsanxuatsq1.ToString();
            txtKhsxSq2.Text = loadkehoachsanxuatsq2.ToString();
            txtKhsxSq3.Text = loadkehoachsanxuatsq3.ToString();
            txtKhsxSq4.Text = loadkehoachsanxuatsq4.ToString();
            txtKhsxCq1.Text = loadkehoachsanxuatcq1.ToString();
            txtKhsxCq2.Text = loadkehoachsanxuatcq2.ToString();
            txtKhsxCq3.Text = loadkehoachsanxuatcq3.ToString();
            txtKhsxCq4.Text = loadkehoachsanxuatcq4.ToString();
            txtsoshotducSq1.Text = loadsoshotducsq1.ToString();
            txtsoshotducSq2.Text = loadsoshotducsq2.ToString();
            txtsoshotducSq3.Text = loadsoshotducsq3.ToString();
            txtsoshotducSq4.Text = loadsoshotducsq4.ToString();
            txtsoshotducCq1.Text = loadsoshotduccq1.ToString();
            txtsoshotducCq2.Text = loadsoshotduccq2.ToString();
            txtsoshotducCq3.Text = loadsoshotduccq3.ToString();
            txtsoshotducCq4.Text = loadsoshotduccq4.ToString();
            txtSlttSq1.Text = loadsanluongthuctesq1.ToString();
            txtSlttSq2.Text = loadsanluongthuctesq2.ToString();
            txtSlttSq3.Text = loadsanluongthuctesq3.ToString();
            txtSlttSq4.Text = loadsanluongthuctesq4.ToString();
            txtSlttCq1.Text = loadsanluongthuctecq1.ToString();
            txtSlttCq2.Text = loadsanluongthuctecq2.ToString();
            txtSlttCq3.Text = loadsanluongthuctecq3.ToString();
            txtSlttCq4.Text = loadsanluongthuctecq4.ToString();
            txtsoluongfirstshotSq1.Text = loadsoluongfirstshotsq1.ToString();
            txtsoluongfirstshotSq2.Text = loadsoluongfirstshotsq2.ToString();
            txtsoluongfirstshotSq3.Text = loadsoluongfirstshotsq3.ToString();
            txtsoluongfirstshotSq4.Text = loadsoluongfirstshotsq4.ToString();
            txtsoluongfirstshotCq1.Text = loadsoluongfirstshotcq1.ToString();
            txtsoluongfirstshotCq2.Text = loadsoluongfirstshotcq2.ToString();
            txtsoluongfirstshotCq3.Text = loadsoluongfirstshotcq3.ToString();
            txtsoluongfirstshotCq4.Text = loadsoluongfirstshotcq4.ToString();
            txtsoluongNGSq1.Text = loadsoluongngsq1.ToString();
            txtsoluongNGSq2.Text = loadsoluongngsq2.ToString();
            txtsoluongNGSq3.Text = loadsoluongngsq3.ToString();
            txtsoluongNGSq4.Text = loadsoluongngsq4.ToString();
            txtsoluongNGCq1.Text = loadsoluongngcq1.ToString();
            txtsoluongNGCq2.Text = loadsoluongngcq2.ToString();
            txtsoluongNGCq3.Text = loadsoluongngcq3.ToString();
            txtsoluongNGCq4.Text = loadsoluongngcq4.ToString();
            txtTiLeLinhKienOkSq1.Text = loadtilelinhkienoksq1.ToString();
            txtTiLeLinhKienOkSq2.Text = loadtilelinhkienoksq2.ToString();
            txtTiLeLinhKienOkSq3.Text = loadtilelinhkienoksq3.ToString();
            txtTiLeLinhKienOkSq4.Text = loadtilelinhkienoksq4.ToString();
            txtTiLeLinhKienOkCq1.Text = loadtilelinhkienokcq1.ToString();
            txtTiLeLinhKienOkCq2.Text = loadtilelinhkienokcq2.ToString();
            txtTiLeLinhKienOkCq3.Text = loadtilelinhkienokcq3.ToString();
            txtTiLeLinhKienOkCq4.Text = loadtilelinhkienokcq4.ToString(); 
            txttlhtkhSq1.Text = loadtilehoanthanhkehoachsq1.ToString();
            txttlhtkhSq2.Text = loadtilehoanthanhkehoachsq2.ToString();
            txttlhtkhSq3.Text = loadtilehoanthanhkehoachsq3.ToString();
            txttlhtkhSq4.Text = loadtilehoanthanhkehoachsq4.ToString();
            txttlhtkhCq1.Text = loadtilehoanthanhkehoachcq1.ToString();
            txttlhtkhCq2.Text = loadtilehoanthanhkehoachcq2.ToString();
            txttlhtkhCq3.Text = loadtilehoanthanhkehoachcq3.ToString();
            txttlhtkhCq4.Text = loadtilehoanthanhkehoachcq4.ToString();
            
            //SQ1
            #region SQ1
            if (TIMEOFDAYthoidiemdukienbatdausanxuat >= new TimeSpan(6, 00, 00)        //Hours, Minutes, Seconds
             && TIMEOFDAYthoidiemdukienbatdausanxuat < new TimeSpan(9, 00, 00))
            {
                #region Phần load từ Data
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + malinhkien1 + "'");
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

                txtSoNguoiThaoTacDuKien.Text = songuoithaotac.ToString();
                float kehoachsanxuat2 = (float)Convert.ToDouble(kehoachsanxuat1.ToString());
                txtThoiGianSanXuatDuKien.Text = (((kehoachsanxuat2 / socavity) * cycletime) / 3600).ToString();
                txtMayDuc.Text = may1.ToString();
                #endregion 

                

                GIOconlai = (9 - SOGIOthoidiemdukienbatdausanxuat - 1);
                PHUTconlai = (60 - SOPHUTthoidiemdukienbatdausanxuat);
                GIAYtongthoigian = ((GIOconlai * 60) + PHUTconlai) * 60;
                //MessageBox.Show(GIAYtongthoigian.ToString());
                float GIAYtongthoigiancuaQ = 3 * 3600; 
                float kehoachsanxuatsq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;

                float kehoachsanxuatsq1 = (GIAYtongthoigian / cycletime) * socavity;
                

                //sản xuất hết trong Q1
                if (kehoachsanxuatdukien <= kehoachsanxuatsq1)
                {
                    txtKhsxSq1.Text = ((int)Math.Round(kehoachsanxuatdukien)).ToString();
                    labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;
                }
                //sản xuất hết trong Q2
                if (kehoachsanxuatsq1 < kehoachsanxuatdukien && kehoachsanxuatdukien  <= (kehoachsanxuatsq1 + kehoachsanxuatsq2max))
                {
                    labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    txtKhsxSq1.Text = ((int)Math.Round(kehoachsanxuatsq1)).ToString();
                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq1)).ToString(); 

                }
                //sản xuất hết trong Q3
                if ((kehoachsanxuatsq1 + kehoachsanxuatsq2max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max))
                {
                    labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    txtKhsxSq1.Text = ((int)Math.Round(kehoachsanxuatsq1)).ToString();

                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2max)).ToString(); 
                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq1 - kehoachsanxuatsq2max)).ToString(); 
                }
                //sản xuất hết trong Q4
                if ((kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max + kehoachsanxuatsq4max))
                {
                    labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq1.Text = ((int)Math.Round(kehoachsanxuatsq1)).ToString();

                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq1 - kehoachsanxuatsq2max - kehoachsanxuatsq3max)).ToString();
                }
                //sản xuất hết trong C1
                if ((kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max + kehoachsanxuatsq4max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max))
                {
                    labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;


                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq1.Text = ((int)Math.Round(kehoachsanxuatsq1)).ToString();

                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq1 - kehoachsanxuatsq2max - kehoachsanxuatsq3max - kehoachsanxuatsq4max)).ToString();
                }
                //sản xuất hết trong C2
                if ((kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max +kehoachsanxuatcq2max))
                {
                    labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;



                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq1.Text = ((int)Math.Round(kehoachsanxuatsq1)).ToString();

                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq1 - kehoachsanxuatsq2max - kehoachsanxuatsq3max - kehoachsanxuatsq4max - kehoachsanxuatcq1max)).ToString();
                }
                //sản xuất hết trong C3
                if ((kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max) < kehoachsanxuatdukien && kehoachsanxuatdukien < (kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max))
                {

                    labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    txtKhsxSq1.Text = ((int)Math.Round(kehoachsanxuatsq1)).ToString();

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2max)).ToString();

                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq1 - kehoachsanxuatsq2max - kehoachsanxuatsq3max - kehoachsanxuatsq4max - kehoachsanxuatcq1max - kehoachsanxuatcq2max)).ToString();
                }
                //sản xuất hết trong C4
                if ((kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max) < kehoachsanxuatdukien && kehoachsanxuatdukien < (kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    labelcq4.BackColor = Color.LightGreen;

                    txtKhsxSq1.Text = ((int)Math.Round(kehoachsanxuatsq1)).ToString();

                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2max)).ToString();
                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatcq3max)).ToString();
                    txtKhsxCq4.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq1 - kehoachsanxuatsq2max - kehoachsanxuatsq3max - kehoachsanxuatsq4max - kehoachsanxuatcq1max - kehoachsanxuatcq2max- kehoachsanxuatcq3max)).ToString();
                }
                if (kehoachsanxuatdukien > (kehoachsanxuatsq1 + kehoachsanxuatsq2max + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    MessageBox.Show("Kế hoạch sản xuất dự kiến vượt quá kế hoạch sản xuất trong ngày");
                }
            }
            #endregion
            //SQ2
            #region SQ2
            if (TIMEOFDAYthoidiemdukienbatdausanxuat >= new TimeSpan(9, 00, 00)        //Hours, Minutes, Seconds
             && TIMEOFDAYthoidiemdukienbatdausanxuat < new TimeSpan(12, 00, 00))
            {
                #region Phần load từ Data
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + malinhkien1 + "'");
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

                txtSoNguoiThaoTacDuKien.Text = songuoithaotac.ToString();
                float kehoachsanxuat2 = (float)Convert.ToDouble(kehoachsanxuat1.ToString());
                txtThoiGianSanXuatDuKien.Text = (((kehoachsanxuat2 / socavity) * cycletime) / 3600).ToString();
                txtMayDuc.Text = may1.ToString();
                #endregion



                GIOconlai = (12 - SOGIOthoidiemdukienbatdausanxuat - 1);
                PHUTconlai = (60 - SOPHUTthoidiemdukienbatdausanxuat);
                GIAYtongthoigian = ((GIOconlai * 60) + PHUTconlai) * 60;
                //MessageBox.Show(GIAYtongthoigian.ToString());
                float GIAYtongthoigiancuaQ = 3 * 3600;
                float kehoachsanxuatsq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;

                float kehoachsanxuatsq2 = (GIAYtongthoigian / cycletime) * socavity;
                 

                //sản xuất hết trong Q2
                if (kehoachsanxuatdukien <= kehoachsanxuatsq2)
                {
                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatdukien)).ToString();

                    //labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;
                }
                //sản xuất hết trong Q3
                if (kehoachsanxuatsq2 < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq2 + kehoachsanxuatsq3max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2)).ToString();

                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq2)).ToString();

                }
                //sản xuất hết trong Q4
                if ((kehoachsanxuatsq2 + kehoachsanxuatsq3max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq2 + kehoachsanxuatsq3max + kehoachsanxuatsq4max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2)).ToString();

                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq2 - kehoachsanxuatsq3max)).ToString();
                }
               
                //sản xuất hết trong C1
                if ((kehoachsanxuatsq2 + kehoachsanxuatsq3max + kehoachsanxuatsq4max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= ( kehoachsanxuatsq2 + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2)).ToString();

                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq2 - kehoachsanxuatsq3max - kehoachsanxuatsq4max)).ToString();
                }
                //sản xuất hết trong C2
                if (( kehoachsanxuatsq2 + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq2 + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2)).ToString();

                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq2 - kehoachsanxuatsq3max - kehoachsanxuatsq4max - kehoachsanxuatcq1max)).ToString();
                }
                //sản xuất hết trong C3
                if (( kehoachsanxuatsq2 + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= ( kehoachsanxuatsq2 + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max))
                {

                    //labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2)).ToString();

                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2max)).ToString();

                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq2 - kehoachsanxuatsq3max - kehoachsanxuatsq4max - kehoachsanxuatcq1max - kehoachsanxuatcq2max)).ToString();
                }
                //sản xuất hết trong C4
                if ((kehoachsanxuatsq2 + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max) < kehoachsanxuatdukien && kehoachsanxuatdukien < ( kehoachsanxuatsq2 + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    labelcq4.BackColor = Color.LightGreen;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    txtKhsxSq2.Text = ((int)Math.Round(kehoachsanxuatsq2)).ToString();

                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2max)).ToString();
                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatcq3max)).ToString();
                    txtKhsxCq4.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq2 - kehoachsanxuatsq3max - kehoachsanxuatsq4max - kehoachsanxuatcq1max - kehoachsanxuatcq2max - kehoachsanxuatcq3max)).ToString();
                }
                if (kehoachsanxuatdukien > (kehoachsanxuatsq2 + kehoachsanxuatsq3max + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    MessageBox.Show("Kế hoạch sản xuất dự kiến vượt quá kế hoạch sản xuất trong ngày");
                }
            }
            #endregion
            //SQ3
            #region SQ3
            if (TIMEOFDAYthoidiemdukienbatdausanxuat >= new TimeSpan(12, 00, 00)        //Hours, Minutes, Seconds
             && TIMEOFDAYthoidiemdukienbatdausanxuat < new TimeSpan(15, 00, 00))
            {
                #region Phần load từ Data
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + malinhkien1 + "'");
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

                txtSoNguoiThaoTacDuKien.Text = songuoithaotac.ToString();
                float kehoachsanxuat2 = (float)Convert.ToDouble(kehoachsanxuat1.ToString());
                txtThoiGianSanXuatDuKien.Text = (((kehoachsanxuat2 / socavity) * cycletime) / 3600).ToString();
                txtMayDuc.Text = may1.ToString();
                #endregion



                GIOconlai = (15 - SOGIOthoidiemdukienbatdausanxuat - 1);
                PHUTconlai = (60 - SOPHUTthoidiemdukienbatdausanxuat);
                GIAYtongthoigian = ((GIOconlai * 60) + PHUTconlai) * 60;
                //MessageBox.Show(GIAYtongthoigian.ToString());
                float GIAYtongthoigiancuaQ = 3 * 3600;
                float kehoachsanxuatsq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;

                float kehoachsanxuatsq3 = (GIAYtongthoigian / cycletime) * socavity;

                //sản xuất hết trong Q3
                if (kehoachsanxuatdukien <= kehoachsanxuatsq3)
                {
                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatdukien)).ToString();

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;
                }
                //sản xuất hết trong Q4
                if (kehoachsanxuatsq3 < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq3 + kehoachsanxuatsq4max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3)).ToString();

                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq3)).ToString();
                }
                
                //sản xuất hết trong C1
                if ((kehoachsanxuatsq3 + kehoachsanxuatsq4max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq3 + kehoachsanxuatsq4max + kehoachsanxuatcq1max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3)).ToString();

                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq3 - kehoachsanxuatsq4max)).ToString();
                }
                //sản xuất hết trong C2
                if (( kehoachsanxuatsq3 + kehoachsanxuatsq4max + kehoachsanxuatcq1max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq3 + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;


                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3)).ToString();

                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq3 - kehoachsanxuatsq4max - kehoachsanxuatcq1max)).ToString();
                }
                //sản xuất hết trong C3
                if (( kehoachsanxuatsq3 + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq3 + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max))
                {

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;


                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3)).ToString();

                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2max)).ToString();

                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq3 - kehoachsanxuatsq4max - kehoachsanxuatcq1max - kehoachsanxuatcq2max)).ToString();
                }
                //sản xuất hết trong C4
                if ((kehoachsanxuatsq3 + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq3 + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    labelcq4.BackColor = Color.LightGreen;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;


                    txtKhsxSq3.Text = ((int)Math.Round(kehoachsanxuatsq3)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4max)).ToString();
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2max)).ToString();
                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatcq3max)).ToString();
                    txtKhsxCq4.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq3 - kehoachsanxuatsq4max - kehoachsanxuatcq1max - kehoachsanxuatcq2max - kehoachsanxuatcq3max)).ToString();
                }
                if (kehoachsanxuatdukien > (kehoachsanxuatsq3 + kehoachsanxuatsq4max + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    MessageBox.Show("Kế hoạch sản xuất dự kiến vượt quá kế hoạch sản xuất trong ngày");
                }
            }
            #endregion
            //SQ4
            #region SQ4
            if (TIMEOFDAYthoidiemdukienbatdausanxuat >= new TimeSpan(15, 00, 00)        //Hours, Minutes, Seconds
             && TIMEOFDAYthoidiemdukienbatdausanxuat < new TimeSpan(18, 00, 00))
            {
                #region Phần load từ Data
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + malinhkien1 + "'");
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

                txtSoNguoiThaoTacDuKien.Text = songuoithaotac.ToString();
                float kehoachsanxuat2 = (float)Convert.ToDouble(kehoachsanxuat1.ToString());
                txtThoiGianSanXuatDuKien.Text = (((kehoachsanxuat2 / socavity) * cycletime) / 3600).ToString();
                txtMayDuc.Text = may1.ToString();
                #endregion



                GIOconlai = (18 - SOGIOthoidiemdukienbatdausanxuat - 1);
                PHUTconlai = (60 - SOPHUTthoidiemdukienbatdausanxuat);
                GIAYtongthoigian = ((GIOconlai * 60) + PHUTconlai) * 60;
                //MessageBox.Show(GIAYtongthoigian.ToString());
                float GIAYtongthoigiancuaQ = 3 * 3600;
                float kehoachsanxuatsq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;

                float kehoachsanxuatsq4 = (GIAYtongthoigian / cycletime) * socavity;

                //sản xuất hết trong Q4
                if (kehoachsanxuatdukien <= kehoachsanxuatsq4)
                {
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatdukien)).ToString();

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;
                }
           

                //sản xuất hết trong C1
                if ((kehoachsanxuatsq4) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq4 + kehoachsanxuatcq1max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4)).ToString();

                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq4)).ToString();
                }
                //sản xuất hết trong C2
                if ((kehoachsanxuatsq4 + kehoachsanxuatcq1max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq4 + kehoachsanxuatcq1max + kehoachsanxuatcq2max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;


                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4)).ToString();

                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq4 - kehoachsanxuatcq1max)).ToString();
                }
                //sản xuất hết trong C3
                if ((kehoachsanxuatsq4 + kehoachsanxuatcq1max + kehoachsanxuatcq2max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq4 + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max))
                {

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;

                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4)).ToString();

                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2max)).ToString();

                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq4 - kehoachsanxuatcq1max - kehoachsanxuatcq2max)).ToString();
                }
                //sản xuất hết trong C4
                if ((kehoachsanxuatsq4 + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatsq4 + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    labelcq4.BackColor = Color.LightGreen;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;
                    txtKhsxSq4.Text = ((int)Math.Round(kehoachsanxuatsq4)).ToString();


                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2max)).ToString();
                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatcq3max)).ToString();
                    txtKhsxCq4.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatsq4 - kehoachsanxuatcq1max - kehoachsanxuatcq2max - kehoachsanxuatcq3max)).ToString();
                }
                if (kehoachsanxuatdukien > (kehoachsanxuatsq4 + kehoachsanxuatcq1max + kehoachsanxuatcq2max + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    MessageBox.Show("Kế hoạch sản xuất dự kiến vượt quá kế hoạch sản xuất trong ngày");
                }
            }
            #endregion
            //CQ1
            #region CQ1
            if (TIMEOFDAYthoidiemdukienbatdausanxuat >= new TimeSpan(18, 00, 00)        //Hours, Minutes, Seconds
             && TIMEOFDAYthoidiemdukienbatdausanxuat < new TimeSpan(21, 00, 00))
            {
                #region Phần load từ Data
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + malinhkien1 + "'");
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

                txtSoNguoiThaoTacDuKien.Text = songuoithaotac.ToString();
                float kehoachsanxuat2 = (float)Convert.ToDouble(kehoachsanxuat1.ToString());
                txtThoiGianSanXuatDuKien.Text = (((kehoachsanxuat2 / socavity) * cycletime) / 3600).ToString();
                txtMayDuc.Text = may1.ToString();
                #endregion



                GIOconlai = (21 - SOGIOthoidiemdukienbatdausanxuat - 1);
                PHUTconlai = (60 - SOPHUTthoidiemdukienbatdausanxuat);
                GIAYtongthoigian = ((GIOconlai * 60) + PHUTconlai) * 60;
                //MessageBox.Show(GIAYtongthoigian.ToString());
                float GIAYtongthoigiancuaQ = 3 * 3600;
                float kehoachsanxuatsq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;

                float kehoachsanxuatcq1 = (GIAYtongthoigian / cycletime) * socavity;

                //sản xuất hết trong C1
                if (kehoachsanxuatdukien <= kehoachsanxuatcq1)
                {
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatdukien)).ToString();

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    //////labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;
                }
   
                //sản xuất hết trong C2
                if ((kehoachsanxuatcq1) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatcq1 + kehoachsanxuatcq2max))
                {
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1)).ToString();

                    //labelsq1.BackColor = Color.LightGreen
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;


                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatcq1)).ToString();
                }
                //sản xuất hết trong C3
                if ((kehoachsanxuatcq1 + kehoachsanxuatcq2max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatcq1 + kehoachsanxuatcq2max + kehoachsanxuatcq3max))
                {
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1)).ToString();

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;

                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2max)).ToString();
                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatcq1 - kehoachsanxuatcq2max)).ToString();
                }
                //sản xuất hết trong C4

                if ((kehoachsanxuatcq1 + kehoachsanxuatcq2max + kehoachsanxuatcq3max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatcq1 + kehoachsanxuatcq2max + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    txtKhsxCq1.Text = ((int)Math.Round(kehoachsanxuatcq1)).ToString();

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    labelcq4.BackColor = Color.LightGreen;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2max)).ToString();
                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatcq3max)).ToString();
                    txtKhsxCq4.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatcq1 - kehoachsanxuatcq2max - kehoachsanxuatcq3max)).ToString();
                }
                if (kehoachsanxuatdukien > (kehoachsanxuatcq1 + kehoachsanxuatcq2max + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    MessageBox.Show("Kế hoạch sản xuất dự kiến vượt quá kế hoạch sản xuất trong ngày");
                }
            }
            #endregion
            //CQ2
            #region CQ2
            if (TIMEOFDAYthoidiemdukienbatdausanxuat >= new TimeSpan(21, 00, 00)        //Hours, Minutes, Seconds
             && TIMEOFDAYthoidiemdukienbatdausanxuat < new TimeSpan(24, 00, 00))
            {
                #region Phần load từ Data
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + malinhkien1 + "'");
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

                txtSoNguoiThaoTacDuKien.Text = songuoithaotac.ToString();
                float kehoachsanxuat2 = (float)Convert.ToDouble(kehoachsanxuat1.ToString());
                txtThoiGianSanXuatDuKien.Text = (((kehoachsanxuat2 / socavity) * cycletime) / 3600).ToString();
                txtMayDuc.Text = may1.ToString();
                #endregion



                GIOconlai = (24 - SOGIOthoidiemdukienbatdausanxuat - 1);
                PHUTconlai = (60 - SOPHUTthoidiemdukienbatdausanxuat);
                GIAYtongthoigian = ((GIOconlai * 60) + PHUTconlai) * 60;
                //MessageBox.Show(GIAYtongthoigian.ToString());
                float GIAYtongthoigiancuaQ = 3 * 3600;
                float kehoachsanxuatsq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;

                float kehoachsanxuatcq2 = (GIAYtongthoigian / cycletime) * socavity;

                //sản xuất hết trong C2
                if (kehoachsanxuatdukien <= kehoachsanxuatcq2)
                {
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatdukien)).ToString();

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;
                }

                //sản xuất hết trong C3
                if ((kehoachsanxuatcq2) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatcq2 + kehoachsanxuatcq3max))
                {

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;

                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2)).ToString();

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatcq2)).ToString();
                }
                //sản xuất hết trong C4

                if ((kehoachsanxuatcq2 + kehoachsanxuatcq3max) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatcq2 + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    labelcq4.BackColor = Color.LightGreen;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;
                    txtKhsxCq2.Text = ((int)Math.Round(kehoachsanxuatcq2)).ToString();

                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatcq3max)).ToString();
                    txtKhsxCq4.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatcq2 - kehoachsanxuatcq3max)).ToString();
                }
                if (kehoachsanxuatdukien > (kehoachsanxuatcq2 + kehoachsanxuatcq3max + kehoachsanxuatcq4max))
                {
                    MessageBox.Show("Kế hoạch sản xuất dự kiến vượt quá kế hoạch sản xuất trong ngày");
                }
            }
            #endregion
            //CQ3
            #region CQ3
            if (TIMEOFDAYthoidiemdukienbatdausanxuat >= new TimeSpan(0, 00, 00)        //Hours, Minutes, Seconds
             && TIMEOFDAYthoidiemdukienbatdausanxuat < new TimeSpan(3, 00, 00))
            {
                #region Phần load từ Data
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + malinhkien1 + "'");
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

                txtSoNguoiThaoTacDuKien.Text = songuoithaotac.ToString();
                float kehoachsanxuat2 = (float)Convert.ToDouble(kehoachsanxuat1.ToString());
                txtThoiGianSanXuatDuKien.Text = (((kehoachsanxuat2 / socavity) * cycletime) / 3600).ToString();
                txtMayDuc.Text = may1.ToString();
                #endregion



                GIOconlai = (3 - SOGIOthoidiemdukienbatdausanxuat - 1);
                PHUTconlai = (60 - SOPHUTthoidiemdukienbatdausanxuat);
                GIAYtongthoigian = ((GIOconlai * 60) + PHUTconlai) * 60;
                //MessageBox.Show(GIAYtongthoigian.ToString());
                float GIAYtongthoigiancuaQ = 3 * 3600;
                float kehoachsanxuatsq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;

                float kehoachsanxuatcq3 = (GIAYtongthoigian / cycletime) * socavity;

                //sản xuất hết trong C3
                if (kehoachsanxuatdukien <= kehoachsanxuatcq3)
                {
                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatdukien)).ToString();

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    //labelcq4.BackColor = Color.LightGreen;
                    labelcq4.Enabled = false;
                    label45.Enabled = false;
                    txtKhsxCq4.Enabled = false;
                    txtsoshotducCq4.Enabled = false;
                    txtSlttCq4.Enabled = false;
                    txtsoluongfirstshotCq4.Enabled = false;
                    txtsoluongNGCq4.Enabled = false;
                    txtTiLeLinhKienOkCq4.Enabled = false;
                    txttlhtkhCq4.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;
                }

                //sản xuất hết trong C4
                if ((kehoachsanxuatcq3) < kehoachsanxuatdukien && kehoachsanxuatdukien <= (kehoachsanxuatcq3 + kehoachsanxuatcq4max))
                {

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //labelcq2.BackColor = Color.LightGreen;
                    labelcq3.BackColor = Color.LightGreen;
                    labelcq4.BackColor = Color.LightGreen;


                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;

                    //((int)Math.Round(kehoachsanxuatsq2max)).ToString();
                    txtKhsxCq4.Text = ((int)Math.Round(kehoachsanxuatdukien - kehoachsanxuatcq3)).ToString();
                    txtKhsxCq3.Text = ((int)Math.Round(kehoachsanxuatcq3)).ToString();

                }

                if (kehoachsanxuatdukien > (kehoachsanxuatcq3 + kehoachsanxuatcq4max))
                {
                    MessageBox.Show("Kế hoạch sản xuất dự kiến vượt quá kế hoạch sản xuất trong ngày");
                }
            }
            #endregion
            //CQ4
            #region CQ4
            if (TIMEOFDAYthoidiemdukienbatdausanxuat >= new TimeSpan(3, 00, 00)        //Hours, Minutes, Seconds
             && TIMEOFDAYthoidiemdukienbatdausanxuat < new TimeSpan(6, 00, 00))
            {
                #region Phần load từ Data
                DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE malinhkien='" + malinhkien1 + "'");
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

                txtSoNguoiThaoTacDuKien.Text = songuoithaotac.ToString();
                float kehoachsanxuat2 = (float)Convert.ToDouble(kehoachsanxuat1.ToString());
                txtThoiGianSanXuatDuKien.Text = (((kehoachsanxuat2 / socavity) * cycletime) / 3600).ToString();
                txtMayDuc.Text = may1.ToString();
                #endregion



                GIOconlai = (6 - SOGIOthoidiemdukienbatdausanxuat - 1);
                PHUTconlai = (60 - SOPHUTthoidiemdukienbatdausanxuat);
                GIAYtongthoigian = ((GIOconlai * 60) + PHUTconlai) * 60;
                //MessageBox.Show(GIAYtongthoigian.ToString());
                float GIAYtongthoigiancuaQ = 3 * 3600;
                float kehoachsanxuatsq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatsq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq1max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq2max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq3max = (GIAYtongthoigiancuaQ / cycletime) * socavity;
                float kehoachsanxuatcq4max = (GIAYtongthoigiancuaQ / cycletime) * socavity;

                float kehoachsanxuatcq4 = (GIAYtongthoigian / cycletime) * socavity;

                //sản xuất hết trong C4
                if (kehoachsanxuatdukien <= kehoachsanxuatcq4)
                {
                    txtKhsxCq4.Text = ((int)Math.Round(kehoachsanxuatdukien)).ToString();

                    //labelsq1.BackColor = Color.LightGreen;
                    //labelsq2.BackColor = Color.LightGreen;
                    //labelsq3.BackColor = Color.LightGreen;
                    //labelsq4.BackColor = Color.LightGreen;
                    //labelcq1.BackColor = Color.LightGreen;
                    //labelcq2.BackColor = Color.LightGreen;
                    //labelcq3.BackColor = Color.LightGreen;

                    labelcq4.BackColor = Color.LightGreen;
                    
                    labelcq3.Enabled = false;
                    label44.Enabled = false;
                    txtKhsxCq3.Enabled = false;
                    txtsoshotducCq3.Enabled = false;
                    txtSlttCq3.Enabled = false;
                    txtsoluongfirstshotCq3.Enabled = false;
                    txtsoluongNGCq3.Enabled = false;
                    txtTiLeLinhKienOkCq3.Enabled = false;
                    txttlhtkhCq3.Enabled = false;

                    labelcq2.Enabled = false;
                    label43.Enabled = false;
                    txtKhsxCq2.Enabled = false;
                    txtsoshotducCq2.Enabled = false;
                    txtSlttCq2.Enabled = false;
                    txtsoluongfirstshotCq2.Enabled = false;
                    txtsoluongNGCq2.Enabled = false;
                    txtTiLeLinhKienOkCq2.Enabled = false;
                    txttlhtkhCq2.Enabled = false;

                    labelcq1.Enabled = false;
                    label42.Enabled = false;
                    txtKhsxCq1.Enabled = false;
                    txtsoshotducCq1.Enabled = false;
                    txtSlttCq1.Enabled = false;
                    txtsoluongfirstshotCq1.Enabled = false;
                    txtsoluongNGCq1.Enabled = false;
                    txtTiLeLinhKienOkCq1.Enabled = false;
                    txttlhtkhCq1.Enabled = false;

                    labelsq4.Enabled = false;
                    label41.Enabled = false;
                    txtKhsxSq4.Enabled = false;
                    txtsoshotducSq4.Enabled = false;
                    txtSlttSq4.Enabled = false;
                    txtsoluongfirstshotSq4.Enabled = false;
                    txtsoluongNGSq4.Enabled = false;
                    txtTiLeLinhKienOkSq4.Enabled = false;
                    txttlhtkhSq4.Enabled = false;

                    labelsq3.Enabled = false;
                    label40.Enabled = false;
                    txtKhsxSq3.Enabled = false;
                    txtsoshotducSq3.Enabled = false;
                    txtSlttSq3.Enabled = false;
                    txtsoluongfirstshotSq3.Enabled = false;
                    txtsoluongNGSq3.Enabled = false;
                    txtTiLeLinhKienOkSq3.Enabled = false;
                    txttlhtkhSq3.Enabled = false;

                    labelsq2.Enabled = false;
                    label39.Enabled = false;
                    txtKhsxSq2.Enabled = false;
                    txtsoshotducSq2.Enabled = false;
                    txtSlttSq2.Enabled = false;
                    txtsoluongfirstshotSq2.Enabled = false;
                    txtsoluongNGSq2.Enabled = false;
                    txtTiLeLinhKienOkSq2.Enabled = false;
                    txttlhtkhSq2.Enabled = false;

                    labelsq1.Enabled = false;
                    label38.Enabled = false;
                    txtKhsxSq1.Enabled = false;
                    txtsoshotducSq1.Enabled = false;
                    txtSlttSq1.Enabled = false;
                    txtsoluongfirstshotSq1.Enabled = false;
                    txtsoluongNGSq1.Enabled = false;
                    txtTiLeLinhKienOkSq1.Enabled = false;
                    txttlhtkhSq1.Enabled = false;
                }

                if (kehoachsanxuatdukien > (kehoachsanxuatcq4max))
                {
                    MessageBox.Show("Kế hoạch sản xuất dự kiến vượt quá kế hoạch sản xuất trong ngày");
                }
            }
            #endregion

        }


        private void txtSoNguoiThaoTacThucTe_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtSoNguoiThaoTacThucTe.Text != ""))
            {
                //float sanluongok = (float)Convert.ToDouble(txtSanLuongOK.Text.ToString());
                //float tongsoluongfirstshot = (float)Convert.ToDouble(txtTongSoLuongFirsrShot.Text.ToString());
                //txtTiLeLinhKienOK.Text = ((sanluongok / (tongsoshotduc - tongsoluongfirstshot)) * 100).ToString();
                txtThoiGianSanXuatThucTe.Focus();
            }
        }
        private void txtThoiGianSanXuatThucTe_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtThoiGianSanXuatThucTe.Text != ""))
            {
                //thoigiansanxuatthucte = (float)Convert.ToDouble(txtThoiGianSanXuatThucTe.Text.ToString());
                txtThoiGianDungMay.Focus();
            }
        }

        private void txtThoiGianDungMay_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtThoiGianDungMay.Text != ""))
            {
                //sanluongok = (float)Convert.ToDouble(txtSanLuongOK.Text.ToString());
                //float kehoachsanxuat1 = (float)Convert.ToDouble(kehoachsanxuat);
                //txtTiLeHoanThanhKeHoach.Text = ((sanluongok / kehoachsanxuat1) * 100).ToString();
                txtTongSoShotDuc.Focus();
            }
        }
       
     


        private void txtSoNguoiThaoTacThucTe_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtThoiGianDungMay_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtThoiGianSanXuatThucTe_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtTongSoShotDuc_KeyPress(object sender, KeyPressEventArgs e)
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
        //    if (txtThoiGianSanXuatDuKien.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtThoiGianSanXuatDuKien.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }

        //    if (txtSanLuongDucDuKien.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtSanLuongDucDuKien.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }
        //    if (txtThoiDiemDuKienBatDauSanXuat.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtThoiDiemDuKienBatDauSanXuat.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }

        //    if (txtSoLuongNG.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        txtSoLuongNG.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }

        //    if (txtSoLanDungMay.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        txtSoLanDungMay.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }
        //    if (txtSoNguoiThaoTacThucTe.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        txtSoNguoiThaoTacThucTe.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }
        //    if (txtThoiGianSanXuatThucTe.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        txtThoiGianSanXuatThucTe.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }
        //    if (txtSanLuongDucThucTe.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        txtSanLuongDucThucTe.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }
        //    if (txtThoiGianDungMay.Text == "")
        //    {
        //        MessageBox.Show("Chưa điền đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        txtThoiGianDungMay.Focus(); //Đưa con trỏ về ô thiếu dữ liệu để cần nhập.
        //        return false; //dừng lại.
        //    }
        //    return true; //tiếp tục thực thi chương trình.
        //}


        float sanluongthuctesq1;
        float sanluongthuctesq2;
        float sanluongthuctesq3;
        float sanluongthuctesq4;
        float sanluongthuctecq1;
        float sanluongthuctecq2;
        float sanluongthuctecq3;
        float sanluongthuctecq4;
        private void txtSlttSq1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtSlttSq1.Text != ""))
            {
               

                sanluongthuctesq1 = (float)Convert.ToDouble(txtSlttSq1.Text.ToString());
                txtSanLuongOK.Text = (sanluongthuctesq1 + sanluongthuctesq2 + sanluongthuctesq3 + sanluongthuctesq4 + sanluongthuctecq1 + sanluongthuctecq2 + sanluongthuctecq3 + sanluongthuctecq4).ToString();

                float kehoachsanxuatsq1 = (float)Convert.ToDouble(txtKhsxSq1.Text.ToString());
                txttlhtkhSq1.Text = ((sanluongthuctesq1 / kehoachsanxuatsq1) * 100).ToString();

                txtsoluongfirstshotSq1.Focus();
            }
        }

        private void txtSlttSq2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtSlttSq2.Text != ""))
            {
                sanluongthuctesq2 = (float)Convert.ToDouble(txtSlttSq2.Text.ToString());
                txtSanLuongOK.Text = (sanluongthuctesq1 + sanluongthuctesq2 + sanluongthuctesq3 + sanluongthuctesq4 + sanluongthuctecq1 + sanluongthuctecq2 + sanluongthuctecq3 + sanluongthuctecq4).ToString();

                float kehoachsanxuatsq2 = (float)Convert.ToDouble(txtKhsxSq2.Text.ToString());
                txttlhtkhSq2.Text = ((sanluongthuctesq2 / kehoachsanxuatsq2) * 100).ToString(); 
                txtsoluongfirstshotSq2.Focus();
            }
        }

        private void txtSlttSq3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtSlttSq3.Text != ""))
            {
                sanluongthuctesq3 = (float)Convert.ToDouble(txtSlttSq3.Text.ToString());
                txtSanLuongOK.Text = (sanluongthuctesq1 + sanluongthuctesq2 + sanluongthuctesq3 + sanluongthuctesq4 + sanluongthuctecq1 + sanluongthuctecq2 + sanluongthuctecq3 + sanluongthuctecq4).ToString();
                float kehoachsanxuatsq3 = (float)Convert.ToDouble(txtKhsxSq3.Text.ToString());
                txttlhtkhSq3.Text = ((sanluongthuctesq3 / kehoachsanxuatsq3) *100).ToString(); 
                txtsoluongfirstshotSq3.Focus();
            }
        }

        private void txtSlttSq4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtSlttSq4.Text != ""))
            {
                sanluongthuctesq4 = (float)Convert.ToDouble(txtSlttSq4.Text.ToString());
                txtSanLuongOK.Text = (sanluongthuctesq1 + sanluongthuctesq2 + sanluongthuctesq3 + sanluongthuctesq4 + sanluongthuctecq1 + sanluongthuctecq2 + sanluongthuctecq3 + sanluongthuctecq4).ToString();

                float kehoachsanxuatsq4 = (float)Convert.ToDouble(txtKhsxSq4.Text.ToString());
                txttlhtkhSq4.Text = ((sanluongthuctesq4 / kehoachsanxuatsq4) * 100).ToString();

                txtsoluongfirstshotSq4.Focus();
            }
        }

        private void txtSlttCq1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtSlttCq1.Text != ""))
            {
                sanluongthuctecq1 = (float)Convert.ToDouble(txtSlttCq1.Text.ToString());
                txtSanLuongOK.Text = (sanluongthuctesq1 + sanluongthuctesq2 + sanluongthuctesq3 + sanluongthuctesq4 + sanluongthuctecq1 + sanluongthuctecq2 + sanluongthuctecq3 + sanluongthuctecq4).ToString();

                float kehoachsanxuatcq1 = (float)Convert.ToDouble(txtKhsxCq1.Text.ToString());
                txttlhtkhCq1.Text = ((sanluongthuctecq1 / kehoachsanxuatcq1) * 100).ToString();

                txtsoluongfirstshotCq1.Focus();
            }
        }

        private void txtSlttCq2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtSlttCq2.Text != ""))
            {
                sanluongthuctecq2 = (float)Convert.ToDouble(txtSlttCq2.Text.ToString());
                txtSanLuongOK.Text = (sanluongthuctesq1 + sanluongthuctesq2 + sanluongthuctesq3 + sanluongthuctesq4 + sanluongthuctecq1 + sanluongthuctecq2 + sanluongthuctecq3 + sanluongthuctecq4).ToString();

                float kehoachsanxuatcq2 = (float)Convert.ToDouble(txtKhsxCq2.Text.ToString());
                txttlhtkhCq2.Text = ((sanluongthuctecq2 / kehoachsanxuatcq2) * 100).ToString();

                txtsoluongfirstshotCq2.Focus();

            }
        }

        private void txtSlttCq3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtSlttCq3.Text != ""))
            {
                sanluongthuctecq3 = (float)Convert.ToDouble(txtSlttCq3.Text.ToString());
                txtSanLuongOK.Text = (sanluongthuctesq1 + sanluongthuctesq2 + sanluongthuctesq3 + sanluongthuctesq4 + sanluongthuctecq1 + sanluongthuctecq2 + sanluongthuctecq3 + sanluongthuctecq4).ToString();

                float kehoachsanxuatcq3 = (float)Convert.ToDouble(txtKhsxCq3.Text.ToString());
                txttlhtkhCq3.Text = ((sanluongthuctecq3 / kehoachsanxuatcq3) * 100).ToString();

                txtsoluongfirstshotCq3.Focus();

            }
        }

        private void txtSlttCq4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtSlttCq4.Text != ""))
            {
                sanluongthuctecq4 = (float)Convert.ToDouble(txtSlttCq4.Text.ToString());
                txtSanLuongOK.Text = (sanluongthuctesq1 + sanluongthuctesq2 + sanluongthuctesq3 + sanluongthuctesq4 + sanluongthuctecq1 + sanluongthuctecq2 + sanluongthuctecq3 + sanluongthuctecq4).ToString();

                float kehoachsanxuatcq4 = (float)Convert.ToDouble(txtKhsxCq4.Text.ToString());
                txttlhtkhCq4.Text = ((sanluongthuctecq4 / kehoachsanxuatcq4) * 100).ToString();

                txtsoluongfirstshotCq4.Focus();
            }
        }

        float soluongfirstshotsq1;
        float soluongfirstshotsq2;
        float soluongfirstshotsq3;
        float soluongfirstshotsq4;
        float soluongfirstshotcq1;
        float soluongfirstshotcq2;
        float soluongfirstshotcq3;
        float soluongfirstshotcq4;

        private void txtsoluongfirstshotSq1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongfirstshotSq1.Text != ""))
            {
                soluongfirstshotsq1 = (float)Convert.ToDouble(txtsoluongfirstshotSq1.Text.ToString());
                txtTongSoLuongFirsrShot.Text = (soluongfirstshotsq1 + soluongfirstshotsq2 + soluongfirstshotsq3 + soluongfirstshotsq4 + soluongfirstshotcq1 + soluongfirstshotcq2 + soluongfirstshotcq3 + soluongfirstshotcq4).ToString();
                txtsoluongNGSq1.Focus();
            }
        }

        private void txtsoluongfirstshotSq2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongfirstshotSq2.Text != ""))
            {
                soluongfirstshotsq2 = (float)Convert.ToDouble(txtsoluongfirstshotSq2.Text.ToString());
                txtTongSoLuongFirsrShot.Text = (soluongfirstshotsq1 + soluongfirstshotsq2 + soluongfirstshotsq3 + soluongfirstshotsq4 + soluongfirstshotcq1 + soluongfirstshotcq2 + soluongfirstshotcq3 + soluongfirstshotcq4).ToString();
                txtsoluongNGSq2.Focus();

            }
        }

        private void txtsoluongfirstshotSq3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongfirstshotSq3.Text != ""))
            {
                soluongfirstshotsq3 = (float)Convert.ToDouble(txtsoluongfirstshotSq3.Text.ToString());
                txtTongSoLuongFirsrShot.Text = (soluongfirstshotsq1 + soluongfirstshotsq2 + soluongfirstshotsq3 + soluongfirstshotsq4 + soluongfirstshotcq1 + soluongfirstshotcq2 + soluongfirstshotcq3 + soluongfirstshotcq4).ToString();
                txtsoluongNGSq3.Focus();

            }
        }

        private void txtsoluongfirstshotSq4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongfirstshotSq4.Text != ""))
            {
                soluongfirstshotsq4 = (float)Convert.ToDouble(txtsoluongfirstshotSq4.Text.ToString());
                txtTongSoLuongFirsrShot.Text = (soluongfirstshotsq1 + soluongfirstshotsq2 + soluongfirstshotsq3 + soluongfirstshotsq4 + soluongfirstshotcq1 + soluongfirstshotcq2 + soluongfirstshotcq3 + soluongfirstshotcq4).ToString();
                txtsoluongNGSq4.Focus();

            }
        }

        private void txtsoluongfirstshotCq1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongfirstshotCq1.Text != ""))
            {
                soluongfirstshotcq1 = (float)Convert.ToDouble(txtsoluongfirstshotCq1.Text.ToString());
                txtTongSoLuongFirsrShot.Text = (soluongfirstshotsq1 + soluongfirstshotsq2 + soluongfirstshotsq3 + soluongfirstshotsq4 + soluongfirstshotcq1 + soluongfirstshotcq2 + soluongfirstshotcq3 + soluongfirstshotcq4).ToString();
                txtsoluongNGCq1.Focus();

            }
        }

        private void txtsoluongfirstshotCq2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongfirstshotCq2.Text != ""))
            {
                soluongfirstshotcq2 = (float)Convert.ToDouble(txtsoluongfirstshotCq2.Text.ToString());
                txtTongSoLuongFirsrShot.Text = (soluongfirstshotsq1 + soluongfirstshotsq2 + soluongfirstshotsq3 + soluongfirstshotsq4 + soluongfirstshotcq1 + soluongfirstshotcq2 + soluongfirstshotcq3 + soluongfirstshotcq4).ToString();
                txtsoluongNGCq2.Focus();

            }
        }

        private void txtsoluongfirstshotCq3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongfirstshotCq3.Text != ""))
            {
                soluongfirstshotcq3 = (float)Convert.ToDouble(txtsoluongfirstshotCq3.Text.ToString());
                txtTongSoLuongFirsrShot.Text = (soluongfirstshotsq1 + soluongfirstshotsq2 + soluongfirstshotsq3 + soluongfirstshotsq4 + soluongfirstshotcq1 + soluongfirstshotcq2 + soluongfirstshotcq3 + soluongfirstshotcq4).ToString();
                txtsoluongNGCq3.Focus();

            }
        }

        private void txtsoluongfirstshotCq4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongfirstshotCq4.Text != ""))
            {
                soluongfirstshotcq4 = (float)Convert.ToDouble(txtsoluongfirstshotCq4.Text.ToString());
                txtTongSoLuongFirsrShot.Text = (soluongfirstshotsq1 + soluongfirstshotsq2 + soluongfirstshotsq3 + soluongfirstshotsq4 + soluongfirstshotcq1 + soluongfirstshotcq2 + soluongfirstshotcq3 + soluongfirstshotcq4).ToString();
                txtsoluongNGCq4.Focus();

            }
        }

        float soluongngsq1;
        float soluongngsq2;
        float soluongngsq3;
        float soluongngsq4;
        float soluongngcq1;
        float soluongngcq2;
        float soluongngcq3;
        float soluongngcq4;

        float sanluongok2;
        float soluongng2;

        private void txtsoluongNGSq1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongNGSq1.Text != ""))
            {
                soluongngsq1 = (float)Convert.ToDouble(txtsoluongNGSq1.Text.ToString());
                txtSoLuongNG.Text = (soluongngsq1 + soluongngsq2 + soluongngsq3 + soluongngsq4 + soluongngcq1 + soluongngcq2 + soluongngcq3 + soluongngcq4).ToString();

                sanluongok2 = (float)Convert.ToDouble(txtSanLuongOK.Text.ToString());
                soluongng2 = (float)Convert.ToDouble(txtSoLuongNG.Text.ToString());

                txtTiLeLinhKienOK.Text = ((sanluongok2 / (sanluongok2 + soluongng2))*100).ToString();

                sanluongthuctesq1 = (float)Convert.ToDouble(txtSlttSq1.Text.ToString());
                txtTiLeLinhKienOkSq1.Text = ((sanluongthuctesq1 / (sanluongthuctesq1 + soluongngsq1)) * 100).ToString();

                txtTiLeHoanThanhKeHoach.Text = ((sanluongok2 / kehoachsanxuatdukien) * 100).ToString();


                if (((sanluongthuctesq1 + soluongfirstshotsq1 + soluongngsq1)/socavity) <= tongsoshotducsq1)
                {
                    txtsoshotducSq2.Focus();

                }
                else
                {
                    MessageBox.Show("Thông tin số lượng không trùng khớp!");
                }
            }
        }

        private void txtsoluongNGSq2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongNGSq2.Text != ""))
            {
                soluongngsq2 = (float)Convert.ToDouble(txtsoluongNGSq2.Text.ToString());
                txtSoLuongNG.Text = (soluongngsq1 + soluongngsq2 + soluongngsq3 + soluongngsq4 + soluongngcq1 + soluongngcq2 + soluongngcq3 + soluongngcq4).ToString();

                sanluongok2 = (float)Convert.ToDouble(txtSanLuongOK.Text.ToString());
                soluongng2 = (float)Convert.ToDouble(txtSoLuongNG.Text.ToString());

                txtTiLeLinhKienOK.Text = ((sanluongok2 / (sanluongok2 + soluongng2)) * 100).ToString();

                sanluongthuctesq2 = (float)Convert.ToDouble(txtSlttSq2.Text.ToString());
                txtTiLeLinhKienOkSq2.Text = ((sanluongthuctesq2 / (sanluongthuctesq2 + soluongngsq2)) * 100).ToString();

                txtTiLeHoanThanhKeHoach.Text = ((sanluongok2 / kehoachsanxuatdukien) * 100).ToString();


                if (((sanluongthuctesq2 + soluongfirstshotsq2 + soluongngsq2) / socavity) <= tongsoshotducsq2)
                {
                    txtsoshotducSq3.Focus();

                }
                else
                {
                    MessageBox.Show("Thông tin số lượng không trùng khớp!");
                }
            }
        }

        private void txtsoluongNGSq3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongNGSq3.Text != ""))
            {
                soluongngsq3 = (float)Convert.ToDouble(txtsoluongNGSq3.Text.ToString());
                txtSoLuongNG.Text = (soluongngsq1 + soluongngsq2 + soluongngsq3 + soluongngsq4 + soluongngcq1 + soluongngcq2 + soluongngcq3 + soluongngcq4).ToString();

                sanluongok2 = (float)Convert.ToDouble(txtSanLuongOK.Text.ToString());
                soluongng2 = (float)Convert.ToDouble(txtSoLuongNG.Text.ToString());

                txtTiLeLinhKienOK.Text = ((sanluongok2 / (sanluongok2 + soluongng2)) * 100).ToString();


                sanluongthuctesq3 = (float)Convert.ToDouble(txtSlttSq3.Text.ToString());
                txtTiLeLinhKienOkSq3.Text = ((sanluongthuctesq3 / (sanluongthuctesq3 + soluongngsq3)) * 100).ToString();

                txtTiLeHoanThanhKeHoach.Text = ((sanluongok2 / kehoachsanxuatdukien) * 100).ToString();


                if (((sanluongthuctesq3 + soluongfirstshotsq3 + soluongngsq3) / socavity) <= tongsoshotducsq3)
                {
                    txtsoshotducSq4.Focus();
                }
                else
                {
                    MessageBox.Show("Thông tin số lượng không trùng khớp!");
                }
            }
        }

        private void txtsoluongNGSq4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongNGSq4.Text != ""))
            {
                soluongngsq4 = (float)Convert.ToDouble(txtsoluongNGSq4.Text.ToString());
                txtSoLuongNG.Text = (soluongngsq1 + soluongngsq2 + soluongngsq3 + soluongngsq4 + soluongngcq1 + soluongngcq2 + soluongngcq3 + soluongngcq4).ToString();

                sanluongok2 = (float)Convert.ToDouble(txtSanLuongOK.Text.ToString());
                soluongng2 = (float)Convert.ToDouble(txtSoLuongNG.Text.ToString());

                txtTiLeLinhKienOK.Text = ((sanluongok2 / (sanluongok2 + soluongng2)) * 100).ToString();


                sanluongthuctesq4 = (float)Convert.ToDouble(txtSlttSq4.Text.ToString());
                txtTiLeLinhKienOkSq4.Text = ((sanluongthuctesq4 / (sanluongthuctesq4 + soluongngsq4)) * 100).ToString();

                txtTiLeHoanThanhKeHoach.Text = ((sanluongok2 / kehoachsanxuatdukien) * 100).ToString();


                if (((sanluongthuctesq4 + soluongfirstshotsq4 + soluongngsq4) / socavity) <= tongsoshotducsq4)
                {
                    txtsoshotducCq1.Focus();
                }
                else
                {
                    MessageBox.Show("Thông tin số lượng không trùng khớp!");
                }

            }
        }

        private void txtsoluongNGCq1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongNGCq1.Text != ""))
            {
                soluongngcq1 = (float)Convert.ToDouble(txtsoluongNGCq1.Text.ToString());
                txtSoLuongNG.Text = (soluongngsq1 + soluongngsq2 + soluongngsq3 + soluongngsq4 + soluongngcq1 + soluongngcq2 + soluongngcq3 + soluongngcq4).ToString();

                sanluongok2 = (float)Convert.ToDouble(txtSanLuongOK.Text.ToString());
                soluongng2 = (float)Convert.ToDouble(txtSoLuongNG.Text.ToString());

                txtTiLeLinhKienOK.Text = ((sanluongok2 / (sanluongok2 + soluongng2)) * 100).ToString();


                sanluongthuctecq1 = (float)Convert.ToDouble(txtSlttCq1.Text.ToString());
                txtTiLeLinhKienOkCq1.Text = ((sanluongthuctecq1 / (sanluongthuctecq1 + soluongngcq1)) * 100).ToString();

                txtTiLeHoanThanhKeHoach.Text = ((sanluongok2 / kehoachsanxuatdukien) * 100).ToString();


                if (((sanluongthuctecq1 + soluongfirstshotcq1 + soluongngcq1) / socavity) <= tongsoshotduccq1)
                {
                    txtsoshotducCq2.Focus();
                }
                else
                {
                    MessageBox.Show("Thông tin số lượng không trùng khớp!");
                }

            }
        }

        private void txtsoluongNGCq2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongNGCq2.Text != ""))
            {
                soluongngcq2 = (float)Convert.ToDouble(txtsoluongNGCq2.Text.ToString());
                txtSoLuongNG.Text = (soluongngsq1 + soluongngsq2 + soluongngsq3 + soluongngsq4 + soluongngcq1 + soluongngcq2 + soluongngcq3 + soluongngcq4).ToString();

                sanluongok2 = (float)Convert.ToDouble(txtSanLuongOK.Text.ToString());
                soluongng2 = (float)Convert.ToDouble(txtSoLuongNG.Text.ToString());

                txtTiLeLinhKienOK.Text = ((sanluongok2 / (sanluongok2 + soluongng2)) * 100).ToString();

                sanluongthuctecq2 = (float)Convert.ToDouble(txtSlttCq2.Text.ToString());
                txtTiLeLinhKienOkCq2.Text = ((sanluongthuctecq2 / (sanluongthuctecq2 + soluongngcq2)) * 100).ToString();

                txtTiLeHoanThanhKeHoach.Text = ((sanluongok2 / kehoachsanxuatdukien) * 100).ToString();


                if (((sanluongthuctecq2 + soluongfirstshotcq2 + soluongngcq2) / socavity) <= tongsoshotduccq2)
                {
                    txtsoshotducCq3.Focus();
                }
                else
                {
                    MessageBox.Show("Thông tin số lượng không trùng khớp!");
                }

            }
        }

        private void txtsoluongNGCq3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongNGCq3.Text != ""))
            {
                soluongngcq3 = (float)Convert.ToDouble(txtsoluongNGCq3.Text.ToString());
                txtSoLuongNG.Text = (soluongngsq1 + soluongngsq2 + soluongngsq3 + soluongngsq4 + soluongngcq1 + soluongngcq2 + soluongngcq3 + soluongngcq4).ToString();

                sanluongok2 = (float)Convert.ToDouble(txtSanLuongOK.Text.ToString());
                soluongng2 = (float)Convert.ToDouble(txtSoLuongNG.Text.ToString());

                txtTiLeLinhKienOK.Text = ((sanluongok2 / (sanluongok2 + soluongng2)) * 100).ToString();

                sanluongthuctecq3 = (float)Convert.ToDouble(txtSlttCq3.Text.ToString());
                txtTiLeLinhKienOkCq3.Text = ((sanluongthuctecq3 / (sanluongthuctecq3 + soluongngcq3)) * 100).ToString();

                txtTiLeHoanThanhKeHoach.Text = ((sanluongok2 / kehoachsanxuatdukien) * 100).ToString();


                if (((sanluongthuctecq3 + soluongfirstshotcq3 + soluongngcq3) / socavity) <= tongsoshotduccq3)
                {
                    txtsoshotducCq4.Focus();
                }
                else
                {
                    MessageBox.Show("Thông tin số lượng không trùng khớp!");
                }

            }
        }

        private void txtsoluongNGCq4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoluongNGCq4.Text != ""))
            {
                soluongngcq4 = (float)Convert.ToDouble(txtsoluongNGCq4.Text.ToString());
                txtSoLuongNG.Text = (soluongngsq1 + soluongngsq2 + soluongngsq3 + soluongngsq4 + soluongngcq1 + soluongngcq2 + soluongngcq3 + soluongngcq4).ToString();

                sanluongok2 = (float)Convert.ToDouble(txtSanLuongOK.Text.ToString());
                soluongng2 = (float)Convert.ToDouble(txtSoLuongNG.Text.ToString());

                txtTiLeLinhKienOK.Text = ((sanluongok2 / (sanluongok2 + soluongng2)) * 100).ToString();
                sanluongthuctecq4 = (float)Convert.ToDouble(txtSlttCq4.Text.ToString());
                txtTiLeLinhKienOkCq4.Text = ((sanluongthuctecq4 / (sanluongthuctecq4 + soluongngcq4)) * 100).ToString();

                txtTiLeHoanThanhKeHoach.Text = ((sanluongok2 / kehoachsanxuatdukien) * 100).ToString();


                if (((sanluongthuctecq4 + soluongfirstshotcq4 + soluongngcq4) / socavity) <= tongsoshotduccq4)
                {
                }
                else
                {
                    MessageBox.Show("Thông tin số lượng không trùng khớp!");
                }
            }
        }

        float tongsoshotducsq1;
        float tongsoshotducsq2;
        float tongsoshotducsq3;
        float tongsoshotducsq4;
        float tongsoshotduccq1;
        float tongsoshotduccq2;
        float tongsoshotduccq3;
        float tongsoshotduccq4;

        private void txtsoshotducSq1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoshotducSq1.Text != ""))
            {
                tongsoshotducsq1 = (float)Convert.ToDouble(txtsoshotducSq1.Text.ToString());
                txtTongSoShotDuc.Text = (tongsoshotducsq1 + tongsoshotducsq2 + tongsoshotducsq3 + tongsoshotducsq4 + tongsoshotduccq1 + tongsoshotduccq2 + tongsoshotduccq3 + tongsoshotduccq4).ToString();
                txtSlttSq1.Focus();

            }
        }

        private void txtsoshotducSq2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoshotducSq2.Text != ""))
            {
                tongsoshotducsq2 = (float)Convert.ToDouble(txtsoshotducSq2.Text.ToString());
                txtTongSoShotDuc.Text = (tongsoshotducsq1 + tongsoshotducsq2 + tongsoshotducsq3 + tongsoshotducsq4 + tongsoshotduccq1 + tongsoshotduccq2 + tongsoshotduccq3 + tongsoshotduccq4).ToString();
                txtSlttSq2.Focus();
            }
        }

        private void txtsoshotducSq3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoshotducSq3.Text != ""))
            {
                tongsoshotducsq3 = (float)Convert.ToDouble(txtsoshotducSq3.Text.ToString());
                txtTongSoShotDuc.Text = (tongsoshotducsq1 + tongsoshotducsq2 + tongsoshotducsq3 + tongsoshotducsq4 + tongsoshotduccq1 + tongsoshotduccq2 + tongsoshotduccq3 + tongsoshotduccq4).ToString();
                txtSlttSq3.Focus();
            }
        }

        private void txtsoshotducSq4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoshotducSq4.Text != ""))
            {
                tongsoshotducsq4 = (float)Convert.ToDouble(txtsoshotducSq4.Text.ToString());
                txtTongSoShotDuc.Text = (tongsoshotducsq1 + tongsoshotducsq2 + tongsoshotducsq3 + tongsoshotducsq4 + tongsoshotduccq1 + tongsoshotduccq2 + tongsoshotduccq3 + tongsoshotduccq4).ToString();
                txtSlttSq4.Focus();
            }
        }

        private void txtsoshotducCq1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoshotducCq1.Text != ""))
            {
                tongsoshotduccq1 = (float)Convert.ToDouble(txtsoshotducCq1.Text.ToString());
                txtTongSoShotDuc.Text = (tongsoshotducsq1 + tongsoshotducsq2 + tongsoshotducsq3 + tongsoshotducsq4 + tongsoshotduccq1 + tongsoshotduccq2 + tongsoshotduccq3 + tongsoshotduccq4).ToString();
                txtSlttCq1.Focus();
            }
        }

        private void txtsoshotducCq2_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoshotducCq2.Text != ""))
            {
                tongsoshotduccq2 = (float)Convert.ToDouble(txtsoshotducCq2.Text.ToString());
                txtTongSoShotDuc.Text = (tongsoshotducsq1 + tongsoshotducsq2 + tongsoshotducsq3 + tongsoshotducsq4 + tongsoshotduccq1 + tongsoshotduccq2 + tongsoshotduccq3 + tongsoshotduccq4).ToString();
                txtSlttCq2.Focus();
            }
        }

        private void txtsoshotducCq3_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoshotducCq3.Text != ""))
            {
                tongsoshotduccq3 = (float)Convert.ToDouble(txtsoshotducCq3.Text.ToString());
                txtTongSoShotDuc.Text = (tongsoshotducsq1 + tongsoshotducsq2 + tongsoshotducsq3 + tongsoshotducsq4 + tongsoshotduccq1 + tongsoshotduccq2 + tongsoshotduccq3 + tongsoshotduccq4).ToString();
                txtSlttCq3.Focus();
            }
        }

        private void txtsoshotducCq4_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (txtsoshotducCq4.Text != ""))
            {
                tongsoshotduccq4 = (float)Convert.ToDouble(txtsoshotducCq4.Text.ToString());
                txtTongSoShotDuc.Text = (tongsoshotducsq1 + tongsoshotducsq2 + tongsoshotducsq3 + tongsoshotducsq4 + tongsoshotduccq1 + tongsoshotduccq2 + tongsoshotduccq3 + tongsoshotduccq4).ToString();
                txtSlttCq4.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string songuoithaotacdukien = txtSoNguoiThaoTacDuKien.Text;
            string songuoithaotacthucte = txtSoNguoiThaoTacThucTe.Text;
            string thoigiansanxuatdukien = txtThoiGianSanXuatDuKien.Text;
            string thoigiansanxuatthucte = txtThoiGianSanXuatThucTe.Text;
            string thoidiemthuctebatdausanxuat = dateTimePicker1.Value.ToString("dd/MM/yyyy hh:mm tt");
            string sanluongok = txtSanLuongOK.Text;
            string soluongfirstshot = txtTongSoLuongFirsrShot.Text;
            string soluongng = txtSoLuongNG.Text;
            string tilelinhkienok = txtTiLeLinhKienOK.Text;
            string thoigiandungmay = txtThoiGianDungMay.Text;
            string tilehoanthanhkehoach = txtTiLeHoanThanhKeHoach.Text;
            string tongsoshotduc = txtTongSoShotDuc.Text;
            string kehoachsanxuatsq1 = txtKhsxSq1.Text;
            string kehoachsanxuatsq2 = txtKhsxSq2.Text;
            string kehoachsanxuatsq3 = txtKhsxSq3.Text;
            string kehoachsanxuatsq4 = txtKhsxSq4.Text;
            string kehoachsanxuatcq1 = txtKhsxCq1.Text;
            string kehoachsanxuatcq2 = txtKhsxCq2.Text;
            string kehoachsanxuatcq3 = txtKhsxCq3.Text;
            string kehoachsanxuatcq4 = txtKhsxCq4.Text;
            string soshotducsq1 = txtsoshotducSq1.Text;
            string soshotducsq2 = txtsoshotducSq2.Text;
            string soshotducsq3 = txtsoshotducSq3.Text;
            string soshotducsq4 = txtsoshotducSq4.Text;
            string soshotduccq1 = txtsoshotducCq1.Text;
            string soshotduccq2 = txtsoshotducCq2.Text;
            string soshotduccq3 = txtsoshotducCq3.Text;
            string soshotduccq4 = txtsoshotducCq4.Text;
            string sanluongthuctesq1 = txtSlttSq1.Text;
            string sanluongthuctesq2 = txtSlttSq2.Text;
            string sanluongthuctesq3 = txtSlttSq3.Text;
            string sanluongthuctesq4 = txtSlttSq4.Text;
            string sanluongthuctecq1 = txtSlttCq1.Text;
            string sanluongthuctecq2 = txtSlttCq2.Text;
            string sanluongthuctecq3 = txtSlttCq3.Text;
            string sanluongthuctecq4 = txtSlttCq4.Text;
            string soluongfirstshotsq1 = txtsoluongfirstshotSq1.Text;
            string soluongfirstshotsq2 = txtsoluongfirstshotSq2.Text;
            string soluongfirstshotsq3 = txtsoluongfirstshotSq3.Text;
            string soluongfirstshotsq4 = txtsoluongfirstshotSq4.Text;
            string soluongfirstshotcq1 = txtsoluongfirstshotCq1.Text;
            string soluongfirstshotcq2 = txtsoluongfirstshotCq2.Text;
            string soluongfirstshotcq3 = txtsoluongfirstshotCq3.Text;
            string soluongfirstshotcq4 = txtsoluongfirstshotCq4.Text;
            string soluongngsq1 = txtsoluongNGSq1.Text;
            string soluongngsq2 = txtsoluongNGSq2.Text;
            string soluongngsq3 = txtsoluongNGSq3.Text;
            string soluongngsq4 = txtsoluongNGSq4.Text;
            string soluongngcq1 = txtsoluongNGCq1.Text;
            string soluongngcq2 = txtsoluongNGCq2.Text;
            string soluongngcq3 = txtsoluongNGCq3.Text;
            string soluongngcq4 = txtsoluongNGCq4.Text;
            string tilelinhkienoksq1 = txtTiLeLinhKienOkSq1.Text;
            string tilelinhkienoksq2 = txtTiLeLinhKienOkSq2.Text;
            string tilelinhkienoksq3 = txtTiLeLinhKienOkSq3.Text;
            string tilelinhkienoksq4 = txtTiLeLinhKienOkSq4.Text;
            string tilelinhkienokcq1 = txtTiLeLinhKienOkCq1.Text;
            string tilelinhkienokcq2 = txtTiLeLinhKienOkCq2.Text;
            string tilelinhkienokcq3 = txtTiLeLinhKienOkCq3.Text;
            string tilelinhkienokcq4 = txtTiLeLinhKienOkCq4.Text;
            string tilehoanthanhkehoachsq1 = txttlhtkhSq1.Text;
            string tilehoanthanhkehoachsq2 = txttlhtkhSq2.Text;
            string tilehoanthanhkehoachsq3 = txttlhtkhSq3.Text;
            string tilehoanthanhkehoachsq4 = txttlhtkhSq4.Text;
            string tilehoanthanhkehoachcq1 = txttlhtkhCq1.Text;
            string tilehoanthanhkehoachcq2 = txttlhtkhCq2.Text;
            string tilehoanthanhkehoachcq3 = txttlhtkhCq3.Text;
            string tilehoanthanhkehoachcq4 = txttlhtkhCq4.Text;

            QuanlytinhtrangsanxuatDAO.Instance.insertduclinhkien(may1, malinhkien1, kehoachsanxuat1, ngaygionhapdulieu1, songuoithaotacdukien, songuoithaotacthucte, thoigiansanxuatdukien, thoigiansanxuatthucte, thoidiemthuctebatdausanxuat, sanluongok, soluongfirstshot, soluongng, tilelinhkienok, thoigiandungmay, tilehoanthanhkehoach, tongsoshotduc, kehoachsanxuatsq1, kehoachsanxuatsq2, kehoachsanxuatsq3, kehoachsanxuatsq4, kehoachsanxuatcq1, kehoachsanxuatcq2, kehoachsanxuatcq3, kehoachsanxuatcq4, soshotducsq1, soshotducsq2, soshotducsq3, soshotducsq4, soshotduccq1, soshotduccq2, soshotduccq3, soshotduccq4, sanluongthuctesq1, sanluongthuctesq2, sanluongthuctesq3, sanluongthuctesq4, sanluongthuctecq1, sanluongthuctecq2, sanluongthuctecq3, sanluongthuctecq4, soluongfirstshotsq1, soluongfirstshotsq2, soluongfirstshotsq3, soluongfirstshotsq4, soluongfirstshotcq1, soluongfirstshotcq2, soluongfirstshotcq3, soluongfirstshotcq4, soluongngsq1, soluongngsq2, soluongngsq3, soluongngsq4, soluongngcq1, soluongngcq2, soluongngcq3, soluongngcq4, tilelinhkienoksq1, tilelinhkienoksq2, tilelinhkienoksq3, tilelinhkienoksq4, tilelinhkienokcq1, tilelinhkienokcq2, tilelinhkienokcq3, tilelinhkienokcq4, tilehoanthanhkehoachsq1, tilehoanthanhkehoachsq2, tilehoanthanhkehoachsq3, tilehoanthanhkehoachsq4, tilehoanthanhkehoachcq1, tilehoanthanhkehoachcq2, tilehoanthanhkehoachcq3, tilehoanthanhkehoachcq4);
                this.Close();
        }

        private void txtSlttSq1_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);
        }

        private void txtSlttSq2_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);
        }

        private void txtSlttSq3_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtSlttSq4_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtSlttCq1_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtSlttCq2_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtSlttCq3_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtSlttCq4_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtTongSoShotDuc_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtSanLuongOK_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtSoLuongNG_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtTiLeLinhKienOK_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtThoiGianSanXuatThucTe_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtThoiGianDungMay_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }

        private void txtSoNguoiThaoTacThucTe_TextChanged(object sender, EventArgs e)
        {
            if (truyenData != null)
                truyenData(txtSlttSq1.Text, txtSlttSq2.Text, txtSlttSq3.Text, txtSlttSq4.Text, txtSlttCq1.Text, txtSlttCq2.Text, txtSlttCq3.Text, txtSlttCq4.Text, txtTongSoShotDuc.Text, txtSanLuongOK.Text, txtSoLuongNG.Text, txtTiLeLinhKienOK.Text, txtThoiGianSanXuatThucTe.Text, txtThoiGianDungMay.Text, txtSoNguoiThaoTacThucTe.Text, txtKhsxSq1.Text, txtKhsxSq2.Text, txtKhsxSq3.Text, txtKhsxSq4.Text, txtKhsxCq1.Text, txtKhsxCq2.Text, txtKhsxCq3.Text, txtKhsxCq4.Text, txttlhtkhSq1.Text, txttlhtkhSq2.Text, txttlhtkhSq3.Text, txttlhtkhSq4.Text, txttlhtkhCq1.Text, txttlhtkhCq2.Text, txttlhtkhCq3.Text, txttlhtkhCq4.Text);

        }
    }
}

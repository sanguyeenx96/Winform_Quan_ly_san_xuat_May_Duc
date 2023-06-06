﻿using D67.DAO;
using Quanlytinhtrangsanxuat.DAO;
using QuanLyTinhTrangSanXuat.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quanlytinhtrangsanxuat.DAO
{
    public class QuanlytinhtrangsanxuatDAO
    {
        private static QuanlytinhtrangsanxuatDAO instance;

        public static QuanlytinhtrangsanxuatDAO Instance
        {
            get { if (instance == null) instance = new QuanlytinhtrangsanxuatDAO(); return QuanlytinhtrangsanxuatDAO.instance; }
            private set { QuanlytinhtrangsanxuatDAO.instance = value; }
        }
        private QuanlytinhtrangsanxuatDAO() { }

        public bool checkmalinhkien(string malinhkien)
        {
            string query = string.Format("SELECT COUNT(*) FROM dbo.Data WHERE malinhkien='" + malinhkien + "'");
            int result = (int)DataProvider.Instance.ExecuteScalar(query);
            if (result == 0)
            {
                MessageBox.Show("Mã linh kiện bạn nhập chưa có trong cơ sở dữ liệu!");
            }
            return (result > 0);

        }
        public bool insertlichsu(string ngaygionhapdulieu, string may, string malinhkien, string tenlinhkien, string trongluongsanpham, string trongluongrunner, string kehoachsanxuat, string thoidiemdukienbatdausanxuat, string tongsoshotduc, string tongtrongluong1pcs, string cycletimeduc, string thoigianvesinhmaysaytieuchuan, string thoigianvesinhmaysaythucte, string tennguyenlieudukiensudung, string tennguyenlieuthuctesudung, string capdonguyenlieudukiensudung, string capdonguyenlieuthuctesudung, string mamaunguyenlieudukiensudung, string mamaunguyenlieuthuctesudung, string nhietdosay, string nhietdosaythucte, string thoigiansay, string thoigiansaythucte, string tilenhuanghientrenfile, string tilenhuanghienthucte, string luongnhuatinhcandungdukien, string luongnhuatinhcandungthucte, string luongnhuanghiencandungdukien, string luongnhuanghiencandungthucte, string thoidiemdukienbatdauvesinhmaysay, string thoidiemthuctebatdauvesinhmaysay, string thoidiemdukienbatdausaynhua, string thoidiemthuctebatdausaynhua, string khuoncanhadukien, string khuoncanhathucte, string khuoncanupdukien, string khuoncanupthucte, string thoigianthaykhuondukien, string thoigianthaykhuonthucte, string thoigianchaymaydukien, string thoigianchaymaythucte, string thoigianlennhietdukien, string thoigianlennhietthucte, string thoidiemdukienbatdaulenkhuon, string thoidiemthuctebatdaulenkhuon, string songuoithaotacdukien, string songuoithaotacthucte, string thoigiansanxuatdukien, string thoigiansanxuatthucte, string sanluongducdukien, string sanluongducthucte, string thoidiemthuctebatdausanxuat, string sanluongok, string soluongfirstshot, string soluongng, string tilelinhkienok, string solandungmay, string thoigiandungmay, string tilehoatdongmay, string tilehoanthanhkehoach, string kehoachsanxuatsq1, string kehoachsanxuatsq2, string kehoachsanxuatsq3, string kehoachsanxuatsq4, string kehoachsanxuatcq1, string kehoachsanxuatcq2, string kehoachsanxuatcq3, string kehoachsanxuatcq4, string soshotducsq1, string soshotducsq2, string soshotducsq3, string soshotducsq4, string soshotduccq1, string soshotduccq2, string soshotduccq3, string soshotduccq4, string sanluongthuctesq1, string sanluongthuctesq2, string sanluongthuctesq3, string sanluongthuctesq4, string sanluongthuctecq1, string sanluongthuctecq2, string sanluongthuctecq3, string sanluongthuctecq4, string soluongfirstshotsq1, string soluongfirstshotsq2, string soluongfirstshotsq3, string soluongfirstshotsq4, string soluongfirstshotcq1, string soluongfirstshotcq2, string soluongfirstshotcq3, string soluongfirstshotcq4, string soluongngsq1, string soluongngsq2, string soluongngsq3, string soluongngsq4, string soluongngcq1, string soluongngcq2, string soluongngcq3, string soluongngcq4, string tilelinhkienoksq1, string tilelinhkienoksq2, string tilelinhkienoksq3, string tilelinhkienoksq4, string tilelinhkienokcq1, string tilelinhkienokcq2, string tilelinhkienokcq3, string tilelinhkienokcq4, string tilehoanthanhkehoachsq1, string tilehoanthanhkehoachsq2, string tilehoanthanhkehoachsq3, string tilehoanthanhkehoachsq4, string tilehoanthanhkehoachcq1, string tilehoanthanhkehoachcq2, string tilehoanthanhkehoachcq3, string tilehoanthanhkehoachcq4)
        {
            string query = string.Format("INSERT INTO [dbo].[Lichsu] (ngaygionhapdulieu,   may,   malinhkien,   tenlinhkien,   trongluongsanpham,   trongluongrunner,   kehoachsanxuat,   thoidiemdukienbatdausanxuat,   tongsoshotduc,   tongtrongluong1pcs,   cycletimeduc,   thoigianvesinhmaysaytieuchuan,   thoigianvesinhmaysaythucte,   tennguyenlieudukiensudung,   tennguyenlieuthuctesudung,   capdonguyenlieudukiensudung,   capdonguyenlieuthuctesudung,   mamaunguyenlieudukiensudung,   mamaunguyenlieuthuctesudung,   nhietdosay,   nhietdosaythucte,   thoigiansay,   thoigiansaythucte,   tilenhuanghientrenfile,   tilenhuanghienthucte,   luongnhuatinhcandungdukien,   luongnhuatinhcandungthucte,   luongnhuanghiencandungdukien,   luongnhuanghiencandungthucte,   thoidiemdukienbatdauvesinhmaysay,   thoidiemthuctebatdauvesinhmaysay,   thoidiemdukienbatdausaynhua,   thoidiemthuctebatdausaynhua,   khuoncanhadukien,   khuoncanhathucte,   khuoncanupdukien,   khuoncanupthucte,   thoigianthaykhuondukien,   thoigianthaykhuonthucte,   thoigianchaymaydukien,   thoigianchaymaythucte,   thoigianlennhietdukien,   thoigianlennhietthucte,   thoidiemdukienbatdaulenkhuon,   thoidiemthuctebatdaulenkhuon,   songuoithaotacdukien,   songuoithaotacthucte,   thoigiansanxuatdukien,   thoigiansanxuatthucte,   sanluongducdukien,   sanluongducthucte,   thoidiemthuctebatdausanxuat,   sanluongok,   soluongfirstshot,   soluongng,   tilelinhkienok,   solandungmay,   thoigiandungmay,   tilehoatdongmay,   tilehoanthanhkehoach,   kehoachsanxuatsq1,   kehoachsanxuatsq2,   kehoachsanxuatsq3,   kehoachsanxuatsq4,   kehoachsanxuatcq1,   kehoachsanxuatcq2,   kehoachsanxuatcq3,   kehoachsanxuatcq4,   soshotducsq1,   soshotducsq2,   soshotducsq3,   soshotducsq4,   soshotduccq1,   soshotduccq2,   soshotduccq3,   soshotduccq4,   sanluongthuctesq1,   sanluongthuctesq2,   sanluongthuctesq3,   sanluongthuctesq4,   sanluongthuctecq1,   sanluongthuctecq2,   sanluongthuctecq3,   sanluongthuctecq4,   soluongfirstshotsq1,   soluongfirstshotsq2,   soluongfirstshotsq3,   soluongfirstshotsq4,   soluongfirstshotcq1,   soluongfirstshotcq2,   soluongfirstshotcq3,   soluongfirstshotcq4,   soluongngsq1,   soluongngsq2,   soluongngsq3,   soluongngsq4,   soluongngcq1,   soluongngcq2,   soluongngcq3,   soluongngcq4,   tilelinhkienoksq1,   tilelinhkienoksq2,   tilelinhkienoksq3,   tilelinhkienoksq4,   tilelinhkienokcq1,   tilelinhkienokcq2,   tilelinhkienokcq3,   tilelinhkienokcq4,   tilehoanthanhkehoachsq1,   tilehoanthanhkehoachsq2,   tilehoanthanhkehoachsq3,   tilehoanthanhkehoachsq4,   tilehoanthanhkehoachcq1,   tilehoanthanhkehoachcq2,   tilehoanthanhkehoachcq3,   tilehoanthanhkehoachcq4) VALUES (N'{0}',N'{1}',N'{2}', N'{3}',N'{4}', N'{5}', N'{6}', N'{7}',N'{8}', N'{9}',N'{10}', N'{11}',N'{12}', N'{13}',N'{14}',N'{15}',N'{16}',N'{17}',N'{18}',N'{19}',N'{20}',N'{21}',N'{22}',N'{23}',N'{24}',N'{25}',N'{26}',N'{27}',N'{28}',N'{29}',N'{30}',N'{31}',N'{32}',N'{33}',N'{34}',N'{35}',N'{36}',N'{37}',N'{38}',N'{39}',N'{40}',N'{41}',N'{42}',N'{43}',N'{44}',N'{45}',N'{46}',N'{47}',N'{48}',N'{49}',N'{50}',N'{51}',N'{52}',N'{53}',N'{54}',N'{55}',N'{56}',N'{57}',N'{58}',N'{59}',N'{60}',N'{61}',N'{62}',N'{63}',N'{64}',N'{65}',N'{66}',N'{67}',N'{68}',N'{69}',N'{70}',N'{71}',N'{72}',N'{73}',N'{74}',N'{75}',N'{76}',N'{77}',N'{78}',N'{79}',N'{80}',N'{81}',N'{82}',N'{83}',N'{84}',N'{85}',N'{86}',N'{87}',N'{88}',N'{89}',N'{90}',N'{91}',N'{92}',N'{93}',N'{94}',N'{95}',N'{96}',N'{97}',N'{98}',N'{99}',N'{100}',N'{101}',N'{102}',N'{103}',N'{104}',N'{105}',N'{106}',N'{107}',N'{108}',N'{109}',N'{110}',N'{111}',N'{112}',N'{113}',N'{114}',N'{115}')", ngaygionhapdulieu, may, malinhkien, tenlinhkien, trongluongsanpham, trongluongrunner, kehoachsanxuat, thoidiemdukienbatdausanxuat, tongsoshotduc, tongtrongluong1pcs, cycletimeduc, thoigianvesinhmaysaytieuchuan, thoigianvesinhmaysaythucte, tennguyenlieudukiensudung, tennguyenlieuthuctesudung, capdonguyenlieudukiensudung, capdonguyenlieuthuctesudung, mamaunguyenlieudukiensudung, mamaunguyenlieuthuctesudung, nhietdosay, nhietdosaythucte, thoigiansay, thoigiansaythucte, tilenhuanghientrenfile, tilenhuanghienthucte, luongnhuatinhcandungdukien, luongnhuatinhcandungthucte, luongnhuanghiencandungdukien, luongnhuanghiencandungthucte, thoidiemdukienbatdauvesinhmaysay, thoidiemthuctebatdauvesinhmaysay, thoidiemdukienbatdausaynhua, thoidiemthuctebatdausaynhua, khuoncanhadukien, khuoncanhathucte, khuoncanupdukien, khuoncanupthucte, thoigianthaykhuondukien, thoigianthaykhuonthucte, thoigianchaymaydukien, thoigianchaymaythucte, thoigianlennhietdukien, thoigianlennhietthucte, thoidiemdukienbatdaulenkhuon, thoidiemthuctebatdaulenkhuon, songuoithaotacdukien, songuoithaotacthucte, thoigiansanxuatdukien, thoigiansanxuatthucte, sanluongducdukien, sanluongducthucte, thoidiemthuctebatdausanxuat, sanluongok, soluongfirstshot, soluongng, tilelinhkienok, solandungmay, thoigiandungmay, tilehoatdongmay, tilehoanthanhkehoach, kehoachsanxuatsq1, kehoachsanxuatsq2, kehoachsanxuatsq3, kehoachsanxuatsq4, kehoachsanxuatcq1, kehoachsanxuatcq2, kehoachsanxuatcq3, kehoachsanxuatcq4, soshotducsq1, soshotducsq2, soshotducsq3, soshotducsq4, soshotduccq1, soshotduccq2, soshotduccq3, soshotduccq4, sanluongthuctesq1, sanluongthuctesq2, sanluongthuctesq3, sanluongthuctesq4, sanluongthuctecq1, sanluongthuctecq2, sanluongthuctecq3, sanluongthuctecq4, soluongfirstshotsq1, soluongfirstshotsq2, soluongfirstshotsq3, soluongfirstshotsq4, soluongfirstshotcq1, soluongfirstshotcq2, soluongfirstshotcq3, soluongfirstshotcq4, soluongngsq1, soluongngsq2, soluongngsq3, soluongngsq4, soluongngcq1, soluongngcq2, soluongngcq3, soluongngcq4, tilelinhkienoksq1, tilelinhkienoksq2, tilelinhkienoksq3, tilelinhkienoksq4, tilelinhkienokcq1, tilelinhkienokcq2, tilelinhkienokcq3, tilelinhkienokcq4, tilehoanthanhkehoachsq1, tilehoanthanhkehoachsq2, tilehoanthanhkehoachsq3, tilehoanthanhkehoachsq4, tilehoanthanhkehoachcq1, tilehoanthanhkehoachcq2, tilehoanthanhkehoachcq3, tilehoanthanhkehoachcq4);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool insertchuanbinhua(string malinhkien, string ngaygionhapdulieu, string thoigianvesinhmaysaytieuchuan, string tennguyenlieudukiensudung, string capdonguyenlieudukiensudung, string mamaunguyenlieudukiensudung, string nhietdosay, string thoigiansay, string tilenhuanghientrenfile, string luongnhuatinhcandungdukien, string luongnhuanghiencandungdukien, string thoigianvesinhmaysaythucte, string tennguyenlieuthuctesudung, string capdonguyenlieuthuctesudung, string mamaunguyenlieuthuctesudung, string nhietdosaythucte, string thoigiansaythucte, string tilenhuanghienthucte, string luongnhuatinhcandungthucte, string luongnhuanghiencandungthucte, string thoidiemdukienbatdauvesinhmaysay, string thoidiemthuctebatdauvesinhmaysay, string thoidiemdukienbatdausaynhua, string thoidiemthuctebatdausaynhua, string may)
        {
            string query = string.Format("update [dbo].[Lichsu] set thoigianvesinhmaysaytieuchuan=N'{2}', tennguyenlieudukiensudung=N'{3}',capdonguyenlieudukiensudung=N'{4}',mamaunguyenlieudukiensudung=N'{5}',nhietdosay=N'{6}',thoigiansay=N'{7}',tilenhuanghientrenfile=N'{8}',luongnhuatinhcandungdukien=N'{9}',luongnhuanghiencandungdukien=N'{10}',thoigianvesinhmaysaythucte=N'{11}',tennguyenlieuthuctesudung=N'{12}',capdonguyenlieuthuctesudung=N'{13}',mamaunguyenlieuthuctesudung=N'{14}',nhietdosaythucte=N'{15}',thoigiansaythucte=N'{16}',tilenhuanghienthucte=N'{17}',luongnhuatinhcandungthucte=N'{18}',luongnhuanghiencandungthucte=N'{19}',thoidiemdukienbatdauvesinhmaysay=N'{20}',thoidiemthuctebatdauvesinhmaysay=N'{21}',thoidiemdukienbatdausaynhua=N'{22}',thoidiemthuctebatdausaynhua=N'{23}' WHERE malinhkien =N'{0}'and ngaygionhapdulieu=N'{1}' and may=N'{24}'", malinhkien, ngaygionhapdulieu,   thoigianvesinhmaysaytieuchuan,   tennguyenlieudukiensudung,   capdonguyenlieudukiensudung,   mamaunguyenlieudukiensudung,   nhietdosay,   thoigiansay,   tilenhuanghientrenfile,   luongnhuatinhcandungdukien,   luongnhuanghiencandungdukien,   thoigianvesinhmaysaythucte,   tennguyenlieuthuctesudung,   capdonguyenlieuthuctesudung,   mamaunguyenlieuthuctesudung,   nhietdosaythucte,   thoigiansaythucte,   tilenhuanghienthucte,   luongnhuatinhcandungthucte,   luongnhuanghiencandungthucte,   thoidiemdukienbatdauvesinhmaysay,   thoidiemthuctebatdauvesinhmaysay,   thoidiemdukienbatdausaynhua,   thoidiemthuctebatdausaynhua, may);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool insertchuanbiduclinhkien(string may ,string malinhkien, string kehoachsanxuat, string ngaygionhapdulieu, string khuoncanhadukien, string khuoncanhathucte, string khuoncanupdukien, string khuoncanupthucte, string thoigianthaykhuondukien, string thoigianthaykhuonthucte, string thoigianchaymaydukien, string thoigianchaymaythucte, string thoigianlennhietdukien, string thoigianlennhietthucte, string thoidiemdukienbatdaulenkhuon, string thoidiemthuctebatdaulenkhuon)
        {
            string query = string.Format("update [dbo].[Lichsu] set khuoncanhadukien=N'{4}', khuoncanhathucte=N'{5}',khuoncanupdukien=N'{6}',khuoncanupthucte=N'{7}',thoigianthaykhuondukien=N'{8}',thoigianthaykhuonthucte=N'{9}',thoigianchaymaydukien=N'{10}',thoigianchaymaythucte=N'{11}',thoigianlennhietdukien=N'{12}',thoigianlennhietthucte=N'{13}',thoidiemdukienbatdaulenkhuon=N'{14}',thoidiemthuctebatdaulenkhuon=N'{15}' WHERE may =N'{0}'and malinhkien =N'{1}'and kehoachsanxuat =N'{2}'and ngaygionhapdulieu=N'{3}'", may,  malinhkien, ngaygionhapdulieu,  kehoachsanxuat,  khuoncanhadukien,  khuoncanhathucte,  khuoncanupdukien,  khuoncanupthucte,  thoigianthaykhuondukien,  thoigianthaykhuonthucte,  thoigianchaymaydukien,  thoigianchaymaythucte,  thoigianlennhietdukien,  thoigianlennhietthucte,  thoidiemdukienbatdaulenkhuon,  thoidiemthuctebatdaulenkhuon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool insertduclinhkien(string may, string malinhkien, string kehoachsanxuat, string ngaygionhapdulieu, string songuoithaotacdukien, string songuoithaotacthucte,string thoigiansanxuatdukien, string thoigiansanxuatthucte, string thoidiemthuctebatdausanxuat, string sanluongok, string soluongfirstshot, string soluongng, string tilelinhkienok, string thoigiandungmay,string tilehoanthanhkehoach, string tongsoshotduc,string kehoachsanxuatsq1,string kehoachsanxuatsq2,string kehoachsanxuatsq3,string kehoachsanxuatsq4, string kehoachsanxuatcq1,string kehoachsanxuatcq2,string kehoachsanxuatcq3,string kehoachsanxuatcq4, string soshotducsq1, string soshotducsq2, string soshotducsq3, string soshotducsq4, string soshotduccq1, string soshotduccq2, string soshotduccq3,string soshotduccq4,string sanluongthuctesq1,string sanluongthuctesq2,string sanluongthuctesq3,string sanluongthuctesq4,string sanluongthuctecq1,string sanluongthuctecq2,string sanluongthuctecq3,string sanluongthuctecq4,string soluongfirstshotsq1,string soluongfirstshotsq2,string soluongfirstshotsq3,string soluongfirstshotsq4,string soluongfirstshotcq1,string soluongfirstshotcq2,string soluongfirstshotcq3,string soluongfirstshotcq4, string soluongngsq1,string soluongngsq2,string soluongngsq3,string soluongngsq4, string soluongngcq1,string soluongngcq2,string soluongngcq3,string soluongngcq4,string tilelinhkienoksq1,string tilelinhkienoksq2,string tilelinhkienoksq3, string tilelinhkienoksq4, string tilelinhkienokcq1, string tilelinhkienokcq2, string tilelinhkienokcq3, string tilelinhkienokcq4, string tilehoanthanhkehoachsq1,string tilehoanthanhkehoachsq2,string tilehoanthanhkehoachsq3,string tilehoanthanhkehoachsq4,string tilehoanthanhkehoachcq1,string tilehoanthanhkehoachcq2, string tilehoanthanhkehoachcq3, string tilehoanthanhkehoachcq4)
        {
            string query = string.Format("update [dbo].[Lichsu] set  songuoithaotacdukien=N'{4}',   songuoithaotacthucte=N'{5}',  thoigiansanxuatdukien=N'{6}',   thoigiansanxuatthucte=N'{7}',   thoidiemthuctebatdausanxuat=N'{8}',   sanluongok=N'{9}',   soluongfirstshot=N'{10}',   soluongng=N'{11}',   tilelinhkienok=N'{12}',   thoigiandungmay=N'{13}',  tilehoanthanhkehoach=N'{14}',   tongsoshotduc=N'{15}',  kehoachsanxuatsq1=N'{16}',  kehoachsanxuatsq2=N'{17}',  kehoachsanxuatsq3=N'{18}',  kehoachsanxuatsq4=N'{19}',   kehoachsanxuatcq1=N'{20}',  kehoachsanxuatcq2=N'{21}',  kehoachsanxuatcq3=N'{22}',  kehoachsanxuatcq4=N'{23}',   soshotducsq1=N'{24}',   soshotducsq2=N'{25}',   soshotducsq3=N'{26}',   soshotducsq4=N'{27}',   soshotduccq1=N'{28}',   soshotduccq2=N'{29}',   soshotduccq3=N'{30}',  soshotduccq4=N'{31}',  sanluongthuctesq1=N'{32}',  sanluongthuctesq2=N'{33}',  sanluongthuctesq3=N'{34}',  sanluongthuctesq4=N'{35}',  sanluongthuctecq1=N'{36}',  sanluongthuctecq2=N'{37}',  sanluongthuctecq3=N'{38}',  sanluongthuctecq4=N'{39}',  soluongfirstshotsq1=N'{40}',  soluongfirstshotsq2=N'{41}',  soluongfirstshotsq3=N'{42}',  soluongfirstshotsq4=N'{43}',  soluongfirstshotcq1=N'{44}',  soluongfirstshotcq2=N'{45}',  soluongfirstshotcq3=N'{46}',  soluongfirstshotcq4=N'{47}',   soluongngsq1=N'{48}',  soluongngsq2=N'{49}',  soluongngsq3=N'{50}',  soluongngsq4=N'{51}',   soluongngcq1=N'{52}',  soluongngcq2=N'{53}',  soluongngcq3=N'{54}',  soluongngcq4=N'{55}',  tilelinhkienoksq1=N'{56}',  tilelinhkienoksq2=N'{57}',  tilelinhkienoksq3=N'{58}',   tilelinhkienoksq4=N'{59}',   tilelinhkienokcq1=N'{60}',   tilelinhkienokcq2=N'{61}',   tilelinhkienokcq3=N'{62}',   tilelinhkienokcq4=N'{63}',   tilehoanthanhkehoachsq1=N'{64}',  tilehoanthanhkehoachsq2=N'{65}',  tilehoanthanhkehoachsq3=N'{66}',  tilehoanthanhkehoachsq4=N'{67}',  tilehoanthanhkehoachcq1=N'{68}',  tilehoanthanhkehoachcq2=N'{69}',   tilehoanthanhkehoachcq3=N'{70}',   tilehoanthanhkehoachcq4=N'{71}' WHERE may =N'{0}'and malinhkien =N'{1}'and kehoachsanxuat =N'{2}'and ngaygionhapdulieu=N'{3}'", may, malinhkien, kehoachsanxuat, ngaygionhapdulieu, songuoithaotacdukien, songuoithaotacthucte, thoigiansanxuatdukien, thoigiansanxuatthucte, thoidiemthuctebatdausanxuat, sanluongok, soluongfirstshot, soluongng, tilelinhkienok, thoigiandungmay, tilehoanthanhkehoach, tongsoshotduc, kehoachsanxuatsq1, kehoachsanxuatsq2, kehoachsanxuatsq3, kehoachsanxuatsq4, kehoachsanxuatcq1, kehoachsanxuatcq2, kehoachsanxuatcq3, kehoachsanxuatcq4, soshotducsq1, soshotducsq2, soshotducsq3, soshotducsq4, soshotduccq1, soshotduccq2, soshotduccq3, soshotduccq4, sanluongthuctesq1, sanluongthuctesq2, sanluongthuctesq3, sanluongthuctesq4, sanluongthuctecq1, sanluongthuctecq2, sanluongthuctecq3, sanluongthuctecq4, soluongfirstshotsq1, soluongfirstshotsq2, soluongfirstshotsq3, soluongfirstshotsq4, soluongfirstshotcq1, soluongfirstshotcq2, soluongfirstshotcq3, soluongfirstshotcq4, soluongngsq1, soluongngsq2, soluongngsq3, soluongngsq4, soluongngcq1, soluongngcq2, soluongngcq3, soluongngcq4, tilelinhkienoksq1, tilelinhkienoksq2, tilelinhkienoksq3, tilelinhkienoksq4, tilelinhkienokcq1, tilelinhkienokcq2, tilelinhkienokcq3, tilelinhkienokcq4, tilehoanthanhkehoachsq1, tilehoanthanhkehoachsq2, tilehoanthanhkehoachsq3, tilehoanthanhkehoachsq4, tilehoanthanhkehoachcq1, tilehoanthanhkehoachcq2, tilehoanthanhkehoachcq3, tilehoanthanhkehoachcq4);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        //public bool insertfinal(string may, string malinhkien, string kehoachsanxuat, string ngaygionhapdulieu, string kehoachsanxuatsq1, string kehoachsanxuatsq2, string kehoachsanxuatsq3, string kehoachsanxuatsq4, string kehoachsanxuatcq1, string kehoachsanxuatcq2, string kehoachsanxuatcq3, string kehoachsanxuatcq4, string sanluongthuctesq1, string sanluongthuctesq2, string sanluongthuctesq3, string sanluongthuctesq4, string sanluongthuctecq1, string sanluongthuctecq2, string sanluongthuctecq3,string sanluongthuctecq4,string tilehoanthanhkehoachsq1,string tilehoanthanhkehoachsq2,string tilehoanthanhkehoachsq3,string tilehoanthanhkehoachsq4,string tilehoanthanhkehoachcq1,string tilehoanthanhkehoachcq2,string tilehoanthanhkehoachcq3,string tilehoanthanhkehoachcq4)
        //{
        //    string query = string.Format("update [dbo].[Lichsu] set kehoachsanxuatsq1=N'{4}', kehoachsanxuatsq2=N'{5}',kehoachsanxuatsq3=N'{6}',kehoachsanxuatsq4=N'{7}',kehoachsanxuatcq1=N'{8}',kehoachsanxuatcq2=N'{9}',kehoachsanxuatcq3=N'{10}',kehoachsanxuatcq4=N'{11}',sanluongthuctesq1=N'{12}',sanluongthuctesq2=N'{13}',sanluongthuctesq3=N'{14}',sanluongthuctesq4=N'{15}',sanluongthuctecq1=N'{16}',sanluongthuctecq2=N'{17}',sanluongthuctecq3=N'{18}',sanluongthuctecq4=N'{19}',tilehoanthanhkehoachsq1=N'{20}',tilehoanthanhkehoachsq2=N'{21}',tilehoanthanhkehoachsq3=N'{22}',tilehoanthanhkehoachsq4=N'{23}',tilehoanthanhkehoachcq1=N'{24}',tilehoanthanhkehoachcq2=N'{25}',tilehoanthanhkehoachcq3=N'{26}',tilehoanthanhkehoachcq4=N'{27}' WHERE may =N'{0}'and malinhkien =N'{1}'and kehoachsanxuat =N'{2}'and ngaygionhapdulieu=N'{3}'",  may,  malinhkien,  kehoachsanxuat,  ngaygionhapdulieu,  kehoachsanxuatsq1,  kehoachsanxuatsq2,  kehoachsanxuatsq3,  kehoachsanxuatsq4,  kehoachsanxuatcq1,  kehoachsanxuatcq2,kehoachsanxuatcq3,  kehoachsanxuatcq4,  sanluongthuctesq1,  sanluongthuctesq2,  sanluongthuctesq3,  sanluongthuctesq4,  sanluongthuctecq1,  sanluongthuctecq2,  sanluongthuctecq3,  sanluongthuctecq4,  tilehoanthanhkehoachsq1,  tilehoanthanhkehoachsq2,  tilehoanthanhkehoachsq3,  tilehoanthanhkehoachsq4,  tilehoanthanhkehoachcq1,  tilehoanthanhkehoachcq2,  tilehoanthanhkehoachcq3,  tilehoanthanhkehoachcq4);
        //    int result = DataProvider.Instance.ExecuteNonQuery(query);
        //    return result > 0;
        //}

        public List<DataDTO> LoadTableList()
        {
            List<DataDTO> tablelist = new List<DataDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data");
            foreach (DataRow item in data.Rows)
            {
                DataDTO nhap = new DataDTO(item);
                tablelist.Add(nhap);
            }
            return tablelist;
        }


        public bool themdulieu(string malinhkien, string tenlinhkien, string tilenhuanghientrenbanve, string tilenhuanghiendathunghiemok, string socavity, string loaimayduc, string cycletime, string loainhua, string tennguyenlieu, string capdonguyenlieu, string mamau, string nhietdosay, string thoigiansay, string thoigianupkhuon, string thoigianhakhuon, string thoigianchaymay, string thoigiandungmay, string songuoithaotac, string thoigianlennhietmayduc, string thoigianlennhiethotrunner, string thoigianlennhietkhuon, string thoigianvesinhmaysay, string trongluongsanpham, string trongluongrunnergate, string tongtrongluongsanpham, string soluongfirstshotmotlan)
        {
            string query = string.Format("INSERT INTO [dbo].[Data] (malinhkien,tenlinhkien,   tilenhuanghientrenbanve,   tilenhuanghiendathunghiemok,   socavity,   loaimayduc,   cycletime,   loainhua,   tennguyenlieu,   capdonguyenlieu,   mamau,   nhietdosay,   thoigiansay,   thoigianupkhuon,   thoigianhakhuon,   thoigianchaymay,   thoigiandungmay,   songuoithaotac,   thoigianlennhietmayduc,   thoigianlennhiethotrunner,   thoigianlennhietkhuon,   thoigianvesinhmaysay,   trongluongsanpham,   trongluongrunnergate,   tongtrongluongsanpham,   soluongfirstshotmotlan) VALUES (N'{0}',N'{1}',N'{2}', N'{3}',N'{4}', N'{5}', N'{6}', N'{7}',N'{8}', N'{9}',N'{10}', N'{11}',N'{12}', N'{13}',N'{14}',N'{15}',N'{16}',N'{17}',N'{18}',N'{19}',N'{20}',N'{21}',N'{22}',N'{23}',N'{24}',N'{25}')", malinhkien, tenlinhkien, tilenhuanghientrenbanve, tilenhuanghiendathunghiemok, socavity, loaimayduc, cycletime, loainhua, tennguyenlieu, capdonguyenlieu, mamau, nhietdosay, thoigiansay, thoigianupkhuon, thoigianhakhuon, thoigianchaymay, thoigiandungmay, songuoithaotac, thoigianlennhietmayduc, thoigianlennhiethotrunner, thoigianlennhietkhuon, thoigianvesinhmaysay, trongluongsanpham, trongluongrunnergate, tongtrongluongsanpham, soluongfirstshotmotlan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool suadulieu(string id, string malinhkien, string tenlinhkien, string tilenhuanghientrenbanve, string tilenhuanghiendathunghiemok, string socavity, string loaimayduc, string cycletime, string loainhua, string tennguyenlieu, string capdonguyenlieu, string mamau, string nhietdosay, string thoigiansay, string thoigianupkhuon, string thoigianhakhuon, string thoigianchaymay, string thoigiandungmay, string songuoithaotac, string thoigianlennhietmayduc, string thoigianlennhiethotrunner, string thoigianlennhietkhuon, string thoigianvesinhmaysay, string trongluongsanpham, string trongluongrunnergate, string tongtrongluongsanpham, string soluongfirstshotmotlan)
        {
            string query = string.Format("update [dbo].[Data] set malinhkien='{1}',tenlinhkien='{2}',tilenhuanghientrenbanve='{3}',tilenhuanghiendathunghiemok='{4}',socavity='{5}',loaimayduc='{6}',cycletime='{7}',loainhua='{8}',tennguyenlieu='{9}',capdonguyenlieu='{10}',mamau='{11}',nhietdosay='{12}',thoigiansay='{13}',thoigianupkhuon='{14}',thoigianhakhuon='{15}',thoigianchaymay='{16}',thoigiandungmay='{17}',songuoithaotac='{18}',thoigianlennhietmayduc='{19}',thoigianlennhiethotrunner='{20}',thoigianlennhietkhuon='{21}',thoigianvesinhmaysay='{22}',trongluongsanpham='{23}',trongluongrunnergate='{24}',tongtrongluongsanpham='{25}',soluongfirstshotmotlan='{26}' WHERE id ='{0}'" , id, malinhkien, tenlinhkien, tilenhuanghientrenbanve, tilenhuanghiendathunghiemok, socavity, loaimayduc, cycletime, loainhua, tennguyenlieu, capdonguyenlieu, mamau, nhietdosay, thoigiansay, thoigianupkhuon, thoigianhakhuon, thoigianchaymay, thoigiandungmay, songuoithaotac, thoigianlennhietmayduc, thoigianlennhiethotrunner, thoigianlennhietkhuon, thoigianvesinhmaysay, trongluongsanpham, trongluongrunnergate, tongtrongluongsanpham, soluongfirstshotmotlan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

    }
}

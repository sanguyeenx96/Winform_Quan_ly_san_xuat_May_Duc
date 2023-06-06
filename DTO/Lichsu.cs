using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyTinhTrangSanXuat.DTO
{
    public class LichsuDTO
    {
        public LichsuDTO(int id, string ngaygionhapdulieu, string may, string malinhkien, string tenlinhkien, string trongluongsanpham, string trongluongrunner, string kehoachsanxuat, string thoidiemdukienbatdausanxuat, string tongsoshotduc, string tongtrongluong1pcs, string cycletimeduc, string thoigianvesinhmaysaytieuchuan, string thoigianvesinhmaysaythucte, string tennguyenlieudukiensudung, string tennguyenlieuthuctesudung, string capdonguyenlieudukiensudung, string capdonguyenlieuthuctesudung, string mamaunguyenlieudukiensudung, string mamaunguyenlieuthuctesudung, string nhietdosay, string nhietdosaythucte, string thoigiansay, string thoigiansaythucte, string tilenhuanghientrenfile, string tilenhuanghienthucte, string luongnhuatinhcandungdukien, string luongnhuatinhcandungthucte, string luongnhuanghiencandungdukien, string luongnhuanghiencandungthucte, string thoidiemdukienbatdauvesinhmaysay, string thoidiemthuctebatdauvesinhmaysay, string thoidiemdukienbatdausaynhua, string thoidiemthuctebatdausaynhua, string khuoncanhadukien, string khuoncanhathucte, string khuoncanupdukien, string khuoncanupthucte, string thoigianthaykhuondukien, string thoigianthaykhuonthucte, string thoigianchaymaydukien, string thoigianchaymaythucte, string thoigianlennhietdukien, string thoigianlennhietthucte, string thoidiemdukienbatdaulenkhuon, string thoidiemthuctebatdaulenkhuon, string songuoithaotacdukien, string songuoithaotacthucte, string thoigiansanxuatdukien, string thoigiansanxuatthucte, string sanluongducdukien, string sanluongducthucte, string thoidiemthuctebatdausanxuat, string sanluongok, string soluongfirstshot, string soluongng, string tilelinhkienok, string solandungmay, string thoigiandungmay, string tilehoatdongmay, string tilehoanthanhkehoach, string kehoachsanxuatsq1, string kehoachsanxuatsq2, string kehoachsanxuatsq3, string kehoachsanxuatsq4, string kehoachsanxuatcq1, string kehoachsanxuatcq2, string kehoachsanxuatcq3, string kehoachsanxuatcq4, string soshotducsq1, string soshotducsq2, string soshotducsq3, string soshotducsq4, string soshotduccq1, string soshotduccq2, string soshotduccq3, string soshotduccq4, string sanluongthuctesq1, string sanluongthuctesq2, string sanluongthuctesq3, string sanluongthuctesq4, string sanluongthuctecq1, string sanluongthuctecq2, string sanluongthuctecq3, string sanluongthuctecq4, string soluongfirstshotsq1, string soluongfirstshotsq2, string soluongfirstshotsq3, string soluongfirstshotsq4, string soluongfirstshotcq1, string soluongfirstshotcq2, string soluongfirstshotcq3, string soluongfirstshotcq4, string soluongngsq1, string soluongngsq2, string soluongngsq3, string soluongngsq4, string soluongngcq1, string soluongngcq2, string soluongngcq3, string soluongngcq4, string tilelinhkienoksq1, string tilelinhkienoksq2, string tilelinhkienoksq3, string tilelinhkienoksq4, string tilelinhkienokcq1, string tilelinhkienokcq2, string tilelinhkienokcq3, string tilelinhkienokcq4, string tilehoanthanhkehoachsq1, string tilehoanthanhkehoachsq2, string tilehoanthanhkehoachsq3, string tilehoanthanhkehoachsq4, string tilehoanthanhkehoachcq1, string tilehoanthanhkehoachcq2, string tilehoanthanhkehoachcq3, string tilehoanthanhkehoachcq4)
        {
            this.Id = id;
            this.Ngaygionhapdulieu = ngaygionhapdulieu;
            this.May                                            = may;
            this.Malinhkien                                     = malinhkien;
            this.Tenlinhkien                                    = tenlinhkien;
            this.Trongluongsanpham                              = trongluongsanpham;
            this.Trongluongrunner                               = trongluongrunner;
            this.Kehoachsanxuat                                 = kehoachsanxuat;
            this.Thoidiemdukienbatdausanxuat                    = thoidiemdukienbatdausanxuat;
            this.Tongsoshotduc                                  = tongsoshotduc;
            this.Tongtrongluong1pcs                              = tongtrongluong1pcs;
            this.Cycletimeduc                                       = cycletimeduc;
            this.Thoigianvesinhmaysaytieuchuan                   = thoigianvesinhmaysaytieuchuan;
            this.Thoigianvesinhmaysaythucte                         = thoigianvesinhmaysaythucte;
            this.Tennguyenlieudukiensudung                              = tennguyenlieudukiensudung;
            this.Tennguyenlieuthuctesudung                      = tennguyenlieuthuctesudung;
            this.Capdonguyenlieudukiensudung                            = capdonguyenlieudukiensudung;
            this.Capdonguyenlieuthuctesudung                                = capdonguyenlieuthuctesudung;
            this.Mamaunguyenlieudukiensudung                             = mamaunguyenlieudukiensudung;
            this.Mamaunguyenlieuthuctesudung                            = mamaunguyenlieuthuctesudung;
            this.Nhietdosay                                             = nhietdosay;
            this.Nhietdosaythucte                                           = nhietdosaythucte;
            this.Thoigiansay                                        = thoigiansay;
            this.Thoigiansaythucte                                      = thoigiansaythucte;
            this.Tilenhuanghientrenfile                                         = tilenhuanghientrenfile;
            this.Tilenhuanghienthucte                                       = tilenhuanghienthucte;
            this.Luongnhuatinhcandungdukien                                         = luongnhuatinhcandungdukien;
            this.Luongnhuatinhcandungthucte                                         = luongnhuatinhcandungthucte;
            this.Luongnhuanghiencandungdukien                                       = luongnhuanghiencandungdukien;
            this.Luongnhuanghiencandungthucte                                       = luongnhuanghiencandungthucte;
            this.Thoidiemdukienbatdauvesinhmaysay                                       = thoidiemdukienbatdauvesinhmaysay;
            this.Thoidiemthuctebatdauvesinhmaysay                                       = thoidiemthuctebatdauvesinhmaysay;
            this.Thoidiemdukienbatdausaynhua                                         = thoidiemdukienbatdausaynhua;
            this.Thoidiemthuctebatdausaynhua                                        = thoidiemthuctebatdausaynhua;
            this.Khuoncanhadukien                                        = khuoncanhadukien;
            this.Khuoncanhathucte                                        = khuoncanhathucte;
            this.Khuoncanupdukien                                       = khuoncanupdukien;
            this.Khuoncanupthucte                                       = khuoncanupthucte;
            this.Thoigianthaykhuondukien                                        = thoigianthaykhuondukien;
            this.Thoigianthaykhuonthucte                                        = thoigianthaykhuonthucte;
            this.Thoigianchaymaydukien                                      = thoigianchaymaydukien;
            this.Thoigianchaymaythucte                                      = thoigianchaymaythucte;
            this.Thoigianlennhietdukien                                         = thoigianlennhietdukien;
            this.Thoigianlennhietthucte                                         = thoigianlennhietthucte;
            this.Thoidiemdukienbatdaulenkhuon                                       = thoidiemdukienbatdaulenkhuon;
            this.Thoidiemthuctebatdaulenkhuon                                       = thoidiemthuctebatdaulenkhuon;
            this.Songuoithaotacdukien                                       = songuoithaotacdukien;
            this.Songuoithaotacthucte                                       = songuoithaotacthucte;
            this.Thoigiansanxuatdukien                                      = thoigiansanxuatdukien;
            this.Thoigiansanxuatthucte                                      = thoigiansanxuatthucte;
            this.Sanluongducdukien                                       = sanluongducdukien;
            this.Sanluongducthucte                                      = sanluongducthucte;
            this.Thoidiemthuctebatdausanxuat                                        = thoidiemthuctebatdausanxuat;
            this.Sanluongok                                      = sanluongok;
            this.Soluongfirstshot                                       = soluongfirstshot;
            this.Soluongng                                      = soluongng;
            this.Tilelinhkienok                                         = tilelinhkienok;
            this.Solandungmay                                        = solandungmay;
            this.Thoigiandungmay                                        = thoigiandungmay;
            this.Tilehoatdongmay                                        = tilehoatdongmay;
            this.Tilehoanthanhkehoach                                       = tilehoanthanhkehoach;
            this.Kehoachsanxuatsq1                              = kehoachsanxuatsq1;
            this.Kehoachsanxuatsq2                              = kehoachsanxuatsq2;
            this.Kehoachsanxuatsq3                              = kehoachsanxuatsq3;
            this.Kehoachsanxuatsq4                              = kehoachsanxuatsq4;
            this.Kehoachsanxuatcq1                              = kehoachsanxuatcq1;
            this.Kehoachsanxuatcq2                              = kehoachsanxuatcq2;
            this.Kehoachsanxuatcq3                              = kehoachsanxuatcq3;
            this.Kehoachsanxuatcq4                              = kehoachsanxuatcq4;

            this.Soshotducsq1 = soshotducsq1;
            this.Soshotducsq3 = soshotducsq3;
            this.Soshotducsq4 = soshotducsq4;
            this.Soshotduccq1 = soshotduccq1;
            this.Soshotduccq2 = soshotduccq2;
            this.Soshotduccq3 = soshotduccq3;
            this.Soshotduccq4 = soshotduccq4;
            this.Sanluongthuctesq1 = sanluongthuctesq1;
            this.Sanluongthuctesq2 = sanluongthuctesq2;
            this.Sanluongthuctesq3 = sanluongthuctesq3;
            this.Sanluongthuctesq4 = sanluongthuctesq4;
            this.Sanluongthuctecq1 = sanluongthuctecq1;
            this.Sanluongthuctecq2 = sanluongthuctecq2;
            this.Sanluongthuctecq3 = sanluongthuctecq3;
            this.Sanluongthuctecq4 = sanluongthuctecq4;
            this.Soluongfirstshotsq1 = soluongfirstshotsq1;
            this.Soluongfirstshotsq2 = soluongfirstshotsq2;
            this.Soluongfirstshotsq3 = soluongfirstshotsq3;
            this.Soluongfirstshotsq4 = soluongfirstshotsq4;
            this.Soluongfirstshotcq1 = soluongfirstshotcq1;
            this.Soluongfirstshotcq2 = soluongfirstshotcq2;
            this.Soluongfirstshotcq3 = soluongfirstshotcq3;
            this.Soluongfirstshotcq4 = soluongfirstshotcq4;
            this.Soluongngsq1 = soluongngsq1;
            this.Soluongngsq2 = soluongngsq2;
            this.Soluongngsq3 = soluongngsq3;
            this.Soluongngsq4 = soluongngsq4;
            this.Soluongngcq1 = soluongngcq1;
            this.Soluongngcq2 = soluongngcq2;
            this.Soluongngcq3 = soluongngcq3;
            this.Soluongngcq4 = soluongngcq4;
            this.Tilelinhkienoksq1 = tilelinhkienoksq1;
            this.Tilelinhkienoksq2 = tilelinhkienoksq2;
            this.Tilelinhkienoksq3 = tilelinhkienoksq3;
            this.Tilelinhkienoksq4 = tilelinhkienoksq4;
            this.Tilelinhkienokcq1 = tilelinhkienokcq1;
            this.Tilelinhkienokcq2 = tilelinhkienokcq2;
            this.Tilelinhkienokcq3 = tilelinhkienokcq3;
            this.Tilelinhkienokcq4 = tilelinhkienokcq4;
            this.Tilehoanthanhkehoachsq1                        = tilehoanthanhkehoachsq1;
            this.Tilehoanthanhkehoachsq2                        = tilehoanthanhkehoachsq2;
            this.Tilehoanthanhkehoachsq3                        = tilehoanthanhkehoachsq3;
            this.Tilehoanthanhkehoachsq4                        = tilehoanthanhkehoachsq4;
            this.Tilehoanthanhkehoachcq1                        = tilehoanthanhkehoachcq1;
            this.Tilehoanthanhkehoachcq2                        = tilehoanthanhkehoachcq2;
            this.Tilehoanthanhkehoachcq3                        = tilehoanthanhkehoachcq3;
            this.Tilehoanthanhkehoachcq4                        = tilehoanthanhkehoachcq4;


        }

        public LichsuDTO(DataRow row)
        {

            this.Id = (int)row["id"];
            this.Ngaygionhapdulieu = row["ngaygionhapdulieu"].ToString();
            this.May = row["may"].ToString();
            this.Malinhkien = row["malinhkien"].ToString();
            this.Tenlinhkien = row["tenlinhkien"].ToString();
            this.Trongluongsanpham = row["trongluongsanpham"].ToString();
            this.Trongluongrunner = row["trongluongrunner"].ToString();
            this.Kehoachsanxuat = row["kehoachsanxuat"].ToString();
            this.Thoidiemdukienbatdausanxuat = row["thoidiemdukienbatdausanxuat"].ToString();
            this.Tongsoshotduc = row["tongsoshotduc"].ToString();
            this.Tongtrongluong1pcs = row["tongtrongluong1pcs"].ToString();
            this.Cycletimeduc = row["cycletimeduc"].ToString();
            this.Thoigianvesinhmaysaytieuchuan = row["thoigianvesinhmaysaytieuchuan"].ToString();
            this.Thoigianvesinhmaysaythucte = row["thoigianvesinhmaysaythucte"].ToString();
            this.Tennguyenlieudukiensudung = row["tennguyenlieudukiensudung"].ToString();
            this.Tennguyenlieuthuctesudung = row["tennguyenlieuthuctesudung"].ToString();
            this.Capdonguyenlieudukiensudung = row["capdonguyenlieudukiensudung"].ToString();
            this.Capdonguyenlieuthuctesudung = row["capdonguyenlieuthuctesudung"].ToString();
            this.Mamaunguyenlieudukiensudung = row["mamaunguyenlieudukiensudung"].ToString();
            this.Mamaunguyenlieuthuctesudung = row["mamaunguyenlieuthuctesudung"].ToString();
            this.Nhietdosay = row["nhietdosay"].ToString();
            this.Nhietdosaythucte = row["nhietdosaythucte"].ToString();
            this.Thoigiansay = row["thoigiansay"].ToString();
            this.Thoigiansaythucte = row["thoigiansaythucte"].ToString();
            this.Tilenhuanghientrenfile = row["tilenhuanghientrenfile"].ToString();
            this.Tilenhuanghienthucte = row["tilenhuanghienthucte"].ToString();
            this.Luongnhuatinhcandungdukien = row["luongnhuatinhcandungdukien"].ToString();
            this.Luongnhuatinhcandungthucte = row["luongnhuatinhcandungthucte"].ToString();
            this.Luongnhuanghiencandungdukien = row["luongnhuanghiencandungdukien"].ToString();
            this.Luongnhuanghiencandungthucte = row["luongnhuanghiencandungthucte"].ToString();
            this.Thoidiemdukienbatdauvesinhmaysay = row["thoidiemdukienbatdauvesinhmaysay"].ToString();
            this.Thoidiemthuctebatdauvesinhmaysay = row["thoidiemthuctebatdauvesinhmaysay"].ToString();
            this.Thoidiemdukienbatdausaynhua = row["thoidiemdukienbatdausaynhua"].ToString();
            this.Thoidiemthuctebatdausaynhua = row["thoidiemthuctebatdausaynhua"].ToString();
            this.Khuoncanhadukien = row["khuoncanhadukien"].ToString();
            this.Khuoncanhathucte = row["khuoncanhathucte"].ToString();
            this.Khuoncanupdukien = row["khuoncanupdukien"].ToString();
            this.Khuoncanupthucte = row["khuoncanupthucte"].ToString();
            this.Thoigianthaykhuondukien = row["thoigianthaykhuondukien"].ToString();
            this.Thoigianthaykhuonthucte = row["thoigianthaykhuonthucte"].ToString();
            this.Thoigianchaymaydukien = row["thoigianchaymaydukien"].ToString();
            this.Thoigianchaymaythucte = row["thoigianchaymaythucte"].ToString();
            this.Thoigianlennhietdukien = row["thoigianlennhietdukien"].ToString();
            this.Thoigianlennhietthucte = row["thoigianlennhietthucte"].ToString();
            this.Thoidiemdukienbatdaulenkhuon = row["thoidiemdukienbatdaulenkhuon"].ToString();
            this.Thoidiemthuctebatdaulenkhuon = row["thoidiemthuctebatdaulenkhuon"].ToString();
            this.Songuoithaotacdukien = row["songuoithaotacdukien"].ToString();
            this.Songuoithaotacthucte = row["songuoithaotacthucte"].ToString();
            this.Thoigiansanxuatdukien = row["thoigiansanxuatdukien"].ToString();
            this.Thoigiansanxuatthucte = row["thoigiansanxuatthucte"].ToString();
            this.Sanluongducdukien = row["sanluongducdukien"].ToString();
            this.Sanluongducthucte = row["sanluongducthucte"].ToString();
            this.Thoidiemthuctebatdausanxuat = row["thoidiemthuctebatdausanxuat"].ToString();
            this.Sanluongok = row["sanluongok"].ToString();
            this.Soluongfirstshot = row["soluongfirstshot"].ToString();
            this.Soluongng = row["soluongng"].ToString();
            this.Tilelinhkienok = row["tilelinhkienok"].ToString();
            this.Solandungmay = row["solandungmay"].ToString();
            this.Thoigiandungmay = row["thoigiandungmay"].ToString();
            this.Tilehoatdongmay = row["tilehoatdongmay"].ToString();
            this.Tilehoanthanhkehoach = row["tilehoanthanhkehoach"].ToString();
            this.Kehoachsanxuatsq1 = row["kehoachsanxuatsq1"].ToString();
            this.Kehoachsanxuatsq2 = row["kehoachsanxuatsq2"].ToString();
            this.Kehoachsanxuatsq3 = row["kehoachsanxuatsq3"].ToString();
            this.Kehoachsanxuatsq4 = row["kehoachsanxuatsq4"].ToString();
            this.Kehoachsanxuatcq1 = row["kehoachsanxuatcq1"].ToString();
            this.Kehoachsanxuatcq2 = row["kehoachsanxuatcq2"].ToString();
            this.Kehoachsanxuatcq3 = row["kehoachsanxuatcq3"].ToString();
            this.Kehoachsanxuatcq4 = row["kehoachsanxuatcq4"].ToString();


            this.Soshotducsq1                 =  row["soshotducsq1"].ToString();
            this.Soshotducsq2                 =  row["soshotducsq2"].ToString();
            this.Soshotducsq3                 =  row["soshotducsq3"].ToString();
            this.Soshotducsq4                 =  row["soshotducsq4"].ToString();
            this.Soshotduccq1                 =  row["soshotduccq1"].ToString();
            this.Soshotduccq2                 =  row["soshotduccq2"].ToString();
            this.Soshotduccq3                 =  row["soshotduccq3"].ToString();
            this.Soshotduccq4                 =  row["soshotduccq4"].ToString();
            this.Sanluongthuctesq1            =  row["sanluongthuctesq1"].ToString();
            this.Sanluongthuctesq2            =  row["sanluongthuctesq2"].ToString();
            this.Sanluongthuctesq3            =  row["sanluongthuctesq3"].ToString();
            this.Sanluongthuctesq4            =  row["sanluongthuctesq4"].ToString();
            this.Sanluongthuctecq1            =  row["sanluongthuctecq1"].ToString();
            this.Sanluongthuctecq2            =  row["sanluongthuctecq2"].ToString();
            this.Sanluongthuctecq3            =  row["sanluongthuctecq3"].ToString();
            this.Sanluongthuctecq4            =  row["sanluongthuctecq4"].ToString();
            this.Soluongfirstshotsq1          =  row["soluongfirstshotsq1"].ToString();
            this.Soluongfirstshotsq2          =  row["soluongfirstshotsq2"].ToString();
            this.Soluongfirstshotsq3          =  row["soluongfirstshotsq3"].ToString();
            this.Soluongfirstshotsq4          =  row["soluongfirstshotsq4"].ToString();
            this.Soluongfirstshotcq1          =  row["soluongfirstshotcq1"].ToString();
            this.Soluongfirstshotcq2          =  row["soluongfirstshotcq2"].ToString();
            this.Soluongfirstshotcq3          =  row["soluongfirstshotcq3"].ToString();
            this.Soluongfirstshotcq4          =  row["soluongfirstshotcq4"].ToString();
            this.Soluongngsq1                 =  row["soluongngsq1"].ToString();
            this.Soluongngsq2                 =  row["soluongngsq2"].ToString();
            this.Soluongngsq3                 =  row["soluongngsq3"].ToString();
            this.Soluongngsq4                 =  row["soluongngsq4"].ToString();
            this.Soluongngcq1                 =  row["soluongngcq1"].ToString();
            this.Soluongngcq2                 =  row["soluongngcq2"].ToString();
            this.Soluongngcq3                 =  row["soluongngcq3"].ToString();
            this.Soluongngcq4                 =  row["soluongngcq4"].ToString();
            this.Tilelinhkienoksq1            =  row["tilelinhkienoksq1"].ToString();
            this.Tilelinhkienoksq2            =  row["tilelinhkienoksq2"].ToString();
            this.Tilelinhkienoksq3            =  row["tilelinhkienoksq3"].ToString();
            this.Tilelinhkienoksq4            =  row["tilelinhkienoksq4"].ToString();
            this.Tilelinhkienokcq1            =  row["tilelinhkienokcq1"].ToString();
            this.Tilelinhkienokcq2            =  row["tilelinhkienokcq2"].ToString();
            this.Tilelinhkienokcq3            =  row["tilelinhkienokcq3"].ToString();
            this.Tilelinhkienokcq4            =  row["tilelinhkienokcq4"].ToString();

            this.Tilehoanthanhkehoachsq1 = row["tilehoanthanhkehoachsq1"].ToString();
            this.Tilehoanthanhkehoachsq2 = row["tilehoanthanhkehoachsq2"].ToString();
            this.Tilehoanthanhkehoachsq3 = row["tilehoanthanhkehoachsq3"].ToString();
            this.Tilehoanthanhkehoachsq4 = row["tilehoanthanhkehoachsq4"].ToString();
            this.Tilehoanthanhkehoachcq1 = row["tilehoanthanhkehoachcq1"].ToString();
            this.Tilehoanthanhkehoachcq2 = row["tilehoanthanhkehoachcq2"].ToString();
            this.Tilehoanthanhkehoachcq3 = row["tilehoanthanhkehoachcq3"].ToString();
            this.Tilehoanthanhkehoachcq4 = row["tilehoanthanhkehoachcq4"].ToString();

        }
        private int id;
        private string ngaygionhapdulieu;
        private string may;
        private string malinhkien;
        private string tenlinhkien;
        private string trongluongsanpham;
        private string trongluongrunner;
        private string kehoachsanxuat;
        private string thoidiemdukienbatdausanxuat;
        private string tongsoshotduc;
        private string tongtrongluong1pcs;
        private string cycletimeduc;
        private string thoigianvesinhmaysaytieuchuan;
        private string thoigianvesinhmaysaythucte;
        private string tennguyenlieudukiensudung;
        private string tennguyenlieuthuctesudung;
        private string capdonguyenlieudukiensudung;
        private string capdonguyenlieuthuctesudung;
        private string mamaunguyenlieudukiensudung;
        private string mamaunguyenlieuthuctesudung;
        private string nhietdosay;
        private string nhietdosaythucte;
        private string thoigiansay;
        private string thoigiansaythucte;
        private string tilenhuanghientrenfile;
        private string tilenhuanghienthucte;
        private string luongnhuatinhcandungdukien;
        private string luongnhuatinhcandungthucte;
        private string luongnhuanghiencandungdukien;
        private string luongnhuanghiencandungthucte;
        private string thoidiemdukienbatdauvesinhmaysay;
        private string thoidiemthuctebatdauvesinhmaysay;
        private string thoidiemdukienbatdausaynhua;
        private string thoidiemthuctebatdausaynhua;
        private string khuoncanhadukien;
        private string khuoncanhathucte;
        private string khuoncanupdukien;
        private string khuoncanupthucte;
        private string thoigianthaykhuondukien;
        private string thoigianthaykhuonthucte;
        private string thoigianchaymaydukien;
        private string thoigianchaymaythucte;
        private string thoigianlennhietdukien;
        private string thoigianlennhietthucte;
        private string thoidiemdukienbatdaulenkhuon;
        private string thoidiemthuctebatdaulenkhuon;
        private string songuoithaotacdukien;
        private string songuoithaotacthucte;
        private string thoigiansanxuatdukien;
        private string thoigiansanxuatthucte;
        private string sanluongducdukien;
        private string sanluongducthucte;
        private string thoidiemthuctebatdausanxuat;
        private string sanluongok;
        private string soluongfirstshot;
        private string soluongng;
        private string tilelinhkienok;
        private string solandungmay;
        private string thoigiandungmay;
        private string tilehoatdongmay;
        private string tilehoanthanhkehoach;
        private string kehoachsanxuatsq1;
        private string kehoachsanxuatsq2;
        private string kehoachsanxuatsq3;
        private string kehoachsanxuatsq4;
        private string kehoachsanxuatcq1;
        private string kehoachsanxuatcq2;
        private string kehoachsanxuatcq3;
        private string kehoachsanxuatcq4;
        private string soshotducsq1;
        private string soshotducsq2;
        private string soshotducsq3;
        private string soshotducsq4;
        private string soshotduccq1;
        private string soshotduccq2;
        private string soshotduccq3;
        private string soshotduccq4;
        private string sanluongthuctesq1;
        private string sanluongthuctesq2;
        private string sanluongthuctesq3;
        private string sanluongthuctesq4;
        private string sanluongthuctecq1;
        private string sanluongthuctecq2;
        private string sanluongthuctecq3;
        private string sanluongthuctecq4;
        private string soluongfirstshotsq1;
        private string soluongfirstshotsq2;
        private string soluongfirstshotsq3;
        private string soluongfirstshotsq4;
        private string soluongfirstshotcq1;
        private string soluongfirstshotcq2;
        private string soluongfirstshotcq3;
        private string soluongfirstshotcq4;
        private string soluongngsq1;
        private string soluongngsq2;
        private string soluongngsq3;
        private string soluongngsq4;
        private string soluongngcq1;
        private string soluongngcq2;
        private string soluongngcq3;
        private string soluongngcq4;
        private string tilelinhkienoksq1;
        private string tilelinhkienoksq2;
        private string tilelinhkienoksq3;
        private string tilelinhkienoksq4;
        private string tilelinhkienokcq1;
        private string tilelinhkienokcq2;
        private string tilelinhkienokcq3;
        private string tilelinhkienokcq4;
        private string tilehoanthanhkehoachsq1;
        private string tilehoanthanhkehoachsq2;
        private string tilehoanthanhkehoachsq3;
        private string tilehoanthanhkehoachsq4;
        private string tilehoanthanhkehoachcq1;
        private string tilehoanthanhkehoachcq2;
        private string tilehoanthanhkehoachcq3;
        private string tilehoanthanhkehoachcq4;

        public int Id { get => id; set => id = value; }
        public string Ngaygionhapdulieu { get => ngaygionhapdulieu; set => ngaygionhapdulieu = value; }
        public string May { get => may; set => may = value; }
        public string Malinhkien { get => malinhkien; set => malinhkien = value; }
        public string Tenlinhkien { get => tenlinhkien; set => tenlinhkien = value; }
        public string Trongluongsanpham { get => trongluongsanpham; set => trongluongsanpham = value; }
        public string Trongluongrunner { get => trongluongrunner; set => trongluongrunner = value; }
        public string Kehoachsanxuat { get => kehoachsanxuat; set => kehoachsanxuat = value; }
        public string Thoidiemdukienbatdausanxuat { get => thoidiemdukienbatdausanxuat; set => thoidiemdukienbatdausanxuat = value; }
        public string Tongsoshotduc { get => tongsoshotduc; set => tongsoshotduc = value; }
        public string Tongtrongluong1pcs { get => tongtrongluong1pcs; set => tongtrongluong1pcs = value; }
        public string Cycletimeduc { get => cycletimeduc; set => cycletimeduc = value; }
        public string Thoigianvesinhmaysaytieuchuan { get => thoigianvesinhmaysaytieuchuan; set => thoigianvesinhmaysaytieuchuan = value; }
        public string Thoigianvesinhmaysaythucte { get => thoigianvesinhmaysaythucte; set => thoigianvesinhmaysaythucte = value; }
        public string Tennguyenlieudukiensudung { get => tennguyenlieudukiensudung; set => tennguyenlieudukiensudung = value; }
        public string Tennguyenlieuthuctesudung { get => tennguyenlieuthuctesudung; set => tennguyenlieuthuctesudung = value; }
        public string Capdonguyenlieudukiensudung { get => capdonguyenlieudukiensudung; set => capdonguyenlieudukiensudung = value; }
        public string Capdonguyenlieuthuctesudung { get => capdonguyenlieuthuctesudung; set => capdonguyenlieuthuctesudung = value; }
        public string Mamaunguyenlieudukiensudung { get => mamaunguyenlieudukiensudung; set => mamaunguyenlieudukiensudung = value; }
        public string Mamaunguyenlieuthuctesudung { get => mamaunguyenlieuthuctesudung; set => mamaunguyenlieuthuctesudung = value; }
        public string Nhietdosay { get => nhietdosay; set => nhietdosay = value; }
        public string Nhietdosaythucte { get => nhietdosaythucte; set => nhietdosaythucte = value; }
        public string Thoigiansay { get => thoigiansay; set => thoigiansay = value; }
        public string Thoigiansaythucte { get => thoigiansaythucte; set => thoigiansaythucte = value; }
        public string Tilenhuanghientrenfile { get => tilenhuanghientrenfile; set => tilenhuanghientrenfile = value; }
        public string Tilenhuanghienthucte { get => tilenhuanghienthucte; set => tilenhuanghienthucte = value; }
        public string Luongnhuatinhcandungdukien { get => luongnhuatinhcandungdukien; set => luongnhuatinhcandungdukien = value; }
        public string Luongnhuatinhcandungthucte { get => luongnhuatinhcandungthucte; set => luongnhuatinhcandungthucte = value; }
        public string Luongnhuanghiencandungdukien { get => luongnhuanghiencandungdukien; set => luongnhuanghiencandungdukien = value; }
        public string Luongnhuanghiencandungthucte { get => luongnhuanghiencandungthucte; set => luongnhuanghiencandungthucte = value; }
        public string Thoidiemdukienbatdauvesinhmaysay { get => thoidiemdukienbatdauvesinhmaysay; set => thoidiemdukienbatdauvesinhmaysay = value; }
        public string Thoidiemthuctebatdauvesinhmaysay { get => thoidiemthuctebatdauvesinhmaysay; set => thoidiemthuctebatdauvesinhmaysay = value; }
        public string Thoidiemdukienbatdausaynhua { get => thoidiemdukienbatdausaynhua; set => thoidiemdukienbatdausaynhua = value; }
        public string Thoidiemthuctebatdausaynhua { get => thoidiemthuctebatdausaynhua; set => thoidiemthuctebatdausaynhua = value; }
        public string Khuoncanhadukien { get => khuoncanhadukien; set => khuoncanhadukien = value; }
        public string Khuoncanhathucte { get => khuoncanhathucte; set => khuoncanhathucte = value; }
        public string Khuoncanupdukien { get => khuoncanupdukien; set => khuoncanupdukien = value; }
        public string Khuoncanupthucte { get => khuoncanupthucte; set => khuoncanupthucte = value; }
        public string Thoigianthaykhuondukien { get => thoigianthaykhuondukien; set => thoigianthaykhuondukien = value; }
        public string Thoigianthaykhuonthucte { get => thoigianthaykhuonthucte; set => thoigianthaykhuonthucte = value; }
        public string Thoigianchaymaydukien { get => thoigianchaymaydukien; set => thoigianchaymaydukien = value; }
        public string Thoigianchaymaythucte { get => thoigianchaymaythucte; set => thoigianchaymaythucte = value; }
        public string Thoigianlennhietdukien { get => thoigianlennhietdukien; set => thoigianlennhietdukien = value; }
        public string Thoigianlennhietthucte { get => thoigianlennhietthucte; set => thoigianlennhietthucte = value; }
        public string Thoidiemdukienbatdaulenkhuon { get => thoidiemdukienbatdaulenkhuon; set => thoidiemdukienbatdaulenkhuon = value; }
        public string Thoidiemthuctebatdaulenkhuon { get => thoidiemthuctebatdaulenkhuon; set => thoidiemthuctebatdaulenkhuon = value; }
        public string Songuoithaotacdukien { get => songuoithaotacdukien; set => songuoithaotacdukien = value; }
        public string Songuoithaotacthucte { get => songuoithaotacthucte; set => songuoithaotacthucte = value; }
        public string Thoigiansanxuatdukien { get => thoigiansanxuatdukien; set => thoigiansanxuatdukien = value; }
        public string Thoigiansanxuatthucte { get => thoigiansanxuatthucte; set => thoigiansanxuatthucte = value; }
        public string Sanluongducdukien { get => sanluongducdukien; set => sanluongducdukien = value; }
        public string Sanluongducthucte { get => sanluongducthucte; set => sanluongducthucte = value; }
        public string Thoidiemthuctebatdausanxuat { get => thoidiemthuctebatdausanxuat; set => thoidiemthuctebatdausanxuat = value; }
        public string Sanluongok { get => sanluongok; set => sanluongok = value; }
        public string Soluongfirstshot { get => soluongfirstshot; set => soluongfirstshot = value; }
        public string Soluongng { get => soluongng; set => soluongng = value; }
        public string Tilelinhkienok { get => tilelinhkienok; set => tilelinhkienok = value; }
        public string Solandungmay { get => solandungmay; set => solandungmay = value; }
        public string Thoigiandungmay { get => thoigiandungmay; set => thoigiandungmay = value; }
        public string Tilehoatdongmay { get => tilehoatdongmay; set => tilehoatdongmay = value; }
        public string Tilehoanthanhkehoach { get => tilehoanthanhkehoach; set => tilehoanthanhkehoach = value; }
        public string Kehoachsanxuatsq1 { get => kehoachsanxuatsq1; set => kehoachsanxuatsq1 = value; }
        public string Kehoachsanxuatsq2 { get => kehoachsanxuatsq2; set => kehoachsanxuatsq2 = value; }
        public string Kehoachsanxuatsq3 { get => kehoachsanxuatsq3; set => kehoachsanxuatsq3 = value; }
        public string Kehoachsanxuatsq4 { get => kehoachsanxuatsq4; set => kehoachsanxuatsq4 = value; }
        public string Kehoachsanxuatcq1 { get => kehoachsanxuatcq1; set => kehoachsanxuatcq1 = value; }
        public string Kehoachsanxuatcq2 { get => kehoachsanxuatcq2; set => kehoachsanxuatcq2 = value; }
        public string Kehoachsanxuatcq3 { get => kehoachsanxuatcq3; set => kehoachsanxuatcq3 = value; }
        public string Kehoachsanxuatcq4 { get => kehoachsanxuatcq4; set => kehoachsanxuatcq4 = value; }
        public string Soshotducsq1 { get => soshotducsq1; set => soshotducsq1 = value; }
        public string Soshotducsq2 { get => soshotducsq2; set => soshotducsq2 = value; }
        public string Soshotducsq3 { get => soshotducsq3; set => soshotducsq3 = value; }
        public string Soshotducsq4 { get => soshotducsq4; set => soshotducsq4 = value; }
        public string Soshotduccq1 { get => soshotduccq1; set => soshotduccq1 = value; }
        public string Soshotduccq2 { get => soshotduccq2; set => soshotduccq2 = value; }
        public string Soshotduccq3 { get => soshotduccq3; set => soshotduccq3 = value; }
        public string Soshotduccq4 { get => soshotduccq4; set => soshotduccq4 = value; }
        public string Sanluongthuctesq1 { get => sanluongthuctesq1; set => sanluongthuctesq1 = value; }
        public string Sanluongthuctesq2 { get => sanluongthuctesq2; set => sanluongthuctesq2 = value; }
        public string Sanluongthuctesq3 { get => sanluongthuctesq3; set => sanluongthuctesq3 = value; }
        public string Sanluongthuctesq4 { get => sanluongthuctesq4; set => sanluongthuctesq4 = value; }
        public string Sanluongthuctecq1 { get => sanluongthuctecq1; set => sanluongthuctecq1 = value; }
        public string Sanluongthuctecq2 { get => sanluongthuctecq2; set => sanluongthuctecq2 = value; }
        public string Sanluongthuctecq3 { get => sanluongthuctecq3; set => sanluongthuctecq3 = value; }
        public string Sanluongthuctecq4 { get => sanluongthuctecq4; set => sanluongthuctecq4 = value; }
        public string Soluongfirstshotsq1 { get => soluongfirstshotsq1; set => soluongfirstshotsq1 = value; }
        public string Soluongfirstshotsq2 { get => soluongfirstshotsq2; set => soluongfirstshotsq2 = value; }
        public string Soluongfirstshotsq3 { get => soluongfirstshotsq3; set => soluongfirstshotsq3 = value; }
        public string Soluongfirstshotsq4 { get => soluongfirstshotsq4; set => soluongfirstshotsq4 = value; }
        public string Soluongfirstshotcq1 { get => soluongfirstshotcq1; set => soluongfirstshotcq1 = value; }
        public string Soluongfirstshotcq2 { get => soluongfirstshotcq2; set => soluongfirstshotcq2 = value; }
        public string Soluongfirstshotcq3 { get => soluongfirstshotcq3; set => soluongfirstshotcq3 = value; }
        public string Soluongfirstshotcq4 { get => soluongfirstshotcq4; set => soluongfirstshotcq4 = value; }
        public string Soluongngsq1 { get => soluongngsq1; set => soluongngsq1 = value; }
        public string Soluongngsq2 { get => soluongngsq2; set => soluongngsq2 = value; }
        public string Soluongngsq3 { get => soluongngsq3; set => soluongngsq3 = value; }
        public string Soluongngsq4 { get => soluongngsq4; set => soluongngsq4 = value; }
        public string Soluongngcq1 { get => soluongngcq1; set => soluongngcq1 = value; }
        public string Soluongngcq2 { get => soluongngcq2; set => soluongngcq2 = value; }
        public string Soluongngcq3 { get => soluongngcq3; set => soluongngcq3 = value; }
        public string Soluongngcq4 { get => soluongngcq4; set => soluongngcq4 = value; }
        public string Tilelinhkienoksq1 { get => tilelinhkienoksq1; set => tilelinhkienoksq1 = value; }
        public string Tilelinhkienoksq2 { get => tilelinhkienoksq2; set => tilelinhkienoksq2 = value; }
        public string Tilelinhkienoksq3 { get => tilelinhkienoksq3; set => tilelinhkienoksq3 = value; }
        public string Tilelinhkienoksq4 { get => tilelinhkienoksq4; set => tilelinhkienoksq4 = value; }
        public string Tilelinhkienokcq1 { get => tilelinhkienokcq1; set => tilelinhkienokcq1 = value; }
        public string Tilelinhkienokcq2 { get => tilelinhkienokcq2; set => tilelinhkienokcq2 = value; }
        public string Tilelinhkienokcq3 { get => tilelinhkienokcq3; set => tilelinhkienokcq3 = value; }
        public string Tilelinhkienokcq4 { get => tilelinhkienokcq4; set => tilelinhkienokcq4 = value; }
        public string Tilehoanthanhkehoachsq1 { get => tilehoanthanhkehoachsq1; set => tilehoanthanhkehoachsq1 = value; }
        public string Tilehoanthanhkehoachsq2 { get => tilehoanthanhkehoachsq2; set => tilehoanthanhkehoachsq2 = value; }
        public string Tilehoanthanhkehoachsq3 { get => tilehoanthanhkehoachsq3; set => tilehoanthanhkehoachsq3 = value; }
        public string Tilehoanthanhkehoachsq4 { get => tilehoanthanhkehoachsq4; set => tilehoanthanhkehoachsq4 = value; }
        public string Tilehoanthanhkehoachcq1 { get => tilehoanthanhkehoachcq1; set => tilehoanthanhkehoachcq1 = value; }
        public string Tilehoanthanhkehoachcq2 { get => tilehoanthanhkehoachcq2; set => tilehoanthanhkehoachcq2 = value; }
        public string Tilehoanthanhkehoachcq3 { get => tilehoanthanhkehoachcq3; set => tilehoanthanhkehoachcq3 = value; }
        public string Tilehoanthanhkehoachcq4 { get => tilehoanthanhkehoachcq4; set => tilehoanthanhkehoachcq4 = value; }
    }
}

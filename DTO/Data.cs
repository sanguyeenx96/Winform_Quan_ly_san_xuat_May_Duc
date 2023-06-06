using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace QuanLyTinhTrangSanXuat.DTO
{
    public class DataDTO
    {
        public DataDTO(int id, string malinhkien, string tenlinhkien, float tilenhuanghientrenbanve, float tilenhuanghiendathunghiemok, float socavity, float loaimayduc, float cycletime, string loainhua, string tennguyenlieu, string capdonguyenlieu, string mamau, float nhietdosay, float thoigiansay, float thoigianupkhuon, float thoigianhakhuon, float thoigianchaymay, float thoigiandungmay, float songuoithaotac, float thoigianlennhietmayduc, float thoigianlennhiethotrunner, float thoigianlennhietkhuon, float thoigianvesinhmaysay, float trongluongsanpham, float trongluongrunnergate, float tongtrongluongsanpham, float soluongfirstshotmotlan)
        {
            this.Id = id;
            this.Malinhkien = malinhkien;
            this.Tenlinhkien = tenlinhkien;
            this.Tilenhuanghientrenbanve = tilenhuanghientrenbanve;
            this.Tilenhuanghiendathunghiemok = tilenhuanghiendathunghiemok;
            this.Socavity = socavity;
            this.Loaimayduc = loaimayduc;
            this.Cycletime = cycletime;
            this.Loainhua = loainhua;
            this.Tennguyenlieu = tennguyenlieu;
            this.Capdonguyenlieu = capdonguyenlieu;
            this.Mamau = mamau;
            this.Nhietdosay = nhietdosay;
            this.Thoigiansay = thoigiansay;
            this.Thoigianupkhuon = thoigianupkhuon;
            this.Thoigianhakhuon = thoigianhakhuon;
            this.Thoigianchaymay = thoigianchaymay;
            this.Thoigiandungmay = thoigiandungmay;
            this.Songuoithaotac = songuoithaotac;
            this.Thoigianlennhietmayduc = thoigianlennhietmayduc;
            this.Thoigianlennhiethotrunner = thoigianlennhiethotrunner;
            this.Thoigianlennhietkhuon = thoigianlennhietkhuon;
            this.Thoigianvesinhmaysay = thoigianvesinhmaysay;
            this.Trongluongsanpham = trongluongsanpham;
            this.Trongluongrunnergate = trongluongrunnergate;
            this.Tongtrongluongsanpham = tongtrongluongsanpham;
            this.Soluongfirstshotmotlan = soluongfirstshotmotlan;
        }

        public DataDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Malinhkien = row["malinhkien"].ToString();
            this.Tenlinhkien = row["tenlinhkien"].ToString();
            this.Tilenhuanghientrenbanve = (float)Convert.ToDouble(row["tilenhuanghientrenbanve"]);
            this.Tilenhuanghiendathunghiemok = (float)Convert.ToDouble(row["tilenhuanghiendathunghiemok"]); 
            this.Socavity = (float)Convert.ToDouble(row["socavity"]); 
            this.Loaimayduc = (float)Convert.ToDouble(row["loaimayduc"]); 
            this.Cycletime = (float)Convert.ToDouble(row["cycletime"]); 
            this.Loainhua = row["loainhua"].ToString();
            this.Tennguyenlieu = row["tennguyenlieu"].ToString();
            this.Capdonguyenlieu = row["capdonguyenlieu"].ToString();
            this.Mamau = row["mamau"].ToString();
            this.Nhietdosay = (float)Convert.ToDouble(row["nhietdosay"]); 
            this.Thoigiansay = (float)Convert.ToDouble(row["thoigiansay"]); 
            this.Thoigianupkhuon = (float)Convert.ToDouble(row["thoigianupkhuon"]); 
            this.Thoigianhakhuon = (float)Convert.ToDouble(row["thoigianhakhuon"]); 
            this.Thoigianchaymay = (float)Convert.ToDouble(row["thoigianchaymay"]); 
            this.Thoigiandungmay = (float)Convert.ToDouble(row["thoigiandungmay"]); 
            this.Songuoithaotac = (float)Convert.ToDouble(row["songuoithaotac"]); 
            this.Thoigianlennhietmayduc = (float)Convert.ToDouble(row["thoigianlennhietmayduc"]);
            this.Thoigianlennhiethotrunner = (float)Convert.ToDouble(row["thoigianlennhiethotrunner"]); 
            this.Thoigianlennhietkhuon = (float)Convert.ToDouble(row["thoigianlennhietkhuon"]); 
            this.Thoigianvesinhmaysay = (float)Convert.ToDouble(row["thoigianvesinhmaysay"]); 
            this.Trongluongsanpham = (float)Convert.ToDouble(row["trongluongsanpham"]); 
            this.Trongluongrunnergate = (float)Convert.ToDouble(row["trongluongrunnergate"]); 
            this.Tongtrongluongsanpham = (float)Convert.ToDouble(row["tongtrongluongsanpham"]);
            this.Soluongfirstshotmotlan = (float)Convert.ToDouble(row["soluongfirstshotmotlan"]); 
        }

        private int id;
        private string malinhkien;
        private string tenlinhkien;
        private float tilenhuanghientrenbanve;
        private float tilenhuanghiendathunghiemok;
        private float socavity;
        private float loaimayduc;
        private float cycletime;
        private string loainhua;
        private string tennguyenlieu;
        private string capdonguyenlieu;
        private string mamau;
        private float nhietdosay;
        private float thoigiansay;
        private float thoigianupkhuon;
        private float thoigianhakhuon;
        private float thoigianchaymay;
        private float thoigiandungmay;
        private float songuoithaotac;
        private float thoigianlennhietmayduc;
        private float thoigianlennhiethotrunner;
        private float thoigianlennhietkhuon;
        private float thoigianvesinhmaysay;
        private float trongluongsanpham;
        private float trongluongrunnergate;
        private float tongtrongluongsanpham;
        private float soluongfirstshotmotlan;

        public int Id { get => id; set => id = value; }
        public string Malinhkien { get => malinhkien; set => malinhkien = value; }
        public string Tenlinhkien { get => tenlinhkien; set => tenlinhkien = value; }
        public float Tilenhuanghientrenbanve { get => tilenhuanghientrenbanve; set => tilenhuanghientrenbanve = value; }
        public float Tilenhuanghiendathunghiemok { get => tilenhuanghiendathunghiemok; set => tilenhuanghiendathunghiemok = value; }
        public float Socavity { get => socavity; set => socavity = value; }
        public float Loaimayduc { get => loaimayduc; set => loaimayduc = value; }
        public float Cycletime { get => cycletime; set => cycletime = value; }
        public string Loainhua { get => loainhua; set => loainhua = value; }
        public string Tennguyenlieu { get => tennguyenlieu; set => tennguyenlieu = value; }
        public string Capdonguyenlieu { get => capdonguyenlieu; set => capdonguyenlieu = value; }
        public string Mamau { get => mamau; set => mamau = value; }
        public float Nhietdosay { get => nhietdosay; set => nhietdosay = value; }
        public float Thoigiansay { get => thoigiansay; set => thoigiansay = value; }
        public float Thoigianupkhuon { get => thoigianupkhuon; set => thoigianupkhuon = value; }
        public float Thoigianhakhuon { get => thoigianhakhuon; set => thoigianhakhuon = value; }
        public float Thoigianchaymay { get => thoigianchaymay; set => thoigianchaymay = value; }
        public float Thoigiandungmay { get => thoigiandungmay; set => thoigiandungmay = value; }
        public float Songuoithaotac { get => songuoithaotac; set => songuoithaotac = value; }
        public float Thoigianlennhietmayduc { get => thoigianlennhietmayduc; set => thoigianlennhietmayduc = value; }
        public float Thoigianlennhiethotrunner { get => thoigianlennhiethotrunner; set => thoigianlennhiethotrunner = value; }
        public float Thoigianlennhietkhuon { get => thoigianlennhietkhuon; set => thoigianlennhietkhuon = value; }
        public float Thoigianvesinhmaysay { get => thoigianvesinhmaysay; set => thoigianvesinhmaysay = value; }
        public float Trongluongsanpham { get => trongluongsanpham; set => trongluongsanpham = value; }
        public float Trongluongrunnergate { get => trongluongrunnergate; set => trongluongrunnergate = value; }
        public float Tongtrongluongsanpham { get => tongtrongluongsanpham; set => tongtrongluongsanpham = value; }
        public float Soluongfirstshotmotlan { get => soluongfirstshotmotlan; set => soluongfirstshotmotlan = value; }
    }
}

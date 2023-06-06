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
    public partial class frmThemDuLieu : Form
    {
        public frmThemDuLieu()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận thêm dữ liệu?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string malinhkien = txtMaLinhKien.Text;
                    string tenlinhkien = txtTenLinhKien.Text;
                    string tilenhuanghientrenbanve = txtTiLeNhuaNghienTrenBanVe.Text;
                    string tilenhuanghiendathunghiemok = txtTiLeNhuaNghienDaThuNghiemOK.Text;
                    string socavity = txtSoCavity.Text;
                    string loaimayduc = txtLoaiMayDuc.Text;
                    string cycletime = txtCycleTime.Text;
                    string loainhua = txtLoaiNhua.Text;
                    string tennguyenlieu = txtTenNguyenLieu.Text;
                    string capdonguyenlieu = txtCapDoNguyenLieu.Text;
                    string mamau = txtMaMau.Text;
                    string nhietdosay = txtNhietDoSay.Text;
                    string thoigiansay = txtThoiGianSay.Text;
                    string thoigianupkhuon = txtThoiGianUpKhuon.Text;
                    string thoigianhakhuon = txtThoiGianHaKhuon.Text;
                    string thoigianchaymay = txtThoiGianChayMay.Text;
                    string thoigiandungmay = txtThoiGianDungMay.Text;
                    string songuoithaotac = txtSoNguoiThaoTac.Text;
                    string thoigianlennhietmayduc = txtThoiGianLenNhietMayDuc.Text;
                    string thoigianlennhiethotrunner = txtThoiGianLenNhietHotRunner.Text;
                    string thoigianlennhietkhuon = txtThoiGianLenNhietKhuon.Text;
                    string thoigianvesinhmaysay = txtThoiGianVeSinhMaySay.Text;
                    string trongluongsanpham = txtTrongLuongSanPham.Text;
                    string trongluongrunnergate = txtTrongLuongRunnerGate.Text;
                    string tongtrongluongsanpham = txtTongTrongLuongSanPham.Text;
                    string soluongfirstshotmotlan = txtSoLuongFirstShotMotLan.Text;
                    QuanlytinhtrangsanxuatDAO.Instance.themdulieu(malinhkien, tenlinhkien, tilenhuanghientrenbanve, tilenhuanghiendathunghiemok, socavity, loaimayduc, cycletime, loainhua, tennguyenlieu, capdonguyenlieu, mamau, nhietdosay, thoigiansay, thoigianupkhuon, thoigianhakhuon, thoigianchaymay, thoigiandungmay, songuoithaotac, thoigianlennhietmayduc, thoigianlennhiethotrunner, thoigianlennhietkhuon, thoigianvesinhmaysay, trongluongsanpham, trongluongrunnergate, tongtrongluongsanpham, soluongfirstshotmotlan);

                    MessageBox.Show("Thêm dữ liệu thành công!");
                    clear();
                }
                catch
                {
                    MessageBox.Show("Không thành công! Lưu ý dấu . (chấm)");
                }
            }
            else
            {

            }

            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRF_Click(object sender, EventArgs e)
        {
            clear();
        }

        void clear()
        {
            txtMaLinhKien.Text = "";
            txtTenLinhKien.Text = "";
            txtTiLeNhuaNghienTrenBanVe.Text = "";
            txtTiLeNhuaNghienDaThuNghiemOK.Text = "";
            txtSoCavity.Text = "";
            txtLoaiMayDuc.Text = "";
            txtCycleTime.Text = "";
            txtLoaiNhua.Text = "";
            txtTenNguyenLieu.Text = "";
            txtCapDoNguyenLieu.Text = "";
            txtMaMau.Text = "";
            txtNhietDoSay.Text = "";
            txtThoiGianSay.Text = "";
            txtThoiGianUpKhuon.Text = "";
            txtThoiGianHaKhuon.Text = "";
            txtThoiGianChayMay.Text = "";
            txtThoiGianDungMay.Text = "";
            txtSoNguoiThaoTac.Text = "";
            txtThoiGianLenNhietMayDuc.Text = "";
            txtThoiGianLenNhietHotRunner.Text = "";
            txtThoiGianLenNhietKhuon.Text = "";
            txtThoiGianVeSinhMaySay.Text = "";
            txtTrongLuongSanPham.Text = "";
            txtTrongLuongRunnerGate.Text = "";
            txtTongTrongLuongSanPham.Text = "";
            txtSoLuongFirstShotMotLan.Text = "";
        }
    }
}

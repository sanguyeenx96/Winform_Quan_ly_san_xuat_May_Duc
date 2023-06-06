using D67.DAO;
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
    public partial class frmXoaDuLieu : Form
    {
        public frmXoaDuLieu()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                string id1 = txtid.Text;
                DataTable load = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.Data WHERE id='" + id1 + "' ");

                string loadmalinhkien;
                string loadtenlinhkien;
                float loadtilenhuanghientrenbanve;
                float loadtilenhuanghiendathunghiemok;
                float loadsocavity;
                float loadloaimayduc;
                float loadcycletime;
                string loadloainhua;
                string loadtennguyenlieu;
                string loadcapdonguyenlieu;
                string loadmamau;
                float loadnhietdosay;
                float loadthoigiansay;
                float loadthoigianupkhuon;
                float loadthoigianhakhuon;
                float loadthoigianchaymay;
                float loadthoigiandungmay;
                float loadsonguoithaotac;
                float loadthoigianlennhietmayduc;
                float loadthoigianlennhiethotrunner;
                float loadthoigianlennhietkhuon;
                float loadthoigianvesinhmaysay;
                float loadtrongluongsanpham;
                float loadtrongluongrunnergate;
                float loadtongtrongluongsanpham;
                float loadsoluongfirstshotmotlan;

                loadmalinhkien = load.Rows[0][1].ToString();
                loadtenlinhkien = load.Rows[0][2].ToString();
                loadtilenhuanghientrenbanve = (float)Convert.ToDouble(load.Rows[0][3].ToString());
                loadtilenhuanghiendathunghiemok = (float)Convert.ToDouble(load.Rows[0][4].ToString());
                loadsocavity = (float)Convert.ToDouble(load.Rows[0][5].ToString());
                loadloaimayduc = (float)Convert.ToDouble(load.Rows[0][6].ToString());
                loadcycletime = (float)Convert.ToDouble(load.Rows[0][7].ToString());
                loadloainhua = load.Rows[0][8].ToString();
                loadtennguyenlieu = load.Rows[0][9].ToString();
                loadcapdonguyenlieu = load.Rows[0][10].ToString();
                loadmamau = load.Rows[0][11].ToString();
                loadnhietdosay = (float)Convert.ToDouble(load.Rows[0][12].ToString());
                loadthoigiansay = (float)Convert.ToDouble(load.Rows[0][13].ToString());
                loadthoigianupkhuon = (float)Convert.ToDouble(load.Rows[0][14].ToString());
                loadthoigianhakhuon = (float)Convert.ToDouble(load.Rows[0][15].ToString());
                loadthoigianchaymay = (float)Convert.ToDouble(load.Rows[0][16].ToString());
                loadthoigiandungmay = (float)Convert.ToDouble(load.Rows[0][17].ToString());
                loadsonguoithaotac = (float)Convert.ToDouble(load.Rows[0][18].ToString());
                loadthoigianlennhietmayduc = (float)Convert.ToDouble(load.Rows[0][19].ToString());
                loadthoigianlennhiethotrunner = (float)Convert.ToDouble(load.Rows[0][20].ToString());
                loadthoigianlennhietkhuon = (float)Convert.ToDouble(load.Rows[0][21].ToString());
                loadthoigianvesinhmaysay = (float)Convert.ToDouble(load.Rows[0][22].ToString());
                loadtrongluongsanpham = (float)Convert.ToDouble(load.Rows[0][23].ToString());
                loadtrongluongrunnergate = (float)Convert.ToDouble(load.Rows[0][24].ToString());
                loadtongtrongluongsanpham = (float)Convert.ToDouble(load.Rows[0][25].ToString());
                loadsoluongfirstshotmotlan = (float)Convert.ToDouble(load.Rows[0][26].ToString());

                textBox1.Text = loadmalinhkien.ToString();
                textBox2.Text = loadtenlinhkien.ToString();
                textBox3.Text = loadtilenhuanghientrenbanve.ToString().Replace(',', '.');
                textBox4.Text = loadtilenhuanghiendathunghiemok.ToString().Replace(',', '.');
                textBox5.Text = loadsocavity.ToString().Replace(',', '.');
                textBox6.Text = loadloaimayduc.ToString().Replace(',', '.');
                textBox7.Text = loadcycletime.ToString().Replace(',', '.');
                textBox8.Text = loadloainhua.ToString();
                textBox9.Text = loadtennguyenlieu.ToString();
                textBox10.Text = loadcapdonguyenlieu.ToString();
                textBox11.Text = loadmamau.ToString();
                textBox12.Text = loadnhietdosay.ToString().Replace(',', '.');
                textBox13.Text = loadthoigiansay.ToString().Replace(',', '.');
                textBox14.Text = loadthoigianupkhuon.ToString().Replace(',', '.');
                textBox15.Text = loadthoigianhakhuon.ToString().Replace(',', '.');
                textBox16.Text = loadthoigianchaymay.ToString().Replace(',', '.');
                textBox17.Text = loadthoigiandungmay.ToString().Replace(',', '.');
                textBox18.Text = loadsonguoithaotac.ToString().Replace(',', '.');
                textBox19.Text = loadthoigianlennhietmayduc.ToString().Replace(',', '.');
                textBox20.Text = loadthoigianlennhiethotrunner.ToString().Replace(',', '.');
                textBox21.Text = loadthoigianlennhietkhuon.ToString().Replace(',', '.');
                textBox22.Text = loadthoigianvesinhmaysay.ToString().Replace(',', '.');
                textBox23.Text = loadtrongluongsanpham.ToString().Replace(',', '.');
                textBox24.Text = loadtrongluongrunnergate.ToString().Replace(',', '.');
                textBox25.Text = loadtongtrongluongsanpham.ToString().Replace(',', '.');
                textBox26.Text = loadsoluongfirstshotmotlan.ToString().Replace(',', '.');
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu tương ứng với ID vừa nhập!");
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Xác nhận xoá dữ liệu?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                string id1 = txtid.Text;
                DataProvider.Instance.ExecuteQuery("DELETE FROM dbo.Data WHERE id='" + id1 + "' ");
                MessageBox.Show("Đã xoá thành công!");
                refresh();
            }
        }
        void refresh()
        {
            txtid.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            textBox24.Text = "";
            textBox25.Text = "";
            textBox26.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

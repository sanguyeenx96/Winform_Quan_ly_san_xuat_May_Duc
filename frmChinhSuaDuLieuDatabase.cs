using Quanlytinhtrangsanxuat.DAO;
using QuanLyTinhTrangSanXuat.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace D67
{
    public partial class frmChinhSuaDuLieuDatabase : Form
    {
        public frmChinhSuaDuLieuDatabase()
        {
            InitializeComponent();
        }

        private void frmChinhSuaDuLieuDatabase_Load(object sender, EventArgs e)
        {
            List<DataDTO> TableList = QuanlytinhtrangsanxuatDAO.Instance.LoadTableList();
            dataGridView1.DataSource = TableList;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (frmThemDuLieu frmThemDuLieu = new frmThemDuLieu())
            {
                frmThemDuLieu.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (frmSuaDuLieu frmSuaDuLieu = new frmSuaDuLieu())
            {
                frmSuaDuLieu.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (frmXoaDuLieu frmXoaDuLieu = new frmXoaDuLieu())
            {
                frmXoaDuLieu.ShowDialog();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            List<DataDTO> TableList = QuanlytinhtrangsanxuatDAO.Instance.LoadTableList();
            dataGridView1.DataSource = TableList;
        }
    }
}

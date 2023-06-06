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
    public partial class frmLoginChinhSuaDuLieuDatabase : Form
    {
        public frmLoginChinhSuaDuLieuDatabase()
        {
            InitializeComponent();
        }

        private void frmLoginChinhSuaDuLieuDatabase_Load(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtPass.Focus();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPass.Text == "246139")
                {
                    
                    using (frmChinhSuaDuLieuDatabase frmChinhSuaDuLieuDatabase = new frmChinhSuaDuLieuDatabase())
                    {
                        frmChinhSuaDuLieuDatabase.ShowDialog();
                    }
                    this.Close();

                }
                else
                {
                    MessageBox.Show("SAI MẬT KHẨU!");
                }
            }
        }
    }
}

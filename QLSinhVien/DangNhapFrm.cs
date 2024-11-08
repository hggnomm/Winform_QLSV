using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class DangNhapFrm : Form
    {
        public DangNhapFrm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            bool isFound = false;
            foreach(var dn in DataProvider.DangNhaps)
            {
                if(dn.TaiKhoan == tenDangNhap && dn.MatKhau == matKhau)
                {
                    isFound = true;
                    break;
                } 
            }

            if (isFound)
            {
                MainFrm f = new MainFrm();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DangNhapFrm_Load(object sender, EventArgs e)
        {
            DataProvider.GetAllDangNhap();
        }
    }
}

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
    public partial class MainFrm : Form
    {
        DataTable dt = new DataTable();
        public MainFrm()
        {
            InitializeComponent();
            dtgvMH.SelectionChanged += dtgvMH_SelectionChanged; // Đăng ký sự kiện SelectionChanged

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu });
            ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            txtMaMH.Enabled = true; // Cho phép chỉnh sửa mã môn học
            btnLuu.Enabled = true; // Cho phép bấm nút Lưu
            txtMaMH.Focus();
        }

        private void EnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = true;
            }
        } 
        private void UnEnableControls(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Enabled = false;
            }
        }

        private void ResetText(List<Control> controls)
        {
            foreach (Control control in controls)
            {
                control.Text = "";
            }
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            // query get all data

            // Set view form AutoSizeColumnsMode - SelectionMode - AllowTable.........
            LoadTableMonHoc();

        }
        private void LoadTableMonHoc()
        {
            string query = "select * from MonHoc";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvMH.DataSource = dt;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maMH = txtMaMH.Text;
            string tenMH = txtTenMH.Text;
            string soTiet = txtSoTiet.Text;
            string query = $"insert into MonHoc (MaMH, TenMH, SoTiet) VALUES ('{maMH}', '{tenMH}', {soTiet});";

            int kq = DataProvider.ThaoTacCSDL(query);
            if (kq > 0) {
                MessageBox.Show("Thêm môn học thành công!");
                LoadTableMonHoc();
                UnEnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu });
                ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            } else
            {
                MessageBox.Show("Không thể thêm môn học");
            }

        }
        private void dtgvMH_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgvMH.SelectedRows.Count > 0)
            {
                var dongDuocChon = dtgvMH.SelectedRows[0];

                // Pass values to textboxes
                txtMaMH.Text = dongDuocChon.Cells["MaMH"].Value.ToString();
                txtTenMH.Text = dongDuocChon.Cells["TenMH"].Value.ToString();
                txtSoTiet.Text = dongDuocChon.Cells["SoTiet"].Value.ToString();

                // Disable txtMaMH and btnLuu
                txtMaMH.Enabled = false;
                btnLuu.Enabled = false;

                // Enable other controls for editing
                EnableControls(new List<Control> { txtSoTiet, txtTenMH, btnXoa, btnSua });
            }
        }

        private void dtgvMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvMH.SelectedRows.Count > 0)
            {
                var dongDuocChon = dtgvMH.SelectedRows[0];

                // Pass values to textboxes
                txtMaMH.Text = dongDuocChon.Cells["MaMH"].Value.ToString();
                txtTenMH.Text = dongDuocChon.Cells["TenMH"].Value.ToString();
                txtSoTiet.Text = dongDuocChon.Cells["SoTiet"].Value.ToString();

                // Disable txtMaMH and btnLuu
                txtMaMH.Enabled = false;
                btnLuu.Enabled = false;

                // Enable other controls for editing
                EnableControls(new List<Control> { txtSoTiet, txtTenMH, btnXoa, btnSua });
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaMH = txtMaMH.Text;
            string tenMH = txtTenMH.Text;
            string soTiet = txtSoTiet.Text;

            // Kiểm tra xem số tiết có phải là số nguyên hợp lệ không
            if (!int.TryParse(soTiet, out _))
            {
                MessageBox.Show("Số tiết phải là số nguyên hợp lệ.");
                return;
            }

            // Thêm dấu nháy đơn quanh MaMH
            string query = $"UPDATE MonHoc SET TenMH = '{tenMH}', SoTiet = {soTiet} WHERE MaMH = '{MaMH}'";

            int kq = DataProvider.ThaoTacCSDL(query);

            if (kq > 0)
            {
                MessageBox.Show("Sửa môn học thành công!");
                LoadTableMonHoc();
                UnEnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu });
                ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
            }
            else
            {
                MessageBox.Show("Không thể sửa môn học");
            }
        }

    }
}

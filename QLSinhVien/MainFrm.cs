﻿using System;
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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            EnableControls(new List<Control> { txtMaMH, txtTenMH, txtSoTiet, btnLuu });
            ResetText(new List<Control> { txtMaMH, txtTenMH, txtSoTiet });
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
    }
}

namespace QLSinhVien
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.comboMaMH = new System.Windows.Forms.ComboBox();
            this.btnTimMHTheoNoiDung = new System.Windows.Forms.Button();
            this.btnTimMHTheoMa = new System.Windows.Forms.Button();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.dtgvMH = new System.Windows.Forms.DataGridView();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnXemDSSV = new System.Windows.Forms.Button();
            this.btnXemDSSVTheoKhoa = new System.Windows.Forms.Button();
            this.btnXemDiem = new System.Windows.Forms.Button();
            this.btnXemDiemTheoMon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã MH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên MH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn mã môn học cần tìm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tíết:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(692, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập từ khoá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(804, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tìm kiếm thông tin";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(156, 90);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(212, 29);
            this.txtMaMH.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(156, 210);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 29);
            this.textBox5.TabIndex = 10;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(156, 150);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(212, 29);
            this.txtTenMH.TabIndex = 10;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(811, 90);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(212, 29);
            this.txtNoiDung.TabIndex = 11;
            // 
            // comboMaMH
            // 
            this.comboMaMH.FormattingEnabled = true;
            this.comboMaMH.Location = new System.Drawing.Point(441, 150);
            this.comboMaMH.Name = "comboMaMH";
            this.comboMaMH.Size = new System.Drawing.Size(189, 29);
            this.comboMaMH.TabIndex = 12;
            this.comboMaMH.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnTimMHTheoNoiDung
            // 
            this.btnTimMHTheoNoiDung.Location = new System.Drawing.Point(850, 139);
            this.btnTimMHTheoNoiDung.Name = "btnTimMHTheoNoiDung";
            this.btnTimMHTheoNoiDung.Size = new System.Drawing.Size(143, 40);
            this.btnTimMHTheoNoiDung.TabIndex = 15;
            this.btnTimMHTheoNoiDung.Text = "Tìm kiếm";
            this.btnTimMHTheoNoiDung.UseVisualStyleBackColor = true;
            // 
            // btnTimMHTheoMa
            // 
            this.btnTimMHTheoMa.Location = new System.Drawing.Point(468, 203);
            this.btnTimMHTheoMa.Name = "btnTimMHTheoMa";
            this.btnTimMHTheoMa.Size = new System.Drawing.Size(143, 40);
            this.btnTimMHTheoMa.TabIndex = 16;
            this.btnTimMHTheoMa.Text = "Tìm kiếm";
            this.btnTimMHTheoMa.UseVisualStyleBackColor = true;
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.Location = new System.Drawing.Point(156, 257);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(143, 40);
            this.btnHienThiTatCa.TabIndex = 17;
            this.btnHienThiTatCa.Text = "Hiển thị tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = true;
            // 
            // dtgvMH
            // 
            this.dtgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMH.Location = new System.Drawing.Point(77, 312);
            this.dtgvMH.Name = "dtgvMH";
            this.dtgvMH.Size = new System.Drawing.Size(977, 216);
            this.dtgvMH.TabIndex = 18;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(83, 552);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 36);
            this.btnThemMoi.TabIndex = 19;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(176, 552);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 36);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(269, 552);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 36);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(362, 552);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 36);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnXemDSSV
            // 
            this.btnXemDSSV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSSV.Location = new System.Drawing.Point(455, 552);
            this.btnXemDSSV.Name = "btnXemDSSV";
            this.btnXemDSSV.Size = new System.Drawing.Size(122, 36);
            this.btnXemDSSV.TabIndex = 23;
            this.btnXemDSSV.Text = "Xem DSSV";
            this.btnXemDSSV.UseVisualStyleBackColor = true;
            // 
            // btnXemDSSVTheoKhoa
            // 
            this.btnXemDSSVTheoKhoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSSVTheoKhoa.Location = new System.Drawing.Point(595, 552);
            this.btnXemDSSVTheoKhoa.Name = "btnXemDSSVTheoKhoa";
            this.btnXemDSSVTheoKhoa.Size = new System.Drawing.Size(141, 36);
            this.btnXemDSSVTheoKhoa.TabIndex = 24;
            this.btnXemDSSVTheoKhoa.Text = "Xem DSSV theo Khoa";
            this.btnXemDSSVTheoKhoa.UseVisualStyleBackColor = true;
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiem.Location = new System.Drawing.Point(754, 552);
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.Size = new System.Drawing.Size(141, 36);
            this.btnXemDiem.TabIndex = 25;
            this.btnXemDiem.Text = "Xem điểm";
            this.btnXemDiem.UseVisualStyleBackColor = true;
            // 
            // btnXemDiemTheoMon
            // 
            this.btnXemDiemTheoMon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiemTheoMon.Location = new System.Drawing.Point(913, 552);
            this.btnXemDiemTheoMon.Name = "btnXemDiemTheoMon";
            this.btnXemDiemTheoMon.Size = new System.Drawing.Size(141, 36);
            this.btnXemDiemTheoMon.TabIndex = 26;
            this.btnXemDiemTheoMon.Text = "Xem điểm theo môn";
            this.btnXemDiemTheoMon.UseVisualStyleBackColor = true;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 611);
            this.Controls.Add(this.btnXemDiemTheoMon);
            this.Controls.Add(this.btnXemDiem);
            this.Controls.Add(this.btnXemDSSVTheoKhoa);
            this.Controls.Add(this.btnXemDSSV);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.dtgvMH);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.btnTimMHTheoMa);
            this.Controls.Add(this.btnTimMHTheoNoiDung);
            this.Controls.Add(this.comboMaMH);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtTenMH);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox comboMaMH;
        private System.Windows.Forms.Button btnTimMHTheoNoiDung;
        private System.Windows.Forms.Button btnTimMHTheoMa;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.DataGridView dtgvMH;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnXemDSSV;
        private System.Windows.Forms.Button btnXemDSSVTheoKhoa;
        private System.Windows.Forms.Button btnXemDiem;
        private System.Windows.Forms.Button btnXemDiemTheoMon;
    }
}

namespace QuanLyDiemSV
{
    partial class frmGiaoVien
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdbTenSV = new System.Windows.Forms.RadioButton();
            this.rdbLop = new System.Windows.Forms.RadioButton();
            this.rdbMaSV = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 290);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1059, 247);
            this.listView1.TabIndex = 29;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.rdbTenSV);
            this.groupBox2.Controls.Add(this.rdbLop);
            this.groupBox2.Controls.Add(this.rdbMaSV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(733, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 87);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc Thông Tin";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 51);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(244, 22);
            this.txtTimKiem.TabIndex = 18;
            // 
            // rdbTenSV
            // 
            this.rdbTenSV.AutoSize = true;
            this.rdbTenSV.ForeColor = System.Drawing.Color.Black;
            this.rdbTenSV.Location = new System.Drawing.Point(200, 25);
            this.rdbTenSV.Name = "rdbTenSV";
            this.rdbTenSV.Size = new System.Drawing.Size(50, 20);
            this.rdbTenSV.TabIndex = 2;
            this.rdbTenSV.TabStop = true;
            this.rdbTenSV.Text = "Tên";
            this.rdbTenSV.UseVisualStyleBackColor = true;
            // 
            // rdbLop
            // 
            this.rdbLop.AutoSize = true;
            this.rdbLop.ForeColor = System.Drawing.Color.Black;
            this.rdbLop.Location = new System.Drawing.Point(102, 25);
            this.rdbLop.Name = "rdbLop";
            this.rdbLop.Size = new System.Drawing.Size(49, 20);
            this.rdbLop.TabIndex = 1;
            this.rdbLop.TabStop = true;
            this.rdbLop.Text = "Lớp";
            this.rdbLop.UseVisualStyleBackColor = true;
            // 
            // rdbMaSV
            // 
            this.rdbMaSV.AutoSize = true;
            this.rdbMaSV.ForeColor = System.Drawing.Color.Black;
            this.rdbMaSV.Location = new System.Drawing.Point(6, 25);
            this.rdbMaSV.Name = "rdbMaSV";
            this.rdbMaSV.Size = new System.Drawing.Size(48, 20);
            this.rdbMaSV.TabIndex = 0;
            this.rdbMaSV.TabStop = true;
            this.rdbMaSV.Text = "Mã ";
            this.rdbMaSV.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(312, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 24;
            this.label1.Text = "CẬP NHẬT GIÁO VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoTenGV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaGV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1059, 141);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giáo viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(803, 25);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(250, 22);
            this.txtSDT.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(724, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Điện Thoại";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(453, 87);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(255, 22);
            this.txtEmail.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(374, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Email";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Location = new System.Drawing.Point(98, 87);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(255, 24);
            this.cboGioiTinh.TabIndex = 18;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(453, 55);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(255, 22);
            this.txtPassword.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(374, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(453, 25);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(255, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(374, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giới Tính";
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.Location = new System.Drawing.Point(98, 54);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.Size = new System.Drawing.Size(255, 22);
            this.txtHoTenGV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(98, 25);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(255, 22);
            this.txtMaGV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Giáo Viên";
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyDiemSV.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(190, 215);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 34);
            this.btnSua.TabIndex = 32;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyDiemSV.Properties.Resources.add1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(59, 215);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 34);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.ForeColor = System.Drawing.Color.Black;
            this.btnLoc.Image = global::QuanLyDiemSV.Properties.Resources.search_blue;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(256, 50);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(76, 25);
            this.btnLoc.TabIndex = 10;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyDiemSV.Properties.Resources.cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(579, 215);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 34);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyDiemSV.Properties.Resources.Save_icon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(448, 215);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 34);
            this.btnLuu.TabIndex = 26;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyDiemSV.Properties.Resources.close_red;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(318, 215);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 34);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Image = global::QuanLyDiemSV.Properties.Resources.Thoat2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(905, 72);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 34);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::QuanLyDiemSV.Properties.Resources.reload;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(778, 72);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 34);
            this.btnRefresh.TabIndex = 30;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // frmGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1089, 545);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1105, 584);
            this.Name = "frmGiaoVien";
            this.Text = "Cập nhật giáo viên";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdbTenSV;
        private System.Windows.Forms.RadioButton rdbLop;
        private System.Windows.Forms.RadioButton rdbMaSV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label8;
    }
}
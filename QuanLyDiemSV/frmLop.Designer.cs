
namespace QuanLyDiemSV
{
    partial class frmLop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaGV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cboMaHP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.MaMH = new System.Windows.Forms.TextBox();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdbMaGV = new System.Windows.Forms.RadioButton();
            this.rdbMaMH = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "CẬP NHẬT LỚP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaGV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboMaMH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numSoLuong);
            this.groupBox1.Controls.Add(this.cboMaHP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(792, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 158);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tạo lớp";
            // 
            // cboMaGV
            // 
            this.cboMaGV.FormattingEnabled = true;
            this.cboMaGV.Location = new System.Drawing.Point(96, 127);
            this.cboMaGV.Name = "cboMaGV";
            this.cboMaGV.Size = new System.Drawing.Size(124, 24);
            this.cboMaGV.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mã Giáo Viên";
            // 
            // cboMaMH
            // 
            this.cboMaMH.FormattingEnabled = true;
            this.cboMaMH.Location = new System.Drawing.Point(96, 92);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(124, 24);
            this.cboMaMH.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Mã Môn Học";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(96, 57);
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(124, 22);
            this.numSoLuong.TabIndex = 17;
            // 
            // cboMaHP
            // 
            this.cboMaHP.FormattingEnabled = true;
            this.cboMaHP.Location = new System.Drawing.Point(96, 24);
            this.cboMaHP.Name = "cboMaHP";
            this.cboMaHP.Size = new System.Drawing.Size(124, 24);
            this.cboMaHP.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số Lượng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Mã Học Phần";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTenGV);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMaGV);
            this.groupBox2.Controls.Add(this.txtTenMH);
            this.groupBox2.Controls.Add(this.MaMH);
            this.groupBox2.Controls.Add(this.txtMaHP);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(51, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(705, 131);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tạo lớp";
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(459, 59);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(238, 22);
            this.txtTenGV.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(364, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "Tên Giáo Viên";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(459, 24);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(238, 22);
            this.txtMaGV.TabIndex = 24;
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(101, 92);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(238, 22);
            this.txtTenMH.TabIndex = 23;
            // 
            // MaMH
            // 
            this.MaMH.Location = new System.Drawing.Point(101, 56);
            this.MaMH.Name = "MaMH";
            this.MaMH.Size = new System.Drawing.Size(238, 22);
            this.MaMH.TabIndex = 22;
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(101, 24);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(238, 22);
            this.txtMaHP.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(364, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Mã Giáo Viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Tên Môn Học";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Mã Môn Học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mã Học Phần";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnRefresh);
            this.groupBox3.Controls.Add(this.btnLoc);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Controls.Add(this.rdbMaGV);
            this.groupBox3.Controls.Add(this.rdbMaMH);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(762, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 131);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::QuanLyDiemSV.Properties.Resources.reload;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(145, 88);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 30);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.ForeColor = System.Drawing.Color.Black;
            this.btnLoc.Image = global::QuanLyDiemSV.Properties.Resources.search_blue;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(34, 88);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(93, 30);
            this.btnLoc.TabIndex = 28;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(6, 56);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(265, 22);
            this.txtTimKiem.TabIndex = 27;
            // 
            // rdbMaGV
            // 
            this.rdbMaGV.AutoSize = true;
            this.rdbMaGV.ForeColor = System.Drawing.Color.Black;
            this.rdbMaGV.Location = new System.Drawing.Point(130, 28);
            this.rdbMaGV.Name = "rdbMaGV";
            this.rdbMaGV.Size = new System.Drawing.Size(107, 20);
            this.rdbMaGV.TabIndex = 3;
            this.rdbMaGV.TabStop = true;
            this.rdbMaGV.Text = "Mã Giáo Viên";
            this.rdbMaGV.UseVisualStyleBackColor = true;
            // 
            // rdbMaMH
            // 
            this.rdbMaMH.AutoSize = true;
            this.rdbMaMH.ForeColor = System.Drawing.Color.Black;
            this.rdbMaMH.Location = new System.Drawing.Point(6, 28);
            this.rdbMaMH.Name = "rdbMaMH";
            this.rdbMaMH.Size = new System.Drawing.Size(102, 20);
            this.rdbMaMH.TabIndex = 2;
            this.rdbMaMH.TabStop = true;
            this.rdbMaMH.Text = "Mã Môn Học";
            this.rdbMaMH.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(51, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(735, 278);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách lớp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 257);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyDiemSV.Properties.Resources.Thoat2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(924, 430);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 34);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyDiemSV.Properties.Resources.cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(792, 430);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 34);
            this.btnHuy.TabIndex = 34;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyDiemSV.Properties.Resources.Save_icon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(924, 390);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 34);
            this.btnLuu.TabIndex = 33;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyDiemSV.Properties.Resources.close_red;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(792, 390);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 34);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyDiemSV.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(924, 350);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 34);
            this.btnSua.TabIndex = 31;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyDiemSV.Properties.Resources.add1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(792, 350);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 34);
            this.btnThem.TabIndex = 30;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1072, 480);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.MinimumSize = new System.Drawing.Size(1088, 519);
            this.Name = "frmLop";
            this.Text = "Cập nhật lớp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboMaHP;
        private System.Windows.Forms.ComboBox cboMaGV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMaMH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox MaMH;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbMaGV;
        private System.Windows.Forms.RadioButton rdbMaMH;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}

namespace QuanLyDiemSV
{
    partial class frmNhapDiem
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
            this.txtDiemTH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiemLT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboMaLop = new System.Windows.Forms.ComboBox();
            this.cboTenMH = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbTenMH = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdbTenSV = new System.Windows.Forms.RadioButton();
            this.rdbMaSV = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "CẬP NHẬT ĐIỂM SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDiemTH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDiemLT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboMaLop);
            this.groupBox1.Controls.Add(this.cboTenMH);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(38, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(653, 133);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm sinh viên";
            // 
            // txtDiemTH
            // 
            this.txtDiemTH.Location = new System.Drawing.Point(435, 54);
            this.txtDiemTH.Name = "txtDiemTH";
            this.txtDiemTH.Size = new System.Drawing.Size(203, 22);
            this.txtDiemTH.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(326, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Điểm Thực Hành";
            // 
            // txtDiemLT
            // 
            this.txtDiemLT.Location = new System.Drawing.Point(435, 25);
            this.txtDiemLT.Name = "txtDiemLT";
            this.txtDiemLT.Size = new System.Drawing.Size(203, 22);
            this.txtDiemLT.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(326, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Điểm Lý Thuyết ";
            // 
            // cboMaLop
            // 
            this.cboMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaLop.FormattingEnabled = true;
            this.cboMaLop.Location = new System.Drawing.Point(98, 88);
            this.cboMaLop.Name = "cboMaLop";
            this.cboMaLop.Size = new System.Drawing.Size(203, 24);
            this.cboMaLop.TabIndex = 20;
            // 
            // cboTenMH
            // 
            this.cboTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenMH.FormattingEnabled = true;
            this.cboTenMH.Location = new System.Drawing.Point(98, 54);
            this.cboTenMH.Name = "cboTenMH";
            this.cboTenMH.Size = new System.Drawing.Size(203, 24);
            this.cboTenMH.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Môn Học";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(98, 25);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(203, 22);
            this.txtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Sinh Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbTenMH);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.rdbTenSV);
            this.groupBox2.Controls.Add(this.rdbMaSV);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(697, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 133);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // rdbTenMH
            // 
            this.rdbTenMH.AutoSize = true;
            this.rdbTenMH.ForeColor = System.Drawing.Color.Black;
            this.rdbTenMH.Location = new System.Drawing.Point(6, 89);
            this.rdbTenMH.Name = "rdbTenMH";
            this.rdbTenMH.Size = new System.Drawing.Size(107, 20);
            this.rdbTenMH.TabIndex = 13;
            this.rdbTenMH.TabStop = true;
            this.rdbTenMH.Text = "Tên Môn Học";
            this.rdbTenMH.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::QuanLyDiemSV.Properties.Resources.reload;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(235, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnLoc
            // 
            this.btnLoc.ForeColor = System.Drawing.Color.Black;
            this.btnLoc.Image = global::QuanLyDiemSV.Properties.Resources.search_blue;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(116, 67);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(93, 30);
            this.btnLoc.TabIndex = 11;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(116, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(233, 22);
            this.txtTimKiem.TabIndex = 10;
            // 
            // rdbTenSV
            // 
            this.rdbTenSV.AutoSize = true;
            this.rdbTenSV.ForeColor = System.Drawing.Color.Black;
            this.rdbTenSV.Location = new System.Drawing.Point(6, 55);
            this.rdbTenSV.Name = "rdbTenSV";
            this.rdbTenSV.Size = new System.Drawing.Size(109, 20);
            this.rdbTenSV.TabIndex = 2;
            this.rdbTenSV.TabStop = true;
            this.rdbTenSV.Text = "Tên Sinh Viên";
            this.rdbTenSV.UseVisualStyleBackColor = true;
            // 
            // rdbMaSV
            // 
            this.rdbMaSV.AutoSize = true;
            this.rdbMaSV.ForeColor = System.Drawing.Color.Black;
            this.rdbMaSV.Location = new System.Drawing.Point(6, 21);
            this.rdbMaSV.Name = "rdbMaSV";
            this.rdbMaSV.Size = new System.Drawing.Size(104, 20);
            this.rdbMaSV.TabIndex = 1;
            this.rdbMaSV.TabStop = true;
            this.rdbMaSV.Text = "Mã Sinh Viên";
            this.rdbMaSV.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(38, 247);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1016, 322);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng điểm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyDiemSV.Properties.Resources.Thoat2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(841, 198);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 34);
            this.btnThoat.TabIndex = 35;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyDiemSV.Properties.Resources.add1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(123, 198);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 34);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyDiemSV.Properties.Resources.cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(696, 198);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 34);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyDiemSV.Properties.Resources.Save_icon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(554, 198);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 34);
            this.btnLuu.TabIndex = 32;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyDiemSV.Properties.Resources.close_red;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(409, 198);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 34);
            this.btnXoa.TabIndex = 31;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyDiemSV.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(262, 198);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 34);
            this.btnSua.TabIndex = 30;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // frmNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1071, 575);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1087, 614);
            this.Name = "frmNhapDiem";
            this.Text = "Cập nhật điểm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDiemTH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiemLT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboMaLop;
        private System.Windows.Forms.ComboBox cboTenMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbTenMH;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdbTenSV;
        private System.Windows.Forms.RadioButton rdbMaSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
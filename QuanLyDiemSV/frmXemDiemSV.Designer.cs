
namespace QuanLyDiemSV
{
    partial class frmXemDiemSV
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbMaHP = new System.Windows.Forms.RadioButton();
            this.rdbMaLop = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdbTenMH = new System.Windows.Forms.RadioButton();
            this.rdbMaMH = new System.Windows.Forms.RadioButton();
            this.dgvBangDiemSV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiemSV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(366, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "KẾT QUẢ HỌC TẬP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbMaHP);
            this.groupBox2.Controls.Add(this.rdbMaLop);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnMoi);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.rdbTenMH);
            this.groupBox2.Controls.Add(this.rdbMaMH);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(284, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(472, 167);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // rdbMaHP
            // 
            this.rdbMaHP.AutoSize = true;
            this.rdbMaHP.ForeColor = System.Drawing.Color.Black;
            this.rdbMaHP.Location = new System.Drawing.Point(25, 131);
            this.rdbMaHP.Name = "rdbMaHP";
            this.rdbMaHP.Size = new System.Drawing.Size(107, 20);
            this.rdbMaHP.TabIndex = 19;
            this.rdbMaHP.TabStop = true;
            this.rdbMaHP.Text = "Mã Học Phần";
            this.rdbMaHP.UseVisualStyleBackColor = true;
            // 
            // rdbMaLop
            // 
            this.rdbMaLop.AutoSize = true;
            this.rdbMaLop.ForeColor = System.Drawing.Color.Black;
            this.rdbMaLop.Location = new System.Drawing.Point(25, 96);
            this.rdbMaLop.Name = "rdbMaLop";
            this.rdbMaLop.Size = new System.Drawing.Size(71, 20);
            this.rdbMaLop.TabIndex = 18;
            this.rdbMaLop.TabStop = true;
            this.rdbMaLop.Text = "Mã Lớp";
            this.rdbMaLop.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::QuanLyDiemSV.Properties.Resources.reload;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(311, 96);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 30);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnMoi
            // 
            this.btnMoi.ForeColor = System.Drawing.Color.Black;
            this.btnMoi.Image = global::QuanLyDiemSV.Properties.Resources.search_blue;
            this.btnMoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMoi.Location = new System.Drawing.Point(191, 96);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(93, 30);
            this.btnMoi.TabIndex = 16;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(151, 55);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(305, 22);
            this.txtTimKiem.TabIndex = 15;
            // 
            // rdbTenMH
            // 
            this.rdbTenMH.AutoSize = true;
            this.rdbTenMH.ForeColor = System.Drawing.Color.Black;
            this.rdbTenMH.Location = new System.Drawing.Point(25, 63);
            this.rdbTenMH.Name = "rdbTenMH";
            this.rdbTenMH.Size = new System.Drawing.Size(107, 20);
            this.rdbTenMH.TabIndex = 14;
            this.rdbTenMH.TabStop = true;
            this.rdbTenMH.Text = "Tên Môn Học";
            this.rdbTenMH.UseVisualStyleBackColor = true;
            // 
            // rdbMaMH
            // 
            this.rdbMaMH.AutoSize = true;
            this.rdbMaMH.ForeColor = System.Drawing.Color.Black;
            this.rdbMaMH.Location = new System.Drawing.Point(25, 31);
            this.rdbMaMH.Name = "rdbMaMH";
            this.rdbMaMH.Size = new System.Drawing.Size(102, 20);
            this.rdbMaMH.TabIndex = 13;
            this.rdbMaMH.TabStop = true;
            this.rdbMaMH.Text = "Mã Môn Học";
            this.rdbMaMH.UseVisualStyleBackColor = true;
            // 
            // dgvBangDiemSV
            // 
            this.dgvBangDiemSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangDiemSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvBangDiemSV.Location = new System.Drawing.Point(37, 250);
            this.dgvBangDiemSV.Name = "dgvBangDiemSV";
            this.dgvBangDiemSV.Size = new System.Drawing.Size(988, 327);
            this.dgvBangDiemSV.TabIndex = 19;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Môn Học";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Môn Học";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã Lớp";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Mã Học Phần";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Điểm Lý Thuyết";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Điểm Thực Hành";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Điểm Trung Bình";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Điểm Hệ 4";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Đánh Giá";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // frmXemDiemSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1056, 589);
            this.Controls.Add(this.dgvBangDiemSV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1072, 628);
            this.Name = "frmXemDiemSV";
            this.Text = "Xem điểm sinh viên";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangDiemSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbMaHP;
        private System.Windows.Forms.RadioButton rdbMaLop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdbTenMH;
        private System.Windows.Forms.RadioButton rdbMaMH;
        private System.Windows.Forms.DataGridView dgvBangDiemSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}
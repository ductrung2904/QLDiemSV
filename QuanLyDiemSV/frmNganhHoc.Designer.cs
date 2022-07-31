
namespace QuanLyDiemSV
{
    partial class frmNganhHoc
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdbTenNganh = new System.Windows.Forms.RadioButton();
            this.rdbMaNganh = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errMaNganh = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenNganh = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNganh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 37);
            this.label1.TabIndex = 15;
            this.label1.Text = "CẬP NHẬT NGÀNH HỌC";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(107, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 289);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách ngành học";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(493, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNganh";
            this.Column1.HeaderText = "Mã Ngành";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNganh";
            this.Column2.HeaderText = "Tên Ngành";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Controls.Add(this.btnLoc);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.rdbTenNganh);
            this.groupBox2.Controls.Add(this.rdbMaNganh);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(618, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 94);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.Image = global::QuanLyDiemSV.Properties.Resources.reload;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(219, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(114, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.ForeColor = System.Drawing.Color.Black;
            this.btnLoc.Image = global::QuanLyDiemSV.Properties.Resources.search_blue;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(100, 47);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(93, 30);
            this.btnLoc.TabIndex = 11;
            this.btnLoc.Text = "Mới";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(100, 20);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(233, 22);
            this.txtTimKiem.TabIndex = 10;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rdbTenNganh
            // 
            this.rdbTenNganh.AutoSize = true;
            this.rdbTenNganh.ForeColor = System.Drawing.Color.Black;
            this.rdbTenNganh.Location = new System.Drawing.Point(6, 47);
            this.rdbTenNganh.Name = "rdbTenNganh";
            this.rdbTenNganh.Size = new System.Drawing.Size(93, 20);
            this.rdbTenNganh.TabIndex = 2;
            this.rdbTenNganh.TabStop = true;
            this.rdbTenNganh.Text = "Tên Ngành";
            this.rdbTenNganh.UseVisualStyleBackColor = true;
            // 
            // rdbMaNganh
            // 
            this.rdbMaNganh.AutoSize = true;
            this.rdbMaNganh.ForeColor = System.Drawing.Color.Black;
            this.rdbMaNganh.Location = new System.Drawing.Point(6, 21);
            this.rdbMaNganh.Name = "rdbMaNganh";
            this.rdbMaNganh.Size = new System.Drawing.Size(88, 20);
            this.rdbMaNganh.TabIndex = 1;
            this.rdbMaNganh.TabStop = true;
            this.rdbMaNganh.Text = "Mã Ngành";
            this.rdbMaNganh.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTenNganh);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtMaNganh);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(618, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(339, 94);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin ngành học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tên Ngành";
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Location = new System.Drawing.Point(100, 51);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(233, 22);
            this.txtTenNganh.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Ngành";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(100, 21);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(233, 22);
            this.txtMaNganh.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyDiemSV.Properties.Resources.add1;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(618, 249);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(109, 34);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyDiemSV.Properties.Resources.edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(733, 249);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(109, 34);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyDiemSV.Properties.Resources.close_red;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(848, 249);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(109, 34);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyDiemSV.Properties.Resources.Save_icon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(618, 298);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(109, 34);
            this.btnLuu.TabIndex = 27;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = global::QuanLyDiemSV.Properties.Resources.cancel;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(733, 298);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(109, 34);
            this.btnHuy.TabIndex = 28;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyDiemSV.Properties.Resources.Thoat2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(848, 298);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 34);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errMaNganh
            // 
            this.errMaNganh.ContainerControl = this;
            // 
            // errTenNganh
            // 
            this.errTenNganh.ContainerControl = this;
            // 
            // frmNganhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1049, 352);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(886, 391);
            this.Name = "frmNganhHoc";
            this.Text = "Cập nhật ngành học";
            this.Load += new System.EventHandler(this.frmNganhHoc_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaNganh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenNganh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbTenNganh;
        private System.Windows.Forms.RadioButton rdbMaNganh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNganh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ErrorProvider errMaNganh;
        private System.Windows.Forms.ErrorProvider errTenNganh;
    }
}
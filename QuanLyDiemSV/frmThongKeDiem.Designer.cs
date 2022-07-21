
namespace QuanLyDiemSV
{
    partial class frmThongKeDiem
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cboThongKe1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.cboThongKe2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cboThongKe3 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rdbTenSV = new System.Windows.Forms.RadioButton();
            this.rdbMaSV = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.cboThongKe4 = new System.Windows.Forms.ComboBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(55, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 514);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.btnLoc);
            this.tabPage1.Controls.Add(this.cboThongKe1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(961, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê điểm theo lớp";
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.Black;
            this.btnLoc.Image = global::QuanLyDiemSV.Properties.Resources.search_blue;
            this.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoc.Location = new System.Drawing.Point(343, 10);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(109, 30);
            this.btnLoc.TabIndex = 22;
            this.btnLoc.Text = "Xem";
            this.btnLoc.UseVisualStyleBackColor = true;
            // 
            // cboThongKe1
            // 
            this.cboThongKe1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThongKe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThongKe1.FormattingEnabled = true;
            this.cboThongKe1.Location = new System.Drawing.Point(116, 14);
            this.cboThongKe1.Name = "cboThongKe1";
            this.cboThongKe1.Size = new System.Drawing.Size(203, 24);
            this.cboThongKe1.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(34, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mã Lớp";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 436);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.cboThongKe2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(961, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê điểm theo môn học";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::QuanLyDiemSV.Properties.Resources.search_blue;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(344, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 30);
            this.button1.TabIndex = 26;
            this.button1.Text = "Xem";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboThongKe2
            // 
            this.cboThongKe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThongKe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThongKe2.FormattingEnabled = true;
            this.cboThongKe2.Location = new System.Drawing.Point(117, 14);
            this.cboThongKe2.Name = "cboThongKe2";
            this.cboThongKe2.Size = new System.Drawing.Size(203, 24);
            this.cboThongKe2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Môn Học";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(948, 438);
            this.dataGridView2.TabIndex = 23;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Teal;
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.cboThongKe3);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(961, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thống kê điểm theo ngành học";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::QuanLyDiemSV.Properties.Resources.search_blue;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(343, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 30);
            this.button2.TabIndex = 30;
            this.button2.Text = "Xem";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cboThongKe3
            // 
            this.cboThongKe3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThongKe3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThongKe3.FormattingEnabled = true;
            this.cboThongKe3.Location = new System.Drawing.Point(116, 12);
            this.cboThongKe3.Name = "cboThongKe3";
            this.cboThongKe3.Size = new System.Drawing.Size(203, 24);
            this.cboThongKe3.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(34, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ngành Học";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 42);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(949, 440);
            this.dataGridView3.TabIndex = 27;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Teal;
            this.tabPage4.Controls.Add(this.rdbTenSV);
            this.tabPage4.Controls.Add(this.rdbMaSV);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.cboThongKe4);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(961, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Thống kê điểm theo mã/tên sinh viên";
            // 
            // rdbTenSV
            // 
            this.rdbTenSV.AutoSize = true;
            this.rdbTenSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTenSV.ForeColor = System.Drawing.Color.White;
            this.rdbTenSV.Location = new System.Drawing.Point(137, 13);
            this.rdbTenSV.Name = "rdbTenSV";
            this.rdbTenSV.Size = new System.Drawing.Size(109, 20);
            this.rdbTenSV.TabIndex = 32;
            this.rdbTenSV.TabStop = true;
            this.rdbTenSV.Text = "Tên Sinh Viên";
            this.rdbTenSV.UseVisualStyleBackColor = true;
            // 
            // rdbMaSV
            // 
            this.rdbMaSV.AutoSize = true;
            this.rdbMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaSV.ForeColor = System.Drawing.Color.White;
            this.rdbMaSV.Location = new System.Drawing.Point(16, 13);
            this.rdbMaSV.Name = "rdbMaSV";
            this.rdbMaSV.Size = new System.Drawing.Size(104, 20);
            this.rdbMaSV.TabIndex = 31;
            this.rdbMaSV.TabStop = true;
            this.rdbMaSV.Text = "Mã Sinh Viên";
            this.rdbMaSV.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::QuanLyDiemSV.Properties.Resources.search_blue;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(461, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 30);
            this.button3.TabIndex = 30;
            this.button3.Text = "Xem";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cboThongKe4
            // 
            this.cboThongKe4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThongKe4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThongKe4.FormattingEnabled = true;
            this.cboThongKe4.Location = new System.Drawing.Point(252, 12);
            this.cboThongKe4.Name = "cboThongKe4";
            this.cboThongKe4.Size = new System.Drawing.Size(203, 24);
            this.cboThongKe4.TabIndex = 29;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 42);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(949, 438);
            this.dataGridView4.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(319, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 37);
            this.label1.TabIndex = 18;
            this.label1.Text = "THỐNG KÊ ĐIỂM SINH VIÊN";
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyDiemSV.Properties.Resources.Thoat2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(915, 31);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 34);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmThongKeDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1070, 563);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1086, 602);
            this.Name = "frmThongKeDiem";
            this.Text = "Thống kê điểm sinh viên";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox cboThongKe1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboThongKe2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cboThongKe3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cboThongKe4;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.RadioButton rdbTenSV;
        private System.Windows.Forms.RadioButton rdbMaSV;
    }
}
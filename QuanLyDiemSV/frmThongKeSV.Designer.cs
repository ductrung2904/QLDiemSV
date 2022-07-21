
namespace QuanLyDiemSV
{
    partial class frmThongKeSV
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "THỐNG KÊ SINH VIÊN";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(50, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(973, 513);
            this.tabControl1.TabIndex = 17;
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
            this.tabPage1.Size = new System.Drawing.Size(965, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thống kê sinh viên theo ngành học";
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
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngành Học";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(956, 436);
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
            this.tabPage2.Size = new System.Drawing.Size(965, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thống kê sinh viên theo lớp";
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
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mã Lớp";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 44);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(952, 436);
            this.dataGridView2.TabIndex = 23;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::QuanLyDiemSV.Properties.Resources.Thoat2;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(914, 31);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 34);
            this.btnThoat.TabIndex = 36;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmThongKeSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1070, 563);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(1086, 602);
            this.Name = "frmThongKeSV";
            this.Text = "Thống kê sinh viên";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboThongKe1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboThongKe2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
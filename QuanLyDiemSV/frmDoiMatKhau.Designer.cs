
namespace QuanLyDiemSV
{
    partial class frmDoiMatKhau
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chbAnHienMatKhau = new System.Windows.Forms.CheckBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errMatKhauMoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMatKhau = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMatKhauMoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(78, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 37);
            this.label5.TabIndex = 33;
            this.label5.Text = "ĐỔI MẬT KHẨU";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(229, 222);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(111, 39);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Location = new System.Drawing.Point(76, 222);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(111, 39);
            this.btnDoiMatKhau.TabIndex = 31;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = true;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Mật khẩu:";
            // 
            // chbAnHienMatKhau
            // 
            this.chbAnHienMatKhau.AutoSize = true;
            this.chbAnHienMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAnHienMatKhau.Location = new System.Drawing.Point(201, 194);
            this.chbAnHienMatKhau.Name = "chbAnHienMatKhau";
            this.chbAnHienMatKhau.Size = new System.Drawing.Size(132, 20);
            this.chbAnHienMatKhau.TabIndex = 30;
            this.chbAnHienMatKhau.Text = "Ẩn/Hiện Mật khẩu";
            this.chbAnHienMatKhau.UseVisualStyleBackColor = true;
            this.chbAnHienMatKhau.CheckedChanged += new System.EventHandler(this.chbAnHienMatKhau_CheckedChanged);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(201, 85);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(184, 22);
            this.txtMatKhau.TabIndex = 25;
            // 
            // txtNhapLaiMatKhauMoi
            // 
            this.txtNhapLaiMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapLaiMatKhauMoi.Location = new System.Drawing.Point(201, 156);
            this.txtNhapLaiMatKhauMoi.Name = "txtNhapLaiMatKhauMoi";
            this.txtNhapLaiMatKhauMoi.PasswordChar = '*';
            this.txtNhapLaiMatKhauMoi.Size = new System.Drawing.Size(184, 22);
            this.txtNhapLaiMatKhauMoi.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nhập mật khẩu mới:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Nhập lại mật khẩu mới:";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhauMoi.Location = new System.Drawing.Point(201, 121);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.PasswordChar = '*';
            this.txtMatKhauMoi.Size = new System.Drawing.Size(184, 22);
            this.txtMatKhauMoi.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnDoiMatKhau);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chbAnHienMatKhau);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtNhapLaiMatKhauMoi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMatKhauMoi);
            this.groupBox1.Location = new System.Drawing.Point(316, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 296);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // errMatKhauMoi
            // 
            this.errMatKhauMoi.ContainerControl = this;
            // 
            // errMatKhau
            // 
            this.errMatKhau.ContainerControl = this;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1068, 572);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1084, 611);
            this.Name = "frmDoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMatKhauMoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMatKhau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbAnHienMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhauMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errMatKhauMoi;
        private System.Windows.Forms.ErrorProvider errMatKhau;
    }
}
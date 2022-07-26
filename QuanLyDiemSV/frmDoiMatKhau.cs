﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSV
{
    public partial class frmDoiMatKhau : Form
    {
        string ma;
        int role;
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();
        public void SetData(string Data, int vaitro)
        {
            ma = Data;
            role = vaitro;
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
                errMatKhau.SetError(txtMatKhau, "Bạn chưa nhập mật khẩu !");
            else
                errMatKhau.Clear();
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
                errMatKhauMoi.SetError(txtNhapLaiMatKhauMoi, "Mật khẩu không trùng nhau !");
            else
                errMatKhauMoi.Clear();

            if (txtMatKhau.Text.ToString().Length > 0 && txtMatKhauMoi.Text.ToString().Length > 0 && txtMatKhauMoi.Text == txtNhapLaiMatKhauMoi.Text)
            {
                if (txtMatKhau.Text.Length < 5)
                {
                    errMatKhau.SetError(txtMatKhauMoi, "Mật khẩu phải từ 5 ký tự trở lên !");
                    MessageBox.Show("Mật khẩu mới phải từ 5 ký tự trở lên !", "Thông Báo");
                }
                else
                {
                    errMatKhau.Clear();
                }
                if (txtMatKhauMoi.Text.Length < 5)
                {
                    errMatKhauMoi.SetError(txtNhapLaiMatKhauMoi, "Mật khẩu mới phải từ 5 ký tự trở lên !");
                    MessageBox.Show("Mật khẩu mới phải từ 5 ký tự trở lên !", "Thông Báo");
                }
                else
                {
                    switch (role)
                    {
                        case 1:
                            QuanTriVien qt = new QuanTriVien();
                            qt = db.QuanTriViens.Where(x => x.MaQTV.ToString() == ma).SingleOrDefault();
                            if (qt.MatKhau.ToString() != txtMatKhau.Text)
                            {
                                errMatKhau.SetError(txtMatKhau, "Mật khẩu không đúng với tên tài khoản !");
                                MessageBox.Show("Sai mật khẩu", "Thông Báo");
                            }
                            else if (qt.MatKhau.ToString() == txtMatKhau.Text)
                            {
                                qt.MatKhau = txtMatKhauMoi.Text;
                                db.SubmitChanges();
                                MessageBox.Show("Đổi mật khẩu thành công", "Thông Báo");
                            }
                            break;
                        case 2:
                            SinhVien sv = new SinhVien();
                            sv = db.SinhViens.Where(x => x.MaSV.ToString() == ma).SingleOrDefault();
                            if (sv.MatKhau.ToString() == txtMatKhau.Text)
                            {
                                sv.MatKhau = txtMatKhauMoi.Text;
                                db.SubmitChanges();
                                MessageBox.Show("Đổi mật khẩu thành công", "Thông Báo");
                            }
                            else if (sv.MatKhau.ToString() != txtMatKhau.Text)
                            {
                                errMatKhau.SetError(txtMatKhau, "Mật khẩu không đúng với tên tài khoản !");
                                MessageBox.Show("Sai mật khẩu", "Thông Báo");
                            }
                            break;
                        case 3:
                            GiaoVien gv = new GiaoVien();
                            gv = db.GiaoViens.Where(x => x.MaGV.ToString() == ma).SingleOrDefault();
                            if (gv.MatKhau.ToString() == txtMatKhau.Text)
                            {
                                gv.MatKhau = txtMatKhauMoi.Text;
                                db.SubmitChanges();
                                MessageBox.Show("Đổi mật khẩu thành công", "Thông Báo");
                            }
                            else if (gv.MatKhau.ToString() != txtMatKhau.Text)
                            {
                                errMatKhau.SetError(txtMatKhau, "Mật khẩu không đúng với tên tài khoản !");
                                MessageBox.Show("Sai mật khẩu", "Thông Báo");
                            }
                            break;
                    }
                    errMatKhauMoi.Clear();
                    errMatKhau.Clear();
                }
            }
            else
            {
                MessageBox.Show("Thông tin bạn nhập còn thiếu hoặc chưa đúng", "Thông Báo");
                if (txtMatKhau.Text.Length == 0)
                    txtMatKhau.Focus();
                else if (txtMatKhauMoi.Text.Length == 0 || txtMatKhauMoi.Text.Length < 5)
                    txtMatKhauMoi.Focus();
                else if (txtNhapLaiMatKhauMoi.Text.Length == 0 || txtNhapLaiMatKhauMoi.Text.Length < 5)
                    txtNhapLaiMatKhauMoi.Focus();
            }

            txtMatKhau.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLaiMatKhauMoi.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chbAnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = chbAnHienMatKhau.Checked ? '\0' : '*';
            txtMatKhauMoi.PasswordChar = chbAnHienMatKhau.Checked ? '\0' : '*';
            txtNhapLaiMatKhauMoi.PasswordChar = chbAnHienMatKhau.Checked ? '\0' : '*';
        }
    }
}


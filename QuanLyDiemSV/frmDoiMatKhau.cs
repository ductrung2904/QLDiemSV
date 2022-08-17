using System;
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
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
                errMatKhau.SetError(txtMatKhau, "Bạn chưa nhập mật khẩu !");
            else
                errMatKhau.Clear();
            if (txtMatKhauMoi.Text != txtNhapLaiMatKhauMoi.Text)
                errMatKhauMoi.SetError(txtMatKhauMoi, "Mật khẩu không trùng nhau !");
            else
                errMatKhauMoi.Clear();
            if (txtTenTaiKhoan.Text == "")
                errTenTaiKhoan.SetError(txtTenTaiKhoan, "Bạn chưa nhập tên tài khoản !");
            else
                errTenTaiKhoan.Clear();


            if (txtMatKhau.Text.ToString().Length > 0 && txtMatKhauMoi.Text.ToString().Length > 0 && txtMatKhauMoi.Text == txtNhapLaiMatKhauMoi.Text)
            {
                GiaoVien gv = new GiaoVien();
                gv = db.GiaoViens.Where(x => x.Username.ToString() == this.txtTenTaiKhoan.Text).SingleOrDefault();
                if (gv.Password.ToString() == txtMatKhau.Text)
                {
                    gv.Password = txtMatKhauMoi.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Sửa thành công", "Thông Báo");
                }
                else if (gv.Password.ToString() != txtMatKhau.Text)
                {
                    errMatKhau.SetError(txtMatKhau, "Mật khẩu không đúng với tên tài khoản !");
                    MessageBox.Show("Sai Mat Khau", "Thông Báo");
                }

                errTenTaiKhoan.Clear();
                errMatKhauMoi.Clear();
                errMatKhau.Clear();
            }

            txtTenTaiKhoan.Text = "";
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


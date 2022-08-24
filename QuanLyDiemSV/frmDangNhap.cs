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
    public partial class frmDangNhap : Form
    {
        UserRole ur = new UserRole();//Class UserRole dùng để chứa dữ liệu

        QLDiemSVDataContext db = new QLDiemSVDataContext();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            frmDangNhap dangnhap = new frmDangNhap();

            var useradmin = db.QuanTriViens.Select(
                x => new
                {
                    ID = x.MaQTV,
                    Username = x.Username,
                    Password = x.Password,
                    Hoten = x.Username
                });

            var usersv = db.SinhViens.Select(
                x => new
                {
                    ID = x.MaSV,
                    Username = x.Username,
                    Password = x.Password,
                    Hoten = x.TenSV
                });

            var usergv = db.GiaoViens.Select(
                x => new
                {
                    ID = x.MaGV,
                    Username = x.Username,
                    Password = x.Password,
                    Hoten = x.TenGV
                });

            foreach (var item in useradmin)
            {
                if (txtUsername.Text == item.Username && txtPassword.Text == item.Password)
                {
                    this.Visible = false;
                    home.Visible = true;
                    home.btnDKHP.Visible = false;
                    home.btnXemDiemSV.Visible = false;
                    home.btnNhapDiemGV.Visible = false;
                    home.btnDoiMatKhauGV.Visible = false;
                    home.btnDoiMatKhauSV.Visible = false;

                    ur.ID = Convert.ToString(item.ID);
                    ur.UserName = item.Username;

                    home.lblID.Text = ur.ID;

                    string lastName = item.Hoten.Split(' ').Last();
                    ur.Hoten = lastName;
                    home.lblTenDangNhap.Text = "Xin chào, " + ur.Hoten;
                }
            }

            foreach (var item in usersv)
            {
                if (txtUsername.Text == item.Username && txtPassword.Text == item.Password)
                {
                    this.Visible = false;
                    home.Visible = true;
                    home.btnKhoa.Visible = false;
                    home.btnSinhVien.Visible = false;
                    home.btnGiaoVien.Visible = false;
                    home.btnMonHoc.Visible = false;
                    home.btnLopHP.Visible = false;
                    home.btnNhapDiem.Visible = false;
                    home.btnThongKe.Visible = false;
                    home.btnDoiMatKhau.Visible = false;
                    home.btnDoiMatKhauGV.Visible = false;
                    home.btnNhapDiemGV.Visible = false;

                    ur.ID = Convert.ToString(item.ID);
                    ur.UserName = item.Username;

                    home.lblID.Text = ur.ID;

                    string lastName = item.Hoten.Split(' ').Last();
                    ur.Hoten = lastName;
                    home.lblTenDangNhap.Text = "Xin chào, " + ur.Hoten;
                }
            }

            foreach (var item in usergv)
            {
                if (txtUsername.Text == item.Username && txtPassword.Text == item.Password)
                {
                    this.Visible = false;
                    home.Visible = true;
                    home.btnKhoa.Visible = false;
                    home.btnSinhVien.Visible = false;
                    home.btnGiaoVien.Visible = false;
                    home.btnMonHoc.Visible = false;
                    home.btnLopHP.Visible = false;
                    home.btnNhapDiem.Visible = false;
                    home.btnThongKe.Visible = false;
                    home.btnDoiMatKhau.Visible = false;
                    home.btnDoiMatKhauSV.Visible = false;
                    home.btnXemDiemSV.Visible = false;
                    home.btnDKHP.Visible = false;

                    ur.ID = Convert.ToString(item.ID);
                    ur.UserName = item.Username;

                    home.lblID.Text = ur.ID;

                    string lastName = item.Hoten.Split(' ').Last();
                    ur.Hoten = lastName;
                    home.lblTenDangNhap.Text = "Xin chào, " + ur.Hoten;
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn thoát.", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void chbAnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chbAnHienMatKhau.Checked ? '\0' : '*';
        }
    }
}

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

        bool tontai = false;

        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmHome home = new frmHome();
            frmDangNhap dangnhap = new frmDangNhap();

            if (txtUsername.Text == "")
            {
                errTenDN.SetError(txtUsername, "Bạn chưa nhập tên đăng nhập");
            }
            else
                errTenDN.Clear();

            if (txtPassword.Text == "")
            {
                errPass.SetError(txtPassword, "Bạn chưa nhập mật khẩu");
            }
            else
                errPass.Clear();

            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                var useradmin = db.QuanTriViens.Select(
                x => new
                {
                    ID = x.MaQTV,
                    Username = x.TenDangNhap,
                    Password = x.MatKhau,
                    Hoten = x.TenDangNhap
                });

                var usersv = db.SinhViens.Select(
                    x => new
                    {
                        ID = x.MaSV,
                        Username = x.TenDangNhap,
                        Password = x.MatKhau,
                        Hoten = x.TenSV
                    });

                var usergv = db.GiaoViens.Select(
                    x => new
                    {
                        ID = x.MaGV,
                        Username = x.TenDangNhap,
                        Password = x.MatKhau,
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

                        ur.ID = Convert.ToString(item.ID);
                        ur.UserName = item.Username;

                        home.lblID.Text = ur.ID;
                        home.role = 1;

                        string lastName = item.Hoten.Split(' ').Last();
                        ur.Hoten = lastName;
                        home.lblTenDangNhap.Text = "Xin chào, " + ur.Hoten;

                        tontai = true;

                        break;
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
                        home.btnNhapDiemGV.Visible = false;

                        ur.ID = Convert.ToString(item.ID);
                        ur.UserName = item.Username;

                        home.lblID.Text = ur.ID;
                        home.role = 2;

                        string lastName = item.Hoten.Split(' ').Last();
                        ur.Hoten = lastName;
                        home.lblTenDangNhap.Text = "Xin chào, " + ur.Hoten;

                        tontai = true;

                        break;
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
                        home.btnXemDiemSV.Visible = false;
                        home.btnDKHP.Visible = false;

                        ur.ID = Convert.ToString(item.ID);
                        ur.UserName = item.Username;

                        home.lblID.Text = ur.ID;
                        home.role = 3;

                        string lastName = item.Hoten.Split(' ').Last();
                        ur.Hoten = lastName;
                        home.lblTenDangNhap.Text = "Xin chào, " + ur.Hoten;

                        tontai = true;

                        break;
                    }
                }
                if (!tontai)
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không tồn tại!");
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                    txtUsername.Focus();
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

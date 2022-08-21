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

            //Lọc mã nhân viên và mã giáo viên , còn thiếu mã admin
            var usersv = db.SinhViens.Select(
                x => new
                {
                    Username = x.Username,
                    Password = x.Password
                });

            var usergv = db.GiaoViens.Select(
                x => new
                {
                    Username = x.Username,
                    Password = x.Password
                });

            //Lọc mã qua foreach 
            foreach (var item in usersv)
            {
                if(txtUsername.Text == item.Username && txtPassword.Text == item.Password)
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

                    ur.UserName = item.Username;
                }
            }

            foreach (var item in usergv)
            {
                if (txtUsername.Text == item.Username && txtPassword.Text == item.Password)
                {
                    this.Visible = false;
                    home.Visible = true;
                    home.btnKhoa.Visible = false;
                    home.btnGiaoVien.Visible = false;
                    home.btnMonHoc.Visible = false;
                    home.btnLopHP.Visible = false;
                    home.btnSinhVien.Visible = false;

                    ur.UserName = item.Username;
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

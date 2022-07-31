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
        public frmDangNhap()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn thoát.", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                var query = (from gv in db.GiaoViens where gv.Username == txtUsername.Text select gv).First();
                if (query.Username != txtUsername.Text)
                {
                    MessageBox.Show("Tên đăng nhập không đúng hoặc chưa đăng ký", "Thông Báo");
                }
                else if (query.Password != txtPassword.Text)
                {
                    MessageBox.Show("Mật khẩu không đúng", "Thông Báo");
                }
                else if (query.Password == txtPassword.Text)
                {
                    this.Hide();
                    MessageBox.Show("Đăng Nhập thành công.", "Thông Báo");
                    frmHome home = new frmHome();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Sai Tên Đăng Nhập hoặc Mật Khẩu.\nVui lòng nhập lại.", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin đăng nhập", "Thông Báo");
            }
        }
    }
}

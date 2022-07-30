using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSV
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();
        int flag;
        int kiemTraInt;
        Regex numCheck = new Regex(@"^[0-9]{10}$"); //   Kiểm tra dữ liệu phải có 10 số
        Regex emailCheck = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

        private void setControls(bool edit)
        {
            txtMaGV.Enabled = edit;
            txtHoTenGV.Enabled = edit;
            cboGioiTinh.Enabled = edit;
            txtUsername.Enabled = edit;
            txtPassword.Enabled = edit;
            txtEmail.Enabled = edit;
            txtSDT.Enabled = edit;
        }

        void loadData()
        {
            var query = from gv in db.GiaoViens select gv;
            dgvGiaoVien.DataSource = query;
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dgvGiaoVien.Enabled = true;
            dgvGiaoVien.AutoGenerateColumns = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void dgvGiaoVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaGV.Text = dgvGiaoVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTenGV.Text = dgvGiaoVien.CurrentRow.Cells[1].Value.ToString();
            cboGioiTinh.Text = dgvGiaoVien.CurrentRow.Cells[2].Value.ToString();
            txtUsername.Text = dgvGiaoVien.CurrentRow.Cells[3].Value.ToString();
            txtPassword.Text = dgvGiaoVien.CurrentRow.Cells[4].Value.ToString();
            txtEmail.Text = dgvGiaoVien.CurrentRow.Cells[5].Value.ToString();
            txtSDT.Text = dgvGiaoVien.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            setControls(false);
            txtTimKiem.Text = "";
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            loadData();
            dgvGiaoVien.AutoGenerateColumns = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = "";
            txtHoTenGV.Text = "";
            cboGioiTinh.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";

            setControls(true);
            dgvGiaoVien.Enabled = false;
            txtMaGV.Focus();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            flag = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setControls(true);
            dgvGiaoVien.Enabled = false;
            txtMaGV.Focus();
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            flag = 1;
        }

        private void themSV()
        {
            GiaoVien gv = new GiaoVien();
            gv.MaGV = Int32.Parse(txtMaGV.Text);
            gv.TenGV = txtHoTenGV.Text;
            gv.GioiTinh = cboGioiTinh.Text;
            gv.Username = txtUsername.Text;
            gv.Password = txtPassword.Text;
            gv.Email = txtEmail.Text;
            gv.Phone = txtSDT.Text;
            db.GiaoViens.InsertOnSubmit(gv);
            db.SubmitChanges();

            var them = db.GiaoViens.Where(x => x.MaGV == gv.MaGV).ToList();
            dgvGiaoVien.DataSource = them;
            MessageBox.Show("Thêm thành công", "Thông Báo");
        }

        private void suaSV()
        {
            GiaoVien gv = new GiaoVien();
            gv = db.GiaoViens.Where(x => x.MaGV.ToString() == txtMaGV.Text).SingleOrDefault();
            gv.TenGV = txtHoTenGV.Text;
            gv.GioiTinh = cboGioiTinh.Text;
            gv.Username = txtUsername.Text;
            gv.Password = txtPassword.Text;
            gv.Email = txtEmail.Text;
            gv.Phone = txtSDT.Text;
            db.SubmitChanges();

            var sua = db.GiaoViens.Where(x => x.MaGV == gv.MaGV).ToList();
            dgvGiaoVien.DataSource = sua;
            MessageBox.Show("Sửa thành công", "Thông Báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dgvGiaoVien.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            errMaGV.Clear();
            errHoTenGV.Clear();
            errGioiTinh.Clear();
            errrUsername.Clear();
            errPassword.Clear();
            errEmail.Clear();
            errSDT.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "")
                errMaGV.SetError(txtMaGV, "Vui lòng nhập mã giáo siên");
            else
                errMaGV.Clear();
            if (txtHoTenGV.Text == "")
                errHoTenGV.SetError(txtHoTenGV, "Vui lòng nhập họ tên giáo siên");
            else
                errHoTenGV.Clear();
            if (cboGioiTinh.Text == "")
                errGioiTinh.SetError(cboGioiTinh, "Vui lòng nhập giới tính");
            else
                errGioiTinh.Clear();
            if (txtUsername.Text == "")
                errrUsername.SetError(txtUsername, "Vui lòng nhập tên đăng nhập");
            else
                errrUsername.Clear();
            if (txtPassword.Text == "")
                errPassword.SetError(txtPassword, "Vui lòng nhập mật khẩu");
            else
                errPassword.Clear();
            if (txtEmail.Text == "")
                errEmail.SetError(txtEmail, "Vui lòng nhập email");
            else
                errEmail.Clear();
            if (txtSDT.Text == "")
                errSDT.SetError(txtSDT, "Vui lòng nhập số điện thoại");
            else
                errSDT.Clear();

            //  Validate thông tin đầu vào
            bool isNumberMaSV = int.TryParse(txtMaGV.Text, out kiemTraInt);
            bool isNumberDienThoai = int.TryParse(txtSDT.Text, out kiemTraInt);
            bool checkDigitNumberMaSV = numCheck.IsMatch(txtMaGV.Text);
            bool checkDigitNumberDienThoai = numCheck.IsMatch(txtSDT.Text);
            bool checkEmailIsValid = emailCheck.IsMatch(txtEmail.Text);
            if (isNumberMaSV == false)
            {
                errMaGV.SetError(txtMaGV, "Mã giáo viên phải là số");
            }
            if (checkDigitNumberMaSV == false)
            {
                errMaGV.SetError(txtMaGV, "Mã giáo viên phải có 10 số");
            }
            if (isNumberDienThoai == false)
            {
                errSDT.SetError(txtSDT, "Số điện thoại phải là số");
            }
            if (checkDigitNumberDienThoai == false)
            {
                errSDT.SetError(txtSDT, "Số điện thoại phải có 10 số");
            }
            if (checkEmailIsValid == false)
            {
                errEmail.SetError(txtEmail, "Email không hợp lệ");
            }
            if (txtMaGV.Text.ToString().Length > 0 && txtHoTenGV.Text.Length > 0 && cboGioiTinh.Text.Length > 0 && txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0 && txtEmail.Text.Length > 0 && txtSDT.Text.Length > 0 && isNumberMaSV == true && isNumberDienThoai == true && checkDigitNumberMaSV == true && checkDigitNumberDienThoai == true && checkEmailIsValid == true)
            {
                if (flag == 0)
                {
                    themSV();
                }
                else if (flag == 1)
                {
                    suaSV();
                }
                loadData();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                setControls(false);
                dgvGiaoVien.Enabled = true;

                errMaGV.Clear();
                errHoTenGV.Clear();
                errGioiTinh.Clear();
                errrUsername.Clear();
                errPassword.Clear();
                errEmail.Clear();
                errSDT.Clear();
            }
            else
            {
                MessageBox.Show("Thông tin bạn nhập còn thiếu hoặc chưa đúng", "Thông Báo");
                if (txtMaGV.Text.Length == 0)
                    txtMaGV.Focus();
                else if (txtHoTenGV.Text.Length == 0)
                    txtHoTenGV.Focus();
                else if (cboGioiTinh.Text.Length == 0)
                    cboGioiTinh.Focus();
                else if (txtUsername.Text.Length == 0)
                    txtUsername.Focus();
                else if (txtPassword.Text.Length == 0)
                    txtPassword.Focus();
                else if (txtEmail.Text.Length == 0)
                    txtEmail.Focus();
                else if (txtSDT.Text.Length == 0)
                    txtSDT.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    GiaoVien gv = new GiaoVien();
                    gv = db.GiaoViens.Single(x => x.MaGV.ToString() == txtMaGV.Text);
                    db.GiaoViens.DeleteOnSubmit(gv);
                    db.SubmitChanges();

                    var xoa = db.GiaoViens.Where(x => x.MaGV == gv.MaGV).ToList();
                    dgvGiaoVien.DataSource = xoa;
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại", "Thông Báo");
                }
            }
            loadData();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdbMaGV.Checked)
            {
                var timKiemMaGV = from gv in db.GiaoViens where SqlMethods.Like(gv.MaGV.ToString(), "%" + txtTimKiem.Text + "%") select gv;
                dgvGiaoVien.DataSource = timKiemMaGV;
            }
            else if (rdbTenGV.Checked)
            {
                var timKiemTenGV = from gv in db.GiaoViens where SqlMethods.Like(gv.TenGV.ToString(), "%" + txtTimKiem.Text + "%") select gv;
                dgvGiaoVien.DataSource = timKiemTenGV;
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }
    }
}

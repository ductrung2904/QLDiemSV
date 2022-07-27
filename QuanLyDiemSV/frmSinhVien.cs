using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSV
{
    public partial class frmSinhVien : Form
    {
        public frmSinhVien()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();
        int flag;

        private void setControls(bool edit)
        {
            txtMaSV.Enabled = edit;
            txtHoTen.Enabled = edit;
            dtpNgaySinh.Enabled = edit;
            cboGioiTinh.Enabled = edit;
            txtDiaChi.Enabled = edit;
            txtDienThoai.Enabled = edit;
            cboTenKhoa.Enabled = edit;
            txtGhiChu.Enabled = edit;
        }

        void loadData()
        {
            var st = from sv in db.SinhViens join nh in db.NganhHocs on sv.MaNganh equals nh.MaNganh where sv.MaNganh == nh.MaNganh select new { MaSV = sv.MaSV, TenSV = sv.TenSV, NgaySinh = sv.NgaySinh, GioiTinh = sv.GioiTinh, DiaChi = sv.DiaChi, DienThoai = sv.DienThoai, MaNganh = sv.MaNganh, GhiChu = sv.GhiChu};
            dgvSinhVien.DataSource = st;
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dgvSinhVien.Enabled = true;
            dgvSinhVien.AutoGenerateColumns = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            //  load data vào cboNganh
            cboTenKhoa.DataSource = db.NganhHocs.ToList();
            cboTenKhoa.ValueMember = "MaNganh";
            cboTenKhoa.DisplayMember = "TenNganh";
        }

        private void dgvSinhVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSV.Text = dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dgvSinhVien.CurrentRow.Cells[1].Value.ToString();
            dtpNgaySinh.Text = dgvSinhVien.CurrentRow.Cells[2].Value.ToString();
            cboGioiTinh.Text = dgvSinhVien.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dgvSinhVien.CurrentRow.Cells[4].Value.ToString();
            txtDienThoai.Text = dgvSinhVien.CurrentRow.Cells[5].Value.ToString();
            cboTenKhoa.SelectedValue = dgvSinhVien.CurrentRow.Cells[6].Value.ToString();
            txtGhiChu.Text = dgvSinhVien.CurrentRow.Cells[7].Value.ToString();
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
            dgvSinhVien.AutoGenerateColumns = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            cboGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            cboTenKhoa.Text = "";
            txtGhiChu.Text = "";

            setControls(true);
            dgvSinhVien.Enabled = false;
            txtMaSV.Focus();
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
            dgvSinhVien.Enabled = false;
            txtMaSV.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            flag = 1;
        }

        private void themSV()
        {
            SinhVien sv = new SinhVien();
            sv.MaSV = Int32.Parse(txtMaSV.Text);
            sv.TenSV = txtHoTen.Text;
            sv.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            sv.GioiTinh = cboGioiTinh.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.DienThoai = txtDienThoai.Text;
            sv.MaNganh = cboTenKhoa.SelectedValue.ToString();
            sv.GhiChu = txtGhiChu.Text;
            db.SinhViens.InsertOnSubmit(sv);
            db.SubmitChanges();

            var them = db.SinhViens.Where(x => x.MaSV == sv.MaSV).ToList();
            dgvSinhVien.DataSource = them;
            MessageBox.Show("Thêm thành công", "Thông Báo");
        }

        private void suaSV()
        {
            SinhVien sv = new SinhVien();
            sv = db.SinhViens.Where(x => x.MaSV.ToString() == txtMaSV.Text).SingleOrDefault();
            sv.TenSV = txtHoTen.Text;
            sv.NgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            sv.GioiTinh = cboGioiTinh.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.DienThoai = txtDienThoai.Text;
            sv.MaNganh = cboTenKhoa.SelectedValue.ToString();
            sv.GhiChu = txtGhiChu.Text;
            db.SubmitChanges();

            var sua = db.SinhViens.Where(x => x.MaSV == sv.MaSV).ToList();
            dgvSinhVien.DataSource = sua;
            MessageBox.Show("Sửa thành công", "Thông Báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSV.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Text = "";
            cboGioiTinh.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            cboTenKhoa.Text = "";
            txtGhiChu.Text = "";
            setControls(false);
            dgvSinhVien.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdbMaSV.Checked)
            {
                var timKiemMaSV = from sv in db.SinhViens where SqlMethods.Like(sv.MaSV.ToString(), "%" + txtTimKiem.Text + "%") select new { MaSV = sv.MaSV, TenSV = sv.TenSV, NgaySinh = sv.NgaySinh, GioiTinh = sv.GioiTinh, DiaChi = sv.DiaChi, DienThoai = sv.DienThoai, MaNganh = sv.MaNganh, GhiChu = sv.GhiChu };
                dgvSinhVien.DataSource = timKiemMaSV;
            }
            else if (rdbTenSV.Checked)
            {
                var timKiemTenSV = from sv in db.SinhViens where SqlMethods.Like(sv.TenSV.ToString(), "%" + txtTimKiem.Text + "%") select new { MaSV = sv.MaSV, TenSV = sv.TenSV, NgaySinh = sv.NgaySinh, GioiTinh = sv.GioiTinh, DiaChi = sv.DiaChi, DienThoai = sv.DienThoai, MaNganh = sv.MaNganh, GhiChu = sv.GhiChu };
                dgvSinhVien.DataSource = timKiemTenSV;
            }
            else if (rdbNganh.Checked)
            {
                var timKiemTenSV = from sv in db.SinhViens where SqlMethods.Like(sv.MaNganh.ToString(), "%" + txtTimKiem.Text + "%") select new { MaSV = sv.MaSV, TenSV = sv.TenSV, NgaySinh = sv.NgaySinh, GioiTinh = sv.GioiTinh, DiaChi = sv.DiaChi, DienThoai = sv.DienThoai, MaNganh = sv.MaNganh, GhiChu = sv.GhiChu };
                dgvSinhVien.DataSource = timKiemTenSV;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.ToString().Length > 0 && txtHoTen.Text.Length > 0 && dtpNgaySinh.Text.Length > 0 && cboGioiTinh.Text.Length > 0 && txtDiaChi.Text.Length > 0 && txtDienThoai.Text.Length > 0 && cboTenKhoa.Text.Length > 0)
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
                dgvSinhVien.Enabled = true;
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
                    SinhVien sv = new SinhVien();
                    sv = db.SinhViens.Single(x => x.MaSV.ToString() == txtMaSV.Text);
                    db.SinhViens.DeleteOnSubmit(sv);
                    db.SubmitChanges();

                    var xoa = db.SinhViens.Where(x => x.MaSV == sv.MaSV).ToList();
                    dgvSinhVien.DataSource = xoa;
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại", "Thông Báo");
                }
            }
            loadData();
        }
    }
}

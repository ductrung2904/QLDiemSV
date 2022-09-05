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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();
        int flag;
        Regex pattern = new Regex(@"^[0-9]{10}$"); //   Kiểm tra dữ liệu phải có 10 số

        private void setControls(bool edit)
        {
            txtMaMH.Enabled = edit;
            txtTenMH.Enabled = edit;
            numTinChi.Enabled = edit;
            numSoTiet.Enabled = edit;
            cboMaNganh.Enabled = edit;
        }

        void loadData()
        {
            var query = from mh in db.MonHocs join nh in db.NganhHocs on mh.MaNganh equals nh.MaNganh where mh.MaNganh == nh.MaNganh select new { MaMH = mh.MaMH, TenMH = mh.TenMH, SoTinChi = mh.SoTinChi, SoTiet = mh.SoTiet , MaNganh = mh.MaNganh, TenNganh = nh.TenNganh};
            dataMH.DataSource = query;
        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dataMH.Enabled = true;
            dataMH.AutoGenerateColumns = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            rdbMaMH.Checked = true;

            cboMaNganh.DataSource = db.NganhHocs.ToList();
            cboMaNganh.ValueMember = "MaNganh";
            cboMaNganh.DisplayMember = "MaNganh";
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
            dataMH.AutoGenerateColumns = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            numTinChi.Text = "";
            numSoTiet.Text = "";

            setControls(true);
            dataMH.Enabled = false;
            txtMaMH.Focus();
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
            dataMH.Enabled = false;
            txtMaMH.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            flag = 1;
        }

        private void themMH()
        {
            MonHoc mh = new MonHoc();
            mh.MaMH = txtMaMH.Text;
            mh.TenMH = txtTenMH.Text;
            mh.SoTinChi = Int32.Parse(numTinChi.Text);
            mh.SoTiet = Int32.Parse(numSoTiet.Text);
            mh.MaNganh = cboMaNganh.Text;
            db.MonHocs.InsertOnSubmit(mh);
            db.SubmitChanges();

            var them = db.MonHocs.Where(x => x.MaMH == mh.MaMH).ToList();
            dataMH.DataSource = them;
            MessageBox.Show("Thêm thành công", "Thông Báo");
        }

        private void suaMH()
        {
            NganhHoc nh = new NganhHoc();
            MonHoc mh = new MonHoc();
            mh = db.MonHocs.Where(x => x.MaMH.ToString() == txtMaMH.Text).SingleOrDefault();

            mh.TenMH = txtTenMH.Text;
            mh.SoTinChi = Convert.ToInt32(Math.Round(numTinChi.Value, 0));
            mh.SoTiet = Convert.ToInt32(Math.Round(numSoTiet.Value, 0));
            mh.MaNganh = cboMaNganh.Text;   

            db.SubmitChanges();

            var sua = db.MonHocs.Where(x => x.MaMH == mh.MaMH).ToList();
            dataMH.DataSource = sua;
            MessageBox.Show("Sửa thành công", "Thông Báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dataMH.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            errMaMH.Clear();
            errTenMH.Clear();
            errSoTinChi.Clear();
            errSoTiet.Clear();
            errMaNganh.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaMH.Text == "")
                errMaMH.SetError(txtMaMH, "Vui lòng nhập mã môn học");
            else
                errMaMH.Clear();
            if (txtTenMH.Text == "")
                errTenMH.SetError(txtTenMH, "Vui lòng nhập tên môn học");
            else
                errTenMH.Clear();
            if (numTinChi.Text == "0" || numTinChi.Text == "")
                errSoTinChi.SetError(numTinChi, "Vui lòng chỉnh số tín chỉ");
            else
                errSoTinChi.Clear();
            if (numSoTiet.Text == "0" || numSoTiet.Text == "")
                errSoTiet.SetError(numSoTiet, "Vui lòng chỉnh số tiết");
            else
                errSoTiet.Clear();
            if (cboMaNganh.Text == "")
                errMaNganh.SetError(cboMaNganh, "Vui lòng chọn mã ngành");
            else
                errMaNganh.Clear();

            if (txtMaMH.Text.ToString().Length > 0 && txtTenMH.Text.Length > 0 && Int32.Parse(numSoTiet.Text) != 0 && Int32.Parse(numTinChi.Text) != 0)
            {
                string mamh = txtMaMH.Text;
                var checkId = from mh in db.MonHocs where mh.MaMH == mamh select mh.MaMH;
                if (flag == 0)
                {
                    if (checkId.Count() > 0)
                    {
                        MessageBox.Show("Mã môn học này đã tồn tại", "Thông Báo");
                    }
                    else
                    {
                        themMH();
                    }
                }
                else if (flag == 1)
                {
                    suaMH();
                }
                loadData();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                setControls(false);
                dataMH.Enabled = true;

                errMaMH.Clear();
                errTenMH.Clear();
                errSoTinChi.Clear();
                errSoTiet.Clear();
                errMaNganh.Clear();
            }
            else
            {
                MessageBox.Show("Thông tin bạn nhập còn thiếu hoặc chưa đúng", "Thông Báo");
                if (txtMaMH.Text.Length == 0)
                    txtMaMH.Focus();
                else if (txtTenMH.Text.Length == 0)
                    txtTenMH.Focus();
                else if (numSoTiet.Text == "0")
                    numSoTiet.Focus();
                else if (numTinChi.Text == "0")
                    numTinChi.Focus();
                else if (cboMaNganh.Text.Length == 0)
                    cboMaNganh.Focus();
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
                    MonHoc mh = new MonHoc();
                    mh = db.MonHocs.Single(x => x.MaMH.ToString() == txtMaMH.Text);
                    db.MonHocs.DeleteOnSubmit(mh);
                    db.SubmitChanges();

                    var xoa = db.MonHocs.Where(x => x.MaMH == mh.MaMH).ToList();
                    dataMH.DataSource = xoa;
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
            if (rdbMaMH.Checked)
            {
                var timKiemMaMH = from mh in db.MonHocs where SqlMethods.Like(mh.MaMH.ToString(), "%" + txtTimKiem.Text + "%") select new { MaMH = mh.MaMH, TenMH = mh.TenMH, SoTinChi = mh.SoTinChi, SoTiet = mh.SoTiet, MaNganh = mh.MaNganh };
                dataMH.DataSource = timKiemMaMH;
            }
            else if (rdbTenMH.Checked)
            {
                var timKiemTenMH = from mh in db.MonHocs where SqlMethods.Like(mh.TenMH.ToString(), "%" + txtTimKiem.Text + "%") select new { MaMH = mh.MaMH, TenMH = mh.TenMH, SoTinChi = mh.SoTinChi, SoTiet = mh.SoTiet, MaNganh = mh.MaNganh };
                dataMH.DataSource = timKiemTenMH;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void dgvMonHoc_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaMH.Text = dataMH.CurrentRow.Cells[0].Value.ToString();
            txtTenMH.Text = dataMH.CurrentRow.Cells[1].Value.ToString();
            numTinChi.Text = dataMH.CurrentRow.Cells[2].Value.ToString();
            numSoTiet.Text = dataMH.CurrentRow.Cells[3].Value.ToString();
            cboMaNganh.SelectedValue = dataMH.CurrentRow.Cells[4].Value.ToString();         
        }
    }
}

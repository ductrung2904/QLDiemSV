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
    public partial class frmNganhHoc : Form
    {
        public frmNganhHoc()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();
        int flag;
        Regex pattern = new Regex(@"^[0-9]{10}$"); //   Kiểm tra dữ liệu phải có 10 số

        private void setControls(bool edit)
        {
            txtMaNganh.Enabled = edit;
            txtTenNganh.Enabled = edit;
        }

        void loadData()
        {
            var query = from nh in db.NganhHocs select new { MaNganh = nh.MaNganh, TenNganh = nh.TenNganh };
            dataGridView1.DataSource = query;
        }

        private void frmNganhHoc_Load(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dataGridView1.Enabled = true;
            dataGridView1.AutoGenerateColumns = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNganh.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNganh.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
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
            dataGridView1.AutoGenerateColumns = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNganh.Text = "";
            txtTenNganh.Text = "";

            setControls(true);
            dataGridView1.Enabled = false;
            txtMaNganh.Focus();
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
            dataGridView1.Enabled = false;
            txtMaNganh.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            flag = 1;
        }

        private void themNH()
        {
            NganhHoc nh = new NganhHoc();
            nh.MaNganh = txtMaNganh.Text;
            nh.TenNganh = txtTenNganh.Text;
            db.NganhHocs.InsertOnSubmit(nh);
            db.SubmitChanges();

            var them = db.NganhHocs.Where(x => x.MaNganh == nh.MaNganh).ToList();
            dataGridView1.DataSource = them;
            MessageBox.Show("Thêm thành công", "Thông Báo");
        }

        private void suaNH()
        {
            NganhHoc nh = new NganhHoc();
            nh = db.NganhHocs.Where(x => x.MaNganh == txtMaNganh.Text).SingleOrDefault();
            nh.TenNganh = txtTenNganh.Text;
            db.SubmitChanges();

            var sua = db.NganhHocs.Where(x => x.MaNganh == nh.MaNganh).ToList();
            dataGridView1.DataSource = sua;
            MessageBox.Show("Sửa thành công", "Thông Báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dataGridView1.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            errMaNganh.Clear();
            errTenNganh.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.Text == "")
                errMaNganh.SetError(txtMaNganh, "Vui lòng nhập mã ngành");
            else
                errMaNganh.Clear();
            if (txtTenNganh.Text == "")
                errTenNganh.SetError(txtTenNganh, "Vui lòng nhập họ tên ngành");
            else
                errTenNganh.Clear();

            if (txtMaNganh.Text.ToString().Length > 0 && txtTenNganh.Text.Length > 0)
            {
                if (flag == 0)
                {
                    themNH();
                }
                else if (flag == 1)
                {
                    suaNH();
                }
                loadData();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                setControls(false);
                dataGridView1.Enabled = true;

                errMaNganh.Clear();
                errTenNganh.Clear();
            }
            else
            {
                MessageBox.Show("Thông tin bạn nhập còn thiếu hoặc chưa đúng", "Thông Báo");
                if (txtMaNganh.Text.Length == 0)
                    txtMaNganh.Focus();
                else if (txtTenNganh.Text.Length == 0)
                    txtTenNganh.Focus();
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
                    NganhHoc nh = new NganhHoc();
                    nh = db.NganhHocs.Single(x => x.MaNganh.ToString() == txtMaNganh.Text);
                    db.NganhHocs.DeleteOnSubmit(nh);
                    db.SubmitChanges();

                    var xoa = db.NganhHocs.Where(x => x.MaNganh == nh.MaNganh).ToList();
                    dataGridView1.DataSource = xoa;
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
            if (rdbMaNganh.Checked)
            {
                var timKiemMaSV = from nh in db.NganhHocs where SqlMethods.Like(nh.MaNganh.ToString(), "%" + txtTimKiem.Text + "%") select new { MaNganh = nh.MaNganh, TenNganh = nh.TenNganh };
                dataGridView1.DataSource = timKiemMaSV;
            }
            else if (rdbTenNganh.Checked)
            {
                var timKiemTenSV = from nh in db.NganhHocs where SqlMethods.Like(nh.TenNganh.ToString(), "%" + txtTimKiem.Text + "%") select new { MaNganh = nh.MaNganh, TenNganh = nh.TenNganh };
                dataGridView1.DataSource = timKiemTenSV;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }
    
}
}

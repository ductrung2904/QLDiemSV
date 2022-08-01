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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();
        int flag;
        Regex pattern = new Regex(@"^[0-9]{10}$"); //   Kiểm tra dữ liệu phải có 10 số

        private void setControls(bool edit)
        {
            txtMaHP.Enabled = edit;
            txtMaGV.Enabled = edit;
            txtTenGV.Enabled = edit;
            txtTenMH.Enabled = edit;
            MaMH.Enabled = edit;
        }

        void loadData()
        {
            var query = from lop in db.Lops join mh in db.MonHocs on lop.MaMH equals mh.MaMH join gv in db.GiaoViens on lop.MaGV equals gv.MaGV where lop.MaMH == mh.MaMH && lop.MaGV == gv.MaGV select new { MaLop = lop.MaLop, SoLuong = lop.SoLuong, MaHP = lop.MaHocPhan, MaGV = lop.MaGV, MaMH = lop.MaMH };
            dataLop.DataSource = query;
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            MaMH.Enabled = true;
            dataLop.AutoGenerateColumns = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            rdbMaMH.Checked = true;
        }

        private void dgvSinhVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            MonHoc mh = new MonHoc();
            GiaoVien gv = new GiaoVien();
            //.Text = dataLop.CurrentRow.Cells[0].Value.ToString(); 
            txtMaHP.Text = dataLop.CurrentRow.Cells[1].Value.ToString();
            numSoLuong.Text = dataLop.CurrentRow.Cells[2].Value.ToString();   
            MaMH.Text = dataLop.CurrentRow.Cells[3].Value.ToString();
            txtMaGV.Text = dataLop.CurrentRow.Cells[4].Value.ToString();
            //txtTenMH.Text = db.MonHocs.
            //txtTenGV
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
            dataLop.AutoGenerateColumns = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = "";
            txtMaHP.Text = "";
            txtTenGV.Text = "";
            txtTenMH.Text = "";
            MaMH.Text = "";


            setControls(true);
            dataLop.Enabled = false;
            txtMaHP.Focus();
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
            dataLop.Enabled = false;
            txtMaHP.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            flag = 1;
        }

        private void themLop()
        {
            Lop lop = new Lop();
            lop.MaHocPhan = txtMaHP.Text;
            //lop.MaLop = ???;
            lop.SoLuong = Convert.ToInt32(Math.Round(numSoLuong.Value, 0)); 
            lop.MaGV = Int32.Parse(txtMaGV.Text);
            lop.MaMH = MaMH.Text;
            db.Lops.InsertOnSubmit(lop);
            db.SubmitChanges();

            var them = db.Lops.Where(x => x.MaHocPhan == lop.MaHocPhan).ToList();
            dataLop.DataSource = them;
            MessageBox.Show("Thêm thành công", "Thông Báo");
        }

        private void suaLop()
        {
            Lop lop = new Lop();
            lop = db.Lops.Where(x => x.MaHocPhan.ToString() == txtMaHP.Text).SingleOrDefault();
            //
            //
            db.SubmitChanges();

            var sua = db.Lops.Where(x => x.MaHocPhan == lop.MaHocPhan).ToList();
            dataLop.DataSource = sua;
            MessageBox.Show("Sửa thành công", "Thông Báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dataLop.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            errMaLop.Clear();
            errMaHP.Clear();
            errSoLuong.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHP.Text == "")
                errMaHP.SetError(txtMaHP, "Vui lòng nhập mã học phần");
            else

            if (txtMaHP.Text.ToString().Length > 0)
            {
                if (flag == 0)
                {
                    themLop();
                }
                else if (flag == 1)
                {
                    suaLop();
                }
                loadData();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                setControls(false);
                dataLop.Enabled = true;

                errMaLop.Clear();
                errMaHP.Clear();
                errSoLuong.Clear();
            }

            else
            {
                MessageBox.Show("Thông tin bạn nhập còn thiếu hoặc chưa đúng", "Thông Báo");
                if (txtMaHP.Text.Length == 0)
                    txtMaHP.Focus();
                else if (numSoLuong.Text.Length == 0)
                    numSoLuong.Focus();
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
                    Lop lop = new Lop();
                    lop = db.Lops.Single(x => x.MaHocPhan.ToString() == txtMaHP.Text);
                    db.Lops.DeleteOnSubmit(lop);
                    db.SubmitChanges();

                    var xoa = db.Lops.Where(x => x.MaHocPhan == lop.MaHocPhan).ToList();
                    dataLop.DataSource = xoa;
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
                var timKiemMaSV = from lop in db.Lops where SqlMethods.Like(lop.MaHocPhan.ToString(), "%" + txtTimKiem.Text + "%") select new { MaLop = lop.MaLop, SoLuong = lop.SoLuong, MaHocPhan = lop.MaHocPhan, MaGV = lop.MaGV, MaMH = lop.MaMH};
                dataLop.DataSource = timKiemMaSV;
            }
            else if (rdbMaMH.Checked)
            {
                var timKiemTenSV = from lop in db.Lops where SqlMethods.Like(lop.MaHocPhan.ToString(), "%" + txtTimKiem.Text + "%") select new { MaLop = lop.MaLop, SoLuong = lop.SoLuong, MaHocPhan = lop.MaHocPhan, MaGV = lop.MaGV, MaMH = lop.MaMH };
                dataLop.DataSource = timKiemTenSV;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }
    }
}

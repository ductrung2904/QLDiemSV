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
            numSoLuong.Enabled = edit;
            cboMaGV.Enabled = edit;
            txtTTMaHP.Enabled = edit;
            cboMaMH.Enabled = edit;
            txtNoiHoc.Enabled = edit;
        }

        void loadData()
        {
            var query = from lop in db.Lops join mh in db.MonHocs on lop.MaMH equals mh.MaMH join gv in db.GiaoViens on lop.MaGV equals gv.MaGV where lop.MaMH == mh.MaMH && lop.MaGV == gv.MaGV
                        select new
                        {
                            MaLop = lop.MaLop, NoiHoc = lop.NoiHoc, MaHocPhan = lop.MaHocPhan, SoLuong = lop.SoLuong, MaGV = lop.MaGV, MaMH = lop.MaMH ,TenMH = mh.TenMH, TenGV = gv.TenGV, NgayBatDau = lop.NgayBatDau, NgayKetThuc = lop.NgayKetThuc
                        };
            dataLop.DataSource = query;
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dataLop.AutoGenerateColumns = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            rdbMaMH.Checked = true;
            txtMaLop.Enabled = false;
            txtMaGV.Enabled = false;
            txtTenGV.Enabled = false;
            txtTenMH.Enabled = false;
            txtMaMH.Enabled = false;
            txtMaLop2.Enabled = false;

            cboMaMH.DataSource = db.MonHocs.ToList();
            cboMaMH.ValueMember = "MaMH";
            cboMaMH.DisplayMember = "MaMH";

            cboMaGV.DataSource = db.GiaoViens.ToList();
            cboMaGV.ValueMember = "MaGV";
            cboMaGV.DisplayMember = "MaGV";
        }

        private void dgvSinhVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaLop.Text = dataLop.CurrentRow.Cells[0].Value.ToString();
            txtMaLop2.Text = dataLop.CurrentRow.Cells[0].Value.ToString();

            txtMaMH.Text = dataLop.CurrentRow.Cells[5].Value.ToString();
            cboMaMH.Text = dataLop.CurrentRow.Cells[5].Value.ToString();

            txtTenMH.Text = dataLop.CurrentRow.Cells[6].Value.ToString();

            txtMaHP.Text = dataLop.CurrentRow.Cells[2].Value.ToString();
            txtTTMaHP.Text = dataLop.CurrentRow.Cells[2].Value.ToString();

            txtNoiHoc.Text = dataLop.CurrentRow.Cells[1].Value.ToString();

            txtMaGV.Text = dataLop.CurrentRow.Cells[4].Value.ToString();
            cboMaGV.Text = dataLop.CurrentRow.Cells[4].Value.ToString();
            txtTenGV.Text = dataLop.CurrentRow.Cells[7].Value.ToString();

            numSoLuong.Text = dataLop.CurrentRow.Cells[3].Value.ToString();

            dtpNgayBatDau.Text = dataLop.CurrentRow.Cells[8].Value.ToString();
            dtpNgayKetThuc.Text = dataLop.CurrentRow.Cells[9].Value.ToString();
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

        public string tangMaTuDong()
        {
            var query = from lop in db.Lops select lop;
            dataLop.DataSource = query;
            dataLop.AutoGenerateColumns = false;
            string maTuDong = "";
            if (dataLop.Rows.Count <= 0)
            {
                maTuDong = "ML00000001";
            }
            else if (dataLop.Rows.Count > 0)
            {
                int k;
                maTuDong = "ML";
                k = dataLop.Rows.Count - 1;
                k = k + 1;
                if (k < 10)
                {
                    maTuDong = maTuDong + "0000000";
                }
                else if (k < 100)
                {
                    maTuDong = maTuDong + "000000";
                }
                else if (k < 1000)
                {
                    maTuDong = maTuDong + "00000";
                }
                else if (k < 10000)
                {
                    maTuDong = maTuDong + "0000";
                }
                else if (k < 100000)
                {
                    maTuDong = maTuDong + "000";
                }
                else if (k < 1000000)
                {
                    maTuDong = maTuDong + "00";
                }
                else if (k < 10000000)
                {
                    maTuDong = maTuDong + "0";
                }
                maTuDong = maTuDong + k.ToString();
            }
            return maTuDong;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaGV.Text = "";
            txtMaLop.Text = "";
            txtTenGV.Text = "";
            txtTenMH.Text = "";
            txtMaMH.Text = "";

            cboMaGV.Text = "";
            txtMaLop2.Text = tangMaTuDong();
            txtNoiHoc.Text = "";
            numSoLuong.Text = "0";
            txtTTMaHP.Text = "";
            cboMaMH.Text = "";
            dtpNgayBatDau.Value = new DateTime(year: 2020, month: 1, day: 1); 
            dtpNgayKetThuc.Value = new DateTime(year: 2020, month: 1, day: 1); 

            setControls(true);
            dataLop.Enabled = false;
            txtMaLop2.Focus();
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
            txtMaLop2.Focus();
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
            lop.MaLop = txtMaLop2.Text;
            lop.MaHocPhan = txtTTMaHP.Text;
            lop.SoLuong = Convert.ToInt32(Math.Round(numSoLuong.Value, 0)); 
            lop.MaGV = Int32.Parse(cboMaGV.Text);
            lop.MaMH = cboMaMH.Text;
            lop.NgayBatDau = dtpNgayBatDau.Value;
            lop.NgayKetThuc = dtpNgayKetThuc.Value;
            lop.NoiHoc = txtNoiHoc.Text;
            db.Lops.InsertOnSubmit(lop);
            db.SubmitChanges();

            var them = db.Lops.Where(x => x.MaHocPhan == lop.MaHocPhan).ToList();
            dataLop.DataSource = them;
            MessageBox.Show("Thêm thành công", "Thông Báo");
        }

        private void suaLop()
        {
            Lop lop = new Lop();
            lop = db.Lops.Where(x => x.MaLop.ToString() == this.txtMaLop.Text ).SingleOrDefault();
            lop.NoiHoc = txtNoiHoc.Text;
            lop.MaHocPhan = txtTTMaHP.Text;
            lop.MaGV = Int32.Parse(cboMaGV.Text);
            lop.SoLuong = Convert.ToInt32(Math.Round(numSoLuong.Value, 0));
            lop.MaMH = cboMaMH.Text;
            lop.NgayBatDau = dtpNgayBatDau.Value;
            lop.NgayKetThuc = dtpNgayKetThuc.Value;
            lop.NoiHoc = txtNoiHoc.Text;
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

            errSoLuong.Clear();
            errMaGV.Clear();
            errMaMH.Clear();
            errMaHP.Clear();
            errNoiHoc.Clear();
            errMaLop.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (numSoLuong.Text == "0" || numSoLuong.Text == "")
                errSoLuong.SetError(numSoLuong, "Số Lượng nhập phải lớn hơn không");
            else
                errSoLuong.Clear();

            if (cboMaGV.Text == "")
                errMaGV.SetError(cboMaGV, "Bạn chưa nhập giá trị mã giáo viên");
            else
                errMaGV.Clear();

            if (cboMaMH.Text == "")
                errMaMH.SetError(cboMaMH, "Bạn chưa nhập giá trị mã môn học");
            else
                errMaMH.Clear();

            if (txtTTMaHP.Text == "")
                errMaHP.SetError(txtTTMaHP, "Bạn chưa chọn giá trị mã học phần");
            else
                errMaHP.Clear();

            if (txtMaLop2.Text == "")
                errMaLop.SetError(txtMaLop, "Bạn chưa nhập giá trị mã lớp");
            else 
            {
                errMaLop.Clear(); 
            }
                
            if (txtNoiHoc.Text == "")
                errMaHP.SetError(txtTTMaHP, "Bạn chưa nhập giá trị nơi học");
            else
                errMaHP.Clear();

            if (txtTTMaHP.Text.ToString().Length > 0)
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

                errSoLuong.Clear();
                errMaGV.Clear();
                errMaMH.Clear();
                errMaHP.Clear();
            }

            else
            {
                MessageBox.Show("Thông tin bạn nhập còn thiếu hoặc chưa đúng", "Thông Báo");
                if (txtTTMaHP.Text.Length == 0)
                    txtMaLop.Focus();
                else if (numSoLuong.Text.Length == 0)
                    numSoLuong.Focus();
                else if (cboMaGV.Text.Length == 0)
                    cboMaGV.Focus();
                else if (cboMaMH.Text.Length == 0)
                    cboMaMH.Focus();
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
                    lop = db.Lops.Single(x => x.MaLop.ToString() == dataLop.CurrentRow.Cells[0].Value.ToString());
                    db.Lops.DeleteOnSubmit(lop);
                    db.SubmitChanges();

                    var xoa = db.Lops.Where(x => x.MaLop == lop.MaLop).ToList();
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
                var timKiemMaGV = from lop in db.Lops join mh in db.MonHocs on lop.MaMH equals mh.MaMH join gv in db.GiaoViens on lop.MaGV equals gv.MaGV
                                  where SqlMethods.Like(lop.MaGV.ToString(), "%" + txtTimKiem.Text + "%")
                                  select new { MaLop = lop.MaLop, NoiHoc = lop.NoiHoc, MaHocPhan = lop.MaHocPhan, SoLuong = lop.SoLuong, MaGV = lop.MaGV, MaMH = lop.MaMH, TenMH = mh.TenMH, TenGV = gv.TenGV, NgayBatDau = lop.NgayBatDau, NgayKetThuc = lop.NgayKetThuc };
                dataLop.DataSource = timKiemMaGV;
            }
            else if (rdbMaMH.Checked)
            {
                var timKiemMaMH = from lop in db.Lops join mh in db.MonHocs on lop.MaMH equals mh.MaMH join gv in db.GiaoViens on lop.MaGV equals gv.MaGV
                                  where SqlMethods.Like(lop.MaMH.ToString(), "%" + txtTimKiem.Text + "%")
                                  select new { MaLop = lop.MaLop, NoiHoc = lop.NoiHoc, MaHocPhan = lop.MaHocPhan, SoLuong = lop.SoLuong, MaGV = lop.MaGV, MaMH = lop.MaMH, TenMH = mh.TenMH, TenGV = gv.TenGV, NgayBatDau = lop.NgayBatDau, NgayKetThuc = lop.NgayKetThuc };
                dataLop.DataSource = timKiemMaMH;
            }
            else if (rdbMaHP.Checked)
            {
                var timKiemMaMH = from lop in db.Lops join mh in db.MonHocs on lop.MaMH equals mh.MaMH join gv in db.GiaoViens on lop.MaGV equals gv.MaGV
                                  where SqlMethods.Like(lop.MaHocPhan.ToString(), "%" + txtTimKiem.Text + "%")
                                  select new { MaLop = lop.MaLop, NoiHoc = lop.NoiHoc, MaHocPhan = lop.MaHocPhan, SoLuong = lop.SoLuong, MaGV = lop.MaGV, MaMH = lop.MaMH, TenMH = mh.TenMH, TenGV = gv.TenGV, NgayBatDau = lop.NgayBatDau, NgayKetThuc = lop.NgayKetThuc };
                dataLop.DataSource = timKiemMaMH;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }
    }
}

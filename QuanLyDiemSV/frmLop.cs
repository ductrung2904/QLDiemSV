﻿using System;
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
            cboMaHP.Enabled = edit;
            cboMaMH.Enabled = edit;
        }

        void loadData()
        {
            var query = from lop in db.Lops join mh in db.MonHocs on lop.MaMH equals mh.MaMH join gv in db.GiaoViens on lop.MaGV equals gv.MaGV where lop.MaMH == mh.MaMH && lop.MaGV == gv.MaGV select new {  MaHocPhan = lop.MaHocPhan, SoLuong = lop.SoLuong, MaGV = lop.MaGV, MaMH = lop.MaMH ,TenMH = mh.TenMH, TenGV = gv.TenGV, MaLop = lop.MaLop};
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
            txtMaHP.Enabled = false;
            txtMaGV.Enabled = false;
            txtTenGV.Enabled = false;
            txtTenMH.Enabled = false;
            txtMaMH.Enabled = false;

            cboMaMH.DataSource = db.MonHocs.ToList();
            cboMaMH.ValueMember = "MaMH";
            cboMaMH.DisplayMember = "MaMH";

            cboMaGV.DataSource = db.GiaoViens.ToList();
            cboMaGV.ValueMember = "MaGV";
            cboMaGV.DisplayMember = "MaGV";
        }

        private void dgvSinhVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHP.Text = dataLop.CurrentRow.Cells[0].Value.ToString();
            cboMaHP.Text = dataLop.CurrentRow.Cells[0].Value.ToString();
            numSoLuong.Text = dataLop.CurrentRow.Cells[1].Value.ToString();   
            txtMaMH.Text = dataLop.CurrentRow.Cells[3].Value.ToString();
            txtMaGV.Text = dataLop.CurrentRow.Cells[2].Value.ToString();
            txtTenMH.Text = dataLop.CurrentRow.Cells[4].Value.ToString();
            txtTenGV.Text = dataLop.CurrentRow.Cells[5].Value.ToString();
            cboMaGV.Text = dataLop.CurrentRow.Cells[2].Value.ToString();
            cboMaMH.Text = dataLop.CurrentRow.Cells[3].Value.ToString();
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
            txtMaMH.Text = "";


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
            lop.MaHocPhan = cboMaHP.Text;
            lop.SoLuong = Convert.ToInt32(Math.Round(numSoLuong.Value, 0)); 
            lop.MaGV = Int32.Parse(cboMaGV.Text);
            lop.MaMH = cboMaMH.Text;
            db.Lops.InsertOnSubmit(lop);
            db.SubmitChanges();

            var them = db.Lops.Where(x => x.MaHocPhan == lop.MaHocPhan).ToList();
            dataLop.DataSource = them;
            MessageBox.Show("Thêm thành công", "Thông Báo");
        }

        private void suaLop()
        {
            Lop lop = new Lop();
            lop = db.Lops.Where(x => x.MaHocPhan.ToString() == this.cboMaHP.GetItemText(this.cboMaHP.SelectedItem) && x.MaMH.ToString() == this.cboMaMH.GetItemText(this.cboMaMH.SelectedItem)).SingleOrDefault();
            lop.MaHocPhan = cboMaHP.Text;
            lop.MaGV = Int32.Parse(cboMaGV.Text);
            lop.SoLuong = Convert.ToInt32(Math.Round(numSoLuong.Value, 0));
            lop.MaMH = cboMaMH.Text;
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
            if (cboMaHP.Text == "")
                errMaHP.SetError(cboMaHP, "Bạn chưa nhập giá trị học phần");
            else
                errMaHP.Clear();

            if (cboMaHP.Text.ToString().Length > 0)
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
                if (cboMaHP.Text.Length == 0)
                    txtMaHP.Focus();
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
                    lop = db.Lops.Single(x => x.MaLop.ToString() == dataLop.CurrentRow.Cells[6].Value.ToString());
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
                var timKiemMaGV = from lop in db.Lops join mh in db.MonHocs on lop.MaMH equals mh.MaMH join gv in db.GiaoViens on lop.MaGV equals gv.MaGV where SqlMethods.Like(lop.MaGV.ToString(), "%" + txtTimKiem.Text + "%") select new { MaHocPhan = lop.MaHocPhan, SoLuong = lop.SoLuong, MaGV = lop.MaGV, MaMH = lop.MaMH, TenMH = mh.TenMH, TenGV = gv.TenGV };
                dataLop.DataSource = timKiemMaGV;
            }
            else if (rdbMaMH.Checked)
            {
                var timKiemMaMH = from lop in db.Lops join mh in db.MonHocs on lop.MaMH equals mh.MaMH join gv in db.GiaoViens on lop.MaGV equals gv.MaGV where SqlMethods.Like(lop.MaMH.ToString(), "%" + txtTimKiem.Text + "%") select new { MaHocPhan = lop.MaHocPhan, SoLuong = lop.SoLuong, MaGV = lop.MaGV, MaMH = lop.MaMH, TenMH = mh.TenMH, TenGV = gv.TenGV };
                dataLop.DataSource = timKiemMaMH;
            }
            else if (rdbMaHP.Checked)
            {
                var timKiemMaMH = from lop in db.Lops join mh in db.MonHocs on lop.MaMH equals mh.MaMH join gv in db.GiaoViens on lop.MaGV equals gv.MaGV where SqlMethods.Like(lop.MaHocPhan.ToString(), "%" + txtTimKiem.Text + "%") select new { MaHocPhan = lop.MaHocPhan, SoLuong = lop.SoLuong, MaGV = lop.MaGV, MaMH = lop.MaMH, TenMH = mh.TenMH, TenGV = gv.TenGV };
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

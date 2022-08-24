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
    public partial class frmNhapDiem : Form
    {
        //UserRole ur = new UserRole();
        public frmNhapDiem()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();
        int flag;

        private void setControls(bool edit)
        {
            cboMaSV.Enabled = edit;
            cboTenMH.Enabled = edit;
            cboMaLop.Enabled = edit;
            txtDiemLT.Enabled = edit;
            txtDiemTH.Enabled = edit;
        }

        void loadData()
        {
            var query = from d in db.Diems
                        join sv in db.SinhViens on d.MaSV equals sv.MaSV where d.MaSV == sv.MaSV
                        join mh in db.MonHocs on d.MaMH equals mh.MaMH where d.MaMH == mh.MaMH
                        join l in db.Lops on d.MaLop equals l.MaLop where d.MaLop == l.MaLop
                        join gv in db.GiaoViens on l.MaGV equals gv.MaGV
                        where d.MaLop == l.MaLop
                        select new { MaDiem = d.MaDiem, MaSV = sv.MaSV, TenSV = sv.TenSV, MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
            dgvDiem.DataSource = query;
        }

        private void frmNhapDiem_Load(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dgvDiem.Enabled = true;
            dgvDiem.AutoGenerateColumns = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaDiem.Enabled = false;
            txtMaSV.Enabled = false;
            txtTenSV.Enabled = false;
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtMaLop.Enabled = false;
            txtMaHP.Enabled = false;
            txtDiemTB.Enabled = false;
            txtDiemHe4.Enabled = false;
            txtDiemChu.Enabled = false;
            txtDanhGia.Enabled = false;
        }
        private void cboMaSV_Click(object sender, EventArgs e)
        {
            cboMaSV.DataSource = db.SinhViens.ToList();
            cboMaSV.ValueMember = "MaSV";
            cboMaSV.DisplayMember = "MaSV";
        }

        private void cboMaSV_SelectedValueChanged(object sender, EventArgs e)
        {
            var query = db.MonHocs
                .Join(db.SinhViens, mh => mh.MaNganh, sv => sv.MaNganh, (mh, sv) => new { mh, sv })
                .Join(db.NganhHocs, mhsv => mhsv.sv.MaNganh, ng => ng.MaNganh, (mhsv, ng) => new { mhsv, ng })
                .Where(mhsvng => mhsvng.mhsv.sv.MaSV == Convert.ToInt32(this.cboMaSV.GetItemText(this.cboMaSV.SelectedValue)))
                .Select(x => new { x.mhsv.mh.MaMH, x.mhsv.mh.TenMH, x.mhsv.sv.MaSV }).ToList();
            cboTenMH.DataSource = query;
            cboTenMH.ValueMember = "MaMH";
            cboTenMH.DisplayMember = "TenMH";
        }

        private void cboTenMH_SelectedValueChanged(object sender, EventArgs e)
        {
            var query = db.Lops.Where(x => x.MaMH == this.cboTenMH.GetItemText(this.cboTenMH.SelectedValue)).ToList();
            cboMaLop.DataSource = query;
            cboMaLop.ValueMember = "MaLop";
            cboMaLop.DisplayMember = "MaLop";

        }

        private void txtDiemLT_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validate không được nhập chữ
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // validate nhập được giá trị float
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiemTH_KeyPress(object sender, KeyPressEventArgs e)
        {
            // validate không được nhập chữ
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // validate nhập được giá trị float
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dgvDiem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDiem.Text = dgvDiem.CurrentRow.Cells[0].Value.ToString();

            cboMaSV.Text = dgvDiem.CurrentRow.Cells[1].Value.ToString();
            txtMaSV.Text = dgvDiem.CurrentRow.Cells[1].Value.ToString();

            txtTenSV.Text = dgvDiem.CurrentRow.Cells[2].Value.ToString();

            txtMaMH.Text = dgvDiem.CurrentRow.Cells[3].Value.ToString();
            cboTenMH.Text = dgvDiem.CurrentRow.Cells[4].Value.ToString();
            txtTenMH.Text = dgvDiem.CurrentRow.Cells[4].Value.ToString();

            cboMaLop.Text = dgvDiem.CurrentRow.Cells[5].Value.ToString();
            txtMaLop.Text = dgvDiem.CurrentRow.Cells[5].Value.ToString();

            txtMaHP.Text = dgvDiem.CurrentRow.Cells[6].Value.ToString();

            txtDiemLT.Text = (dgvDiem.CurrentRow.Cells[7].Value ?? DBNull.Value).ToString();
            txtDiemTH.Text = (dgvDiem.CurrentRow.Cells[8].Value ?? DBNull.Value).ToString();
            txtDiemTB.Text = (dgvDiem.CurrentRow.Cells[9].Value ?? DBNull.Value).ToString();
            txtDiemHe4.Text = (dgvDiem.CurrentRow.Cells[10].Value ?? DBNull.Value).ToString();
            txtDiemChu.Text = (dgvDiem.CurrentRow.Cells[11].Value ?? DBNull.Value).ToString();
            txtDanhGia.Text = (dgvDiem.CurrentRow.Cells[12].Value ?? DBNull.Value).ToString();
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
            dgvDiem.AutoGenerateColumns = false;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        public string tangMaTuDong()
        {
            var query = from d in db.Diems join sv in db.SinhViens on d.MaSV equals sv.MaSV where d.MaSV == sv.MaSV join mh in db.MonHocs on d.MaMH equals mh.MaMH where d.MaMH == mh.MaMH join l in db.Lops on d.MaLop equals l.MaLop where d.MaLop == l.MaLop select new { MaDiem = d.MaDiem, MaSV = sv.MaSV, TenSV = sv.TenSV, MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
            dgvDiem.DataSource = query;
            dgvDiem.AutoGenerateColumns = false;
            string maTuDong = "";
            if (dgvDiem.Rows.Count <= 0)
            {
                maTuDong = "MD00000001";
            }
            else if (dgvDiem.Rows.Count > 0)
            {
                int k;
                maTuDong = "MD";
                k = dgvDiem.Rows.Count;
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
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            txtMaLop.Text = "";
            txtMaHP.Text = "";

            txtMaDiem.Text = tangMaTuDong();
            cboMaSV.Text = "";
            cboTenMH.Text = "";
            cboMaLop.Text = "";
            txtDiemLT.Text = "";
            txtDiemTH.Text = "";
            txtDiemTB.Text = "";
            txtDiemHe4.Text = "";
            txtDiemChu.Text = "";
            txtDanhGia.Text = "";

            setControls(true);
            dgvDiem.Enabled = false;
            cboMaSV.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            flag = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setControls(true);
            dgvDiem.Enabled = false;
            cboMaSV.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            flag = 1;
        }

        private void themDiem()
        {
            Diem d = new Diem();
            d.MaDiem = txtMaDiem.Text;
            d.MaSV = Int32.Parse(cboMaSV.Text);
            d.MaMH = cboTenMH.SelectedValue.ToString();
            d.MaLop = cboMaLop.Text;
            if (d.DiemLT == null && d.DiemTH == null)
            {
                if (txtDiemLT.Text.Length > 0 && txtDiemTH.Text.Length == 0)
                {
                    d.DiemLT = float.Parse(txtDiemLT.Text);
                    d.DiemTH = null;
                    d.DiemTB = d.DiemLT;
                    d.DiemHe4 = (d.DiemTB * 4) / 10;
                    if (d.DiemTB != null)
                    {
                        //  Xếp loại điểm trung bình
                        if (d.DiemTB >= 8.5 && d.DiemTB <= 10)
                        {
                            d.DiemChu = "A";
                        }
                        else if (d.DiemTB >= 7 && d.DiemTB < 8.5)
                        {
                            d.DiemChu = "B";
                        }
                        else if (d.DiemTB >= 5.5 && d.DiemTB < 7)
                        {
                            d.DiemChu = "C";
                        }
                        else if (d.DiemTB >= 4 && d.DiemTB < 5.5)
                        {
                            d.DiemChu = "D";
                        }
                        else if (d.DiemTB < 4)
                        {
                            d.DiemChu = "F";
                        }
                        //  Đánh giá theo điểm trung bình
                        if (d.DiemTB >= 4)
                        {
                            d.DanhGia = "Đạt";
                        }
                        else if (d.DiemTB < 4)
                        {
                            d.DanhGia = "Thi lại";
                        }
                    }
                }
                else if (txtDiemLT.Text.Length > 0 && txtDiemTH.Text.Length > 0)
                {
                    d.DiemLT = float.Parse(txtDiemLT.Text);
                    d.DiemTH = float.Parse(txtDiemTH.Text);
                    d.DiemTB = (d.DiemLT + d.DiemTH) / 2;
                    d.DiemHe4 = (d.DiemTB * 4) / 10;
                    if (d.DiemTB != null)
                    {
                        //  Xếp loại điểm trung bình
                        if (d.DiemTB >= 8.5 && d.DiemTB <= 10)
                        {
                            d.DiemChu = "A";
                        }
                        else if (d.DiemTB >= 7 && d.DiemTB < 8.5)
                        {
                            d.DiemChu = "B";
                        }
                        else if (d.DiemTB >= 5.5 && d.DiemTB < 7)
                        {
                            d.DiemChu = "C";
                        }
                        else if (d.DiemTB >= 4 && d.DiemTB < 5.5)
                        {
                            d.DiemChu = "D";
                        }
                        else if (d.DiemTB < 4)
                        {
                            d.DiemChu = "F";
                        }
                        //  Đánh giá theo điểm trung bình
                        if (d.DiemTB >= 4)
                        {
                            d.DanhGia = "Đạt";
                        }
                        else if (d.DiemTB < 4)
                        {
                            d.DanhGia = "Thi lại";
                        }
                    }
                }
            }
            db.Diems.InsertOnSubmit(d);
            db.SubmitChanges();

            loadData();
            MessageBox.Show("Thêm thành công", "Thông Báo");
        }

        private void suaDiem()
        {
            Diem d = new Diem();
            d = db.Diems.Where(x => x.MaDiem.ToString() == txtMaDiem.Text).SingleOrDefault();
            d.MaSV = Int32.Parse(cboMaSV.Text);
            //d.MaMH = cboTenMH.SelectedValue.ToString();
            d.MaLop = cboMaLop.Text;
            if (txtDiemLT.Text.Length > 0 && txtDiemTH.Text.Length == 0)
            {
                d.DiemLT = float.Parse(txtDiemLT.Text);
                d.DiemTH = null;
                d.DiemTB = d.DiemLT;
                d.DiemHe4 = (d.DiemTB * 4) / 10;
                if (d.DiemTB != null)
                {
                    //  Xếp loại điểm trung bình
                    if (d.DiemTB >= 8.5 && d.DiemTB <= 10)
                    {
                        d.DiemChu = "A";
                    }
                    else if (d.DiemTB >= 7 && d.DiemTB < 8.5)
                    {
                        d.DiemChu = "B";
                    }
                    else if (d.DiemTB >= 5.5 && d.DiemTB < 7)
                    {
                        d.DiemChu = "C";
                    }
                    else if (d.DiemTB >= 4 && d.DiemTB < 5.5)
                    {
                        d.DiemChu = "D";
                    }
                    else if (d.DiemTB < 4)
                    {
                        d.DiemChu = "F";
                    }
                    //  Đánh giá theo điểm trung bình
                    if (d.DiemTB >= 4)
                    {
                        d.DanhGia = "Đạt";
                    }
                    else if (d.DiemTB < 4)
                    {
                        d.DanhGia = "Không đạt";
                    }
                }
            }
            else if (txtDiemLT.Text.Length > 0 && txtDiemTH.Text.Length > 0)
            {
                d.DiemLT = float.Parse(txtDiemLT.Text);
                d.DiemTH = float.Parse(txtDiemTH.Text);
                d.DiemTB = (d.DiemLT + d.DiemTH) / 2;
                d.DiemHe4 = (d.DiemTB * 4) / 10;
                if (d.DiemTB != null)
                {
                    //  Xếp loại điểm trung bình
                    if (d.DiemTB >= 8.5 && d.DiemTB <= 10)
                    {
                        d.DiemChu = "A";
                    }
                    else if (d.DiemTB >= 7 && d.DiemTB < 8.5)
                    {
                        d.DiemChu = "B";
                    }
                    else if (d.DiemTB >= 5.5 && d.DiemTB < 7)
                    {
                        d.DiemChu = "C";
                    }
                    else if (d.DiemTB >= 4 && d.DiemTB < 5.5)
                    {
                        d.DiemChu = "D";
                    }
                    else if (d.DiemTB < 4)
                    {
                        d.DiemChu = "F";
                    }
                    //  Đánh giá theo điểm trung bình
                    if (d.DiemTB >= 4)
                    {
                        d.DanhGia = "Đạt";
                    }
                    else if (d.DiemTB < 4)
                    {
                        d.DanhGia = "Không đạt";
                    }
                }
            }

            db.SubmitChanges();

            loadData();
            MessageBox.Show("Sửa thành công", "Thông Báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dgvDiem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;

            errMaSV.Clear();
            errTenMH.Clear();
            errMaLop.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cboMaSV.Text == "")
                errMaSV.SetError(cboMaSV, "Vui lòng nhập mã sinh siên");
            else
                errMaSV.Clear();
            if (cboTenMH.Text == "")
                errTenMH.SetError(cboTenMH, "Vui lòng nhập tên môn học");
            else
                errTenMH.Clear();
            if (cboMaLop.Text == "")
                errMaLop.SetError(cboMaLop, "Vui lòng nhập mã lớp");
            else
                errMaLop.Clear();

            if (cboMaSV.Text.Length > 0 && cboTenMH.Text.Length > 0 && cboMaLop.Text.Length > 0 && txtDiemLT.Text.Length > 0)
            {
                if (float.Parse(txtDiemLT.Text) < 0 || float.Parse(txtDiemLT.Text) > 10)
                {
                    errDiemLT.SetError(txtDiemLT, "Điểm nhập vào phải lớn hơn 0 và nhỏ hơn 10");
                }

                else if (txtDanhGia.Text == "Đạt")
                {
                    MessageBox.Show("Bạn không thể sửa điểm được nữa");
                    loadData();
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    setControls(false);
                    dgvDiem.Enabled = true;
                }    

                else if (txtDiemTH.Text.Length > 0)
                {
                    errDiemLT.Clear();
                    if (float.Parse(txtDiemTH.Text) < 0 || float.Parse(txtDiemTH.Text) > 10)
                    {
                        errDiemTH.SetError(txtDiemTH, "Điểm nhập vào phải lớn hơn 0 và nhỏ hơn 10");
                    }
                    else if (txtDanhGia.Text == "Đạt")
                    {
                        MessageBox.Show("Bạn không thể sửa điểm được nữa");
                        loadData();
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        setControls(false);
                        dgvDiem.Enabled = true;
                    }
                    else
                    {
                        errDiemTH.Clear();
                        if (flag == 0)
                        {
                            themDiem();
                        }
                        else if (flag == 1)
                        {
                            suaDiem();
                        }
                        loadData();
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        btnThem.Enabled = true;
                        btnXoa.Enabled = true;
                        btnSua.Enabled = true;
                        setControls(false);
                        dgvDiem.Enabled = true;
                    }

                }

                else if (txtDanhGia.Text == "Không đạt")
                {
                    MessageBox.Show("Bạn không thể sửa điểm được nữa");
                    loadData();
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    setControls(false);
                    dgvDiem.Enabled = true;
                }

                else
                {
                    errDiemLT.Clear();
                    errDiemTH.Clear();
                    if (flag == 0)
                    {
                        themDiem();
                    }
                    else if (flag == 1)
                    {
                        suaDiem();
                    }
                    loadData();
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                    setControls(false);
                    dgvDiem.Enabled = true;

                    errMaSV.Clear();
                    errTenMH.Clear();
                    errMaLop.Clear();
                }
            }
            else
            {
                MessageBox.Show("Thông tin bạn nhập còn thiếu hoặc chưa đúng", "Thông Báo");
                if (cboMaSV.Text.Length == 0)
                    cboMaSV.Focus();
                else if (cboTenMH.Text.Length == 0)
                    cboTenMH.Focus();
                else if (cboMaLop.Text.Length == 0)
                    cboMaLop.Focus();
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
                    Diem d = new Diem();
                    d = db.Diems.Single(x => x.MaDiem.ToString() == txtMaDiem.Text);
                    db.Diems.DeleteOnSubmit(d);
                    db.SubmitChanges();

                    var xoa = db.Diems.Where(x => x.MaDiem == d.MaDiem).ToList();
                    dgvDiem.DataSource = xoa;
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
            if (rdbMaSV.Checked)
            {
                var timKiemMaSV = from d in db.Diems join sv in db.SinhViens on d.MaSV equals sv.MaSV where d.MaSV == sv.MaSV join mh in db.MonHocs on d.MaMH equals mh.MaMH where d.MaMH == mh.MaMH join l in db.Lops on d.MaLop equals l.MaLop where d.MaLop == l.MaLop where SqlMethods.Like(sv.MaSV.ToString(), "%" + txtTimKiem.Text + "%") select new { MaDiem = d.MaDiem, MaSV = d.MaSV, TenSV = sv.TenSV, MaMH = d.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
                dgvDiem.DataSource = timKiemMaSV;
            }
            else if (rdbTenSV.Checked)
            {
                var timKiemTenSV = from d in db.Diems join sv in db.SinhViens on d.MaSV equals sv.MaSV where d.MaSV == sv.MaSV join mh in db.MonHocs on d.MaMH equals mh.MaMH where d.MaMH == mh.MaMH join l in db.Lops on d.MaLop equals l.MaLop where d.MaLop == l.MaLop where SqlMethods.Like(sv.TenSV.ToString(), "%" + txtTimKiem.Text + "%") select new { MaDiem = d.MaDiem, MaSV = d.MaSV, TenSV = sv.TenSV, MaMH = d.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
                dgvDiem.DataSource = timKiemTenSV;
            }
            else if (rdbTenMH.Checked)
            {
                var timKiemTenMH = from d in db.Diems join sv in db.SinhViens on d.MaSV equals sv.MaSV where d.MaSV == sv.MaSV join mh in db.MonHocs on d.MaMH equals mh.MaMH where d.MaMH == mh.MaMH join l in db.Lops on d.MaLop equals l.MaLop where d.MaLop == l.MaLop where SqlMethods.Like(mh.TenMH.ToString(), "%" + txtTimKiem.Text + "%") select new { MaDiem = d.MaDiem, MaSV = d.MaSV, TenSV = sv.TenSV, MaMH = d.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
                dgvDiem.DataSource = timKiemTenMH;
            }
            else if (rdbMaLop.Checked)
            {
                var timKiemLop = from d in db.Diems join sv in db.SinhViens on d.MaSV equals sv.MaSV where d.MaSV == sv.MaSV join mh in db.MonHocs on d.MaMH equals mh.MaMH where d.MaMH == mh.MaMH join l in db.Lops on d.MaLop equals l.MaLop where d.MaLop == l.MaLop where SqlMethods.Like(l.MaHocPhan.ToString(), "%" + txtTimKiem.Text + "%") select new { MaDiem = d.MaDiem, MaSV = d.MaSV, TenSV = sv.TenSV, MaMH = d.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
                dgvDiem.DataSource = timKiemLop;
            }
        }
    }
}

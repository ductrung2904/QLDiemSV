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
    public partial class frmDKHP : Form
    {
        public frmDKHP()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();
        public int luuSL, luuSLHuy, luuSLSauDK, luuSLSauHuyDK, kiemTraDK;
        int role;

        public void SetData(string Data, int vaitro)
        {
            lblID2.Text = Data;
            role = vaitro;
        }

        void loadData()
        {
            var query = from mh in db.MonHocs
                        join l in db.Lops on mh.MaMH equals l.MaMH
                        join n in db.NganhHocs on mh.MaNganh equals n.MaNganh
                        join d in db.Diems on mh.MaMH equals d.MaMH
                        join sv in db.SinhViens on d.MaSV equals sv.MaSV
                        where mh.MaMH == l.MaMH && mh.MaNganh == n.MaNganh && d.MaLop == l.MaLop && d.MaMH == mh.MaMH && d.MaSV == sv.MaSV && sv.MaSV == Convert.ToInt32(lblID2.Text)
                        select new { MaDiem = d.MaDiem, MaLop = l.MaLop, MaHocPhan = l.MaHocPhan, TenMH = mh.TenMH, NoiHoc = l.NoiHoc, NgayBatDau = l.NgayBatDau, NgayKetThuc = l.NgayKetThuc, SoTiet = mh.SoTiet, SoTinChi = mh.SoTinChi, SoLuong = l.SoLuong, TrangThai = d.TrangThai };
            dgvDSLopDaDK.DataSource = query;
        }

        private void frmDKHP_Load(object sender, EventArgs e)
        {
            loadData();
            cboMonHoc.Enabled = false;
            cboLop.Enabled = false;
            btnDangKy.Enabled = false;
            dgvDSLopDaDK.Enabled = true;
            dgvDSLopDaDK.AutoGenerateColumns = false;
            dgvDSMoLop.Enabled = true;
            dgvDSMoLop.AutoGenerateColumns = false;
        }
        private void cboMonHoc_Click(object sender, EventArgs e)
        {
            var query = from mh in db.MonHocs join n in db.NganhHocs on mh.MaNganh equals n.MaNganh join sv in db.SinhViens on n.MaNganh equals sv.MaNganh where mh.MaNganh == n.MaNganh && n.MaNganh == sv.MaNganh && sv.MaSV == Convert.ToInt32(lblID2.Text) select new { MaMH = mh.MaMH, TenMH = mh.TenMH };
            cboMonHoc.DataSource = query;
            cboMonHoc.ValueMember = "MaMH";
            cboMonHoc.DisplayMember = "TenMH";
        }

        private void cboMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            var query = db.MonHocs
                .Join(db.Lops, mh => mh.MaMH, lop => lop.MaMH, (mh, lop) => new { mh, lop })
                .Join(db.NganhHocs, mhlop => mhlop.mh.MaNganh, ng => ng.MaNganh, (mhlop, ng) => new { mhlop, ng })
                .Where(mhlopng => mhlopng.mhlop.mh.MaMH == this.cboMonHoc.GetItemText(this.cboMonHoc.SelectedValue))
                .Select(x => new { x.mhlop.lop.MaLop, x.mhlop.lop.MaHocPhan, x.mhlop.mh.TenMH, x.mhlop.lop.NoiHoc, x.mhlop.lop.NgayBatDau, x.mhlop.lop.NgayKetThuc, x.mhlop.mh.SoTiet, x.mhlop.mh.SoTinChi, x.mhlop.lop.SoLuong }).ToList();
            dgvDSMoLop.DataSource = query;

            var query2 = db.Lops.Where(x => x.MaMH == this.cboMonHoc.GetItemText(this.cboMonHoc.SelectedValue)).ToList();
            cboLop.DataSource = query2;
            cboLop.ValueMember = "MaLop";
            cboLop.DisplayMember = "MaLop";
        }

        private void dgvDSLopDaDK_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cboMonHoc.Text = dgvDSLopDaDK.CurrentRow.Cells[3].Value.ToString();
            cboLop.Text = dgvDSLopDaDK.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            cboMonHoc.Enabled = true;
            cboLop.Enabled = true;
            cboMonHoc.Focus();
            btnDangKy.Enabled = true;
        }

        public string tangMaTuDong()
        {
            var query = from d in db.Diems join sv in db.SinhViens on d.MaSV equals sv.MaSV where d.MaSV == sv.MaSV join mh in db.MonHocs on d.MaMH equals mh.MaMH where d.MaMH == mh.MaMH join l in db.Lops on d.MaLop equals l.MaLop where d.MaLop == l.MaLop select new { MaDiem = d.MaDiem, MaSV = sv.MaSV, MaMH = mh.MaMH, MaLop = d.MaLop, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
            dgvDSMoLop.DataSource = query;
            dgvDSMoLop.AutoGenerateColumns = false;
            string maTuDong = "";
            if (dgvDSMoLop.Rows.Count <= 0)
            {
                maTuDong = "MD00000001";
            }
            else if (dgvDSMoLop.Rows.Count > 0)
            {
                int k;
                maTuDong = "MD";
                k = dgvDSMoLop.Rows.Count;
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

        private void dangKyHP()
        {
            Diem d = new Diem();
            d.MaDiem = tangMaTuDong();
            d.MaSV = Int32.Parse(lblID2.Text);
            d.MaMH = cboMonHoc.SelectedValue.ToString();
            d.MaLop = cboLop.Text;
            d.DiemLT = null;
            d.DiemTH = null;
            d.DiemTB = null;
            d.DiemHe4 = null;
            d.DiemChu = null;
            d.DanhGia = null;
            d.TrangThai = Convert.ToBoolean(0);
            db.Diems.InsertOnSubmit(d);
            db.SubmitChanges();

            var them = db.Diems.Where(x => x.MaDiem == d.MaDiem).ToList();
            dgvDSMoLop.DataSource = them;
            MessageBox.Show("Đăng ký thành công", "Thông Báo");
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (cboMonHoc.Text == "")
            {
                errMonHoc.SetError(cboMonHoc, "Vui lòng chọn môn học");
            }
            else
            {
                errMonHoc.Clear();
            }
            if (cboLop.Text == "")
            {
                errLop.SetError(cboLop, "Vui lòng chọn lớp");
            }
            else
            {
                errLop.Clear();
            }

            if (cboMonHoc.Text.Length > 0 && cboLop.Text.Length > 0)
            {
                string malop = cboLop.SelectedValue.ToString();
                var checkMaLop = from mh in db.MonHocs
                                 join l in db.Lops on mh.MaMH equals l.MaMH
                                 join n in db.NganhHocs on mh.MaNganh equals n.MaNganh
                                 join d in db.Diems on mh.MaMH equals d.MaMH
                                 join sv in db.SinhViens on d.MaSV equals sv.MaSV
                                 where mh.MaMH == l.MaMH && mh.MaNganh == n.MaNganh && d.MaLop == l.MaLop && d.MaMH == mh.MaMH && d.MaSV == sv.MaSV && sv.MaSV == Convert.ToInt32(lblID2.Text) && d.MaLop == malop
                                 select d.MaLop;
                if (checkMaLop.Count() > 0)
                {
                    MessageBox.Show("Bạn đã đăng ký lớp học phần này", "Thông Báo");
                }
                else
                {
                    errMonHoc.Clear();
                    dangKyHP();
                    loadData();
                    dgvDSMoLop.DataSource = false;
                    cboMonHoc.Enabled = false;
                    cboLop.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Thông tin bạn nhập còn thiếu hoặc chưa đúng", "Thông Báo");
                if (cboMonHoc.Text.Length == 0)
                    cboMonHoc.Focus();
                else if (cboLop.Text.Length == 0)
                    cboLop.Focus();
            }
        }

        private void btnHuyDK_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn hủy đăng ký", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                if (Boolean.Parse(dgvDSLopDaDK.CurrentRow.Cells[10].Value.ToString()) == true)
                {
                    MessageBox.Show("Bạn không thể hủy đăng ký học phần này", "Thông Báo");
                }
                else
                {
                    Diem d = new Diem();
                    d = db.Diems.Single(x => x.MaDiem.ToString() == dgvDSLopDaDK.CurrentRow.Cells[0].Value.ToString());
                    db.Diems.DeleteOnSubmit(d);
                    db.SubmitChanges();

                    var xoa = db.Diems.Where(x => x.MaDiem == d.MaDiem).ToList();
                    dgvDSLopDaDK.DataSource = xoa;
                    MessageBox.Show("Hủy đăng ký thành công", "Thông Báo");
                    loadData();
                    dgvDSMoLop.DataSource = false;
                    cboMonHoc.Enabled = false;
                    cboLop.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Hủy đăng ký thất bại", "Thông Báo");
            }
            loadData();
        }
    }
}

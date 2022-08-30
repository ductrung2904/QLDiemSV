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
    public partial class frmXemDiemSV : Form
    {
        int role;
        public frmXemDiemSV()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();
        public void SetData(string Data,int vaitro)
        {
            lblID2.Text = Data;
            role = vaitro;
        }

        void loadData()
        {
            var query = from sv in db.SinhViens join diem in db.Diems on sv.MaSV equals diem.MaSV
                        join lop in db.Lops on diem.MaLop equals lop.MaLop
                        join mh in db.MonHocs on diem.MaMH equals mh.MaMH where sv.MaSV == diem.MaSV && diem.MaLop == lop.MaLop && diem.MaMH == mh.MaMH && sv.MaSV == Convert.ToInt32(lblID2.Text) select new { MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = lop.MaLop, MaHocPhan = lop.MaHocPhan, DiemLT = diem.DiemLT, DiemTH = diem.DiemTH, DiemTB = diem.DiemTB, DiemHe4 = diem.DiemHe4, DanhGia = diem.DanhGia };
            dgvBangDiemSV.DataSource = query;
        }

        private void frmXemDiemSV_Load(object sender, EventArgs e)
        {
            loadData();
            dgvBangDiemSV.Enabled = true;
            dgvBangDiemSV.AutoGenerateColumns = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdbMaMH.Checked)
            {
                var timKiemMaMH = from sv in db.SinhViens join diem in db.Diems on sv.MaSV equals diem.MaSV join lop in db.Lops on diem.MaLop equals lop.MaLop join mh in db.MonHocs on diem.MaMH equals mh.MaMH where sv.MaSV == diem.MaSV && diem.MaLop == lop.MaLop && diem.MaMH == mh.MaMH && sv.MaSV == Convert.ToInt32(lblID2.Text) where SqlMethods.Like(mh.MaMH.ToString(), "%" + txtTimKiem.Text + "%") select new { MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = lop.MaLop, MaHocPhan = lop.MaHocPhan, DiemLT = diem.DiemLT, DiemTH = diem.DiemTH, DiemTB = diem.DiemTB, DiemHe4 = diem.DiemHe4, DanhGia = diem.DanhGia };
                dgvBangDiemSV.DataSource = timKiemMaMH;
            }
            else if (rdbTenMH.Checked)
            {
                var timKiemTenMH = from sv in db.SinhViens join diem in db.Diems on sv.MaSV equals diem.MaSV join lop in db.Lops on diem.MaLop equals lop.MaLop join mh in db.MonHocs on diem.MaMH equals mh.MaMH where sv.MaSV == diem.MaSV && diem.MaLop == lop.MaLop && diem.MaMH == mh.MaMH && sv.MaSV == Convert.ToInt32(lblID2.Text) where SqlMethods.Like(mh.TenMH.ToString(), "%" + txtTimKiem.Text + "%") select new { MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = lop.MaLop, MaHocPhan = lop.MaHocPhan, DiemLT = diem.DiemLT, DiemTH = diem.DiemTH, DiemTB = diem.DiemTB, DiemHe4 = diem.DiemHe4, DanhGia = diem.DanhGia };
                dgvBangDiemSV.DataSource = timKiemTenMH;
            }
            else if (rdbMaLop.Checked)
            {
                var timKiemMaLop = from sv in db.SinhViens join diem in db.Diems on sv.MaSV equals diem.MaSV join lop in db.Lops on diem.MaLop equals lop.MaLop join mh in db.MonHocs on diem.MaMH equals mh.MaMH where sv.MaSV == diem.MaSV && diem.MaLop == lop.MaLop && diem.MaMH == mh.MaMH && sv.MaSV == Convert.ToInt32(lblID2.Text) where SqlMethods.Like(lop.MaLop.ToString(), "%" + txtTimKiem.Text + "%") select new { MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = lop.MaLop, MaHocPhan = lop.MaHocPhan, DiemLT = diem.DiemLT, DiemTH = diem.DiemTH, DiemTB = diem.DiemTB, DiemHe4 = diem.DiemHe4, DanhGia = diem.DanhGia };
                dgvBangDiemSV.DataSource = timKiemMaLop;
            }
            else if (rdbMaHP.Checked)
            {
                var timKiemMaHP = from sv in db.SinhViens join diem in db.Diems on sv.MaSV equals diem.MaSV join lop in db.Lops on diem.MaLop equals lop.MaLop join mh in db.MonHocs on diem.MaMH equals mh.MaMH where sv.MaSV == diem.MaSV && diem.MaLop == lop.MaLop && diem.MaMH == mh.MaMH && sv.MaSV == Convert.ToInt32(lblID2.Text) where SqlMethods.Like(lop.MaHocPhan.ToString(), "%" + txtTimKiem.Text + "%") select new { MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = lop.MaLop, MaHocPhan = lop.MaHocPhan, DiemLT = diem.DiemLT, DiemTH = diem.DiemTH, DiemTB = diem.DiemTB, DiemHe4 = diem.DiemHe4, DanhGia = diem.DanhGia };
                dgvBangDiemSV.DataSource = timKiemMaHP;
            }
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            loadData();
            dgvBangDiemSV.AutoGenerateColumns = false;
        }
    }
}

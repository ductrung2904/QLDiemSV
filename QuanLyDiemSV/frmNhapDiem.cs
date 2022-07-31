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
    public partial class frmNhapDiem : Form
    {
        public frmNhapDiem()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();

        private void setControls(bool edit)
        {
            cboMaSV.Enabled = edit;
            cboTenMH.Enabled = edit;
            cboMaLop.Enabled = edit;
            numDiemLT.Enabled = edit;
            numDiemTH.Enabled = edit;
        }

        void loadData()
        {
            var query = from d in db.Diems join sv in db.SinhViens on d.MaSV equals sv.MaSV where sv.MaSV == d.MaSV join mh in db.MonHocs on d.MaMH equals mh.MaMH where mh.MaMH == d.MaMH join l in db.Lops on d.MaLop equals l.MaLop where l.MaLop == d.MaLop select new { MaSV = sv.MaSV, TenSV = sv.TenSV, MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH};
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

            txtMaSV.Enabled = false;
            txtTenSV.Enabled = false;
            txtMaMH.Enabled = false;
            txtTenMH.Enabled = false;
            txtMaLop.Enabled = false;

            //  load data vào cboTenMH
            cboTenMH.DataSource = db.MonHocs.ToList();
            cboTenMH.ValueMember = "MaMH";
            cboTenMH.DisplayMember = "TenMH";
            //  load data vào cboMaLop
            cboMaLop.DataSource = db.Lops.ToList();
            cboMaLop.ValueMember = "MaLop";
            cboMaLop.DisplayMember = "TenLop";
        }

        private void dgvDiem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cboMaSV.Text = dgvDiem.CurrentRow.Cells[0].Value.ToString();
            txtMaSV.Text = dgvDiem.CurrentRow.Cells[0].Value.ToString();
            txtTenSV.Text = dgvDiem.CurrentRow.Cells[1].Value.ToString();
            cboTenMH.Text = dgvDiem.CurrentRow.Cells[2].Value.ToString();
            txtMaMH.Text = dgvDiem.CurrentRow.Cells[2].Value.ToString();
            txtTenMH.Text = dgvDiem.CurrentRow.Cells[3].Value.ToString();
            cboMaLop.Text = dgvDiem.CurrentRow.Cells[4].Value.ToString();
            txtMaLop.Text = dgvDiem.CurrentRow.Cells[4].Value.ToString();
            numDiemLT.Text = dgvDiem.CurrentRow.Cells[5].Value.ToString();
            numDiemTH.Text = dgvDiem.CurrentRow.Cells[6].Value.ToString();
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
    }
}

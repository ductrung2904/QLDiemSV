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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSinhVien());
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNganhHoc());
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMonHoc());
        }

        private void btnLopHP_Click(object sender, EventArgs e)
        {
            openChildForm(new frmLop());
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            openChildForm(new frmGiaoVien());
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhapDiem());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeDiem());
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhau());
        }

        private void btnXemDiemSV_Click(object sender, EventArgs e)
        {
            openChildForm(new frmXemDiemSV());
        }

        private void btnDoiMatKhauGV_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhauGV());
        }

        private void btnDoiMatKhauSV_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhauSV());
        }

        private void btnNhapDiemGV_Click(object sender, EventArgs e)
        {
            openChildForm(new frmNhapDiemGV());
        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDKHP());
        }
    }
}

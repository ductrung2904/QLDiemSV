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
            //panelThongKe.Visible = false;
        }

        //private void hideMenu()
        //{
        //    if (panelThongKe.Visible == true)
        //        panelThongKe.Visible = false;
        //}

        //private void showMenu(Panel subMenu)
        //{
        //    if (subMenu.Visible == false)
        //    {
        //        hideMenu();
        //        subMenu.Visible = true;
        //    }
        //    else
        //        subMenu.Visible = false;
        //}

        //private void btnThongKe_Click(object sender, EventArgs e)
        //{
        //    showMenu(panelThongKe);
        //}

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
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new frmThongKeDiem());
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDoiMatKhau());
        }
    }
}

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
    public partial class frmNhapDiemGV : Form
    {
        int role;
        public frmNhapDiemGV()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();

        private void setControls(bool edit)
        {
            txtDiemLT.Enabled = edit;
            txtDiemTH.Enabled = edit;
        }

        public void SetData(string Data,int vaitro)
        {
            lblID2.Text = Data;
            role = vaitro;
        }

        void loadData()
        {
            var query = from d in db.Diems
                        join sv in db.SinhViens on d.MaSV equals sv.MaSV
                        where d.MaSV == sv.MaSV
                        join mh in db.MonHocs on d.MaMH equals mh.MaMH
                        where d.MaMH == mh.MaMH
                        join l in db.Lops on d.MaLop equals l.MaLop
                        where d.MaLop == l.MaLop
                        join gv in db.GiaoViens on l.MaGV equals gv.MaGV
                        where d.MaLop == l.MaLop && 
                        l.MaGV == gv.MaGV &&
                        gv.MaGV == Convert.ToInt32(lblID2.Text)
                        select new { MaDiem = d.MaDiem, MaSV = sv.MaSV, TenSV = sv.TenSV, MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
            dgvDiem.DataSource = query;
        }

        private void frmNhapDiemGV_Load(object sender, EventArgs e)
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

        private void dgvDiem_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDiem.Text = dgvDiem.CurrentRow.Cells[0].Value.ToString();
            txtMaSV.Text = dgvDiem.CurrentRow.Cells[1].Value.ToString();
            txtTenSV.Text = dgvDiem.CurrentRow.Cells[2].Value.ToString();
            txtMaMH.Text = dgvDiem.CurrentRow.Cells[3].Value.ToString();
            txtTenMH.Text = dgvDiem.CurrentRow.Cells[4].Value.ToString();
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
            btnNhapDiem.Enabled = true;
            loadData();
            dgvDiem.AutoGenerateColumns = false;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            txtTimKiem.Focus();
        }

        private void btnNhapDiem_Click(object sender, EventArgs e)
        {
            setControls(true);
            dgvDiem.Enabled = false;
            btnNhapDiem.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtDiemLT.Focus();
        }

        private void nhapDiem()
        {
            Diem d = new Diem();
            d = db.Diems.Where(x => x.MaDiem.ToString() == txtMaDiem.Text).SingleOrDefault();
            if (txtDanhGia.Text == "")
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
                d.TrangThai = Convert.ToBoolean(1);
            }
            else if (txtDanhGia.Text == "Thi lại")
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
                d.TrangThai = Convert.ToBoolean(1);
            }

            db.SubmitChanges();

            loadData();
            MessageBox.Show("Nhập điểm thành công", "Thông Báo");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            loadData();
            setControls(false);
            dgvDiem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnNhapDiem.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtDiemLT.Text == "")
                errDiemLT.SetError(txtDiemLT, "Vui lòng nhập điểm");
            else
                errDiemLT.Clear();

            if (txtDiemLT.Text.Length > 0)
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
                    btnNhapDiem.Enabled = true;
                    setControls(false);
                    dgvDiem.Enabled = true;
                }
                else if (txtDanhGia.Text == "Không đạt")
                {
                    MessageBox.Show("Bạn không thể sửa điểm được nữa");
                    loadData();
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnNhapDiem.Enabled = true;
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
                        btnNhapDiem.Enabled = true;
                        setControls(false);
                        dgvDiem.Enabled = true;
                    }
                    else
                    {
                        errDiemTH.Clear();
                        nhapDiem();

                        loadData();
                        btnLuu.Enabled = false;
                        btnHuy.Enabled = false;
                        btnNhapDiem.Enabled = true;
                        setControls(false);
                        dgvDiem.Enabled = true;
                    }
                }

                else
                {
                    errDiemLT.Clear();
                    errDiemTH.Clear();
                    nhapDiem();

                    loadData();
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                    btnNhapDiem.Enabled = true;
                    setControls(false);
                    dgvDiem.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Thông tin bạn nhập còn thiếu hoặc chưa đúng", "Thông Báo");
                if (txtDiemLT.Text.Length == 0)
                    txtDiemLT.Focus();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdbMaSV.Checked)
            {
                var timKiemMaSV = from d in db.Diems
                                  join sv in db.SinhViens on d.MaSV equals sv.MaSV
                                  where d.MaSV == sv.MaSV
                                  join mh in db.MonHocs on d.MaMH equals mh.MaMH
                                  where d.MaMH == mh.MaMH
                                  join l in db.Lops on d.MaLop equals l.MaLop
                                  where d.MaLop == l.MaLop
                                  join gv in db.GiaoViens on l.MaGV equals gv.MaGV
                                  where d.MaLop == l.MaLop &&
                                  l.MaGV == gv.MaGV &&
                                  gv.MaGV == Convert.ToInt32(lblID2.Text) &&
                                  SqlMethods.Like(sv.MaSV.ToString(), "%" + txtTimKiem.Text + "%")
                                  select new { MaDiem = d.MaDiem, MaSV = sv.MaSV, TenSV = sv.TenSV, MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
                dgvDiem.DataSource = timKiemMaSV;
            }
            else if (rdbTenSV.Checked)
            {
                var timKiemTenSV = from d in db.Diems
                                   join sv in db.SinhViens on d.MaSV equals sv.MaSV
                                   where d.MaSV == sv.MaSV
                                   join mh in db.MonHocs on d.MaMH equals mh.MaMH
                                   where d.MaMH == mh.MaMH
                                   join l in db.Lops on d.MaLop equals l.MaLop
                                   where d.MaLop == l.MaLop
                                   join gv in db.GiaoViens on l.MaGV equals gv.MaGV
                                   where d.MaLop == l.MaLop &&
                                   l.MaGV == gv.MaGV &&
                                   gv.MaGV == Convert.ToInt32(lblID2.Text) &&
                                   SqlMethods.Like(sv.TenSV.ToString(), "%" + txtTimKiem.Text + "%")
                                   select new { MaDiem = d.MaDiem, MaSV = sv.MaSV, TenSV = sv.TenSV, MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
                dgvDiem.DataSource = timKiemTenSV;
            }
            else if (rdbTenMH.Checked)
            {
                var timKiemTenMH = from d in db.Diems
                                   join sv in db.SinhViens on d.MaSV equals sv.MaSV
                                   where d.MaSV == sv.MaSV
                                   join mh in db.MonHocs on d.MaMH equals mh.MaMH
                                   where d.MaMH == mh.MaMH
                                   join l in db.Lops on d.MaLop equals l.MaLop
                                   where d.MaLop == l.MaLop
                                   join gv in db.GiaoViens on l.MaGV equals gv.MaGV
                                   where d.MaLop == l.MaLop &&
                                   l.MaGV == gv.MaGV &&
                                   gv.MaGV == Convert.ToInt32(lblID2.Text) &&
                                   SqlMethods.Like(mh.TenMH.ToString(), "%" + txtTimKiem.Text + "%")
                                   select new { MaDiem = d.MaDiem, MaSV = sv.MaSV, TenSV = sv.TenSV, MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
                dgvDiem.DataSource = timKiemTenMH;
            }
            else if (rdbMaLop.Checked)
            {
                var timKiemLop = from d in db.Diems
                                 join sv in db.SinhViens on d.MaSV equals sv.MaSV
                                 where d.MaSV == sv.MaSV
                                 join mh in db.MonHocs on d.MaMH equals mh.MaMH
                                 where d.MaMH == mh.MaMH
                                 join l in db.Lops on d.MaLop equals l.MaLop
                                 where d.MaLop == l.MaLop
                                 join gv in db.GiaoViens on l.MaGV equals gv.MaGV
                                 where d.MaLop == l.MaLop &&
                                 l.MaGV == gv.MaGV &&
                                 gv.MaGV == Convert.ToInt32(lblID2.Text) &&
                                 SqlMethods.Like(l.MaHocPhan.ToString(), "%" + txtTimKiem.Text + "%")
                                 select new { MaDiem = d.MaDiem, MaSV = sv.MaSV, TenSV = sv.TenSV, MaMH = mh.MaMH, TenMH = mh.TenMH, MaLop = d.MaLop, MaHocPhan = l.MaHocPhan, DiemLT = d.DiemLT, DiemTH = d.DiemTH, DiemTB = d.DiemTB, DiemHe4 = d.DiemHe4, DiemChu = d.DiemChu, DanhGia = d.DanhGia };
                dgvDiem.DataSource = timKiemLop;
            }
        }
    }
}

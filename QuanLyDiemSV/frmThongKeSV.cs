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
    public partial class frmThongKeSV : Form
    {
        public frmThongKeSV()
        {
            InitializeComponent();
        }
        QLDiemSVDataContext db = new QLDiemSVDataContext();
        void loadData()
        {
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*var query = from sv in db.SinhViens
                        join nh in db.NganhHocs on sv.MaNganh equals nh.MaNganh
                        where sv.MaNganh == nh.MaNganh
                        select new
                        {
                            MaLop = lop.MaLop,
                            NoiHoc = lop.NoiHoc,
                            MaHocPhan = lop.MaHocPhan,
                            SoLuong = lop.SoLuong,
                            MaGV = lop.MaGV,
                            MaMH = lop.MaMH,
                            TenMH = mh.TenMH,
                            TenGV = gv.TenGV,
                            NgayBatDau = lop.NgayBatDau,
                            NgayKetThuc = lop.NgayKetThuc
                        };
            dataTK1.DataSource = query;*/
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var query = from sv in db.SinhViens
                        join nh in db.NganhHocs on sv.MaNganh equals nh.MaNganh
                        where sv.MaNganh == nh.MaNganh && sv.MaNganh == cboThongKe1.Text
                        select new
                        {
                            MaSV = sv.MaSV,
                            TenSV = sv.TenSV,
                            NgaySinh = sv.NgaySinh,
                            GioiTinh = sv.GioiTinh,
                            DiaChi = sv.DiaChi,
                            DienThoai = sv.DienThoai,
                            Username = sv.Username,
                            GhiChu = sv.GhiChu,
                            MaNganh = sv.MaNganh,
                            TenNganh = nh.TenNganh
                        };
            datatk2.DataSource = query;
        }

        private void frmThongKeSV_Load(object sender, EventArgs e)
        {
            cboThongKe1.DataSource = db.NganhHocs.ToList();
            cboThongKe1.ValueMember = "MaNganh";
            cboThongKe1.DisplayMember = "MaNganh";

            cboThongKe2.DataSource = db.Lops.ToList();
            cboThongKe2.ValueMember = "MaLop";
            cboThongKe2.DisplayMember = "MaLop";
        }
    }
}

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
    public partial class frmThongKeDiem : Form
    {
        QLDiemSVDataContext db = new QLDiemSVDataContext();

        public frmThongKeDiem()
        {
            InitializeComponent();
        }
        void loadData()
        {
            cboMonHoc.Enabled = false;
            cboLopHP.Enabled = false;
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (cboNganhHoc.GetItemText(cboNganhHoc.SelectedItem) == "")
            {
                errNH.SetError(cboNganhHoc, "Bạn chưa chọn Ngành học!");
            }
            else if (cboMonHoc.Text == "")
            {              
                var query = from diem in db.Diems
                            group diem by diem.MaSV into diemSV

                            join sv in db.SinhViens on diemSV.FirstOrDefault().MaSV equals sv.MaSV
                            join nh in db.NganhHocs on sv.MaNganh equals nh.MaNganh
                            join lop in db.Lops on diemSV.FirstOrDefault().MaLop equals lop.MaLop
                            join mh in db.MonHocs on lop.MaMH equals mh.MaMH                  
                            where   nh.MaNganh == mh.MaNganh &&
                                    nh.MaNganh == sv.MaNganh &&
                                    sv.MaSV == diemSV.FirstOrDefault().MaSV &&
                                    mh.MaMH == lop.MaMH &&
                                    nh.MaNganh.ToString() == cboNganhHoc.GetItemText(cboNganhHoc.SelectedItem)
                            select new
                            {
                                MaSV = sv.MaSV,
                                TenSV = sv.TenSV,
                                TenNganh = nh.TenNganh,
                                DiemTB = Math.Round(double.Parse(diemSV.Average(x => x.DiemTB).ToString()), 2),
                                DiemH4 = Math.Round(double.Parse((diemSV.Average(x => x.DiemTB)*4/10).ToString()), 2),
                                SoTC = diemSV.Sum(x => x.MonHoc.SoTinChi)
                            };

                dgvThongKeDiemSV.DataSource = query;
           }
            else if (cboLopHP.Text == "")
            {
                var query = from diem in db.Diems
                            group diem by diem.MaSV into diemSV

                            join sv in db.SinhViens on diemSV.FirstOrDefault().MaSV equals sv.MaSV
                            join nh in db.NganhHocs on sv.MaNganh equals nh.MaNganh
                            join lop in db.Lops on diemSV.FirstOrDefault().MaLop equals lop.MaLop
                            join mh in db.MonHocs on lop.MaMH equals mh.MaMH
                            where nh.MaNganh == mh.MaNganh &&
                                    nh.MaNganh == sv.MaNganh &&
                                    sv.MaSV == diemSV.FirstOrDefault().MaSV &&
                                    mh.MaMH == lop.MaMH &&
                                    nh.MaNganh.ToString() == this.cboNganhHoc.GetItemText(this.cboNganhHoc.SelectedItem) &&
                                    mh.MaMH.ToString() == this.cboMonHoc.GetItemText(this.cboMonHoc.SelectedItem)
                            select new
                            {
                                MaSV = sv.MaSV,
                                TenSV = sv.TenSV,
                                TenNganh = nh.TenNganh,
                                DiemTB = Math.Round(double.Parse(diemSV.Average(x => x.DiemTB).ToString()), 2),
                                DiemH4 = Math.Round(double.Parse((diemSV.Average(x => x.DiemTB) * 4 / 10).ToString()), 2),
                                SoTC = diemSV.Sum(x => x.MonHoc.SoTinChi)
                            };

                dgvThongKeDiemSV.DataSource = query;
            }
            else
            {
                var query = from diem in db.Diems
                            group diem by diem.MaSV into diemSV

                            join sv in db.SinhViens on diemSV.FirstOrDefault().MaSV equals sv.MaSV
                            join nh in db.NganhHocs on sv.MaNganh equals nh.MaNganh
                            join lop in db.Lops on diemSV.FirstOrDefault().MaLop equals lop.MaLop
                            join mh in db.MonHocs on lop.MaMH equals mh.MaMH
                            where nh.MaNganh == mh.MaNganh &&
                                    nh.MaNganh == sv.MaNganh &&
                                    sv.MaSV == diemSV.FirstOrDefault().MaSV &&
                                    mh.MaMH == lop.MaMH &&
                                    nh.MaNganh.ToString() == this.cboNganhHoc.GetItemText(this.cboNganhHoc.SelectedItem) &&
                                    mh.MaMH.ToString() == this.cboMonHoc.GetItemText(this.cboMonHoc.SelectedItem) &&
                                    lop.MaHocPhan.ToString() == this.cboLopHP.GetItemText(this.cboLopHP.SelectedItem)
                            select new
                            {
                                MaSV = sv.MaSV,
                                TenSV = sv.TenSV,
                                TenNganh = nh.TenNganh,
                                DiemTB = Math.Round(double.Parse(diemSV.Average(x => x.DiemTB).ToString()), 2),
                                DiemH4 = Math.Round(double.Parse((diemSV.Average(x => x.DiemTB) * 4 / 10).ToString()), 2),
                                SoTC = diemSV.Sum(x => x.MonHoc.SoTinChi)
                            };

                dgvThongKeDiemSV.DataSource = query;
            }           
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (saveFileDialogExcel.ShowDialog() == DialogResult.OK)
            {
                toExcel(dgvThongKeDiemSV, saveFileDialogExcel.FileName);
            }
        }

        private void toExcel(DataGridView dgvThongKeDiemSV, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;

            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                worksheet.Name = "BANG THONG KE SINH VIEN";

                for (int i = 0; i < dgvThongKeDiemSV.ColumnCount; i++)
                {
                    worksheet.Cells[1, 1 + i] = dgvThongKeDiemSV.Columns[i].HeaderText;
                    
                }

                for (int i = 0; i < dgvThongKeDiemSV.RowCount; i++)
                {
                    for (int y = 0; y < dgvThongKeDiemSV.ColumnCount; y++)
                    {
                        worksheet.Cells[i + 2, y + 1] = dgvThongKeDiemSV.Rows[i].Cells[y].Value.ToString();
                    }
                    worksheet.Columns[i + 1].ColumnWidth = 15;
                }

                workbook.SaveAs(fileName);
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu thành công.!");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboLopHP.SelectedValue = "";
            cboMonHoc.SelectedValue = "";
            cboNganhHoc.SelectedValue = "";

            dgvThongKeDiemSV.DataSource = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongKeDiem_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void cboNganhHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            var mh_Theo_NganhHoc = db.MonHocs.
                Where(x => x.MaNganh == this.cboNganhHoc.GetItemText(this.cboNganhHoc.SelectedItem)).ToList();

            cboMonHoc.DataSource = mh_Theo_NganhHoc;
            cboMonHoc.ValueMember = "MaMH";
            cboMonHoc.DisplayMember = "MaMH";

            cboMonHoc.Text = "";
            cboLopHP.Text = "";
        }

        private void cboMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            var lh_Theo_MonHoc = db.Lops.
                Where(x => x.MaMH == this.cboMonHoc.GetItemText(this.cboMonHoc.SelectedItem)).ToList();

            cboLopHP.DataSource = lh_Theo_MonHoc;
            cboLopHP.ValueMember = "MaHocPhan";
            cboLopHP.DisplayMember = "MaHocPhan";

            cboLopHP.Text = "";
        }

        private void cboNganhHoc_Click(object sender, EventArgs e)
        {
            cboMonHoc.Enabled = true;
            errNH.Clear();

            cboNganhHoc.DataSource = db.NganhHocs.ToList();
            cboNganhHoc.ValueMember = "MaNganh";
            cboNganhHoc.DisplayMember = "MaNganh";
        }

        private void cboMonHoc_Click(object sender, EventArgs e)
        {
            cboLopHP.Enabled = true;
        }
    }
}


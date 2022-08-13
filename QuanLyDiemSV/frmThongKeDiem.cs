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
            if( cboNganhHoc.Text == "")
            {
                errNH.SetError(cboNganhHoc, "Bạn chưa chọn Ngành học!");
            }
            else if(cboMonHoc.Text == "")
            {
                var query = from nh in db.NganhHocs
                            join sv in db.SinhViens on nh.MaNganh equals sv.MaNganh
                            join mh in db.MonHocs on nh.MaNganh equals mh.MaNganh
                            join diem in db.Diems on sv.MaSV equals diem.MaSV
                            join lop in db.Lops on mh.MaMH equals lop.MaMH
                            where   nh.MaNganh.ToString() == this.cboNganhHoc.GetItemText(this.cboNganhHoc.SelectedItem) 
                            select new
                            {
                                MaSV = sv.MaSV,
                                TenSV = sv.TenSV,
                                MaNganh = nh.MaNganh,
                                TenMH = mh.TenMH,
                                MaLop = lop.MaLop,
                                MaHocPhan = lop.MaHocPhan,
                                DiemLT = Math.Round(double.Parse(diem.DiemLT.ToString()), 2),
                                DiemTH = Math.Round(double.Parse(diem.DiemTH.ToString()), 2),
                                DiemTB = Math.Round(double.Parse(diem.DiemTB.ToString()), 2),
                                DiemH4 = Math.Round(double.Parse(diem.DiemHe4.ToString()), 2),
                            };

                dgvThongKeDiemSV.DataSource = query;
            }
            else if(cboLopHP.Text == "")
            {
                var query = from nh in db.NganhHocs
                            join sv in db.SinhViens on nh.MaNganh equals sv.MaNganh
                            join mh in db.MonHocs on nh.MaNganh equals mh.MaNganh
                            join diem in db.Diems on sv.MaSV equals diem.MaSV
                            join lop in db.Lops on mh.MaMH equals lop.MaMH
                            where nh.MaNganh.ToString() == this.cboNganhHoc.GetItemText(this.cboNganhHoc.SelectedItem) &&
                                    mh.MaMH.ToString() == this.cboMonHoc.GetItemText(this.cboMonHoc.SelectedItem) 
                            select new
                            {
                                MaSV = sv.MaSV,
                                TenSV = sv.TenSV,
                                MaNganh = nh.MaNganh,
                                TenMH = mh.TenMH,
                                MaLop = lop.MaLop,
                                MaHocPhan = lop.MaHocPhan,
                                DiemLT = Math.Round(double.Parse(diem.DiemLT.ToString()), 2),
                                DiemTH = Math.Round(double.Parse(diem.DiemTH.ToString()), 2),
                                DiemTB = Math.Round(double.Parse(diem.DiemTB.ToString()), 2),
                                DiemH4 = Math.Round(double.Parse(diem.DiemHe4.ToString()), 2),
                            };

                dgvThongKeDiemSV.DataSource = query;
            }
            else
            {
                var query = from nh in db.NganhHocs
                            join sv in db.SinhViens on nh.MaNganh equals sv.MaNganh
                            join mh in db.MonHocs on nh.MaNganh equals mh.MaNganh
                            join diem in db.Diems on sv.MaSV equals diem.MaSV
                            join lop in db.Lops on mh.MaMH equals lop.MaMH
                            where nh.MaNganh.ToString() == this.cboNganhHoc.GetItemText(this.cboNganhHoc.SelectedItem) &&
                                    mh.MaMH.ToString() == this.cboMonHoc.GetItemText(this.cboMonHoc.SelectedItem) &&
                                    lop.MaHocPhan.ToString() == this.cboLopHP.GetItemText(this.cboLopHP.SelectedItem)
                            select new
                            {
                                MaSV = sv.MaSV,
                                TenSV = sv.TenSV,
                                MaNganh = nh.MaNganh,
                                TenMH = mh.TenMH,
                                MaLop = lop.MaLop,
                                MaHocPhan = lop.MaHocPhan,
                                DiemLT = Math.Round(double.Parse(diem.DiemLT.ToString()), 2),
                                DiemTH = Math.Round(double.Parse(diem.DiemTH.ToString()), 2),
                                DiemTB = Math.Round(double.Parse(diem.DiemTB.ToString()), 2),
                                DiemH4 = Math.Round(double.Parse(diem.DiemHe4.ToString()), 2),
                            };

                dgvThongKeDiemSV.DataSource = query;
            }
            
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            /*DataSet customersDataSet = new DataSet();

            //Read the XML file with data
            string inputXmlPath = Path.GetFullPath(@"../../Data/Employees.xml");
            customersDataSet.ReadXml(inputXmlPath);
            DataTable dataTable = new DataTable();

            //Copy the structure and data of the table
            dataTable = customersDataSet.Tables[1].Copy();

            //Removing unwanted columns
            dataTable.Columns.RemoveAt(0);
            dataTable.Columns.RemoveAt(10);
            this.dataGridView1.DataSource = dataTable;

            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold)));
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.BorderStyle = BorderStyle.None;
#endregion

            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;

                //Create a workbook with single worksheet
                IWorkbook workbook = application.Workbooks.Create(1);

                IWorksheet worksheet = workbook.Worksheets[0];

                //Import from DataGridView to worksheet
                worksheet.ImportDataGridView(dataGridView1, 1, 1, isImportHeader: true, isImportStyle: true);

                worksheet.UsedRange.AutofitColumns();
                workbook.SaveAs("Output.xlsx");
            }*/
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboLopHP.Text = "";
            cboMonHoc.Text = "";
            cboNganhHoc.Text = "";

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

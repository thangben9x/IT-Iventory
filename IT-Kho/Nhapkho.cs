using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.Drawing;

namespace IT_Kho
{
    public partial class Nhapkho : DevExpress.XtraEditors.XtraUserControl
    {
        public Nhapkho()
        {
            InitializeComponent();
        }
        private static Nhapkho _instance;

        public static Nhapkho Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Nhapkho();
                return _instance;
            }
        }
        private void hien()
        {
            try
            {
                string sql = "SELECT model , Nhap.masp,tensp,slnhap,dvt,ngaynhap,ncc,sn,ghichu,barcode, NhanVien.username  FROM Nhap INNER JOIN NhanVien ON NhanVien.manv = Nhap.manv";

                gridControl1.DataSource = Connect.getTable(sql);

            }
            catch
            {
                XtraMessageBox.Show("Không thể kết nối tới CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void Nhapkho_Load(object sender, EventArgs e)
        {
            hien();
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = "";
            bool bVali = true;
            // kiem tra cell cua mot dong dang Edit xem co rong ko?
            if (gridView1.GetRowCellValue(e.RowHandle, "model").ToString() == "" || gridView1.GetRowCellValue(e.RowHandle, "masp").ToString() == "" || gridView1.GetRowCellValue(e.RowHandle, "slnhap").ToString() == "" || gridView1.GetRowCellValue(e.RowHandle, "dvt").ToString() == "" || gridView1.GetRowCellValue(e.RowHandle, "ngaynhap").ToString() == ""
                    || gridView1.GetRowCellValue(e.RowHandle, "manv").ToString() == "" || gridView1.GetRowCellValue(e.RowHandle, "ncc").ToString() == "" || gridView1.GetRowCellValue(e.RowHandle, "barcode").ToString() == "" || gridView1.GetRowCellValue(e.RowHandle, "sn").ToString() == "" || gridView1.GetRowCellValue(e.RowHandle, "ghichu").ToString() == "" || gridView1.GetRowCellValue(e.RowHandle, "sn").ToString() == "" || gridView1.GetRowCellValue(e.RowHandle, "tensp").ToString() == "")
            {
                // chuỗi thông báo lỗi
                bVali = false;
                sErr = sErr + "Vui lòng điền đầy đủ thông tin!! Nhấn OK để load lại form nhập!!";
            }
            if (bVali)
            {
                //lưu giá trị hiển thị trên gridview vào các biến tương ứng
                string model = gridView1.GetRowCellValue(e.RowHandle, "model").ToString();
                string tensp = gridView1.GetRowCellValue(e.RowHandle, "tensp").ToString();
                string masp = gridView1.GetRowCellValue(e.RowHandle, "masp").ToString();
                string slnhap = gridView1.GetRowCellValue(e.RowHandle, "slnhap").ToString();
                string dvt = gridView1.GetRowCellValue(e.RowHandle, "dvt").ToString();
                string ngaynhap = gridView1.GetRowCellValue(e.RowHandle, "ngaynhap").ToString();
                string manv = gridView1.GetRowCellValue(e.RowHandle, "manv").ToString();
                string ncc = gridView1.GetRowCellValue(e.RowHandle, "ncc").ToString();
                string sn = gridView1.GetRowCellValue(e.RowHandle, "sn").ToString();
                string barcode = gridView1.GetRowCellValue(e.RowHandle, "barcode").ToString();
                string ghichu = gridView1.GetRowCellValue(e.RowHandle, "ghichu").ToString();
                string id = gridView1.GetRowCellValue(e.RowHandle, "id").ToString();

                
                GridView view = sender as GridView;
                //kiểm tra xem dòng đang chọn có phải dòng mới không nếu đúng thì insert không thì update
                if (view.IsNewItemRow(e.RowHandle))
                {
                    try
                    {
                        string insert = "insert into Nhap values('" + model + "','" + masp + "','" + tensp + "','" + slnhap + "','" + dvt + "','" + Convert.ToDateTime(ngaynhap).ToString("MM/dd/yyyy") + "','" + manv + "','" + ghichu + "','" + ncc + "','" + sn + "','" + barcode + "')";
                        Connect.Query(insert);
                        hien();


                    }
                    catch
                    {
                        XtraMessageBox.Show("Không thể kết nối tới CSDL!!");
                    }
                }
                else
                {
                    try
                    {
                        string update = "update Nhap set masp = '" + masp + "', slnhap = '" + slnhap + "', dvt = '" + dvt + "',ngaynhap = '" + Convert.ToDateTime(ngaynhap).ToString("MM/dd/yyyy") + "', manv = '" + manv + "', ncc ='" + ncc + "' ,ghichu='" + ghichu + "',barcode='" + barcode + "',sn='" + sn + "', model = '" + model + "'where id = '" + id + "'";
                        Connect.Query(update);
                        hien();

                    }
                    catch
                    {
                        XtraMessageBox.Show("Không thể kết nối tới CSDL!!");
                    }
                }
            }
            else
            {
                DialogResult tb = XtraMessageBox.Show(sErr, "Lỗi trong quá trình nhập!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (tb == DialogResult.OK)
                {
                    // load lại form
                    hien();
                }
            }
        }
    }
    
}

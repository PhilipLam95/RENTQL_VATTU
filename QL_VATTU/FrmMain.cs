using QLYVATTU.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLYVATTU.VIEW.REPORT_VIEW;
using QL_VATTU.VIEW.REPORT_VIEW;

namespace QLYVATTU
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //goi view

        public static FrmMain INSTANCE;

        public FrmMain()
        {
            InitializeComponent();
        }

        private DataTable tenchinhanh;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetting();
            foreach(Connection cnn in Access.CnnList)
            {
                Console.WriteLine(cnn.ChiNhanh);
            }

            Connection[] myarray = Access.CnnList.ToArray();
           

            Console.WriteLine(Access.CnnList.ToArray());
            QLYVATTU.VIEW.DangNhap f = new QLYVATTU.VIEW.DangNhap() { MdiParent = this, Text = "Đăng nhập" };
            f.Show();

        }

        private void LoadSetting() // cài đặt begin
        {
            ChiNhanh chinhanh = new ChiNhanh();
            tenchinhanh = chinhanh.getChiNhanh();

            if (tenchinhanh == null)
            {
                MessageBox.Show("Lỗi CDSL! Không thể lấy danh sách chi nhánh");
                return;
            }
            else if (tenchinhanh.Rows.Count == 0)
            {
                MessageBox.Show("Trong CSDL không có chi nhánh nào . ");
                return;
            }

            foreach (DataRow dr in tenchinhanh.Rows)
            {
                Connection cnn = new Connection()
                {
                    ChiNhanh = dr["ChiNhanh"].ToString(),
                    DataSource = dr["DATASOURCE"].ToString(),
                    MaCN = dr["MACN"].ToString(),
                    DIACHI = dr["DIACHI"].ToString(),
                    SoDT = dr["SoDT"].ToString()
                };
                Access.CnnList.Add(cnn);

            }

        }




        // ----------------------------------------------Timer refresh data-------------------------------------------------------


        // -------------------------------------------------------------------------------------------------------------------------
        //check form 
        public Form CheckExists(Type ftype)
        {

            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public static void CheckFormNotInMdi(Type ftype)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        //Check Null Value TextBox()
        public bool CheckNullValue(TextBox textbox)
        {
            if (textbox.Text == "")
            {
                MessageBox.Show("Giá trị " + textbox.Tag + " không được để trống");
                return false;
            }
            return true;
        }

        public bool CheckNullValueCBox(ComboBox combobox)
        {
            if (combobox.Text == "")
            {
                MessageBox.Show("Giá trị " + combobox.Tag + " không được để trống");
                return false;
            }
            return true;
        }


        public bool CheckNullValueTextEdit(DevExpress.XtraEditors.TextEdit TextEdit)
        {
            if (TextEdit.Text == "")
            {
                MessageBox.Show("Giá trị " + TextEdit.Tag + " không được để trống");
                return false;
            }
            return true;
        }


        public bool CheckNullValueMasedTextBox(MaskedTextBox maskedTextBox)
        {
            if (string.IsNullOrEmpty(maskedTextBox.Mask))
            {
                MessageBox.Show("Giá trị " + maskedTextBox.Tag + " không được để trống");
                return false;
            }
            return true;
        }



        //----------------------------------------------------------GỌI FORM ----------------------------------------------------------
        private void btnLoaiHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//FORM LOAI HÀNG
        {
            //Form frm = this.CheckExists(typeof(VIEW.LoaiHang));
            //if (frm != null) frm.Activate();
            //else
            //{
            //    VIEW.LoaiHang f = new VIEW.LoaiHang() { MdiParent = this, Text = "Các loại hàng" };
            //    f.Show();
            //}
        }

        private void btnTaoTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//FORM TẠO TÀI KHOẢN
        {
            Form frm = this.CheckExists(typeof(VIEW.TaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.TaoTaiKhoan f = new VIEW.TaoTaiKhoan() { MdiParent = this, Text = "Tạo tài khoản" };
                f.Show();
            }
        }

        private void btnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//FORM DỔI MẬT KHẨU
        {
            Form frm = this.CheckExists(typeof(VIEW.DoiMatKhau));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.DoiMatKhau f = new VIEW.DoiMatKhau() { MdiParent = this, Text = "Đổi Mật Khẩu " };
                f.Show();
            }
        }


        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// FORM PHIẾU XUẤT
        {
            Form frm = this.CheckExists(typeof(VIEW.PhieuXuat));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.PhieuXuat f = new VIEW.PhieuXuat() { MdiParent = this, Text = "Phiếu xuất " };
                f.Show();
            }
        }


        private void btnHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form frm = this.CheckExists(typeof(VIEW.MatHang));
            //if (frm != null) frm.Activate();
            //else
            //{
            //    VIEW.MatHang f = new VIEW.MatHang() { MdiParent = this, Text = "Các mặt hàng " };
            //    f.Show();
            //}
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//form Don dat hàng
        {
            Form frm = this.CheckExists(typeof(VIEW.DonDatHang));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.DonDatHang f = new VIEW.DonDatHang() { MdiParent = this, Text = "Đơn Đặt Hàng " };
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//form nhập hàng
        {
            Form frm = this.CheckExists(typeof(QL_VATTU.VIEW.PhieuNhap));
            if (frm != null)
            {
                frm.Activate();

            }
            else
            {
                QL_VATTU.VIEW.PhieuNhap f = new QL_VATTU.VIEW.PhieuNhap() { MdiParent = this, Text = "Phiếu Nhâp " };
                f.Show();



            }
        }




        private void btnBaoCaoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(VIEW.REPORT_VIEW.ChiTietHangNhap));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.REPORT_VIEW.ChiTietHangNhap f = new VIEW.REPORT_VIEW.ChiTietHangNhap() { MdiParent = this, Text = "Báo Cáo Hàng " };
                f.Show();
            }
        }


        private void btnDangXuat_Click(object sender, EventArgs e) // form dang nhap
        {
            foreach (Form c in this.MdiChildren)
            {
                c.Close();
            }
            ReturnDefault();
            VIEW.DangNhap f = new VIEW.DangNhap() { MdiParent = this, Text = "Đăng nhập" };
            f.Show();
        }

        int x = 450, y = 85, a = 1;

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(VIEW.DSNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.DSNhanVien f = new VIEW.DSNhanVien() { MdiParent = this, Text = "Xem Danh Sách Nhân Viên" };
                f.Show();
            }


        }

        private void btnHDNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// FORM REPORT HOAT DONG NHAN VIEN
        {
            Form frm = this.CheckExists(typeof(HoatDongNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                HoatDongNhanVien f = new HoatDongNhanVien() { MdiParent = this, Text = "Xem Danh Sách Nhân Viên" };
                f.Show();
            }


        }

        private void btnDSNHANVIEN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) // form report danh sach nhan vien ben 
        {
            Form frm = this.CheckExists(typeof(DanhSachNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                DanhSachNhanVien f = new DanhSachNhanVien() { MdiParent = this, Text = "Danh sách nhân viên công ty" };
                f.Show();
            }
        }

        private void btnDanhMucKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) // form danh mục kho
        {
            Form frm = this.CheckExists(typeof(VIEW.DanhMucKho));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.DanhMucKho f = new VIEW.DanhMucKho() { MdiParent = this, Text = "Danh Mục Kho" };
                f.Show();
            }
        }

        private void btnDanhMucVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(VIEW.DanhMucVatTu));
            if (frm != null) frm.Activate();
            else
            {
                VIEW.DanhMucVatTu f = new VIEW.DanhMucVatTu() { MdiParent = this, Text = "Danh Mục Vat Tu" };
                f.Show();
            }
        }

        private void btnDSVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(DanhSachVatTu));
            if (frm != null) frm.Activate();
            else
            {
                DanhSachVatTu f = new DanhSachVatTu() { MdiParent = this, Text = "Danh sách vật tư" };
                f.Show();
            }
        }

        private void btnNhaCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form frm = this.CheckExists(typeof(VIEW.NhaCungCap));
            //if (frm != null) frm.Activate();
            //else
            //{
            //    VIEW.NhaCungCap f = new VIEW.NhaCungCap() { MdiParent = this, Text = "Nhà cung cấp" };
            //    f.Show();
            //}
        }

        //----------------------------------------------------------GỌI FORM ----------------------------------------------------------


        private void FrmMain_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }









        public void HienThiTrangChu()
        {
            btnLoaiHang.Enabled = true;
            btnHang.Enabled = true;
            btnNhaCC.Enabled = true;
            //btnKhachHang.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            //btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            btnDangXuat.Visible = true;
        }

        private void HienThiQuanLyNhanVien()
        {
            rbQLNhanvien.Visible = true;
            btnNhanVien.Enabled = true;
            btnTaoTK.Enabled = true;
        }

        private void HienThiKhoHang()
        {
            barButtonItem1.Enabled = true; // button lap don dat hang
            barButtonItem3.Enabled = true; // button phieu nhap
            barButtonItem4.Enabled = true; // button phieu xuat
            rbpNghiepVu.Visible = true;
        }

        private void HienThiBaoCao()
        {
            rbpBaoCao.Visible = true;
        }

        public void ReturnDefault()
        {
            btnLoaiHang.Enabled = false;
            btnHang.Enabled = false;
            btnNhaCC.Enabled = false;
            //btnKhachHang.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            // btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            btnDangXuat.Visible = false;
            rbQLNhanvien.Visible = false;
            rbpNghiepVu.Visible = false;
            rbpBaoCao.Visible = false;
            label1.Visible = false;
        }


        public void HienThiQuyen_User()
        {
            btnDoiMatKhau.Enabled = true;
            HienThiKhoHang();
            HienThiTrangChu();
            label1.Visible = true;
            label1.Text = "Xin chào " + Access.HOTEN;
            btnNhaCC.Enabled = false;
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }
        }

        public void HienThiQuyen_ChiNhanh()
        {
            label1.Visible = true;
            label1.Text = "Xin chào " + Access.HOTEN;
            HienThiTrangChu();
            HienThiQuanLyNhanVien();
            HienThiKhoHang();
            HienThiBaoCao();
            //HienThiQuanLyNhanVien();
            //HienThiKhoHang();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }
        }

        public void HienThiQuyen_CongTy()
        {
            label1.Visible = true;
            label1.Text = "Xin chào " + Access.HOTEN;
            btnDoiMatKhau.Enabled = true;
            //btnKhachHang.Enabled = true;
            rbpBaoCao.Visible = true;
            rbQLNhanvien.Visible = true;
            //btnMatHang.Enabled = true;
            btnDangXuat.Visible = true;
            btnTaoTK.Enabled = true;
            HienThiBaoCao();
            //HienThiQuanLyNhanVien();
            //HienThiKhoHang();
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Hide();
            }
        }

      

        Random random = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                label1.Location = new Point(x, y);
                if (x >= 800)
                {
                    a = -1;
                    label1.ForeColor = Color.FromArgb(random.Next(0, 225), random.Next(0, 225), random.Next(0, 225));
                }
                if (x < 450)
                {
                    a = 1;
                    label1.ForeColor = Color.FromArgb(random.Next(0, 225), random.Next(0, 225), random.Next(0, 225));
                }

            }
            catch
            {

            }
        }
    }
}
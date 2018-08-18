namespace QLYVATTU
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnMatHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhaCC = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTK = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackUpRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnHDNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSNHANVIEN = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhMucKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDSVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhMucVT = new DevExpress.XtraBars.BarButtonItem();
            this.rbHome = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpTaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpHeThong = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbDoiTac = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbQLNhanvien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpNghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnDangNhap,
            this.btnLoaiHang,
            this.btnMatHang,
            this.btnHang,
            this.btnNhaCC,
            this.barButtonItem1,
            this.barButtonItem3,
            this.barButtonItem4,
            this.btnNhanVien,
            this.btnTaoTK,
            this.barButtonItem7,
            this.btnDoiMatKhau,
            this.btnBaoCaoHang,
            this.btnBackUpRestore,
            this.btnHDNhanVien,
            this.btnDSNHANVIEN,
            this.btnDanhMucKho,
            this.btnDSVT,
            this.btnDanhMucVT});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 24;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbHome,
            this.rbQLNhanvien,
            this.rbpNghiepVu,
            this.rbpBaoCao});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(889, 143);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Id = 15;
            this.btnDangNhap.Name = "btnDangNhap";
            // 
            // btnLoaiHang
            // 
            this.btnLoaiHang.Caption = "LOẠI HÀNG";
            this.btnLoaiHang.Enabled = false;
            this.btnLoaiHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLoaiHang.Glyph")));
            this.btnLoaiHang.Id = 1;
            this.btnLoaiHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLoaiHang.LargeGlyph")));
            this.btnLoaiHang.Name = "btnLoaiHang";
            this.btnLoaiHang.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnLoaiHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLoaiHang_ItemClick);
            // 
            // btnMatHang
            // 
            this.btnMatHang.Id = 4;
            this.btnMatHang.Name = "btnMatHang";
            // 
            // btnHang
            // 
            this.btnHang.Caption = "MẶT HÀNG";
            this.btnHang.Enabled = false;
            this.btnHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHang.Glyph")));
            this.btnHang.Id = 3;
            this.btnHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHang.LargeGlyph")));
            this.btnHang.Name = "btnHang";
            this.btnHang.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHang_ItemClick);
            // 
            // btnNhaCC
            // 
            this.btnNhaCC.Caption = "NHÀ CUNG CẤP";
            this.btnNhaCC.Enabled = false;
            this.btnNhaCC.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhaCC.Glyph")));
            this.btnNhaCC.Id = 5;
            this.btnNhaCC.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhaCC.LargeGlyph")));
            this.btnNhaCC.Name = "btnNhaCC";
            this.btnNhaCC.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnNhaCC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhaCC_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "LẬP ĐƠN ĐẶT HÀNG";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "NHẬP HÀNG";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 8;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "XUẤT HÀNG";
            this.barButtonItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.Glyph")));
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.LargeGlyph")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "NHÂN VIÊN";
            this.btnNhanVien.Enabled = false;
            this.btnNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.Glyph")));
            this.btnNhanVien.Id = 10;
            this.btnNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.LargeGlyph")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhanVien_ItemClick);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Caption = "QUẢN LÝ TÀI KHOẢN";
            this.btnTaoTK.Enabled = false;
            this.btnTaoTK.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTaoTK.Glyph")));
            this.btnTaoTK.Id = 11;
            this.btnTaoTK.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTaoTK.LargeGlyph")));
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTK_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "SAO LƯU-PHỤC HỒI";
            this.barButtonItem7.Id = 12;
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.Caption = "ĐỔI MẬT KHẨU";
            this.btnDoiMatKhau.Enabled = false;
            this.btnDoiMatKhau.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.Glyph")));
            this.btnDoiMatKhau.Id = 14;
            this.btnDoiMatKhau.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDoiMatKhau.LargeGlyph")));
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoiMatKhau_ItemClick);
            // 
            // btnBaoCaoHang
            // 
            this.btnBaoCaoHang.Caption = "Báo Cáo Hàng Nhập";
            this.btnBaoCaoHang.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoHang.Glyph")));
            this.btnBaoCaoHang.Id = 17;
            this.btnBaoCaoHang.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBaoCaoHang.LargeGlyph")));
            this.btnBaoCaoHang.Name = "btnBaoCaoHang";
            this.btnBaoCaoHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCaoHang_ItemClick);
            // 
            // btnBackUpRestore
            // 
            this.btnBackUpRestore.Caption = "SAO LƯU- PHỤC HỒI";
            this.btnBackUpRestore.Enabled = false;
            this.btnBackUpRestore.Glyph = ((System.Drawing.Image)(resources.GetObject("btnBackUpRestore.Glyph")));
            this.btnBackUpRestore.Id = 18;
            this.btnBackUpRestore.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnBackUpRestore.LargeGlyph")));
            this.btnBackUpRestore.Name = "btnBackUpRestore";
            // 
            // btnHDNhanVien
            // 
            this.btnHDNhanVien.Caption = "Hoạt Động Nhân Viên";
            this.btnHDNhanVien.Glyph = ((System.Drawing.Image)(resources.GetObject("btnHDNhanVien.Glyph")));
            this.btnHDNhanVien.Id = 19;
            this.btnHDNhanVien.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnHDNhanVien.LargeGlyph")));
            this.btnHDNhanVien.Name = "btnHDNhanVien";
            this.btnHDNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHDNhanVien_ItemClick);
            // 
            // btnDSNHANVIEN
            // 
            this.btnDSNHANVIEN.Caption = "Danh Sách Nhân Viên";
            this.btnDSNHANVIEN.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDSNHANVIEN.Glyph")));
            this.btnDSNHANVIEN.Id = 20;
            this.btnDSNHANVIEN.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDSNHANVIEN.LargeGlyph")));
            this.btnDSNHANVIEN.Name = "btnDSNHANVIEN";
            this.btnDSNHANVIEN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSNHANVIEN_ItemClick);
            // 
            // btnDanhMucKho
            // 
            this.btnDanhMucKho.Caption = "DANH MỤC KHO";
            this.btnDanhMucKho.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDanhMucKho.Glyph")));
            this.btnDanhMucKho.Id = 21;
            this.btnDanhMucKho.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDanhMucKho.LargeGlyph")));
            this.btnDanhMucKho.Name = "btnDanhMucKho";
            this.btnDanhMucKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhMucKho_ItemClick);
            // 
            // btnDSVT
            // 
            this.btnDSVT.Caption = "Danh Sách Vật Tư";
            this.btnDSVT.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDSVT.Glyph")));
            this.btnDSVT.Id = 22;
            this.btnDSVT.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnDSVT.LargeGlyph")));
            this.btnDSVT.Name = "btnDSVT";
            this.btnDSVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDSVT_ItemClick);
            // 
            // btnDanhMucVT
            // 
            this.btnDanhMucVT.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.btnDanhMucVT.Caption = "DANH MỤC VẬT TƯ";
            this.btnDanhMucVT.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDanhMucVT.Glyph")));
            this.btnDanhMucVT.Id = 23;
            this.btnDanhMucVT.Name = "btnDanhMucVT";
            this.btnDanhMucVT.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnDanhMucVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhMucVT_ItemClick);
            // 
            // rbHome
            // 
            this.rbHome.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpTaiKhoan,
            this.rbpHeThong,
            this.rbDoiTac});
            this.rbHome.Name = "rbHome";
            this.rbHome.Text = "Trang chủ";
            // 
            // rbpTaiKhoan
            // 
            this.rbpTaiKhoan.ItemLinks.Add(this.btnDoiMatKhau);
            this.rbpTaiKhoan.Name = "rbpTaiKhoan";
            this.rbpTaiKhoan.Text = "TÀI KHOẢN";
            // 
            // rbpHeThong
            // 
            this.rbpHeThong.ItemLinks.Add(this.btnLoaiHang);
            this.rbpHeThong.ItemLinks.Add(this.btnHang);
            this.rbpHeThong.ItemLinks.Add(this.btnBackUpRestore);
            this.rbpHeThong.Name = "rbpHeThong";
            this.rbpHeThong.Text = "HỆ THỐNG";
            // 
            // rbDoiTac
            // 
            this.rbDoiTac.ItemLinks.Add(this.btnNhaCC);
            this.rbDoiTac.Name = "rbDoiTac";
            this.rbDoiTac.Text = "ĐỐI TÁC";
            // 
            // rbQLNhanvien
            // 
            this.rbQLNhanvien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rbQLNhanvien.Name = "rbQLNhanvien";
            this.rbQLNhanvien.Text = "Quản Lý Nhân Viên";
            this.rbQLNhanvien.Visible = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnNhanVien);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTaoTK);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "QUẢN LÝ";
            // 
            // rbpNghiepVu
            // 
            this.rbpNghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbpNghiepVu.Name = "rbpNghiepVu";
            this.rbpNghiepVu.Text = "Kho Hàng";
            this.rbpNghiepVu.Visible = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhMucKho);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDanhMucVT);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "NHẬP XUẤT HÀNG HÓA";
            // 
            // rbpBaoCao
            // 
            this.rbpBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.rbpBaoCao.Name = "rbpBaoCao";
            this.rbpBaoCao.Text = "Báo Cáo";
            this.rbpBaoCao.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBaoCaoHang);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDSVT);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Báo Cáo Hàng Nhập";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHDNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDSNHANVIEN);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Báo Cáo Nhân Viên";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem1";
            this.barButtonItem2.Id = 7;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangXuat.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDangXuat.Appearance.Options.UseBackColor = true;
            this.btnDangXuat.AppearanceHovered.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.AppearanceHovered.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnDangXuat.AppearanceHovered.BorderColor = System.Drawing.Color.Blue;
            this.btnDangXuat.AppearanceHovered.Options.UseBackColor = true;
            this.btnDangXuat.AppearanceHovered.Options.UseBorderColor = true;
            this.btnDangXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnDangXuat.Location = new System.Drawing.Point(756, 69);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(121, 41);
            this.btnDangXuat.TabIndex = 2;
            this.btnDangXuat.Text = "ĐĂNG XUẤT";
            this.btnDangXuat.Visible = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(353, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(82)))), ((int)(((byte)(73)))));
            this.btnCloseApp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCloseApp.BackgroundImage")));
            this.btnCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseApp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCloseApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCloseApp.FlatAppearance.BorderSize = 100;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCloseApp.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCloseApp.ForeColor = System.Drawing.Color.Red;
            this.btnCloseApp.Location = new System.Drawing.Point(855, 0);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(34, 29);
            this.btnCloseApp.TabIndex = 6;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(889, 419);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.FrmMain_GiveFeedback);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbHome;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnLoaiHang;
        private DevExpress.XtraBars.BarButtonItem btnMatHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpHeThong;
        private DevExpress.XtraBars.BarButtonItem btnHang;
        private DevExpress.XtraBars.BarButtonItem btnNhaCC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbDoiTac;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpNghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpBaoCao;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnTaoTK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQLNhanvien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnDoiMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnDangXuat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoHang;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.Button btnCloseApp;
        private DevExpress.XtraBars.BarButtonItem btnBackUpRestore;
        private DevExpress.XtraBars.BarButtonItem btnHDNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnDSNHANVIEN;
        private DevExpress.XtraBars.BarButtonItem btnDanhMucKho;
        private DevExpress.XtraBars.BarButtonItem btnDSVT;
        private DevExpress.XtraBars.BarButtonItem btnDanhMucVT;
    }
}


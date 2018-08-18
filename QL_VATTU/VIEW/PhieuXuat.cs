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
using QLYVATTU.MODEL;
using DevExpress.XtraGrid;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace QLYVATTU.VIEW
{
    public partial class PhieuXuat : Form
    {
        public PhieuXuat()
        {
            InitializeComponent();
        }
        CTPhieuXuat ctPX;
        private DataTable hd;
        private DataTable kh;
        private DataTable vt;
        private DataTable kho;
        private string maKH = ""; //lưu mã khách hàng để add vào phiếu xuất
        private string maVT = ""; //lay ma vat tu khi click vao de add vao chi tiet hoa don
        private string maPX = ""; //tao phieu xuat, luu ma phieu xuat de huy phieu,
        private int soVTOld; //so luong vat tu cho vao phieu xuat
        private int soVTKho; //số vật tư còn trong kho để so sánh với số vt xuất
        private string giaVT;
        private string maKho;
        private string tKho;
        decimal tongTien = 0;

        private static int index = 0;
        
        DataTable chiTietPX = new DataTable();

        FrmMain f = Program.fmain;
        //xây dụng hàm kiểm tra chuỗi nhập có phải số kg, true là số
        private bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        //phuong thuc dinh nghia cot gv
        private void gridViewChiTietPX()
        {
            chiTietPX.Columns.Add("Mã Vật Tư", typeof(string));
            chiTietPX.Columns.Add("Tên Vật Tư", typeof(string));
            chiTietPX.Columns.Add("Số lượng", typeof(int));
            chiTietPX.Columns.Add("Đơn Giá", typeof(string));
            chiTietPX.Columns.Add("Xóa", typeof(bool));
            chiTietPX.Columns[4].DefaultValue = false;
        }

        private void loadLaiPX()
        {
            //laod lại view khách hàng
            KhachHang khachhang = new KhachHang();
            //kh = khachhang.getKhachHang();
            //gvKH.DataSource = kh;
            //gvKH.DataMember = kh.TableName;
            //load lại view danh sách phiếu xuất
            HoaDon hoadon = new HoaDon();
            hd = hoadon.getHoaDon();
            gvDSPX.DataSource = hd;
            gvDSPX.DataMember = hd.TableName;

            //load lại chi tiết kho
            VatTu vattu = new VatTu();
            vt = vattu.getVatTu();
            gvVatTu.DataSource = vt;
            gvVatTu.DataMember = vt.TableName;
            //gvVatTu.DataMember = ctKho.TableName;
        }

        private void PhieuXuat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_DANHSACHPHIEUXUAT' table. You can move, or remove it, as needed.
            //this.sP_DANHSACHPHIEUXUATTableAdapter.Fill(this.qL_VATTUDataSet.SP_DANHSACHPHIEUXUAT);

            KhachHang khachhang = new KhachHang();
            //kh = khachhang.getKhachHang();
            //gvKH.DataSource = kh;
            //gvKH.DataMember = kh.TableName;
            //sP_TIMKIEM_KHACHHANGGridControl.DataSource = kh;  //thay datasource thàng gridview
            //sP_TIMKIEM_KHACHHANGGridControl.DataMember = kh.TableName;


            HoaDon hoadon = new HoaDon();
            hd = hoadon.getHoaDon();
            gvDSPX.DataSource = hd;
            gvDSPX.DataMember = hd.TableName;

            //do ten kho vao combobox
            kho = hoadon.getKho();
            cb_DSKho.Items.Clear();
            cb_DSKho.DisplayMember = "Text";
            cb_DSKho.ValueMember = "Value";
            foreach (DataRow dr in kho.Rows)
            {
                cb_DSKho.Items.Add(new { Text = dr["TENKHO"], Value = dr["MAKHO"]});
                //MessageBox.Show(dr["MAKHO"].ToString());
            }
            cb_DSKho.SelectedIndex = 0;

            gridViewChiTietPX();

            // NHẬN SỰ KIỆN CLICK ĐỂ LẤY MÃ KHO MỚI LOAD DANH SÁCH VẬT TƯ TRONG KHO
            ConfigGridViewVatTu();
            lbMaKH.Hide();  //label lay ma khach hang khi lay ma tu dong hoac click chuot kh co san

            if(index == 1)
            {
                Timer timer = new Timer();
                timer.Interval = (10 * 700); // 7 secs
                timer.Tick += new EventHandler(timer_Tick);
                timer.Start();
            }
            
        }

        public void ConfigGridViewVatTu()
        {
            VatTu vattu = new VatTu();
            vt = vattu.getVatTu();
            gvVatTu.DataSource = vt;
            gvVatTu.DataMember = vt.TableName;
            for (int i = 0; i < gridView4.Columns.Count; i++)
            {
                
                if (gridView4.Columns[i].FieldName == "MAVT")
                {
                    gridView4.Columns[i].Visible = true;
                    gridView4.Columns[i].OptionsColumn.AllowEdit = true;
                    gridView4.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
                    gridView4.Columns[i].Caption = "Mã vật tư";
                    gridView4.Columns[i].OptionsColumn.FixedWidth = true;
                   
                }
                else if (gridView4.Columns[i].FieldName == "TENVT")
                {
                    gridView4.Columns[i].Visible = true;
                    gridView4.Columns[i].Caption = "Tên vật tư";
                    
                }

                else if (gridView4.Columns[i].FieldName == "SOLUONGTON")
                {
                    gridView4.Columns[i].Visible = true;
                    gridView4.Columns[i].Caption = "Số lượng tồn";

                }
                else if (gridView4.Columns[i].FieldName == "DVT")
                {
                    gridView4.Columns[i].Visible = true;
                    gridView4.Columns[i].Caption = "Đơn vị";
                    
                }
                else if (gridView4.Columns[i].FieldName == "DONGIA")
                {
                    gridView4.Columns[i].Visible = true;
                    gridView4.Columns[i].Caption = "Đơn giá";
                  
                }

                else if (gridView4.Columns[i].FieldName == "TrangThai")
                {
                    gridView4.Columns[i].Visible = false;
                    gridView4.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                    gridView4.Columns[i].Caption = "Trạng thái";
                    
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            loadLaiPX();
        }

        private void sP_DANHSACHPHIEUXUATGridControl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void hotenTbox_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

       

        private void cb_DSKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index = 1;
            //string tenKho = cb_DSKho.SelectedItem.ToString();
            //HoaDon hoaDon = new HoaDon();
            //string[] param = { tenKho };
            //try
            //{
            //    DataTable ctKho = hoaDon.getChiTietKho(param);
            //    gvVatTu.DataSource = ctKho;
            //    gvVatTu.DataMember = ctKho.TableName;
            //    //-------lay ma phieu KHO-----------//
            //    SqlDataReader makho;
            //    //tạo 1 mã khách hàng mới
            //    makho = hoaDon.getMaKho(param);
            //    makho.Read();
            //    maKho = makho["MAKHO"].ToString();
            //    //MessageBox.Show(maKho);
            //    makho.Close();
            //    tKho = tenKho;
            //    //==================================//
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi Tương tác CSDL! " + ex.ToString());
            //}
            //cb_DSKho.Enabled = false;
        }

        private void gvKH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //DataRow red = gridView2.GetFocusedDataRow();
            ////MessageBox.Show(red["Họ Tên"].ToString());
            //maKH = red["Mã Khách Hàng"].ToString();
            //lbMaKH.Text = maKH;
            //tbTenKH.Text = red["Họ tên"].ToString();
            //tbSDT.Text = red["Số Điện Thoại"].ToString();
            //tbDiaChi.Text = red["Địa Chỉ"].ToString();

            ////mếu chọn khách hàng có sẵn thì cho readonly -> kg cho sửa
            //tbTenKH.Enabled = false;
            //tbSDT.Enabled = false;
            //tbDiaChi.Enabled = false;
            //btTaoKH.Enabled = false;
            //btHuyPX.Enabled = true;
        }

        private void gvVT_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void gvVatTu_Click(object sender, EventArgs e)
        {

        }

        private void gridView4_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow vattu = gridView4.GetFocusedDataRow();
            maVT = vattu["MAVT"].ToString();
            //MessageBox.Show(""+maVT+"*");
            tbTenVT.Text = vattu["TENVT"].ToString();
            lbDonViTinh.Text = vattu["DVT"].ToString();
            soVTKho = Convert.ToInt32(vattu["SOLUONGTON"]);
            giaVT = vattu["DONGIA"].ToString();
        }

        private void btTaoPX_Click(object sender, EventArgs e)  //kg can
        {
            //string tenKH = tbTenKH.Text;
            //string soDT = tbSDT.Text;
            //string diaChi = tbDiaChi.Text;
            //if (tenKH == "" || soDT == "" || diaChi == "")
            //{
            //    MessageBox.Show("Vui Lòng Chọn Khách Hàng Hoặc Điền Thông Tin Đầy Đủ!");
            //}
            //else if (maKH == "")
            //{
            //    MessageBox.Show("Vui Lòng Nhấn 'Tạo Khách Hàng Mới' Để Tiếp Tục!");
            //}
            //else
            //{
            //    if (cb_DSKho.SelectedIndex == -1)
            //    {
            //        MessageBox.Show("Vui Lòng Chọn Kho Để Xuất Hàng!");
            //    }
            //}
        }

        private void btTaoKH_Click(object sender, EventArgs e)
        {
            string tenKH = tbTenKH.Text;
            string soDT = tbSDT.Text;
            string diaChi = tbDiaChi.Text;
            if (tenKH == "" || soDT == "" || diaChi == "")
            {
                MessageBox.Show("Vui Lòng Chọn Khách Hàng Hoặc Điền Thông Tin Đầy Đủ!");
            }
            else if (IsNumber(soDT) == false || soDT.Length > 11 || soDT.Length < 10)
            {
                MessageBox.Show("Số Điện Thoại Chưa Đúng ĐỊnh Dạng!");
            }
            else
            {
                SqlDataReader maKhachHang;
                KhachHang khachhang = new KhachHang();
                //tạo 1 mã khách hàng mới
                //maKhachHang = khachhang.getMaKhachHang();
                //maKhachHang.Read();
                //maKH = maKhachHang["MAKH"].ToString();
                //maKhachHang.Close();
                //truyền mã thêm khách hàng mới
                string[] param = { maKH, tenKH, soDT, diaChi };
                int result = khachhang.taoKhachHang(param);
                if (result == 0)
                {
                    MessageBox.Show("Đã Tạo Khách hàng Thành Công!");
                    kh = khachhang.getKhachHang();
                    //gvKH.DataSource = kh;
                    //gvKH.DataMember = kh.TableName;
                    tbTenKH.Enabled = false;
                    tbSDT.Enabled = false;
                    tbDiaChi.Enabled = false;
                    btTaoKH.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Tạo Khách Hàng Lỗi!");
                }
            }
        }

        private void btThemPX_Click(object sender, EventArgs e)
        {
            //btXoaVTPX.Enabled = true;
            ////--------xét điều kiện thêm vào chi tiết phiếu xuất----------//
            if (IsNumber(tbSLVT.Text) == false)
            {
                MessageBox.Show("Số Lượng Vật Tư Xuất Phải Là Số!");
            }
            else
            {
                try
                {
                    bool tenVT = f.CheckNullValue(tbTenVT);
                    bool soLuong = f.CheckNullValue(tbSLVT);

                    if (tenVT && soLuong)
                    {
                        for (int i = 0; i < gridView3.RowCount; i++)
                        {

                            string maVatTu = gridView3.GetRowCellValue(i, gridView3.Columns[0]).ToString();
                            string tenVatTu = gridView3.GetRowCellValue(i, gridView3.Columns[1]).ToString();


                            if (maVatTu == maVT && tenVatTu == tbTenVT.Text)
                            {
                                int tempSL = Int32.Parse(tbSLVT.Text);
                                //MessageBox.Show(tempSL.ToString());
                                if (tempSL > soVTKho)
                                {
                                    MessageBox.Show("Số Vật Tư Cần Xuất Quá Số Lượng Vật Tư trong Kho!");
                                    return;
                                }
                                else
                                {
                                    gridView3.DeleteRow(i);
                                    chiTietPX.Rows.Add(maVT, tbTenVT.Text, tempSL, giaVT);
                                    gvChiTietHD.DataSource = chiTietPX;
                                    gvChiTietHD.DataBindings.Clear();
                                    for (int j = 0; j < 4; j++)
                                    {
                                        gridView3.Columns[j].OptionsColumn.AllowEdit = false;
                                    }
                                    tbSLVT.Text = "";
                                    tempSL = 0;
                                    for (int y = 0; y < gridView3.RowCount; y++)
                                    {
                                        if (y == 0)
                                        {
                                            tongTien = Convert.ToDecimal(gridView3.GetRowCellValue(y, gridView3.Columns[3])) * Convert.ToDecimal(gridView3.GetRowCellValue(y, gridView3.Columns[2]));
                                        }
                                        else
                                        {
                                            tongTien += Convert.ToDecimal(gridView3.GetRowCellValue(y, gridView3.Columns[3])) * Convert.ToDecimal(gridView3.GetRowCellValue(y, gridView3.Columns[2]));
                                        }
                                       
                                    }

                                    lbTien.Text = String.Format("{0:0,0 vnđ}", tongTien);
                                    //lbTien.Text = tongTien.ToString();
                                    return;
                                }
                            }
                        }
                        if ((Convert.ToInt32(tbSLVT.Text)) > soVTKho)
                        {
                            MessageBox.Show("Số Vật Tư Cần Xuất Quá Số Lượng Vật Tư trong Kho!");
                            return;
                        }
                        else
                        {
                            chiTietPX.Rows.Add(maVT, tbTenVT.Text, tbSLVT.Text, giaVT);
                            gvChiTietHD.DataSource = chiTietPX;
                            gvChiTietHD.DataBindings.Clear();
                            for (int j = 0; j < 4; j++)
                            {
                                gridView3.Columns[j].OptionsColumn.AllowEdit = false;
                                //gridView3.Columns[2].OptionsColumn.AllowEdit = true;
                            }
                            tbSLVT.Text = "";
                            for (int i = 0; i < gridView3.RowCount; i++)
                            {
                                if (i == 0)
                                {
                                    tongTien = Convert.ToDecimal(gridView3.GetRowCellValue(i, gridView3.Columns[3])) * Convert.ToDecimal(gridView3.GetRowCellValue(i, gridView3.Columns[2]));
                                }
                                else
                                {
                                    tongTien += Convert.ToDecimal(gridView3.GetRowCellValue(i, gridView3.Columns[3])) * Convert.ToDecimal(gridView3.GetRowCellValue(i, gridView3.Columns[2]));
                                }
                            }
                            lbTien.Text = String.Format("{0:0,0 vnđ}", tongTien);
                            //lbTien.Text = tongTien.ToString();
                            //MessageBox.Show(tongTien.ToString());
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sai " + ex);

                }
            }

        }

        private void btLapPX_Click(object sender, EventArgs e)
        {
            string tenKH = tbTenKH.Text;
            string soDT = tbSDT.Text;
            string diaChi = tbDiaChi.Text;
            string maKho = (cb_DSKho.SelectedItem as dynamic).Value;
            if (tenKH == "" || soDT == "" || diaChi == "" )
            {
                MessageBox.Show("Vui Lòng Chọn Khách Hàng Hoặc Điền Thông Tin Đầy Đủ!");
            }
            else if (cb_DSKho.SelectedIndex == -1)
            {
                MessageBox.Show("Vui Lòng Chọn Kho Để Xuất Hàng!");
            }
            else
            {
                //-------lay ma phieu xuat-----------//
                SqlDataReader maHD;
                HoaDon HoaDon = new HoaDon();
                //tạo 1 mã khách hàng mới
                maHD = HoaDon.getMaPX();
                maHD.Read();
                maPX = maHD["MAHD"].ToString();
                maHD.Close();
                //-------hoan thanh lay ma-----------//
                string maNV = Access.MANV.ToString();
                try
                {
                    int nuRow = gridView3.RowCount;
                    int x;
                    string strXML = "<Root>";
                    for (int i = 0; i < nuRow; i++)
                    {
                        strXML += "<PhieuXuat MAPX = \"" + maPX;
                        strXML += "\" HOTENKH =\"" + tenKH;
                        strXML += "\" MAKHO =\"" + maKho;
                        strXML += "\" MANV =\"" + maNV;
                        strXML += "\" SDT =\"" + soDT;
                        strXML += "\" DIACHI =\"" + diaChi;
                        strXML += "\" MAVT =\"" + gridView3.GetRowCellValue(i, gridView3.Columns[0]).ToString();
                        strXML += "\" SL_XUAT =\"" + gridView3.GetRowCellValue(i, gridView3.Columns[2]).ToString();
                        strXML += "\" DONGIA =\"" + gridView3.GetRowCellValue(i, gridView3.Columns[3]).ToString();
                        strXML += "\" />";
                    }
                        strXML += "</Root>";
                    
                        string[] param = { strXML };
                        HoaDon hd = new HoaDon();
                        x = hd.taoHoaDon(param);
                        if (x == 0 )
                        {
                            MessageBox.Show("Đã Lập Hóa Đơn Thành Công");
                            int y = 0;
                            while (y < gridView3.RowCount)
                            {
                                gridView3.DeleteRow(y);
                            }
                            loadLaiPX();
                            lbTien.Text = "";
                            tbTenVT.Text = "";
                            tongTien = 0;
                            //khach hang
                            tbTenKH.Text = "";
                            tbSDT.Text = "";
                            tbDiaChi.Text = "";
                            tbTenKH.Enabled = true;
                            tbSDT.Enabled = true;
                            tbDiaChi.Enabled = true;
                            btTaoKH.Enabled = true;
                            //kho
                            cb_DSKho.Enabled = true;

                            return;
                        }
                    
                }
                catch
                {
                    MessageBox.Show("Lập Hóa Đơn Thất Bại");
                }
            }
        }

        private void btHuyKH_Click(object sender, EventArgs e)
        {
            maKH = "";
            tbTenKH.Enabled = true;
            tbSDT.Enabled = true;
            tbDiaChi.Enabled = true;
            tbTenKH.Text = "";
            tbSDT.Text = "";
            tbDiaChi.Text = "";
            btTaoKH.Enabled = true;
        }

        private void gbHoanThanh_Enter(object sender, EventArgs e)
        {

        }

        private void UpDateSL_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRow read = gridView3.GetFocusedDataRow();
            string mavatu = read["Mã Vật Tư"].ToString();
            string soLuongVT = read["Số Lượng"].ToString();
            //MessageBox.Show(soLuongVT); //lay dung
            if (IsNumber(soLuongVT) == false)
            {
                MessageBox.Show("Số Lượng Phải Là Số");
                //gridView3.SetRowCellValue(i, gridView3.Columns[2], soVTOld);
                //for (int y; y < gridView3.RowCount; y++)
                //{
                //    for (int j = 0; j < 4; j++)
                //    {
                //        gridView3.Columns[j].OptionsColumn.AllowEdit = false;
                //        gridView3.Columns[2].OptionsColumn.AllowEdit = true;
                //    }
                //}
            }
            else
            {
                for (int i = 0; i < gridView4.RowCount; i++)
                {
                    if (gridView4.GetRowCellValue(i, gridView4.Columns[0]).ToString() == mavatu)
                    {
                        //MessageBox.Show(mavatu); //lay đúng
                        int a = Convert.ToInt32(gridView4.GetRowCellValue(i, gridView4.Columns[4]));//so luong nhap
                        int b = Convert.ToInt32(soLuongVT);// so luong trong kho
                        if (b > a)
                        {
                            MessageBox.Show("Số Lượng Lớn Hơn Hàng Còn Trong Kho!");
                            gridView3.SetRowCellValue(gridView3.FocusedRowHandle, gridView3.Columns[2], soVTOld); //sai chỗ i
                            //for (int y = 0; y < gridView3.RowCount; y++)
                            //{
                            gridView3.Columns[2].OptionsColumn.AllowEdit = false;
                            //gridView3.Columns[2].OptionsColumn.AllowEdit = true;
                            //}
                            return;
                        }
                    }
                }
            }

        }

        private void SaveSLOld_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow vattu = gridView3.GetFocusedDataRow();
            soVTOld = Convert.ToInt32(vattu["Số Lượng"].ToString());
            gridView3.Columns[2].OptionsColumn.AllowEdit = true;
            //MessageBox.Show(soVTOld.ToString());
        }

        private void btXoaVTPX_Click(object sender, EventArgs e)
        {
            //int i = 0;
            //int y = gridView3.RowCount;
            //for (i = 0; i < y; i++)
            //{
            //    var check = gridView3.GetRowCellValue(i, gridView3.Columns[4]).ToString();
            //    if (check == "True")
            //    {
            //        gridView3.DeleteRow(i);
            //    }
            //    else if (check == "") continue;
            //}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int y = gridView3.RowCount;
            for (i = 0; i < y; i++)
            {
                bool check = (bool)gridView3.GetRowCellValue(i, gridView3.Columns[4]);
                if (check)
                {
                    gridView3.DeleteRow(i);
                    y--;
                    i = -1;
                }
            }

        }

        private void btHuyPX_Click(object sender, EventArgs e)
        {
            cb_DSKho.Enabled = true;
            btHuyKH_Click(sender, e);
            int y = 0;
            while (y < gridView3.RowCount)
            {
                gridView3.DeleteRow(y);
            }
            lbTien.Text = "";
            tbTenVT.Text = "";
            loadLaiPX();
            return;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
            DataRow red = gridView1.GetFocusedDataRow();
            string maPX = red[0].ToString();

            if (ctPX == null)
            {
                ctPX = new CTPhieuXuat();
                ctPX.Sender(maPX);    //Gọi delegate
                ctPX.Show();

            }
            else
            {
                ctPX.Hide();
                ctPX = new CTPhieuXuat();
                ctPX.Activate();
                ctPX.Show();

                ctPX.Sender(maPX);
            }

        }

        
    }
}

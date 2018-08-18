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
using QLYVATTU.STACK;
using QLYVATTU.LIST_ARRAY;
using System.Text.RegularExpressions;

namespace QLYVATTU.VIEW
{
    public partial class TaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public TaoTaiKhoan()
        {
            InitializeComponent();
        }
        private DataTable nv;
        //private static List<string> NHANVIEN_TrongBang = null;


        private Stack<Command> _commands;
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void TaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_LAY_NHANVIEN' table. You can move, or remove it, as needed.
            
            panel6.Visible = false;
            _commands = new Stack<Command>();
            load_DS_NHANVIEn();
            loadTheoRole();
            //int gioitinh = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[4]));
            Check_role_congty();

            

        }
        private int Execute(string _operator, ListNhanVien _operand, ListNhanVien oldstate)
        {
            Command command = new NhanVienCommand(_operator, _operand, oldstate);
            int code = command.Execute();
            _commands.Push(command);
            btnUndo.Enabled = true;
            return code;
        }


       


        private void load_DS_NHANVIEn()
        {
            NhanVien nhanvien = new NhanVien();
            nv = nhanvien.getNhanVien();
            sP_LAY_NHANVIENGridControl.DataSource = nv;
            sP_LAY_NHANVIENGridControl.DataMember = nv.TableName;
        }


        private void load_DS_NhanVien_ChiNhanh_User()
        {
            NhanVien nhanvien = new NhanVien();
            nv = nhanvien.getNhanVien_User_ChiNhanh();
            if (nv == null)
            {
                sP_LAY_NHANVIENGridControl.DataSource = null;
            }
            else
            {
                sP_LAY_NHANVIENGridControl.DataSource = nv;
                sP_LAY_NHANVIENGridControl.DataMember = nv.TableName;
            }
        }

        private void load_DS_Nhanvien_User()
        {
            NhanVien nhanvien = new NhanVien();
            nv = nhanvien.getNhanVien();
            if (nv != null && nv.Rows.Count >0)
            {

                sP_LAY_NHANVIENGridControl.DataSource = nv;
                sP_LAY_NHANVIENGridControl.DataMember = nv.TableName;
            }
            else
            {
                sP_LAY_NHANVIENGridControl.DataSource = null;
            }
        }

        private void Check_role_congty()
        {
            if(Access.ROLE == "CongTy")
            {
               
                rabtnChiNhanh.Checked = false;
                rabtnChiNhanh.Visible = false;
                rabtnUser.Checked = false;
                rabtnUser.Visible = false;
                rabtnCongTy.Checked = true;
                rabtnCongTy.Visible = true;
            }
            else
            {
                rabtnChiNhanh.Checked = true;
                rabtnChiNhanh.Visible = true;
                rabtnUser.Checked = false;
                rabtnUser.Visible = true;
                rabtnCongTy.Checked = false;
                rabtnCongTy.Visible = false;

            }
        }

      


        private void loadTheoRole()
        {
            if (Access.ROLE == "CongTy")
            {
                load_DS_NhanVien_ChiNhanh_User();

            }
            else
            {
                load_DS_Nhanvien_User();
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {

        }


        private bool CheckForTaoTaiKhoan()
        {
            int noError = 0;
            string error = "Nội dung bạn nhập có 1 số lỗi sau. Vui lòng sửa trước khi lưu.";
            if (tboxLoginName.Text == "")
            {
                error += "\r\n+Tên tài khoản không được để trống";
                noError++;
            }

            if(tboxPassword.Text == "")
            {
                error += "\r\n+ Mật Khẩu không được để trống";
                noError++;
            }

            if (tbox_Repassword.Text.Trim() != tboxPassword.Text.Trim())
            {
                error += "\r\n+ Mật Khẩu và mật khẩu nhập lại không giống nhau";
                noError++;
            }
            if(tboxHo.Text == "" || tboxTen.Text == "")
            {
                error += " \r\n+Họ và tên không được để trống";
                noError++;
            }

            if(nGAYSINHDateEdit.Text == "")
            {
                error += "\r\n+ Hãy chọn ngày sinh";
                noError++;
            }
            if(tboxDiachi.Text =="")
            {
                error += "\r\n+ Nhập địa chỉ";
                noError++;
            }
            if (Convert.ToInt32(tboxLuong.Text.ToString()) < 4000000)
            {
                error += "\r\n+ Luong nhap phai lớn hơn 4000000";
                noError++;
            }

            if (noError > 0)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
            else
            {
                return true;
            }


         
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            bool check;
             check = CheckForTaoTaiKhoan();
            if (check == true)
            {
                string ho = tboxHo.Text.ToString();
                string ten = tboxTen.Text.ToString();
                string luong = tboxLuong.Text.ToString();
                string role = "";
                if (Access.ROLE == "ChiNhanh")
                {
                    if (rabtnUser.Checked == true)
                    {
                        role = rabtnUser.Text.ToString();
                    }
                    else
                    {
                        role = rabtnChiNhanh.Text.ToString();
                    }
                }
                else
                {
                    role = Access.ROLE;
                }


                DateTime ngaysinh = this.nGAYSINHDateEdit.DateTime;
                string nsinh = String.Format("{0:MM-dd-yyyy}", ngaysinh);
                string diachi = tboxDiachi.Text.ToString();
                string sodt = tboxSDT.Text.ToString();
                string password = tboxPassword.Text.ToString();
                string loginname = tboxLoginName.Text.ToString();
                //string role = "CHINHANH";
                string[] param = { ho, ten, luong, nsinh, diachi, loginname, password, role };
                NhanVien nhanvien = new NhanVien();
                int x = nhanvien.InserCusomer(param);
                if (x == 0)
                {
                    MessageBox.Show("Tạo tài khoản thành công");
                    loadTheoRole();
                    EventforHUy();


                }
                else
                {
                    MessageBox.Show("Tạo tài khoản lỗi");
                }
            }
            else
            {
                  
            }

        }

        private void tboxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Nhập kiểu số ", "Thông Báo ");
            }

            
        }

        private void gridView1_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            //if(e.Column.FieldName == "PHAI")
            //{
            //    if((bool)e.Value == true)
            //    {

            //        Convert.ToString(e.Value == "Nam"); 

            //    }
            //    else
            //    {
            //        Convert.ToString(e.Value == "Nữ");
            //    }
               
            //}
        }

        private void sP_LAY_NHANVIENGridControl_Click(object sender, EventArgs e)
        {

        }

        private void FocusRowChangeData()
        {


            tboxLoginName.Enabled = false;
            tboxPassword.Enabled = false;
            btnXoa.Enabled = true;
            panel6.Visible = true;
            DataRow red = gridView1.GetFocusedDataRow();
            if(red == null)
            {
                return;
            }
            else
            {
                tboxHo.Text = red["HO"].ToString();
                tboxTen.Text = red["TEN"].ToString();
                tboxSDT.Text = red["SODT"].ToString();
                tboxDiachi.Text = red["DIACHI"].ToString();
                nGAYSINHDateEdit.Text = red["NGAYSINH"].ToString();
                lbMaNhanVien.Text = red["MANV"].ToString();
                tboxLuong.Text = red["LUONG"].ToString();
                //string manv = red["MANV"].ToString();
                //if (red["PHAI"].ToString() == "Nam")
                //{
                //    rabtnNam.Checked = true;
                //}
                //else
                //{
                //    rabtnNu.Checked = true;
                //}


                if (red["CHUCVU"].ToString() == "Giám đốc")
                {
                    rabtnChiNhanh.Checked = true;
                    rabtnCongTy.Enabled = false;
                }

                if (red["CHUCVU"].ToString() == "Nhân Viên")
                {
                    rabtnUser.Checked = true;
                    rabtnCongTy.Enabled = false;
                }


                if (red["TRANHTHAI"].ToString() == "Đang làm")
                {
                    rptDangLam.Checked = true;
                }
                else
                {
                    rptDaNghi.Checked = true;
                }
            }
           

            rabtnCongTy.Visible = true;
            rabtnChiNhanh.Visible = true;
            rabtnUser.Visible = true;



            btnLuu.Enabled = false;
            btnHuy.Enabled = true;


        }
       


        private void EventforHUy()
        {
            panel6.Visible = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            tboxLoginName.Enabled = false;
            tboxPassword.Enabled = false;

            tboxLoginName.Text = "";
            tboxPassword.Text = "";
            tboxHo.Text = "";
            tboxTen.Text = "";
            tboxSDT.Text = "";
            tboxLuong.Text = "";
            tboxDiachi.Text = "";
            nGAYSINHDateEdit.Text = "";
            tboxLoginName.Enabled = true;
            tboxPassword.Enabled = true;
            tboxHo.Enabled = true;
            tboxHo.Enabled = true;
            tboxSDT.Enabled = true;
            tboxDiachi.Enabled = true;
            tboxLuong.Enabled = true;
            nGAYSINHDateEdit.Enabled = true;
        }
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EventforHUy();
            NhanVien nhanvien = new NhanVien();
            nv = nhanvien.getManvtudong();
            foreach (DataRow s in nv.Rows)
            {
                lbMaNhanVien.Text = s[0].ToString();
            }

            

            if( Access.ROLE == "CongTy")
            {
                rabtnCongTy.Visible = true;
                rabtnChiNhanh.Visible = false;
                rabtnUser.Visible = false;
                rabtnCongTy.Checked = true;
            }
            else
            {
                rabtnCongTy.Visible = false;
                rabtnChiNhanh.Visible = true;
                rabtnUser.Visible = true;
                rabtnUser.Checked = true;
            }

            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = false;
            int noError = 0;
            string errors = "Nội dung bạn nhập có 1 số lỗi sau. Vui lòng sửa trước khi lưu.";
            if (tboxHo.Text.Trim() == "")
            {
                //MessageBox.Show("Nội dung câu hỏi không được bỏ trống");
                errors += "\r\n+ Họ bị bỏ trống";
                noError++;
            }
            if (tboxTen.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án A không được bỏ trống");
                errors += "\r\n+ Tên bị bỏ trống";
                noError++;
            }
            if (tboxDiachi.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án B không được bỏ trống");
                errors += "\r\n+ Địa chỉ bị bỏ trống";
                noError++;
            }
            if (tboxSDT.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án B không được bỏ trống");
                errors += "\r\n+ Số điện thoại bị bỏ trống";
                noError++;
            }
            if (nGAYSINHDateEdit.Text.Trim() == "")
            {
                //MessageBox.Show("Đáp án B không được bỏ trống");
                errors += "\r\n+ Ngày sing bị bỏ trống";
                noError++;
            }

            if (noError > 0)
            {
                MessageBox.Show(errors);
                btnLuu.Enabled = true;
                return;
            }

            DataRow red = gridView1.GetFocusedDataRow();

            string MANV = lbMaNhanVien.Text.ToString();


            string role_login = "";
            if (rabtnCongTy.Checked)
            {
                role_login = rabtnCongTy.Text.ToString();
            }

            if(rabtnChiNhanh.Checked)
            {
                role_login = rabtnChiNhanh.Text.ToString();
            }

            if(rabtnUser.Checked)
            {
                role_login = rabtnUser.Text.ToString();
            }

            string gioitinh = "";
            if(rabtnNam.Checked )
            {
                gioitinh = rabtnNam.Text.ToString();
            }
            else
            {
                gioitinh = rabtnNu.Text.ToString();
            }

            string trthai = "";
            if(rptDangLam.Checked)
            {
                trthai = rptDangLam.Text.ToString();
            }
            else
            {
                trthai = rptDaNghi.Text.ToString();
            }

         

            DateTime ngsinh = this.nGAYSINHDateEdit.DateTime;
            String nsinh = String.Format("{0:MM-dd-yyyy}", ngsinh);

            
            ListNhanVien NHANVIEN_TrongFORM = new ListNhanVien
            {

                MaNV = lbMaNhanVien.Text.ToString(),
                HO = tboxHo.Text.ToString(),
                TEN = tboxTen.Text.ToString(),
                Phai = gioitinh,
                NgaySinh = nsinh,
                DiaChi = tboxDiachi.Text.ToString(),
                Sdt = tboxSDT.Text.ToString(),
                login = tboxLoginName.Text.Trim().ToString(),
                matkhau = tboxPassword.Text.Trim().ToString(),
                role = role_login,
                Trangthai = trthai,

            };

            //if (red == null)
            //{
            //    ListNhanVien NHANVIEN_TrongBang = new ListNhanVien
            //    {
            //        MaNV = "",
            //        HO = "",
            //        TEN = "",
            //        Phai = "",
            //        NgaySinh = "",
            //        DiaChi = "",
            //        Sdt = "",
            //        role = "",
            //        Trangthai = "",
            //    };
            //}


            
            ListNhanVien NHANVIEN_TrongBang = new ListNhanVien
            {
                MaNV = red["MANV"].ToString(),
                HO = red["HO"].ToString(),
                TEN = red["TEN"].ToString(),
                Phai = red["PHAI"].ToString(),
                NgaySinh = red["NGAYSINH"].ToString(),
                DiaChi = red["DIACHI"].ToString(),
                Sdt = red["SODT"].ToString(),
                role = red["CHUCVU"].ToString(),
                Trangthai = red["TRTHAI"].ToString(),
            };

            //}
            //else
            //{
            //    ListNhanVien NHANVIEN_TrongBang = new ListNhanVien
            //    {
            //        MaNV = "",
            //        HO = "",
            //        TEN = "",
            //        Phai = "",
            //        NgaySinh = "",
            //        DiaChi = "",
            //        Sdt = "",
            //        role = "",
            //        Trangthai = "",
            //    };
            //}




            if (tboxLoginName.Enabled)
            {
                if (tboxLoginName.Text.Trim() == ""  || tboxPassword.Text.Trim() == "")
                {
                    MessageBox.Show("UserName hoặc mật khẩu bạn đã bỏ trống");
                    return;
                }
                else
                {

                    int code = Execute("insert", NHANVIEN_TrongFORM, NHANVIEN_TrongBang);
                    if (code == 0)
                    {
                        btnReload.PerformClick();
                        MessageBox.Show("Thêm nhân viên thành công");
                        tboxLoginName.Text = "";
                        tboxPassword.Text = "";
                        if(Access.ROLE == "CongTy")
                        {
                            
                            load_DS_NhanVien_ChiNhanh_User();
                        }
                        else
                        {
                            load_DS_Nhanvien_User();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên thất bại");
                    }
                }
               
            }
            else
            {
                int code = Execute("update", NHANVIEN_TrongFORM, NHANVIEN_TrongBang);
                if (code == 0)
                {
                    btnReload.PerformClick();
                    MessageBox.Show("Lưu nhân viên thành công");

                }
                else
                {
                    MessageBox.Show("Lưu nhân viên thất bại");
                }
            }
        }

        private void sP_LAYNHANVIEN_USERGridControl_Click(object sender, EventArgs e)
        {
            FocusRowChangeData();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            if (_commands.Count > 0)
            {
                Command command = _commands.Pop();
                int code = command.UnExecute();
                if (code == 0)
                {
                    btnReload.PerformClick();
                    //MessageBox.Show("Phục hồi thành công");
                }
                else
                    MessageBox.Show("Phục hồi thất bại.");
                if (_commands.Count == 0)
                    btnUndo.Enabled = false;
            }
        }

        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TaoTaiKhoan_Load(sender, e);
            btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            FocusRowChangeData();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

       

        private void rptDangLam_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rptDaNghi_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EventforHUy();
        }

        private void tboxHo_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void tboxTen_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rabtnNam_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rabtnNu_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void nGAYSINHDateEdit_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void tboxDiachi_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void tboxSDT_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rabtnUser_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rabtnCongTy_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void rabtnChiNhanh_CheckedChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void tboxLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Nhap kiểu số");
                e.Handled = true;
            }
               
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
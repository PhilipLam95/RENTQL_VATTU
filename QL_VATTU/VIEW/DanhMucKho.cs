using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLYVATTU.MODEL;
using QLYVATTU.STACK;
using QLYVATTU.LIST_ARRAY;

namespace QLYVATTU.VIEW
{
    public partial class DanhMucKho : Form
    {
        public DanhMucKho()
        {
            InitializeComponent();
        }

        private Stack<Command> _commands;
        private static DataTable kho = new DataTable();
        

        private void DanhMucKho_Load(object sender, EventArgs e)
        {
        
            _commands = new Stack<Command>(); // khoi tạo stack
            loadKho();

        }

        private void loadKho()
        {
            DonDH dondh = new DonDH();
            kho = dondh.getKho();
            sP_LAYKHOGridControl.DataSource = kho;
            sP_LAYKHOGridControl.DataMember = kho.TableName;
        }

        private void ForcusRowChangeData()
        {
            DataRow row = gridView1.GetFocusedDataRow();
            tBoxMakho.Text = row["MAKHO"].ToString();
            tboxTenKho.Text = row["TENKHO"].ToString();
            tBoxDiachi.Text = row["DIACHI"].ToString();
            tBoxMakho.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int Execute(string _operator, ListKho _operand, ListKho oldstate)
        {
            Command command = new KhoCommand(_operator, _operand, oldstate);
            int code = command.Execute();
            _commands.Push(command);
            btnUndo.Enabled = true;
            return code;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            ForcusRowChangeData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tBoxMakho.Text = "";
            tboxTenKho.Text = "";
            tBoxDiachi.Text = "";
            tBoxMakho.Enabled = true;
            tboxTenKho.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = false;
            int noError = 0;
            string errors = " Nội dung nhập có 1 số lỗi sau. Vui lòng sửa trước khi lưu";
            if(tBoxMakho.Text.Trim() == "")
            {
                errors += "\r\n+ Mã kho bị bỏ trống";
                noError++;
            }
            if(tboxTenKho.Text.Trim() == "")
            {
                errors += "\r\n+ Tên kho bị bỏ trống";
                noError++;
            }
            if (tBoxDiachi.Text.Trim() == "")
            {
                errors += "\r\n+ Tên Địa chỉ bị bỏ trống";
                noError++;
            }


            if (noError >0)
            {
                MessageBox.Show(errors);
                btnLuu.Enabled = true;
                return;
            }

            DataRow row = gridView1.GetFocusedDataRow();
            ListKho Kho_TrongBang = new ListKho // lấy giá trị kho trước đó đưa vào List Kho_TrongBang
            {
                MaKho = row["MAKHO"].ToString(),
                TenKho = row["TENKHO"].ToString(),
                Diachi = row["DIACHI"].ToString()
            };

            ListKho Kho_TrongForm = new ListKho // lấy giá trị kho muốn thay đổi/ thêm đưa vào LIst Kho_TrongForm
            {
                MaKho= tBoxMakho.Text.Trim().ToString(),
                TenKho = tboxTenKho.Text.Trim().ToString(),
                Diachi = tBoxDiachi.Text.ToString()
            };

            if(tBoxMakho.Enabled)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (tBoxMakho.Text.Trim().ToUpper().ToString() == gridView1.GetRowCellValue(i, gridView1.Columns[0]).ToString() || 
                        tboxTenKho.Text.Trim().ToUpper().ToString() == gridView1.GetRowCellValue(i, gridView1.Columns[1]).ToString())  // kiểm tra trùng mã kho và tên kho trước đo
                    {
                        MessageBox.Show("Kho thêm đã tồn tại");
                        return;
                    }
                    else
                    {
                        if (i == (gridView1.RowCount - 1))
                        {
                            int code = Execute("insert", Kho_TrongForm, Kho_TrongBang);
                            if (code == 0)
                            {
                                MessageBox.Show("Thêm Kho Thành công");
                                btnReload.PerformClick();

                            }
                            else
                            {
                                MessageBox.Show("Kho này đã tồn tại ở chi nhánh bên kia");
                            }
                            break;
                        }
                    }
                }

                
                btnLuu.Enabled = true;

            }

            else
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (tboxTenKho.Text.Trim().ToUpper().ToString() == gridView1.GetRowCellValue(i, gridView1.Columns[1]).ToString()
                        && tBoxDiachi.Text.Trim().ToUpper().ToString() == gridView1.GetRowCellValue(i,gridView1.Columns[2]).ToString())
                    {
                        MessageBox.Show("Chưa chỉnh sửa kho");
                        break;
                    }
                    else
                    {
                        if (i == (gridView1.RowCount - 1))
                        {
                            int code = Execute("update", Kho_TrongForm, Kho_TrongBang);
                            if (code == 0)
                            {
                                MessageBox.Show("Update kho thành công");
                                btnReload.PerformClick();

                            }
                            else
                            {
                                MessageBox.Show("Lưu vật tư thất bại");
                            }
                        }
                    }
                }      
            }
        }

        private void tBoxMakho_TextChanged(object sender, EventArgs e)
        {
            if(tboxTenKho.Text.Trim() == "" || tBoxMakho.Text.Trim() == "")
            {
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void tboxTenKho_TextChanged(object sender, EventArgs e)
        {
            if (tboxTenKho.Text.Trim() == "" || tBoxMakho.Text.Trim() == "")
            {
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            else
            {
                btnLuu.Enabled = true;
                btnHuy.Enabled = true;
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadKho();
            btnLuu.Enabled = false;
            ForcusRowChangeData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tboxTenKho.Text = "";
            tboxTenKho.Text = "";
            tBoxMakho.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
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

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnXoa.Enabled = false;
           
            DataRow row = gridView1.GetFocusedDataRow();
            ListKho Kho_TrongBang = new ListKho
            {
                MaKho = row["MAKHO"].ToString(),
                TenKho = row["TENKHO"].ToString(),
                Diachi = row["DIACHI"].ToString()
            };
            ListKho Kho_TrongForm = new ListKho
            {
                MaKho = tBoxMakho.Text.Trim().ToString(),
                TenKho = tboxTenKho.Text.Trim().ToString(),
            };

            int code = Execute("delete", Kho_TrongForm, Kho_TrongBang);
            if (code == 0)
            {
                MessageBox.Show("Xoá thành công");
                btnReload.PerformClick();
            }
            else
                MessageBox.Show("Kho này tạm thời không được xóa.");
            tBoxMakho.Enabled = false;
            btnXoa.Enabled = true;
        }
    }
}

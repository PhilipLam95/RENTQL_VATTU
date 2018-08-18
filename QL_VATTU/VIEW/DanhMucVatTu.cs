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
    public partial class DanhMucVatTu : Form
    {
        public DanhMucVatTu()
        {
            InitializeComponent();
        }

        private Stack<Command> _commands;
        private static DataTable vattu = new DataTable();
        

        private void DanhMucVatTu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qL_VATTUDataSet.SP_LAYKHO' table. You can move, or remove it, as needed.
            _commands = new Stack<Command>();
            loadVattu();
            ConfigGrids();
            cboxTrangThai.DisplayMember = "Text";
            cboxTrangThai.ValueMember = "Value";
            for (int i = 0; i < 2; i++)
            {
                if (i == 1)
                {
                    cboxTrangThai.Items.Add(new { Text = "Ngừng bán", Value = i });
                }
                else
                {
                    cboxTrangThai.Items.Add(new { Text = "Đang bán", Value = i });
                }
                
            }
            cboxTrangThai.SelectedIndex = 0;
        }

        private void loadVattu()
        {
            VatTu vt  = new VatTu();
            vattu = vt.getVatTu();
            sP_LAY_VATTUGridControl.DataSource = vattu;
            sP_LAY_VATTUGridControl.DataMember = vattu.TableName;
        }

        private void ForcusRowChangeData()
        {
            DataRow row = gridView1.GetFocusedDataRow();
            tBoxMaVatTu.Text = row["MAVT"].ToString();
            tboxTenVattu.Text = row["TENVT"].ToString();
            tBoxDonVi.Text = row["DVT"].ToString();
            tboxSoluong.Text = row["SOLUONGTON"].ToString();
            tboxDongia.Text = row["DONGIA"].ToString();
            if (Convert.ToInt32(row["TrangThai"].ToString()) == 1)
            {
                cboxTrangThai.SelectedIndex = 1;
            }
            if (Convert.ToInt32(row["TrangThai"].ToString()) == 0)
            {
                cboxTrangThai.SelectedIndex = 0;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int Execute(string _operator, ListVatTu _operand, ListVatTu oldstate)
        {
            Command command = new Vattu_Command(_operator, _operand, oldstate);
            int code = command.Execute();
            _commands.Push(command);
            btnUndo.Enabled = true;
            return code;
            //return 0;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            tBoxMaVatTu.Enabled = false;
            btnXoa.Enabled = true;
            cboxTrangThai.Enabled = true;
            ForcusRowChangeData();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tBoxMaVatTu.Enabled = true;
            tBoxMaVatTu.Text = "";
            tboxTenVattu.Text = "";
            tBoxDonVi.Enabled = true;
            tBoxDonVi.Text = "";
            tboxDongia.Enabled = true;
            tboxDongia.Text = "";
            cboxTrangThai.SelectedIndex = 1;
            tboxSoluong.Text = "";
            VatTu vt = new VatTu();
            DataTable x = vt.getMaVatTuAuto();
            tBoxMaVatTu.Text = x.Rows[0]["MAVT"].ToString();
            


        }

        private int checkTrangThaiVatTu(string text)
        {
            if (text == "Đang bán")
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private int checkSoluong(string text)
        {
            if (text.Trim() != "")
            {
                return Convert.ToInt32(text);
            }
            else
            {
                return 0;
            }
        }
        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnLuu.Enabled = false;
            int noError = 0;
            string errors = " Nội dung nhập có 1 số lỗi sau. Vui lòng sửa trước khi lưu";
            if (tBoxMaVatTu.Text.Trim() == "")
            {
                errors += "\r\n+ Mã vật tự bị bỏ trống";
                noError++;
            }
            if (tboxTenVattu.Text.Trim() == "")
            {
                errors += "\r\n+ Tên vật tư bị bỏ trống";
                noError++;
            }
            if (tBoxDonVi.Text.Trim() == "")
            {
                errors += "\r\n+ Tên Đơn vị bị bỏ trống";
                noError++;
            }
            if (tboxDongia.Text.Trim() == "")
            {
                errors += "\r\n+ Đơn giá bị bỏ trống";
                noError++;
            }

            if (noError > 0)
            {
                MessageBox.Show(errors);
                btnLuu.Enabled = true;
                return;
            }

            DataRow row = gridView1.GetFocusedDataRow();
            ListVatTu Vattu_TrongBang = new ListVatTu
            {
                MAVT = row["MAVT"].ToString(),
                TENVT = row["TENVT"].ToString(),
                DVT = row["DVT"].ToString(),
                SOLUONGTON = Convert.ToInt32(row["SOLUONGTON"].ToString()),
                DONGIA = float.Parse(row["DONGIA"].ToString()),
                TrangThaiVT = Convert.ToInt32(row["TrangThai"].ToString())
            };

            ListVatTu Vattu_TrongForm = new ListVatTu
            {
                MAVT = tBoxMaVatTu.Text.Trim().ToString(),
                TENVT = tboxTenVattu.Text.Trim().ToString(),
                DVT = tBoxDonVi.Text.ToString(),
                SOLUONGTON = checkSoluong(tboxSoluong.Text.ToString()),
                DONGIA = float.Parse(tboxDongia.Text.ToString()),
                TrangThaiVT = checkTrangThaiVatTu(cboxTrangThai.Text.ToString())

            };

            if (tBoxMaVatTu.Enabled)
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    if (tBoxMaVatTu.Text.Trim().ToUpper().ToString() == gridView1.GetRowCellValue(i, gridView1.Columns[0]).ToString() ||
                        tboxTenVattu.Text.Trim().ToUpper().ToString() == gridView1.GetRowCellValue(i, gridView1.Columns[1]).ToString())
                    {
                        MessageBox.Show("Vật tư thêm đã tồn tại");
                        return;
                    }
                    else
                    {
                        if (i == (gridView1.RowCount - 1))
                        {
                            int code = Execute("insert", Vattu_TrongForm, Vattu_TrongBang);
                            if (code == 0)
                            {
                                MessageBox.Show("Thêm Vật tư Thành công");
                                btnReload.PerformClick();

                            }
                            else
                            {
                                MessageBox.Show("Vật tư đã tồn tại ở chi nhánh bên kia");
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
                    if (tboxTenVattu.Text.Trim().ToUpper().ToString() == gridView1.GetRowCellValue(i, gridView1.Columns[1]).ToString()
                        && tBoxDonVi.Text.Trim() == gridView1.GetRowCellValue(i, gridView1.Columns[2]).ToString()
                        )
                    {
                        MessageBox.Show("Vật tu thêm đã tồn tại");
                        break;
                    }
                    else
                    {
                        if (i == (gridView1.RowCount - 1))
                        {
                            int code = Execute("update", Vattu_TrongForm, Vattu_TrongBang);
                            if (code == 0)
                            {
                                MessageBox.Show("Update Vattu thành công");
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
            if (tboxTenVattu.Text.Trim() == "" || tboxTenVattu.Text.Trim() == "")
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
            if (tboxTenVattu.Text.Trim() == "" || tboxTenVattu.Text.Trim() == "")
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
            loadVattu();
            btnLuu.Enabled = false;
            ForcusRowChangeData();
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            tboxTenVattu.Text = "";
            tBoxMaVatTu.Text = "";
            tBoxMaVatTu.Enabled = false;
            tboxDongia.Text = "";
            tboxSoluong.Text = "";
            tboxSoluong.Enabled = false;
            tBoxDonVi.Text = "";
            cboxTrangThai.Enabled = false;
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
            if (tBoxMaVatTu.Text.Trim() == "")
            {
                MessageBox.Show("Chọn vật tư trước khi xóa");
                return;
            }
            DataRow row = gridView1.GetFocusedDataRow();
            ListVatTu Kho_TrongBang = new ListVatTu
            {
                MAVT = row["MAVT"].ToString(),
                TENVT = row["TENVT"].ToString(),
                DVT = row["DVT"].ToString(),
                SOLUONGTON = Convert.ToInt32(row["SOLUONGTON"].ToString()),
                DONGIA = float.Parse(row["DONGIA"].ToString()),
                TrangThaiVT = Convert.ToInt32(row["TrangThai"].ToString())
            };
            //MessageBox.Show(row["MAKHO"].ToString());
            ListVatTu Kho_TrongForm = new ListVatTu
            {
                MAVT = tBoxMaVatTu.Text.Trim().ToString(),
                TENVT = tboxTenVattu.Text.Trim().ToString(),
                DVT = tBoxDonVi.Text.ToString(),
                SOLUONGTON = checkSoluong(tboxSoluong.Text.ToString()),
                DONGIA = float.Parse(tboxDongia.Text.ToString()),
                TrangThaiVT = checkTrangThaiVatTu(cboxTrangThai.Text.ToString())
            };
            try
            {
                int code = Execute("delete", Kho_TrongForm, Kho_TrongBang);
                if (code == 0)
                {
                    MessageBox.Show("Xoá thành công");
                    btnReload.PerformClick();
                }
                else
                {
                    MessageBox.Show("Vât tư này đang bán - hoặc trong kho còn vật tư =>Không được xóa");
                }
                tBoxMaVatTu.Enabled = false;
                btnXoa.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Vât tư này đang bán - hoặc trong kho còn vật tư =>Không được xóa");
            }
            
                
           
        }

        private void ConfigGrids()
        {
            try
            {
                for (int i = 0; i < gridView1.Columns.Count; i++)
                {
                    gridView1.Columns[i].Visible = false;
                    gridView1.Columns[i].OptionsColumn.AllowEdit = true;
                    gridView1.Columns[i].OptionsFilter.AllowAutoFilter = true;
                    gridView1.Columns[i].OptionsFilter.AllowFilter = true;
                    gridView1.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
                    if (gridView1.Columns[i].FieldName == "MAVT")
                    {
                        gridView1.Columns[i].Visible = true;
                        gridView1.Columns[i].OptionsColumn.AllowEdit = true;
                        gridView1.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns[i].Caption = "Mã vật tư";
                        gridView1.Columns[i].Width = 45;
                        gridView1.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                    }
                    else if (gridView1.Columns[i].FieldName == "TENVT")
                    {
                        gridView1.Columns[i].Visible = true;
                        gridView1.Columns[i].Caption = "Tên vật tư";
                        gridView1.Columns[i].BestFit();
                        gridView1.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                        //SummaryField(gridView1, "GraduateLevelName", "Tổng: {0}", DevExpress.Data.SummaryItemType.Count);
                    }
                    else if (gridView1.Columns[i].FieldName == "DVT")
                    {
                        gridView1.Columns[i].Visible = true;
                        gridView1.Columns[i].Caption = "Đơn vị";
                        gridView1.Columns[i].BestFit();
                        gridView1.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                    }
                    else if (gridView1.Columns[i].FieldName == "SOLUONGTON")
                    {
                        gridView1.Columns[i].Visible = true;
                        gridView1.Columns[i].Caption = "Số lượng tồn";
                        gridView1.Columns[i].BestFit();
                        gridView1.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                    }
                    else if (gridView1.Columns[i].FieldName == "DONGIA")
                    {
                        gridView1.Columns[i].Visible = true;
                        gridView1.Columns[i].Caption = "Đơn giá";
                        gridView1.Columns[i].BestFit();
                        gridView1.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                    }

                    else if (gridView1.Columns[i].FieldName == "TrangThai")
                    {
                        gridView1.Columns[i].Visible = true;
                        gridView1.Columns[i].Caption = "Trạng Thái ";
                        gridView1.Columns[i].OptionsColumn.AllowEdit = true;
                        //gridView1.Columns[i].ColumnEdit = rep_Text;
                        gridView1.Columns[i].AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
                        gridView1.Columns[i].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
                        gridView1.Columns[i].OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
                        gridView1.Columns[i].Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
                        gridView1.Columns[i].VisibleIndex = 80;
                        gridView1.Columns[i].Width = 100;
                        gridView1.Columns[i].BestFit();
                    }
                }
            }
            catch
            {

            }
        }

        private void rep_Text_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void sP_LAY_VATTUGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}

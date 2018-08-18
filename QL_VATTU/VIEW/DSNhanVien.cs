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
using System.Data.SqlClient;

namespace QLYVATTU.VIEW
{
    public partial class DSNhanVien : Form
    {
        public DSNhanVien()
        {
            InitializeComponent();
        }

        public string tenlogin;
        public string role_login;

        private static DataTable dsnv;
        //add chi nhánh vào combobox
        private void AddCN()
        {
            foreach (Connection cnn in Access.CnnList)
            {
                cbChiNhanh.Items.Add(cnn.ChiNhanh);
                if (Access.MACN == cnn.MaCN)
                {
                    lbTenCN.Text = cnn.ChiNhanh;
                }
            }
            cbChiNhanh.SelectedIndex = 0;
        }
        private void DSNhanVien_Load(object sender, EventArgs e)
        {
            AddCN();
            NhanVien nhanvien = new NhanVien();
            dsnv = nhanvien.getUser();
            grNV.DataSource = dsnv;
            grNV.DataMember = dsnv.TableName;
            tbMaNV.ReadOnly = true;
            tbTenNV.ReadOnly = true;
            tbNgaySinh.ReadOnly = true;
            tbDiaChi.ReadOnly = true;
            tbChucVu.ReadOnly = true;
            tbTenCN.ReadOnly = true;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            DataRow nhanvien = gridView1.GetFocusedDataRow();
            tbMaNV.Text = nhanvien[0].ToString();
            tbTenNV.Text = nhanvien[1].ToString() + " " + nhanvien[2].ToString();
            tbNgaySinh.Text = nhanvien[3].ToString();
            tbDiaChi.Text = nhanvien[4].ToString();
            tbChucVu.Text = nhanvien[6].ToString();
            tbTenCN.Text = lbTenCN.Text;
        }

        private void cbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                Connection cnn = Access.CnnList[cbChiNhanh.SelectedIndex];
                string macn = cnn.MaCN;
                string manv = tbMaNV.Text;
                SqlDataReader role;
                NhanVien nhanvien = new NhanVien();
                string[] ma = { manv };
                role = nhanvien.KiemTraNV(ma);
                role.Read();
                
                 tenlogin = role["TENLOGIN"].ToString();
                 role_login = role["ROLE"].ToString();
                role.Close();



                if (macn == Access.MACN.ToString())
                {
                    MessageBox.Show("Nhân Viên Đang Làm Viện Trên Chi Nhánh Này");
                    return;
                }
                else
                {
                    
                    
                    //MessageBox.Show(role["MATKHAU"].ToString());
                    if (role == null || (role_login != "CongTy" && role_login != "ChiNhanh")) //xet them ten login, pass
                    {  
                        string[] param = { manv, macn, tenlogin, role_login };
                        //NhanVien nhanvien = new NhanVien();
                        try
                        {

                            NhanVien nvv = new NhanVien();
                            int y = nvv.ChuyenNV(param);
                            if (y == 0)
                            {
                                MessageBox.Show("Chuyển Nhân Viên Sang " + cnn.ChiNhanh + " Thành Công!", "Thông Báo");
                                MessageBox.Show("Tên Login sau khi chuyển qua server kia :" + tenlogin.ToString());
                                DSNhanVien_Load(sender, e);

                            }
                            else
                            {
                                MessageBox.Show("That bai");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex.ToString(), "Error");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.ToString(), "Error");
            }
        }
    }
}

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
using System.Data.SqlClient;

namespace QLYVATTU.VIEW
{
    public partial class DangNhap : DevExpress.XtraEditors.XtraForm
    {

        
        public DangNhap()
        {
            InitializeComponent();
        }


        private SqlDataReader reader;
        private void DangNhapcs_Load(object sender, EventArgs e)
        {
            add_CN();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void add_CN()
        {

            foreach (Connection cnn in Access.CnnList)
            {
                comboBox1.Items.Add(cnn.ChiNhanh);
            }
            comboBox1.SelectedIndex = 0;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private bool CheckEmpty()
        {
            
            if (tboxTaiKhoan.Text == "")
            {
                MessageBox.Show(" Tên tài khoản không được để trống");
                return false;
            }

            if (tboxMatKhau.Text == "")
            {
                MessageBox.Show("Nhập mật khẩu của bạn");
                return false;
            }
            else
                return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            try
            {
               
                bool x = CheckEmpty();
                if (x == false)
                {
                    return;
                }
                else
                {
                    Connection cnn = Access.CnnList[comboBox1.SelectedIndex];
                    Access.DATA_SOURCE = cnn.DataSource;
                    Access.MACN = cnn.MaCN;
                    string username = tboxTaiKhoan.Text.Trim();
                    string password = tboxMatKhau.Text.Trim();
                    Access.USERNAME = username;
                    Access.PASSWORD = password;

                    if (!Access.Connect())
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu của bạn đã sai !!!");
                        return;
                    }
                    else
                    {
                        try
                        {
                            string[] param = { username };
                            ChiNhanh chinhanh = new ChiNhanh();
                            reader = chinhanh.getLogin(param);
                            reader.Read();
                            if (reader.HasRows)
                            {
                                Console.WriteLine(reader["MANV"].ToString() + reader["HOTEN"].ToString() + reader["ROLE"].ToString());

                                Access.ROLE = reader["ROLE"].ToString();
                                Access.HOTEN = reader["HOTEN"].ToString();
                                Access.MANV = reader["MANV"].ToString();
                                if (Access.ROLE == "ChiNhanh")
                                {
                                    MessageBox.Show("Đăng Nhập Thành Công");
                                    Program.fmain.HienThiQuyen_ChiNhanh();
                                }

                                if (Access.ROLE == "CongTy")
                                {
                                    MessageBox.Show("Đăng Nhập Thành Công");
                                    Program.fmain.HienThiQuyen_CongTy();
                                }

                                if (Access.ROLE == "User")
                                {
                                    MessageBox.Show("Đăng Nhập Thành Công");
                                    Program.fmain.HienThiQuyen_User();
                                }

                            }
                            else
                            {
                                MessageBox.Show("Nhân viên này đã nghỉ. Không thể đăng nhập");
                            }
                            reader.Close();
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi đăng nhập");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không Tồn Tại Server này!!!. Mời bạn chọn lại ");
            }
        }

    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
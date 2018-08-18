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

namespace QLYVATTU.VIEW
{
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            labelUserName.Text = Access.USERNAME;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string oldpassword = tboxOldPassword.Text.Trim().ToString();
            string newpassword = tBoxNewPassword.Text.Trim().ToString();
            string confirmpass = tboxConfirmPassword.Text.Trim().ToString();
            string errors = "Có 1 số lỗi sau :";
            int noError = 0;
            if(oldpassword == "" || newpassword == "" || confirmpass == "")
            {
                errors += "\r\n Có trường nào bạn đã để trống";
                noError++;
            }
            if(oldpassword != Access.PASSWORD)
            {
                errors += "\r\n Mật khẩu cũ bạn nhập không chính xác";
                noError++;
            }
            if(newpassword != confirmpass)
            {
                errors += "\r\n Mật khẩu mới và mật khẩu xác nhận không giống nhau";
                noError++;
            }

            if(noError > 0)
            {
                MessageBox.Show(errors);
                return;
            }
            else
            {
                NhanVien nvien = new NhanVien();
                string[] param = { oldpassword, newpassword, Access.USERNAME };
                
                int a = nvien.DoiMatKhau(param);
                    if (a == 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công");
                        Access.PASSWORD = newpassword;
                        tboxOldPassword.Text = "";
                        tBoxNewPassword.Text = "";
                        tboxConfirmPassword.Text = "";
                    }
                    else
                {
                    MessageBox.Show("Đổi mật khẩu thất bại");
                }
                
                
            }
        }
    }
}

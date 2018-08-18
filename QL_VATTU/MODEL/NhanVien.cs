using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYVATTU.MODEL
{
    class NhanVien
    {
        public static String SP_LAY_NHANVIEN = "SP_LAY_NHANVIEN";
        public static String SP_TAOTAIKHOAN_NHANVIEN = "SP_TAOTAIKHOAN_NHANVIEN";
        public static String SP_CHUYEN_NV = "SP_CHUYEN_NV";
        public static String SP_KIEMTRA_ROLE = "SP_KIEMTRA_ROLE";
        public static String SP_LOAD_USER = "SP_LOAD_USER";
        public static string SP_DOIMATKHAU = "SP_DOIMATKHAU";
        public static String SP_LAYNHANVIEN_USER = "SP_LAYNHANVIEN_USER";
        public static String SP_LAYNHANVIEN_USER_CHINHANH = "SP_LAYNHANVIEN_USER_CHINHANH";
        public static String SP_LAYMA_NV_TUDONG = "SP_LAYMA_NV_TUDONG";
        public DataTable getNhanVien() // lay nhan vien
        {
            DataTable nhanvien = Access.ExecuteQuery(SP_LAY_NHANVIEN, null);
            return nhanvien;
        }

        public DataTable getManvtudong()
        {
            DataTable nhanvien = Access.ExecuteQuery(SP_LAYMA_NV_TUDONG, null);
            return nhanvien;
        }

        public DataTable getNhanVienUser()
        {
            DataTable nhanvien = Access.ExecuteQuery(SP_LAYNHANVIEN_USER, null);
            return nhanvien;
        }

        public DataTable getNhanVien_User_ChiNhanh()
        {
            DataTable nhanvien = Access.ExecuteQuery(SP_LAYNHANVIEN_USER_CHINHANH, null);
            return nhanvien;
        }


        public int DoiMatKhau(string[] param) // doi mat khau
        {
           string[] name = { "@oldpassword", "@newpassword", "@login" };
            int x = Access.ExecuteNonQuery(SP_DOIMATKHAU, name, param, 3);
            return x;
        }

        public DataTable getUser() // lay nhan vien để chuyển chi nhánh
        {
            DataTable nhanvien = Access.ExecuteQuery(SP_LOAD_USER, null);
            return nhanvien;
        }

        public int InserCusomer(string[] param)
        {
            string[] name = { "@HO", "@TEN", "@LUONG", "@NGAYSINH", "@DIACHI", "@LGNAME", "@PASS", "@ROLE" };
            int x = Access.ExecuteNonQuery("SP_TAOTAIKHOAN_NHANVIEN", name, param, 8);
            return x;
        }

        //chuyển nhân viên sang chi nhánh khác để làm việc
        public int ChuyenNV(string[] param)
        {
            string[] name = { "@MANV", "@MACN", "@TENLOGIN", "@ROLE" };
            int x = Access.ExecuteNonQuery(SP_CHUYEN_NV, name, param, 4);
            return x;
        }
        //kiem tra role nhan vien co duoc chuyen sang chi nhanh khac hay kg
        //neu role conty thi kg dc chuyen
        public SqlDataReader KiemTraNV(string[] param)
        {
            string[] name = { "@MANV" };
            SqlDataReader role = Access.ExecSqlDataReader(SP_KIEMTRA_ROLE, name, param, 1);
            return role;
        }

        public DataTable getNhanVienTheoCN(string[] param)
        {
            string[] name = { "@MACN" };
            DataTable NV = Access.ExecuteQuery("SP_LAY_NHANVIENTHEOCN", name, param, 1);
            return NV;
        }

    }
}

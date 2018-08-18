using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLYVATTU.MODEL
{
    class Report
    {

        public static string SP_THONGKESOHANGNHAP = "SP_THONGKESOHANGNHAP";
        public static string SP_THONGKESOHANGXUAT = "SP_THONGKESOHANGXUAT";
        public static String SP_CHITIETHANGNHAP = "SP_CHITIETHANGNHAP";
        public static String SP_CHITIETHANGXUAT = "SP_CHITIETHANGXUAT";
        public static String SP_TONGCHI = "SP_TONGCHI";
        public static String SP_TONGTHU = "SP_TONGTHU";
        public static String SP_TONGHOPNHAPXUAT = "SP_TONGHOPNHAPXUAT";
        public static String SP_HOATDONGNHANVIEN = "SP_HOATDONGNHANVIEN";

        public static string SP_REPORT_DS_NHANVIEN = "SP_REPORT_DS_NHANVIEN";
        public static string SP_REPORT_DS_NHANVIEN_THEOMA = "SP_REPORT_DS_NHANVIEN_THEOMA";


        public DataTable THONGKEHANGNHAP(string[] param)
        {
            string[] name = { "@FromDay", "@ToDay", "@Role" };
            DataTable hangnhap = Access.ExecuteQuery(SP_THONGKESOHANGNHAP, name, param, 3);
            return hangnhap;
        }
        public DataTable THONGKEHANGXUAT(string[] param)
        {
            string[] name = { "@FromDay", "@ToDay", "@Role" };
            DataTable hangxuat = Access.ExecuteQuery(SP_THONGKESOHANGXUAT, name, param, 3);
            return hangxuat;
        }

        //public DataTable ChiTietHangNhap(string[] param)
        //{
        //    string[] name = { "@DateFrom", "@DateTo","@MACN" };
        //    DataTable hangnhap = Access.ExecuteQuery(SP_CHITIETHANGNHAP, name, param, 3);
        //    return hangnhap;
        //}

        //public DataTable ChiTietHangXuat(string[] param)
        //{
        //    string[] name = { "@DateFrom", "@DateTo","@MACN" };
        //    DataTable hangxuat = Access.ExecuteQuery(SP_CHITIETHANGXUAT, name, param, 3);
        //    return hangxuat;
        //}

        public DataTable TongChi(string[] param)
        {
            string[] name = { "@DateFrom", "@DateTo", "@MACN" };
            DataTable tongchi = Access.ExecuteQuery(SP_TONGCHI, name, param, 3);
            return tongchi;
        }

        public DataTable TongThu(string[] param)
        {
            string[] name = { "@DateFrom", "@DateTo", "@MACN" };
            DataTable tongthu = Access.ExecuteQuery(SP_TONGTHU, name, param, 3);
            return tongthu;
        }

        public DataTable ThongKeNhapXuat(string[] param)
        {
            string[] name = { "@DateFrom", "@DateTo", "@MACN" };
            DataTable tonghop = Access.ExecuteQuery(SP_TONGHOPNHAPXUAT, name, param, 3);
            return tonghop;
        }

        public DataTable HoatDongNhanVien(string[] param)
        {
            string[] name = { "@MaNV", "@DateFrom", "@DateTo", "@MACN" };
            DataTable nv = Access.ExecuteQuery(SP_HOATDONGNHANVIEN, name, param, 4);
            return nv;
        }

        public DataTable Load_REPORT_DS_NHANVIEN()
        {
            DataTable nv = Access.ExecuteQuery(SP_REPORT_DS_NHANVIEN, null);
            return nv;
        }

        public DataTable Load_REPORT_DS_NHANVIEN_THEOMA(string[] param)
        {
            string[] name = { "@MACN" };
            DataTable nv = Access.ExecuteQuery(SP_REPORT_DS_NHANVIEN_THEOMA, name, param, 1);
            return nv;
        }
    }
}

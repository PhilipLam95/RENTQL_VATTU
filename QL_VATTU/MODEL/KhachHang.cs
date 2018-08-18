using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYVATTU.MODEL
{
    class KhachHang
    {
        public static String SP_TIMKIEM_KHACHHANG = "SP_TIMKIEM_KHACHHANG";
        public static String SP_DS_KHACHHANG = "SP_DS_KHACHHANG";
        public static String SP_LAYMAKHACHHANG = "SP_LAYMAKHACHHANG";
        public static String SP_TAO_KH = "SP_TAO_KH";

        public DataTable getKhachHang()
        {
            DataTable khachhang = Access.ExecuteQuery(SP_DS_KHACHHANG, null);
            return khachhang;
        }
        public DataTable getTimKhachHang(String[] param) //KG CAN, TRONG GRIDVIEW DA HO TRO TIM KIEM BAO NGON
        {
            String[] name = { "@TUKHOA" };
            DataTable khachhang = Access.ExecuteQuery(SP_TIMKIEM_KHACHHANG, name, param, 1);
            return khachhang;
        }

        public SqlDataReader getMaKhachHang()
        {
            SqlDataReader maKH = Access.ExecSqlDataReader(SP_LAYMAKHACHHANG, null);
            return maKH;
        }
        public int taoKhachHang(string[] param)
        {
            String[] name = { "@MAKH", "@TENKH", "@SODT", "@DIACHI" };
            int i = Access.ExecuteNonQuery(SP_TAO_KH, name, param, 4);
            return i;
        }
    }
}

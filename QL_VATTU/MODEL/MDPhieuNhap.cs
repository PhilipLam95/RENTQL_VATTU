using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLYVATTU.MODEL
{
    class MDPhieuNhap
    {

        public static string SP_DS_CHITIET_DONDATHANG_THEOMA = "SP_DS_CHITIET_DONDATHANG_THEOMA";
        public static string SP_DS_DONDATHANG_CHUANHAP = "SP_DS_DONDATHANG_CHUANHAP";
        public static string SP_LAYPHIEUNHAP_TUDONG = "SP_LAYPHIEUNHAP_TUDONG";
        public static string SP_DS_PHIEUNHAP = "SP_DS_PHIEUNHAP";
        public static string SP_TAO_PHIEUNHAP = "SP_TAO_PHIEUNHAP";
        public static string SP_DS_CHITIET_PHIEUNHAP = "SP_DS_CHITIET_PHIEUNHAP";


        public DataTable getDS_DonDatHang_ChuaNhap()
        {
            DataTable dondh = Access.ExecuteQuery(SP_DS_DONDATHANG_CHUANHAP, null);
            return dondh;
        }
        public DataTable getChiTietDonDatHangTheoMa(string[] param)
        {
            string[] name = { "@MADDH" };
            DataTable dondh = Access.ExecuteQuery(SP_DS_CHITIET_DONDATHANG_THEOMA, name, param, 1);
            return dondh;
        }

        public DataTable getChiTietPhieuNhap(string[] param)
        {

            string[] name = { "@MAPN" };
            DataTable pn = Access.ExecuteQuery(SP_DS_CHITIET_PHIEUNHAP, name, param, 1);
            return pn;
        }


        public SqlDataReader getMaPhieuNhap_TuDong()
        {
            SqlDataReader mapn = Access.ExecSqlDataReader(SP_LAYPHIEUNHAP_TUDONG, null);
            return mapn;
        }

        public DataTable getDS_PHIEUNHAP()
        {
            DataTable pnhap = Access.ExecuteQuery(SP_DS_PHIEUNHAP, null);
            return pnhap;
        }

        public int CreatePhieuNhap(string[] param)
        {
            string[] name = { "@XmlData" };
            int x = Access.ExecuteNonQuery(SP_TAO_PHIEUNHAP, name, param, 1);
            return x;
        }
    }
}

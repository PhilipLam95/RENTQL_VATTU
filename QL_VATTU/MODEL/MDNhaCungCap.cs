using System;
using System.Data;
using System.Data.SqlClient;


namespace QLYVATTU.MODEL
{
    class MDNhaCungCap
    {
        public static String SP_DS_NCC = "SP_DS_NCC";
        public static String SP_DS_CT_NCC = "SP_DS_CT_NCC";
        public static String SP_LAYMANCC = "SP_LAYMANCC";
        public static String SP_TAO_NCC = "SP_TAO_NCC";
        public static String SP_XOA_VT_NCC = "SP_XOA_VT_NCC";
        public static String SP_THEM_VT_NCC = "SP_THEM_VT_NCC";

        public DataTable getDSNCC() //danh sach nha cung cap
        {
            DataTable nhaCC = Access.ExecuteQuery(SP_DS_NCC, null);
            return nhaCC;
        }

        //lay chi tiet nha cung cap
        public DataTable getCTNCC(string[] param)
        {
            string[] name = { "@MANCC" };
            DataTable ctNCC = Access.ExecuteQuery(SP_DS_CT_NCC, name, param, 1);
            return ctNCC;
        }

        public SqlDataReader GetMaNCC()
        {
            SqlDataReader mancc = Access.ExecSqlDataReader(SP_LAYMANCC, null);
            return mancc;
        }

        //tao nha cung cap
        public int CreateNCC(string[] param)
        {
            string[] name = { "@MANCC", "@TENNCC", "@DIACHI", "@SDT", "@MAVT" };
            int x = Access.ExecuteNonQuery(SP_TAO_NCC, name, param, 5);
            return x;
        }

        public int xoaVTNCC(string[] param)
        {
            string[] name = { "MANCC", "MAVT" };
            int x = Access.ExecuteNonQuery(SP_XOA_VT_NCC, name, param, 2);
            return x;
        }

        public int ThemVTNCC(string[] param)
        {
            string[] name = { "@MANCC", "@MAVT" };
            int x = Access.ExecuteNonQuery(SP_THEM_VT_NCC, name, param, 2);
            return x;
        }
    }
}

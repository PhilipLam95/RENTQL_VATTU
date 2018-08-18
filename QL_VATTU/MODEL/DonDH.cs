using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLYVATTU.MODEL
{
    class DonDH
    {

        public static string SP_DS_DONDATHANG = "SP_DS_DONDATHANG";
        public static string SP_LAYMADONDATHANG_TUDONG = "SP_LAYMADONDATHANG_TUDONG";
        public static string SP_LAYKHO = "SP_LAYKHO";
        public static string SP_TAO_DONAHNG = "SP_TAO_DONHANG";
        public static string SP_LAYNHACUNGCAP = "SP_LAYNHACUNGCAP";
        public static string SP_DS_CHITIET_DONDATHANG = "SP_DS_CHITIET_DONDATHANG";

        public DataTable getDonDatHang()
        {
            DataTable dondh = Access.ExecuteQuery(SP_DS_DONDATHANG, null);
            return dondh;
        }

        public DataTable getChiTietDonDatHang(string[] param)
        {
            string[] name = { "@MADDH" };
            Console.WriteLine(name[0]);
            DataTable dondh = Access.ExecuteQuery(SP_DS_CHITIET_DONDATHANG, name, param, 1);
            return dondh;
        }
        public DataTable getKho()
        {
            DataTable kho = Access.ExecuteQuery(SP_LAYKHO, null);
            return kho;
        }

        public SqlDataReader getMaDDH()
        {

            SqlDataReader maddh = Access.ExecSqlDataReader(SP_LAYMADONDATHANG_TUDONG, null);
            return maddh;
        }

        public DataTable getNhacungcap()
        {
            DataTable nhacc = Access.ExecuteQuery(SP_LAYNHACUNGCAP, null);
            return nhacc;
        }


        public int Create_DonHang(string[] param)
        {
            string[] name = { "@XmlData" };
            int x = Access.ExecuteNonQuery("SP_TAO_DONHANG", name, param, 1);
            return x;
        }
    }
}
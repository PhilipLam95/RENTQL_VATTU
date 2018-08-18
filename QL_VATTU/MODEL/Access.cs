using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace QLYVATTU.MODEL
{
    class Access
    {


        public static String DATA_SOURCE = @"LAM-A75\SERVER1";//địa chỉ cơ sở dữ liệu

        public static String INITIAL_CATALOG = "QL_VATTU";//tên cơ sở dữ liệu
        public static String USERNAME = "sa";//tài khoản
        public static String PASSWORD = "123";//mật khẩu
        public static string MACN = "CN1"; // Ma chi nhanh

        //thông tin tài khoản đang đăng nhập
        public static String HOTEN = "";
        public static String ROLE = "";
        public static String MANV = "";

        public static List<Connection> CnnList = new List<Connection>();

        public static SqlConnection connection;




        public static bool Connect()
        {
            if (connection != null && connection.State == ConnectionState.Open)
                connection.Close();
            try
            {
                /*string connectionString = string.Format(@"Data Source={0};Initial Catalog={1};Persist Security Info=True;
                                        User ID={2};Password={3};", dataSource, initCatalog, username, password);*/
                string connectionString = string.Format(@"Data Source=" + DATA_SOURCE + ";" + "Initial Catalog=" + INITIAL_CATALOG + ";"
                    + "Persist Security Info=True" + ";" + "User ID=" + USERNAME + ";" + "password=" + PASSWORD + ";");



                /* string connectionString = string.Format(@"Data Source=DELL-PC\SERVER_ONE;Initial Catalog=QLDSV;Persist Security Info=True;User ID=sa;Password=123");*/
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }

        }

        public static void Close()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }

        public static DataTable ExecuteQuery(string _cmd, string[] name = null, object[] value = null, int NoParam = 0, CommandType cmdType = CommandType.StoredProcedure)
        {
            try
            {
                DataTable dataTable;
                if (connection == null || connection.State == ConnectionState.Closed)
                {
                    Connect();
                }
                using (SqlCommand sqlCmd = new SqlCommand(_cmd, connection))
                {
                    for (int i = 0; i < NoParam; i++)
                    {
                        sqlCmd.Parameters.AddWithValue(name[i], value[i]);
                    }
                    sqlCmd.CommandType = cmdType;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCmd);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    Close();
                }
                return dataTable;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                Close();
                return null;
            }

        }




        public static SqlDataReader ExecSqlDataReader(string _cmd, string[] name = null, object[] value = null, int NoParam = 0,
                    CommandType cmdType = CommandType.StoredProcedure)
        {
            try
            {
                SqlDataReader reader;
                if (connection == null || connection.State == ConnectionState.Closed)
                    Connect();
                using (SqlCommand sqlCmd = new SqlCommand(_cmd, connection) { CommandType = CommandType.Text })
                {
                    for (int i = 0; i < NoParam; i++)
                    {
                        sqlCmd.Parameters.AddWithValue(name[i], value[i]);
                    }
                    sqlCmd.CommandType = cmdType;
                    reader = sqlCmd.ExecuteReader();
                }
                return reader;

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                Close();
                return null;
            }

        }

        public static int ExecuteNonQuery(string _cmd, string[] name = null, object[] value = null, int NoParam = 0,
             CommandType cmdType = CommandType.StoredProcedure)
        {
            int retval;
            if (connection == null || connection.State == ConnectionState.Closed)
            {
                Connect();
            }
            try
            {
                
                using (SqlCommand sqlCmd = new SqlCommand(_cmd, connection))
                {
                    for (int i = 0; i < NoParam; i++)
                    {
                        sqlCmd.Parameters.AddWithValue(name[i], value[i]);
                    }
                    SqlParameter retParam = new SqlParameter() { SqlDbType = SqlDbType.Int, ParameterName = "@retParam", Direction = ParameterDirection.ReturnValue };
                    sqlCmd.Parameters.Add(retParam);
                    sqlCmd.CommandType = cmdType;
                    sqlCmd.ExecuteNonQuery();
                    retval = (int)sqlCmd.Parameters["@retParam"].Value;
                    Close();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                Close();
                return -1;
            }
            return retval;
            
        }

        
    }
}

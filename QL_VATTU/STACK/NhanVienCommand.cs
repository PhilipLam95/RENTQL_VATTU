using System;
using QLYVATTU.LIST_ARRAY;
using QLYVATTU.MODEL;

namespace QLYVATTU.STACK
{
    class NhanVienCommand : Command
    {

        private string _operator;
        private ListNhanVien _operand;
        private ListNhanVien oldstate;


        public NhanVienCommand(string _operator, ListNhanVien _operand, ListNhanVien oldstate)
        {
            this._operator = _operator;
            this._operand = _operand;
            this.oldstate = oldstate;
        }


        public override int Execute()
        {
            return Operation(_operator, _operand, oldstate);
        }

        public override int UnExecute()
        {
            return Operation(Undo(_operator), _operand, oldstate);
        }

        public string Undo(string _operator)
        {
            switch (_operator)
            {
                case "insert": return "delete";
                case "update": return "unupdate";
                case "delete": return "insert";
                default:
                    throw new ArgumentException("_operator");
            }
        }
        public int Operation(string _operator, ListNhanVien _operand, ListNhanVien oldstate)
        {
            int code = 0;
            switch (_operator)
            {
                case "insert":
                    code = CreateNhanVien(_operand);
                    break;
                case "update":
                    code = UpdateNhanVien(_operand);
                    break;
                case "delete":
                    code = RemoveNhanVien(_operand);
                    break;
                case "unupdate":
                    code = UpdateNhanVien(oldstate);
                    break;
            }
            return code;
        }

       
        private int CreateNhanVien(ListNhanVien nv)
        {

            string[] name = { "@HO", "@TEN", "@PHAI", "@NGAYSINH", "@DIACHI", "@SDT", "@LGNAME", "@PASS", "@ROLE" };
            object[] param = {  nv.HO,nv.TEN,nv.Phai,nv.NgaySinh,nv.DiaChi,nv.Sdt,nv.login,nv.matkhau,nv.role};
            return Access.ExecuteNonQuery("SP_TAOTAIKHOAN_NHANVIEN", name, param, 9);
        }

        private int UpdateNhanVien(ListNhanVien nv)
        {
            string[] name = { "@MANV","@HO", "@TEN", "@PHAI", "@NGAYSINH", "@DIACHI", "@SDT", "@ROLE","@TRTHAI" };
            object[] param = { nv.MaNV,nv.HO, nv.TEN, nv.Phai, nv.NgaySinh, nv.DiaChi, nv.Sdt, nv.role,nv.Trangthai };
            return Access.ExecuteNonQuery("SP_UPDATE_NHANVIEN", name, param, 9);
        }

        private int RemoveNhanVien(ListNhanVien nv)
        {
            string[] name = { "@MANV" };
            object[] param = { nv.MaNV };
            return Access.ExecuteNonQuery("SP_XOA_NHANVIEN", name, param, 1);
        }



    }
}

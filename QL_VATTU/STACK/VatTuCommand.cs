using System;
using QLYVATTU.LIST_ARRAY;
using QLYVATTU.MODEL;

namespace QLYVATTU.STACK
{
    class Vattu_Command : Command
    {

        private string _operator;
        private ListVatTu _operand;
        private ListVatTu oldstate;


        public Vattu_Command(string _operator, ListVatTu _operand, ListVatTu oldstate)
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
        public int Operation(string _operator, ListVatTu _operand, ListVatTu oldstate)
        {
            int code = 0;
            switch (_operator)
            {
                case "insert":
                    code = CreateVatTu(_operand);
                    break;
                case "update":
                    code = UpdateVatTu(_operand);
                    break;
                case "delete":
                    code = RemoveVatTu(_operand);
                    break;
                case "unupdate":
                    code = UpdateVatTu(oldstate);
                    break;
            }
            return code;
        }

        private int CreateVatTu(ListVatTu vt)
        {

            string[] name = { "@MAVT", "@TENVT", "@DONVI","@DONGIA" };
            object[] param = { vt.MAVT, vt.TENVT,vt.DVT,vt.DONGIA  };
            return Access.ExecuteNonQuery("SP_TAO_VATTU", name, param, 4);
        }

        private int UpdateVatTu(ListVatTu vt)
        {
            string[] name = { "@MAVT", "@TENVT", "@DONVI", "@TRANGTHAI","@DONGIA" };
            object[] param = { vt.MAVT, vt.TENVT, vt.DVT, vt.TrangThaiVT,vt.DONGIA };
            return Access.ExecuteNonQuery("SP_SUA_VATTU", name, param, 5);
        }

        private int RemoveVatTu(ListVatTu vt)
        {
            string[] name = { "@MAVT" };
            object[] param = { vt.MAVT };
            return Access.ExecuteNonQuery("SP_XOA_VATTU", name, param, 1);
        }



    }
}

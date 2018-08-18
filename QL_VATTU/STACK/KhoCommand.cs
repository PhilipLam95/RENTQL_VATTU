using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLYVATTU.LIST_ARRAY;
using QLYVATTU.MODEL;

namespace QLYVATTU.STACK
{
    class KhoCommand : Command
    {
        private string _operator;
        private ListKho _operand;
        private ListKho oldstate;


        public KhoCommand(string _operator, ListKho _operand, ListKho oldstate)
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
        public int Operation(string _operator, ListKho _operand, ListKho oldstate)
        {
            int code = 0;
            switch (_operator)
            {
                case "insert":
                    code = CreateKho(_operand);
                    break;
                case "update":
                    code = UpdateKho(_operand);
                    break;
                case "delete":
                    code = RemoveKho(_operand);
                    break;
                case "unupdate":
                    code = UpdateKho(oldstate);
                    break;
            }
            return code;
        }

        private int CreateKho(ListKho kho)
        {

            string[] name = { "@MAKHO", "@TENKHO","@DIACHI"};
            object[] param = { kho.MaKho, kho.TenKho ,kho.Diachi };
            return Access.ExecuteNonQuery("SP_TAO_KHO", name, param, 3);
        }

        private int UpdateKho(ListKho kho)
        {
            string[] name = { "@MAKHO", "@TENKHO", "@DIACHI" };
            object[] param = { kho.MaKho, kho.TenKho, kho.Diachi };
            return Access.ExecuteNonQuery("SP_SUA_KHO", name, param, 3);
        }

        private int RemoveKho(ListKho kho)
        {
            string[] name = { "@MAKHO" };
            object[] param = { kho.MaKho };
            return Access.ExecuteNonQuery("SP_XOA_KHO", name, param, 1);
        }

    }
}

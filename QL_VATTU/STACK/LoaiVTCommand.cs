using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLYVATTU.MODEL;
using QLYVATTU.LIST_ARRAY;

namespace QLYVATTU.STACK
{
    class LoaiVTCommand : Command
    {

        private string _operator;
        private ListLoaiVatTu _operand;
        private ListLoaiVatTu oldstate;



        public LoaiVTCommand(string _operator, ListLoaiVatTu _operand, ListLoaiVatTu oldstate)
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
        public int Operation(string _operator, ListLoaiVatTu _operand, ListLoaiVatTu oldstate)
        {
            int code = 0;
            switch (_operator)
            {
                case "insert":
                    code = CreateLoaiVatTu(_operand);
                    break;
                case "update":
                    code = UpdateLoaiVatTu(_operand);
                    break;
                case "delete":
                    code = RemoveLoaiVatTu(_operand);
                    break;
                case "unupdate":
                    code = UpdateLoaiVatTu(oldstate);
                    break;
            }
            return code;
        }

        private int CreateLoaiVatTu(ListLoaiVatTu lvt)
        {
            string[] name = { "MALOAI", "@TENLOAI" };
            string[] param = { lvt.MALOAI, lvt.TENLOAI };
            return Access.ExecuteNonQuery("SP_TAO_LOAIVT", name, param, 2);
        }

        private int UpdateLoaiVatTu(ListLoaiVatTu lvt)
        {
            string[] name = { "MALOAI", "@TENLOAI" };
            string[] param = { lvt.MALOAI, lvt.TENLOAI };
            return Access.ExecuteNonQuery("SP_SUA_LOAIVT", name, param, 2);
        }

        private int RemoveLoaiVatTu(ListLoaiVatTu lvt)
        {
            string[] name = { "MALOAI" };
            string[] param = { lvt.MALOAI };
            return Access.ExecuteNonQuery("SP_XOA_LOAIVT", name, param, 1);
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;
using QLYVATTU.MODEL;

namespace QL_VATTU.VIEW
{
    public partial class CT_PhieuNhap : Form
    {

        private static DataTable pnhap;
        public delegate void SendMessage(string ct_pn);
        public SendMessage Sender;
        public CT_PhieuNhap()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }

        private void load_CTPN(string ct_pn)
        {
            string[] param = { ct_pn };
            MDPhieuNhap phieunhap = new MDPhieuNhap();
            pnhap = phieunhap.getChiTietPhieuNhap(param);
            sP_DS_CHITIET_PHIEUNHAPGridControl.DataSource = pnhap;
            sP_DS_CHITIET_PHIEUNHAPGridControl.DataMember = pnhap.TableName;
        }

        private void GetMessage(string ct_pn)
        {
            label1.Text = ct_pn.ToUpper();
            load_CTPN(ct_pn);
        }

        private void CT_PhieuNhap_Load(object sender, EventArgs e)
        {
           

        }
    }
}

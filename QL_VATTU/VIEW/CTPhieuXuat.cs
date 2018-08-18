using QLYVATTU.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYVATTU.VIEW
{
    public partial class CTPhieuXuat : Form
    {
        private static DataTable pxuat;
        public delegate void SendMessage(string ctPX);
        public SendMessage Sender;
        public CTPhieuXuat()
        {
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
        }

       
        

        private void Load_CTPX(string ctPX)
        {
            string[] param = { ctPX };
            HoaDon hoadon = new HoaDon();
            pxuat = hoadon.getChiTietHD(param);
            gridControl1.DataSource = pxuat;
            gridControl1.DataMember = pxuat.TableName;

        }
        private void CTPhieuXuat_Load(object sender, EventArgs e)
        {
           
        }
        private void GetMessage(string ctPX)
        {
            lbMaPX.Text = ctPX.ToUpper();
            Load_CTPX(ctPX);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

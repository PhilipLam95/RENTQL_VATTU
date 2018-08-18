using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLYVATTU.MODEL;
using DevExpress.XtraReports.UI;
using QLYVATTU.LIST_ARRAY;

namespace QL_VATTU.VIEW.REPORT_VIEW
{
    public partial class DanhSachVatTu : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachVatTu()
        {
            InitializeComponent();
        }

        private void DanhSachVatTu_Load(object sender, EventArgs e)
        {
            VatTu vt = new VatTu();
            DataTable x = vt.getVatTu();
            gridControl1.DataSource = x;
          

        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            VatTu vt = new VatTu();
            DataTable x = vt.getVatTu();

            REPORT.rptDanhSachVatTu report = new REPORT.rptDanhSachVatTu();
            report.DataSource = x;
            report.DataMember = x.TableName;
            report.ShowPreviewDialog();
        }
    }
}

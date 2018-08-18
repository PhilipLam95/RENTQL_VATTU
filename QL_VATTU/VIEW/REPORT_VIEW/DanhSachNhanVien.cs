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
    public partial class DanhSachNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            foreach (Connection cnn in Access.CnnList)
            {

                cbbChiNhanh.Items.Add(cnn.ChiNhanh);
                if (Access.MACN == cnn.MaCN.ToString())
                {
                    cbbChiNhanh.Text = cnn.ChiNhanh.ToString();
                }

            }

            if (Access.ROLE == "CongTy")
            {
                cbbChiNhanh.Enabled = true;
            }
            else
            {
                cbbChiNhanh.Enabled = false;
            }

        }

        private void btnIn_Click(object sender, EventArgs e)
        {

            Connection cnn = Access.CnnList[cbbChiNhanh.SelectedIndex];
            string maCN = cnn.MaCN;
            string[] param = { maCN };

            Report rpt = new Report();
            DataTable x = rpt.Load_REPORT_DS_NHANVIEN_THEOMA(param);

            REPORT.rptDanhSachNhanVien report = new REPORT.rptDanhSachNhanVien();
            report.DataSource = x;
            report.DataMember = x.TableName;
            report.ShowPreviewDialog();
        }

        private void cbbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connection cnn = Access.CnnList[cbbChiNhanh.SelectedIndex];
            string maCN = cnn.MaCN;
            string[] param = { maCN };

            Report rpt = new Report();
            DataTable x = rpt.Load_REPORT_DS_NHANVIEN_THEOMA(param);
            gridControl1.DataSource = x;
        }
    }
}

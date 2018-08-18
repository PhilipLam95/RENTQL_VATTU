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
    public partial class HoatDongNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public HoatDongNhanVien()
        {
            InitializeComponent();
        }

        List<ListNhanVien> LISTNV = new List<ListNhanVien>();
        private static DataTable nhanvien;

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void HoatDongNhanVien_Load(object sender, EventArgs e)
        {

           foreach (Connection cnn in Access.CnnList)
            {

                comboBox1.Items.Add(cnn.ChiNhanh);
                if (Access.MACN == cnn.MaCN.ToString())
                {
                    comboBox1.Text = cnn.ChiNhanh.ToString();
                }

            }



            if (Access.ROLE == "CongTy")
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }



        }

        


        private void btnPreview_Click(object sender, EventArgs e)
        {

            DateTime DateFrom = this.dtDateFrom.DateTime;
            DateTime DateTo = this.dtDateTo.DateTime;
            String idNV = cbbMaNV.Text.ToString();
            String timeDateFrom = String.Format("{0:yyyy-MM-dd}", DateFrom);
            String timeDateTo = String.Format("{0:yyyy-MM-dd}", DateTo);
            Connection cnn = Access.CnnList[comboBox1.SelectedIndex];
            string maCN = cnn.MaCN;
            string[] param = { idNV, timeDateFrom, timeDateTo, maCN };

            Report rpt = new Report();
            DataTable x = rpt.HoatDongNhanVien(param);

            REPORT.rptHoatDongNhanVien report = new REPORT.rptHoatDongNhanVien();
            report.DataSource = x;
            report.DataMember = x.TableName;
            report.ShowPreviewDialog();

        }

        private void cbbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListNhanVien list in LISTNV)
            {
                for (int i = 0; i < LISTNV.Count; i++)
                {
                    if (cbbMaNV.Text == LISTNV[i].MaNV)
                    {
                        txtTenNV.Text = (LISTNV[i].HOTEN);

                    }
                }


            }
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            Connection cnn = Access.CnnList[comboBox1.SelectedIndex];
            string macn = cnn.MaCN;
            string[] param = { macn };
            NhanVien nv = new NhanVien();
            nhanvien = nv.getNhanVienTheoCN(param);


            foreach (DataRow row in nhanvien.Rows)
            {
                ListNhanVien lnv = new ListNhanVien()
                {
                    MaNV = row["MANV"].ToString(),
                    HOTEN = row["HOTEN"].ToString()

                };
                LISTNV.Add(lnv);
                //cbbMaNV.Items.Add(row["MANV"].ToString();
            }
            //cbbMaNV.Items.Clear();

            //foreach (ListNhanVien lnv in LISTNV.ToList())
            //{

            //    cbbMaNV.Items.Add(lnv.MaNV);

            //}


            cbbMaNV.Items.Clear();
            foreach (DataRow row in nhanvien.Rows)
            {
                cbbMaNV.Items.Add(row["MANV"]);
            }
            cbbMaNV.SelectedIndex = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
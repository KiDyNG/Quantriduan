using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace CNPM
{
    public partial class Xuathoadon : Form
    {
        public Xuathoadon()
        {
            InitializeComponent();
        }

        private void bt_quaylai_Click(object sender, EventArgs e)
        {
            Xuathoadon LapHoaDon = new Xuathoadon();
            this.Hide();
            LapHoaDon.ShowDialog();
        }

        private void bt_xuat_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_tenkhachhang.Text!=""&&txt_ngaylap.Text!="")
                {
                    string connect = "server=" + @"DESKTOP-N66APPQ\MSSQLSERVER01" + ";database=" + "QLCuhangmotor" + ";integrated security=true";
                    SqlConnection con = new SqlConnection(connect);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT MaHoaDon, TenKhachHang, TenXe, HoaDon.SoLuong, NgayLap, Gia, Gia*HoaDon.SoLuong AS 'TongTien' FROM HoaDon, Xe, KhachHang WHERE HoaDon.MaXe = Xe.MaXe AND HoaDon.MaKhachHang = KhachHang.MaKhachHang AND NgayLap ='"+txt_ngaylap.Text+"' AND TenKhachHang = N'"+txt_tenkhachhang.Text+"'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Xuathoadon");
                    if (ds.Tables.Count > 0)
                    {
                        this.reportViewer1.LocalReport.ReportEmbeddedResource = "CNPM.Xuat_HoaDon.rdlc";
                        ReportDataSource rds = new ReportDataSource();
                        rds.Name = "DataSet";
                        rds.Value = ds.Tables["Xuathoadon"];
                        this.reportViewer1.LocalReport.DataSources.Add(rds);
                    }
                    else
                    {
                        MessageBox.Show("Không có hóa đơn cần xuất");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.reportViewer1.RefreshReport();
        }

        private void Xuathoadon_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

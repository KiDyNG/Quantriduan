using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHDT
{
    public partial class Giaodienchinh : Form
    {
        public Giaodienchinh()
        {
            InitializeComponent();
        }

        private void btn_dangxuatgiaodienchinh_Click(object sender, EventArgs e)
        {

        }

        private void btn_qlkh_giaodienchinh_Click(object sender, EventArgs e)
        {
            QLKH QuanLyKhachHang = new QLKH();
            this.Hide();
            QuanLyKhachHang.ShowDialog();
        }

        private void btn_qlx_giaodienchinh_Click(object sender, EventArgs e)
        {
            QLSP QuanLySP = new QLSP();
            this.Hide();
            QuanLySP.ShowDialog();
        }

        private void btn_lhd_giaodienchinh_Click(object sender, EventArgs e)
        {
            Laphoadon HoaDon = new Laphoadon();
            this.Hide();
            HoaDon.ShowDialog();
        }

        private void btn_dangxuat_giaodienchinh_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đăng xuất", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Dangnhap DangNhap = new Dangnhap();
                this.Hide();
                DangNhap.ShowDialog();
            }
        }
    }
}

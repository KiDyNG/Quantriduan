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

namespace PTTKHDT
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string connect = "server=" + @"DESKTOP-N66APPQ\MSSQLSERVER01" + ";database=" + "QLCuahangmotor" + ";integrated security=true";
                SqlConnection con = new SqlConnection(connect);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NguoiDung WHERE taikhoan='" + txt_taikhoan.Text + "' AND matkhau='" + txt_matkhau.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    var admin = dt.Rows[0].Field<string>("admin");
                    if (admin == "n")
                    {
                        MessageBox.Show("Chào mừng nhân viên KiDyNG Motor");
                        Giaodienchinh giaodienchinh = new Giaodienchinh();
                        this.Hide();
                        giaodienchinh.ShowDialog();
                    }
                    if (admin == "y")
                    {
                        MessageBox.Show("Chào mừng quản lý KiDyNG Motor");
                        QLNV QLNV = new QLNV();
                        this.Hide();
                        QLNV.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công! Kiểm tra thông tin đăng nhập");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_thoatdangnhap_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dg == DialogResult.OK)
            {
                Application.Exit();

            }
        }
    }
}

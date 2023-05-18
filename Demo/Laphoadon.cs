using CNPM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTTKHDT
{
    public partial class Laphoadon : Form
    {
        string connect = "server=" + @"DESKTOP-N66APPQ\MSSQLSERVER01" + ";database=" + "QLCuahangmotor" + ";integrated security=true";
        SqlConnection con = new SqlConnection();
        public Laphoadon()
        {
            InitializeComponent();
        }

        public void display_hoadon()
        {
            try
            {
                con.ConnectionString = connect;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM HoaDon", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_laphoadon.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void clear_hoadon()
        {
            txt_mahd.Text = "";
            txt_makh.Text = "";
            txt_maxe.Text = "";
            txt_soluong.Text = "";
            txt_thanhtien.Text = "";
            txt_ngaylap.Text = "";
        }
        private void btn_lammoihd_Click(object sender, EventArgs e)
        {
            clear_hoadon();
        }

        private void btn_taohd_Click(object sender, EventArgs e)
        {
            if (txt_mahd.Text != "" && txt_maxe.Text != "" && txt_makh.Text != "" && txt_thanhtien.Text != "" && txt_soluong.Text != "" && txt_ngaylap.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO HoaDon(MaHoaDon,MaXe,MaKhachHang,SoLuong,ThanhTien,NgayLap) VALUES(@mahoadon,@maxe,@makhachhang,@soluong,@thanhtien,@ngaylap)", con);
                    cmd.Parameters.AddWithValue("@mahoadon", txt_mahd.Text);
                    cmd.Parameters.AddWithValue("@maxe", txt_maxe.Text);
                    cmd.Parameters.AddWithValue("@makhachhang", txt_makh.Text);
                    cmd.Parameters.AddWithValue("@soluong", txt_soluong.Text);
                    cmd.Parameters.AddWithValue("@thanhtien", txt_thanhtien.Text);
                    cmd.Parameters.AddWithValue("@ngaylap", txt_ngaylap.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo hóa đơn thành công!");
                    con.Close();
                    display_hoadon();
                    clear_hoadon();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Không thêm được dữ liệu!");
            }
        }

        private void gv_laphoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows_id = e.RowIndex;
            txt_mahd.Text = gv_laphoadon.Rows[rows_id].Cells[0].Value.ToString().Trim();
            txt_maxe.Text = gv_laphoadon.Rows[rows_id].Cells[1].Value.ToString().Trim();
            txt_makh.Text = gv_laphoadon.Rows[rows_id].Cells[2].Value.ToString().Trim();
            txt_soluong.Text = gv_laphoadon.Rows[rows_id].Cells[4].Value.ToString().Trim();
            txt_thanhtien.Text = gv_laphoadon.Rows[rows_id].Cells[5].Value.ToString().Trim();
            txt_ngaylap.Text = gv_laphoadon.Rows[rows_id].Cells[3].Value.ToString().Trim();
        }

        private void btn_thoatlaphd_Click(object sender, EventArgs e)
        {
            Giaodienchinh giaodienchinh = new Giaodienchinh();
            this.Hide();
            giaodienchinh.ShowDialog();
        }

        private void btn_xuathd_hd_Click(object sender, EventArgs e)
        {
            Laphoadon luathoadon = new Laphoadon();
            this.Hide();
            luathoadon.ShowDialog();
        }


        private void Laphoadon_Load(object sender, EventArgs e)
        {
            display_hoadon();
        }

    }
}

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
    public partial class QLKH : Form
    {
        string connect = "server=" + @"DESKTOP-N66APPQ\MSSQLSERVER01" + ";database=" + "QLCuahangmotor" + ";integrated security=true";
        SqlConnection con = new SqlConnection();
        public QLKH()
        {
            InitializeComponent();
        }

        public void display_khachhang()
        {
            try
            {
                con.ConnectionString = connect;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_qlkh.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_thoatkh_Click(object sender, EventArgs e)
        {
            Giaodienchinh giaodienchinh = new Giaodienchinh();
            this.Hide();
            giaodienchinh.ShowDialog();
        }

        private void QLKH_Load(object sender, EventArgs e)
        {
            display_khachhang();
        }

        public void clear_khachhang()
        {
            txt_makh.Text = "";
            txt_tenkh.Text = "";
            txt_sdtkh.Text = "";
            txt_diachi.Text = "";
            btn_themkh.Enabled = true;
            txt_makh.Enabled = true;
        }

        private void btn_themkh_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text != "" && txt_tenkh.Text != "" && txt_sdtkh.Text != "" && txt_diachi.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO KhachHang(MaKhachHang,TenKhachHang,SDT,DiaChi) VALUES(@makhachhang,@tenkhachhang,@sdtkh,@diachi)", con);
                    cmd.Parameters.AddWithValue("@makhachhang", txt_makh.Text);
                    cmd.Parameters.AddWithValue("@tenkhachhang", txt_tenkh.Text);
                    cmd.Parameters.AddWithValue("@sdtkh", txt_sdtkh.Text);
                    cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành thông tin khách hàng thành công");
                    con.Close();
                    display_khachhang();
                    clear_khachhang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private void gv_qlkh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows_id = e.RowIndex;
            txt_makh.Text = gv_qlkh.Rows[rows_id].Cells[0].Value.ToString().Trim();
            txt_tenkh.Text = gv_qlkh.Rows[rows_id].Cells[1].Value.ToString().Trim();
            txt_sdtkh.Text = gv_qlkh.Rows[rows_id].Cells[2].Value.ToString().Trim();
            txt_diachi.Text = gv_qlkh.Rows[rows_id].Cells[3].Value.ToString().Trim();
            btn_themkh.Enabled = false;
            txt_makh.Enabled = false;
        }

        private void btn_suakh_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text != "" && txt_tenkh.Text != "" && txt_sdtkh.Text != "" && txt_diachi.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE KhachHang SET TenKhachHang=@tenkhachhang,SDT=@sdtkh,DiaChi=@diachi WHERE MaKhachHang=@makhachhang", con);
                    cmd.Parameters.AddWithValue("@makhachhang", txt_makh.Text);
                    cmd.Parameters.AddWithValue("@tenkhachhang", txt_tenkh.Text);
                    cmd.Parameters.AddWithValue("@sdtkh", txt_sdtkh.Text);
                    cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    if (rowsaffected == 1)
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thành công");
                    }
                    con.Close();
                    display_khachhang();
                    clear_khachhang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private void btn_xoakh_Click(object sender, EventArgs e)
        {
            if (txt_makh.Text != "" && txt_tenkh.Text != "" && txt_sdtkh.Text != "" && txt_diachi.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE KhachHang WHERE MaKhachHang=@makhachhang AND TenKhachHang=@tenkhachhang AND SDT=@sdtkh AND DiaChi=@diachi", con);
                    cmd.Parameters.AddWithValue("@makhachhang", txt_makh.Text);
                    cmd.Parameters.AddWithValue("@tenkhachhang", txt_tenkh.Text);
                    cmd.Parameters.AddWithValue("@sdtkh", txt_sdtkh.Text);
                    cmd.Parameters.AddWithValue("@diachi", txt_diachi.Text);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    if (rowsaffected == 1)
                    {
                        MessageBox.Show("Xóa thông tin khách hàng thành công");
                    }
                    con.Close();
                    display_khachhang();
                    clear_khachhang();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private void btn_timkiemkh_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = connect;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM KhachHang WHERE MaKhachHang LIKE '%" + txt_timkiemkh.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_qlkh.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_lammoikh_Click(object sender, EventArgs e)
        {
            clear_khachhang();
        }
    }
}

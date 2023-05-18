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
    public partial class QLNV : Form
    {
        string connect = "server=" + @"DESKTOP-N66APPQ\MSSQLSERVER01" + ";database=" + "QLCuahangmotor" + ";integrated security=true";
        SqlConnection con = new SqlConnection();
        public QLNV()
        {
            InitializeComponent();
        }

        public void display_nhanvien()
        {
            try
            {
                con.ConnectionString = connect;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_qlnv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            display_nhanvien();
        }

        private void txt_lammoinv_Click(object sender, EventArgs e)
        {
            clear_nhanvien();
        }

        public void clear_nhanvien()
        {
            txt_manv.Text = "";
            txt_tennv.Text = "";
            txt_sdtnv.Text = "";
            txt_diachinv.Text = "";
            txt_luong.Text = "";
        }

        private void gv_qlnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows_id = e.RowIndex;
            txt_manv.Text = gv_qlnv.Rows[rows_id].Cells[0].Value.ToString().Trim();
            txt_tennv.Text = gv_qlnv.Rows[rows_id].Cells[1].Value.ToString().Trim();
            txt_sdtnv.Text = gv_qlnv.Rows[rows_id].Cells[2].Value.ToString().Trim();
            txt_diachinv.Text = gv_qlnv.Rows[rows_id].Cells[3].Value.ToString().Trim();
            txt_luong.Text = gv_qlnv.Rows[rows_id].Cells[4].Value.ToString().Trim();
        }

        private void btn_timkiemnv_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = connect;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM NhanVien WHERE MaNhanVien LIKE '%" + txt_manv.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_qlnv.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_themnv_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text != "" && txt_tennv.Text != "" && txt_sdtnv.Text != "" && txt_diachinv.Text != "" && txt_luong.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO NhanVien(MaNhanVien,TenNhanVien,SDT,DiaChi,Luong) VALUES(@manhanvien,@tennhanvien,@sdtnv,@diachi,@luong)", con);
                    cmd.Parameters.AddWithValue("@manhanvien", txt_manv.Text);
                    cmd.Parameters.AddWithValue("@tennhanvien", txt_tennv.Text);
                    cmd.Parameters.AddWithValue("@sdtnv", txt_sdtnv.Text);
                    cmd.Parameters.AddWithValue("@diachi", txt_diachinv.Text);
                    cmd.Parameters.AddWithValue("@luong", txt_luong.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành thông tin nhân viên thành công");
                    con.Close();
                    display_nhanvien();
                    clear_nhanvien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private void btn_suanv_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text != "" && txt_tennv.Text != "" && txt_sdtnv.Text != "" && txt_diachinv.Text != "" && txt_luong.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE NhanVien SET TenNhanVien=@tennhanvien,SDT=@sdtnv,DiaChi=@diachi,Luong=@luong WHERE MaNhanVien=@manhanvien", con);
                    cmd.Parameters.AddWithValue("@manhanvien", txt_manv.Text);
                    cmd.Parameters.AddWithValue("@tennhanvien", txt_tennv.Text);
                    cmd.Parameters.AddWithValue("@sdtnv", txt_sdtnv.Text);
                    cmd.Parameters.AddWithValue("@diachi", txt_diachinv.Text);
                    cmd.Parameters.AddWithValue("@luong", txt_luong.Text);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    if (rowsaffected == 1)
                    {
                        MessageBox.Show("Sửa thông tin nhân viên thành công");
                    }
                    con.Close();
                    display_nhanvien();
                    clear_nhanvien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private void btn_xoanv_Click(object sender, EventArgs e)
        {
            if (txt_manv.Text != "" && txt_tennv.Text != "" && txt_sdtnv.Text != "" && txt_diachinv.Text != "") if (txt_manv.Text != "" && txt_tennv.Text != "" && txt_sdtnv.Text != "" && txt_diachinv.Text != "" && txt_luong.Text != "")
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("DELETE NhanVien WHERE MaNhanVien=@manhanvien AND TenNhanVien=@tennhanvien AND SDT=@sdtnv AND DiaChi=@diachi AND Luong=@luong", con);
                        cmd.Parameters.AddWithValue("@manhanvien", txt_manv.Text);
                        cmd.Parameters.AddWithValue("@tennhanvien", txt_tennv.Text);
                        cmd.Parameters.AddWithValue("@sdtnv", txt_sdtnv.Text);
                        cmd.Parameters.AddWithValue("@diachi", txt_diachinv.Text);
                        cmd.Parameters.AddWithValue("@luong", txt_luong.Text);
                        int rowsaffected = cmd.ExecuteNonQuery();
                        if (rowsaffected == 1)
                        {
                            MessageBox.Show("Xóa thông tin nhân viên thành công");
                        }
                        con.Close();
                        display_nhanvien();
                        clear_nhanvien();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        con.Close();
                    }
                }
        }

        private void btn_thoatnv_Click(object sender, EventArgs e)
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

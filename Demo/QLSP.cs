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
    public partial class QLSP : Form
    {
        string connect = "server=" + @"DESKTOP-N66APPQ\MSSQLSERVER01" + ";database=" + "QLCuahangmotor" + ";integrated security=true";
        SqlConnection con = new SqlConnection();
        public QLSP()
        {
            InitializeComponent();
        }

        public void display_xe()
        {
            try
            {
                con.ConnectionString = connect;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Xe", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_xe.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void clear_xe()
        {
            txt_maxe.Text = "";
            txt_tenxe.Text = "";
            txt_loai.Text = "";
            txt_soluong.Text = "";
            txt_gia.Text = "";
        }

        private void txt_thoatxe_Click(object sender, EventArgs e)
        {
            Giaodienchinh Giaodienchinh = new Giaodienchinh();
            this.Hide();
            Giaodienchinh.ShowDialog();
        }

        private void btn_themxe_Click(object sender, EventArgs e)
        {
            if (txt_maxe.Text != "" && txt_tenxe.Text != "" && txt_loai.Text != "" && txt_soluong.Text != "" && txt_gia.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Xe(MaXe,TenXe,Loai,SoLuong,Gia) VALUES(@maxe,@tenxe,@loai,@soluong,@gia)", con);
                    cmd.Parameters.AddWithValue("@maxe", txt_maxe.Text);
                    cmd.Parameters.AddWithValue("@tenxe", txt_tenxe.Text);
                    cmd.Parameters.AddWithValue("@loai", txt_loai.Text);
                    cmd.Parameters.AddWithValue("@soluong", txt_soluong.Text);
                    cmd.Parameters.AddWithValue("@gia", txt_gia.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành thông tin xe thành công");
                    con.Close();
                    display_xe();
                    clear_xe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private void txt_suaxe_Click(object sender, EventArgs e)
        {
            if (txt_maxe.Text != "" && txt_tenxe.Text != "" && txt_loai.Text != "" && txt_soluong.Text != "" && txt_gia.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Xe SET TenXe=@tenxe,Loai=@loai,SoLuong=@soluong,Gia=@gia WHERE MaXe=@maxe", con);
                    cmd.Parameters.AddWithValue("@maxe", txt_maxe.Text);
                    cmd.Parameters.AddWithValue("@tenxe", txt_tenxe.Text);
                    cmd.Parameters.AddWithValue("@loai", txt_loai.Text);
                    cmd.Parameters.AddWithValue("@soluong", txt_soluong.Text);
                    cmd.Parameters.AddWithValue("@gia", txt_gia.Text);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    if (rowsaffected == 1)
                    {
                        MessageBox.Show("Sửa thông tin xe thành công");
                    }
                    con.Close();
                    display_xe();
                    clear_xe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private void QLSP_Load(object sender, EventArgs e)
        {
            display_xe();
        }

        private void txt_lamoixe_Click(object sender, EventArgs e)
        {
            clear_xe();
        }

        private void txt_xoaxe_Click(object sender, EventArgs e)
        {
            if (txt_maxe.Text != "" && txt_tenxe.Text != "" && txt_loai.Text != "" && txt_soluong.Text != "" && txt_gia.Text != "")
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE Xe WHERE MaXe=@maxe AND TenXe=@tenxe AND Loai=@loai AND SoLuong=@soluong AND Gia=@gia", con);
                    cmd.Parameters.AddWithValue("@maxe", txt_maxe.Text);
                    cmd.Parameters.AddWithValue("@tenxe", txt_tenxe.Text);
                    cmd.Parameters.AddWithValue("@loai", txt_loai.Text);
                    cmd.Parameters.AddWithValue("@soluong", txt_soluong.Text);
                    cmd.Parameters.AddWithValue("@gia", txt_gia.Text);
                    int rowsaffected = cmd.ExecuteNonQuery();
                    if (rowsaffected == 1)
                    {
                        MessageBox.Show("Xóa thông tin xe thành công");
                    }
                    con.Close();
                    display_xe();
                    clear_xe();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    con.Close();
                }
            }
        }

        private void btn_timkiemxe_Click(object sender, EventArgs e)
        {
            try
            {
                con.ConnectionString = connect;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Xe WHERE MaXe LIKE '%" + txt_timkiemxe.Text + "%'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gv_xe.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gv_xe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows_id = e.RowIndex;
            txt_maxe.Text = gv_xe.Rows[rows_id].Cells[0].Value.ToString().Trim();
            txt_tenxe.Text = gv_xe.Rows[rows_id].Cells[1].Value.ToString().Trim();
            txt_loai.Text = gv_xe.Rows[rows_id].Cells[2].Value.ToString().Trim();
            txt_soluong.Text = gv_xe.Rows[rows_id].Cells[3].Value.ToString().Trim();
            txt_gia.Text = gv_xe.Rows[rows_id].Cells[4].Value.ToString().Trim();
        }
    }
}

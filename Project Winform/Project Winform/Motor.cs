using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Project_Winform
{
    public partial class Motor : Form
    {
        public Motor()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from motor where id_motor=@id",con);
                cmd.Parameters.AddWithValue("@id", txt_search.Text);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txt_id.Text = dr.GetValue(0).ToString();
                    txt_nama.Text = dr.GetValue(1).ToString();
                    txt_merk.Text = dr.GetValue(2).ToString();
                    txt_cc.Text = dr.GetValue(3).ToString();
                    txt_plat.Text = dr.GetValue(4).ToString();
                    txt_harga.Text = dr.GetValue(5).ToString();
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from motor", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    data_motor.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Tidak Ada Data");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into motor(id_motor, nama_motor, merk, cc, plat, harga) values(@id,@nama,@merk,@cc,@plat,@harga)", con);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@nama", txt_nama.Text);
                cmd.Parameters.AddWithValue("@merk", txt_merk.Text);
                cmd.Parameters.AddWithValue("@cc", txt_cc.Text);
                cmd.Parameters.AddWithValue("@plat", txt_plat.Text);
                cmd.Parameters.AddWithValue("@harga", int.Parse(txt_harga.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Ditambahkan", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_id.Clear();
                txt_nama.Clear();
                txt_merk.Clear();
                txt_cc.Clear();
                txt_plat.Clear();
                txt_harga.Clear();
                cmd = new NpgsqlCommand("select * from motor", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    data_motor.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Tidak Ada Data");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("update motor set id_motor=@id, nama_motor=@nama, merk=@merk, cc=@cc, plat=@plat, harga=@harga where id_motor=@search", con);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@nama", txt_nama.Text);
                cmd.Parameters.AddWithValue("@merk", txt_merk.Text);
                cmd.Parameters.AddWithValue("@cc", txt_cc.Text);
                cmd.Parameters.AddWithValue("@plat", txt_plat.Text);
                cmd.Parameters.AddWithValue("@harga", int.Parse(txt_harga.Text));
                cmd.Parameters.AddWithValue("@search", txt_search.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Di Update", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd = new NpgsqlCommand("select * from motor", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    data_motor.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Tidak Ada Data");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from motor where id_motor=@id", con);
                cmd.Parameters.AddWithValue("@id", txt_search.Text);
                cmd.ExecuteNonQuery();        
                MessageBox.Show("Data Berhasil Di Hapus", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd = new NpgsqlCommand("select * from motor", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    data_motor.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Tidak Ada Data");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_id.Clear();
            txt_nama.Clear();
            txt_merk.Clear();
            txt_cc.Clear();
            txt_plat.Clear();
            txt_harga.Clear();
        }

        private void orders_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Dispose();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

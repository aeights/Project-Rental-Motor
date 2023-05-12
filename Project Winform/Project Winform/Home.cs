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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

        private void rent_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select harga from motor where id_motor=@id", con);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                int harga = int.Parse(dr.GetValue(0).ToString());
                int total = harga * int.Parse(txt_day.Text);
                con.Close();
                con.Open();
                cmd = new NpgsqlCommand("insert into orders(username, id_motor, hari, total) values(@uname, @id, @day, @total)", con);
                cmd.Parameters.AddWithValue("@uname", txt_username.Text);
                cmd.Parameters.AddWithValue("@id", txt_id.Text);
                cmd.Parameters.AddWithValue("@day", int.Parse(txt_day.Text));
                cmd.Parameters.AddWithValue("@total", total);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Berhasil, Silahkan Cek Di Menu Transaksi", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                txt_username.Clear();
                txt_id.Clear();
                txt_day.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
            }
        }

        private void transaksi_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from orders where username=@uname", con);
                cmd.Parameters.AddWithValue("@uname", txt_username.Text);
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

        private void logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

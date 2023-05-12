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
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void cek_orders_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select * from orders", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    data_orders.DataSource = dt;
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

        private void cancel_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("delete from orders where order_id=@id", con);
                cmd.Parameters.AddWithValue("@id", int.Parse(txt_id.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Berhasil Dibatalkan", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd = new NpgsqlCommand("select * from orders", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    data_orders.DataSource = dt;
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

        private void back_Click(object sender, EventArgs e)
        {
            Motor motor = new Motor();
            motor.Show();
            this.Dispose();
        }
    }
}

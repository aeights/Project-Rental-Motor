using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace Project_Winform
{
    public partial class Daftar_user : Form
    {
        public Daftar_user()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_name.Clear();
        }

        private void daftar_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Select * from akun_user where username= '" + txt_username.Text + "'", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Username telah digunakan");
                }
                else
                {
                    con.Close();
                    con.Open();
                    cmd = new NpgsqlCommand("insert into akun_user(username, password, nama) values(@uname,@pass,@name)", con);
                    cmd.Parameters.AddWithValue("@uname", txt_username.Text);
                    cmd.Parameters.AddWithValue("@pass", txt_password.Text);
                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    dr.Close();
                    MessageBox.Show("Akun anda berhasil dibuat, Silahkan login", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login_User user = new Login_User();
                    this.Dispose();
                    user.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Dispose();
            }
        }
    }
}

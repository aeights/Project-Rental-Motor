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
using System.Configuration;

namespace Project_Winform
{
    public partial class Login_User : Form
    {
        public Login_User()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            try
            {
                bool status = false;

                NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=Dragonmania;Database=rentalmotor;");
                con.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("Select * from akun_user where username= '" + txt_username.Text + "' and password = '" + txt_password.Text + "'", con);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    status = true;
                    Home home = new Home();
                    this.Dispose();
                    home.Show();
                    MessageBox.Show("Login Berhasil");
                }
                else if (status == false)
                {
                    MessageBox.Show("Username atau Password Anda Salah ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                con.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
        }

        private void lbl_daftar_Click(object sender, EventArgs e)
        {
            Daftar_user daftar = new Daftar_user();
            daftar.Show();
            this.Hide();
        }
    }
}

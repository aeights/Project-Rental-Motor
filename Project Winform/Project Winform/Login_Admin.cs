using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Winform
{
    public partial class Login_Admin : Form
    {
        public Login_Admin()
        {
            InitializeComponent();
            this.ActiveControl = txt_username;
        }

        private void login_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_username.Text=="admin" & txt_password.Text == "123")
                {
                    Motor admin = new Motor();
                    this.Dispose();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Username atau Password anda salah");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

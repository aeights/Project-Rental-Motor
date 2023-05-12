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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void txt_user_Click(object sender, EventArgs e)
        {
            Login_User user = new Login_User();
            user.Show();
            this.Hide();
        }

        private void txt_admin_Click(object sender, EventArgs e)
        {
            Login_Admin admin = new Login_Admin();
            admin.Show();
            this.Hide();
        }
    }
}

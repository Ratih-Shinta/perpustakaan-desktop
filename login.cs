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

namespace perpustakaan
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9B6EH00T;Initial Catalog=loginApp;Integrated Security=True");

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-9B6EH00T;Initial Catalog=loginApp;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM loginApp WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", txtusername.Text);
            cmd.Parameters.AddWithValue("@password", txtpassword.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error Login");
            }
            dashboard dashboard = new dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void llregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register registerForm = new register();
            registerForm.Show();
            this.Hide();
        }
    }
}

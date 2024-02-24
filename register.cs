using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace perpustakaan
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            string conn = "Data Source=LAPTOP-9B6EH00T;Initial Catalog=loginApp;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(conn))
            {
                try
                {
                    con.Open();

                    string query = "INSERT INTO loginApp (username, password) VALUES (@username, @password)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", txtusername.Text);
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Registration failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            login login = new login();
            login.Show();
            this.Hide();

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lllogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login loginForm = new login();
            loginForm.Show();
            this.Hide();
        }
    }
}
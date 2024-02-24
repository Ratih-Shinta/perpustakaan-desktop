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
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-9B6EH00T;Initial Catalog=perpustakaan;Integrated Security=True");

        private void bind_data()
        {
            SqlCommand cmd = new SqlCommand("Select id, judul As judul, penulis As penulis, genre As genre, penerbit As penerbit, ketersediaan As ketersediaan, favorite from perpustakaan", conn);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahona", 11, FontStyle.Bold);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string genre = string.Empty;
            if (cbFiksi.Checked == true)
            {
                genre = cbFiksi.Text;
            }
            if (cbNonfiksi.Checked == true)
            {
                genre = cbNonfiksi.Text;
            }

            string favorite = string.Empty;
            if (rbFavorite.Checked == true)
            {
                favorite = rbFavorite.Text;
            }

            string ketersediaan = cbKetersediaan.SelectedItem.ToString();

            SqlCommand cmd2 = new SqlCommand("INSERT INTO perpustakaan(id,judul,penulis,genre,penerbit,ketersediaan,favorite)Values(@id,@judul,@penulis,@genre,@penerbit,@ketersediaan,@favorite)", conn);
            cmd2.Parameters.AddWithValue("id", txtID.Text);
            cmd2.Parameters.AddWithValue("judul", txtJudul.Text);
            cmd2.Parameters.AddWithValue("penulis", txtPenulis.Text);
            cmd2.Parameters.AddWithValue("genre", genre);
            cmd2.Parameters.AddWithValue("penerbit", txtPenerbit.Text);
            cmd2.Parameters.AddWithValue("ketersediaan", ketersediaan);
            cmd2.Parameters.AddWithValue("favorite", favorite);
            conn.Open();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedrow = dataGridView1.Rows[index];
            txtID.Text = selectedrow.Cells[0].Value.ToString();
            txtJudul.Text = selectedrow.Cells[1].Value.ToString();
            txtPenulis.Text = selectedrow.Cells[2].Value.ToString();

            string genres = selectedrow.Cells[3].Value.ToString();
            cbNonfiksi.Checked = genres.Contains("NonFiksi");
            cbFiksi.Checked = genres.Contains("Fiksi");

            txtPenerbit.Text = selectedrow.Cells[4].Value.ToString();
            cbKetersediaan.Text = selectedrow.Cells[5].Value.ToString();
            rbFavorite.Text = selectedrow.Cells[6].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd4 = new SqlCommand("Delete from perpustakaan where id=@id", conn);
            cmd4.Parameters.AddWithValue("id", txtID.Text);
            conn.Open();
            cmd4.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string genre = string.Empty;
            if (cbFiksi.Checked == true)
            {
                genre = cbFiksi.Text;
            }
            if (cbNonfiksi.Checked == true)
            {
                genre = cbNonfiksi.Text;
            }

            SqlCommand cmd3 = new SqlCommand("Update perpustakaan Set judul=@judul, penulis=@enulis, genre=@genre penerbit=@penerbit, ketersediaan=@ketersediaan, favorite=@favorite where id=@id", conn);

            cmd3.Parameters.AddWithValue("id", txtID.Text);
            cmd3.Parameters.AddWithValue("judul", txtJudul.Text);
            cmd3.Parameters.AddWithValue("penulis", txtPenulis.Text);
            cmd3.Parameters.AddWithValue("genre", genre);
            cmd3.Parameters.AddWithValue("penerbit", txtPenerbit.Text);
            cmd3.Parameters.AddWithValue("ketersediaan", cbKetersediaan);
            cmd3.Parameters.AddWithValue("favorite", rbFavorite);
            conn.Open();
            cmd3.ExecuteNonQuery();
            conn.Close();
            bind_data();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Select id, judul As judul, penulis As penulis, genre As genre, penerbit As penerbit, ketersediaan As ketersediaan, favorite from perpustakaan where judul Like @judul+'%'", conn);

            sqlCommand.Parameters.AddWithValue("judul", txtSearch.Text);

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = sqlCommand;

            DataTable dataTable = new DataTable();
            dataTable.Clear();
            dataAdapter.Fill(dataTable);

            dataGridView1.DataSource = dataTable;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 12, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.Font = new Font("Arial", 12);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtJudul.Clear();
            txtPenulis.Clear();
            cbFiksi.Checked = false;
            cbNonfiksi.Checked = false;
            txtPenerbit.Clear();
            cbKetersediaan.SelectedIndex = -1;
            rbFavorite.Checked = false;
        }
    }
}

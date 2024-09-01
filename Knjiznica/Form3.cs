using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class Form3 : Form
    {
        string path = "popis_knjiga.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\popis_knjiga.db";

        public Form3()
        {
            InitializeComponent();
        }

        private void data_show()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Naziv";
                dataGridView1.Columns[1].Name = "Autor";
                dataGridView1.Columns[2].Name = "ID knjige";
            }

            dataGridView1.Rows.Clear();

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string stm = "SELECT * FROM test";
                using (var cmd = new SQLiteCommand(stm, con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            dataGridView1.Rows.Add(dr.GetString(0), dr.GetString(1), dr.GetString(2));
                        }
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
            }

            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                string sql = "CREATE TABLE IF NOT EXISTS test (" +
                             "book_name VARCHAR(20), " +
                             "book_author VARCHAR(30), " +
                             "book_id VARCHAR(12))";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var cmd = new SQLiteCommand(con);

                try
                {
                    cmd.CommandText = "INSERT INTO test (book_name, book_author, book_id) values(@book_name, @book_author, @book_id)";
                    cmd.Parameters.AddWithValue("@book_name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@book_author", textBox2.Text);
                    cmd.Parameters.AddWithValue("@book_id", textBox3.Text);

                    cmd.ExecuteNonQuery();

                    string[] row = new string[] { textBox1.Text, textBox2.Text, textBox3.Text};
                    dataGridView1.Rows.Add(row);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Podaci se ne mogu dodati: " + ex.Message);
                }
            }
        }

        private void azuriraj_knjigu_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var cmd = new SQLiteCommand(con);

                try
                {
                    cmd.CommandText = "UPDATE test SET book_author=@book_author, book_id=@book_id WHERE book_name=@book_name";
                    cmd.Parameters.AddWithValue("@book_name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@book_author", textBox2.Text);
                    cmd.Parameters.AddWithValue("@book_id", textBox3.Text);

                    cmd.ExecuteNonQuery();

                    dataGridView1.Rows.Clear();
                    data_show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Podaci se ne mogu ažurirati: " + ex.Message);
                }
            }
        }

        private void obrisi_knjigu_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var cmd = new SQLiteCommand(con);

                try
                {
                    cmd.CommandText = "DELETE FROM test WHERE book_name=@book_name";
                    cmd.Parameters.AddWithValue("@book_name", textBox1.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Knjiga uspješno obrisana!");
                        dataGridView1.Rows.Clear();
                        data_show();
                    }
                    else
                    {
                        MessageBox.Show("Nema knjige s tim nazivom.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Podaci se ne mogu obrisati: " + ex.Message);
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["book_name"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["book_author"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["book_id"].FormattedValue.ToString();

            }
        }
    }
}

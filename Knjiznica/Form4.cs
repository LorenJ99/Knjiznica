using System;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Knjiznica
{
    public partial class Form4 : Form
    {
        string path = "popis_clanova.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\popis_clanova.db";
        public Form4()
        {
            InitializeComponent();
        }

        private void data_show()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Ime";
                dataGridView1.Columns[1].Name = "Prezime";
                dataGridView1.Columns[2].Name = "ID člana";
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
                             "member_name VARCHAR(20), " +
                             "member_surname VARCHAR(30), " +
                             "member_id VARCHAR(12))";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void dodavanje_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var cmd = new SQLiteCommand(con);

                try
                {
                    cmd.CommandText = "INSERT INTO test (member_name, member_surname, member_id) values(@member_name, @member_surname, @member_id)";
                    cmd.Parameters.AddWithValue("@member_name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@member_surname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@member_id", textBox3.Text);
                    cmd.ExecuteNonQuery();

                    string[] row = new string[] { textBox1.Text, textBox2.Text, textBox3.Text};
                    dataGridView1.Rows.Add(row);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot insert data: " + ex.Message);
                }
            }
        }

        private void azuriranje_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var cmd = new SQLiteCommand(con);

                try
                {
                    cmd.CommandText = "UPDATE test SET member_name=@member_name, member_surname=@member_surname, member_id=@member_id WHERE member_name=@member_name";
                    cmd.Parameters.AddWithValue("@member_name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@member_surname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@member_id", textBox3.Text);

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

        private void brisanje_Click(object sender, EventArgs e)
        {
            using (var con = new SQLiteConnection(cs))
            {
                con.Open();
                var cmd = new SQLiteCommand(con);

                try
                {
                    cmd.CommandText = "DELETE FROM test WHERE member_name=@member_name";
                    cmd.Parameters.AddWithValue("@member_name", textBox1.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Član uspješno obrisan!");
                        dataGridView1.Rows.Clear();
                        data_show();
                    }
                    else
                    {
                        MessageBox.Show("Nema člana s tim nazivom.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Podaci se ne mogu obrisati: " + ex.Message);
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Create_db();
            data_show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridView1.CurrentRow.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["member_name"].FormattedValue.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["member_surname"].FormattedValue.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["member_id"].FormattedValue.ToString();

            }
        }

    }
}

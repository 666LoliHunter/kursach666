using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursach666
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            load_data();
        }

        private OleDbConnection OpenConnectionMain()
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=megaultralast.mdb";
            OleDbConnection conn = new OleDbConnection(connectionString);
            conn.Open();

            return conn;
        }

        private void CloseConnectionMain(OleDbConnection conn, OleDbDataReader reader)
        {
            reader.Close();
            conn.Close();
        }

        private void load_data()
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=megaultralast.mdb";
            OleDbConnection conn = new OleDbConnection(connectionString);

            conn.Open();
            string query = "SELECT * FROM printers";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows == false)
            {
                MessageBox.Show("Данных нет!", "Ошибка");
            }
            else
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["id"], reader["prod"], reader["type"],
                        reader["model"], reader["price"]);
                }
            }

            reader.Close();
            conn.Close();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////
            OleDbConnection conn = OpenConnectionMain();
            ///////////////////////////////////////////////////

            string query = textBox1.Text;

            OleDbCommand svo = new OleDbCommand(query, conn);
            OleDbDataReader reader = svo.ExecuteReader();

            if (reader.HasRows == false)
            {
                MessageBox.Show("Данных нет!", "Ошибка");
            }
            else
            {
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["id"], reader["prod"], reader["type"],
                        reader["model"], reader["price"]);
                }
            }

            ///////////////////////////////////////////////////
            CloseConnectionMain(conn, reader);
            ///////////////////////////////////////////////////
        }


    }
}

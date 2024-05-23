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
        public string subQueryProd = "";
        public string subQueryType = "";
        public string subQueryOrderPrice = "";
        public string subQueryPriceFilter = "";
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

        private void load_data(string more_query="")
        {
            string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=megaultralast.mdb";
            OleDbConnection conn = new OleDbConnection(connectionString);

            conn.Open();
            string query = "SELECT * FROM printers" + more_query;
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
                    dGVTable.Rows.Add(reader["id"], reader["prod"], reader["type"],
                        reader["model"], reader["price"]);
                }
            }

            reader.Close();
            conn.Close();
        }

        private void GenerateQuery()
        {
            string done_query = "select * from printers ";
            List<string> lensQuery = new List<string>() { subQueryProd, subQueryType, subQueryPriceFilter };
            List<string> goodQuery = new List<string>();

            for (int i = 0; i < lensQuery.Count; i++)
            {
                if (lensQuery[i].Length > 0)
                {
                    goodQuery.Add(lensQuery[i]);
                }
            }


            if (goodQuery.Count > 0 || subQueryPriceFilter.Length > 0)
            {
                
                if (goodQuery.Count > 0)
                {

                    done_query += "where ";

                    for(int i = 0; i < goodQuery.Count; i++) 
                    { 
                        if (i != goodQuery.Count - 1)
                        {
                            done_query += goodQuery[i] + " and ";
                        }
                        else
                        {
                            done_query += goodQuery[i] + " ";
                        }
                    }
                }

                done_query += subQueryOrderPrice;
                
            }
            else
            {
                done_query = "select * from printers";
            }

            tBoxSQL.Text = done_query;
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            ///////////////////////////////////////////////////
            OleDbConnection conn = OpenConnectionMain();
            ///////////////////////////////////////////////////

            string query = tBoxSQL.Text;

            OleDbCommand svo = new OleDbCommand(query, conn);
            try
            {
                OleDbDataReader reader = svo.ExecuteReader();

                if (reader.HasRows == false && reader.RecordsAffected == 0)
                {
                    MessageBox.Show("Данных нет!", "Ошибка");
                }
                else if (reader.RecordsAffected > 0)
                {
                    dGVTable.Rows.Clear();

                    ///////////////////////////////////////////////////
                    CloseConnectionMain(conn, reader);
                    ///////////////////////////////////////////////////

                    load_data();
                }
                else
                {
                    dGVTable.Rows.Clear();
                    while (reader.Read())
                    {
                        dGVTable.Rows.Add(reader["id"], reader["prod"], reader["type"],
                            reader["model"], reader["price"]);
                    }

                    ///////////////////////////////////////////////////
                    CloseConnectionMain(conn, reader);
                    ///////////////////////////////////////////////////
                }
            }
            catch
            {
                MessageBox.Show("Ошибка в синтаксисе SQL запроса! Отредактируйте запрос " +
                    "и повторите попытку", "Ошибка");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rBOrderPriceDown_CheckedChanged(object sender, EventArgs e)
        {
            string query = "order by price asc";

            subQueryOrderPrice = query;

            GenerateQuery();
        }

        private void rBOrderPriceHigh_CheckedChanged(object sender, EventArgs e)
        {
            string query = "order by price desc";

            subQueryOrderPrice = query;

            GenerateQuery();
        }

        private void lBProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "";

            ListBox.SelectedObjectCollection checkedProdUser = lBProd.SelectedItems;

            for (int i = 0; i < checkedProdUser.Count; i++)
            {
                if (i == checkedProdUser.Count - 1)
                {
                    query = query + $"prod=\"{checkedProdUser[i].ToString()}\"";
                }
                else
                {
                    query = query + $"prod=\"{checkedProdUser[i].ToString()}\" or ";
                }
            }

            subQueryProd = query;

            GenerateQuery();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "";

            ListBox.SelectedObjectCollection checkedTypeUser = lBType.SelectedItems;

            for (int i = 0; i < checkedTypeUser.Count; i++)
            {
                if (i == checkedTypeUser.Count - 1)
                {
                    query = query + $"type=\"{checkedTypeUser[i].ToString()}\"";
                }
                else
                {
                    query = query + $"type=\"{checkedTypeUser[i].ToString()}\" or ";
                }
            }

            subQueryType = query;

            GenerateQuery();
        }

        private void tBoxPriceFilter_TextChanged(object sender, EventArgs e)
        {
            string query = $"price < {tBoxPriceFilter.Text}";

            subQueryPriceFilter = query;

            GenerateQuery();
        }

        private void btnClearSQL_Click(object sender, EventArgs e)
        {
            subQueryPriceFilter = "";
            subQueryOrderPrice = "";
            subQueryProd = "";
            subQueryType = "";

            GenerateQuery();
        }
    }
}

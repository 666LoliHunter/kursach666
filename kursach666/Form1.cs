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
    public partial class FormApp : Form
    {
        public string subQueryProd = "";
        public string subQueryType = "";
        public string subQueryOrderPrice = "";
        public string subQueryPriceFilter = "";
        public FormApp()
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
            string query = "";
            conn.Open();

            if (more_query == "")
            {
                query = "SELECT * FROM printers";
            }
            else
            {
                query = more_query;
            }

            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            
            dGVTable.Rows.Clear();

            if (reader.HasRows == false)
            {
                MessageBox.Show("Данных нет!", "Ошибка");

                subQueryOrderPrice = "";
                subQueryPriceFilter = "";
                subQueryProd = "";
                subQueryType = "";

                lBProd.ClearSelected();
                lBType.ClearSelected();
                rBOrderPriceDown.Checked = false;
                rBOrderPriceHigh.Checked = false;
                tBoxPriceFilter.Text = "";

                load_data();
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

            load_data(done_query);

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

        private void btnClearSQL_Click(object sender, EventArgs e)
        {
            subQueryPriceFilter = "";
            subQueryOrderPrice = "";
            subQueryProd = "";
            subQueryType = "";

            GenerateQuery();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string query = "";

            if (tBoxPriceFilter.Text.Length > 0)
            {
                query = $"price < {tBoxPriceFilter.Text}";
            }
            else
            {
                query = "";
            }

            subQueryPriceFilter = query;

            GenerateQuery();

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            subQueryOrderPrice = "";
            subQueryPriceFilter = "";
            subQueryProd = "";
            subQueryType = "";

            lBProd.ClearSelected();
            lBType.ClearSelected();
            rBOrderPriceDown.Checked = false;
            rBOrderPriceHigh.Checked = false;
            tBoxPriceFilter.Text = "";

            load_data();
        }

        private void btnSendQuery_Click(object sender, EventArgs e)
        {
            GenerateQuery();
        }
    }
}

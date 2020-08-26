using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;

namespace InventoryManagementSystem
{
    public partial class Search : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=InventoryManagementSystem.db; Version=3; New=False; Compress=True;");
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            fillcombobox();
        }
        public void openConnection()
        {
            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

        }

        public void closeConnection()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
            }
        }
        public void fillcombobox()
        {
            string sql = "SELECT * FROM Items";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader myreader;
            try
            {
                openConnection();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string sname = myreader.GetString(2);
                    cmbItemName.Items.Add(sname);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openConnection();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select * From Items Where ItemName='" + cmbItemName.SelectedItem + "'", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            sda.SelectCommand.ExecuteNonQuery();
            closeConnection();
        }

    }
}

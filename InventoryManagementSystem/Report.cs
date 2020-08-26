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
    public partial class Report : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=InventoryManagementSystem.db; Version=3; New=False; Compress=True;");
        private List<DataGridView> shoppingcart = new List<DataGridView>();
        //private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            fillDatagridView();
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
        public void fillDatagridView()
        {
            openConnection();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select * From Report", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            sda.SelectCommand.ExecuteNonQuery();
            closeConnection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openConnection();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select * From Report Where Date='" + dateTimePicker1.Text + "'", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            sda.SelectCommand.ExecuteNonQuery();
            closeConnection();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                int yPos = 320;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[0].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(24, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[1].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(100, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[2].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(200, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[3].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(300, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[4].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(400, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[5].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(500, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[6].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(600, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[7].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(700, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[8].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(800, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[9].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(900, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[10].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(1000, yPos));
                    e.Graphics.DrawString(dataGridView1.Rows[i].Cells[11].Value.ToString(), new System.Drawing.Font("TIMES NEW ROMAN", 14, FontStyle.Bold), Brushes.Black, new Point(1100, yPos));
                    yPos += 40;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
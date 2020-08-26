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
    public partial class Warehouse : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=InventoryManagementSystem.db; Version=3; New=False; Compress=True;");

        public Warehouse()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtItemNo.Clear();
            txtItemName.Clear();
            txtItemSize.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtSearch.Clear();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString();
            fillDatagridView();
            txtItemNo.Focus();
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
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select * From Items", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            sda.SelectCommand.ExecuteNonQuery();
            closeConnection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtItemNo.Text == "")
            {
                MessageBox.Show("Item No Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            else if (txtItemName.Text == "")
            {
                MessageBox.Show("Item Name Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtItemSize.Text == "")
            {
                MessageBox.Show("Item Size Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Price Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Item Quantity Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    openConnection();
                    SQLiteCommand sda = new SQLiteCommand("INSERT INTO Items(ItemNo, ItemName, ItemSize, Price, Quantity, Date) VALUES('" + txtItemNo.Text.Trim() + "', '" + txtItemName.Text.Trim() + "', '" + txtItemSize.Text.Trim() + "', '" + txtPrice.Text.Trim() + "', '" + txtQuantity.Text.Trim()+ "', '" + txtDate.Text.Trim() + "')", con);
                    sda.ExecuteNonQuery();
                    MessageBox.Show("Item Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    closeConnection();

                    txtItemNo.Clear();
                    txtItemName.Clear();
                    txtPrice.Clear();
                    txtItemSize.Clear();
                    txtQuantity.Clear();
                    fillDatagridView();

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
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openConnection();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select * From Items Where ItemNo='"+txtSearch.Text.Trim()+"'", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            sda.SelectCommand.ExecuteNonQuery();
            closeConnection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtItemNo.Text == "")
            {
                MessageBox.Show("Item No Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtItemName.Text == "")
            {
                MessageBox.Show("Item Name Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtItemSize.Text == "")
            {
                MessageBox.Show("Item Size Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPrice.Text == "")
            {
                MessageBox.Show("Price Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Item Quantity Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    openConnection();
                    SQLiteCommand sda = new SQLiteCommand("UPDATE Items SET ItemNo='" + txtItemNo.Text.Trim() + "', ItemName='" + txtItemName.Text.Trim() + "',ItemSize='" +txtItemSize.Text.Trim() + "', Price='" + txtPrice.Text.Trim() + "', Quantity='"+txtQuantity.Text+"', Date='"+txtDate.Text+"' Where ItemId= '" +lblId.Text+ "'", con);
                    sda.ExecuteNonQuery();
                    MessageBox.Show("Item Successfully Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    closeConnection();

                    txtItemNo.Clear();
                    txtItemName.Clear();
                    txtPrice.Clear();
                    txtItemSize.Clear();
                    txtQuantity.Clear();
                    fillDatagridView();

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
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblId.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtItemNo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtItemName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtItemSize.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPrice.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtQuantity.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
           
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete this Item", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                openConnection();
                SQLiteCommand sda = new SQLiteCommand("Delete From Items Where Id='" + lblId.Text + "'", con);
                sda.ExecuteNonQuery();
                closeConnection();
                MessageBox.Show("Item Successfully Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
    }
}

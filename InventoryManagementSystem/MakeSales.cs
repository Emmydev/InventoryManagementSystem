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
    public partial class MakeSales : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=InventoryManagementSystem.db; Version=3; New=False; Compress=True;");
        public MakeSales()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnkReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Report reprt = new Report();
            reprt.Show();
        }

        private void lnkaAllItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllItems items = new AllItems();
            items.Show();
        }

        private void lnkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void MakeSales_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToLongDateString();
            fillcombobox();
            //fillItemNocombobox();
            fillItemSizecombobox();
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
        private void label6_Click(object sender, EventArgs e)
        {

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
                closeConnection();

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

        private void cmbItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT Price, ItemSize FROM Items WHERE ItemName='" + cmbItemName.Text + "'";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            SQLiteDataReader myreader;
            try
            {
                openConnection();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string price = myreader.GetDecimal(0).ToString();
                    txtPrice.Text = price;

                    string size = myreader.GetValue(1).ToString();
                    cmbItemSize.SelectedItem = size;
                }
                closeConnection();

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

        //public void fillItemNocombobox()
        //{
        //    string sql = "SELECT * FROM Items";
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    SqlDataReader myreader;
        //    try
        //    {
        //        con.Open();
        //        myreader = cmd.ExecuteReader();
        //        while (myreader.Read())
        //        {
        //            int sname = myreader.GetInt32(1);
        //            cmbItemNo.Items.Add(sname);
        //        }
        //        con.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}

        public void fillItemSizecombobox()
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
                    string sname = myreader.GetString(3);
                    cmbItemSize.Items.Add(sname);
                }
                closeConnection();
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            if(txtQuantity.Text =="" || txtPrice.Text =="")
            {
                MessageBox.Show("Price or Quantity Field Cannot be Null");
            }
            else
            {
                decimal price = Convert.ToDecimal(txtPrice.Text);
                decimal quantity = Convert.ToDecimal(txtQuantity.Text);

                decimal total = price * quantity;
                txtTotal.Text = total.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSurname.Clear();
            txtOtherNames.Clear();
            cmbGender.SelectedIndex = -1;
            txtOccupation.Clear();
            txtAddress.Clear();
            txtPhoneNo.Clear();
            cmbItemName.SelectedIndex = -1;
            txtPrice.Clear();
            txtQuantity.Clear();
            //cmbItemNo.SelectedIndex = -1;
            cmbItemSize.SelectedIndex = -1;
            txtTotal.Clear();

        }

        private void btnPurchaseDone_Click(object sender, EventArgs e)
        {
        
            if(txtSurname.Text=="")
            {
                MessageBox.Show("Surname Field Cannot be Empty");
            }
            else if(txtOtherNames.Text=="")
            {
                MessageBox.Show("Other Names Field Cannot be Empty");
            }
            else if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Select Gender");
            }
            else if (txtOccupation.Text == "")
            {
                MessageBox.Show("Occupation Field Cannot be Empty");
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address Field Cannot be Empty");
            }
            else if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Phone No Field Cannot be Empty");
            }
            else if (cmbItemName.SelectedIndex==-1)
            {
                MessageBox.Show("Select Item Field Cannot be Empty");
            }
            else if (txtQuantity.Text == "")
            {
                MessageBox.Show("Quantity Field Cannot be Empty");
            }
            else if (cmbItemSize.SelectedIndex == -1)
            {
                MessageBox.Show("Select Item Size Field Cannot be Empty");
            }
            else if (txtTotal.Text=="")
            {
                MessageBox.Show("Total Field Cannot be Empty");
            }
            
            else
            {
                try
                {

                    string sql = "SELECT * FROM Items WHERE ItemName='" + cmbItemName.Text + "'";
                    SQLiteCommand cmd = new SQLiteCommand(sql, con);
                    SQLiteDataReader myreader;
                    openConnection();
                    myreader = cmd.ExecuteReader();
                    while (myreader.Read())
                    {
                        //int price = myreader.GetInt32(5);
                        //txtTest.Text = price.ToString();

                        int Oldquantity = myreader.GetInt32(5);
                        int quantityPurchased;
                        quantityPurchased = Convert.ToInt32(txtQuantity.Text);
                        
                        if(Oldquantity < quantityPurchased)
                        {
                            MessageBox.Show("Stock too Low");
                            closeConnection();
                            
                            cmbItemName.SelectedIndex = -1;
                            txtPrice.Clear();
                            txtQuantity.Clear();
                            txtTotal.Clear();
                            //cmbItemNo.SelectedIndex = -1;
                            cmbItemSize.SelectedIndex = -1;
                            
                        }

                    }
                    closeConnection();

                        openConnection();
                        SQLiteCommand sda = new SQLiteCommand("INSERT INTO Report(Surname, OtherNames, Gender, Occupation, Address, PhoneNo, Date, ItemName, Price, Quantity, ItemSize, Total) VALUES('" + txtSurname.Text.Trim() + "', '" + txtOtherNames.Text.Trim() + "', '" + cmbGender.SelectedItem + "', '" + txtOccupation.Text.Trim() + "', '" + txtAddress.Text.Trim() + "', '" + txtPhoneNo.Text.Trim() + "', '" + txtDate.Text.Trim() + "', '" + cmbItemName.SelectedItem + "', '" + txtPrice.Text.Trim() + "', '" + txtQuantity.Text.Trim() + "', '" + cmbItemSize.SelectedItem + "', '" + txtTotal.Text.Trim() + "')", con);
                        sda.ExecuteNonQuery();
                        MessageBox.Show("Record Updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();


                        openConnection();
                        SQLiteCommand sad = new SQLiteCommand("UPDATE Items SET Quantity= Quantity - ('" +Convert.ToInt32(txtQuantity.Text) + "') Where ItemName= '" + cmbItemName.SelectedItem + "'", con);
                        sad.ExecuteNonQuery();
                        closeConnection();
                    
                    cmbItemName.SelectedIndex = -1;
                    txtPrice.Clear();
                    txtQuantity.Clear();
                    txtTotal.Clear();
                   // cmbItemNo.SelectedIndex = -1;
                    cmbItemSize.SelectedIndex = -1;
                    
                          
                 }


                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                 
             }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            openConnection();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select * From Report Where Date='" +dateTimePicker1.Text+ "'", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            sda.SelectCommand.ExecuteNonQuery();
            closeConnection();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            openConnection();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select * From Report", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            sda.SelectCommand.ExecuteNonQuery();
            closeConnection();
        }
        
    }
}

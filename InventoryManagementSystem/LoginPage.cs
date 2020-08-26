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
    public partial class LoginPage : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=InventoryManagementSystem.db; Version=3; New=False; Compress=True;");
        public LoginPage()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text=="")
            {
                MessageBox.Show("Email Field Cannot be Empty");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Password Field Cannot be Empty");
            }
            else if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Role Must be Selected");
            }

            else
            {
                try
                {
                    //string queryText = @"SELECT COUNT(*) FROM StaffInformation WHERE Email = @email And Password= @password And Role= @role";
                    //SQLiteCommand cmd = new SQLiteCommand(queryText, con);
                    //con.Open();
                    //cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    //cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                    //cmd.Parameters.AddWithValue("@role", cmbRole.SelectedItem);
                    //int result = (int)cmd.ExecuteScalar();
                    //if (result > 0)
                    //{
                    //    //MessageBox.Show("Successful");
                    //    if (cmbRole.SelectedItem == "SalesRep")
                    //    {
                    //        MakeSales recep = new MakeSales();
                    //        recep.Show();
                    //        this.Close();
                    //    }
                    //    else if (cmbRole.SelectedItem == "Admin")
                    //    {
                    //        StaffRegisteration adm = new StaffRegisteration();
                    //        adm.Show();
                    //        this.Close();
                    //    }

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Invalid Login Details", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}

                    if (txtEmail.Text == "admin" & txtPassword.Text == "admin" )
                    {
                        //MessageBox.Show("Successful");
                        if (cmbRole.SelectedItem == "SalesRep")
                        {
                            MakeSales recep = new MakeSales();
                            recep.Show();
                            this.Close();
                        }
                        else if (cmbRole.SelectedItem == "Admin")
                        {
                            StaffRegisteration adm = new StaffRegisteration();
                            adm.Show();
                            this.Close();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Login Details", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    txtEmail.Clear();
                    txtPassword.Clear();
                    cmbRole.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}

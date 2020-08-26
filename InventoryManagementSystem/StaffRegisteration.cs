using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.SQLite;

namespace InventoryManagementSystem
{
    public partial class StaffRegisteration : Form
    {
        string imgLocation;
        SQLiteConnection con = new SQLiteConnection("Data Source=InventoryManagementSystem.db; Version=3; New=False; Compress=True;");
        public StaffRegisteration()
        {
            InitializeComponent();
        }

        private void StaffRegisteration_Load(object sender, EventArgs e)
        {
           txtStaffName.Focus();
            autoIncrement();
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
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStaffName.Clear();
            cmbGender.SelectedIndex = -1;
            dateTimePicker1.Text = DateTime.Now.ToLongDateString();
            cmbRole.SelectedIndex = -1;
            txtNationality.Clear();
            txtState.Clear();
            txtLGA.Clear();
            txtPhoneNo.Clear();
            txtEmail.Clear();
            txtQualification.Clear();
            txtAddress.Clear();
            txtAppointmentYr.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            ImageBox.Image = null;
        }

        private void lnkAllStaff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllStaff staff = new AllStaff();
            staff.Show();
        }

        private void lnkAllItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AllItems items = new AllItems();
            items.Show();
        }

        private void lnkWarehouse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Warehouse ware = new Warehouse();
            ware.Show();
        }

        private void lnkSearchItem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Search serch = new Search();
            serch.Show();
        }

        private void lnkReport_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Report reprt = new Report();
            reprt.Show();
        }

        private void lnkLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public bool CheckPassword()
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password Mismatch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EmailCheck()
        {
            openConnection();
            SQLiteCommand sda = new SQLiteCommand("Select Count(*) From StaffInformation Where Email='" + txtEmail.Text + "'", con);
            int count = Convert.ToInt32(sda.ExecuteScalar());
            closeConnection();
            if (count > 0)
            {
                MessageBox.Show(txtEmail.Text + " Already Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            else
            {
                return false;
            }



        }
        public void autoIncrement()
        {
            openConnection();
            SQLiteCommand sda = new SQLiteCommand("Select Max(StaffId)+1 From StaffInformation", con);
            SQLiteDataReader dr = sda.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    //string rand = "REC";
                    txtStaffId.Text = dr[0].ToString();
                    //lblUserId.Text = lblUserId.Text;
                    if (txtStaffId.Text == "")
                    {

                        txtStaffId.Text = "1";
                    }
                }
            }
            else
            {

                txtStaffId.Text = "1";
            }
            closeConnection();


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtStaffName.Text == "")
            {
                MessageBox.Show("Staff Name Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Select Staff Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Select Staff Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNationality.Text == "")
            {
                MessageBox.Show("Nationality Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtState.Text == "")
            {
                MessageBox.Show("State Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLGA.Text == "")
            {
                MessageBox.Show("LGA Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPhoneNo.Text == "")
            {
                MessageBox.Show("Phone No Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Email Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtQualification.Text == "")
            {
                MessageBox.Show("Qualification Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAppointmentYr.Text == "")
            {
                MessageBox.Show("Appointment Year Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Phone No Field Cannot be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
            else
            {
                try
                {
                    if (!EmailCheck() & !CheckPassword())
                    {
                        byte[] images = null;
                        FileStream filestream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader br = new BinaryReader(filestream);
                        images = br.ReadBytes((int)filestream.Length);


                        openConnection();
                        SQLiteCommand sda = new SQLiteCommand("INSERT INTO StaffInformation(StaffId, StaffName, Gender, DOB, Role, Nationality, State, LGA, PhoneNo, Email, Qualification, Address, AppointmentYr, Password, Image) VALUES('" + txtStaffId.Text.Trim() + "', '" + txtStaffName.Text.Trim() + "', '" + cmbGender.SelectedItem + "', '" + dateTimePicker1.Text + "', '" + cmbRole.SelectedItem + "', '" + txtNationality.Text.Trim() + "', '" + txtState.Text.Trim() + "', '" + txtLGA.Text.Trim() + "', '" + txtPhoneNo.Text.Trim() + "', '" + txtEmail.Text.Trim() + "', '" + txtQualification.Text.Trim() + "', '" + txtAddress.Text.Trim() + "', '" + txtAppointmentYr.Text.Trim() + "', '" + txtPassword.Text.Trim() + "',@image)", con);
                        sda.Parameters.Add(new SQLiteParameter("@image", images));
                        sda.ExecuteNonQuery();
                        MessageBox.Show("Staff Record Successfully Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        closeConnection();

                        txtStaffName.Clear();
                        cmbGender.SelectedIndex = -1;
                        dateTimePicker1.Text = DateTime.Now.ToLongDateString();
                        cmbRole.SelectedIndex = -1;
                        txtNationality.Clear();
                        txtState.Clear();
                        txtLGA.Clear();
                        txtPhoneNo.Clear();
                        txtEmail.Clear();
                        txtQualification.Clear();
                        txtAddress.Clear();
                        txtAppointmentYr.Clear();
                        txtPassword.Clear();
                        txtConfirmPassword.Clear();
                        ImageBox.Image = null;
                        autoIncrement();

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
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*)";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                ImageBox.ImageLocation = imgLocation;

            }
        }


    }
}

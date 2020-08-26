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
    public partial class AllStaff : Form
    {
        SQLiteConnection con = new SQLiteConnection("Data Source=InventoryManagementSystem.db; Version=3; New=False; Compress=True;");
        public AllStaff()
        {
            InitializeComponent();
        }

        private void AllStaff_Load(object sender, EventArgs e)
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            openConnection();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select StaffId, StaffName, Gender, DOB, Role, Nationality, State, LGA, PhoneNo, Email, Qualification, Address, AppointmentYr From StaffInformation Where StaffId = '"+txtSearch.Text.Trim()+"'", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            sda.SelectCommand.ExecuteNonQuery();
            closeConnection();
        }
        public void fillDatagridView()
        {
            openConnection();
            SQLiteDataAdapter sda = new SQLiteDataAdapter("Select StaffId, StaffName, Gender, DOB, Role, Nationality, State, LGA, PhoneNo, Email, Qualification, Address, AppointmentYr From StaffInformation", con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            sda.SelectCommand.ExecuteNonQuery();
            closeConnection();
        }

        private void btnViewStaff_Click(object sender, EventArgs e)
        {
            fillDatagridView();
        }
        
    }
}

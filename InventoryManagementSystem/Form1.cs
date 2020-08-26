using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
        }

        private void lnkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void picBoxExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Exit", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        

        
    }
}

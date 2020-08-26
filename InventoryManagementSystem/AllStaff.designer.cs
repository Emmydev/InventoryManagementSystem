namespace InventoryManagementSystem
{
    partial class AllStaff
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnViewStaff = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Azure;
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Controls.Add(this.btnViewStaff);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(12, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(939, 421);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Registered Staff";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(807, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 35);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(325, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 19);
            this.label9.TabIndex = 12;
            this.label9.Text = "Staff ID:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(411, 34);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 30);
            this.txtSearch.TabIndex = 2;
            // 
            // btnViewStaff
            // 
            this.btnViewStaff.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewStaff.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewStaff.Location = new System.Drawing.Point(329, 364);
            this.btnViewStaff.Name = "btnViewStaff";
            this.btnViewStaff.Size = new System.Drawing.Size(292, 35);
            this.btnViewStaff.TabIndex = 1;
            this.btnViewStaff.Text = "View all Staff";
            this.btnViewStaff.UseVisualStyleBackColor = false;
            this.btnViewStaff.Click += new System.EventHandler(this.btnViewStaff_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.Location = new System.Drawing.Point(42, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(849, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.Location = new System.Drawing.Point(-4, -2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(967, 44);
            this.textBox1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(219, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // AllStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(963, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox4);
            this.Name = "AllStaff";
            this.Text = "AllStaff";
            this.Load += new System.EventHandler(this.AllStaff_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnViewStaff;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
    }
}
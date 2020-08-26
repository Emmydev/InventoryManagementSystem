namespace InventoryManagementSystem
{
    partial class Warehouse
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtItemSize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.Location = new System.Drawing.Point(-3, -1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(967, 44);
            this.textBox1.TabIndex = 53;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Azure;
            this.groupBox4.Controls.Add(this.lblId);
            this.groupBox4.Controls.Add(this.txtItemName);
            this.groupBox4.Controls.Add(this.btnSearch);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtSearch);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.txtDate);
            this.groupBox4.Controls.Add(this.txtPrice);
            this.groupBox4.Controls.Add(this.txtItemSize);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtQuantity);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtItemNo);
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(12, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(939, 409);
            this.groupBox4.TabIndex = 55;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add/Modify/Delete Items";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DarkRed;
            this.lblId.Location = new System.Drawing.Point(910, 387);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 19);
            this.lblId.TabIndex = 56;
            this.lblId.Text = "Id";
            this.lblId.Visible = false;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(109, 80);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(232, 27);
            this.txtItemName.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Blue;
            this.btnSearch.Location = new System.Drawing.Point(827, 37);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 35);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(356, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Item No:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(431, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(377, 23);
            this.txtSearch.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Blue;
            this.btnAdd.Location = new System.Drawing.Point(100, 272);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 35);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdate.Location = new System.Drawing.Point(260, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 35);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Location = new System.Drawing.Point(132, 313);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 35);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Blue;
            this.btnClear.Location = new System.Drawing.Point(222, 312);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 35);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDate.Location = new System.Drawing.Point(109, 222);
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(232, 27);
            this.txtDate.TabIndex = 43;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(109, 149);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(232, 27);
            this.txtPrice.TabIndex = 4;
            // 
            // txtItemSize
            // 
            this.txtItemSize.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemSize.Location = new System.Drawing.Point(109, 116);
            this.txtItemSize.Multiline = true;
            this.txtItemSize.Name = "txtItemSize";
            this.txtItemSize.Size = new System.Drawing.Size(232, 27);
            this.txtItemSize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(6, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Item Size:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkBlue;
            this.label16.Location = new System.Drawing.Point(7, 233);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 19);
            this.label16.TabIndex = 38;
            this.label16.Text = "Date:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(109, 186);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(232, 27);
            this.txtQuantity.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkBlue;
            this.label14.Location = new System.Drawing.Point(6, 194);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 19);
            this.label14.TabIndex = 36;
            this.label14.Text = "Item Quantity:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(6, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 19);
            this.label12.TabIndex = 34;
            this.label12.Text = "Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(6, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 33;
            this.label11.Text = "Item Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkBlue;
            this.label10.Location = new System.Drawing.Point(6, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "Item No:";
            // 
            // txtItemNo
            // 
            this.txtItemNo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemNo.Location = new System.Drawing.Point(109, 47);
            this.txtItemNo.Multiline = true;
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(232, 27);
            this.txtItemNo.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(360, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(573, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(229, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 28);
            this.label1.TabIndex = 57;
            this.label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // Warehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.stock;
            this.ClientSize = new System.Drawing.Size(963, 472);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox1);
            this.Name = "Warehouse";
            this.Text = "Warehouse";
            this.Load += new System.EventHandler(this.Warehouse_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtItemSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label1;
    }
}
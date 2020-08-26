namespace InventoryManagementSystem
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkExit = new System.Windows.Forms.LinkLabel();
            this.picBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(28, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(544, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY AND STOCK MANAGEMENT SYSTEM";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Blue;
            this.btnLogin.Location = new System.Drawing.Point(205, 133);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(199, 85);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "PROCEED TO LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkExit
            // 
            this.lnkExit.AutoSize = true;
            this.lnkExit.ForeColor = System.Drawing.Color.Blue;
            this.lnkExit.LinkColor = System.Drawing.Color.Blue;
            this.lnkExit.Location = new System.Drawing.Point(529, 332);
            this.lnkExit.Name = "lnkExit";
            this.lnkExit.Size = new System.Drawing.Size(66, 13);
            this.lnkExit.TabIndex = 7;
            this.lnkExit.TabStop = true;
            this.lnkExit.Text = "Exit Program";
            this.lnkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExit_LinkClicked);
            // 
            // picBoxExit
            // 
            this.picBoxExit.Image = global::InventoryManagementSystem.Properties.Resources.exit1;
            this.picBoxExit.Location = new System.Drawing.Point(532, 276);
            this.picBoxExit.Name = "picBoxExit";
            this.picBoxExit.Size = new System.Drawing.Size(60, 54);
            this.picBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxExit.TabIndex = 8;
            this.picBoxExit.TabStop = false;
            this.picBoxExit.Click += new System.EventHandler(this.picBoxExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InventoryManagementSystem.Properties.Resources._base;
            this.pictureBox1.Location = new System.Drawing.Point(4, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(603, 345);
            this.Controls.Add(this.picBoxExit);
            this.Controls.Add(this.lnkExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lnkExit;
        private System.Windows.Forms.PictureBox picBoxExit;
    }
}


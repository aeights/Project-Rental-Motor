namespace Project_Winform
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.logout = new System.Windows.Forms.Button();
            this.data_motor = new System.Windows.Forms.DataGridView();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_day = new System.Windows.Forms.TextBox();
            this.rent = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.transaksi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_motor)).BeginInit();
            this.SuspendLayout();
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.logout.Location = new System.Drawing.Point(571, 3);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(100, 30);
            this.logout.TabIndex = 0;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // data_motor
            // 
            this.data_motor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_motor.Location = new System.Drawing.Point(12, 151);
            this.data_motor.Name = "data_motor";
            this.data_motor.Size = new System.Drawing.Size(650, 200);
            this.data_motor.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(164, 85);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 20);
            this.txt_username.TabIndex = 2;
            // 
            // txt_day
            // 
            this.txt_day.Location = new System.Drawing.Point(385, 85);
            this.txt_day.Name = "txt_day";
            this.txt_day.Size = new System.Drawing.Size(100, 20);
            this.txt_day.TabIndex = 3;
            // 
            // rent
            // 
            this.rent.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.rent.Location = new System.Drawing.Point(275, 111);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(100, 30);
            this.rent.TabIndex = 4;
            this.rent.Text = "Sewa";
            this.rent.UseVisualStyleBackColor = true;
            this.rent.Click += new System.EventHandler(this.rent_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.refresh.Location = new System.Drawing.Point(164, 111);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(100, 30);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Cek Motor";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label2.Location = new System.Drawing.Point(388, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Hari";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(275, 85);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.label3.Location = new System.Drawing.Point(278, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "ID Motor";
            // 
            // transaksi
            // 
            this.transaksi.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.transaksi.Location = new System.Drawing.Point(385, 111);
            this.transaksi.Name = "transaksi";
            this.transaksi.Size = new System.Drawing.Size(100, 30);
            this.transaksi.TabIndex = 11;
            this.transaksi.Text = "Cek Transaksi";
            this.transaksi.UseVisualStyleBackColor = true;
            this.transaksi.Click += new System.EventHandler(this.transaksi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sewa Motor";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.transaksi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.rent);
            this.Controls.Add(this.txt_day);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.data_motor);
            this.Controls.Add(this.logout);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.data_motor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.DataGridView data_motor;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_day;
        private System.Windows.Forms.Button rent;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button transaksi;
        private System.Windows.Forms.Label label4;
    }
}
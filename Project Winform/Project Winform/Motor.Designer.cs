namespace Project_Winform
{
    partial class Motor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Motor));
            this.refresh = new System.Windows.Forms.Button();
            this.data_motor = new System.Windows.Forms.DataGridView();
            this.insert = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_merk = new System.Windows.Forms.TextBox();
            this.txt_cc = new System.Windows.Forms.TextBox();
            this.txt_plat = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.orders = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_motor)).BeginInit();
            this.SuspendLayout();
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(167, 124);
            this.refresh.Margin = new System.Windows.Forms.Padding(2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(56, 25);
            this.refresh.TabIndex = 1;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // data_motor
            // 
            this.data_motor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_motor.Location = new System.Drawing.Point(12, 153);
            this.data_motor.Margin = new System.Windows.Forms.Padding(2);
            this.data_motor.Name = "data_motor";
            this.data_motor.RowHeadersWidth = 51;
            this.data_motor.RowTemplate.Height = 24;
            this.data_motor.Size = new System.Drawing.Size(650, 200);
            this.data_motor.TabIndex = 2;
            // 
            // insert
            // 
            this.insert.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert.Location = new System.Drawing.Point(239, 124);
            this.insert.Margin = new System.Windows.Forms.Padding(2);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(56, 25);
            this.insert.TabIndex = 3;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // update
            // 
            this.update.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(310, 124);
            this.update.Margin = new System.Windows.Forms.Padding(2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(56, 25);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(380, 124);
            this.delete.Margin = new System.Windows.Forms.Padding(2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(56, 25);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(97, 77);
            this.txt_id.Margin = new System.Windows.Forms.Padding(2);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(126, 20);
            this.txt_id.TabIndex = 6;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(97, 101);
            this.txt_nama.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(126, 20);
            this.txt_nama.TabIndex = 7;
            // 
            // txt_merk
            // 
            this.txt_merk.Location = new System.Drawing.Point(274, 77);
            this.txt_merk.Margin = new System.Windows.Forms.Padding(2);
            this.txt_merk.Name = "txt_merk";
            this.txt_merk.Size = new System.Drawing.Size(126, 20);
            this.txt_merk.TabIndex = 8;
            // 
            // txt_cc
            // 
            this.txt_cc.Location = new System.Drawing.Point(274, 101);
            this.txt_cc.Margin = new System.Windows.Forms.Padding(2);
            this.txt_cc.Name = "txt_cc";
            this.txt_cc.Size = new System.Drawing.Size(126, 20);
            this.txt_cc.TabIndex = 9;
            // 
            // txt_plat
            // 
            this.txt_plat.Location = new System.Drawing.Point(450, 77);
            this.txt_plat.Margin = new System.Windows.Forms.Padding(2);
            this.txt_plat.Name = "txt_plat";
            this.txt_plat.Size = new System.Drawing.Size(126, 20);
            this.txt_plat.TabIndex = 10;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(450, 101);
            this.txt_harga.Margin = new System.Windows.Forms.Padding(2);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(126, 20);
            this.txt_harga.TabIndex = 11;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(274, 52);
            this.txt_search.Margin = new System.Windows.Forms.Padding(2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(66, 20);
            this.txt_search.TabIndex = 12;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(344, 50);
            this.search.Margin = new System.Windows.Forms.Padding(2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(56, 22);
            this.search.TabIndex = 13;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(450, 124);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(56, 25);
            this.clear.TabIndex = 14;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // logout
            // 
            this.logout.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.Location = new System.Drawing.Point(587, 12);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(75, 25);
            this.logout.TabIndex = 15;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // orders
            // 
            this.orders.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orders.Location = new System.Drawing.Point(587, 41);
            this.orders.Name = "orders";
            this.orders.Size = new System.Drawing.Size(75, 25);
            this.orders.TabIndex = 16;
            this.orders.Text = "Cek Order";
            this.orders.UseVisualStyleBackColor = true;
            this.orders.Click += new System.EventHandler(this.orders_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data Motor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "ID Motor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Plat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "CC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(235, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Merk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Nama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(190, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "Search by ID";
            // 
            // Motor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orders);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.txt_plat);
            this.Controls.Add(this.txt_cc);
            this.Controls.Add(this.txt_merk);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.data_motor);
            this.Controls.Add(this.refresh);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Motor";
            this.Text = "Motor";
            ((System.ComponentModel.ISupportInitialize)(this.data_motor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView data_motor;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_merk;
        private System.Windows.Forms.TextBox txt_cc;
        private System.Windows.Forms.TextBox txt_plat;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button orders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}
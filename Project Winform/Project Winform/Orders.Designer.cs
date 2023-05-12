namespace Project_Winform
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.data_orders = new System.Windows.Forms.DataGridView();
            this.cek_orders = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_orders)).BeginInit();
            this.SuspendLayout();
            // 
            // data_orders
            // 
            this.data_orders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_orders.Location = new System.Drawing.Point(62, 149);
            this.data_orders.Name = "data_orders";
            this.data_orders.Size = new System.Drawing.Size(548, 200);
            this.data_orders.TabIndex = 0;
            // 
            // cek_orders
            // 
            this.cek_orders.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cek_orders.Location = new System.Drawing.Point(260, 118);
            this.cek_orders.Name = "cek_orders";
            this.cek_orders.Size = new System.Drawing.Size(83, 25);
            this.cek_orders.TabIndex = 1;
            this.cek_orders.Text = "Cek Orders";
            this.cek_orders.UseVisualStyleBackColor = true;
            this.cek_orders.Click += new System.EventHandler(this.cek_orders_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(349, 119);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(83, 25);
            this.cancel.TabIndex = 2;
            this.cancel.Text = "Batalkan Order";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(299, 92);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(90, 20);
            this.txt_id.TabIndex = 3;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(587, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 25);
            this.back.TabIndex = 4;
            this.back.Text = "Kembali";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Order";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.cek_orders);
            this.Controls.Add(this.data_orders);
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.data_orders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_orders;
        private System.Windows.Forms.Button cek_orders;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
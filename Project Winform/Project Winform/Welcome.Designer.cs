namespace Project_Winform
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.Button();
            this.txt_admin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(166, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat Datang di Moto Java Easy\r\nSilahkan Login Terlebih Dahulu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_user.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F);
            this.txt_user.Location = new System.Drawing.Point(255, 155);
            this.txt_user.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(170, 36);
            this.txt_user.TabIndex = 1;
            this.txt_user.Text = "Login Sebagai User";
            this.txt_user.UseVisualStyleBackColor = false;
            this.txt_user.Click += new System.EventHandler(this.txt_user_Click);
            // 
            // txt_admin
            // 
            this.txt_admin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_admin.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_admin.Location = new System.Drawing.Point(255, 207);
            this.txt_admin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_admin.Name = "txt_admin";
            this.txt_admin.Size = new System.Drawing.Size(170, 36);
            this.txt_admin.TabIndex = 2;
            this.txt_admin.Text = "Login Sebagai Admin";
            this.txt_admin.UseVisualStyleBackColor = false;
            this.txt_admin.Click += new System.EventHandler(this.txt_admin_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 361);
            this.Controls.Add(this.txt_admin);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txt_user;
        private System.Windows.Forms.Button txt_admin;
    }
}
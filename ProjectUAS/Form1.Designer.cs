namespace ProjectUAS
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
            this.btnPembeli = new System.Windows.Forms.Button();
            this.btnBuku = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPembeli
            // 
            this.btnPembeli.Location = new System.Drawing.Point(289, 348);
            this.btnPembeli.Name = "btnPembeli";
            this.btnPembeli.Size = new System.Drawing.Size(81, 33);
            this.btnPembeli.TabIndex = 0;
            this.btnPembeli.Text = "PEMBELI";
            this.btnPembeli.UseVisualStyleBackColor = true;
            this.btnPembeli.Click += new System.EventHandler(this.btnPembeli_Click);
            // 
            // btnBuku
            // 
            this.btnBuku.Location = new System.Drawing.Point(404, 348);
            this.btnBuku.Name = "btnBuku";
            this.btnBuku.Size = new System.Drawing.Size(81, 33);
            this.btnBuku.TabIndex = 2;
            this.btnBuku.Text = "KARYAWAN";
            this.btnBuku.UseVisualStyleBackColor = true;
            this.btnBuku.Click += new System.EventHandler(this.btnBuku_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectUAS.Properties.Resources.tokoo;
            this.pictureBox1.Location = new System.Drawing.Point(234, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuku);
            this.Controls.Add(this.btnPembeli);
            this.Name = "Form1";
            this.Text = "Halaman Utama";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPembeli;
        private System.Windows.Forms.Button btnBuku;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


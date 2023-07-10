namespace ProjectUAS
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtIDBuku = new System.Windows.Forms.TextBox();
            this.txtNamaPembeli = new System.Windows.Forms.TextBox();
            this.IDBuku = new System.Windows.Forms.Label();
            this.NamaPembeli = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(460, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 55;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(347, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 299);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtIDBuku
            // 
            this.txtIDBuku.Location = new System.Drawing.Point(313, 181);
            this.txtIDBuku.Name = "txtIDBuku";
            this.txtIDBuku.Size = new System.Drawing.Size(270, 20);
            this.txtIDBuku.TabIndex = 52;
            // 
            // txtNamaPembeli
            // 
            this.txtNamaPembeli.Location = new System.Drawing.Point(313, 142);
            this.txtNamaPembeli.Name = "txtNamaPembeli";
            this.txtNamaPembeli.Size = new System.Drawing.Size(270, 20);
            this.txtNamaPembeli.TabIndex = 51;
            // 
            // IDBuku
            // 
            this.IDBuku.AutoSize = true;
            this.IDBuku.Location = new System.Drawing.Point(188, 184);
            this.IDBuku.Name = "IDBuku";
            this.IDBuku.Size = new System.Drawing.Size(58, 13);
            this.IDBuku.TabIndex = 50;
            this.IDBuku.Text = "ID Pembeli";
            // 
            // NamaPembeli
            // 
            this.NamaPembeli.AutoSize = true;
            this.NamaPembeli.Location = new System.Drawing.Point(188, 142);
            this.NamaPembeli.Name = "NamaPembeli";
            this.NamaPembeli.Size = new System.Drawing.Size(46, 13);
            this.NamaPembeli.TabIndex = 49;
            this.NamaPembeli.Text = "ID Buku";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 56;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtIDBuku);
            this.Controls.Add(this.txtNamaPembeli);
            this.Controls.Add(this.IDBuku);
            this.Controls.Add(this.NamaPembeli);
            this.Name = "Form7";
            this.Text = "Membeli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtIDBuku;
        private System.Windows.Forms.TextBox txtNamaPembeli;
        private System.Windows.Forms.Label IDBuku;
        private System.Windows.Forms.Label NamaPembeli;
        private System.Windows.Forms.Button button1;
    }
}
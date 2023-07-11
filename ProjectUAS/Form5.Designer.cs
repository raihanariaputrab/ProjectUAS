namespace ProjectUAS
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.txtIDKrywn = new System.Windows.Forms.TextBox();
            this.txtAlmt = new System.Windows.Forms.Label();
            this.NoHP = new System.Windows.Forms.Label();
            this.IDkrywn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(444, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 40;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(331, 309);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(219, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 38;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(297, 191);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(270, 20);
            this.txtAlamat.TabIndex = 37;
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(297, 152);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(270, 20);
            this.txtNoHP.TabIndex = 36;
            // 
            // txtIDKrywn
            // 
            this.txtIDKrywn.Location = new System.Drawing.Point(297, 112);
            this.txtIDKrywn.Name = "txtIDKrywn";
            this.txtIDKrywn.Size = new System.Drawing.Size(270, 20);
            this.txtIDKrywn.TabIndex = 35;
            // 
            // txtAlmt
            // 
            this.txtAlmt.AutoSize = true;
            this.txtAlmt.Location = new System.Drawing.Point(172, 194);
            this.txtAlmt.Name = "txtAlmt";
            this.txtAlmt.Size = new System.Drawing.Size(39, 13);
            this.txtAlmt.TabIndex = 34;
            this.txtAlmt.Text = "Alamat";
            // 
            // NoHP
            // 
            this.NoHP.AutoSize = true;
            this.NoHP.Location = new System.Drawing.Point(172, 152);
            this.NoHP.Name = "NoHP";
            this.NoHP.Size = new System.Drawing.Size(39, 13);
            this.NoHP.TabIndex = 33;
            this.NoHP.Text = "No HP";
            // 
            // IDkrywn
            // 
            this.IDkrywn.AutoSize = true;
            this.IDkrywn.Location = new System.Drawing.Point(172, 112);
            this.IDkrywn.Name = "IDkrywn";
            this.IDkrywn.Size = new System.Drawing.Size(68, 13);
            this.IDkrywn.TabIndex = 32;
            this.IDkrywn.Text = "ID Karyawan";
            this.IDkrywn.Click += new System.EventHandler(this.IDPembeli_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNoHP);
            this.Controls.Add(this.txtIDKrywn);
            this.Controls.Add(this.txtAlmt);
            this.Controls.Add(this.NoHP);
            this.Controls.Add(this.IDkrywn);
            this.Name = "Form5";
            this.Text = "Karyawan";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.TextBox txtIDKrywn;
        private System.Windows.Forms.Label txtAlmt;
        private System.Windows.Forms.Label NoHP;
        private System.Windows.Forms.Label IDkrywn;
    }
}
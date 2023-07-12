namespace ProjectUAS
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.NoHP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.txtIDKasir = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Alamat = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NoHP
            // 
            this.NoHP.AutoSize = true;
            this.NoHP.Location = new System.Drawing.Point(18, 133);
            this.NoHP.Name = "NoHP";
            this.NoHP.Size = new System.Drawing.Size(39, 13);
            this.NoHP.TabIndex = 17;
            this.NoHP.Text = "No HP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Kasir";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(239, 336);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Delete";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(713, 336);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Read";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(158, 336);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Insert";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(322, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Create";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(101, 128);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(274, 20);
            this.txtNoHP.TabIndex = 11;
            // 
            // txtIDKasir
            // 
            this.txtIDKasir.Location = new System.Drawing.Point(101, 90);
            this.txtIDKasir.Name = "txtIDKasir";
            this.txtIDKasir.Size = new System.Drawing.Size(274, 20);
            this.txtIDKasir.TabIndex = 10;
            this.txtIDKasir.TextChanged += new System.EventHandler(this.txtIDKasir_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(393, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.Size = new System.Drawing.Size(395, 213);
            this.dataGridView1.TabIndex = 9;
            // 
            // Alamat
            // 
            this.Alamat.AutoSize = true;
            this.Alamat.Location = new System.Drawing.Point(18, 209);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(39, 13);
            this.Alamat.TabIndex = 21;
            this.Alamat.Text = "Alamat";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(17, 171);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 20;
            this.Password.Text = "Password";
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(101, 204);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(274, 20);
            this.txtAlamat.TabIndex = 19;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(101, 166);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(274, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(17, 252);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 24;
            this.Username.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(101, 247);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(274, 20);
            this.txtUsername.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(11, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 32;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(319, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Silahkan Isi Data Berikut";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(77, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 34;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Alamat);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.NoHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNoHP);
            this.Controls.Add(this.txtIDKasir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Kasir";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.TextBox txtIDKasir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Alamat;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
    }
}
namespace ProjectUAS
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.pembeliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kasirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bukuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lihatTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 26);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pembeliToolStripMenuItem,
            this.kasirToolStripMenuItem,
            this.bukuToolStripMenuItem,
            this.lihatTransaksiToolStripMenuItem});
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(99, 23);
            this.toolStripButton1.Text = "Data Master";
            // 
            // pembeliToolStripMenuItem
            // 
            this.pembeliToolStripMenuItem.Name = "pembeliToolStripMenuItem";
            this.pembeliToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.pembeliToolStripMenuItem.Text = "Pembeli";
            this.pembeliToolStripMenuItem.Click += new System.EventHandler(this.pembeliToolStripMenuItem_Click);
            // 
            // kasirToolStripMenuItem
            // 
            this.kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            this.kasirToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.kasirToolStripMenuItem.Text = "Kasir";
            this.kasirToolStripMenuItem.Click += new System.EventHandler(this.kasirToolStripMenuItem_Click);
            // 
            // bukuToolStripMenuItem
            // 
            this.bukuToolStripMenuItem.Name = "bukuToolStripMenuItem";
            this.bukuToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.bukuToolStripMenuItem.Text = "Buku";
            this.bukuToolStripMenuItem.Click += new System.EventHandler(this.bukuToolStripMenuItem_Click);
            // 
            // lihatTransaksiToolStripMenuItem
            // 
            this.lihatTransaksiToolStripMenuItem.Name = "lihatTransaksiToolStripMenuItem";
            this.lihatTransaksiToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.lihatTransaksiToolStripMenuItem.Text = "Lihat Transaksi";
            this.lihatTransaksiToolStripMenuItem.Click += new System.EventHandler(this.lihatTransaksiToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 46);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form13";
            this.Text = "Data Master";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem pembeliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kasirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bukuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lihatTransaksiToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}
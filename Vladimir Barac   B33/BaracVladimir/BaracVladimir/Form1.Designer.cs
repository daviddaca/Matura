namespace BaracVladimir
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.unosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.igraciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tereniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spiskoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spisakTerenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spisakPartijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajRadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazALTIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosToolStripMenuItem,
            this.spiskoviToolStripMenuItem,
            this.krajRadaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // unosToolStripMenuItem
            // 
            this.unosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.igraciToolStripMenuItem,
            this.tereniToolStripMenuItem});
            this.unosToolStripMenuItem.Name = "unosToolStripMenuItem";
            this.unosToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.unosToolStripMenuItem.Text = "Unos";
            // 
            // igraciToolStripMenuItem
            // 
            this.igraciToolStripMenuItem.Name = "igraciToolStripMenuItem";
            this.igraciToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.igraciToolStripMenuItem.Text = "Igraci";
            this.igraciToolStripMenuItem.Click += new System.EventHandler(this.igraciToolStripMenuItem_Click);
            // 
            // tereniToolStripMenuItem
            // 
            this.tereniToolStripMenuItem.Name = "tereniToolStripMenuItem";
            this.tereniToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tereniToolStripMenuItem.Text = "Tereni";
            // 
            // spiskoviToolStripMenuItem
            // 
            this.spiskoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spisakTerenaToolStripMenuItem,
            this.spisakPartijaToolStripMenuItem});
            this.spiskoviToolStripMenuItem.Name = "spiskoviToolStripMenuItem";
            this.spiskoviToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.spiskoviToolStripMenuItem.Text = "Spiskovi";
            // 
            // spisakTerenaToolStripMenuItem
            // 
            this.spisakTerenaToolStripMenuItem.Name = "spisakTerenaToolStripMenuItem";
            this.spisakTerenaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.spisakTerenaToolStripMenuItem.Text = "Spisak terena";
            this.spisakTerenaToolStripMenuItem.Click += new System.EventHandler(this.spisakTerenaToolStripMenuItem_Click);
            // 
            // spisakPartijaToolStripMenuItem
            // 
            this.spisakPartijaToolStripMenuItem.Name = "spisakPartijaToolStripMenuItem";
            this.spisakPartijaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.spisakPartijaToolStripMenuItem.Text = "Spisak partija";
            // 
            // krajRadaToolStripMenuItem
            // 
            this.krajRadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazALTIToolStripMenuItem});
            this.krajRadaToolStripMenuItem.Name = "krajRadaToolStripMenuItem";
            this.krajRadaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.krajRadaToolStripMenuItem.Text = "Kraj rada";
            this.krajRadaToolStripMenuItem.Click += new System.EventHandler(this.krajRadaToolStripMenuItem_Click);
            // 
            // izlazALTIToolStripMenuItem
            // 
            this.izlazALTIToolStripMenuItem.Name = "izlazALTIToolStripMenuItem";
            this.izlazALTIToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazALTIToolStripMenuItem.Text = "Izlaz ALT+I";
            this.izlazALTIToolStripMenuItem.Click += new System.EventHandler(this.izlazALTIToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Golf Klub";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem igraciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tereniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spiskoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spisakTerenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spisakPartijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajRadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazALTIToolStripMenuItem;

    }
}


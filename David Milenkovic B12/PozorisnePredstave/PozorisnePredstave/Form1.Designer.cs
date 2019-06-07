namespace PozorisnePredstave
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
            this.rezervacijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predstaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predstaveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preglediToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poTrupamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poKomadimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.krajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervacijeToolStripMenuItem,
            this.preglediToolStripMenuItem,
            this.krajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rezervacijeToolStripMenuItem
            // 
            this.rezervacijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.predstaveToolStripMenuItem,
            this.predstaveToolStripMenuItem1});
            this.rezervacijeToolStripMenuItem.Name = "rezervacijeToolStripMenuItem";
            this.rezervacijeToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.rezervacijeToolStripMenuItem.Text = "Unos";
            // 
            // predstaveToolStripMenuItem
            // 
            this.predstaveToolStripMenuItem.Name = "predstaveToolStripMenuItem";
            this.predstaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.predstaveToolStripMenuItem.Text = "Rezervacije";
            this.predstaveToolStripMenuItem.Click += new System.EventHandler(this.predstaveToolStripMenuItem_Click);
            // 
            // predstaveToolStripMenuItem1
            // 
            this.predstaveToolStripMenuItem1.Name = "predstaveToolStripMenuItem1";
            this.predstaveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.predstaveToolStripMenuItem1.Text = "Predstave";
            // 
            // preglediToolStripMenuItem
            // 
            this.preglediToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poTrupamaToolStripMenuItem,
            this.poKomadimaToolStripMenuItem});
            this.preglediToolStripMenuItem.Name = "preglediToolStripMenuItem";
            this.preglediToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.preglediToolStripMenuItem.Text = "Pregledi";
            // 
            // poTrupamaToolStripMenuItem
            // 
            this.poTrupamaToolStripMenuItem.Name = "poTrupamaToolStripMenuItem";
            this.poTrupamaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.poTrupamaToolStripMenuItem.Text = "Po trupama";
            // 
            // poKomadimaToolStripMenuItem
            // 
            this.poKomadimaToolStripMenuItem.Name = "poKomadimaToolStripMenuItem";
            this.poKomadimaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.poKomadimaToolStripMenuItem.Text = "Po komadima";
            this.poKomadimaToolStripMenuItem.Click += new System.EventHandler(this.poKomadimaToolStripMenuItem_Click);
            // 
            // krajToolStripMenuItem
            // 
            this.krajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.krajToolStripMenuItem.Name = "krajToolStripMenuItem";
            this.krajToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.krajToolStripMenuItem.Text = "Kraj";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Pozoriste";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezervacijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predstaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predstaveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preglediToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poTrupamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poKomadimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem krajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}


namespace pryGerhauser
{
    partial class Main
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
            menuStrip1 = new MenuStrip();
            firmaToolStripMenuItem = new ToolStripMenuItem();
            galagaToolStripMenuItem = new ToolStripMenuItem();
            panelHijo = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { firmaToolStripMenuItem, galagaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(685, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // firmaToolStripMenuItem
            // 
            firmaToolStripMenuItem.Name = "firmaToolStripMenuItem";
            firmaToolStripMenuItem.Size = new Size(49, 20);
            firmaToolStripMenuItem.Text = "Firma";
            firmaToolStripMenuItem.Click += firmaToolStripMenuItem_Click;
            // 
            // galagaToolStripMenuItem
            // 
            galagaToolStripMenuItem.Name = "galagaToolStripMenuItem";
            galagaToolStripMenuItem.Size = new Size(55, 20);
            galagaToolStripMenuItem.Text = "Galaga";
            galagaToolStripMenuItem.Click += galagaToolStripMenuItem_Click;
            // 
            // panelHijo
            // 
            panelHijo.Dock = DockStyle.Fill;
            panelHijo.Location = new Point(0, 24);
            panelHijo.Name = "panelHijo";
            panelHijo.Size = new Size(685, 370);
            panelHijo.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 394);
            Controls.Add(panelHijo);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem firmaToolStripMenuItem;
        private ToolStripMenuItem galagaToolStripMenuItem;
        private Panel panelHijo;
    }
}
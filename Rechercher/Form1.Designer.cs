namespace Rechercher
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rechercher1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercher2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercher3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercher4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rechercher1ToolStripMenuItem,
            this.rechercher2ToolStripMenuItem,
            this.rechercher3ToolStripMenuItem,
            this.rechercher4ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rechercher1ToolStripMenuItem
            // 
            this.rechercher1ToolStripMenuItem.Name = "rechercher1ToolStripMenuItem";
            this.rechercher1ToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.rechercher1ToolStripMenuItem.Text = "Rechercher 1";
            this.rechercher1ToolStripMenuItem.Click += new System.EventHandler(this.rechercher1ToolStripMenuItem_Click);
            // 
            // rechercher2ToolStripMenuItem
            // 
            this.rechercher2ToolStripMenuItem.Name = "rechercher2ToolStripMenuItem";
            this.rechercher2ToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.rechercher2ToolStripMenuItem.Text = "Rechercher 2";
            this.rechercher2ToolStripMenuItem.Click += new System.EventHandler(this.rechercher2ToolStripMenuItem_Click);
            // 
            // rechercher3ToolStripMenuItem
            // 
            this.rechercher3ToolStripMenuItem.Name = "rechercher3ToolStripMenuItem";
            this.rechercher3ToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.rechercher3ToolStripMenuItem.Text = "Rechercher 3";
            this.rechercher3ToolStripMenuItem.Click += new System.EventHandler(this.rechercher3ToolStripMenuItem_Click);
            // 
            // rechercher4ToolStripMenuItem
            // 
            this.rechercher4ToolStripMenuItem.Name = "rechercher4ToolStripMenuItem";
            this.rechercher4ToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.rechercher4ToolStripMenuItem.Text = "Rechercher 4";
            this.rechercher4ToolStripMenuItem.Click += new System.EventHandler(this.rechercher4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 289);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rechercher1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercher2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercher3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechercher4ToolStripMenuItem;

    }
}


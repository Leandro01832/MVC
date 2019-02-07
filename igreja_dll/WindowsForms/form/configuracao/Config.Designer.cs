namespace igreja2.form.configuracao
{
    partial class Config
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
            this.celulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supervisorEmTreinamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ministerioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.celulaToolStripMenuItem,
            this.supervisorToolStripMenuItem,
            this.supervisorEmTreinamentoToolStripMenuItem,
            this.ministerioToolStripMenuItem,
            this.siteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(906, 36);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // celulaToolStripMenuItem
            // 
            this.celulaToolStripMenuItem.Name = "celulaToolStripMenuItem";
            this.celulaToolStripMenuItem.Size = new System.Drawing.Size(77, 32);
            this.celulaToolStripMenuItem.Text = "Celula";
            this.celulaToolStripMenuItem.Click += new System.EventHandler(this.celulaToolStripMenuItem_Click);
            // 
            // supervisorToolStripMenuItem
            // 
            this.supervisorToolStripMenuItem.Name = "supervisorToolStripMenuItem";
            this.supervisorToolStripMenuItem.Size = new System.Drawing.Size(117, 32);
            this.supervisorToolStripMenuItem.Text = "Supervisor";
            this.supervisorToolStripMenuItem.Click += new System.EventHandler(this.supervisorToolStripMenuItem_Click);
            // 
            // supervisorEmTreinamentoToolStripMenuItem
            // 
            this.supervisorEmTreinamentoToolStripMenuItem.Name = "supervisorEmTreinamentoToolStripMenuItem";
            this.supervisorEmTreinamentoToolStripMenuItem.Size = new System.Drawing.Size(261, 32);
            this.supervisorEmTreinamentoToolStripMenuItem.Text = "Supervisor em treinamento";
            this.supervisorEmTreinamentoToolStripMenuItem.Click += new System.EventHandler(this.supervisorEmTreinamentoToolStripMenuItem_Click);
            // 
            // ministerioToolStripMenuItem
            // 
            this.ministerioToolStripMenuItem.Name = "ministerioToolStripMenuItem";
            this.ministerioToolStripMenuItem.Size = new System.Drawing.Size(112, 32);
            this.ministerioToolStripMenuItem.Text = "Ministerio";
            this.ministerioToolStripMenuItem.Click += new System.EventHandler(this.ministerioToolStripMenuItem_Click);
            // 
            // siteToolStripMenuItem
            // 
            this.siteToolStripMenuItem.Name = "siteToolStripMenuItem";
            this.siteToolStripMenuItem.Size = new System.Drawing.Size(57, 32);
            this.siteToolStripMenuItem.Text = "Site";
            this.siteToolStripMenuItem.Click += new System.EventHandler(this.siteToolStripMenuItem_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 531);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Config";
            this.Text = "Config";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem celulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supervisorEmTreinamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ministerioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siteToolStripMenuItem;
    }
}
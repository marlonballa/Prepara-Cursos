namespace ProgramadorCSharp3._0_PreparaCursos
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cEssencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIntermediárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividadesExtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeDespesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAvançadoIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAvançadoIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cEssencialToolStripMenuItem,
            this.cIntermediárioToolStripMenuItem,
            this.cAvançadoIToolStripMenuItem,
            this.cAvançadoIIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cEssencialToolStripMenuItem
            // 
            this.cEssencialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem});
            this.cEssencialToolStripMenuItem.Name = "cEssencialToolStripMenuItem";
            this.cEssencialToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.cEssencialToolStripMenuItem.Text = "C# Essencial";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            // 
            // cIntermediárioToolStripMenuItem
            // 
            this.cIntermediárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultórioToolStripMenuItem,
            this.atividadesExtrasToolStripMenuItem});
            this.cIntermediárioToolStripMenuItem.Name = "cIntermediárioToolStripMenuItem";
            this.cIntermediárioToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.cIntermediárioToolStripMenuItem.Text = "C# Intermediário";
            // 
            // consultórioToolStripMenuItem
            // 
            this.consultórioToolStripMenuItem.Name = "consultórioToolStripMenuItem";
            this.consultórioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultórioToolStripMenuItem.Text = "Consultório";
            this.consultórioToolStripMenuItem.Click += new System.EventHandler(this.consultórioToolStripMenuItem_Click);
            // 
            // atividadesExtrasToolStripMenuItem
            // 
            this.atividadesExtrasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDeDespesasToolStripMenuItem});
            this.atividadesExtrasToolStripMenuItem.Name = "atividadesExtrasToolStripMenuItem";
            this.atividadesExtrasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atividadesExtrasToolStripMenuItem.Text = "Atividades Extras";
            // 
            // controleDeDespesasToolStripMenuItem
            // 
            this.controleDeDespesasToolStripMenuItem.Name = "controleDeDespesasToolStripMenuItem";
            this.controleDeDespesasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.controleDeDespesasToolStripMenuItem.Text = "Controle de Despesas";
            this.controleDeDespesasToolStripMenuItem.Click += new System.EventHandler(this.controleDeDespesasToolStripMenuItem_Click);
            // 
            // cAvançadoIToolStripMenuItem
            // 
            this.cAvançadoIToolStripMenuItem.Name = "cAvançadoIToolStripMenuItem";
            this.cAvançadoIToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.cAvançadoIToolStripMenuItem.Text = "C# Avançado I";
            // 
            // cAvançadoIIToolStripMenuItem
            // 
            this.cAvançadoIIToolStripMenuItem.Name = "cAvançadoIIToolStripMenuItem";
            this.cAvançadoIIToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.cAvançadoIIToolStripMenuItem.Text = "C# Avançado II";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cEssencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIntermediárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividadesExtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeDespesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAvançadoIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAvançadoIIToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
    }
}


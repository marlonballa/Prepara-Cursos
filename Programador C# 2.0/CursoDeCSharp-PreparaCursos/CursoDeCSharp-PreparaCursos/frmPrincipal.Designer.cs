namespace CursoDeCSharp_PreparaCursos
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cEssencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIntermediárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atividadeExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeDespesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoaFísicaXPessoaJurídicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cEssencialToolStripMenuItem,
            this.cIntermediárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cEssencialToolStripMenuItem
            // 
            this.cEssencialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoaFísicaXPessoaJurídicaToolStripMenuItem});
            this.cEssencialToolStripMenuItem.Name = "cEssencialToolStripMenuItem";
            this.cEssencialToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.cEssencialToolStripMenuItem.Text = "C# Essencial";
            // 
            // cIntermediárioToolStripMenuItem
            // 
            this.cIntermediárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultórioToolStripMenuItem,
            this.atividadeExtraToolStripMenuItem});
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
            // atividadeExtraToolStripMenuItem
            // 
            this.atividadeExtraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDeDespesasToolStripMenuItem});
            this.atividadeExtraToolStripMenuItem.Name = "atividadeExtraToolStripMenuItem";
            this.atividadeExtraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.atividadeExtraToolStripMenuItem.Text = "Atividades Extras";
            // 
            // controleDeDespesasToolStripMenuItem
            // 
            this.controleDeDespesasToolStripMenuItem.Name = "controleDeDespesasToolStripMenuItem";
            this.controleDeDespesasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.controleDeDespesasToolStripMenuItem.Text = "Controle de Despesas";
            this.controleDeDespesasToolStripMenuItem.Click += new System.EventHandler(this.controleDeDespesasToolStripMenuItem_Click);
            // 
            // pessoaFísicaXPessoaJurídicaToolStripMenuItem
            // 
            this.pessoaFísicaXPessoaJurídicaToolStripMenuItem.Name = "pessoaFísicaXPessoaJurídicaToolStripMenuItem";
            this.pessoaFísicaXPessoaJurídicaToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.pessoaFísicaXPessoaJurídicaToolStripMenuItem.Text = "Pessoa Física x Pessoa Jurídica";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso de Programador C# - Projetos Desenvolvidos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cEssencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIntermediárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atividadeExtraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeDespesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoaFísicaXPessoaJurídicaToolStripMenuItem;
    }
}


namespace ProgramadorCSharp3._0_PreparaCursos
{
    partial class frmControleDespesas2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleDespesas2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCadastrarContas = new System.Windows.Forms.ToolStripButton();
            this.btnCadastrarCategorias = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarContas,
            this.btnCadastrarCategorias});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1008, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCadastrarContas
            // 
            this.btnCadastrarContas.Image = global::ProgramadorCSharp3._0_PreparaCursos.Properties.Resources.Contas;
            this.btnCadastrarContas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrarContas.Name = "btnCadastrarContas";
            this.btnCadastrarContas.Size = new System.Drawing.Size(64, 22);
            this.btnCadastrarContas.Text = "Contas";
            // 
            // btnCadastrarCategorias
            // 
            this.btnCadastrarCategorias.Image = global::ProgramadorCSharp3._0_PreparaCursos.Properties.Resources.Categorias;
            this.btnCadastrarCategorias.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrarCategorias.Name = "btnCadastrarCategorias";
            this.btnCadastrarCategorias.Size = new System.Drawing.Size(83, 22);
            this.btnCadastrarCategorias.Text = "Categorias";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(120, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmControleDespesas2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmControleDespesas2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Despesas 2.0";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCadastrarContas;
        private System.Windows.Forms.ToolStripButton btnCadastrarCategorias;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
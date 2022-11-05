namespace ProgramadorCSharp3._0_PreparaCursos
{
    partial class frmControleDeConsultorio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleDeConsultorio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovaConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbPesquisaPorPeriodo = new System.Windows.Forms.GroupBox();
            this.dtpPesquisaConsultasDataInicial = new MetroFramework.Controls.MetroDateTime();
            this.dtpPesquisaConsultasDataFinal = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.gbPesquisaPorMedicoPaciente = new System.Windows.Forms.GroupBox();
            this.rbPesquisarPorMedico = new MetroFramework.Controls.MetroRadioButton();
            this.rbPesquisarPorPaciente = new MetroFramework.Controls.MetroRadioButton();
            this.rbPesquisaPorTelefone = new MetroFramework.Controls.MetroRadioButton();
            this.txtConteudoPesquisa = new MetroFramework.Controls.MetroTextBox();
            this.btnPesquisarConsultas = new MetroFramework.Controls.MetroButton();
            this.gbConsultasDoDia = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_CONSULTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CONSULTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO_CONSULTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.gbPesquisaPorPeriodo.SuspendLayout();
            this.gbPesquisaPorMedicoPaciente.SuspendLayout();
            this.gbConsultasDoDia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoMédicoToolStripMenuItem,
            this.cadastrarNovoPacienteToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastrarNovoMédicoToolStripMenuItem
            // 
            this.cadastrarNovoMédicoToolStripMenuItem.Name = "cadastrarNovoMédicoToolStripMenuItem";
            this.cadastrarNovoMédicoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cadastrarNovoMédicoToolStripMenuItem.Text = "Cadastrar Novo Médico";
            this.cadastrarNovoMédicoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoMédicoToolStripMenuItem_Click);
            // 
            // cadastrarNovoPacienteToolStripMenuItem
            // 
            this.cadastrarNovoPacienteToolStripMenuItem.Name = "cadastrarNovoPacienteToolStripMenuItem";
            this.cadastrarNovoPacienteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cadastrarNovoPacienteToolStripMenuItem.Text = "Cadastrar Novo Paciente";
            this.cadastrarNovoPacienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoPacienteToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovaConsultaToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // cadastrarNovaConsultaToolStripMenuItem
            // 
            this.cadastrarNovaConsultaToolStripMenuItem.Name = "cadastrarNovaConsultaToolStripMenuItem";
            this.cadastrarNovaConsultaToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cadastrarNovaConsultaToolStripMenuItem.Text = "Cadastrar Nova Consulta";
            this.cadastrarNovaConsultaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovaConsultaToolStripMenuItem_Click);
            // 
            // gbPesquisaPorPeriodo
            // 
            this.gbPesquisaPorPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.gbPesquisaPorPeriodo.Controls.Add(this.metroLabel2);
            this.gbPesquisaPorPeriodo.Controls.Add(this.metroLabel1);
            this.gbPesquisaPorPeriodo.Controls.Add(this.dtpPesquisaConsultasDataFinal);
            this.gbPesquisaPorPeriodo.Controls.Add(this.dtpPesquisaConsultasDataInicial);
            this.gbPesquisaPorPeriodo.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisaPorPeriodo.Location = new System.Drawing.Point(153, 27);
            this.gbPesquisaPorPeriodo.Name = "gbPesquisaPorPeriodo";
            this.gbPesquisaPorPeriodo.Size = new System.Drawing.Size(244, 100);
            this.gbPesquisaPorPeriodo.TabIndex = 3;
            this.gbPesquisaPorPeriodo.TabStop = false;
            this.gbPesquisaPorPeriodo.Text = "Pesquisa por período:";
            // 
            // dtpPesquisaConsultasDataInicial
            // 
            this.dtpPesquisaConsultasDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPesquisaConsultasDataInicial.Location = new System.Drawing.Point(95, 24);
            this.dtpPesquisaConsultasDataInicial.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpPesquisaConsultasDataInicial.Name = "dtpPesquisaConsultasDataInicial";
            this.dtpPesquisaConsultasDataInicial.Size = new System.Drawing.Size(131, 29);
            this.dtpPesquisaConsultasDataInicial.TabIndex = 0;
            // 
            // dtpPesquisaConsultasDataFinal
            // 
            this.dtpPesquisaConsultasDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPesquisaConsultasDataFinal.Location = new System.Drawing.Point(95, 60);
            this.dtpPesquisaConsultasDataFinal.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpPesquisaConsultasDataFinal.Name = "dtpPesquisaConsultasDataFinal";
            this.dtpPesquisaConsultasDataFinal.Size = new System.Drawing.Size(131, 29);
            this.dtpPesquisaConsultasDataFinal.TabIndex = 1;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Data inicial:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 65);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Data Final:";
            // 
            // gbPesquisaPorMedicoPaciente
            // 
            this.gbPesquisaPorMedicoPaciente.BackColor = System.Drawing.Color.Transparent;
            this.gbPesquisaPorMedicoPaciente.Controls.Add(this.btnPesquisarConsultas);
            this.gbPesquisaPorMedicoPaciente.Controls.Add(this.txtConteudoPesquisa);
            this.gbPesquisaPorMedicoPaciente.Controls.Add(this.rbPesquisaPorTelefone);
            this.gbPesquisaPorMedicoPaciente.Controls.Add(this.rbPesquisarPorPaciente);
            this.gbPesquisaPorMedicoPaciente.Controls.Add(this.rbPesquisarPorMedico);
            this.gbPesquisaPorMedicoPaciente.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbPesquisaPorMedicoPaciente.Location = new System.Drawing.Point(403, 27);
            this.gbPesquisaPorMedicoPaciente.Name = "gbPesquisaPorMedicoPaciente";
            this.gbPesquisaPorMedicoPaciente.Size = new System.Drawing.Size(244, 100);
            this.gbPesquisaPorMedicoPaciente.TabIndex = 3;
            this.gbPesquisaPorMedicoPaciente.TabStop = false;
            this.gbPesquisaPorMedicoPaciente.Text = "Pesquisa Avançada:";
            // 
            // rbPesquisarPorMedico
            // 
            this.rbPesquisarPorMedico.AutoSize = true;
            this.rbPesquisarPorMedico.Location = new System.Drawing.Point(12, 24);
            this.rbPesquisarPorMedico.Name = "rbPesquisarPorMedico";
            this.rbPesquisarPorMedico.Size = new System.Drawing.Size(66, 15);
            this.rbPesquisarPorMedico.TabIndex = 0;
            this.rbPesquisarPorMedico.Text = "Médico:";
            this.rbPesquisarPorMedico.UseSelectable = true;
            // 
            // rbPesquisarPorPaciente
            // 
            this.rbPesquisarPorPaciente.AutoSize = true;
            this.rbPesquisarPorPaciente.Location = new System.Drawing.Point(84, 24);
            this.rbPesquisarPorPaciente.Name = "rbPesquisarPorPaciente";
            this.rbPesquisarPorPaciente.Size = new System.Drawing.Size(71, 15);
            this.rbPesquisarPorPaciente.TabIndex = 0;
            this.rbPesquisarPorPaciente.Text = "Paciente:";
            this.rbPesquisarPorPaciente.UseSelectable = true;
            // 
            // rbPesquisaPorTelefone
            // 
            this.rbPesquisaPorTelefone.AutoSize = true;
            this.rbPesquisaPorTelefone.Location = new System.Drawing.Point(161, 24);
            this.rbPesquisaPorTelefone.Name = "rbPesquisaPorTelefone";
            this.rbPesquisaPorTelefone.Size = new System.Drawing.Size(70, 15);
            this.rbPesquisaPorTelefone.TabIndex = 0;
            this.rbPesquisaPorTelefone.Text = "Telefone:";
            this.rbPesquisaPorTelefone.UseSelectable = true;
            // 
            // txtConteudoPesquisa
            // 
            // 
            // 
            // 
            this.txtConteudoPesquisa.CustomButton.Image = null;
            this.txtConteudoPesquisa.CustomButton.Location = new System.Drawing.Point(210, 1);
            this.txtConteudoPesquisa.CustomButton.Name = "";
            this.txtConteudoPesquisa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConteudoPesquisa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConteudoPesquisa.CustomButton.TabIndex = 1;
            this.txtConteudoPesquisa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConteudoPesquisa.CustomButton.UseSelectable = true;
            this.txtConteudoPesquisa.CustomButton.Visible = false;
            this.txtConteudoPesquisa.Lines = new string[0];
            this.txtConteudoPesquisa.Location = new System.Drawing.Point(6, 45);
            this.txtConteudoPesquisa.MaxLength = 32767;
            this.txtConteudoPesquisa.Name = "txtConteudoPesquisa";
            this.txtConteudoPesquisa.PasswordChar = '\0';
            this.txtConteudoPesquisa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConteudoPesquisa.SelectedText = "";
            this.txtConteudoPesquisa.SelectionLength = 0;
            this.txtConteudoPesquisa.SelectionStart = 0;
            this.txtConteudoPesquisa.ShortcutsEnabled = true;
            this.txtConteudoPesquisa.Size = new System.Drawing.Size(232, 23);
            this.txtConteudoPesquisa.TabIndex = 1;
            this.txtConteudoPesquisa.UseSelectable = true;
            this.txtConteudoPesquisa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConteudoPesquisa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnPesquisarConsultas
            // 
            this.btnPesquisarConsultas.Location = new System.Drawing.Point(85, 71);
            this.btnPesquisarConsultas.Name = "btnPesquisarConsultas";
            this.btnPesquisarConsultas.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarConsultas.Style = MetroFramework.MetroColorStyle.Black;
            this.btnPesquisarConsultas.TabIndex = 2;
            this.btnPesquisarConsultas.Text = "Pesquisar";
            this.btnPesquisarConsultas.UseSelectable = true;
            this.btnPesquisarConsultas.UseStyleColors = true;
            // 
            // gbConsultasDoDia
            // 
            this.gbConsultasDoDia.Controls.Add(this.metroLabel3);
            this.gbConsultasDoDia.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsultasDoDia.Location = new System.Drawing.Point(653, 27);
            this.gbConsultasDoDia.Name = "gbConsultasDoDia";
            this.gbConsultasDoDia.Size = new System.Drawing.Size(200, 100);
            this.gbConsultasDoDia.TabIndex = 4;
            this.gbConsultasDoDia.TabStop = false;
            this.gbConsultasDoDia.Text = "Consultas do Dia";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(14, 35);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(174, 30);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Para exibir as \"Consultas do DIa\",\r\nbasta clicar sobre este groupbox.";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_CONSULTA,
            this.NOME_PACIENTE,
            this.NOME_MEDICO,
            this.DATA_CONSULTA,
            this.HORARIO_CONSULTA});
            this.dataGridView1.Location = new System.Drawing.Point(12, 165);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(984, 360);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ID_CONSULTA
            // 
            this.ID_CONSULTA.DataPropertyName = "ID_CONSULTA";
            this.ID_CONSULTA.HeaderText = "Código:";
            this.ID_CONSULTA.Name = "ID_CONSULTA";
            this.ID_CONSULTA.ReadOnly = true;
            this.ID_CONSULTA.Width = 95;
            // 
            // NOME_PACIENTE
            // 
            this.NOME_PACIENTE.DataPropertyName = "NOME_PACIENTE";
            this.NOME_PACIENTE.HeaderText = "Nome do Paciente:";
            this.NOME_PACIENTE.Name = "NOME_PACIENTE";
            this.NOME_PACIENTE.ReadOnly = true;
            this.NOME_PACIENTE.Width = 350;
            // 
            // NOME_MEDICO
            // 
            this.NOME_MEDICO.DataPropertyName = "NOME_MEDICO";
            this.NOME_MEDICO.HeaderText = "Nome do Médico:";
            this.NOME_MEDICO.Name = "NOME_MEDICO";
            this.NOME_MEDICO.ReadOnly = true;
            this.NOME_MEDICO.Width = 350;
            // 
            // DATA_CONSULTA
            // 
            this.DATA_CONSULTA.DataPropertyName = "DATA";
            this.DATA_CONSULTA.HeaderText = "Data:";
            this.DATA_CONSULTA.Name = "DATA_CONSULTA";
            this.DATA_CONSULTA.ReadOnly = true;
            this.DATA_CONSULTA.Width = 95;
            // 
            // HORARIO_CONSULTA
            // 
            this.HORARIO_CONSULTA.DataPropertyName = "HORARIO";
            this.HORARIO_CONSULTA.HeaderText = "Horário:";
            this.HORARIO_CONSULTA.Name = "HORARIO_CONSULTA";
            this.HORARIO_CONSULTA.ReadOnly = true;
            this.HORARIO_CONSULTA.Width = 94;
            // 
            // frmControleDeConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gbConsultasDoDia);
            this.Controls.Add(this.gbPesquisaPorMedicoPaciente);
            this.Controls.Add(this.gbPesquisaPorPeriodo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmControleDeConsultorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Consultório";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbPesquisaPorPeriodo.ResumeLayout(false);
            this.gbPesquisaPorPeriodo.PerformLayout();
            this.gbPesquisaPorMedicoPaciente.ResumeLayout(false);
            this.gbPesquisaPorMedicoPaciente.PerformLayout();
            this.gbConsultasDoDia.ResumeLayout(false);
            this.gbConsultasDoDia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovaConsultaToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbPesquisaPorPeriodo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtpPesquisaConsultasDataFinal;
        private MetroFramework.Controls.MetroDateTime dtpPesquisaConsultasDataInicial;
        private System.Windows.Forms.GroupBox gbPesquisaPorMedicoPaciente;
        private MetroFramework.Controls.MetroButton btnPesquisarConsultas;
        private MetroFramework.Controls.MetroTextBox txtConteudoPesquisa;
        private MetroFramework.Controls.MetroRadioButton rbPesquisaPorTelefone;
        private MetroFramework.Controls.MetroRadioButton rbPesquisarPorPaciente;
        private MetroFramework.Controls.MetroRadioButton rbPesquisarPorMedico;
        private System.Windows.Forms.GroupBox gbConsultasDoDia;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_CONSULTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_MEDICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CONSULTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO_CONSULTA;
    }
}
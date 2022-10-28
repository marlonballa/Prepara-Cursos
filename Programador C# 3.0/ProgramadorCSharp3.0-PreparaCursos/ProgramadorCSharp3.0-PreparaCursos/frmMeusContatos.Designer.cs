namespace ProgramadorCSharp3._0_PreparaCursos
{
    partial class frmMeusContatos
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
            System.Windows.Forms.Label lblIdentificadorContato;
            System.Windows.Forms.Label lblNomeContato;
            System.Windows.Forms.Label lblTelefoneContato;
            System.Windows.Forms.Label lblAniversario;
            System.Windows.Forms.Label e_DA_FAMILIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeusContatos));
            this.agendaDeContatosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agendaDeContatosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdentificadorContato = new System.Windows.Forms.TextBox();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.txtTelefoneContato = new System.Windows.Forms.MaskedTextBox();
            this.dtpAniversarioContato = new System.Windows.Forms.DateTimePicker();
            this.cbEDaFamilia = new System.Windows.Forms.CheckBox();
            this.gbCadastrarNovoContato = new System.Windows.Forms.GroupBox();
            this.gbPesquisarContatos = new System.Windows.Forms.GroupBox();
            this.btnPesquisarEmContatos = new MetroFramework.Controls.MetroButton();
            this.txtInformacaoDePesquisaDeContato = new MetroFramework.Controls.MetroTextBox();
            this.rbPesquisarTelefoneContato = new MetroFramework.Controls.MetroRadioButton();
            this.rbPesquisarNomeContato = new MetroFramework.Controls.MetroRadioButton();
            this.dgvAgendaContatos = new System.Windows.Forms.DataGridView();
            this.lblShowAllContacts = new MetroFramework.Controls.MetroLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.agendaDeContatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaContatosMB = new ProgramadorCSharp3._0_PreparaCursos.AgendaContatosMB();
            this.agendaDeContatosTableAdapter = new ProgramadorCSharp3._0_PreparaCursos.AgendaContatosMBTableAdapters.AgendaDeContatosTableAdapter();
            this.tableAdapterManager = new ProgramadorCSharp3._0_PreparaCursos.AgendaContatosMBTableAdapters.TableAdapterManager();
            lblIdentificadorContato = new System.Windows.Forms.Label();
            lblNomeContato = new System.Windows.Forms.Label();
            lblTelefoneContato = new System.Windows.Forms.Label();
            lblAniversario = new System.Windows.Forms.Label();
            e_DA_FAMILIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDeContatosBindingNavigator)).BeginInit();
            this.agendaDeContatosBindingNavigator.SuspendLayout();
            this.gbCadastrarNovoContato.SuspendLayout();
            this.gbPesquisarContatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaContatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDeContatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaContatosMB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdentificadorContato
            // 
            lblIdentificadorContato.AutoSize = true;
            lblIdentificadorContato.Location = new System.Drawing.Point(6, 24);
            lblIdentificadorContato.Name = "lblIdentificadorContato";
            lblIdentificadorContato.Size = new System.Drawing.Size(65, 13);
            lblIdentificadorContato.TabIndex = 1;
            lblIdentificadorContato.Text = "Identificador";
            // 
            // lblNomeContato
            // 
            lblNomeContato.AutoSize = true;
            lblNomeContato.Location = new System.Drawing.Point(80, 24);
            lblNomeContato.Name = "lblNomeContato";
            lblNomeContato.Size = new System.Drawing.Size(90, 13);
            lblNomeContato.TabIndex = 3;
            lblNomeContato.Text = "Nome do Contato";
            // 
            // lblTelefoneContato
            // 
            lblTelefoneContato.AutoSize = true;
            lblTelefoneContato.Location = new System.Drawing.Point(629, 24);
            lblTelefoneContato.Name = "lblTelefoneContato";
            lblTelefoneContato.Size = new System.Drawing.Size(52, 13);
            lblTelefoneContato.TabIndex = 5;
            lblTelefoneContato.Text = "Telefone:";
            // 
            // lblAniversario
            // 
            lblAniversario.AutoSize = true;
            lblAniversario.Location = new System.Drawing.Point(786, 24);
            lblAniversario.Name = "lblAniversario";
            lblAniversario.Size = new System.Drawing.Size(59, 13);
            lblAniversario.TabIndex = 7;
            lblAniversario.Text = "Aniversário";
            // 
            // e_DA_FAMILIALabel
            // 
            e_DA_FAMILIALabel.AutoSize = true;
            e_DA_FAMILIALabel.Location = new System.Drawing.Point(892, 24);
            e_DA_FAMILIALabel.Name = "e_DA_FAMILIALabel";
            e_DA_FAMILIALabel.Size = new System.Drawing.Size(72, 13);
            e_DA_FAMILIALabel.TabIndex = 9;
            e_DA_FAMILIALabel.Text = "É da Família?";
            // 
            // agendaDeContatosBindingNavigator
            // 
            this.agendaDeContatosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agendaDeContatosBindingNavigator.BindingSource = this.agendaDeContatosBindingSource;
            this.agendaDeContatosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agendaDeContatosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.agendaDeContatosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.agendaDeContatosBindingNavigatorSaveItem});
            this.agendaDeContatosBindingNavigator.Location = new System.Drawing.Point(20, 60);
            this.agendaDeContatosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agendaDeContatosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agendaDeContatosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agendaDeContatosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agendaDeContatosBindingNavigator.Name = "agendaDeContatosBindingNavigator";
            this.agendaDeContatosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agendaDeContatosBindingNavigator.Size = new System.Drawing.Size(968, 25);
            this.agendaDeContatosBindingNavigator.TabIndex = 0;
            this.agendaDeContatosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // agendaDeContatosBindingNavigatorSaveItem
            // 
            this.agendaDeContatosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agendaDeContatosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agendaDeContatosBindingNavigatorSaveItem.Image")));
            this.agendaDeContatosBindingNavigatorSaveItem.Name = "agendaDeContatosBindingNavigatorSaveItem";
            this.agendaDeContatosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agendaDeContatosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.agendaDeContatosBindingNavigatorSaveItem.Click += new System.EventHandler(this.agendaDeContatosBindingNavigatorSaveItem_Click);
            // 
            // txtIdentificadorContato
            // 
            this.txtIdentificadorContato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaDeContatosBindingSource, "ID_CONTATO", true));
            this.txtIdentificadorContato.Enabled = false;
            this.txtIdentificadorContato.Location = new System.Drawing.Point(6, 40);
            this.txtIdentificadorContato.Name = "txtIdentificadorContato";
            this.txtIdentificadorContato.Size = new System.Drawing.Size(65, 20);
            this.txtIdentificadorContato.TabIndex = 2;
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaDeContatosBindingSource, "NOME_CONTATO", true));
            this.txtNomeContato.Location = new System.Drawing.Point(83, 40);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(543, 20);
            this.txtNomeContato.TabIndex = 4;
            // 
            // txtTelefoneContato
            // 
            this.txtTelefoneContato.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaDeContatosBindingSource, "TELEFONE_CONTATO", true));
            this.txtTelefoneContato.Location = new System.Drawing.Point(632, 40);
            this.txtTelefoneContato.Name = "txtTelefoneContato";
            this.txtTelefoneContato.Size = new System.Drawing.Size(151, 20);
            this.txtTelefoneContato.TabIndex = 6;
            // 
            // dtpAniversarioContato
            // 
            this.dtpAniversarioContato.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agendaDeContatosBindingSource, "ANIVERSARIO_CONTATO", true));
            this.dtpAniversarioContato.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAniversarioContato.Location = new System.Drawing.Point(789, 40);
            this.dtpAniversarioContato.Name = "dtpAniversarioContato";
            this.dtpAniversarioContato.Size = new System.Drawing.Size(104, 20);
            this.dtpAniversarioContato.TabIndex = 8;
            // 
            // cbEDaFamilia
            // 
            this.cbEDaFamilia.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.agendaDeContatosBindingSource, "E_DA_FAMILIA", true));
            this.cbEDaFamilia.Location = new System.Drawing.Point(897, 39);
            this.cbEDaFamilia.Name = "cbEDaFamilia";
            this.cbEDaFamilia.Size = new System.Drawing.Size(45, 24);
            this.cbEDaFamilia.TabIndex = 10;
            this.cbEDaFamilia.Text = "SIM";
            this.cbEDaFamilia.UseVisualStyleBackColor = true;
            // 
            // gbCadastrarNovoContato
            // 
            this.gbCadastrarNovoContato.Controls.Add(lblNomeContato);
            this.gbCadastrarNovoContato.Controls.Add(lblIdentificadorContato);
            this.gbCadastrarNovoContato.Controls.Add(this.cbEDaFamilia);
            this.gbCadastrarNovoContato.Controls.Add(this.txtIdentificadorContato);
            this.gbCadastrarNovoContato.Controls.Add(e_DA_FAMILIALabel);
            this.gbCadastrarNovoContato.Controls.Add(this.dtpAniversarioContato);
            this.gbCadastrarNovoContato.Controls.Add(this.txtNomeContato);
            this.gbCadastrarNovoContato.Controls.Add(lblAniversario);
            this.gbCadastrarNovoContato.Controls.Add(lblTelefoneContato);
            this.gbCadastrarNovoContato.Controls.Add(this.txtTelefoneContato);
            this.gbCadastrarNovoContato.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCadastrarNovoContato.Location = new System.Drawing.Point(20, 85);
            this.gbCadastrarNovoContato.Name = "gbCadastrarNovoContato";
            this.gbCadastrarNovoContato.Size = new System.Drawing.Size(968, 84);
            this.gbCadastrarNovoContato.TabIndex = 11;
            this.gbCadastrarNovoContato.TabStop = false;
            this.gbCadastrarNovoContato.Text = "Cadastrar Novo Contato";
            // 
            // gbPesquisarContatos
            // 
            this.gbPesquisarContatos.Controls.Add(this.btnPesquisarEmContatos);
            this.gbPesquisarContatos.Controls.Add(this.txtInformacaoDePesquisaDeContato);
            this.gbPesquisarContatos.Controls.Add(this.rbPesquisarTelefoneContato);
            this.gbPesquisarContatos.Controls.Add(this.rbPesquisarNomeContato);
            this.gbPesquisarContatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPesquisarContatos.Location = new System.Drawing.Point(20, 169);
            this.gbPesquisarContatos.Name = "gbPesquisarContatos";
            this.gbPesquisarContatos.Size = new System.Drawing.Size(968, 85);
            this.gbPesquisarContatos.TabIndex = 12;
            this.gbPesquisarContatos.TabStop = false;
            this.gbPesquisarContatos.Text = "Pesquisar Contatos";
            // 
            // btnPesquisarEmContatos
            // 
            this.btnPesquisarEmContatos.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPesquisarEmContatos.Location = new System.Drawing.Point(835, 40);
            this.btnPesquisarEmContatos.Name = "btnPesquisarEmContatos";
            this.btnPesquisarEmContatos.Size = new System.Drawing.Size(127, 23);
            this.btnPesquisarEmContatos.TabIndex = 2;
            this.btnPesquisarEmContatos.Text = "Pesquisar";
            this.btnPesquisarEmContatos.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnPesquisarEmContatos.UseSelectable = true;
            this.btnPesquisarEmContatos.Click += new System.EventHandler(this.btnPesquisarEmContatos_Click);
            // 
            // txtInformacaoDePesquisaDeContato
            // 
            // 
            // 
            // 
            this.txtInformacaoDePesquisaDeContato.CustomButton.Image = null;
            this.txtInformacaoDePesquisaDeContato.CustomButton.Location = new System.Drawing.Point(798, 1);
            this.txtInformacaoDePesquisaDeContato.CustomButton.Name = "";
            this.txtInformacaoDePesquisaDeContato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInformacaoDePesquisaDeContato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInformacaoDePesquisaDeContato.CustomButton.TabIndex = 1;
            this.txtInformacaoDePesquisaDeContato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInformacaoDePesquisaDeContato.CustomButton.UseSelectable = true;
            this.txtInformacaoDePesquisaDeContato.CustomButton.Visible = false;
            this.txtInformacaoDePesquisaDeContato.Lines = new string[0];
            this.txtInformacaoDePesquisaDeContato.Location = new System.Drawing.Point(9, 40);
            this.txtInformacaoDePesquisaDeContato.MaxLength = 32767;
            this.txtInformacaoDePesquisaDeContato.Name = "txtInformacaoDePesquisaDeContato";
            this.txtInformacaoDePesquisaDeContato.PasswordChar = '\0';
            this.txtInformacaoDePesquisaDeContato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInformacaoDePesquisaDeContato.SelectedText = "";
            this.txtInformacaoDePesquisaDeContato.SelectionLength = 0;
            this.txtInformacaoDePesquisaDeContato.SelectionStart = 0;
            this.txtInformacaoDePesquisaDeContato.ShortcutsEnabled = true;
            this.txtInformacaoDePesquisaDeContato.Size = new System.Drawing.Size(820, 23);
            this.txtInformacaoDePesquisaDeContato.TabIndex = 1;
            this.txtInformacaoDePesquisaDeContato.UseSelectable = true;
            this.txtInformacaoDePesquisaDeContato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInformacaoDePesquisaDeContato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rbPesquisarTelefoneContato
            // 
            this.rbPesquisarTelefoneContato.AutoSize = true;
            this.rbPesquisarTelefoneContato.Location = new System.Drawing.Point(134, 19);
            this.rbPesquisarTelefoneContato.Name = "rbPesquisarTelefoneContato";
            this.rbPesquisarTelefoneContato.Size = new System.Drawing.Size(130, 15);
            this.rbPesquisarTelefoneContato.TabIndex = 0;
            this.rbPesquisarTelefoneContato.Text = "Telefone do Contato";
            this.rbPesquisarTelefoneContato.UseSelectable = true;
            // 
            // rbPesquisarNomeContato
            // 
            this.rbPesquisarNomeContato.AutoSize = true;
            this.rbPesquisarNomeContato.Location = new System.Drawing.Point(9, 19);
            this.rbPesquisarNomeContato.Name = "rbPesquisarNomeContato";
            this.rbPesquisarNomeContato.Size = new System.Drawing.Size(119, 15);
            this.rbPesquisarNomeContato.TabIndex = 0;
            this.rbPesquisarNomeContato.Text = "Nome do Contato";
            this.rbPesquisarNomeContato.UseSelectable = true;
            // 
            // dgvAgendaContatos
            // 
            this.dgvAgendaContatos.AllowUserToAddRows = false;
            this.dgvAgendaContatos.AllowUserToDeleteRows = false;
            this.dgvAgendaContatos.AutoGenerateColumns = false;
            this.dgvAgendaContatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgendaContatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1});
            this.dgvAgendaContatos.DataSource = this.agendaDeContatosBindingSource;
            this.dgvAgendaContatos.Location = new System.Drawing.Point(20, 278);
            this.dgvAgendaContatos.Name = "dgvAgendaContatos";
            this.dgvAgendaContatos.RowHeadersVisible = false;
            this.dgvAgendaContatos.Size = new System.Drawing.Size(968, 293);
            this.dgvAgendaContatos.TabIndex = 12;
            // 
            // lblShowAllContacts
            // 
            this.lblShowAllContacts.AutoSize = true;
            this.lblShowAllContacts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblShowAllContacts.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblShowAllContacts.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblShowAllContacts.Location = new System.Drawing.Point(822, 256);
            this.lblShowAllContacts.Name = "lblShowAllContacts";
            this.lblShowAllContacts.Size = new System.Drawing.Size(166, 19);
            this.lblShowAllContacts.TabIndex = 11;
            this.lblShowAllContacts.Text = "Mostrar Todos os Contatos";
            this.lblShowAllContacts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblShowAllContacts.Click += new System.EventHandler(this.lblShowAllContacts_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CONTATO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identificador:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_CONTATO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Contato:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TELEFONE_CONTATO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 173;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ANIVERSARIO_CONTATO";
            this.dataGridViewTextBoxColumn4.HeaderText = "Aniversário:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "E_DA_FAMILIA";
            this.dataGridViewCheckBoxColumn1.HeaderText = "É da Família?";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // agendaDeContatosBindingSource
            // 
            this.agendaDeContatosBindingSource.DataMember = "AgendaDeContatos";
            this.agendaDeContatosBindingSource.DataSource = this.agendaContatosMB;
            // 
            // agendaContatosMB
            // 
            this.agendaContatosMB.DataSetName = "AgendaContatosMB";
            this.agendaContatosMB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaDeContatosTableAdapter
            // 
            this.agendaDeContatosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendaDeContatosTableAdapter = this.agendaDeContatosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ProgramadorCSharp3._0_PreparaCursos.AgendaContatosMBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmMeusContatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1008, 580);
            this.Controls.Add(this.lblShowAllContacts);
            this.Controls.Add(this.dgvAgendaContatos);
            this.Controls.Add(this.gbPesquisarContatos);
            this.Controls.Add(this.gbCadastrarNovoContato);
            this.Controls.Add(this.agendaDeContatosBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMeusContatos";
            this.Text = "Meus Contatos - Agenda";
            this.Load += new System.EventHandler(this.frmMeusContatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendaDeContatosBindingNavigator)).EndInit();
            this.agendaDeContatosBindingNavigator.ResumeLayout(false);
            this.agendaDeContatosBindingNavigator.PerformLayout();
            this.gbCadastrarNovoContato.ResumeLayout(false);
            this.gbCadastrarNovoContato.PerformLayout();
            this.gbPesquisarContatos.ResumeLayout(false);
            this.gbPesquisarContatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgendaContatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDeContatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaContatosMB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AgendaContatosMB agendaContatosMB;
        private System.Windows.Forms.BindingSource agendaDeContatosBindingSource;
        private AgendaContatosMBTableAdapters.AgendaDeContatosTableAdapter agendaDeContatosTableAdapter;
        private AgendaContatosMBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agendaDeContatosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton agendaDeContatosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtIdentificadorContato;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.MaskedTextBox txtTelefoneContato;
        private System.Windows.Forms.DateTimePicker dtpAniversarioContato;
        private System.Windows.Forms.CheckBox cbEDaFamilia;
        private System.Windows.Forms.GroupBox gbCadastrarNovoContato;
        private System.Windows.Forms.GroupBox gbPesquisarContatos;
        private MetroFramework.Controls.MetroTextBox txtInformacaoDePesquisaDeContato;
        private MetroFramework.Controls.MetroRadioButton rbPesquisarTelefoneContato;
        private MetroFramework.Controls.MetroRadioButton rbPesquisarNomeContato;
        private MetroFramework.Controls.MetroButton btnPesquisarEmContatos;
        private System.Windows.Forms.DataGridView dgvAgendaContatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private MetroFramework.Controls.MetroLabel lblShowAllContacts;
    }
}
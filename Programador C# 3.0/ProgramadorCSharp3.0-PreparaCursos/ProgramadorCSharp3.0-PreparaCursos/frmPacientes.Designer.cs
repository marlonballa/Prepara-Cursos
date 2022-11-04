namespace ProgramadorCSharp3._0_PreparaCursos
{
    partial class frmPacientes
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
            System.Windows.Forms.Label lblIdentificadorPaciente;
            System.Windows.Forms.Label lblNomePaciente;
            System.Windows.Forms.Label lblEnderecoPaciente;
            System.Windows.Forms.Label lblNumeroEnderecoPaciente;
            System.Windows.Forms.Label lblBairroEnderecoPaciente;
            System.Windows.Forms.Label lblCidadePaciente;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label lblSexoPaciente;
            System.Windows.Forms.Label cELULARLabel;
            System.Windows.Forms.Label tELEFONE_CONTATOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPacientes));
            this.controleDeConsultorioMB = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMB();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.PacienteTableAdapter();
            this.tableAdapterManager = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.TableAdapterManager();
            this.pacienteBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.pacienteBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnFecharCadastroPaciente = new System.Windows.Forms.ToolStripButton();
            this.txtIdentificadorPaciente = new System.Windows.Forms.TextBox();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtEnderecoPaciente = new System.Windows.Forms.TextBox();
            this.txtNumeroEnderecoPaciente = new System.Windows.Forms.TextBox();
            this.txtBairroPaciente = new System.Windows.Forms.TextBox();
            this.txtCidadePaciente = new System.Windows.Forms.TextBox();
            this.cbSexoPaciente = new System.Windows.Forms.ComboBox();
            this.cELULARMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tELEFONE_CONTATOMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gbCadastrarNovoPaciente = new System.Windows.Forms.GroupBox();
            this.txtCEPPaciente = new System.Windows.Forms.TextBox();
            this.btnInserirDadosCEP = new System.Windows.Forms.PictureBox();
            this.tpComoDigitarCep = new System.Windows.Forms.ToolTip(this.components);
            this.gbPesquisarPacientes = new System.Windows.Forms.GroupBox();
            this.pacienteDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblIdentificadorPaciente = new System.Windows.Forms.Label();
            lblNomePaciente = new System.Windows.Forms.Label();
            lblEnderecoPaciente = new System.Windows.Forms.Label();
            lblNumeroEnderecoPaciente = new System.Windows.Forms.Label();
            lblBairroEnderecoPaciente = new System.Windows.Forms.Label();
            lblCidadePaciente = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            lblSexoPaciente = new System.Windows.Forms.Label();
            cELULARLabel = new System.Windows.Forms.Label();
            tELEFONE_CONTATOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeConsultorioMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).BeginInit();
            this.pacienteBindingNavigator.SuspendLayout();
            this.gbCadastrarNovoPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserirDadosCEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdentificadorPaciente
            // 
            lblIdentificadorPaciente.AutoSize = true;
            lblIdentificadorPaciente.Location = new System.Drawing.Point(4, 22);
            lblIdentificadorPaciente.Name = "lblIdentificadorPaciente";
            lblIdentificadorPaciente.Size = new System.Drawing.Size(65, 13);
            lblIdentificadorPaciente.TabIndex = 1;
            lblIdentificadorPaciente.Text = "Identificador";
            // 
            // lblNomePaciente
            // 
            lblNomePaciente.AutoSize = true;
            lblNomePaciente.Location = new System.Drawing.Point(83, 22);
            lblNomePaciente.Name = "lblNomePaciente";
            lblNomePaciente.Size = new System.Drawing.Size(98, 13);
            lblNomePaciente.TabIndex = 3;
            lblNomePaciente.Text = "Nome do Paciente:";
            // 
            // lblEnderecoPaciente
            // 
            lblEnderecoPaciente.AutoSize = true;
            lblEnderecoPaciente.Location = new System.Drawing.Point(83, 63);
            lblEnderecoPaciente.Name = "lblEnderecoPaciente";
            lblEnderecoPaciente.Size = new System.Drawing.Size(113, 13);
            lblEnderecoPaciente.TabIndex = 5;
            lblEnderecoPaciente.Text = "Endereço do Paciente";
            // 
            // lblNumeroEnderecoPaciente
            // 
            lblNumeroEnderecoPaciente.AutoSize = true;
            lblNumeroEnderecoPaciente.Location = new System.Drawing.Point(568, 63);
            lblNumeroEnderecoPaciente.Name = "lblNumeroEnderecoPaciente";
            lblNumeroEnderecoPaciente.Size = new System.Drawing.Size(47, 13);
            lblNumeroEnderecoPaciente.TabIndex = 7;
            lblNumeroEnderecoPaciente.Text = "Número:";
            // 
            // lblBairroEnderecoPaciente
            // 
            lblBairroEnderecoPaciente.AutoSize = true;
            lblBairroEnderecoPaciente.Location = new System.Drawing.Point(617, 63);
            lblBairroEnderecoPaciente.Name = "lblBairroEnderecoPaciente";
            lblBairroEnderecoPaciente.Size = new System.Drawing.Size(37, 13);
            lblBairroEnderecoPaciente.TabIndex = 9;
            lblBairroEnderecoPaciente.Text = "Bairro:";
            // 
            // lblCidadePaciente
            // 
            lblCidadePaciente.AutoSize = true;
            lblCidadePaciente.Location = new System.Drawing.Point(779, 63);
            lblCidadePaciente.Name = "lblCidadePaciente";
            lblCidadePaciente.Size = new System.Drawing.Size(43, 13);
            lblCidadePaciente.TabIndex = 11;
            lblCidadePaciente.Text = "Cidade:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(3, 63);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(31, 13);
            cEPLabel.TabIndex = 13;
            cEPLabel.Text = "CEP:";
            // 
            // lblSexoPaciente
            // 
            lblSexoPaciente.AutoSize = true;
            lblSexoPaciente.Location = new System.Drawing.Point(568, 22);
            lblSexoPaciente.Name = "lblSexoPaciente";
            lblSexoPaciente.Size = new System.Drawing.Size(45, 13);
            lblSexoPaciente.TabIndex = 15;
            lblSexoPaciente.Text = "Gênero:";
            // 
            // cELULARLabel
            // 
            cELULARLabel.AutoSize = true;
            cELULARLabel.Location = new System.Drawing.Point(695, 22);
            cELULARLabel.Name = "cELULARLabel";
            cELULARLabel.Size = new System.Drawing.Size(42, 13);
            cELULARLabel.TabIndex = 17;
            cELULARLabel.Text = "Celular:";
            // 
            // tELEFONE_CONTATOLabel
            // 
            tELEFONE_CONTATOLabel.AutoSize = true;
            tELEFONE_CONTATOLabel.Location = new System.Drawing.Point(822, 22);
            tELEFONE_CONTATOLabel.Name = "tELEFONE_CONTATOLabel";
            tELEFONE_CONTATOLabel.Size = new System.Drawing.Size(107, 13);
            tELEFONE_CONTATOLabel.TabIndex = 19;
            tELEFONE_CONTATOLabel.Text = "Telefone de Contato:";
            // 
            // controleDeConsultorioMB
            // 
            this.controleDeConsultorioMB.DataSetName = "ControleDeConsultorioMB";
            this.controleDeConsultorioMB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.controleDeConsultorioMB;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Consultas02TableAdapter = null;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = null;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pacienteBindingNavigator
            // 
            this.pacienteBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pacienteBindingNavigator.BindingSource = this.pacienteBindingSource;
            this.pacienteBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pacienteBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pacienteBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.pacienteBindingNavigatorSaveItem,
            this.btnFecharCadastroPaciente});
            this.pacienteBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pacienteBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pacienteBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pacienteBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pacienteBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pacienteBindingNavigator.Name = "pacienteBindingNavigator";
            this.pacienteBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pacienteBindingNavigator.Size = new System.Drawing.Size(978, 25);
            this.pacienteBindingNavigator.TabIndex = 0;
            this.pacienteBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.bindingNavigatorPositionItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            // pacienteBindingNavigatorSaveItem
            // 
            this.pacienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pacienteBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pacienteBindingNavigatorSaveItem.Image")));
            this.pacienteBindingNavigatorSaveItem.Name = "pacienteBindingNavigatorSaveItem";
            this.pacienteBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.pacienteBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.pacienteBindingNavigatorSaveItem.Click += new System.EventHandler(this.PacienteBindingNavigatorSaveItem_Click);
            // 
            // btnFecharCadastroPaciente
            // 
            this.btnFecharCadastroPaciente.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFecharCadastroPaciente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFecharCadastroPaciente.Image = global::ProgramadorCSharp3._0_PreparaCursos.Properties.Resources.close_icon1;
            this.btnFecharCadastroPaciente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFecharCadastroPaciente.Name = "btnFecharCadastroPaciente";
            this.btnFecharCadastroPaciente.Size = new System.Drawing.Size(23, 22);
            this.btnFecharCadastroPaciente.Text = "Fechar";
            this.btnFecharCadastroPaciente.Click += new System.EventHandler(this.btnFecharCadastroPaciente_Click);
            // 
            // txtIdentificadorPaciente
            // 
            this.txtIdentificadorPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "ID_PACIENTE", true));
            this.txtIdentificadorPaciente.Location = new System.Drawing.Point(6, 38);
            this.txtIdentificadorPaciente.Name = "txtIdentificadorPaciente";
            this.txtIdentificadorPaciente.ReadOnly = true;
            this.txtIdentificadorPaciente.Size = new System.Drawing.Size(74, 20);
            this.txtIdentificadorPaciente.TabIndex = 2;
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NOME_PACIENTE", true));
            this.txtNomePaciente.Location = new System.Drawing.Point(86, 38);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(479, 20);
            this.txtNomePaciente.TabIndex = 4;
            // 
            // txtEnderecoPaciente
            // 
            this.txtEnderecoPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "ENDERECO_PACIENTE", true));
            this.txtEnderecoPaciente.Location = new System.Drawing.Point(86, 79);
            this.txtEnderecoPaciente.Name = "txtEnderecoPaciente";
            this.txtEnderecoPaciente.Size = new System.Drawing.Size(479, 20);
            this.txtEnderecoPaciente.TabIndex = 6;
            // 
            // txtNumeroEnderecoPaciente
            // 
            this.txtNumeroEnderecoPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "NUMERO", true));
            this.txtNumeroEnderecoPaciente.Location = new System.Drawing.Point(571, 79);
            this.txtNumeroEnderecoPaciente.Name = "txtNumeroEnderecoPaciente";
            this.txtNumeroEnderecoPaciente.Size = new System.Drawing.Size(42, 20);
            this.txtNumeroEnderecoPaciente.TabIndex = 8;
            // 
            // txtBairroPaciente
            // 
            this.txtBairroPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "BAIRRO", true));
            this.txtBairroPaciente.Location = new System.Drawing.Point(619, 79);
            this.txtBairroPaciente.Name = "txtBairroPaciente";
            this.txtBairroPaciente.Size = new System.Drawing.Size(157, 20);
            this.txtBairroPaciente.TabIndex = 10;
            // 
            // txtCidadePaciente
            // 
            this.txtCidadePaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CIDADE", true));
            this.txtCidadePaciente.Enabled = false;
            this.txtCidadePaciente.Location = new System.Drawing.Point(782, 79);
            this.txtCidadePaciente.Name = "txtCidadePaciente";
            this.txtCidadePaciente.Size = new System.Drawing.Size(164, 20);
            this.txtCidadePaciente.TabIndex = 12;
            // 
            // cbSexoPaciente
            // 
            this.cbSexoPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "SEXO", true));
            this.cbSexoPaciente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexoPaciente.FormattingEnabled = true;
            this.cbSexoPaciente.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cbSexoPaciente.Location = new System.Drawing.Point(571, 38);
            this.cbSexoPaciente.Name = "cbSexoPaciente";
            this.cbSexoPaciente.Size = new System.Drawing.Size(121, 21);
            this.cbSexoPaciente.TabIndex = 16;
            // 
            // cELULARMaskedTextBox
            // 
            this.cELULARMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CELULAR", true));
            this.cELULARMaskedTextBox.Location = new System.Drawing.Point(698, 38);
            this.cELULARMaskedTextBox.Mask = "(99) 9-9999-9999";
            this.cELULARMaskedTextBox.Name = "cELULARMaskedTextBox";
            this.cELULARMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.cELULARMaskedTextBox.TabIndex = 18;
            // 
            // tELEFONE_CONTATOMaskedTextBox
            // 
            this.tELEFONE_CONTATOMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "TELEFONE_CONTATO", true));
            this.tELEFONE_CONTATOMaskedTextBox.Location = new System.Drawing.Point(825, 38);
            this.tELEFONE_CONTATOMaskedTextBox.Mask = "(99) 9-9999-9999";
            this.tELEFONE_CONTATOMaskedTextBox.Name = "tELEFONE_CONTATOMaskedTextBox";
            this.tELEFONE_CONTATOMaskedTextBox.Size = new System.Drawing.Size(121, 20);
            this.tELEFONE_CONTATOMaskedTextBox.TabIndex = 20;
            // 
            // gbCadastrarNovoPaciente
            // 
            this.gbCadastrarNovoPaciente.Controls.Add(this.txtCEPPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(this.btnInserirDadosCEP);
            this.gbCadastrarNovoPaciente.Controls.Add(lblIdentificadorPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(this.txtCidadePaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(lblCidadePaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(this.txtBairroPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(lblBairroEnderecoPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(this.txtNumeroEnderecoPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(lblNumeroEnderecoPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(lblEnderecoPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(this.txtNomePaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(this.txtEnderecoPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(lblNomePaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(this.txtIdentificadorPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(lblSexoPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(this.cbSexoPaciente);
            this.gbCadastrarNovoPaciente.Controls.Add(cELULARLabel);
            this.gbCadastrarNovoPaciente.Controls.Add(this.cELULARMaskedTextBox);
            this.gbCadastrarNovoPaciente.Controls.Add(tELEFONE_CONTATOLabel);
            this.gbCadastrarNovoPaciente.Controls.Add(cEPLabel);
            this.gbCadastrarNovoPaciente.Controls.Add(this.tELEFONE_CONTATOMaskedTextBox);
            this.gbCadastrarNovoPaciente.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCadastrarNovoPaciente.Enabled = false;
            this.gbCadastrarNovoPaciente.Location = new System.Drawing.Point(0, 25);
            this.gbCadastrarNovoPaciente.Name = "gbCadastrarNovoPaciente";
            this.gbCadastrarNovoPaciente.Size = new System.Drawing.Size(978, 118);
            this.gbCadastrarNovoPaciente.TabIndex = 21;
            this.gbCadastrarNovoPaciente.TabStop = false;
            this.gbCadastrarNovoPaciente.Text = "Cadastrar Novo Paciente";
            // 
            // txtCEPPaciente
            // 
            this.txtCEPPaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pacienteBindingSource, "CEP", true));
            this.txtCEPPaciente.Location = new System.Drawing.Point(6, 79);
            this.txtCEPPaciente.Name = "txtCEPPaciente";
            this.txtCEPPaciente.Size = new System.Drawing.Size(74, 20);
            this.txtCEPPaciente.TabIndex = 25;
            this.tpComoDigitarCep.SetToolTip(this.txtCEPPaciente, "Digite apenas números, sem pontos ou traços: 15950000");
            // 
            // btnInserirDadosCEP
            // 
            this.btnInserirDadosCEP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirDadosCEP.Image = global::ProgramadorCSharp3._0_PreparaCursos.Properties.Resources.next_plan;
            this.btnInserirDadosCEP.Location = new System.Drawing.Point(65, 63);
            this.btnInserirDadosCEP.Name = "btnInserirDadosCEP";
            this.btnInserirDadosCEP.Size = new System.Drawing.Size(12, 12);
            this.btnInserirDadosCEP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInserirDadosCEP.TabIndex = 22;
            this.btnInserirDadosCEP.TabStop = false;
            this.btnInserirDadosCEP.Click += new System.EventHandler(this.btnInserirDadosCEP_Click);
            // 
            // tpComoDigitarCep
            // 
            this.tpComoDigitarCep.IsBalloon = true;
            this.tpComoDigitarCep.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tpComoDigitarCep.ToolTipTitle = "Como digitar o CEP:";
            // 
            // gbPesquisarPacientes
            // 
            this.gbPesquisarPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPesquisarPacientes.Location = new System.Drawing.Point(0, 143);
            this.gbPesquisarPacientes.Name = "gbPesquisarPacientes";
            this.gbPesquisarPacientes.Size = new System.Drawing.Size(978, 86);
            this.gbPesquisarPacientes.TabIndex = 22;
            this.gbPesquisarPacientes.TabStop = false;
            this.gbPesquisarPacientes.Text = "Pesquisar Pacientes";
            // 
            // pacienteDataGridView
            // 
            this.pacienteDataGridView.AllowUserToAddRows = false;
            this.pacienteDataGridView.AutoGenerateColumns = false;
            this.pacienteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pacienteDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn8});
            this.pacienteDataGridView.DataSource = this.pacienteBindingSource;
            this.pacienteDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.pacienteDataGridView.Location = new System.Drawing.Point(0, 229);
            this.pacienteDataGridView.Name = "pacienteDataGridView";
            this.pacienteDataGridView.RowHeadersVisible = false;
            this.pacienteDataGridView.Size = new System.Drawing.Size(978, 369);
            this.pacienteDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_PACIENTE";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_PACIENTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Paciente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ENDERECO_PACIENTE";
            this.dataGridViewTextBoxColumn3.HeaderText = "ENDERECO_PACIENTE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NUMERO";
            this.dataGridViewTextBoxColumn4.HeaderText = "NUMERO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BAIRRO";
            this.dataGridViewTextBoxColumn5.HeaderText = "BAIRRO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CIDADE";
            this.dataGridViewTextBoxColumn6.HeaderText = "Cidade:";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 124;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "CEP";
            this.dataGridViewTextBoxColumn7.HeaderText = "CEP";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CELULAR";
            this.dataGridViewTextBoxColumn9.HeaderText = "Celular:";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "TELEFONE_CONTATO";
            this.dataGridViewTextBoxColumn10.HeaderText = "Contato Extra:";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SEXO";
            this.dataGridViewTextBoxColumn8.HeaderText = "Sexo:";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 610);
            this.Controls.Add(this.pacienteDataGridView);
            this.Controls.Add(this.gbPesquisarPacientes);
            this.Controls.Add(this.gbCadastrarNovoPaciente);
            this.Controls.Add(this.pacienteBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controleDeConsultorioMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingNavigator)).EndInit();
            this.pacienteBindingNavigator.ResumeLayout(false);
            this.pacienteBindingNavigator.PerformLayout();
            this.gbCadastrarNovoPaciente.ResumeLayout(false);
            this.gbCadastrarNovoPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInserirDadosCEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControleDeConsultorioMB controleDeConsultorioMB;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private ControleDeConsultorioMBTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private ControleDeConsultorioMBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pacienteBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton pacienteBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtIdentificadorPaciente;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.TextBox txtEnderecoPaciente;
        private System.Windows.Forms.TextBox txtNumeroEnderecoPaciente;
        private System.Windows.Forms.TextBox txtBairroPaciente;
        private System.Windows.Forms.TextBox txtCidadePaciente;
        private System.Windows.Forms.ComboBox cbSexoPaciente;
        private System.Windows.Forms.MaskedTextBox cELULARMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox tELEFONE_CONTATOMaskedTextBox;
        private System.Windows.Forms.GroupBox gbCadastrarNovoPaciente;
        private System.Windows.Forms.ToolStripButton btnFecharCadastroPaciente;
        private System.Windows.Forms.PictureBox btnInserirDadosCEP;
        private System.Windows.Forms.TextBox txtCEPPaciente;
        private System.Windows.Forms.ToolTip tpComoDigitarCep;
        private System.Windows.Forms.GroupBox gbPesquisarPacientes;
        private System.Windows.Forms.DataGridView pacienteDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}
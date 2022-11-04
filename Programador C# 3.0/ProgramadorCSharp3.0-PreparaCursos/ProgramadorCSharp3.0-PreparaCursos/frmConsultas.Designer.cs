namespace ProgramadorCSharp3._0_PreparaCursos
{
    partial class frmConsultas
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
            System.Windows.Forms.Label Identificador;
            System.Windows.Forms.Label lblNomePaciente;
            System.Windows.Forms.Label lblNomeMedico;
            System.Windows.Forms.Label lblDataConsulta;
            System.Windows.Forms.Label lblHorarioConsulta;
            System.Windows.Forms.Label lblRetornoConsulta;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.controleDeConsultorioMB = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMB();
            this.consultas02BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consultas02TableAdapter = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.Consultas02TableAdapter();
            this.tableAdapterManager = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.TableAdapterManager();
            this.medicoTableAdapter = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.MedicoTableAdapter();
            this.pacienteTableAdapter = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.PacienteTableAdapter();
            this.consultas02BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.consultas02BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdentificador = new System.Windows.Forms.TextBox();
            this.nOME_PACIENTEComboBox = new System.Windows.Forms.ComboBox();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nOME_MEDICOComboBox = new System.Windows.Forms.ComboBox();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtpDataConsulta = new System.Windows.Forms.DateTimePicker();
            this.dtpHorarioConsulta = new System.Windows.Forms.DateTimePicker();
            this.cbRetornoConsulta = new System.Windows.Forms.CheckBox();
            this.gbCadastrarNovaConsulta = new System.Windows.Forms.GroupBox();
            this.consultas02DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            Identificador = new System.Windows.Forms.Label();
            lblNomePaciente = new System.Windows.Forms.Label();
            lblNomeMedico = new System.Windows.Forms.Label();
            lblDataConsulta = new System.Windows.Forms.Label();
            lblHorarioConsulta = new System.Windows.Forms.Label();
            lblRetornoConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeConsultorioMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultas02BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultas02BindingNavigator)).BeginInit();
            this.consultas02BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            this.gbCadastrarNovaConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultas02DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Identificador
            // 
            Identificador.AutoSize = true;
            Identificador.Location = new System.Drawing.Point(8, 16);
            Identificador.Name = "Identificador";
            Identificador.Size = new System.Drawing.Size(65, 13);
            Identificador.TabIndex = 1;
            Identificador.Text = "Identificador";
            // 
            // lblNomePaciente
            // 
            lblNomePaciente.AutoSize = true;
            lblNomePaciente.Location = new System.Drawing.Point(6, 55);
            lblNomePaciente.Name = "lblNomePaciente";
            lblNomePaciente.Size = new System.Drawing.Size(98, 13);
            lblNomePaciente.TabIndex = 3;
            lblNomePaciente.Text = "Nome do Paciente:";
            // 
            // lblNomeMedico
            // 
            lblNomeMedico.AutoSize = true;
            lblNomeMedico.Location = new System.Drawing.Point(375, 55);
            lblNomeMedico.Name = "lblNomeMedico";
            lblNomeMedico.Size = new System.Drawing.Size(88, 13);
            lblNomeMedico.TabIndex = 5;
            lblNomeMedico.Text = "Nome do Médico";
            // 
            // lblDataConsulta
            // 
            lblDataConsulta.AutoSize = true;
            lblDataConsulta.Location = new System.Drawing.Point(79, 16);
            lblDataConsulta.Name = "lblDataConsulta";
            lblDataConsulta.Size = new System.Drawing.Size(89, 13);
            lblDataConsulta.TabIndex = 7;
            lblDataConsulta.Text = "Data da Consulta";
            // 
            // lblHorarioConsulta
            // 
            lblHorarioConsulta.AutoSize = true;
            lblHorarioConsulta.Location = new System.Drawing.Point(306, 16);
            lblHorarioConsulta.Name = "lblHorarioConsulta";
            lblHorarioConsulta.Size = new System.Drawing.Size(44, 13);
            lblHorarioConsulta.TabIndex = 9;
            lblHorarioConsulta.Text = "Horário:";
            // 
            // lblRetornoConsulta
            // 
            lblRetornoConsulta.AutoSize = true;
            lblRetornoConsulta.Location = new System.Drawing.Point(367, 16);
            lblRetornoConsulta.Name = "lblRetornoConsulta";
            lblRetornoConsulta.Size = new System.Drawing.Size(76, 13);
            lblRetornoConsulta.TabIndex = 11;
            lblRetornoConsulta.Text = "Terá Retorno?";
            // 
            // controleDeConsultorioMB
            // 
            this.controleDeConsultorioMB.DataSetName = "ControleDeConsultorioMB";
            this.controleDeConsultorioMB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultas02BindingSource
            // 
            this.consultas02BindingSource.DataMember = "Consultas02";
            this.consultas02BindingSource.DataSource = this.controleDeConsultorioMB;
            // 
            // consultas02TableAdapter
            // 
            this.consultas02TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Consultas02TableAdapter = this.consultas02TableAdapter;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = this.medicoTableAdapter;
            this.tableAdapterManager.PacienteTableAdapter = this.pacienteTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // consultas02BindingNavigator
            // 
            this.consultas02BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultas02BindingNavigator.BindingSource = this.consultas02BindingSource;
            this.consultas02BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultas02BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultas02BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultas02BindingNavigatorSaveItem});
            this.consultas02BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consultas02BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultas02BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultas02BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultas02BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultas02BindingNavigator.Name = "consultas02BindingNavigator";
            this.consultas02BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultas02BindingNavigator.Size = new System.Drawing.Size(752, 25);
            this.consultas02BindingNavigator.TabIndex = 0;
            this.consultas02BindingNavigator.Text = "bindingNavigator1";
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
            // consultas02BindingNavigatorSaveItem
            // 
            this.consultas02BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultas02BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultas02BindingNavigatorSaveItem.Image")));
            this.consultas02BindingNavigatorSaveItem.Name = "consultas02BindingNavigatorSaveItem";
            this.consultas02BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consultas02BindingNavigatorSaveItem.Text = "Salvar Dados";
            this.consultas02BindingNavigatorSaveItem.Click += new System.EventHandler(this.consultas02BindingNavigatorSaveItem_Click);
            // 
            // txtIdentificador
            // 
            this.txtIdentificador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultas02BindingSource, "ID_CONSULTA", true));
            this.txtIdentificador.Location = new System.Drawing.Point(11, 32);
            this.txtIdentificador.Name = "txtIdentificador";
            this.txtIdentificador.ReadOnly = true;
            this.txtIdentificador.Size = new System.Drawing.Size(62, 20);
            this.txtIdentificador.TabIndex = 2;
            // 
            // nOME_PACIENTEComboBox
            // 
            this.nOME_PACIENTEComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultas02BindingSource, "NOME_PACIENTE", true));
            this.nOME_PACIENTEComboBox.DataSource = this.pacienteBindingSource;
            this.nOME_PACIENTEComboBox.DisplayMember = "NOME_PACIENTE";
            this.nOME_PACIENTEComboBox.FormattingEnabled = true;
            this.nOME_PACIENTEComboBox.Location = new System.Drawing.Point(11, 71);
            this.nOME_PACIENTEComboBox.Name = "nOME_PACIENTEComboBox";
            this.nOME_PACIENTEComboBox.Size = new System.Drawing.Size(360, 21);
            this.nOME_PACIENTEComboBox.TabIndex = 4;
            this.nOME_PACIENTEComboBox.ValueMember = "NOME_PACIENTE";
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "Paciente";
            this.pacienteBindingSource.DataSource = this.controleDeConsultorioMB;
            // 
            // nOME_MEDICOComboBox
            // 
            this.nOME_MEDICOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultas02BindingSource, "NOME_MEDICO", true));
            this.nOME_MEDICOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.consultas02BindingSource, "NOME_MEDICO", true));
            this.nOME_MEDICOComboBox.DataSource = this.medicoBindingSource;
            this.nOME_MEDICOComboBox.DisplayMember = " NOME_MEDICO";
            this.nOME_MEDICOComboBox.FormattingEnabled = true;
            this.nOME_MEDICOComboBox.Location = new System.Drawing.Point(378, 71);
            this.nOME_MEDICOComboBox.Name = "nOME_MEDICOComboBox";
            this.nOME_MEDICOComboBox.Size = new System.Drawing.Size(360, 21);
            this.nOME_MEDICOComboBox.TabIndex = 6;
            this.nOME_MEDICOComboBox.ValueMember = " NOME_MEDICO";
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.controleDeConsultorioMB;
            // 
            // dtpDataConsulta
            // 
            this.dtpDataConsulta.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultas02BindingSource, "DATA_CONSULTA", true));
            this.dtpDataConsulta.Location = new System.Drawing.Point(82, 32);
            this.dtpDataConsulta.Name = "dtpDataConsulta";
            this.dtpDataConsulta.Size = new System.Drawing.Size(220, 20);
            this.dtpDataConsulta.TabIndex = 8;
            // 
            // dtpHorarioConsulta
            // 
            this.dtpHorarioConsulta.CustomFormat = "HH:mm";
            this.dtpHorarioConsulta.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultas02BindingSource, "HORARIO_CONSULTA", true));
            this.dtpHorarioConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHorarioConsulta.Location = new System.Drawing.Point(309, 32);
            this.dtpHorarioConsulta.Name = "dtpHorarioConsulta";
            this.dtpHorarioConsulta.ShowUpDown = true;
            this.dtpHorarioConsulta.Size = new System.Drawing.Size(52, 20);
            this.dtpHorarioConsulta.TabIndex = 10;
            // 
            // cbRetornoConsulta
            // 
            this.cbRetornoConsulta.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.consultas02BindingSource, "RETORNO", true));
            this.cbRetornoConsulta.Location = new System.Drawing.Point(370, 30);
            this.cbRetornoConsulta.Name = "cbRetornoConsulta";
            this.cbRetornoConsulta.Size = new System.Drawing.Size(200, 24);
            this.cbRetornoConsulta.TabIndex = 12;
            this.cbRetornoConsulta.Text = "SIM";
            this.cbRetornoConsulta.UseVisualStyleBackColor = true;
            // 
            // gbCadastrarNovaConsulta
            // 
            this.gbCadastrarNovaConsulta.Controls.Add(Identificador);
            this.gbCadastrarNovaConsulta.Controls.Add(this.cbRetornoConsulta);
            this.gbCadastrarNovaConsulta.Controls.Add(lblRetornoConsulta);
            this.gbCadastrarNovaConsulta.Controls.Add(this.dtpHorarioConsulta);
            this.gbCadastrarNovaConsulta.Controls.Add(lblHorarioConsulta);
            this.gbCadastrarNovaConsulta.Controls.Add(this.dtpDataConsulta);
            this.gbCadastrarNovaConsulta.Controls.Add(lblDataConsulta);
            this.gbCadastrarNovaConsulta.Controls.Add(this.nOME_MEDICOComboBox);
            this.gbCadastrarNovaConsulta.Controls.Add(lblNomeMedico);
            this.gbCadastrarNovaConsulta.Controls.Add(this.nOME_PACIENTEComboBox);
            this.gbCadastrarNovaConsulta.Controls.Add(lblNomePaciente);
            this.gbCadastrarNovaConsulta.Controls.Add(this.txtIdentificador);
            this.gbCadastrarNovaConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCadastrarNovaConsulta.Location = new System.Drawing.Point(0, 25);
            this.gbCadastrarNovaConsulta.Name = "gbCadastrarNovaConsulta";
            this.gbCadastrarNovaConsulta.Size = new System.Drawing.Size(752, 112);
            this.gbCadastrarNovaConsulta.TabIndex = 13;
            this.gbCadastrarNovaConsulta.TabStop = false;
            this.gbCadastrarNovaConsulta.Text = "Cadastrar Nova Consulta";
            // 
            // consultas02DataGridView
            // 
            this.consultas02DataGridView.AutoGenerateColumns = false;
            this.consultas02DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultas02DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.consultas02DataGridView.DataSource = this.consultas02BindingSource;
            this.consultas02DataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.consultas02DataGridView.Location = new System.Drawing.Point(0, 137);
            this.consultas02DataGridView.Name = "consultas02DataGridView";
            this.consultas02DataGridView.RowHeadersVisible = false;
            this.consultas02DataGridView.Size = new System.Drawing.Size(752, 324);
            this.consultas02DataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CONSULTA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_PACIENTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Paciente:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOME_MEDICO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Médico:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATA_CONSULTA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Data:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HORARIO_CONSULTA";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "Hora:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "RETORNO";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Retorno:";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 75;
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 462);
            this.Controls.Add(this.consultas02DataGridView);
            this.Controls.Add(this.gbCadastrarNovaConsulta);
            this.Controls.Add(this.consultas02BindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Nova Consulta";
            this.Load += new System.EventHandler(this.frmConsultas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controleDeConsultorioMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultas02BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultas02BindingNavigator)).EndInit();
            this.consultas02BindingNavigator.ResumeLayout(false);
            this.consultas02BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            this.gbCadastrarNovaConsulta.ResumeLayout(false);
            this.gbCadastrarNovaConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultas02DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControleDeConsultorioMB controleDeConsultorioMB;
        private System.Windows.Forms.BindingSource consultas02BindingSource;
        private ControleDeConsultorioMBTableAdapters.Consultas02TableAdapter consultas02TableAdapter;
        private ControleDeConsultorioMBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultas02BindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultas02BindingNavigatorSaveItem;
        private ControleDeConsultorioMBTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private System.Windows.Forms.TextBox txtIdentificador;
        private System.Windows.Forms.ComboBox nOME_PACIENTEComboBox;
        private System.Windows.Forms.ComboBox nOME_MEDICOComboBox;
        private System.Windows.Forms.DateTimePicker dtpDataConsulta;
        private System.Windows.Forms.DateTimePicker dtpHorarioConsulta;
        private System.Windows.Forms.CheckBox cbRetornoConsulta;
        private System.Windows.Forms.GroupBox gbCadastrarNovaConsulta;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ControleDeConsultorioMBTableAdapters.PacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private System.Windows.Forms.DataGridView consultas02DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}
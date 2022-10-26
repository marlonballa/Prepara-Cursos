namespace ProgramadorCSharp3._0_PreparaCursos
{
    partial class frmConsultorio
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
            System.Windows.Forms.Label lblConsulta;
            System.Windows.Forms.Label lblNomePaciente;
            System.Windows.Forms.Label lblNomeMedico;
            System.Windows.Forms.Label lblDataConsulta;
            System.Windows.Forms.Label lblHorarioConsulta;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultorio));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpConsultas = new System.Windows.Forms.TabPage();
            this.dgvConsultas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Consultorio_2_0DataSet = new ProgramadorCSharp3._0_PreparaCursos._Consultorio_2_0DataSet();
            this.consultasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.consultasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdConsulta = new System.Windows.Forms.TextBox();
            this.hORÁRIODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.dATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtNomeMedico = new System.Windows.Forms.TextBox();
            this.tpPesquisar = new System.Windows.Forms.TabPage();
            this.dtgPesquisa = new System.Windows.Forms.DataGridView();
            this.IDENTIFICADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_PACIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME_MEDICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HORARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisarPaciente = new System.Windows.Forms.RadioButton();
            this.lblPesquisarMedico = new System.Windows.Forms.RadioButton();
            this.consultasTableAdapter = new ProgramadorCSharp3._0_PreparaCursos._Consultorio_2_0DataSetTableAdapters.ConsultasTableAdapter();
            this.tableAdapterManager = new ProgramadorCSharp3._0_PreparaCursos._Consultorio_2_0DataSetTableAdapters.TableAdapterManager();
            lblConsulta = new System.Windows.Forms.Label();
            lblNomePaciente = new System.Windows.Forms.Label();
            lblNomeMedico = new System.Windows.Forms.Label();
            lblDataConsulta = new System.Windows.Forms.Label();
            lblHorarioConsulta = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tpConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Consultorio_2_0DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).BeginInit();
            this.consultasBindingNavigator.SuspendLayout();
            this.tpPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConsulta
            // 
            lblConsulta.AutoSize = true;
            lblConsulta.Location = new System.Drawing.Point(10, 40);
            lblConsulta.Name = "lblConsulta";
            lblConsulta.Size = new System.Drawing.Size(88, 13);
            lblConsulta.TabIndex = 2;
            lblConsulta.Text = "Consulta Número";
            // 
            // lblNomePaciente
            // 
            lblNomePaciente.AutoSize = true;
            lblNomePaciente.Location = new System.Drawing.Point(104, 40);
            lblNomePaciente.Name = "lblNomePaciente";
            lblNomePaciente.Size = new System.Drawing.Size(95, 13);
            lblNomePaciente.TabIndex = 4;
            lblNomePaciente.Text = "Nome do Paciente";
            // 
            // lblNomeMedico
            // 
            lblNomeMedico.AutoSize = true;
            lblNomeMedico.Location = new System.Drawing.Point(366, 40);
            lblNomeMedico.Name = "lblNomeMedico";
            lblNomeMedico.Size = new System.Drawing.Size(88, 13);
            lblNomeMedico.TabIndex = 6;
            lblNomeMedico.Text = "Nome do Médico";
            // 
            // lblDataConsulta
            // 
            lblDataConsulta.AutoSize = true;
            lblDataConsulta.Location = new System.Drawing.Point(628, 40);
            lblDataConsulta.Name = "lblDataConsulta";
            lblDataConsulta.Size = new System.Drawing.Size(39, 13);
            lblDataConsulta.TabIndex = 8;
            lblDataConsulta.Text = "DATA:";
            // 
            // lblHorarioConsulta
            // 
            lblHorarioConsulta.AutoSize = true;
            lblHorarioConsulta.Location = new System.Drawing.Point(733, 40);
            lblHorarioConsulta.Name = "lblHorarioConsulta";
            lblHorarioConsulta.Size = new System.Drawing.Size(60, 13);
            lblHorarioConsulta.TabIndex = 10;
            lblHorarioConsulta.Text = "HORÁRIO:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpConsultas);
            this.tabControl1.Controls.Add(this.tpPesquisar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 537);
            this.tabControl1.TabIndex = 0;
            // 
            // tpConsultas
            // 
            this.tpConsultas.Controls.Add(this.dgvConsultas);
            this.tpConsultas.Controls.Add(lblConsulta);
            this.tpConsultas.Controls.Add(this.consultasBindingNavigator);
            this.tpConsultas.Controls.Add(this.txtIdConsulta);
            this.tpConsultas.Controls.Add(this.hORÁRIODateTimePicker);
            this.tpConsultas.Controls.Add(lblNomePaciente);
            this.tpConsultas.Controls.Add(lblHorarioConsulta);
            this.tpConsultas.Controls.Add(this.txtNomePaciente);
            this.tpConsultas.Controls.Add(this.dATADateTimePicker);
            this.tpConsultas.Controls.Add(lblNomeMedico);
            this.tpConsultas.Controls.Add(lblDataConsulta);
            this.tpConsultas.Controls.Add(this.txtNomeMedico);
            this.tpConsultas.Location = new System.Drawing.Point(4, 22);
            this.tpConsultas.Name = "tpConsultas";
            this.tpConsultas.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsultas.Size = new System.Drawing.Size(1000, 511);
            this.tpConsultas.TabIndex = 0;
            this.tpConsultas.Text = "Agendar Consultas";
            this.tpConsultas.UseVisualStyleBackColor = true;
            // 
            // dgvConsultas
            // 
            this.dgvConsultas.AllowUserToAddRows = false;
            this.dgvConsultas.AllowUserToDeleteRows = false;
            this.dgvConsultas.AutoGenerateColumns = false;
            this.dgvConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvConsultas.DataSource = this.consultasBindingSource;
            this.dgvConsultas.Location = new System.Drawing.Point(14, 82);
            this.dgvConsultas.Name = "dgvConsultas";
            this.dgvConsultas.ReadOnly = true;
            this.dgvConsultas.RowHeadersVisible = false;
            this.dgvConsultas.Size = new System.Drawing.Size(978, 421);
            this.dgvConsultas.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CONSULTA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Consulta Número:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_PACIENTE";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Paciente:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 364;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOME_MEDICO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Médico:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 364;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DATA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Data:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HORÁRIO";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn5.HeaderText = "Horário:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // consultasBindingSource
            // 
            this.consultasBindingSource.DataMember = "Consultas";
            this.consultasBindingSource.DataSource = this._Consultorio_2_0DataSet;
            // 
            // _Consultorio_2_0DataSet
            // 
            this._Consultorio_2_0DataSet.DataSetName = "_Consultorio_2_0DataSet";
            this._Consultorio_2_0DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consultasBindingNavigator
            // 
            this.consultasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consultasBindingNavigator.BindingSource = this.consultasBindingSource;
            this.consultasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.consultasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.consultasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.consultasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.consultasBindingNavigatorSaveItem});
            this.consultasBindingNavigator.Location = new System.Drawing.Point(13, 3);
            this.consultasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.consultasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.consultasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.consultasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.consultasBindingNavigator.Name = "consultasBindingNavigator";
            this.consultasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.consultasBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.consultasBindingNavigator.TabIndex = 1;
            this.consultasBindingNavigator.Text = "bindingNavigator1";
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
            // consultasBindingNavigatorSaveItem
            // 
            this.consultasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.consultasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("consultasBindingNavigatorSaveItem.Image")));
            this.consultasBindingNavigatorSaveItem.Name = "consultasBindingNavigatorSaveItem";
            this.consultasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.consultasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.consultasBindingNavigatorSaveItem.Click += new System.EventHandler(this.consultasBindingNavigatorSaveItem_Click_1);
            // 
            // txtIdConsulta
            // 
            this.txtIdConsulta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "ID_CONSULTA", true));
            this.txtIdConsulta.Enabled = false;
            this.txtIdConsulta.Location = new System.Drawing.Point(14, 56);
            this.txtIdConsulta.Name = "txtIdConsulta";
            this.txtIdConsulta.Size = new System.Drawing.Size(80, 20);
            this.txtIdConsulta.TabIndex = 3;
            // 
            // hORÁRIODateTimePicker
            // 
            this.hORÁRIODateTimePicker.CustomFormat = "HH:mm";
            this.hORÁRIODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "HORÁRIO", true));
            this.hORÁRIODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hORÁRIODateTimePicker.Location = new System.Drawing.Point(736, 56);
            this.hORÁRIODateTimePicker.Name = "hORÁRIODateTimePicker";
            this.hORÁRIODateTimePicker.Size = new System.Drawing.Size(79, 20);
            this.hORÁRIODateTimePicker.TabIndex = 11;
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "NOME_PACIENTE", true));
            this.txtNomePaciente.Location = new System.Drawing.Point(107, 56);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(256, 20);
            this.txtNomePaciente.TabIndex = 5;
            // 
            // dATADateTimePicker
            // 
            this.dATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consultasBindingSource, "DATA", true));
            this.dATADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATADateTimePicker.Location = new System.Drawing.Point(631, 56);
            this.dATADateTimePicker.Name = "dATADateTimePicker";
            this.dATADateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.dATADateTimePicker.TabIndex = 9;
            // 
            // txtNomeMedico
            // 
            this.txtNomeMedico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consultasBindingSource, "NOME_MEDICO", true));
            this.txtNomeMedico.Location = new System.Drawing.Point(369, 56);
            this.txtNomeMedico.Name = "txtNomeMedico";
            this.txtNomeMedico.Size = new System.Drawing.Size(256, 20);
            this.txtNomeMedico.TabIndex = 7;
            // 
            // tpPesquisar
            // 
            this.tpPesquisar.Controls.Add(this.dtgPesquisa);
            this.tpPesquisar.Controls.Add(this.btnPesquisar);
            this.tpPesquisar.Controls.Add(this.txtPesquisar);
            this.tpPesquisar.Controls.Add(this.lblPesquisarPaciente);
            this.tpPesquisar.Controls.Add(this.lblPesquisarMedico);
            this.tpPesquisar.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisar.Name = "tpPesquisar";
            this.tpPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisar.Size = new System.Drawing.Size(1000, 511);
            this.tpPesquisar.TabIndex = 1;
            this.tpPesquisar.Text = "Pesquisar Consultas";
            this.tpPesquisar.UseVisualStyleBackColor = true;
            // 
            // dtgPesquisa
            // 
            this.dtgPesquisa.AllowUserToAddRows = false;
            this.dtgPesquisa.AllowUserToDeleteRows = false;
            this.dtgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDENTIFICADOR,
            this.NOME_PACIENTE,
            this.NOME_MEDICO,
            this.DATA,
            this.HORARIO});
            this.dtgPesquisa.Location = new System.Drawing.Point(8, 80);
            this.dtgPesquisa.Name = "dtgPesquisa";
            this.dtgPesquisa.ReadOnly = true;
            this.dtgPesquisa.RowHeadersVisible = false;
            this.dtgPesquisa.Size = new System.Drawing.Size(984, 423);
            this.dtgPesquisa.TabIndex = 3;
            // 
            // IDENTIFICADOR
            // 
            this.IDENTIFICADOR.DataPropertyName = "ID_CONSULTA";
            this.IDENTIFICADOR.HeaderText = "Consulta Número:";
            this.IDENTIFICADOR.Name = "IDENTIFICADOR";
            this.IDENTIFICADOR.ReadOnly = true;
            this.IDENTIFICADOR.Width = 75;
            // 
            // NOME_PACIENTE
            // 
            this.NOME_PACIENTE.DataPropertyName = "NOME_PACIENTE";
            this.NOME_PACIENTE.HeaderText = "Nome do Paciente:";
            this.NOME_PACIENTE.Name = "NOME_PACIENTE";
            this.NOME_PACIENTE.ReadOnly = true;
            this.NOME_PACIENTE.Width = 380;
            // 
            // NOME_MEDICO
            // 
            this.NOME_MEDICO.DataPropertyName = "NOME_MEDICO";
            this.NOME_MEDICO.HeaderText = "Nome do Médico:";
            this.NOME_MEDICO.Name = "NOME_MEDICO";
            this.NOME_MEDICO.ReadOnly = true;
            this.NOME_MEDICO.Width = 380;
            // 
            // DATA
            // 
            this.DATA.DataPropertyName = "DATA";
            this.DATA.HeaderText = "Data:";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 75;
            // 
            // HORARIO
            // 
            this.HORARIO.DataPropertyName = "HORARIO";
            this.HORARIO.HeaderText = "Horário:";
            this.HORARIO.Name = "HORARIO";
            this.HORARIO.ReadOnly = true;
            this.HORARIO.Width = 75;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(875, 44);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(117, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(8, 44);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(861, 20);
            this.txtPesquisar.TabIndex = 1;
            // 
            // lblPesquisarPaciente
            // 
            this.lblPesquisarPaciente.AutoSize = true;
            this.lblPesquisarPaciente.Location = new System.Drawing.Point(120, 21);
            this.lblPesquisarPaciente.Name = "lblPesquisarPaciente";
            this.lblPesquisarPaciente.Size = new System.Drawing.Size(113, 17);
            this.lblPesquisarPaciente.TabIndex = 0;
            this.lblPesquisarPaciente.TabStop = true;
            this.lblPesquisarPaciente.Text = "Nome do Paciente";
            this.lblPesquisarPaciente.UseVisualStyleBackColor = true;
            // 
            // lblPesquisarMedico
            // 
            this.lblPesquisarMedico.AutoSize = true;
            this.lblPesquisarMedico.Location = new System.Drawing.Point(8, 21);
            this.lblPesquisarMedico.Name = "lblPesquisarMedico";
            this.lblPesquisarMedico.Size = new System.Drawing.Size(106, 17);
            this.lblPesquisarMedico.TabIndex = 0;
            this.lblPesquisarMedico.TabStop = true;
            this.lblPesquisarMedico.Text = "Nome do Médico";
            this.lblPesquisarMedico.UseVisualStyleBackColor = true;
            // 
            // consultasTableAdapter
            // 
            this.consultasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = this.consultasTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProgramadorCSharp3._0_PreparaCursos._Consultorio_2_0DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmConsultorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "frmConsultorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Janela de Agendamento e Controle de Consultas";
            this.Load += new System.EventHandler(this.frmConsultorio_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpConsultas.ResumeLayout(false);
            this.tpConsultas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Consultorio_2_0DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultasBindingNavigator)).EndInit();
            this.consultasBindingNavigator.ResumeLayout(false);
            this.consultasBindingNavigator.PerformLayout();
            this.tpPesquisar.ResumeLayout(false);
            this.tpPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpConsultas;
        private System.Windows.Forms.TabPage tpPesquisar;
        private _Consultorio_2_0DataSet _Consultorio_2_0DataSet;
        private System.Windows.Forms.BindingSource consultasBindingSource;
        private _Consultorio_2_0DataSetTableAdapters.ConsultasTableAdapter consultasTableAdapter;
        private _Consultorio_2_0DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consultasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton consultasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dgvConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtIdConsulta;
        private System.Windows.Forms.DateTimePicker hORÁRIODateTimePicker;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.DateTimePicker dATADateTimePicker;
        private System.Windows.Forms.TextBox txtNomeMedico;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.RadioButton lblPesquisarMedico;
        private System.Windows.Forms.RadioButton lblPesquisarPaciente;
        private System.Windows.Forms.DataGridView dtgPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTIFICADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_PACIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME_MEDICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HORARIO;
    }
}
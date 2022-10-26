namespace ProgramadorCSharp3._0_PreparaCursos
{
    partial class frmControleDeAluno
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
            System.Windows.Forms.Label lblIdentificadorAluno;
            System.Windows.Forms.Label lblNomeAluno;
            System.Windows.Forms.Label lblTelefoneAluno;
            System.Windows.Forms.Label lblEmailAluno;
            System.Windows.Forms.Label lblCursoAluno;
            System.Windows.Forms.Label lblNascimentoAluno;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleDeAluno));
            this.tcControleAlunos = new System.Windows.Forms.TabControl();
            this.tbCadastroAlunos = new System.Windows.Forms.TabPage();
            this.alunosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.alunosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdentificadorAluno = new System.Windows.Forms.TextBox();
            this.nOME_ALUNOTextBox = new System.Windows.Forms.TextBox();
            this.tELEFONE_ALUNOMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.eMAIL_ALUNOTextBox = new System.Windows.Forms.TextBox();
            this.cURSOTextBox = new System.Windows.Forms.TextBox();
            this.nASCIMENTO_ALUNODateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tpPesquisarAlunos = new System.Windows.Forms.TabPage();
            this.dtgAlunos = new System.Windows.Forms.DataGridView();
            this.lblFormaPesquisa = new System.Windows.Forms.Label();
            this.rbPesquisarPorAluno = new System.Windows.Forms.RadioButton();
            this.rbPesquisarPorCurso = new System.Windows.Forms.RadioButton();
            this.txtPesquisaControleEscolar = new System.Windows.Forms.TextBox();
            this.btnPesquisarAlunos = new System.Windows.Forms.Button();
            this.dgvAlunosPesquisados = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleEscolarMBDataSet = new ProgramadorCSharp3._0_PreparaCursos.ControleEscolarMBDataSet();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alunosTableAdapter = new ProgramadorCSharp3._0_PreparaCursos.ControleEscolarMBDataSetTableAdapters.AlunosTableAdapter();
            this.tableAdapterManager = new ProgramadorCSharp3._0_PreparaCursos.ControleEscolarMBDataSetTableAdapters.TableAdapterManager();
            lblIdentificadorAluno = new System.Windows.Forms.Label();
            lblNomeAluno = new System.Windows.Forms.Label();
            lblTelefoneAluno = new System.Windows.Forms.Label();
            lblEmailAluno = new System.Windows.Forms.Label();
            lblCursoAluno = new System.Windows.Forms.Label();
            lblNascimentoAluno = new System.Windows.Forms.Label();
            this.tcControleAlunos.SuspendLayout();
            this.tbCadastroAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).BeginInit();
            this.alunosBindingNavigator.SuspendLayout();
            this.tpPesquisarAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosPesquisados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleEscolarMBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdentificadorAluno
            // 
            lblIdentificadorAluno.AutoSize = true;
            lblIdentificadorAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblIdentificadorAluno.Location = new System.Drawing.Point(8, 41);
            lblIdentificadorAluno.Name = "lblIdentificadorAluno";
            lblIdentificadorAluno.Size = new System.Drawing.Size(80, 16);
            lblIdentificadorAluno.TabIndex = 0;
            lblIdentificadorAluno.Text = "Identificador";
            // 
            // lblNomeAluno
            // 
            lblNomeAluno.AutoSize = true;
            lblNomeAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomeAluno.Location = new System.Drawing.Point(91, 41);
            lblNomeAluno.Name = "lblNomeAluno";
            lblNomeAluno.Size = new System.Drawing.Size(100, 16);
            lblNomeAluno.TabIndex = 2;
            lblNomeAluno.Text = "Nome do Aluno";
            // 
            // lblTelefoneAluno
            // 
            lblTelefoneAluno.AutoSize = true;
            lblTelefoneAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTelefoneAluno.Location = new System.Drawing.Point(400, 41);
            lblTelefoneAluno.Name = "lblTelefoneAluno";
            lblTelefoneAluno.Size = new System.Drawing.Size(64, 16);
            lblTelefoneAluno.TabIndex = 4;
            lblTelefoneAluno.Text = "Telefone:";
            // 
            // lblEmailAluno
            // 
            lblEmailAluno.AutoSize = true;
            lblEmailAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEmailAluno.Location = new System.Drawing.Point(532, 41);
            lblEmailAluno.Name = "lblEmailAluno";
            lblEmailAluno.Size = new System.Drawing.Size(48, 16);
            lblEmailAluno.TabIndex = 6;
            lblEmailAluno.Text = "E-mail:";
            // 
            // lblCursoAluno
            // 
            lblCursoAluno.AutoSize = true;
            lblCursoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblCursoAluno.Location = new System.Drawing.Point(737, 41);
            lblCursoAluno.Name = "lblCursoAluno";
            lblCursoAluno.Size = new System.Drawing.Size(45, 16);
            lblCursoAluno.TabIndex = 8;
            lblCursoAluno.Text = "Curso:";
            // 
            // lblNascimentoAluno
            // 
            lblNascimentoAluno.AutoSize = true;
            lblNascimentoAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNascimentoAluno.Location = new System.Drawing.Point(862, 41);
            lblNascimentoAluno.Name = "lblNascimentoAluno";
            lblNascimentoAluno.Size = new System.Drawing.Size(133, 16);
            lblNascimentoAluno.TabIndex = 10;
            lblNascimentoAluno.Text = "Data de Nascimento:";
            // 
            // tcControleAlunos
            // 
            this.tcControleAlunos.Controls.Add(this.tbCadastroAlunos);
            this.tcControleAlunos.Controls.Add(this.tpPesquisarAlunos);
            this.tcControleAlunos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcControleAlunos.Location = new System.Drawing.Point(0, 0);
            this.tcControleAlunos.Name = "tcControleAlunos";
            this.tcControleAlunos.SelectedIndex = 0;
            this.tcControleAlunos.Size = new System.Drawing.Size(1008, 537);
            this.tcControleAlunos.TabIndex = 0;
            // 
            // tbCadastroAlunos
            // 
            this.tbCadastroAlunos.AutoScroll = true;
            this.tbCadastroAlunos.Controls.Add(this.dtgAlunos);
            this.tbCadastroAlunos.Controls.Add(this.alunosBindingNavigator);
            this.tbCadastroAlunos.Controls.Add(lblIdentificadorAluno);
            this.tbCadastroAlunos.Controls.Add(this.txtIdentificadorAluno);
            this.tbCadastroAlunos.Controls.Add(lblNomeAluno);
            this.tbCadastroAlunos.Controls.Add(this.nOME_ALUNOTextBox);
            this.tbCadastroAlunos.Controls.Add(lblTelefoneAluno);
            this.tbCadastroAlunos.Controls.Add(this.tELEFONE_ALUNOMaskedTextBox);
            this.tbCadastroAlunos.Controls.Add(lblEmailAluno);
            this.tbCadastroAlunos.Controls.Add(this.eMAIL_ALUNOTextBox);
            this.tbCadastroAlunos.Controls.Add(lblCursoAluno);
            this.tbCadastroAlunos.Controls.Add(this.cURSOTextBox);
            this.tbCadastroAlunos.Controls.Add(lblNascimentoAluno);
            this.tbCadastroAlunos.Controls.Add(this.nASCIMENTO_ALUNODateTimePicker);
            this.tbCadastroAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCadastroAlunos.Location = new System.Drawing.Point(4, 22);
            this.tbCadastroAlunos.Name = "tbCadastroAlunos";
            this.tbCadastroAlunos.Padding = new System.Windows.Forms.Padding(3);
            this.tbCadastroAlunos.Size = new System.Drawing.Size(1000, 511);
            this.tbCadastroAlunos.TabIndex = 0;
            this.tbCadastroAlunos.Text = "Cadastro de Alunos";
            this.tbCadastroAlunos.UseVisualStyleBackColor = true;
            // 
            // alunosBindingNavigator
            // 
            this.alunosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.alunosBindingNavigator.BindingSource = this.alunosBindingSource;
            this.alunosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.alunosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.alunosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.alunosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.alunosBindingNavigatorSaveItem});
            this.alunosBindingNavigator.Location = new System.Drawing.Point(5, 3);
            this.alunosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.alunosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.alunosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.alunosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.alunosBindingNavigator.Name = "alunosBindingNavigator";
            this.alunosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.alunosBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.alunosBindingNavigator.TabIndex = 1;
            this.alunosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // alunosBindingNavigatorSaveItem
            // 
            this.alunosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alunosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("alunosBindingNavigatorSaveItem.Image")));
            this.alunosBindingNavigatorSaveItem.Name = "alunosBindingNavigatorSaveItem";
            this.alunosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.alunosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.alunosBindingNavigatorSaveItem.Click += new System.EventHandler(this.alunosBindingNavigatorSaveItem_Click);
            // 
            // txtIdentificadorAluno
            // 
            this.txtIdentificadorAluno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "ID_ALUNO", true));
            this.txtIdentificadorAluno.Enabled = false;
            this.txtIdentificadorAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificadorAluno.Location = new System.Drawing.Point(11, 60);
            this.txtIdentificadorAluno.Name = "txtIdentificadorAluno";
            this.txtIdentificadorAluno.Size = new System.Drawing.Size(77, 22);
            this.txtIdentificadorAluno.TabIndex = 1;
            // 
            // nOME_ALUNOTextBox
            // 
            this.nOME_ALUNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "NOME_ALUNO", true));
            this.nOME_ALUNOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nOME_ALUNOTextBox.Location = new System.Drawing.Point(94, 60);
            this.nOME_ALUNOTextBox.Name = "nOME_ALUNOTextBox";
            this.nOME_ALUNOTextBox.Size = new System.Drawing.Size(303, 22);
            this.nOME_ALUNOTextBox.TabIndex = 3;
            // 
            // tELEFONE_ALUNOMaskedTextBox
            // 
            this.tELEFONE_ALUNOMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "TELEFONE_ALUNO", true));
            this.tELEFONE_ALUNOMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tELEFONE_ALUNOMaskedTextBox.Location = new System.Drawing.Point(403, 60);
            this.tELEFONE_ALUNOMaskedTextBox.Name = "tELEFONE_ALUNOMaskedTextBox";
            this.tELEFONE_ALUNOMaskedTextBox.Size = new System.Drawing.Size(126, 22);
            this.tELEFONE_ALUNOMaskedTextBox.TabIndex = 5;
            // 
            // eMAIL_ALUNOTextBox
            // 
            this.eMAIL_ALUNOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "EMAIL_ALUNO", true));
            this.eMAIL_ALUNOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eMAIL_ALUNOTextBox.Location = new System.Drawing.Point(535, 60);
            this.eMAIL_ALUNOTextBox.Name = "eMAIL_ALUNOTextBox";
            this.eMAIL_ALUNOTextBox.Size = new System.Drawing.Size(200, 22);
            this.eMAIL_ALUNOTextBox.TabIndex = 7;
            // 
            // cURSOTextBox
            // 
            this.cURSOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.alunosBindingSource, "CURSO", true));
            this.cURSOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cURSOTextBox.Location = new System.Drawing.Point(740, 60);
            this.cURSOTextBox.Name = "cURSOTextBox";
            this.cURSOTextBox.Size = new System.Drawing.Size(120, 22);
            this.cURSOTextBox.TabIndex = 9;
            // 
            // nASCIMENTO_ALUNODateTimePicker
            // 
            this.nASCIMENTO_ALUNODateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.alunosBindingSource, "NASCIMENTO_ALUNO", true));
            this.nASCIMENTO_ALUNODateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nASCIMENTO_ALUNODateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.nASCIMENTO_ALUNODateTimePicker.Location = new System.Drawing.Point(865, 58);
            this.nASCIMENTO_ALUNODateTimePicker.Name = "nASCIMENTO_ALUNODateTimePicker";
            this.nASCIMENTO_ALUNODateTimePicker.Size = new System.Drawing.Size(130, 22);
            this.nASCIMENTO_ALUNODateTimePicker.TabIndex = 11;
            // 
            // tpPesquisarAlunos
            // 
            this.tpPesquisarAlunos.Controls.Add(this.dgvAlunosPesquisados);
            this.tpPesquisarAlunos.Controls.Add(this.btnPesquisarAlunos);
            this.tpPesquisarAlunos.Controls.Add(this.txtPesquisaControleEscolar);
            this.tpPesquisarAlunos.Controls.Add(this.rbPesquisarPorCurso);
            this.tpPesquisarAlunos.Controls.Add(this.rbPesquisarPorAluno);
            this.tpPesquisarAlunos.Controls.Add(this.lblFormaPesquisa);
            this.tpPesquisarAlunos.Location = new System.Drawing.Point(4, 22);
            this.tpPesquisarAlunos.Name = "tpPesquisarAlunos";
            this.tpPesquisarAlunos.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisarAlunos.Size = new System.Drawing.Size(1000, 511);
            this.tpPesquisarAlunos.TabIndex = 1;
            this.tpPesquisarAlunos.Text = "Pesquisar Alunos";
            this.tpPesquisarAlunos.UseVisualStyleBackColor = true;
            // 
            // dtgAlunos
            // 
            this.dtgAlunos.AllowUserToAddRows = false;
            this.dtgAlunos.AllowUserToDeleteRows = false;
            this.dtgAlunos.AutoGenerateColumns = false;
            this.dtgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dtgAlunos.DataSource = this.alunosBindingSource;
            this.dtgAlunos.Location = new System.Drawing.Point(11, 88);
            this.dtgAlunos.Name = "dtgAlunos";
            this.dtgAlunos.ReadOnly = true;
            this.dtgAlunos.RowHeadersVisible = false;
            this.dtgAlunos.Size = new System.Drawing.Size(983, 423);
            this.dtgAlunos.TabIndex = 13;
            // 
            // lblFormaPesquisa
            // 
            this.lblFormaPesquisa.AutoSize = true;
            this.lblFormaPesquisa.Location = new System.Drawing.Point(8, 14);
            this.lblFormaPesquisa.Name = "lblFormaPesquisa";
            this.lblFormaPesquisa.Size = new System.Drawing.Size(146, 13);
            this.lblFormaPesquisa.TabIndex = 0;
            this.lblFormaPesquisa.Text = "Escolha a forma de pesquisa:";
            // 
            // rbPesquisarPorAluno
            // 
            this.rbPesquisarPorAluno.AutoSize = true;
            this.rbPesquisarPorAluno.Location = new System.Drawing.Point(11, 30);
            this.rbPesquisarPorAluno.Name = "rbPesquisarPorAluno";
            this.rbPesquisarPorAluno.Size = new System.Drawing.Size(52, 17);
            this.rbPesquisarPorAluno.TabIndex = 1;
            this.rbPesquisarPorAluno.Text = "Aluno";
            this.rbPesquisarPorAluno.UseVisualStyleBackColor = true;
            // 
            // rbPesquisarPorCurso
            // 
            this.rbPesquisarPorCurso.AutoSize = true;
            this.rbPesquisarPorCurso.Checked = true;
            this.rbPesquisarPorCurso.Location = new System.Drawing.Point(102, 30);
            this.rbPesquisarPorCurso.Name = "rbPesquisarPorCurso";
            this.rbPesquisarPorCurso.Size = new System.Drawing.Size(52, 17);
            this.rbPesquisarPorCurso.TabIndex = 1;
            this.rbPesquisarPorCurso.TabStop = true;
            this.rbPesquisarPorCurso.Text = "Curso";
            this.rbPesquisarPorCurso.UseVisualStyleBackColor = true;
            // 
            // txtPesquisaControleEscolar
            // 
            this.txtPesquisaControleEscolar.Location = new System.Drawing.Point(11, 54);
            this.txtPesquisaControleEscolar.Name = "txtPesquisaControleEscolar";
            this.txtPesquisaControleEscolar.Size = new System.Drawing.Size(835, 20);
            this.txtPesquisaControleEscolar.TabIndex = 2;
            // 
            // btnPesquisarAlunos
            // 
            this.btnPesquisarAlunos.Location = new System.Drawing.Point(852, 53);
            this.btnPesquisarAlunos.Name = "btnPesquisarAlunos";
            this.btnPesquisarAlunos.Size = new System.Drawing.Size(142, 23);
            this.btnPesquisarAlunos.TabIndex = 3;
            this.btnPesquisarAlunos.Text = "Pesquisar";
            this.btnPesquisarAlunos.UseVisualStyleBackColor = true;
            this.btnPesquisarAlunos.Click += new System.EventHandler(this.btnPesquisarAlunos_Click);
            // 
            // dgvAlunosPesquisados
            // 
            this.dgvAlunosPesquisados.AllowUserToAddRows = false;
            this.dgvAlunosPesquisados.AllowUserToDeleteRows = false;
            this.dgvAlunosPesquisados.AutoGenerateColumns = false;
            this.dgvAlunosPesquisados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunosPesquisados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvAlunosPesquisados.DataSource = this.alunosBindingSource;
            this.dgvAlunosPesquisados.Location = new System.Drawing.Point(11, 82);
            this.dgvAlunosPesquisados.Name = "dgvAlunosPesquisados";
            this.dgvAlunosPesquisados.ReadOnly = true;
            this.dgvAlunosPesquisados.RowHeadersVisible = false;
            this.dgvAlunosPesquisados.Size = new System.Drawing.Size(983, 423);
            this.dgvAlunosPesquisados.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ALUNO";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOME_ALUNO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Aluno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TELEFONE_ALUNO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "EMAIL_ALUNO";
            this.dataGridViewTextBoxColumn4.HeaderText = "E-mail:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CURSO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Curso:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NASCIMENTO_ALUNO";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data de Nascimento:";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.controleEscolarMBDataSet;
            // 
            // controleEscolarMBDataSet
            // 
            this.controleEscolarMBDataSet.DataSetName = "ControleEscolarMBDataSet";
            this.controleEscolarMBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ID_ALUNO";
            this.dataGridViewTextBoxColumn7.Frozen = true;
            this.dataGridViewTextBoxColumn7.HeaderText = "Identificador";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "NOME_ALUNO";
            this.dataGridViewTextBoxColumn8.HeaderText = "Nome do Aluno";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 400;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TELEFONE_ALUNO";
            this.dataGridViewTextBoxColumn9.HeaderText = "Telefone:";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 120;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "EMAIL_ALUNO";
            this.dataGridViewTextBoxColumn10.HeaderText = "E-mail:";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 150;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "CURSO";
            this.dataGridViewTextBoxColumn11.HeaderText = "Curso:";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "NASCIMENTO_ALUNO";
            this.dataGridViewTextBoxColumn12.HeaderText = "Data de Nascimento:";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // alunosTableAdapter
            // 
            this.alunosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = this.alunosTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = ProgramadorCSharp3._0_PreparaCursos.ControleEscolarMBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmControleDeAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.tcControleAlunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmControleDeAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Alunos";
            this.Load += new System.EventHandler(this.frmControleDeAluno_Load);
            this.tcControleAlunos.ResumeLayout(false);
            this.tbCadastroAlunos.ResumeLayout(false);
            this.tbCadastroAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingNavigator)).EndInit();
            this.alunosBindingNavigator.ResumeLayout(false);
            this.alunosBindingNavigator.PerformLayout();
            this.tpPesquisarAlunos.ResumeLayout(false);
            this.tpPesquisarAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAlunos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunosPesquisados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleEscolarMBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcControleAlunos;
        private System.Windows.Forms.TabPage tbCadastroAlunos;
        private System.Windows.Forms.TabPage tpPesquisarAlunos;
        private ControleEscolarMBDataSet controleEscolarMBDataSet;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private ControleEscolarMBDataSetTableAdapters.AlunosTableAdapter alunosTableAdapter;
        private ControleEscolarMBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator alunosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton alunosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtIdentificadorAluno;
        private System.Windows.Forms.TextBox nOME_ALUNOTextBox;
        private System.Windows.Forms.MaskedTextBox tELEFONE_ALUNOMaskedTextBox;
        private System.Windows.Forms.TextBox eMAIL_ALUNOTextBox;
        private System.Windows.Forms.TextBox cURSOTextBox;
        private System.Windows.Forms.DateTimePicker nASCIMENTO_ALUNODateTimePicker;
        private System.Windows.Forms.DataGridView dtgAlunos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btnPesquisarAlunos;
        private System.Windows.Forms.TextBox txtPesquisaControleEscolar;
        private System.Windows.Forms.RadioButton rbPesquisarPorCurso;
        private System.Windows.Forms.RadioButton rbPesquisarPorAluno;
        private System.Windows.Forms.Label lblFormaPesquisa;
        private System.Windows.Forms.DataGridView dgvAlunosPesquisados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}
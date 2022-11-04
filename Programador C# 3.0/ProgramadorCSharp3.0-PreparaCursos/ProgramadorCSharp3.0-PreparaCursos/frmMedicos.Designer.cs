namespace ProgramadorCSharp3._0_PreparaCursos
{
    partial class frmCadastroMedicos
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
            System.Windows.Forms.Label lblIdentificadorMedico;
            System.Windows.Forms.Label lblNomeMedico;
            System.Windows.Forms.Label lblTelefoneMedico;
            System.Windows.Forms.Label lblvalorConsulta;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroMedicos));
            this.controleDeConsultorioMB = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMB();
            this.medicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicoTableAdapter = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.MedicoTableAdapter();
            this.tableAdapterManager = new ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.TableAdapterManager();
            this.medicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.medicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnFecharFrmMedicos = new System.Windows.Forms.ToolStripButton();
            this.txtIdentificadorMedico = new System.Windows.Forms.TextBox();
            this._NOME_MEDICOTextBox = new System.Windows.Forms.TextBox();
            this.tELEFONE_MEDICOMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.vALOR_CONSULTATextBox = new System.Windows.Forms.TextBox();
            this.gbCadastrarNovoMedico = new System.Windows.Forms.GroupBox();
            this.gbPesquisarMedicos = new System.Windows.Forms.GroupBox();
            this.rbPesquisarPorNomeMedico = new MetroFramework.Controls.MetroRadioButton();
            this.rbPesquisarPorIdentificador = new MetroFramework.Controls.MetroRadioButton();
            this.dgvMedicos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lblIdentificadorMedico = new System.Windows.Forms.Label();
            lblNomeMedico = new System.Windows.Forms.Label();
            lblTelefoneMedico = new System.Windows.Forms.Label();
            lblvalorConsulta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controleDeConsultorioMB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingNavigator)).BeginInit();
            this.medicoBindingNavigator.SuspendLayout();
            this.gbCadastrarNovoMedico.SuspendLayout();
            this.gbPesquisarMedicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIdentificadorMedico
            // 
            lblIdentificadorMedico.AutoSize = true;
            lblIdentificadorMedico.Location = new System.Drawing.Point(12, 22);
            lblIdentificadorMedico.Name = "lblIdentificadorMedico";
            lblIdentificadorMedico.Size = new System.Drawing.Size(68, 13);
            lblIdentificadorMedico.TabIndex = 1;
            lblIdentificadorMedico.Text = "Identificador:";
            // 
            // lblNomeMedico
            // 
            lblNomeMedico.AutoSize = true;
            lblNomeMedico.Location = new System.Drawing.Point(84, 22);
            lblNomeMedico.Name = "lblNomeMedico";
            lblNomeMedico.Size = new System.Drawing.Size(88, 13);
            lblNomeMedico.TabIndex = 3;
            lblNomeMedico.Text = "Nome do Médico";
            // 
            // lblTelefoneMedico
            // 
            lblTelefoneMedico.AutoSize = true;
            lblTelefoneMedico.Location = new System.Drawing.Point(734, 22);
            lblTelefoneMedico.Name = "lblTelefoneMedico";
            lblTelefoneMedico.Size = new System.Drawing.Size(105, 13);
            lblTelefoneMedico.TabIndex = 5;
            lblTelefoneMedico.Text = "Telefone do Médico:";
            // 
            // lblvalorConsulta
            // 
            lblvalorConsulta.AutoSize = true;
            lblvalorConsulta.Location = new System.Drawing.Point(869, 22);
            lblvalorConsulta.Name = "lblvalorConsulta";
            lblvalorConsulta.Size = new System.Drawing.Size(93, 13);
            lblvalorConsulta.TabIndex = 7;
            lblvalorConsulta.Text = "Valor da Consulta:";
            // 
            // controleDeConsultorioMB
            // 
            this.controleDeConsultorioMB.DataSetName = "ControleDeConsultorioMB";
            this.controleDeConsultorioMB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicoBindingSource
            // 
            this.medicoBindingSource.DataMember = "Medico";
            this.medicoBindingSource.DataSource = this.controleDeConsultorioMB;
            // 
            // medicoTableAdapter
            // 
            this.medicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsultasTableAdapter = null;
            this.tableAdapterManager.MedicoTableAdapter = this.medicoTableAdapter;
            this.tableAdapterManager.PacienteTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProgramadorCSharp3._0_PreparaCursos.ControleDeConsultorioMBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicoBindingNavigator
            // 
            this.medicoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicoBindingNavigator.BindingSource = this.medicoBindingSource;
            this.medicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.medicoBindingNavigatorSaveItem,
            this.btnFecharFrmMedicos});
            this.medicoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicoBindingNavigator.Name = "medicoBindingNavigator";
            this.medicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicoBindingNavigator.Size = new System.Drawing.Size(974, 25);
            this.medicoBindingNavigator.TabIndex = 0;
            this.medicoBindingNavigator.Text = "bindingNavigator1";
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
            // medicoBindingNavigatorSaveItem
            // 
            this.medicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicoBindingNavigatorSaveItem.Image")));
            this.medicoBindingNavigatorSaveItem.Name = "medicoBindingNavigatorSaveItem";
            this.medicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.medicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.medicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicoBindingNavigatorSaveItem_Click);
            // 
            // btnFecharFrmMedicos
            // 
            this.btnFecharFrmMedicos.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnFecharFrmMedicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFecharFrmMedicos.Image = global::ProgramadorCSharp3._0_PreparaCursos.Properties.Resources.close_icon;
            this.btnFecharFrmMedicos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFecharFrmMedicos.Name = "btnFecharFrmMedicos";
            this.btnFecharFrmMedicos.Size = new System.Drawing.Size(23, 22);
            this.btnFecharFrmMedicos.Text = "toolStripButton1";
            this.btnFecharFrmMedicos.Click += new System.EventHandler(this.btnFecharFrmMedicos_Click);
            // 
            // txtIdentificadorMedico
            // 
            this.txtIdentificadorMedico.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "ID_MEDICO", true));
            this.txtIdentificadorMedico.Location = new System.Drawing.Point(15, 38);
            this.txtIdentificadorMedico.Name = "txtIdentificadorMedico";
            this.txtIdentificadorMedico.Size = new System.Drawing.Size(65, 20);
            this.txtIdentificadorMedico.TabIndex = 2;
            // 
            // _NOME_MEDICOTextBox
            // 
            this._NOME_MEDICOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, " NOME_MEDICO", true));
            this._NOME_MEDICOTextBox.Location = new System.Drawing.Point(87, 38);
            this._NOME_MEDICOTextBox.Name = "_NOME_MEDICOTextBox";
            this._NOME_MEDICOTextBox.Size = new System.Drawing.Size(644, 20);
            this._NOME_MEDICOTextBox.TabIndex = 4;
            // 
            // tELEFONE_MEDICOMaskedTextBox
            // 
            this.tELEFONE_MEDICOMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "TELEFONE_MEDICO", true));
            this.tELEFONE_MEDICOMaskedTextBox.Location = new System.Drawing.Point(737, 38);
            this.tELEFONE_MEDICOMaskedTextBox.Mask = "(99) 9-0000-0000";
            this.tELEFONE_MEDICOMaskedTextBox.Name = "tELEFONE_MEDICOMaskedTextBox";
            this.tELEFONE_MEDICOMaskedTextBox.Size = new System.Drawing.Size(129, 20);
            this.tELEFONE_MEDICOMaskedTextBox.TabIndex = 6;
            // 
            // vALOR_CONSULTATextBox
            // 
            this.vALOR_CONSULTATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicoBindingSource, "VALOR_CONSULTA", true));
            this.vALOR_CONSULTATextBox.Location = new System.Drawing.Point(872, 38);
            this.vALOR_CONSULTATextBox.Name = "vALOR_CONSULTATextBox";
            this.vALOR_CONSULTATextBox.Size = new System.Drawing.Size(90, 20);
            this.vALOR_CONSULTATextBox.TabIndex = 8;
            // 
            // gbCadastrarNovoMedico
            // 
            this.gbCadastrarNovoMedico.Controls.Add(lblIdentificadorMedico);
            this.gbCadastrarNovoMedico.Controls.Add(this.vALOR_CONSULTATextBox);
            this.gbCadastrarNovoMedico.Controls.Add(lblvalorConsulta);
            this.gbCadastrarNovoMedico.Controls.Add(this.tELEFONE_MEDICOMaskedTextBox);
            this.gbCadastrarNovoMedico.Controls.Add(lblTelefoneMedico);
            this.gbCadastrarNovoMedico.Controls.Add(this._NOME_MEDICOTextBox);
            this.gbCadastrarNovoMedico.Controls.Add(lblNomeMedico);
            this.gbCadastrarNovoMedico.Controls.Add(this.txtIdentificadorMedico);
            this.gbCadastrarNovoMedico.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCadastrarNovoMedico.Location = new System.Drawing.Point(0, 25);
            this.gbCadastrarNovoMedico.Name = "gbCadastrarNovoMedico";
            this.gbCadastrarNovoMedico.Size = new System.Drawing.Size(974, 70);
            this.gbCadastrarNovoMedico.TabIndex = 9;
            this.gbCadastrarNovoMedico.TabStop = false;
            this.gbCadastrarNovoMedico.Text = "Cadastrar Novo Médico";
            // 
            // gbPesquisarMedicos
            // 
            this.gbPesquisarMedicos.Controls.Add(this.rbPesquisarPorNomeMedico);
            this.gbPesquisarMedicos.Controls.Add(this.rbPesquisarPorIdentificador);
            this.gbPesquisarMedicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPesquisarMedicos.Location = new System.Drawing.Point(0, 95);
            this.gbPesquisarMedicos.Name = "gbPesquisarMedicos";
            this.gbPesquisarMedicos.Size = new System.Drawing.Size(974, 78);
            this.gbPesquisarMedicos.TabIndex = 10;
            this.gbPesquisarMedicos.TabStop = false;
            this.gbPesquisarMedicos.Text = "Pesquisar Médico";
            // 
            // rbPesquisarPorNomeMedico
            // 
            this.rbPesquisarPorNomeMedico.AutoSize = true;
            this.rbPesquisarPorNomeMedico.Location = new System.Drawing.Point(104, 19);
            this.rbPesquisarPorNomeMedico.Name = "rbPesquisarPorNomeMedico";
            this.rbPesquisarPorNomeMedico.Size = new System.Drawing.Size(116, 15);
            this.rbPesquisarPorNomeMedico.TabIndex = 1;
            this.rbPesquisarPorNomeMedico.Text = "Nome do Médico";
            this.rbPesquisarPorNomeMedico.UseSelectable = true;
            // 
            // rbPesquisarPorIdentificador
            // 
            this.rbPesquisarPorIdentificador.AutoSize = true;
            this.rbPesquisarPorIdentificador.Location = new System.Drawing.Point(8, 19);
            this.rbPesquisarPorIdentificador.Name = "rbPesquisarPorIdentificador";
            this.rbPesquisarPorIdentificador.Size = new System.Drawing.Size(90, 15);
            this.rbPesquisarPorIdentificador.TabIndex = 0;
            this.rbPesquisarPorIdentificador.Text = "Identificador";
            this.rbPesquisarPorIdentificador.UseSelectable = true;
            // 
            // dgvMedicos
            // 
            this.dgvMedicos.AllowUserToAddRows = false;
            this.dgvMedicos.AllowUserToDeleteRows = false;
            this.dgvMedicos.AutoGenerateColumns = false;
            this.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgvMedicos.DataSource = this.medicoBindingSource;
            this.dgvMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedicos.Location = new System.Drawing.Point(0, 173);
            this.dgvMedicos.Name = "dgvMedicos";
            this.dgvMedicos.RowHeadersVisible = false;
            this.dgvMedicos.Size = new System.Drawing.Size(974, 307);
            this.dgvMedicos.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_MEDICO";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identificador:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = " NOME_MEDICO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do Médico";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 590;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TELEFONE_MEDICO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefone:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "VALOR_CONSULTA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor da Consulta:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 115;
            // 
            // frmCadastroMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 480);
            this.Controls.Add(this.dgvMedicos);
            this.Controls.Add(this.gbPesquisarMedicos);
            this.Controls.Add(this.gbCadastrarNovoMedico);
            this.Controls.Add(this.medicoBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCadastroMedicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Médicos";
            this.Load += new System.EventHandler(this.frmCadastroMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controleDeConsultorioMB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicoBindingNavigator)).EndInit();
            this.medicoBindingNavigator.ResumeLayout(false);
            this.medicoBindingNavigator.PerformLayout();
            this.gbCadastrarNovoMedico.ResumeLayout(false);
            this.gbCadastrarNovoMedico.PerformLayout();
            this.gbPesquisarMedicos.ResumeLayout(false);
            this.gbPesquisarMedicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControleDeConsultorioMB controleDeConsultorioMB;
        private System.Windows.Forms.BindingSource medicoBindingSource;
        private ControleDeConsultorioMBTableAdapters.MedicoTableAdapter medicoTableAdapter;
        private ControleDeConsultorioMBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton medicoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtIdentificadorMedico;
        private System.Windows.Forms.TextBox _NOME_MEDICOTextBox;
        private System.Windows.Forms.MaskedTextBox tELEFONE_MEDICOMaskedTextBox;
        private System.Windows.Forms.TextBox vALOR_CONSULTATextBox;
        private System.Windows.Forms.GroupBox gbCadastrarNovoMedico;
        private System.Windows.Forms.GroupBox gbPesquisarMedicos;
        private MetroFramework.Controls.MetroRadioButton rbPesquisarPorNomeMedico;
        private MetroFramework.Controls.MetroRadioButton rbPesquisarPorIdentificador;
        private System.Windows.Forms.DataGridView dgvMedicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripButton btnFecharFrmMedicos;
    }
}
namespace CursoDeCSharp_PreparaCursos
{
    partial class frmControleDespesas
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
            System.Windows.Forms.Label iD_CONTALabel;
            System.Windows.Forms.Label lblDescricao;
            System.Windows.Forms.Label lblDataConta;
            System.Windows.Forms.Label lblCategoria;
            System.Windows.Forms.Label vALORLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleDespesas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.controleDespesasMBDataSet = new CursoDeCSharp_PreparaCursos.ControleDespesasMBDataSet();
            this.contasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contasTableAdapter = new CursoDeCSharp_PreparaCursos.ControleDespesasMBDataSetTableAdapters.ContasTableAdapter();
            this.tableAdapterManager = new CursoDeCSharp_PreparaCursos.ControleDespesasMBDataSetTableAdapters.TableAdapterManager();
            this.contasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtIdentificadorConta = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dATADateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cATEGORIATextBox = new System.Windows.Forms.TextBox();
            this.vALORTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbContas = new System.Windows.Forms.TabPage();
            this.tbPesquisar = new System.Windows.Forms.TabPage();
            this.contasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iD_CONTALabel = new System.Windows.Forms.Label();
            lblDescricao = new System.Windows.Forms.Label();
            lblDataConta = new System.Windows.Forms.Label();
            lblCategoria = new System.Windows.Forms.Label();
            vALORLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.controleDespesasMBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingNavigator)).BeginInit();
            this.contasBindingNavigator.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbContas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_CONTALabel
            // 
            iD_CONTALabel.AutoSize = true;
            iD_CONTALabel.Location = new System.Drawing.Point(10, 51);
            iD_CONTALabel.Name = "iD_CONTALabel";
            iD_CONTALabel.Size = new System.Drawing.Size(65, 13);
            iD_CONTALabel.TabIndex = 1;
            iD_CONTALabel.Text = "Identificador";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new System.Drawing.Point(81, 51);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new System.Drawing.Size(104, 13);
            lblDescricao.TabIndex = 3;
            lblDescricao.Text = "Descrição da Conta:";
            // 
            // lblDataConta
            // 
            lblDataConta.AutoSize = true;
            lblDataConta.Location = new System.Drawing.Point(553, 51);
            lblDataConta.Name = "lblDataConta";
            lblDataConta.Size = new System.Drawing.Size(33, 13);
            lblDataConta.TabIndex = 5;
            lblDataConta.Text = "Data:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new System.Drawing.Point(469, 51);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new System.Drawing.Size(55, 13);
            lblCategoria.TabIndex = 7;
            lblCategoria.Text = "Categoria:";
            // 
            // vALORLabel
            // 
            vALORLabel.AutoSize = true;
            vALORLabel.Location = new System.Drawing.Point(644, 51);
            vALORLabel.Name = "vALORLabel";
            vALORLabel.Size = new System.Drawing.Size(46, 13);
            vALORLabel.TabIndex = 9;
            vALORLabel.Text = "VALOR:";
            // 
            // controleDespesasMBDataSet
            // 
            this.controleDespesasMBDataSet.DataSetName = "ControleDespesasMBDataSet";
            this.controleDespesasMBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contasBindingSource
            // 
            this.contasBindingSource.DataMember = "Contas";
            this.contasBindingSource.DataSource = this.controleDespesasMBDataSet;
            // 
            // contasTableAdapter
            // 
            this.contasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ContasTableAdapter = this.contasTableAdapter;
            this.tableAdapterManager.UpdateOrder = CursoDeCSharp_PreparaCursos.ControleDespesasMBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contasBindingNavigator
            // 
            this.contasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contasBindingNavigator.BindingSource = this.contasBindingSource;
            this.contasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contasBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.contasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contasBindingNavigatorSaveItem});
            this.contasBindingNavigator.Location = new System.Drawing.Point(13, 12);
            this.contasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contasBindingNavigator.Name = "contasBindingNavigator";
            this.contasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contasBindingNavigator.Size = new System.Drawing.Size(280, 25);
            this.contasBindingNavigator.TabIndex = 0;
            this.contasBindingNavigator.Text = "bindingNavigator1";
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
            // contasBindingNavigatorSaveItem
            // 
            this.contasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contasBindingNavigatorSaveItem.Image")));
            this.contasBindingNavigatorSaveItem.Name = "contasBindingNavigatorSaveItem";
            this.contasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contasBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.contasBindingNavigatorSaveItem.Click += new System.EventHandler(this.contasBindingNavigatorSaveItem_Click_1);
            // 
            // txtIdentificadorConta
            // 
            this.txtIdentificadorConta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "ID_CONTA", true));
            this.txtIdentificadorConta.Enabled = false;
            this.txtIdentificadorConta.Location = new System.Drawing.Point(10, 67);
            this.txtIdentificadorConta.Name = "txtIdentificadorConta";
            this.txtIdentificadorConta.Size = new System.Drawing.Size(62, 20);
            this.txtIdentificadorConta.TabIndex = 2;
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "DESCRICAO", true));
            this.txtDescricao.Location = new System.Drawing.Point(84, 67);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(375, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // dATADateTimePicker
            // 
            this.dATADateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.contasBindingSource, "DATA", true));
            this.dATADateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dATADateTimePicker.Location = new System.Drawing.Point(556, 67);
            this.dATADateTimePicker.Name = "dATADateTimePicker";
            this.dATADateTimePicker.Size = new System.Drawing.Size(80, 20);
            this.dATADateTimePicker.TabIndex = 6;
            // 
            // cATEGORIATextBox
            // 
            this.cATEGORIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "CATEGORIA", true));
            this.cATEGORIATextBox.Location = new System.Drawing.Point(472, 67);
            this.cATEGORIATextBox.Name = "cATEGORIATextBox";
            this.cATEGORIATextBox.Size = new System.Drawing.Size(69, 20);
            this.cATEGORIATextBox.TabIndex = 8;
            // 
            // vALORTextBox
            // 
            this.vALORTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contasBindingSource, "VALOR", true));
            this.vALORTextBox.Location = new System.Drawing.Point(647, 67);
            this.vALORTextBox.Name = "vALORTextBox";
            this.vALORTextBox.Size = new System.Drawing.Size(84, 20);
            this.vALORTextBox.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbContas);
            this.tabControl1.Controls.Add(this.tbPesquisar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 393);
            this.tabControl1.TabIndex = 11;
            // 
            // tbContas
            // 
            this.tbContas.AutoScroll = true;
            this.tbContas.Controls.Add(this.contasDataGridView);
            this.tbContas.Controls.Add(this.contasBindingNavigator);
            this.tbContas.Controls.Add(iD_CONTALabel);
            this.tbContas.Controls.Add(this.vALORTextBox);
            this.tbContas.Controls.Add(this.txtIdentificadorConta);
            this.tbContas.Controls.Add(vALORLabel);
            this.tbContas.Controls.Add(lblDescricao);
            this.tbContas.Controls.Add(this.cATEGORIATextBox);
            this.tbContas.Controls.Add(this.txtDescricao);
            this.tbContas.Controls.Add(lblCategoria);
            this.tbContas.Controls.Add(lblDataConta);
            this.tbContas.Controls.Add(this.dATADateTimePicker);
            this.tbContas.Location = new System.Drawing.Point(4, 22);
            this.tbContas.Name = "tbContas";
            this.tbContas.Padding = new System.Windows.Forms.Padding(3);
            this.tbContas.Size = new System.Drawing.Size(744, 367);
            this.tbContas.TabIndex = 0;
            this.tbContas.Text = "Contas";
            this.tbContas.UseVisualStyleBackColor = true;
            // 
            // tbPesquisar
            // 
            this.tbPesquisar.Location = new System.Drawing.Point(4, 22);
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tbPesquisar.Size = new System.Drawing.Size(744, 367);
            this.tbPesquisar.TabIndex = 1;
            this.tbPesquisar.Text = "Pesquisar";
            this.tbPesquisar.UseVisualStyleBackColor = true;
            // 
            // contasDataGridView
            // 
            this.contasDataGridView.AutoGenerateColumns = false;
            this.contasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.contasDataGridView.DataSource = this.contasBindingSource;
            this.contasDataGridView.Location = new System.Drawing.Point(10, 105);
            this.contasDataGridView.Name = "contasDataGridView";
            this.contasDataGridView.RowHeadersVisible = false;
            this.contasDataGridView.Size = new System.Drawing.Size(721, 256);
            this.contasDataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_CONTA";
            this.dataGridViewTextBoxColumn1.HeaderText = "Identificador:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRICAO";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição da Conta:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 351;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DATA";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Data:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 75;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CATEGORIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoria:";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "VALOR";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmControleDespesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 393);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmControleDespesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControleDespesas";
            this.Load += new System.EventHandler(this.frmControleDespesas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controleDespesasMBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contasBindingNavigator)).EndInit();
            this.contasBindingNavigator.ResumeLayout(false);
            this.contasBindingNavigator.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbContas.ResumeLayout(false);
            this.tbContas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ControleDespesasMBDataSet controleDespesasMBDataSet;
        private System.Windows.Forms.BindingSource contasBindingSource;
        private ControleDespesasMBDataSetTableAdapters.ContasTableAdapter contasTableAdapter;
        private ControleDespesasMBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtIdentificadorConta;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DateTimePicker dATADateTimePicker;
        private System.Windows.Forms.TextBox cATEGORIATextBox;
        private System.Windows.Forms.TextBox vALORTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbContas;
        private System.Windows.Forms.TabPage tbPesquisar;
        private System.Windows.Forms.DataGridView contasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
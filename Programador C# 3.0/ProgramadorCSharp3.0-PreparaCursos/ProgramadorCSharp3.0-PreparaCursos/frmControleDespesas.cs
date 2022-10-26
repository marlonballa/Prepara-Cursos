using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramadorCSharp3._0_PreparaCursos
{
    public partial class frmControleDespesas : Form
    {
        public frmControleDespesas()
        {
            InitializeComponent();
        }

        private void contasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controleDespesasMBDataSet);

        }

        private void frmControleDespesas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controleDespesasMBDataSet.Contas'. Você pode movê-la ou removê-la conforme necessário.
            this.contasTableAdapter.Fill(this.controleDespesasMBDataSet.Contas);

        }

        private void btnPesquisarConta_Click(object sender, EventArgs e)
        {
            if (rbCategoria.Checked == true) { dtgContasPesquisadas.DataSource = contasTableAdapter.PesquisarCategoria(txtPesquisarConta.Text, dtpDataConta.Value.Date);} 
            else { dtgContasPesquisadas.DataSource = contasTableAdapter.PesquisarValor(Convert.ToDecimal(txtPesquisarConta.Text), dtpDataConta.Value.Date);  }
        }
    }
}

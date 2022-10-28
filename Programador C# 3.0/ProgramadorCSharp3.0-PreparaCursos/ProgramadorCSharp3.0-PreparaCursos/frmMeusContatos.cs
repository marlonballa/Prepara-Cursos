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
    public partial class frmMeusContatos : MetroFramework.Forms.MetroForm
    {
        public frmMeusContatos()
        {
            InitializeComponent();
        }

        private void agendaDeContatosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaDeContatosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaContatosMB);

            Limpar();
        }

        private void frmMeusContatos_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'agendaContatosMB.AgendaDeContatos'. Você pode movê-la ou removê-la conforme necessário.
            this.agendaDeContatosTableAdapter.Fill(this.agendaContatosMB.AgendaDeContatos);
            Limpar();

        }

        private void btnPesquisarEmContatos_Click(object sender, EventArgs e)
        {
            if (rbPesquisarNomeContato.Checked == false && rbPesquisarTelefoneContato.Checked == false || txtInformacaoDePesquisaDeContato.Text == "") { MessageBox.Show("Você deve escolher o tipo de pesquisa e informar um valor a ser pesquisado!", "Eita...", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                if (rbPesquisarNomeContato.Checked == true)
                { dgvAgendaContatos.DataSource = agendaDeContatosTableAdapter.PesquisarContatoPorNome(txtInformacaoDePesquisaDeContato.Text); }
                else
                { dgvAgendaContatos.DataSource = agendaDeContatosTableAdapter.PesquisarContatoPorTelefone(txtInformacaoDePesquisaDeContato.Text); }
            }
        }

        private void lblShowAllContacts_Click(object sender, EventArgs e)
        {
            dgvAgendaContatos.DataSource = agendaDeContatosTableAdapter.RetornarTodosOsContatos();
        }

        public void Limpar()
        {
            txtIdentificadorContato.Clear();
            txtNomeContato.Clear();
            txtTelefoneContato.Clear();
            cbEDaFamilia.Checked = false;
        }
    }
}

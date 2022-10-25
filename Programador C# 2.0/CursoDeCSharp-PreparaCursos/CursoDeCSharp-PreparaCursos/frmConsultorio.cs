using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoDeCSharp_PreparaCursos
{
    public partial class frmConsultorio : Form
    {
        public frmConsultorio()
        {
            InitializeComponent();
        }

        private void consultasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consultasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.consultorioDataSet);

        }

        private void frmConsultorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'consultorioDataSet.Consultas'. Você pode movê-la ou removê-la conforme necessário.
            this.consultasTableAdapter.Fill(this.consultorioDataSet.Consultas);

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rbMedico.Checked == true)
            {
                //Estamos informando que os valores que aparecerão na tabela de resultados de pesquisa, serão os valores provenientes do método: RetornarMedico().
                dtgPesquisa.DataSource = consultasTableAdapter.RetornarMedico(txtPesquisar.Text);
            }
            else
            {
                dtgPesquisa.DataSource = consultasTableAdapter.RetornarPaciente(txtPesquisar.Text);
            }
        }
    }
}

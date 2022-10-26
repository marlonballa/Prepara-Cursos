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
    public partial class frmControleDeAluno : Form
    {
        public frmControleDeAluno()
        {
            InitializeComponent();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.controleEscolarMBDataSet);

        }

        private void frmControleDeAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controleEscolarMBDataSet.Alunos'. Você pode movê-la ou removê-la conforme necessário.
            this.alunosTableAdapter.Fill(this.controleEscolarMBDataSet.Alunos);

        }

        private void btnPesquisarAlunos_Click(object sender, EventArgs e)
        {
            if (rbPesquisarPorAluno.Checked == true) { dgvAlunosPesquisados.DataSource = alunosTableAdapter.RetornarAluno(txtPesquisaControleEscolar.Text); }
            else { dgvAlunosPesquisados.DataSource = alunosTableAdapter.RetornarCurso(txtPesquisaControleEscolar.Text); }
        }
    }
}

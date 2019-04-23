using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using caAlunoMaterias;

namespace WindowsFormsApp1
{
    public partial class fAlunoMateria : Form
    {
        private List<Aluno> listaAlunos = new List<Aluno>();
        private List<Materia> listaMaterias = new List<Materia>();

        static Aluno achaAluno(String nome_aluno, List<Aluno> alunos)
        {
            Aluno achei_aluno = null;
            for (int i = 0; i < alunos.Count(); i++)
            {
                if (nome_aluno == alunos[i].getNome())
                {
                    achei_aluno = alunos[i];
                    break;
                }
            }
            return achei_aluno;
        }

        static Materia achaMateria(String nome_materia, List<Materia> materias)
        {
            Materia achei_materia = null;
            for (int i = 0; i < materias.Count(); i++)
            {
                if (nome_materia == materias[i].getNome())
                {
                    achei_materia = materias[i];
                    break;
                }
            }
            return achei_materia;
        }

        public fAlunoMateria()
        {
            InitializeComponent();
        }

        private void btCadastrarAluno_Click(object sender, EventArgs e)
        {
            listaAlunos.Add(new Aluno(tbNomeAluno.Text, tbMatriculaAluno.Text, int.Parse(tbPeriodoAluno.Text)));
            Alunos.Items.Add(tbNomeAluno.Text);
            tbNomeAluno.Text = "";
            tbMatriculaAluno.Text = "";
            tbPeriodoAluno.Text = "";
            Alunos.SetSelected(Alunos.Items.Count - 1, true);
        }

        private void btCadastrarMateria_Click(object sender, EventArgs e)
        {
            listaMaterias.Add(new Materia(tbNomeMateria.Text, tbCodigoMateria.Text));
            Materias.Items.Add(tbNomeMateria.Text);
            tbNomeMateria.Text = "";
            tbCodigoMateria.Text = "";
        }

        private void btAssociar_Click(object sender, EventArgs e)
        {
            achaAluno(Alunos.Items[Alunos.SelectedIndex].ToString(), listaAlunos).associaMateria(achaMateria(Materias.Items[Materias.SelectedIndex].ToString(), listaMaterias));
        }

        private void tpRelatorio_Enter(object sender, EventArgs e)
        {

            if (Alunos.Items.Count == 0)
            {
                return;
            }

            Aluno selecionado = achaAluno(Alunos.Items[Alunos.SelectedIndex].ToString(), listaAlunos);
            List<String> selecionadoMaterias = selecionado.imprimeRelatorio();
            Relatorio.Items.Add("Aluno " + selecionado.getNome());

            for (int i = 0; i < selecionadoMaterias.Count; i++)
            {
                Relatorio.Items.Add(selecionadoMaterias[i]);
            }
        }

        private void tpRelatorio_Leave(object sender, EventArgs e)
        {
            Relatorio.Items.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaEmpregadoHeranca
{
    public partial class Janela1 : Form
    {

        private List<EmpregadoCLT> empregadosCLT = new List<EmpregadoCLT>();
        private List<EmpregadoHorista> empregadosHoristas = new List<EmpregadoHorista>();

        private EmpregadoCLT procuraEmpregadoCLT(
            String _nome, List<EmpregadoCLT> _empregados)
        {
            foreach (EmpregadoCLT empregado in _empregados)
            {
                if (_nome == empregado.getNome())
                {
                    return empregado;
                }
            }
            return new EmpregadoCLT();
        }

        private EmpregadoHorista procuraEmpregadoHorista(
            String _nome, List<EmpregadoHorista> _empregados)
        {
            foreach (EmpregadoHorista empregado in _empregados)
            {
                if (_nome == empregado.getNome())
                {
                    return empregado;
                }
            }
            return new EmpregadoHorista();
        }

        public Janela1()
        {
            InitializeComponent();
        }

        private void cbHorista_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHorista.Checked == true)
            {
                cbCLT.Checked = false;
                lbSBrutoCLT.Visible = false;
                tbSBrutoCLT.Visible = false;
                lbNHoras.Visible = true;
                lbPrecoH.Visible = true;
                tbNHoras.Visible = true;
                tbPrecoH.Visible = true;
            }
            else
            {
                lbNHoras.Visible = false;
                lbPrecoH.Visible = false;
                tbNHoras.Visible = false;
                tbPrecoH.Visible = false;
            }
        }

        private void cbCLT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCLT.Checked == true)
            {
                cbHorista.Checked = false;
                lbSBrutoCLT.Visible = true;
                tbSBrutoCLT.Visible = true;
                lbNHoras.Visible = false;
                lbPrecoH.Visible = false;
                tbNHoras.Visible = false;
                tbPrecoH.Visible = false;
            }
            else
            {
                lbSBrutoCLT.Visible = false;
                tbSBrutoCLT.Visible = false;
            }
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (cbCLT.Checked == true && tbNome.Text != "" && tbCPF.Text != "" &&
                tbEndereco.Text != "" && tbSBrutoCLT.Text != "")
            {
                empregadosCLT.Add(new EmpregadoCLT(tbNome.Text, tbCPF.Text, tbEndereco.Text, double.Parse(tbSBrutoCLT.Text)));
                listbCLT.Items.Add(tbNome.Text);
                listbCLT.SetSelected(listbCLT.Items.Count - 1, true);
                tbNome.Text = tbCPF.Text = tbEndereco.Text = tbSBrutoCLT.Text = "";
            }
            else if (cbHorista.Checked == true && tbNome.Text != "" && tbCPF.Text != "" &&
                tbEndereco.Text != "" && tbNHoras.Text != "" && tbPrecoH.Text != "")
            {
                empregadosHoristas.Add(new EmpregadoHorista(tbNome.Text, tbCPF.Text, tbEndereco.Text, int.Parse(tbNHoras.Text),
                    double.Parse(tbPrecoH.Text)));
                listbHorista.Items.Add(tbNome.Text);
                listbHorista.SetSelected(listbHorista.Items.Count - 1, true);
                tbNome.Text = tbCPF.Text = tbEndereco.Text = tbNHoras.Text = tbPrecoH.Text = "";
            }
        }

        private void tabRelatorio_Leave(object sender, EventArgs e)
        {
            listbRelatorio.Items.Clear();
        }

        private void tabRelatorio_Enter(object sender, EventArgs e)
        {
            if (cbCLT.Checked == true && listbCLT.Items.Count != 0)
            {
                EmpregadoCLT selecionado = procuraEmpregadoCLT(
                    listbCLT.Items[listbCLT.SelectedIndex].ToString(),
                    empregadosCLT);
                listbRelatorio.Items.Add("Empregado CLT");
                listbRelatorio.Items.Add("Nome: " + selecionado.getNome());
                listbRelatorio.Items.Add("CPF: " + selecionado.getCpf());
                listbRelatorio.Items.Add("Endereço: " + selecionado.getEndereco());
                listbRelatorio.Items.Add("Salário Bruto: " + selecionado.getsBrutoCLT());
                listbRelatorio.Items.Add("Salário Líquido: " + selecionado.salarioLiq());
            }
            else if (cbHorista.Checked == true && listbHorista.Items.Count != 0)
            {
                EmpregadoHorista selecionado = procuraEmpregadoHorista(
                    listbHorista.Items[listbHorista.SelectedIndex].ToString(),
                    empregadosHoristas);
                listbRelatorio.Items.Add("Empregado Horista");
                listbRelatorio.Items.Add("Nome: " + selecionado.getNome());
                listbRelatorio.Items.Add("CPF: " + selecionado.getCpf());
                listbRelatorio.Items.Add("Endereço: " + selecionado.getEndereco());
                listbRelatorio.Items.Add("Horas Trabalhadas: " + selecionado.getnHoras());
                listbRelatorio.Items.Add("Preço da Hora: " + selecionado.getpHoras());
                listbRelatorio.Items.Add("Salário Líquido: " + selecionado.salarioLiq());
            }
        }
    }
}

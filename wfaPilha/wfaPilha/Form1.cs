using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using caPilha;

namespace wfaPilha
{
    public partial class formPilha : Form
    {

        private Pilha pilha;

        public formPilha()
        {
            InitializeComponent();
            pilha = new Pilha();
        }

        private void btPush_Click(object sender, EventArgs e)
        {
            string valor = tbPush.Text;
            if (valor == "")
            {
                return;
            }
            try
            {
                pilha.push(int.Parse(valor));
                tbPilha.Text = pilha.print();
                tbPush.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Informações de Entrada Inválidas",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btPop_Click(object sender, EventArgs e)
        {
            try
            {
                tbPop.Text = pilha.pop().ToString();
                tbPilha.Text = pilha.print();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Pilha Está Vazia",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btImprime_Click(object sender, EventArgs e)
        {
            tbPilha.Text = pilha.print();
        }

        private void btInverte_Click(object sender, EventArgs e)
        {
            tbPilha.Text = pilha.inversePrint();
        }

        private void btMenor_Click(object sender, EventArgs e)
        {
            try
            {
                tbPilha.Text = pilha.menor().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Pilha Está Vazia",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btMaior_Click(object sender, EventArgs e)
        {
            try
            {
                tbPilha.Text = pilha.maior().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Pilha Está Vazia",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wfaBuscaArquivo
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private string obtemInfoArquivo(string pathname)
        {
            string info = "";

            info = pathname + " existe\r\n\r\n";
            info += "Criado em: " + File.GetCreationTime(pathname) + "\r\n";
            info += "Modificado em: " + File.GetLastWriteTime(pathname) + "\r\n";
            info += "Acesso em: " + File.GetLastAccessTime(pathname) + "\r\n\r\n";

            return info;
        }

        private string listarDiretorios(string pathname)
        {
            string info;
            string[] dirs = Directory.GetDirectories(pathname), files = Directory.GetFiles(pathname);

            info = "Sub-Pastas: \r\n";
            for(int i = 0; i < dirs.Length; i++)
            {
                info += dirs[i] + "\r\n";
            }
            info += "\r\nArquivos: \r\n";
            for (int i = 0; i < files.Length; i++)
            {
                info += files[i] + "\r\n";
            }
            info += "\r\n";
            return info;
        }

        private void analyzeInput(string pathname)
        {
            if (File.Exists(pathname))
            {
                StreamReader stream = new StreamReader(pathname);
                try
                {
                    tbRWArquivo.Text = obtemInfoArquivo(pathname);
                    tbRWArquivo.Text += stream.ReadToEnd();
                }
                catch (IOException IOException)
                {
                    MessageBox.Show(
                        IOException.ToString(),
                        "Erro Inesperado",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    stream.Close();
                }
            }
            else if (Directory.Exists(pathname))
            {
                tbRWArquivo.Text = obtemInfoArquivo(pathname);
                tbRWArquivo.Text += listarDiretorios(pathname);
            }
            else
            {
                MessageBox.Show(
                    "Caminho não encontrado",
                    "Erro de Arquivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void tbDirEntrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                analyzeInput(tbDirEntrada.Text);
            }
        }

        private void salvaArquivo()
        {
            string caminho = @"../information.txt";
            StreamWriter stream = new StreamWriter(caminho);
            try
            {
                if (!(File.Exists(caminho)))
                {
                    File.CreateText(caminho);
                }
                stream.WriteLine(tbRWArquivo.Text);
                MessageBox.Show(
                    "Arquivo salvo em \"./wfaBuscaArquivo/wfaBuscaArquivo/bin/information.txt\"",
                    "Gravado com sucesso!",
                    MessageBoxButtons.OK);
            }
            catch (IOException IOException)
            {
                MessageBox.Show(
                    IOException.ToString(),
                    "Erro Inesperado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                stream.Close();
            }

        }

        private void btSalvarArquivo_Click(object sender, EventArgs e)
        {
            salvaArquivo();
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult =
            MessageBox.Show(
                "Deseja Salvar As Alterações Antes De Sair?",
                "Atenção",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.Yes)
            {
                salvaArquivo();
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}

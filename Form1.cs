using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriarPasta_Click(object sender, EventArgs e)
        {
            string pastaCriada = @"C:\Users\renan\OneDrive\Documentos\aula\" + txtPastaCriada.Text;
            if (! Directory.Exists(pastaCriada))
            {
                Directory.CreateDirectory(pastaCriada);
            }
            else
            {
                MessageBox.Show("Pasta já existe", " ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletarPasta_Click(object sender, EventArgs e)
        {
            string deletarPasta = @"C:\Users\renan\OneDrive\Documentos\aula\" + txtApagarPasta.Text;
            if (Directory.Exists(deletarPasta))
            {
                Directory.Delete(deletarPasta);
            }
            else
            {
                MessageBox.Show("Pasta não existe ou já foi apagada", " ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          
        }

        private void btnCriarArquivo_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\renan\OneDrive\Documentos\aula\" + txtArquivo.Text);
        }

        private void btnMoverArquivo_Click(object sender, EventArgs e)
        {
            string nomeArquivo = txtArquivo.Text;
            string pastaOrigem = txtArquivoOrigem.Text;
            string pastaDestino = txtArquivoDestino.Text;

            string arquivoOrigem = System.IO.Path.Combine(pastaOrigem, nomeArquivo);
            string arquivoDestino = System.IO.Path.Combine(pastaDestino, nomeArquivo);

            System.IO.File.Copy(arquivoOrigem, arquivoDestino, true);
        }

    }
}

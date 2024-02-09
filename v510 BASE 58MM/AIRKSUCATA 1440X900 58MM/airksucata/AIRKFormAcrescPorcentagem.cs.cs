using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airksucata
{
    public partial class AIRKFormAcrescPorcentagem : Form
    {
        public AIRKFormAcrescPorcentagem()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Associe os métodos btnPorcentagem_Click aos eventos de clique dos botões
            btn001.Click += new EventHandler(btnPorcentagem_Click);
            btn005.Click += new EventHandler(btnPorcentagem_Click);
            btn010.Click += new EventHandler(btnPorcentagem_Click);
            btn025.Click += new EventHandler(btnPorcentagem_Click);
            btn050.Click += new EventHandler(btnPorcentagem_Click);
            btn100.Click += new EventHandler(btnPorcentagem_Click);
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            // Extrai a porcentagem do nome do botão
            string porcentagemStr = btn.Name.Substring(3); // Ignora os primeiros 3 caracteres "btn"
            int novaPorcentagem;

            if (int.TryParse(porcentagemStr, out novaPorcentagem))
            {
                // Obtém o valor atual do txtPorcentagem
                string porcentagemAtualStr = txtPorcentagem.Text.Trim('%');
                int porcentagemAtual;

                if (int.TryParse(porcentagemAtualStr, out porcentagemAtual))
                {
                    // Soma a nova porcentagem à porcentagem atual
                    int resultadoPorcentagem = porcentagemAtual + novaPorcentagem;

                    // Define o valor da porcentagem resultante no txtPorcentagem
                    txtPorcentagem.Text = resultadoPorcentagem.ToString() + "%";
                }
                else
                {
                    MessageBox.Show("Erro ao converter a porcentagem atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erro ao converter a porcentagem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AIRKFormAcrescPorcentagem_Load(object sender, EventArgs e)
        {
            // Associe os métodos btnPorcentagem_Click aos eventos de clique dos botões
            btn001.Click += new EventHandler(btnPorcentagem_Click);
            btn005.Click += new EventHandler(btnPorcentagem_Click);
            btn010.Click += new EventHandler(btnPorcentagem_Click);
            btn025.Click += new EventHandler(btnPorcentagem_Click);
            btn050.Click += new EventHandler(btnPorcentagem_Click);
            btn100.Click += new EventHandler(btnPorcentagem_Click);
        }

        private void btnProntoPorcentagem_Click(object sender, EventArgs e)
        {
            // Obtém o valor do txtPorcentagem
            string porcentagemTxt = txtPorcentagem.Text.Trim('%');

            // Verifica se é possível converter o valor para decimal
            if (int.TryParse(porcentagemTxt, out int porcentagem))
            {
                // Salva o valor em um arquivo na pasta "valorPorcentagem"
                string pastaValorPorcentagem = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "valorAcresc");
                string caminhoArquivo = Path.Combine(pastaValorPorcentagem, "acrescimoTemp.bin");

                // Verifica se a pasta "valorPorcentagem" existe, se não, a cria
                if (!Directory.Exists(pastaValorPorcentagem))
                {
                    Directory.CreateDirectory(pastaValorPorcentagem);
                }

                // Escreve o valor no arquivo
                File.WriteAllText(caminhoArquivo, porcentagem.ToString());

                // Fecha o form atual
                this.Close();

                // Abre o novo formulário AIRKNomeSimOuNao
                AIRKNomeSimOuNao Simounao = new AIRKNomeSimOuNao();
                Simounao.Show();

                //MessageBox.Show("Porcentagem salva com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("A porcentagem inserida não é válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

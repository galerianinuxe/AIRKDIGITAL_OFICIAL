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
    public partial class AIRKFormAcrescValor : Form
    {
        public AIRKFormAcrescValor()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            // Limpa o conteúdo do txtValor e define o formato para "R$ 0,00"
            txtValorAcrescimo.Text = "R$ 0,00";
        }

        private void AdicionarValorAoTxt(decimal valor)
        {
            // Obtém o valor atual do txtValor e remove o símbolo de R$ e espaços
            string valorAtual = txtValorAcrescimo.Text.Replace("R$", "").Trim();

            // Converte o valor atual para decimal
            decimal valorAtualDecimal;
            if (decimal.TryParse(valorAtual, out valorAtualDecimal))
            {
                // Soma o valor atual com o valor do botão clicado
                decimal novoValor = valorAtualDecimal + valor;

                // Atualiza o txtValor com o novo valor no formato "R$ 0,00"
                txtValorAcrescimo.Text = $"R$ {novoValor:N2}";
            }
        }

        private void btnValor001_Click(object sender, EventArgs e)
        {
            AdicionarValorAoTxt(0.01m);
        }

        private void btnValor005_Click(object sender, EventArgs e)
        {
            AdicionarValorAoTxt(0.05m);
        }

        private void btnValor010_Click(object sender, EventArgs e)
        {
            AdicionarValorAoTxt(0.10m);
        }

        private void btnValor025_Click(object sender, EventArgs e)
        {
            AdicionarValorAoTxt(0.25m);
        }

        private void btnValor100_Click(object sender, EventArgs e)
        {
            AdicionarValorAoTxt(1.00m);
        }

        private void btnValor250_Click(object sender, EventArgs e)
        {
            AdicionarValorAoTxt(2.50m);
        }

        ///////////////////////SOBRE O TECLADO E NOME DO CLIENTE////////////////////////////



        // No código do seu formulário atual (onde está o )

        private void btnPronto_Click(object sender, EventArgs e)
        {
            // Obtém o valor do txtValorAcrescimo
            string valorTxtAcrescimo = txtValorAcrescimo.Text.Replace("R$", "").Trim();

            // Verifica se é possível converter o valor para decimal
            if (decimal.TryParse(valorTxtAcrescimo, out decimal valorAcrescimo))
            {
                // Salva o valor em um arquivo na pasta "valorAcresc"
                string pastaValorAcresc = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "valorAcresc");
                string caminhoArquivo = Path.Combine(pastaValorAcresc, "acrescimoTemp.bin");

                // Verifica se a pasta "valorAcresc" existe, se não, a cria
                if (!Directory.Exists(pastaValorAcresc))
                {
                    Directory.CreateDirectory(pastaValorAcresc);
                }

                // Escreve o valor no arquivo
                File.WriteAllText(caminhoArquivo, valorAcrescimo.ToString());

                // Fecha o form atual
                this.Close();

                // Abre o novo formulário AIRKNomeSimOuNao
                //AIRKNomeSimOuNao Simounao = new AIRKNomeSimOuNao();
                //Simounao.Show();

                //MessageBox.Show("Valor salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O valor inserido não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}


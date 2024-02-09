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
    public partial class AIRKInserirNome : Form
    {
        public AIRKInserirNome()
        {
            InitializeComponent();
        }
        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text.Length > 0)
            {
                txtNomeCliente.Text = txtNomeCliente.Text.Substring(0, txtNomeCliente.Text.Length - 1);

                if (txtNomeCliente.Text.Length == 0)
                {
                    txtNomeCliente.Text = ""; // Se o campo estiver vazio, defina como valor inicial
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text = "";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "Q";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "W";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "E";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "R";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "T";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "Y";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "U";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "I";
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "O";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "P";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "A";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "S";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "D";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "F";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "H";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "J";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "L";
        }

        private void btnÇ_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "Ç";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "Z";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "X";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "C";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "V";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "B";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "N";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "M";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += ".";
        }

        private void btnTraço_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += "-";
        }

        private void btnSpace_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Text += " ";
        }

        private void btnSemNome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmarNome_Click(object sender, EventArgs e)
        {
            // Obtém o valor do txtNomeCliente
            string nomeCliente = txtNomeCliente.Text.Trim();

            // Verifica se o nome não está vazio
            if (!string.IsNullOrEmpty(nomeCliente))
            {
                // Salva o valor em um arquivo na pasta "clienteNome"
                string pastaClienteNome = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clienteNome");
                string caminhoArquivo = Path.Combine(pastaClienteNome, "clientnameTemp.bin");

                // Verifica se a pasta "clienteNome" existe, se não, a cria
                if (!Directory.Exists(pastaClienteNome))
                {
                    Directory.CreateDirectory(pastaClienteNome);
                }

                // Escreve o valor no arquivo
                File.WriteAllText(caminhoArquivo, nomeCliente);

                // Fecha o form atual ou realiza outra ação necessária
                this.Close();

                //AQUI ATIVA E EXIBE O LABEL NOME CLIENTE NO FORM SISTEMA


                //MessageBox.Show("Nome do cliente salvo com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O nome do cliente não pode estar vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }

}

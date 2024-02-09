using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airksucata
{
    public partial class AIRKAlertaEdicaoMaterial : Form
    {
        public AIRKAlertaEdicaoMaterial()
        {
            InitializeComponent();
        }

        private void btnNaoReiniciar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void btnReiniciarTudo_Click(object sender, EventArgs e)
        {
            ReiniciarAplicacao();
        }

        private void ReiniciarAplicacao()
        {
            // Fecha a aplicação atual
            Application.Exit();

            // Aguarda um curto período para garantir que a aplicação foi completamente encerrada
            System.Threading.Thread.Sleep(1000);

            // Inicia o processo novamente
            IniciarProcesso("airksucata.exe");
        }

        private void IniciarProcesso(string nomeProcesso)
        {
            // Inicia o processo novamente
            try
            {
                Process.Start(nomeProcesso);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar o processo {nomeProcesso}: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

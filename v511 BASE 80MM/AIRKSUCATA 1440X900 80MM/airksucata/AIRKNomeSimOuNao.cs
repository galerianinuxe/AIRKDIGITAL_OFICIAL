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
    public partial class AIRKNomeSimOuNao : Form
    {
        public AIRKNomeSimOuNao()
        {
            InitializeComponent();
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            this.Close();
            // Ao clicar no botão, cria uma nova instância do AIRKFormAcrescValor e a exibe
            AIRKInserirNome formInsertNome = new AIRKInserirNome();
            formInsertNome.Show();
        }
    }
}

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
    public partial class AIRKFormTipoAcrescimo : Form
    {
        public AIRKFormTipoAcrescimo()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValor_Click(object sender, EventArgs e)
        {
            this.Close();
            // Ao clicar no botão, cria uma nova instância do AIRKFormAcrescValor e a exibe
            AIRKFormAcrescValor formAcrescimoValor = new AIRKFormAcrescValor();
            formAcrescimoValor.Show();

        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            this.Close();
            AIRKFormAcrescPorcentagem formAcrescimoPorc = new AIRKFormAcrescPorcentagem();
            formAcrescimoPorc.Show();
        }


    }
}

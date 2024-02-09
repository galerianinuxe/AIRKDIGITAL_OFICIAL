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
    public partial class AIRKFormResolucao : Form
    {
        public AIRKFormResolucao()
        {
            InitializeComponent();
        }

        private void btn1024x768_Click(object sender, EventArgs e)
        {
            // Abrir o formulário do sistema
            AIRKCalculatorSist1024x768 resol1024x768 = new AIRKCalculatorSist1024x768();
            resol1024x768.ShowDialog(); // Exibir o sistema 1024x768
        }

        private void btn1440x900_Click(object sender, EventArgs e)
        {
            // Abrir o formulário do sistema
            formSistema resol1440x900 = new formSistema();
            resol1440x900.ShowDialog(); // Exibir o sistema 1024x768
        }
    }
}

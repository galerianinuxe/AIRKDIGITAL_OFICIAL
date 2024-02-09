namespace airksucata
{
    public partial class formVerificacao : Form
    {
        public formVerificacao()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
            // Atualize o formulário principal chamando o método RefreshInterface
            formSistema formSistema = Application.OpenForms.OfType<formSistema>().FirstOrDefault();
            if (formSistema != null)
            {
                formSistema.RefreshInterface();
            }
        }

        string Plastic = "Polymer";
        string Eletronic = "Circuit";
        string Silver = "Argentum";
        string Wire = "Cable";
        string Iron = "MetalPesado";
        string Can = "Refrescante";
        string Glass = "Transparente";
        string Alumin = "Leveza";


        //string abrirConfig = "ArgentumPolymerMetalPesadoTransparente"; //SENHA PARA ACESSAR CONFIG
        //string abrirConfig = "LevezaRefrescanteCircuitCable"; //SENHA PARA ACESSAR CONFIG
        //string abrirConfig = "TransparenteMetalPesadoArgentumCircuitCableRefrescante"; //SENHA ECOVIDA
        //string abrirConfig = "TransparenteMetalPesadoArgentumCircuitCableRefrescante"; //SENHA XLATA
        string abrirConfig = "PolymerArgentumMetalPesadoLevezaRefrescanteCable"; //SENHA ECOVIDA
        //string abrirConfig = "PolymerLevezaPolymerLeveza"; //SENHA PARA ACESSAR CONFIG

        private void BtnPlastic_Click(object sender, EventArgs e)
        {
            txtPassConfig.Text += Plastic;

            if (txtPassConfig.Text == abrirConfig)
            {
                //this.Close(); // Fecha o formVerificacao
                AbrirFormConfig(); // Abre o formConfig

            }
        }
        private void btnEletronic_Click(object sender, EventArgs e)
        {
            txtPassConfig.Text += Eletronic;

            if (txtPassConfig.Text == abrirConfig)
            {
                AbrirFormConfig(); // Abre o formConfig

            }

        }

        private void btnSilver_Click(object sender, EventArgs e)
        {
            txtPassConfig.Text += Silver;

            if (txtPassConfig.Text == abrirConfig)
            {

                AbrirFormConfig(); // Abre o formConfig
                //this.Close(); // Fecha o formVerificacao
            }

        }

        private void btnWire_Click(object sender, EventArgs e)
        {
            txtPassConfig.Text += Wire;

            if (txtPassConfig.Text == abrirConfig)
            {
                AbrirFormConfig(); // Abre o formConfig
                //this.Close(); // Fecha o formVerificacao
            }

        }

        private void btnPlastic_Click(object sender, EventArgs e)
        {
            txtPassConfig.Text += Plastic;

            if (txtPassConfig.Text == abrirConfig)
            {
                AbrirFormConfig(); // Abre o formConfig
                //this.Close(); // Fecha o formVerificacao
            }
        }
        // Método para abrir o formConfig
        private void AbrirFormConfig()
        {
            this.Close();

            formConfig formConfig = new formConfig();
            formConfig.TopMost = true;
            // Restaurar a propriedade TopMost ao valor padrão depois de fechar o formConfig, se necessário
            formConfig.TopMost = false;
            formConfig.ShowDialog();



        }



        private void btnIron_Click(object sender, EventArgs e)
        {
            txtPassConfig.Text += Iron;

            if (txtPassConfig.Text == abrirConfig)
            {
                //this.Close(); // Fecha o formVerificacao
                AbrirFormConfig(); // Abre o formConfig
            }
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            txtPassConfig.Text += Can;

            if (txtPassConfig.Text == abrirConfig)
            {
                //this.Close(); // Fecha o formVerificacao
                AbrirFormConfig(); // Abre o formConfig
            }
        }

        private void btnGlass_Click(object sender, EventArgs e)
        {
            txtPassConfig.Text += Glass;

            if (txtPassConfig.Text == abrirConfig)
            {
                //this.Close(); // Fecha o formVerificacao
                AbrirFormConfig(); // Abre o formConfig
            }
        }

        private void btnAlum_Click(object sender, EventArgs e)
        {
            txtPassConfig.Text += Alumin;

            if (txtPassConfig.Text == abrirConfig)
            {
                //this.Close(); // Fecha o formVerificacao
                AbrirFormConfig(); // Abre o formConfig
            }
        }
    }
}

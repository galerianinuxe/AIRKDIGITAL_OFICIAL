namespace airksucata
{
    public partial class formConfig : Form
    {
        public formConfig()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void FormAddMaterial_Click(object sender, EventArgs e)
        {
            FormAddMaterial formAddMaterial = new FormAddMaterial();
            DialogResult result = formAddMaterial.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            formRelatorios formAddMaterial = new formRelatorios();
            DialogResult result = formAddMaterial.ShowDialog();
        }

        private void btnRelatorioVenda_Click(object sender, EventArgs e)
        {
            relatorioVenda formRelatorioVenda = new relatorioVenda();
            DialogResult result = formRelatorioVenda.ShowDialog();
        }

        private void CarregarAjustesSistema()
        {
            // Caminhos dos arquivos
            string caminhoLogoPrincipal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ajustesGerais", "logoPrincipal.png");
            string caminhoUpdate = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ajustesGerais", "ultimoUpdate.airk");
            string caminhoVersion = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ajustesGerais", "version.airk");
            string caminhoNomeEmpresa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ajustesGerais", "nomeEmpresa.txt");
            string caminhoContatoEmpresa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dadosComprovanteVisual", "contatoEmpresa.txt");
            string caminhoLocalEmpresa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dadosComprovanteVisual", "localEmpresa.txt");


            // Carregar logoWhats
            if (File.Exists(caminhoLogoPrincipal))
            {
                Image imagemLogoWhats = Image.FromFile(caminhoLogoPrincipal);
                logoPrincipal.Image = imagemLogoWhats;
            }

            // Carregar nomeEmpresa
            if (File.Exists(caminhoNomeEmpresa))
            {
                string textoNomeEmpresa = File.ReadAllText(caminhoNomeEmpresa);
                lbNomeEmpresa.Text = textoNomeEmpresa;
            }

            // Carregar contatoEmpresa
            if (File.Exists(caminhoContatoEmpresa))
            {
                string textoContatoEmpresa = File.ReadAllText(caminhoContatoEmpresa);
                lbContatoEmpresa.Text = textoContatoEmpresa;
            }

            // Carregar localEmpresa
            if (File.Exists(caminhoLocalEmpresa))
            {
                string textoLocalEmpresa = File.ReadAllText(caminhoLocalEmpresa);
                lbLocalEmpresa.Text = textoLocalEmpresa;
            }

            // Carregar Ultima versão
            if (File.Exists(caminhoVersion))
            {
                string ultimaVersion = File.ReadAllText(caminhoVersion);
                lbVersion.Text = ultimaVersion;
            }
            // Carregar Ultima Atualização
            if (File.Exists(caminhoUpdate))
            {
                string ultimoUp = File.ReadAllText(caminhoUpdate);
                lbUpdate.Text = ultimoUp;
            }

        }

        private void formConfig_Load(object sender, EventArgs e)
        {
            CarregarAjustesSistema();
        }
    }
}


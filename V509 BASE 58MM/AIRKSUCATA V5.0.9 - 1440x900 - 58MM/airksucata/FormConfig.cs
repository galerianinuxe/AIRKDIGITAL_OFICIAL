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
    }
}


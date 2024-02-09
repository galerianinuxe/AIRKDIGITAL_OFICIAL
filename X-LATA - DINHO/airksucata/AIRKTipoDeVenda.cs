namespace airksucata
{
    public partial class AIRKTipoDeVenda : Form
    {
        public AIRKTipoDeVenda()
        {
            InitializeComponent();
        }

        private void btnPorUnid_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância da form
            AIRKInserirVenda formInsertVendaUnit = new AIRKInserirVenda();

            // Mostra o novo formulário
            formInsertVendaUnit.ShowDialog();

            // Fecha o formulário atual
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fecha o formulário atual
            this.Close();
        }

        private void btnPorPeso_Click(object sender, EventArgs e)
        {
            // Cria uma nova instância da form
            AIRKInserirVendaKg formInsertVendaKg = new AIRKInserirVendaKg();

            // Mostra o novo formulário
            formInsertVendaKg.ShowDialog();

            // Fecha o formulário atual
            this.Close();
        }
    }
}

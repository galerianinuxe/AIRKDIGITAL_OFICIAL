using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace airksucata
{
    public partial class formComprovanteRelatorio : Form
    {
        private int numeroRegistroSelecionado; // Declaração do campo
        private Bitmap bmp;

        public formComprovanteRelatorio(int numeroRegistroSelecionado)
        {
            InitializeComponent();
            // Atualize o labelRegistroRel com o valor do "registro_id"
            this.numeroRegistroSelecionado = numeroRegistroSelecionado; // Atribuição do valor ao campo
            labelRegistroRel.Text = numeroRegistroSelecionado.ToString("D5");
            // Consulte o banco de dados para obter o valor da coluna "total" na tabela "registros"
            ConsultarValorTotalRegistro(numeroRegistroSelecionado);
            ConsultarItensPedidos(numeroRegistroSelecionado);
            AjustarAlturaListView();  // Chama a função para ajustar a altura do ListView
        }

        private void formComprovanteRelatorio_Load_1(object sender, EventArgs e)
        {

        }
        private void ConsultarValorTotalRegistro(int numeroRegistro)
        {
            try
            {
                string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obter o valor da coluna "total" e "dataHoraRegistro" na tabela "registros"
                    string query = "SELECT total, dataHoraRegistro FROM registros WHERE registro_id = @numeroRegistro";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@numeroRegistro", numeroRegistro);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal total = reader.GetDecimal("total");
                                DateTime dataHoraRegistro = reader.GetDateTime("dataHoraRegistro");

                                // Atualize o labelTotalRelatorio com o valor no formato "R$ 00,00"
                                labelTotalRelatorio.Text = total.ToString("C2");

                                // Formate a data e hora no formato desejado e atualize o labelRelogioReg
                                labelRelogioReg.Text = dataHoraRegistro.ToString("dd/MM/yyyy HH:mm:ss");

                                // Adicione saída de depuração
                                Console.WriteLine($"Total: {total}");
                                Console.WriteLine($"Data/Hora Registro: {dataHoraRegistro}");
                            }
                            else
                            {
                                // Caso não haja valor na coluna "total" ou "dataHoraRegistro", defina os rótulos como vazios
                                labelTotalRelatorio.Text = string.Empty;
                                labelRelogioReg.Text = string.Empty;

                                // Adicione saída de depuração
                                //Console.WriteLine("Nenhum resultado encontrado.");
                            }
                        }
                    }

                    // Consulta SQL para obter os itens correspondentes ao número do registro na tabela "pedidos_impressos"
                    string queryItens = "SELECT materialNome, materialValor, inputValor, totalPagar FROM pedidos_impressos WHERE id_registro = @numeroRegistro";

                    using (MySqlCommand commandItens = new MySqlCommand(queryItens, connection))
                    {
                        commandItens.Parameters.AddWithValue("@numeroRegistro", numeroRegistro);

                        using (MySqlDataReader readerItens = commandItens.ExecuteReader())
                        {
                            // Limpe o ListView antes de adicionar novos itens
                            listComprovanteRel2.Items.Clear();

                            while (readerItens.Read())
                            {
                                string materialNome = readerItens.GetString("materialNome");
                                decimal materialValor = readerItens.GetDecimal("materialValor");
                                decimal inputValor = readerItens.GetDecimal("inputValor");
                                decimal totalPagar = readerItens.GetDecimal("totalPagar");

                                // Adicione os itens ao ListView
                                ListViewItem item = new ListViewItem(materialNome);
                                item.SubItems.Add(materialValor.ToString("C2")); // Formate o materialValor como moeda
                                item.SubItems.Add(inputValor.ToString("N2")); // Formate o inputValor com duas casas decimais
                                item.SubItems.Add(totalPagar.ToString("C2")); // Formate o totalPagar como moeda

                                listComprovanteRel2.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao consultar o valor total, a data/hora do registro e os itens: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConsultarItensPedidos(int numeroRegistro)
        {
            try
            {
                string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Consulta SQL para obter os itens correspondentes ao número do registro na tabela "pedidos_impressos"
                    string queryItens = "SELECT materialNome, materialValor, inputValor, totalPagar FROM pedidos_impressos WHERE id_registro = @numeroRegistro";

                    using (MySqlCommand commandItens = new MySqlCommand(queryItens, connection))
                    {
                        commandItens.Parameters.AddWithValue("@numeroRegistro", numeroRegistro);

                        using (MySqlDataReader readerItens = commandItens.ExecuteReader())
                        {
                            // Limpe o ListView antes de adicionar novos itens
                            listComprovanteRel2.Items.Clear();

                            // Configure as colunas do ListView
                            listComprovanteRel2.View = View.Details;
                            listComprovanteRel2.Columns.Add("Material", 130); // Nome da coluna e largura em pixels
                            listComprovanteRel2.Columns.Add("Valor KG", 80); // Nome da coluna e largura em pixels
                            listComprovanteRel2.Columns.Add("Peso", 95); // Nome da coluna e largura em pixels
                            listComprovanteRel2.Columns.Add("Total R$", 136); // Nome da coluna e largura em pixels

                            // Agora, você pode adicionar os itens ao ListView
                            while (readerItens.Read())
                            {
                                string materialNome = readerItens.GetString("materialNome");
                                decimal materialValor = readerItens.GetDecimal("materialValor");
                                decimal inputValor = readerItens.GetDecimal("inputValor");
                                decimal totalPagar = readerItens.GetDecimal("totalPagar");

                                ListViewItem item = new ListViewItem(materialNome);
                                item.SubItems.Add(materialValor.ToString("C2"));
                                item.SubItems.Add(inputValor.ToString("N2"));
                                item.SubItems.Add(totalPagar.ToString("C2"));

                                // Aplicar as informações de formatação aqui
                                item.BackColor = Color.White;
                                item.ForeColor = Color.Black;
                                item.Font = new Font("Cambria", 13, FontStyle.Bold);

                                // Adicione o item ao ListView
                                listComprovanteRel2.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao consultar os itens: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmarimprimirRel_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(panelComprovante.Width, panelComprovante.Height);
            panelComprovante.DrawToBitmap(bmp, new Rectangle(0, 0, panelComprovante.Width, panelComprovante.Height));

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            pd.PrintPage += Pd_PrintPage;

            pd.Print();

            // Após a impressão com sucesso, feche a janela atual
            this.Close();
        }

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (bmp != null)
            {
                int printWidth = (int)(bmp.Width * 0.65);
                int printHeight = (int)(bmp.Height * 0.80);

                e.Graphics.DrawImage(bmp, 0, 0, printWidth, printHeight);

                e.HasMorePages = false;
            }
        }
        private void AjustarAlturaListView()
        {
            int totalHeight = 0;

            foreach (ListViewItem item in listComprovanteRel2.Items)
            {
                totalHeight += item.Bounds.Height;
            }

            // Adiciona a altura dos subitens para cada item, exceto o primeiro item
            for (int i = 1; i < listComprovanteRel2.Columns.Count; i++)
            {
                totalHeight += listComprovanteRel2.Items.Count > 0 ? listComprovanteRel2.Items[0].SubItems[i].Bounds.Height : 0;
            }

            // Adiciona a altura das margens do ListView
            totalHeight += listComprovanteRel2.Margin.Vertical;

            // Define a altura ajustada para o ListView
            listComprovanteRel2.Height = totalHeight;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelComprovante_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

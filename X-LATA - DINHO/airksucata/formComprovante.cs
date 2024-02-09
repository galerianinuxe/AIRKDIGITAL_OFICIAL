using MySql.Data.MySqlClient;
using System.Drawing.Printing;
using System.Globalization;

namespace airksucata
{
    public partial class FormComprovante : Form
    {

        private List<ListViewItem> items;
        private Bitmap bmp;

        public FormComprovante(List<ListViewItem> items)
        {
            InitializeComponent();
            this.items = items;
            PreencherListaComprovante();
            DisplayItemsAndTotal();
            AjustarAlturaListView();  // Chama a função para ajustar a altura do ListView

            // Obtém e exibe um número aleatório no labelRegistro
            int idRegistro = ObterUltimoIDRegistro() + 1;
            labelRegistro.Text = idRegistro.ToString("D5");
        }

        private void timerRelogioReg_Tick(object sender, EventArgs e)
        {
            labelRelogio.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private int ObterUltimoIDRegistro()
        {
            try
            {
                string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT MAX(id_registro) FROM pedidos_impressos"; // Obtém o maior ID de registro
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            return Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao obter o último ID de registro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0; // Caso ocorra um erro, retorna 0 como valor padrão
        }

        private void PreencherListaComprovante()
        {
            listaComprovante.View = View.Details;
            listaComprovante.Columns.Add("Material", 130);
            listaComprovante.Columns.Add("Peso", 80);
            listaComprovante.Columns.Add("Valor KG", 95);
            listaComprovante.Columns.Add("Total", 136);
        }

        private void DisplayItemsAndTotal()
        {
            decimal total = 0;


            foreach (var item in items)
            {
                ListViewItem clonedItem = (ListViewItem)item.Clone();

                foreach (ListViewItem.ListViewSubItem subItem in clonedItem.SubItems)
                {
                    subItem.BackColor = Color.White;
                    subItem.ForeColor = Color.Black;
                    subItem.Font = new Font("Cambria", 13, FontStyle.Bold);
                    // Defina a distância vertical desejada entre os itens (por exemplo, 5 pixels)
                    int verticalSpacing = -2;
                }

                listaComprovante.Items.Add(clonedItem);

                int lastIndex = item.SubItems.Count - 1;
                string totalPagarText = item.SubItems[lastIndex].Text.Substring(3).Replace(".", "").Replace(",", ".");
                if (decimal.TryParse(totalPagarText, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal itemTotal))
                {
                    total += itemTotal;
                }
                AjustarAlturaListView();  // Chama a função para ajustar a altura do ListView
            }

            labelTotal.Text = $"{total.ToString("C2")}";
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool SalvarInformacoesNoBancoDeDados(int idRegistro, string materialNome, decimal materialValor, decimal totalPagar, decimal inputValor, DateTime dataHoraAtual, decimal total, string nomeClient)
        {
            try
            {
                string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Passo 1: Inserir os dados na tabela 'pedidos_impressos'
                    string queryPedido = "INSERT INTO pedidos_impressos (id_registro, materialNome, materialValor, totalPagar, inputValor, dataHoraAtual, nomeCliente) " +
                                        "VALUES (@id_Registro, @materialNome, @materialValor, @totalPagar, @inputValor, @dataHoraAtual, @nomeCliente)";
                    using (MySqlCommand commandPedido = new MySqlCommand(queryPedido, connection))
                    {
                        commandPedido.Parameters.AddWithValue("@id_Registro", idRegistro);
                        commandPedido.Parameters.AddWithValue("@materialNome", materialNome);
                        commandPedido.Parameters.AddWithValue("@materialValor", materialValor / 100); // Divide por 100 para ajustar as casas decimais
                        commandPedido.Parameters.AddWithValue("@totalPagar", totalPagar / 100); // Divide por 100 para ajustar as casas decimais
                        commandPedido.Parameters.AddWithValue("@inputValor", inputValor);
                        commandPedido.Parameters.AddWithValue("@dataHoraAtual", dataHoraAtual);
                        commandPedido.Parameters.AddWithValue("@nomeCliente", nomeClient);
                        commandPedido.ExecuteNonQuery();
                    }

                    // Passo 2: Verificar se o registro já existe na tabela 'registros'
                    string queryCheckRegistro = "SELECT COUNT(*) FROM registros WHERE registro_id = @id_Registro";
                    int registroExistente;
                    using (MySqlCommand commandCheckRegistro = new MySqlCommand(queryCheckRegistro, connection))
                    {
                        commandCheckRegistro.Parameters.AddWithValue("@id_Registro", idRegistro);
                        registroExistente = Convert.ToInt32(commandCheckRegistro.ExecuteScalar());
                    }

                    // Passo 3: Inserir o registro na tabela 'registros' somente se ele não existir
                    if (registroExistente == 0)
                    {
                        string queryRegistro = "INSERT INTO registros (registro_id, dataHoraRegistro, total) VALUES (@id_Registro, @dataHoraAtual, @total)";
                        using (MySqlCommand commandRegistro = new MySqlCommand(queryRegistro, connection))
                        {
                            commandRegistro.Parameters.AddWithValue("@id_Registro", idRegistro);
                            commandRegistro.Parameters.AddWithValue("@dataHoraAtual", dataHoraAtual);
                            commandRegistro.Parameters.AddWithValue("@total", total); // Divide por 100 para ajustar as casas decimais
                            commandRegistro.ExecuteNonQuery();
                        }
                    }
                }

                return true; // Indica que os dados foram salvos com sucesso
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // Código de erro de chave duplicada
                {
                    MessageBox.Show("Erro de duplicação. Certifique-se de que o id_item ou id_registro não estejam duplicados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"Erro ao salvar os dados no banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return false; // Indica que ocorreu um erro ao salvar os dados
            }
        }
        private decimal CalcularTotal()
        {
            decimal total = 0;

            foreach (var item in items)
            {
                string totalPagarText = item.SubItems[3].Text.Substring(3).Replace(".", "").Replace(",", ".");
                if (decimal.TryParse(totalPagarText, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal itemTotal))
                {
                    total += itemTotal;
                }
            }

            return total;
        }

        public void VerificarEExcluirNomeCliente()
        {
            // Caminho completo para o arquivo "clientnameTemp.bin"
            string caminhoArquivo3 = Path.Combine("clienteNome", "clientnameTemp.bin");

            try
            {
                // Verifica se o arquivo existe
                if (File.Exists(caminhoArquivo3))
                {
                    // Exclui o arquivo
                    File.Delete(caminhoArquivo3);

                    Console.WriteLine("Arquivo 'clientnameTemp.bin' excluído com sucesso.");
                }
                else
                {
                    Console.WriteLine("O arquivo 'clientnameTemp.bin' não existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir o arquivo: {ex.Message}");
            }
        }

        private void btnConfirmarimprimir_Click_1(object sender, EventArgs e)
        {

            bool dadosSalvosComSucesso = true;

            // Calcula o total antes do loop
            decimal total = CalcularTotal(); // Substitua por sua lógica de cálculo do total


            foreach (var item in items)
            {
                //string idItem = ObterProximoIDItem().ToString(); // Obtém o próximo ID de item único
                int idRegistro = Convert.ToInt32(labelRegistro.Text); // Obtém o valor atual do labelRegistro
                string materialNome = item.SubItems[0].Text;
                decimal materialValor = Convert.ToDecimal(item.SubItems[2].Text.Substring(3).Replace(".", "").Replace(",", "."));
                decimal totalPagar = Convert.ToDecimal(item.SubItems[3].Text.Substring(3).Replace(".", "").Replace(",", "."));
                decimal inputValor = Convert.ToDecimal(item.SubItems[1].Text);
                DateTime dataHoraAtual = DateTime.Now;
                string nomeClient = lbNomeCliente.Text.Replace("Cliente: ", "");

                if (!SalvarInformacoesNoBancoDeDados(idRegistro, materialNome, materialValor, totalPagar, inputValor, dataHoraAtual, total, nomeClient))
                {
                    dadosSalvosComSucesso = false;
                    break;
                }
            }

            if (dadosSalvosComSucesso)
            {
                bmp = new Bitmap(panelComprovante.Width, panelComprovante.Height);
                panelComprovante.DrawToBitmap(bmp, new Rectangle(0, 0, panelComprovante.Width, panelComprovante.Height));

                PrintDocument pd = new PrintDocument();
                pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
                pd.PrintPage += Pd_PrintPage;

                pd.Print();

                // Após a impressão com sucesso, feche a janela atual
                this.Close();

                // Atualize o formulário principal chamando o método RefreshInterface
                formSistema formSistema = Application.OpenForms.OfType<formSistema>().FirstOrDefault();
                if (formSistema != null)
                {
                    formSistema.RefreshInterface();
                }
            }
            else
            {
                MessageBox.Show("Erro ao salvar os dados no banco de dados. A impressão não será realizada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Verifique se o arquivo listaTemporaria.json existe antes de excluí-lo
            string listaTemporariaFilePath = "listaTemporaria.json";
            if (File.Exists(listaTemporariaFilePath))
            {
                try
                {
                    File.Delete(listaTemporariaFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o arquivo listaTemporaria.json: " + ex.Message);
                }
            }

            VerificarEExcluirNomeCliente();
        }


        /*private int ObterProximoIDItem()
        {
            idItemAtual++; // Incrementa o contador
            return idItemAtual;
        }*/

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

            foreach (ListViewItem item in listaComprovante.Items)
            {
                totalHeight += item.Bounds.Height;
            }

            // Adiciona a altura dos subitens para cada item, exceto o primeiro item
            for (int i = 1; i < listaComprovante.Columns.Count; i++)
            {
                totalHeight += listaComprovante.Items.Count > 0 ? listaComprovante.Items[0].SubItems[i].Bounds.Height : 0;
            }

            // Adiciona a altura das margens do ListView
            totalHeight += listaComprovante.Margin.Vertical;

            // Define a altura ajustada para o ListView
            listaComprovante.Height = totalHeight;
        }

        private void panelCabecalho_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CarregarDadosComprovanteVisual()
        {
            // Caminhos dos arquivos
            string caminhoLogoComprovante = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dadosComprovanteVisual", "logoComprovante.png");
            string caminhoLogoWhats = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dadosComprovanteVisual", "logoWhats.png");
            string caminhoNomeEmpresa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dadosComprovanteVisual", "nomeEmpresa.txt");
            string caminhoContatoEmpresa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dadosComprovanteVisual", "contatoEmpresa.txt");
            string caminhoLocalEmpresa = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dadosComprovanteVisual", "localEmpresa.txt");

            // Carregar logoComprovante
            if (File.Exists(caminhoLogoComprovante))
            {
                Image imagemLogoComprovante = Image.FromFile(caminhoLogoComprovante);
                logoComprovante.Image = imagemLogoComprovante;
            }

            // Carregar logoWhats
            if (File.Exists(caminhoLogoWhats))
            {
                Image imagemLogoWhats = Image.FromFile(caminhoLogoWhats);
                logoWhats.Image = imagemLogoWhats;
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
        }
        private void FormComprovante_Load(object sender, EventArgs e)
        {
            //CARREGA OS DADOS DO COMPROVANTE VISUAL//
            CarregarDadosComprovanteVisual();

            string nomeArquivo = "clientnameTemp.bin";
            string pastaClienteNome = "clienteNome";  // Substitua pelo caminho real do seu projeto

            string caminhoCompleto = Path.Combine(pastaClienteNome, nomeArquivo);

            if (File.Exists(caminhoCompleto))
            {
                // Se o arquivo existe, exiba seu conteúdo no lbNomeCliente
                string conteudoArquivo = File.ReadAllText(caminhoCompleto);
                lbNomeCliente.Text = $"Cliente: {conteudoArquivo}";
            }
            else
            {
                // Se o arquivo não existe, oculte o lbNomeCliente
                lbNomeCliente.Visible = false;
            }
        }

        private void btnSoSalvar_Click(object sender, EventArgs e)
        {

            bool dadosSalvosComSucesso = true;

            // Calcula o total antes do loop
            decimal total = CalcularTotal(); // Substitua por sua lógica de cálculo do total


            foreach (var item in items)
            {
                //string idItem = ObterProximoIDItem().ToString(); // Obtém o próximo ID de item único
                int idRegistro = Convert.ToInt32(labelRegistro.Text); // Obtém o valor atual do labelRegistro
                string materialNome = item.SubItems[0].Text;
                decimal materialValor = Convert.ToDecimal(item.SubItems[2].Text.Substring(3).Replace(".", "").Replace(",", "."));
                decimal totalPagar = Convert.ToDecimal(item.SubItems[3].Text.Substring(3).Replace(".", "").Replace(",", "."));
                decimal inputValor = Convert.ToDecimal(item.SubItems[1].Text);
                DateTime dataHoraAtual = DateTime.Now;
                string nomeClient = lbNomeCliente.Text.Replace("Cliente: ", "");

                if (!SalvarInformacoesNoBancoDeDados(idRegistro, materialNome, materialValor, totalPagar, inputValor, dataHoraAtual, total, nomeClient))
                {
                    dadosSalvosComSucesso = false;
                    break;
                }
            }

            // Após a impressão com sucesso, feche a janela atual
            this.Close();

            // Atualize o formulário principal chamando o método RefreshInterface
            formSistema formSistema = Application.OpenForms.OfType<formSistema>().FirstOrDefault();
            if (formSistema != null)
            {
                formSistema.RefreshInterface();
            }

            // Verifique se o arquivo listaTemporaria.json existe antes de excluí-lo
            string listaTemporariaFilePath = "listaTemporaria.json";
            if (File.Exists(listaTemporariaFilePath))
            {
                try
                {
                    File.Delete(listaTemporariaFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir o arquivo listaTemporaria.json: " + ex.Message);
                }
            }

            VerificarEExcluirNomeCliente();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            bool dadosSalvosComSucesso = true;

            // Calcula o total antes do loop
            decimal total = CalcularTotal(); // Substitua por sua lógica de cálculo do total


            foreach (var item in items)
            {
                //string idItem = ObterProximoIDItem().ToString(); // Obtém o próximo ID de item único
                int idRegistro = Convert.ToInt32(labelRegistro.Text); // Obtém o valor atual do labelRegistro
                string materialNome = item.SubItems[0].Text;
                decimal materialValor = Convert.ToDecimal(item.SubItems[2].Text.Substring(3).Replace(".", "").Replace(",", "."));
                decimal totalPagar = Convert.ToDecimal(item.SubItems[3].Text.Substring(3).Replace(".", "").Replace(",", "."));
                decimal inputValor = Convert.ToDecimal(item.SubItems[1].Text);
                DateTime dataHoraAtual = DateTime.Now;
                string nomeClient = lbNomeCliente.Text.Replace("Cliente: ", "");

                if (!SalvarInformacoesNoBancoDeDados(idRegistro, materialNome, materialValor, totalPagar, inputValor, dataHoraAtual, total, nomeClient))
                {
                    dadosSalvosComSucesso = false;
                    break;
                }
            }

            if (dadosSalvosComSucesso)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirRecibo);
                pd.Print();

                // Após a impressão com sucesso, feche a janela atual
                this.Close();

                // Atualize o formulário principal chamando o método RefreshInterface
                formSistema formSistema = Application.OpenForms.OfType<formSistema>().FirstOrDefault();
                if (formSistema != null)
                {
                    formSistema.RefreshInterface();
                }

                // Verifique se o arquivo listaTemporaria.json existe antes de excluí-lo
                string listaTemporariaFilePath = "listaTemporaria.json";
                if (File.Exists(listaTemporariaFilePath))
                {
                    try
                    {
                        File.Delete(listaTemporariaFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o arquivo listaTemporaria.json: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Erro ao salvar os dados no banco de dados. A impressão não será realizada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ImprimirRecibo(object sender, PrintPageEventArgs e)
        {
            // Configurações de impressão
            int linhaAtual = 2; // Margem top de 2px
            int margemInterna = 2; // Margem interna de 2px
            int alturaLinha = 10; // Altura de cada linha
            Font fonteCabecalho = new Font("Arial", 10, FontStyle.Bold);
            Font fonteTexto = new Font("Arial", 8);
            Font fonteDados = new Font("Arial", 10, FontStyle.Bold);
            Font fonteDadosCabecalho = new Font("Arial", 8, FontStyle.Bold);

            // Adicione o caminho para a imagem
            string caminhoImagem = "logoRelatorio.png"; // Substitua pelo caminho real da sua imagem
            Image imagem = Image.FromFile(caminhoImagem);

            // Cabeçalho


            string contato = "";
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dadosComprovante", "contato.ink");

            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    contato = File.ReadAllText(caminhoArquivo);
                }
            }
            catch (Exception ex)
            {
                // Lidar com exceções, como logar o erro ou fornecer um valor padrão
                Console.WriteLine($"Falta Contato Comprovante: {ex.Message}");
            }


            Font contatoFonte = new Font("Arial", 13, FontStyle.Bold);
            ///////////////////////////////////////////////////////
            string local = "";
            string caminhoArquivoLocal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dadosComprovante", "local.ink");

            try
            {
                if (File.Exists(caminhoArquivoLocal))
                {
                    local = File.ReadAllText(caminhoArquivoLocal);
                }
            }
            catch (Exception ex)
            {
                // Lidar com exceções, como logar o erro ou fornecer um valor padrão
                Console.WriteLine($"Falta Contato Comprovante: {ex.Message}");
            }
            string cabecalho = "Recibo de Compra\n";
            string DataRecibo = $"Data: {labelRelogio.Text}";
            string NumRegistro = $"Nº Registro: {labelRegistro.Text}\n";
            string cabecalhoCompleto = $"{cabecalho}\n{DataRecibo}\n{NumRegistro}\n";
            string dadosEmpresa = $"{caminhoArquivo}\n{local}\n";




            StringFormat formatoCentralizado = new StringFormat();
            formatoCentralizado.Alignment = StringAlignment.Center;
            formatoCentralizado.LineAlignment = StringAlignment.Center;

            SizeF tamanhoCabecalho = e.Graphics.MeasureString(cabecalhoCompleto, fonteCabecalho);

            // Desenhar a imagem no topo centralizado
            int posicaoXImagem = (e.PageBounds.Width - 100) / 2; // Posição X centralizada
            e.Graphics.DrawImage(imagem, posicaoXImagem, linhaAtual, 100, 100);


            linhaAtual += 80 + margemInterna; // Altura da imagem mais a margem interna
            e.Graphics.DrawString(contato, contatoFonte, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, (int)tamanhoCabecalho.Height), formatoCentralizado);
            linhaAtual += 15 + margemInterna; // Altura da imagem mais a margem interna

            linhaAtual += 15 + margemInterna; // Altura da imagem mais a margem interna
            e.Graphics.DrawString(local, fonteDadosCabecalho, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, (int)tamanhoCabecalho.Height), formatoCentralizado);

            linhaAtual += 50 + margemInterna; // Altura da imagem mais a margem interna
            e.Graphics.DrawString(cabecalhoCompleto, fonteCabecalho, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, (int)tamanhoCabecalho.Height), formatoCentralizado);
            linhaAtual += (int)tamanhoCabecalho.Height + margemInterna; // Pular duas linhas após o cabeçalho

            // Larguras específicas das colunas
            int[] largurasColunas = { 75, 50, 60, 80 }; // Ajuste conforme necessário

            // Imprimir cabeçalhos de coluna
            int colunaAtual = margemInterna;
            for (int i = 0; i < listaComprovante.Columns.Count; i++)
            {
                // Ajuste para quebra de texto nas colunas
                var tamanhoColuna = e.Graphics.MeasureString(listaComprovante.Columns[i].Text, fonteTexto);
                e.Graphics.DrawString(listaComprovante.Columns[i].Text, fonteTexto, Brushes.Black, new Rectangle(colunaAtual, linhaAtual, largurasColunas[i], (int)tamanhoColuna.Height));
                colunaAtual += largurasColunas[i];
            }


            linhaAtual += (int)e.Graphics.MeasureString("X", fonteTexto).Height + margemInterna; // Pular uma linha após os cabeçalhos

            // Imprimir dados da lista
            foreach (ListViewItem item in listaComprovante.Items)
            {
                colunaAtual = margemInterna;
                for (int i = 0; i < item.SubItems.Count; i++)
                {
                    // Ajuste para quebra de texto nas colunas
                    var tamanhoSubItem = e.Graphics.MeasureString(item.SubItems[i].Text, fonteTexto);
                    e.Graphics.DrawString(item.SubItems[i].Text, fonteTexto, Brushes.Black, new Rectangle(colunaAtual, linhaAtual, largurasColunas[i], (int)tamanhoSubItem.Height));
                    colunaAtual += largurasColunas[i];
                }
                linhaAtual += alturaLinha;
            }

            // Imprimir informações adicionais
            linhaAtual += margemInterna;
            string textoTotalCompra = $"Total: {labelTotal.Text}\n{lbNomeCliente.Text}\n";


            // Ajuste de posição vertical
            int alturaTextoAdicional = (int)e.Graphics.MeasureString("X", fonteDados).Height + margemInterna;

            linhaAtual += 10 + margemInterna; // Altura da imagem mais a margem interna
            e.Graphics.DrawString(textoTotalCompra, fonteDados, Brushes.Black, new Point(margemInterna, linhaAtual));
            linhaAtual += 10 + margemInterna; // Altura da imagem mais a margem interna
            linhaAtual += alturaTextoAdicional;

            // Imprimir textos adicionais
            linhaAtual += margemInterna;
            Font fonteTextoAdicional = new Font("Arial", 8);
            string textoAdicional1 = "Sistema Desenvolvido por AIRK DIGITAL";
            string textoAdicional2 = "Atendimento WhatsApp: (11)96351-2105";
            e.Graphics.DrawString(textoAdicional1, fonteTextoAdicional, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, fonteTextoAdicional.Height), formatoCentralizado);
            linhaAtual += (int)fonteTextoAdicional.Height;

            e.Graphics.DrawString(textoAdicional2, fonteTextoAdicional, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, fonteTextoAdicional.Height), formatoCentralizado);

        }

        private void labelRelogio_TextChanged(object sender, EventArgs e)
        {
            btnConfirmarimprimir.Enabled = true;
            btnSoSalvar.Enabled = true;
        }
    }
}

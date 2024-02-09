using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Globalization;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace airksucata
{
    public partial class formSistema : Form

    {


        private string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";
        private double selectedMaterialValuePerKg = 0; // Variável para armazenar o valor "pesoporkg" do material selecionado

        public formSistema()
        {
            InitializeComponent();
            InitializeListView();
            LoadMaterialButtons();
            lbAcrescimo.TextChanged += lbAcrescimo_TextChanged;


        }
        public void AtualizarAcrescimo(string valor)
        {
            // Converte o valor para decimal
            if (decimal.TryParse(valor, out decimal valorDecimal))
            {
                // Exibe o valor no formato monetário
                lbAcrescimo.Text = $"+ R${valorDecimal}";
                lbAcrescimo.Visible = true;
            }
            else
            {
                lbAcrescimo.Text = "Valor inválido";
            }
        }
        private void InitializeListView()
        {

            // Configurar o ListView
            listRegistros.View = View.Details;

            // Defina a cor de fundo do ListView
            listRegistros.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);

            // Defina o tamanho da fonte
            listRegistros.Font = new Font("Arial", 9, FontStyle.Regular); // Substitua "Arial" pela fonte desejada
            // Adicionar colunas ao ListView na ordem especificada
            listRegistros.Columns.Add("ID", 35, HorizontalAlignment.Left);
            listRegistros.Columns.Add("Nome", 160, HorizontalAlignment.Left);
            listRegistros.Columns.Add("Valor KG", 80, HorizontalAlignment.Left);
            listRegistros.Columns.Add("Peso", 80, HorizontalAlignment.Left);
            listRegistros.Columns.Add("Total", 100, HorizontalAlignment.Left);
            listRegistros.Columns.Add("Data e Hora", 160, HorizontalAlignment.Left);

            // Preencher o ListView com os dados da tabela "pedidos_impressos"
            PreencherListView();
            AtualizarQuantidadeRegistros();
        }

        private void PreencherListView()
        {
            string consulta = "SELECT id_registro, materialNome, materialValor, inputValor, totalPagar, dataHoraAtual FROM pedidos_impressos ORDER BY id_registro DESC LIMIT 7"; // Substitua por sua consulta SQL

            // Limpar a lista antes de preenchê-la novamente
            listRegistros.Items.Clear();

            using (MySqlConnection conexao = new MySqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand(consulta, conexao);
                    MySqlDataReader leitor = comando.ExecuteReader();

                    while (leitor.Read())
                    {
                        ListViewItem item = new ListViewItem(leitor["id_registro"].ToString());
                        item.SubItems.Add(leitor["materialNome"].ToString());
                        item.SubItems.Add(leitor["materialValor"].ToString());
                        item.SubItems.Add(leitor["inputValor"].ToString());
                        item.SubItems.Add(leitor["totalPagar"].ToString());
                        item.SubItems.Add(leitor["dataHoraAtual"].ToString());

                        listRegistros.Items.Add(item);
                    }

                    leitor.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao preencher ListView: " + ex.Message);
                }
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void LoadMaterialButtons()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id, nome, valorporkg FROM materiais ORDER BY nome"; // Consulta SQL para obter os dados
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    int row = 0;
                    int col = 0;
                    int maxButtonsPerRow = 6;

                    while (reader.Read())
                    {
                        string nome = reader.GetString("nome");
                        CreateMaterialButton(row, col, nome);

                        col++;
                        if (col >= maxButtonsPerRow)
                        {
                            col = 0;
                            row++;
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar materiais: " + ex.Message);
                }
            }
        }
        private Button selectedButton; // Adicione esta variável de classe para armazenar o botão selecionado

        private void CreateMaterialButton(int row, int col, string nome)
        {
            Button newButton = new Button();

            // Ajuste o formato do nome para "Nome"
            string formattedNome = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nome.ToLower());

            newButton.Text = formattedNome;
            newButton.Width = 143; // Defina a largura desejada
            newButton.Height = 30; // Defina a altura desejada
            newButton.BackColor = Color.FromArgb(0, 140, 0); // Cor de fundo
            newButton.ForeColor = Color.White; // Cor do texto
            newButton.Font = new Font("Arial", 8, FontStyle.Bold); // Fonte e tamanho do texto
            newButton.FlatStyle = FlatStyle.Flat; // Estilo do botão
            newButton.FlatAppearance.BorderSize = 0; // Espessura da borda
            newButton.Margin = new Padding(1); // Margem
            newButton.Padding = new Padding(0); // Espaçamento interno
            newButton.TextAlign = ContentAlignment.MiddleCenter; // Alinhamento do texto
            newButton.TextImageRelation = TextImageRelation.TextAboveImage; // Relação entre texto e imagem
            newButton.Location = new Point(col * (newButton.Width + 2), row * (newButton.Height + 2));
            newButton.Click += MaterialButton_Click;

            // Adicione o botão ao painel ou contêiner desejado
            btnsMaterial.Controls.Add(newButton); // Substitua "btnsMaterial" pelo nome correto do seu painel
        }


        private void MaterialButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                Button clickedButton = (Button)sender; // Obtém o botão clicado

                // Remova a borda de qualquer botão selecionado anteriormente
                if (selectedButton != null)
                {
                    selectedButton.FlatAppearance.BorderSize = 0;
                    selectedButton.BackColor = Color.FromArgb(0, 140, 0);
                }

                // Atualiza os campos de texto com os valores
                nomeProduto.Text = clickedButton.Text;

                // Define a borda para o botão atualmente selecionado
                clickedButton.FlatAppearance.BorderSize = 1;
                clickedButton.FlatAppearance.BorderColor = Color.Lime;
                clickedButton.BackColor = Color.FromArgb(0, 40, 0);

                // Armazena o botão selecionado
                selectedButton = clickedButton;

                try
                {
                    connection.Open();

                    string query = "SELECT valorporkg FROM materiais WHERE nome = @nome"; // Consulta SQL para obter o valorporkg
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", clickedButton.Text);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string valorPorKgString = result.ToString();
                        valorPorKgString = valorPorKgString.Replace(".", ",");
                        selectedMaterialValuePerKg = Convert.ToDouble(valorPorKgString);
                        valorKg.Text = selectedMaterialValuePerKg.ToString("C2");
                        nomeProduto.Text = clickedButton.Text; // Atualiza o nome do produto
                        btnInserir.Enabled = true; // Ativa o botão "btnInserir" após o cálculo ser realizado
                        btnImprimir.Enabled = true;
                        btnAcrescimo.Enabled = true;
                        btnInserirNome.Enabled = true;

                        // Verificar a quantidade de itens na lista e atualizar o botão "btnImprimir"
                        if (listaRegistrosListView.Items.Count == 0)
                        {
                            btnImprimir.Enabled = false;
                        }

                        // Chama a função para exibir detalhes
                        //ExibirDetalhes(clickedButton.Text);
                    }
                    else
                    {
                        MessageBox.Show("Valor por kg não encontrado para o material selecionado.");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter valor por kg do material: " + ex.Message);
                    return;
                }
            }

            double peso;
            string pesoText = txtPeso.Text.Replace("kg", ""); // Remova o "kg" do texto

            if (!string.IsNullOrEmpty(pesoText) && double.TryParse(pesoText, out peso))
            {
                double valorTotal = peso * selectedMaterialValuePerKg;

                // Verifica se lbAcrescimo está sendo exibido
                if (lbAcrescimo.Visible)
                {
                    // Obtém o valor atual de lbAcrescimo
                    if (double.TryParse(lbAcrescimo.Text.Replace("+R$", "").Trim(), out double valorAcrescimo))
                    {
                        // Calcula o novo totalPagar considerando lbAcrescimo
                        double totalPagar = (selectedMaterialValuePerKg + valorAcrescimo) * peso;

                        // Atualiza o totalPagarLb
                        totalPagarLb.Text = totalPagar.ToString("C2");
                    }
                    else
                    {
                        MessageBox.Show("O valor atual em lbAcrescimo não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Caso lbAcrescimo não esteja sendo exibido, calcula o totalPagar sem considerar lbAcrescimo
                    totalPagarLb.Text = valorTotal.ToString("C2");
                }
            }
            else
            {
                // Mostrar caixa de diálogo personalizada com a mensagem de aviso
                CustomMessageBox customMessageBox = new CustomMessageBox();
                valorKg.Text = "R$ 0,00";
                totalPagarLb.Text = "R$ 0,00";
                btnInserir.Enabled = false;
                btnImprimir.Enabled = false;
                btnAcrescimo.Enabled = false;
                btnInserirNome.Enabled = false;
                customMessageBox.ShowDialog();
                resetaButtonMaterial();
            }
            AtualizarQuantidadeRegistros();
        }


        /*private void ExibirDetalhes(string materialName)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT detalhes FROM materiais WHERE nome = @nome"; // Consulta SQL para obter detalhes
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", materialName);

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        string detalhes = result.ToString();
                        detalhesMaterial.Text = detalhes; // Exibe os detalhes no label detalhesMaterial
                    }
                    else
                    {
                        MessageBox.Show("Detalhes não encontrados para o material selecionado.");
                        detalhesMaterial.Text = string.Empty; // Limpa o label em caso de erro
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter detalhes do material: " + ex.Message);
                    detalhesMaterial.Text = string.Empty; // Limpa o label em caso de erro
                }
            }
        }*/

        private double CalcularTotalPagar(double valorAcrescimo, double valorPorKg, double peso)
        {
            double valorTotalAcrescimo = valorAcrescimo + (valorPorKg * peso);
            return valorTotalAcrescimo;
        }
        //AQUI FAZ O CÁCULO APÓS CLICAR EM ALGUM MATERIAL

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Atualiza o labelRelogio com a data e hora atual
            labelRelogio.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPeso.Text = txtPeso.Text + "0";
        }

        private void btnVirg_Click(object sender, EventArgs e)
        {
            if (!txtPeso.Text.Contains(","))
            {
                txtPeso.Text = txtPeso.Text + ",";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPeso.Text = txtPeso.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPeso.Text = txtPeso.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPeso.Text = txtPeso.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPeso.Text = txtPeso.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPeso.Text = txtPeso.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPeso.Text = txtPeso.Text + "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtPeso.Text = txtPeso.Text + "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtPeso.Text = txtPeso.Text + "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txtPeso.Text = txtPeso.Text + "9";
        }
        private void btnCe_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text.Length > 0)
            {
                txtPeso.Text = txtPeso.Text.Substring(0, txtPeso.Text.Length - 1);

                if (txtPeso.Text.Length == 0)
                {
                    txtPeso.Text = ""; // Se o campo estiver vazio, defina como valor inicial
                    btnInserir.Enabled = false; //DESATIVA O BOTÃO INSERIR
                    btnImprimir.Enabled = false; //DESATIVA O BOTÃO IMPRIMIR
                }
            }
        }
        private void btnZerar_Click(object sender, EventArgs e)
        {
            nomeProduto.Text = "Material";
            txtPeso.Text = "";
            valorKg.Text = "R$ 0,00";
            totalPagarLb.Text = "R$ 0,00";
            btnInserir.Enabled = false; //DESATIVA O BOTÃO INSERIR
            //btnImprimir.Enabled = false; //DESATIVA O BOTÃO IMPRIMIR
            // Verificar se a lista está vazia e desabilitar o botão se necessário
            if (listaRegistrosListView.Items.Count == 0)
            {
                btnImprimir.Enabled = false;
            }
            AtualizarQuantidadeRegistros();
            btnAcrescimo.Enabled = false;


        }
        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtualizarQuantidadeRegistros()
        {
            // Obtenha a quantidade de itens no ListView
            int quantidadeRegistros = listaRegistrosListView.Items.Count;

            // Adicione 1 se a quantidade for menor que 100 e maior ou igual a 0
            quantidadeRegistros = (quantidadeRegistros < 100 && quantidadeRegistros >= 0) ? quantidadeRegistros : quantidadeRegistros;

            // Exiba a quantidade no Label
            lbQuantRegistros.Text = $"{quantidadeRegistros}";

            // Verifique se atingiu a quantidade máxima
            if (quantidadeRegistros >= 100)
            {
                // Desabilite o botão de inserção
                btnInserir.Enabled = false;
                btnImprimir.Enabled = true;

                // Exiba o label informando que a quantidade máxima foi atingida
                lbMax.Text = "LIMITE ATINGIDO";
                lbMax.Visible = true;
            }
            else
            {
                if (quantidadeRegistros > 0)
                {
                    // Se a quantidade não atingiu o máximo, habilite o botão de inserção
                    btnImprimir.Enabled = true;

                }

                // Exiba o contador no lbMax
                lbMax.Text = $"{quantidadeRegistros}";

                // Oculte o label informando que a quantidade máxima foi atingida
                lbMax.Visible = false;
            }
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

        public void VerificarEExcluirArquivo()
        {
            // Caminho completo para o arquivo "acrescimoTemp.bin"
            string caminhoArquivo = Path.Combine("valorAcresc", "acrescimoTemp.bin");

            try
            {
                // Verifica se o arquivo existe
                if (File.Exists(caminhoArquivo))
                {
                    // Exclui o arquivo
                    File.Delete(caminhoArquivo);

                    Console.WriteLine("Arquivo 'acrescimoTemp.bin' excluído com sucesso.");
                }
                else
                {
                    Console.WriteLine("O arquivo 'acrescimoTemp.bin' não existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao excluir o arquivo: {ex.Message}");
            }
        }


        private void verificaInserirNome()
        {
            // Obtém o texto de lbQuantRegistros
            string textoQuantidade = lbQuantRegistros.Text;

            // Verifica se o texto é um número maior que zero
            if (!string.IsNullOrEmpty(textoQuantidade) && int.TryParse(textoQuantidade, out int quantidadeRegistros) && quantidadeRegistros > 0)
            {
                // Ativa o botão btnInserirNome
                btnInserirNome.Enabled = true;
            }
            else
            {
                // Desativa o botão btnInserirNome se o texto não for um número maior que zero
                btnInserirNome.Enabled = false;
            }
        }
        //AQUI COMEÇA FUNÇÃO DO INSERIR +1
        private void btnInserir_Click(object sender, EventArgs e)
        {
            resetaButtonMaterial();
            string material = nomeProduto.Text;
            double pesoTotal;

            if (double.TryParse(txtPeso.Text.Replace("kg", ""), out pesoTotal))
            {
                double valorAcrescimo = 0.0; // Valor padrão se lbAcrescimo não estiver presente ou for nulo

                // Verifique se lbAcrescimo está presente e não é nulo
                if (lbAcrescimo != null && !string.IsNullOrEmpty(lbAcrescimo.Text))
                {
                    // Obtenha o valor numérico de lbAcrescimo removendo o "+ R$ " e utilizando a CultureInfo para lidar com a formatação
                    string lbAcrescimoTexto = lbAcrescimo.Text.Replace("+ R$ ", "").Replace("/kg", "").Trim();

                    if (double.TryParse(lbAcrescimoTexto, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out valorAcrescimo))
                    {
                        // Some o valor de selectedMaterialValuePerKg com o valor de lbAcrescimo
                        double valorKg2 = selectedMaterialValuePerKg + valorAcrescimo;

                        double totalPagar = pesoTotal * valorKg2;

                        AdicionarRegistroAoListView(material, pesoTotal, valorKg2, totalPagar);
                        SalvarListaTemporaria();
                        // Limpe os campos
                        LimparCampos();
                        btnAcrescimo.Enabled = false;
                        btnInserirNome.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Formato inválido para o valor do acréscimo.", "Erro de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // lbAcrescimo não está presente ou é nulo, prossiga com o valorAcrescimo padrão
                    double valorKg2 = selectedMaterialValuePerKg + valorAcrescimo;
                    double totalPagar = pesoTotal * valorKg2;

                    AdicionarRegistroAoListView(material, pesoTotal, valorKg2, totalPagar);
                    SalvarListaTemporaria();
                    // Limpe os campos
                    LimparCampos();
                    btnAcrescimo.Enabled = false;
                    btnInserirNome.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Peso inválido. Por favor, insira um valor numérico válido.", "Erro de entrada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            VerificarEExcluirArquivo();
            verificaInserirNome();
        }


        private void AdicionarRegistroAoListView(string material, double pesoTotal, double valorKg2, double totalPagar)
        {
            // Inserir o novo item no início da lista
            ListViewItem item = new ListViewItem(material);
            item.SubItems.Add(pesoTotal.ToString("F3"));
            item.SubItems.Add(valorKg2.ToString("C"));
            item.SubItems.Add(totalPagar.ToString("C"));

            listaRegistrosListView.Items.Insert(0, item);

            // Habilitar o botão de imprimir
            btnImprimir.Enabled = true;
            AtualizarQuantidadeRegistros();
        }




        private void LimparCampos()
        {
            nomeProduto.Text = "Nome do Material";
            txtPeso.Text = "";
            valorKg.Text = "R$ 0,00";
            totalPagarLb.Text = "R$ 0,00";
            btnInserir.Enabled = false;
            // Verificar se a lista está vazia e desabilitar o botão se necessário
            if (listaRegistrosListView.Items.Count == 0)
            {
                btnImprimir.Enabled = false;
                btnInserirNome.Enabled = false;
            }
            AtualizarQuantidadeRegistros();

        }
        private void VerificarEExibirClientNameTemp()
        {
            // Verifique se o arquivo "listaTemporaria.json" existe
            string caminhoListaTemporaria = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "listaTemporaria.json");

            if (File.Exists(caminhoListaTemporaria))
            {
                // Se o arquivo "listaTemporaria.json" existe, verifique o arquivo "clientnameTemp.bin"
                string caminhoArquivoClientNameTemp = Path.Combine("clienteNome", "clientnameTemp.bin");

                if (File.Exists(caminhoArquivoClientNameTemp))
                {
                    // Se o arquivo "clientnameTemp.bin" existe, leia o conteúdo e exiba no lbNomeCliente
                    string conteudoClientNameTemp = File.ReadAllText(caminhoArquivoClientNameTemp);

                    // Supondo que você tenha uma referência chamada "formularioSistema" do tipo AIRKCalculatorSist
                    lbNomeCliente.Text = conteudoClientNameTemp;
                }
                else
                {
                    // Se o arquivo "clientnameTemp.bin" não existe, exclua o arquivo da pasta "clienteNome"
                    try
                    {
                        File.Delete(caminhoArquivoClientNameTemp);
                        Console.WriteLine("Arquivo 'clientnameTemp.bin' excluído com sucesso.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao excluir o arquivo 'clientnameTemp.bin': {ex.Message}");
                    }
                }
            }
        }


        private void CarregarListaTemporaria()
        {
            // Verifique se o arquivo "listaTemporaria.json" existe
            if (File.Exists("listaTemporaria.json"))
            {
                try
                {
                    // Leia o conteúdo do arquivo JSON
                    string json = File.ReadAllText("listaTemporaria.json");

                    // Desserialize o JSON em uma lista de objetos
                    var registros = JsonConvert.DeserializeObject<List<Registro>>(json);

                    // Limpe o ListView antes de adicionar os novos itens
                    listaRegistrosListView.Items.Clear();

                    // Adicione os registros ao ListView
                    foreach (var registro in registros)
                    {
                        AdicionarRegistroAoListView(registro.Material, registro.PesoTotal, registro.ValorKg, registro.TotalPagar);
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar dados do arquivo JSON: " + ex.Message);
                }
            }

        }

        private void CarregarAjustesSistema()
        {
            // Caminhos dos arquivos
            string caminhoLogoPrincipal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ajustesGerais", "logoPrincipal.png");
            string caminhoUpdate = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ajustesGerais", "ultimoUpdate.airk");
            string caminhoVersion = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ajustesGerais", "version.airk");

            // Carregar logoPrincipal
            if (File.Exists(caminhoLogoPrincipal))
            {
                Image imagemLogoPrincipal = Image.FromFile(caminhoLogoPrincipal);
                logoPrincipal.Image = imagemLogoPrincipal;
            }

            // Carregar nomeEmpresa
            if (File.Exists(caminhoUpdate))
            {
                string ultimoUp = File.ReadAllText(caminhoUpdate);
                lbUpdate.Text = ultimoUp;
            }

            // Carregar nomeEmpresa
            if (File.Exists(caminhoVersion))
            {
                string ultimaVersion = File.ReadAllText(caminhoVersion);
                lbVersion.Text = ultimaVersion;
            }
        }

        public void statusSistema()
        {
            // Obtém o diretório de trabalho atual
            string diretorio = Environment.CurrentDirectory;

            // Encontrar todos os arquivos no diretório com o padrão de nome "date7d_*.arq"
            string[] arquivos = Directory.GetFiles(diretorio, "date*.arq");

            if (arquivos.Length > 0)
            {
                // Pegar o primeiro arquivo encontrado
                string primeiroArquivo = arquivos[0];

                // Extrair a parte da data do nome do arquivo
                int posicaoInicioData = primeiroArquivo.IndexOf("_") + 1;
                string parteData = primeiroArquivo.Substring(posicaoInicioData, 14);

                // Converter a parte da data para um objeto DateTime
                DateTime dataDoArquivo = DateTime.ParseExact(parteData, "yyyyMMddHHmmss", null);

                // Adicionar 35 dias para obter a data de vencimento
                DateTime dataDeVencimento = dataDoArquivo.AddDays(35);

                // Data atual
                DateTime dataAtual = DateTime.Now;

                // Calcular a diferença em dias
                int diasRestantes = (int)(dataDeVencimento - dataAtual).TotalDays;

                // Exibir a informação no label
                string status = diasRestantes > 0 ? $"Sistema Ativo! - Restam {diasRestantes} dias de uso." : "O prazo expirou.";

                // Aqui você deve substituir "lbStatus" pelo nome real do seu controle Label
                lbStatus.Text = status;

                // Desabilitar todos os botões se o prazo expirou
                if (status == "O prazo expirou.")
                {
                    DesabilitarBotoes();
                }
            }
            else
            {
                // Nenhum arquivo encontrado
                lbStatus.Text = "NENHUM PLANO ATIVO.";

                // Desabilitar todos os botões
                DesabilitarBotoes();
            }
        }

        private void DesabilitarBotoes()
        {
            // Desabilitar todos os botões do formulário
            panel6.Enabled = false;
            listRegistros.Enabled = false;
            btnConfig.Visible = false;
            btnAtualizar.Visible = false;
            btnsMaterial.Enabled = false;
            lbPrazoVencido1.Visible = true;
            lbPrazoVencido2.Visible = true;
        }
        private void formSistema_Load(object sender, EventArgs e)
        {

            statusSistema();
            CarregarAjustesSistema();
            // Carregue os dados do arquivo JSON ao abrir o formulário
            CarregarListaTemporaria();
            //VerificarEExibirClientNameTemp();

            // Configure as colunas do ListView
            listaRegistrosListView.View = View.Details;
            listaRegistrosListView.Columns.Add("Material", 130);
            listaRegistrosListView.Columns.Add("Peso", 80);
            listaRegistrosListView.Columns.Add("Valor KG", 80);
            listaRegistrosListView.Columns.Add("Total R$", 110);

            // Configurar o estilo dos cabeçalhos das colunas
            listaRegistrosListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listaRegistrosListView.BackColor = Color.FromArgb(30, 30, 30);
            listaRegistrosListView.ForeColor = Color.White;
            listaRegistrosListView.Font = new Font("Nexa", 11);


            /* listaRegistrosListBox.Font = new Font("Century Gothic", 10);
             listaRegistrosListBox.ForeColor = Color.White;
             //listaRegistrosListBox.BackColor = Color.Black;
             listaRegistrosListBox.SelectionMode = SelectionMode.None;*/

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    //connection.Open();
                    //MessageBox.Show("Conexão estabelecida com sucesso!");
                    // Agora a conexão está aberta e pronta para ser usada
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de dados: " + ex.Message);
                }
            }
            btnInserir.Enabled = false; // //DESATIVA O BOTÃO INSERIR
            btnImprimir.Enabled = false; //DESATIVA O BOTÃO IMPRIMIR
            AtualizarQuantidadeRegistros();
            excluirNome();
        }

        private void listaRegistrosListView_DoubleClick(object sender, EventArgs e)
        {
            if (listaRegistrosListView.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listaRegistrosListView.SelectedItems[0];

                string message = "Deseja remover o registro selecionado?";
                confirmarDelete confirmationForm = new confirmarDelete(message);

                if (confirmationForm.ShowDialog() == DialogResult.Yes)
                {
                    listaRegistrosListView.Items.Remove(selectedItem);
                    SalvarListaTemporaria();

                    // Verificar se a lista está vazia e desabilitar o botão se necessário
                    if (listaRegistrosListView.Items.Count == 0)
                    {
                        btnImprimir.Enabled = false;
                    }
                    AtualizarQuantidadeRegistros();
                }
            }
        }
        private decimal CalculateTotal()
        {
            decimal total = 0;

            foreach (ListViewItem item in listaRegistrosListView.Items)
            {
                if (decimal.TryParse(item.SubItems[3].Text, out decimal itemTotal))
                {
                    total += itemTotal;
                }
            }

            return total;
        }

        private void ClearMaterialButtons(Panel panel)
        {
            panel.Controls.Clear();
        }
        public void RefreshInterface()
        {
            // Limpa os botões existentes antes de carregar novos botões
            ClearMaterialButtons(btnsMaterial);
            // Carrega os novos botões
            LoadMaterialButtons();

            // Limpar campos
            nomeProduto.Text = "Nome do Material";
            txtPeso.Text = "";
            valorKg.Text = "R$ 0,00";
            totalPagarLb.Text = "R$ 0,00";
            lbQuantRegistros.Text = "0";

            // Limpar a lista de registros e desabilitar o botão "btnImprimir"
            listaRegistrosListView.Items.Clear();
            listRegistros.Items.Clear();
            btnImprimir.Enabled = false;
            btnAcrescimo.Enabled = false;
            lbAcrescimo.Visible = false;
            lbNomeCliente.Visible = false;
            btnInserirNome.Enabled = false;

            // Preencher a lista de registros novamente
            PreencherListView();

            // Atualizar a lista de registros no ListView (se você também precisa disso)
            //AtualizarListaRegistrosListView();

            // Outras atualizações ou redefinições que você precisa fazer
            // ...

            // Ativar ou desativar botões conforme necessário
            btnInserir.Enabled = false;
            AtualizarQuantidadeRegistros();
            excluirNome();
            LoadMaterialButtons();
            resetaButtonMaterial();




        }
        public void resetaButtonMaterial()
        {
            // Remova a borda de qualquer botão selecionado anteriormente
            if (selectedButton != null)
            {
                selectedButton.FlatAppearance.BorderSize = 0;
                selectedButton.BackColor = Color.FromArgb(0, 140, 0);
            }
        }
        public void excluirNome()
        {
            // Caminho completo para o arquivo "clientnameTemp.bin"
            string caminhoNome = Path.Combine("clienteNome", "clientnameTemp.bin");

            try
            {
                // Verifica se o arquivo existe
                if (File.Exists(caminhoNome))
                {
                    // Exclui o arquivo
                    File.Delete(caminhoNome);

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

        private void DesabilitaAcrescimo()
        {

            //lbAcrescimo.Visible = false;
        }


        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshInterface();
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
                    //MessageBox.Show("Erro ao excluir o arquivo listaTemporaria.json: " + ex.Message);
                }
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {

            // AQUI CRIA O FORM DE VERIFICAÇÃO DE ACESSO A CONFIGURAÇÕES
            formVerificacao formVerifi = new formVerificacao();

            // Abra o novo formulário como uma janela de diálogo (modal)
            DialogResult result = formVerifi.ShowDialog();

            // AQUI CRIA O FORM CONTEUDO DAS CONFIGURAÇÕES
            //formConfig formConfig = new formConfig();

            // Abra o novo formulário como uma janela de diálogo (modal)
            //DialogResult result = formConfig.ShowDialog();

            // Verifique o resultado do diálogo, se necessário
            if (result == DialogResult.OK)
            {
                // Alguma ação após fechar o formulário de configuração, se necessário
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Cria uma nova lista para armazenar os ListViewItem
            List<ListViewItem> listViewItems = new List<ListViewItem>();

            // Copia os itens da coleção da listaRegistrosListView para a lista listViewItems
            foreach (ListViewItem item in listaRegistrosListView.Items)
            {
                listViewItems.Add((ListViewItem)item.Clone());
            }

            // Cria uma nova instância da formComprovante
            FormComprovante formComprovante = new FormComprovante(listViewItems);
            formComprovante.ShowDialog();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            // AQUI CRIA O FORM DE VERIFICAÇÃO DE ACESSO A CONFIGURAÇÕES
            AIRKTipoDeVenda formTipoVenda = new AIRKTipoDeVenda();

            // Abra o novo formulário como uma janela de diálogo (modal)
            DialogResult result = formTipoVenda.ShowDialog();
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            // AQUI CRIA O FORM DE VERIFICAÇÃO DE ACESSO A CONFIGURAÇÕES
            formReimprimir formReimprime = new formReimprimir();

            // Abra o novo formulário como uma janela de diálogo (modal)
            DialogResult result = formReimprime.ShowDialog();
        }

        private void SalvarListaTemporaria()
        {
            // Criar uma lista para armazenar os registros
            List<Registro> registros = new List<Registro>();

            // Iterar através dos itens do ListView e adicionar os registros à lista
            foreach (ListViewItem item in listaRegistrosListView.Items)
            {
                string material = item.SubItems[0].Text;
                double pesoTotal = Convert.ToDouble(item.SubItems[1].Text);
                double valorKg = Convert.ToDouble(item.SubItems[2].Text.Replace("R$ ", "").Replace(".", "").Replace(",", ".")) / 100;
                double totalPagar = Convert.ToDouble(item.SubItems[3].Text.Replace("R$ ", "").Replace(".", "").Replace(",", ".")) / 100;

                registros.Add(new Registro
                {
                    Material = material,
                    PesoTotal = pesoTotal,
                    ValorKg = valorKg,
                    TotalPagar = totalPagar
                });
            }

            // Serializar a lista para JSON
            string json = JsonConvert.SerializeObject(registros, Formatting.Indented);

            try
            {
                // Salvar o JSON em um arquivo
                File.WriteAllText("listaTemporaria.json", json);
                //MessageBox.Show("Lista temporária salva com sucesso em listaTemporaria.json", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao salvar a lista temporária: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Classe de modelo para os registros
        public class Registro
        {
            public string Material { get; set; }
            public double PesoTotal { get; set; }
            public double ValorKg { get; set; }
            public double TotalPagar { get; set; }
        }

        private void btnAcrescimo_Click(object sender, EventArgs e)
        {
            // Ao clicar no botão, cria uma nova instância do AIRKFormTipoAcrescimo e a exibe
            AIRKFormTipoAcrescimo formTipoAcrescimo = new AIRKFormTipoAcrescimo();
            formTipoAcrescimo.Show();
        }

        private void lbAcrescimo_TextChanged(object sender, EventArgs e)
        {
            AtualizarTotalPagar();
        }

        private void AtualizarTotalPagar()
        {
            // Caminho completo para o arquivo "acrescimoTemp.bin"
            string caminhoArquivo = Path.Combine(Application.StartupPath, "valorAcresc", "acrescimoTemp.bin");

            if (File.Exists(caminhoArquivo))
            {
                // Lê o valor do arquivo
                string valorArquivo = File.ReadAllText(caminhoArquivo);

                // Converte o valor do arquivo para decimal
                if (decimal.TryParse(valorArquivo, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal valorArquivoDecimal))
                {
                    // Obtém o valor atual do textbox txtPeso
                    if (decimal.TryParse(txtPeso.Text, out decimal pesoDecimal))
                    {
                        // Obtém o valor atual do totalPagarLb
                        if (decimal.TryParse(valorKg.Text.Replace("R$", "").Trim(), out decimal valorKgDecimal))
                        {
                            // Obtém o valor atual do lbAcrescimo
                            decimal valorAcrescimo = 0;
                            if (lbAcrescimo.Visible && decimal.TryParse(lbAcrescimo.Text.Replace("+R$", "").Trim(), out decimal lbAcrescimoDecimal))
                            {
                                valorAcrescimo = lbAcrescimoDecimal;
                            }

                            // Calcula o novo totalPagar
                            decimal novoTotalPagar = (valorKgDecimal + valorAcrescimo) * pesoDecimal;

                            // Atualiza o totalPagarLb
                            totalPagarLb.Text = $"R$ {novoTotalPagar:N2}";
                        }
                        else
                        {
                            MessageBox.Show("O valor atual no totalPagarLb não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Obtém o valor atual do textbox txtPeso
                        if (string.IsNullOrEmpty(txtPeso.Text))
                        {
                            // Se o txtPeso estiver vazio, exclui o arquivo acrescimoTemp.bin
                            string caminhoArquivo2 = Path.Combine(Application.StartupPath, "valorAcresc", "acrescimoTemp.bin");

                            if (File.Exists(caminhoArquivo2))
                            {
                                File.Delete(caminhoArquivo2);
                            }

                        }
                        else if (decimal.TryParse(txtPeso.Text, out pesoDecimal))
                        {
                            // O valor foi parseado corretamente
                            // Continua com o restante do código
                        }
                        else
                        {
                            MessageBox.Show("O valor atual no txtPeso não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                        //MessageBox.Show("O valor atual no txtPeso não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O valor no arquivo não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void AtualizarValorKgETotalPagar()
        {
            AtualizarQuantidadeRegistros();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // Verifica se o arquivo "acrescimoTemp.bin" existe na pasta "valorAcresc"
            string pastaValorAcresc = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "valorAcresc");
            string caminhoArquivoBin = Path.Combine(pastaValorAcresc, "acrescimoTemp.bin");

            if (File.Exists(caminhoArquivoBin))
            {
                // Lê o valor do arquivo de texto
                string valorTexto = File.ReadAllText(caminhoArquivoBin);

                // Verifica se é possível converter o valor para decimal
                if (decimal.TryParse(valorTexto, out decimal valorBinario))
                {
                    // Atualiza o lbAcrescimo com o valor atual
                    lbAcrescimo.Text = $"+R$ {valorBinario:N2}";

                    // Torna o lbAcrescimo visível
                    lbAcrescimo.Visible = true;
                }
                else
                {
                    MessageBox.Show("O valor no arquivo 'acrescimoTemp.bin' não é válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Caso o arquivo não exista, define o lbAcrescimo como vazio e o torna invisível
                lbAcrescimo.Text = "";
                lbAcrescimo.Visible = false;
            }

            AtualizarTotalPagar();
            VerificarExibirNomeCliente();
            verificaBtnNome();


        }

        private void verificaBtnNome()
        {
            // Verifica se o lbNomeCliente está sendo exibido
            if (lbNomeCliente.Visible)
            {
                // Se estiver sendo exibido, torna o btnInserirNome invisível e o btnAlterarNome visível
                btnInserirNome.Visible = false;
                btnAlterarNome.Visible = true;
            }
            else
            {
                // Caso contrário, torna o btnInserirNome visível e o btnAlterarNome invisível
                btnInserirNome.Visible = true;
                btnAlterarNome.Visible = false;
            }
        }

        private void VerificarExibirNomeCliente()
        {
            // Caminho completo para o arquivo "clientnameTemp.bin"
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clienteNome", "clientnameTemp.bin");

            // Verifica se o arquivo existe
            if (File.Exists(caminhoArquivo))
            {
                // Lê o valor do arquivo
                string nomeCliente = File.ReadAllText(caminhoArquivo);

                // Atualiza o texto da label
                lbNomeCliente.Text = "Cliente: " + nomeCliente;

                // Torna a label visível
                lbNomeCliente.Visible = true;
            }
            else
            {
                // Se o arquivo não existe, torna a label invisível
                lbNomeCliente.Visible = false;
            }
        }
        private void btnInserirNome_Click(object sender, EventArgs e)
        {
            // Ao clicar no botão, cria uma nova instância do AIRKFormTipoAcrescimo e a exibe
            AIRKInserirNome formNomeCliente = new AIRKInserirNome();
            formNomeCliente.Show();
        }

        private void btnZerar_Click_1(object sender, EventArgs e)
        {
            resetaButtonMaterial();
            btnInserirNome.Enabled = false;

        }

        private void lbQuantRegistros_TextChanged(object sender, EventArgs e)
        {

        }


    }

}

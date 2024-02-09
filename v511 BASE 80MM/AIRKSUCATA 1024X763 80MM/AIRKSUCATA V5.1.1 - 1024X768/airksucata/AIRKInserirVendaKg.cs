using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.Data;
using System.Globalization;

namespace airksucata
{
    public partial class AIRKInserirVendaKg : Form
    {
        // Declare a lista de histórico de valores como uma variável de classe
        private List<decimal> valueHistory = new List<decimal>();
        // Declare a variável para armazenar o número único
        private int numeroUnico;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        

        public AIRKInserirVendaKg()
        {
            InitializeComponent();
            txtPeso.BorderStyle = BorderStyle.FixedSingle;
            // Associando o manipulador de eventos ao evento TextChanged de txtPeso
            txtPeso.TextChanged += txtPeso_TextChanged;

            // Configurar o Timer para atualizar a cada segundo (1000 milissegundos)
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start();

            // Recupere o próximo número único ao iniciar o formulário
            numeroUnico = ObterProximoNumeroUnico();

            // Exiba o número único no label lbRegistroVenda formatado como "000001"
            lbRegistroVenda.Text = numeroUnico.ToString("000000");

        }
        private void AIRKInserirVendaKg_Load(object sender, EventArgs e)
        {
            // Desative o foco no txtPeso
            this.ActiveControl = null;

            // Torne o txtPeso não editável
            txtPeso.ReadOnly = true;

            // Remova a seleção de texto no evento Enter
            txtPeso.Enter += TxtPeso_Enter;

        }
        private void TxtPeso_Enter(object sender, EventArgs e)
        {
            // Remova a seleção de texto
            txtPeso.Select(0, 0);
        }


        private int ObterProximoNumeroUnico()
        {
            string connectionString = "Server=localhost;Database=xlata_db;User=root;Password=;";
            string query = "SELECT MAX(id_venda) FROM vendas_kg";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        // Se houver um valor máximo, incremente-o em 1 e retorne
                        return Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        // Se não houver valores na tabela, comece com 1
                        return 1;
                    }
                }
            }
        }


        private int ObterProximoNumeroDisponivel(int numeroAtualRegistroVenda)
        {
            string connectionString = "Server=localhost;Database=xlata_db;User=root;Password=;";
            string query = "SELECT id_venda FROM vendas_kg WHERE id_venda = @NumeroUnico";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    while (true)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@NumeroUnico", numeroAtualRegistroVenda);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            // Se o número atual de registro já existe no banco de dados, incremente e verifique novamente
                            numeroAtualRegistroVenda++;
                        }
                        else
                        {
                            // Se o número atual de registro não existir no banco de dados, retorne-o
                            return numeroAtualRegistroVenda;
                        }
                    }
                }
            }
        }



        private decimal CalcularValorTotal()
        {
            // Obtenha o valor unitário do campo txtValorMaterial
            if (decimal.TryParse(txtValorMaterial.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal valorUnitario))
            {
                // Obtenha a quantidade do campo txtPeso
                if (decimal.TryParse(txtPeso.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal quantidade))
                {
                    // Calcule o valor total
                    decimal valorTotal = valorUnitario * quantidade;
                    return valorTotal;
                }
            }

            // Caso haja um erro ou um valor inválido, retorne 0
            return 0;
        }


        private void txtQuant_TextChanged(object sender, EventArgs e)
        {
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
            VerificarHabilitacaoBtnFinalizar();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "0";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtNomeMaterial.Text.Length > 0)
            {
                txtNomeMaterial.Text = txtNomeMaterial.Text.Substring(0, txtNomeMaterial.Text.Length - 1);

                if (txtNomeMaterial.Text.Length == 0)
                {
                    txtNomeMaterial.Text = ""; // Se o campo estiver vazio, defina como valor inicial
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text = "";
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "Q";
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "W";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "E";
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "R";
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "T";
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "Y";
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "U";
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "I";
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "O";
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "P";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "A";
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "S";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "D";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "F";
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "G";
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "H";
        }

        private void btnJ_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "J";
        }

        private void btnK_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "K";
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "L";
        }

        private void btnÇ_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "Ç";
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "Z";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "X";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "C";
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "V";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "B";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "N";
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "M";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += ".";
        }

        private void btnTraço_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += "-";
        }

        private void btnAddValor01_Click(object sender, EventArgs e)
        {
            AdicionarValor(0.01m);
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnAddValor10_Click(object sender, EventArgs e)
        {
            AdicionarValor(0.10m);
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnAddValor50_Click(object sender, EventArgs e)
        {
            AdicionarValor(0.50m);
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnAddValor200_Click(object sender, EventArgs e)
        {
            AdicionarValor(2.00m);
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnAddValor1000_Click(object sender, EventArgs e)
        {
            AdicionarValor(10.00m);
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnAddValor5000_Click(object sender, EventArgs e)
        {
            AdicionarValor(50.00m);
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void AdicionarValor(decimal valor)
        {
            if (decimal.TryParse(txtValorMaterial.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal valorAtual))
            {
                decimal novoValor = valorAtual + valor;
                txtValorMaterial.Text = novoValor.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

                // Registre a modificação na lista de histórico
                valueHistory.Add(novoValor);
            }
            else
            {
                txtValorMaterial.Text = valor.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
                // Registre a modificação na lista de histórico
                valueHistory.Add(valor);
            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            if (valueHistory.Count > 1) // Certifique-se de que exista mais de um valor no histórico para desfazer
            {
                // Remova o valor atual da lista de histórico
                valueHistory.RemoveAt(valueHistory.Count - 1);

                // Obtenha o valor mais recente (anterior) na lista
                decimal valorAnterior = valueHistory.Last();

                // Atualize o campo txtValorMaterial com o valor anterior
                txtValorMaterial.Text = valorAnterior.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
            }
            else if (valueHistory.Count == 1)
            {
                // Se houver apenas um valor no histórico, restaure-o
                decimal valorAnterior = valueHistory.First();
                txtValorMaterial.Text = valorAnterior.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
            }
            else
            {
                MessageBox.Show("Não há alterações para desfazer.");
            }
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            txtValorMaterial.Text = "";
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnMais1_Click(object sender, EventArgs e)
        {
            AtualizarQuantidade(1); // Adiciona +1 à quantidade atual
        }

        private void btnMenos1_Click(object sender, EventArgs e)
        {
            AtualizarQuantidade(-1); // Subtrai 1 da quantidade atual
        }

        private void AtualizarQuantidade(int valor)
        {
            if (int.TryParse(txtPeso.Text, out int quantidade))
            {
                quantidade += valor; // Adiciona ou subtrai o valor especificado

                // Certifique-se de que a quantidade não seja menor que zero
                quantidade = Math.Max(0, quantidade);

                // Atualiza o campo txtQuant com a nova quantidade
                txtPeso.Text = quantidade.ToString();
            }
            else
            {
                // Se a conversão não funcionar, defina o valor para 0
                txtPeso.Text = "0";
            }
        }


        private void btnSpace_Click(object sender, EventArgs e)
        {
            txtNomeMaterial.Text += " ";
        }

        private void btnAddValor10000_Click(object sender, EventArgs e)
        {
            AdicionarValor(100.00m);
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnAddValor50000_Click(object sender, EventArgs e)
        {
            AdicionarValor(500.00m);
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }
        private void btnAddValor250000_Click(object sender, EventArgs e)
        {
            AdicionarValor(2500.00m);
            // Calcule o valor total
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));
        }

        private void btnQuantVirgula_Click(object sender, EventArgs e)
        {
            if (!txtPeso.Text.Contains(","))
            {
                txtPeso.Text = txtPeso.Text + ",";
            }

        }

        private void btnQuantNum1_Click(object sender, EventArgs e)
        {
            txtPeso.Text += "1";
        }

        private void btnQuantNum2_Click(object sender, EventArgs e)
        {
            txtPeso.Text += "2";
        }

        private void btnQuantNum3_Click(object sender, EventArgs e)
        {
            txtPeso.Text += "3";
        }

        private void btnQuantNum4_Click(object sender, EventArgs e)
        {
            txtPeso.Text += "4";
        }

        private void btnQuantNum5_Click(object sender, EventArgs e)
        {
            txtPeso.Text += "5";
        }

        private void btnQuantNum6_Click(object sender, EventArgs e)
        {
            txtPeso.Text += "6";
        }

        private void btnQuantNum7_Click(object sender, EventArgs e)
        {
            txtPeso.Text += "7";
        }

        private void btnQuantNum8_Click(object sender, EventArgs e)
        {
            txtPeso.Text += "8";
        }

        private void btnQuantNum9_Click(object sender, EventArgs e)
        {
            txtPeso.Text += "9";
        }

        private void btnQuantNum0_Click(object sender, EventArgs e)
        {
            txtPeso.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPeso.Text = "";
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {

            // Valores dos controles
            string nomeMaterial = txtNomeMaterial.Text;
            decimal valorVenda = decimal.Parse(txtValorMaterial.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"));
            decimal valorUnitario = decimal.Parse(labelValorTotal.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"));
            decimal quantidadeVenda = decimal.Parse(txtPeso.Text);

            // Forma de pagamento selecionada
            string formaPagamento = ObterFormaPagamentoSelecionada(); // Função para obter a forma de pagamento selecionada

            // Obtenha a data e hora atuais
            DateTime dataVenda = DateTime.Now;

            // String de conexão com o banco de dados MySQL
            string connectionString = "Server=localhost;Database=xlata_db;User=root;Password=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Comando SQL para inserir os dados na tabela "vendas" sem especificar um valor para a coluna "id_venda"
                string query = "INSERT INTO vendas_kg (produto_venda, valor_kg, valor_venda, forma_pagamento, peso_venda, dataVenda) " +
                    "VALUES (@Produto, @ValorKg, @ValorVenda, @FormaPagamento, @Peso, @DataVenda)";

                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Produto", nomeMaterial);
                    cmd.Parameters.AddWithValue("@ValorKg", valorVenda); // Aqui você deve usar o valor unitário
                    cmd.Parameters.AddWithValue("@ValorVenda", valorUnitario); // Aqui você deve usar o valor total
                    cmd.Parameters.AddWithValue("@FormaPagamento", formaPagamento);
                    cmd.Parameters.AddWithValue("@Peso", quantidadeVenda);
                    cmd.Parameters.AddWithValue("@DataVenda", dataVenda);

                    cmd.ExecuteNonQuery();
                }
            }
            // Salvar no arquivo JSON
            SalvarEmArquivoJson(nomeMaterial, valorVenda, valorUnitario, formaPagamento, quantidadeVenda, dataVenda);

            // Feche a janela atual
            this.Close();

            // AQUI CRIA O FORM DE VERIFICAÇÃO DE ACESSO A CONFIGURAÇÕES
            AIRKVendaSalva VendaSalva = new AIRKVendaSalva();

            // Abra o novo formulário como uma janela de diálogo (modal)
            DialogResult result = VendaSalva.ShowDialog();
        }
        // Declare a lista no nível da classe
        private List<object> listaVendas = new List<object>();

        private void SalvarEmArquivoJson(string nomeMaterial, decimal valorVenda, decimal valorUnitario, string formaPagamento, decimal quantidadeVenda, DateTime dataVenda)
        {
            // Crie um objeto para armazenar os dados do item específico
            var dadosVendaItem = new
            {
                Produto = nomeMaterial,
                ValorKg = valorVenda.ToString("C"), // Formatando como moeda
                ValorVenda = valorUnitario.ToString("C"), // Formatando como moeda
                FormaPagamento = formaPagamento,
                Peso = $"{quantidadeVenda:F3}", // Formatando para 3 casas decimais
                DataVenda = dataVenda
            };

            // Crie o nome da pasta com base na data atual sem a hora
            string nomePasta = $"relatorioVendaPorKg\\{dataVenda:yyyy-MM-dd}";

            // Garanta que o diretório exista
            if (!Directory.Exists(nomePasta))
            {
                Directory.CreateDirectory(nomePasta);
            }

            // Crie o nome do arquivo específico para o item com base na hora do item sem a data
            string nomeArquivoItem = $"AIRK_vendakg_{dataVenda:HH.mm.ss}.json";

            // Caminho completo do arquivo específico para o item
            string caminhoArquivoItem = Path.Combine(nomePasta, nomeArquivoItem);

            // Adicione os dados do item à lista específica do item
            listaVendas.Add(dadosVendaItem);

            // Converta a lista específica do item para uma string JSON
            string jsonDataItem = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

            // Salve os dados no arquivo específico para o item
            File.WriteAllText(caminhoArquivoItem, jsonDataItem);

            // Crie o nome do arquivo para as vendas gerais
            string nomeArquivoGeral = $"AIRK_VENDAS-GERAL{dataVenda:yyyy-MM-dd}.json";

            // Crie o caminho completo para o arquivo das vendas gerais
            string caminhoArquivoGeral = Path.Combine(nomePasta, nomeArquivoGeral);

            // Se o arquivo já existir, leia o conteúdo atual
            if (File.Exists(caminhoArquivoGeral))
            {
                // Deserializar o conteúdo atual para uma lista
                var dadosVendasGeral = JsonConvert.DeserializeObject<List<object>>(File.ReadAllText(caminhoArquivoGeral));

                // Adicione os dados do item à lista geral
                dadosVendasGeral.Add(dadosVendaItem);

                // Converta a lista geral para uma string JSON
                string jsonDataGeral = JsonConvert.SerializeObject(dadosVendasGeral, Formatting.Indented);

                // Salve todos os dados no arquivo das vendas gerais
                File.WriteAllText(caminhoArquivoGeral, jsonDataGeral);
            }
            else
            {
                // Se o arquivo não existir, crie e salve os dados do item
                var dadosVendasGeral = new List<object> { dadosVendaItem };
                string jsonDataGeral = JsonConvert.SerializeObject(dadosVendasGeral, Formatting.Indented);
                File.WriteAllText(caminhoArquivoGeral, jsonDataGeral);
            }
        }

        private string ObterFormaPagamentoSelecionada()
        {
            if (radioPix.Checked)
            {
                return "PIX";
            }
            else if (radioDinheiro.Checked)
            {
                return "Dinheiro";
            }
            else if (radioDebito.Checked)
            {
                return "Débito";
            }
            else if (radioCredito.Checked)
            {
                return "Crédito";
            }
            else
            {
                return "Outro"; // Pode definir um valor padrão ou tratar conforme sua necessidade
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            // Atualize o Label com a hora e a data em tempo real
            labelDataHora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void VerificarHabilitacaoBtnFinalizar()
        {
            // Verifique se todos os campos têm valores não nulos e maiores que zero
            bool valorMaterialPreenchido = !string.IsNullOrEmpty(txtValorMaterial.Text) && decimal.TryParse(txtValorMaterial.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal valorMaterial) && valorMaterial > 0;
            bool nomeMaterialPreenchido = !string.IsNullOrEmpty(txtNomeMaterial.Text);
            bool quantidadePreenchida = !string.IsNullOrEmpty(txtPeso.Text) && decimal.TryParse(txtPeso.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("pt-BR"), out decimal quantidade) && quantidade > 0;

            // Verifique se algum dos botões de opção (radios) está selecionado
            bool radioSelecionado = radioPix.Checked || radioDinheiro.Checked || radioDebito.Checked || radioCredito.Checked;

            // Habilitar o botão se todos os campos estiverem preenchidos corretamente e algum rádio estiver selecionado
            btnFinalizarCompra.Enabled = valorMaterialPreenchido && nomeMaterialPreenchido && quantidadePreenchida && radioSelecionado;
        }



        private void txtValorMaterial_TextChanged(object sender, EventArgs e)
        {
            VerificarHabilitacaoBtnFinalizar();
        }

        private void txtNomeMaterial_TextChanged(object sender, EventArgs e)
        {
            VerificarHabilitacaoBtnFinalizar();
        }

        private void radioPix_CheckedChanged(object sender, EventArgs e)
        {
            VerificarHabilitacaoBtnFinalizar();
        }

        private void radioDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            VerificarHabilitacaoBtnFinalizar();
        }

        private void radioDebito_CheckedChanged(object sender, EventArgs e)
        {
            VerificarHabilitacaoBtnFinalizar();
        }

        private void radioCredito_CheckedChanged(object sender, EventArgs e)
        {
            VerificarHabilitacaoBtnFinalizar();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            // Remova qualquer caractere que não seja um dígito ou vírgula
            string input = new string(txtPeso.Text.Where(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());

            // Se houver mais de uma vírgula ou ponto, remova os extras
            if (input.Count(ch => ch == ',' || ch == '.') > 1)
            {
                int lastCommaIndex = input.LastIndexOf(',');
                int lastDotIndex = input.LastIndexOf('.');

                if (lastCommaIndex > lastDotIndex)
                {
                    // Se a última vírgula aparecer depois do último ponto, remova o ponto
                    input = input.Remove(lastDotIndex, 1);
                }
                else
                {
                    // Caso contrário, remova a vírgula
                    input = input.Remove(lastCommaIndex, 1);
                }
            }

            // Substitua ',' por '.' para garantir que o valor seja interpretado corretamente como decimal
            input = input.Replace('.', ',');

            // Atualize o texto em txtPeso com o valor formatado
            txtPeso.Text = input;

            // Coloque o cursor no final do texto para facilitar a edição contínua
            txtPeso.SelectionStart = txtPeso.Text.Length;

            // Chame o método CalcularValorTotal()
            decimal valorTotal = CalcularValorTotal();

            // Atualize o labelValorTotal no formato "R$ 0,00"
            labelValorTotal.Text = valorTotal.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

            // Verifique a habilitação do botão Finalizar
            VerificarHabilitacaoBtnFinalizar();
        }

        private void txtPeso_Click(object sender, EventArgs e)
        {
            txtPeso.Select(0, 0);
        }

        private void txtNomeMaterial_TextChanged_1(object sender, EventArgs e)
        {
            // Verifique a habilitação do botão Finalizar
            VerificarHabilitacaoBtnFinalizar();
        }
    }
}

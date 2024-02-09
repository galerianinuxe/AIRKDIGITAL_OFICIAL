using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Drawing.Printing;






namespace airksucata
{
    public partial class formRelatorios : Form
    {
        public formRelatorios()
        {
            InitializeComponent();
            PreencherComboBoxMateriais();
            listaMateriais.SelectedItem = "TUDO"; // Seleciona a opção "TUDO" por padrão
            PreencherListaComprovante();
        }

        private void PreencherComboBoxMateriais()
        {
            try
            {
                string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT nome FROM materiais";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string materialNome = reader["nome"].ToString();
                                listaMateriais.Items.Add(materialNome);
                            }
                        }
                    }
                }
                listaMateriais.Items.Add("TUDO");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao preencher a ComboBox de materiais: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencherListaComprovante()
        {
            listViewResultado.View = View.Details;
            listViewResultado.Columns.Add("ID", 80);
            listViewResultado.Columns.Add("Material", 220);
            listViewResultado.Columns.Add("R$ Valor KG", 80);
            listViewResultado.Columns.Add("Peso", 110);
            listViewResultado.Columns.Add("Total R$", 130);
            listViewResultado.Columns.Add("Data", 190);
        }

        private void ListaMateriais_DropDown(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            // Defina manualmente a altura do menu suspenso
            int totalItems = comboBox.Items.Count;
            int maxHeight = 900; // ou qualquer outro valor desejado

            int suggestedHeight = comboBox.ItemHeight * Math.Min(totalItems, comboBox.MaxDropDownItems);
            comboBox.DropDownHeight = Math.Min(maxHeight, suggestedHeight);
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            listViewResultado.Items.Clear();

            string materialSelecionado = listaMateriais.SelectedItem as string;

            string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "";
                    MySqlCommand command = new MySqlCommand();

                    query = "SELECT id_registro, materialNome, materialValor, inputValor, totalPagar, DATE_FORMAT(dataHoraAtual, '%Y-%m-%d %H:%i:%s') AS dataFormatada FROM pedidos_impressos WHERE 1=1";

                    if (materialSelecionado != "TUDO")
                    {
                        query += " AND materialNome = @materialNome";
                        command.Parameters.AddWithValue("@materialNome", materialSelecionado);
                    }

                    DateTime dataInicial;
                    DateTime dataFinal;

                    if (radio24h.Checked)
                    {
                        dataInicial = DateTime.Now.AddHours(-24);
                        dataFinal = DateTime.Now;
                    }
                    else if (radio7d.Checked)
                    {
                        dataInicial = DateTime.Now.AddDays(-7);
                        dataFinal = DateTime.Now;
                    }
                    else if (radio30d.Checked)
                    {
                        dataInicial = DateTime.Now.AddDays(-30);
                        dataFinal = DateTime.Now;
                    }
                    else if (radio3d.Checked)
                    {
                        dataInicial = DateTime.Now.AddDays(-3);
                        dataFinal = DateTime.Now;
                    }
                    else
                    {
                        // Se nenhum período selecionado, use um padrão (por exemplo, os últimos 30 dias)
                        dataInicial = DateTime.Now.AddDays(-30);
                        dataFinal = DateTime.Now;
                    }

                    query += " AND dataHoraAtual >= @dataInicial AND dataHoraAtual <= @dataFinal";
                    command.Parameters.AddWithValue("@dataInicial", dataInicial);
                    command.Parameters.AddWithValue("@dataFinal", dataFinal);

                    query += " ORDER BY dataHoraAtual DESC";

                    command.Connection = connection;
                    command.CommandText = query;

                    double pesoTotal = 0.0;
                    double totalCompra = 0.0;

                    Dictionary<string, double> pesoMaterial = new Dictionary<string, double>(); // Dicionário para armazenar os pesos por material

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["id_registro"].ToString());
                            item.SubItems.Add(reader["materialNome"].ToString());
                            item.SubItems.Add(reader["materialValor"].ToString());
                            item.SubItems.Add(reader["inputValor"].ToString());
                            item.SubItems.Add(reader["totalPagar"].ToString());
                            item.SubItems.Add(reader["dataFormatada"].ToString());

                            listViewResultado.Items.Add(item);

                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                subItem.BackColor = Color.White;
                                subItem.ForeColor = Color.Black;
                                subItem.Font = new Font("Nexa", 13, FontStyle.Regular);
                            }

                            double pesoItem = double.Parse(item.SubItems[3].Text);
                            double totalItem = double.Parse(item.SubItems[4].Text);

                            pesoTotal += pesoItem;
                            totalCompra += totalItem;

                            // Verificar se o material já está no dicionário e atualizar o peso
                            if (pesoMaterial.ContainsKey(reader["materialNome"].ToString()))
                            {
                                pesoMaterial[reader["materialNome"].ToString()] += pesoItem;
                            }
                            else
                            {
                                pesoMaterial[reader["materialNome"].ToString()] = pesoItem;
                            }
                        }
                    }

                    // Encontrar o material com o maior peso total
                    string materialMaisComprado = "";
                    double pesoMaisComprado = 0.0;

                    foreach (var kvp in pesoMaterial)
                    {
                        if (kvp.Value > pesoMaisComprado)
                        {
                            materialMaisComprado = kvp.Key;
                            pesoMaisComprado = kvp.Value;
                        }
                    }

                    lbTotalPeso.Text = pesoTotal.ToString("N3") + " kg";
                    lbTotalCompra.Text = "R$ " + totalCompra.ToString("N2");
                    lbMaisComprado.Text = materialMaisComprado;

                    // Calcular a soma total do peso do material mais comprado dentro do período
                    double somaTotalPesoMaterialMaisComprado = CalcularSomaTotalPesoMaterialMaisComprado(connection, materialMaisComprado, dataInicial, dataFinal);
                    lbTotalPesoMaterialMaisComprado.Text = somaTotalPesoMaterialMaisComprado.ToString("N3") + " kg";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao executar a consulta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // Após adicionar itens ao listViewResultado
            AtualizarEstadoBtnImprimir();
        }
        // Método para atualizar o estado do botão
        private void AtualizarEstadoBtnImprimir()
        {
            btnImprimir.Enabled = listViewResultado.Items.Count > 0;
        }
        private double CalcularSomaTotalPesoMaterialMaisComprado(MySqlConnection connection, string materialMaisComprado, DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                string query = "SELECT SUM(inputValor) AS somaTotalPeso FROM pedidos_impressos WHERE materialNome = @materialNome AND dataHoraAtual >= @dataInicial AND dataHoraAtual <= @dataFinal";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@materialNome", materialMaisComprado);
                command.Parameters.AddWithValue("@dataInicial", dataInicial);
                command.Parameters.AddWithValue("@dataFinal", dataFinal);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToDouble(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao calcular a soma total do peso do material mais comprado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0.0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            GerarExcel();
        }

        private void GerarExcel()
        {
            string caminhoArquivo = string.Empty;

            if (listViewResultado.Items.Count > 0)
            {
                try
                {
                    // Obter a data do primeiro e último item da lista
                    DateTime dataPrimeiroItem = DateTime.ParseExact(listViewResultado.Items[0].SubItems[5].Text, "yyyy-MM-dd HH:mm:ss", null);
                    DateTime dataUltimoItem = DateTime.ParseExact(listViewResultado.Items[listViewResultado.Items.Count - 1].SubItems[5].Text, "yyyy-MM-dd HH:mm:ss", null);

                    // Construir o nome do arquivo Excel
                    caminhoArquivo = Path.Combine("relatoriosCompra", $"AIRK_{dataUltimoItem:dd-MMMM-yyyy_HHmm}_ATÉ_{dataPrimeiroItem:dd-MMMM-yyyy_HHmm}.xlsx");

                    // Criar o diretório se não existir
                    Directory.CreateDirectory("relatoriosCompra");

                    // Inicializar o workbook do ClosedXML
                    using (var workbook = new XLWorkbook())
                    {
                        // Adicionar uma planilha ao workbook
                        var worksheet = workbook.Worksheets.Add("RelatoriosCompra");

                        // Adicionar cabeçalhos
                        for (int col = 1; col <= listViewResultado.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col).Value = listViewResultado.Columns[col - 1].Text;
                            worksheet.Cell(1, col).Style.Fill.BackgroundColor = XLColor.Gray;
                            worksheet.Cell(1, col).Style.Font.Bold = true;
                        }

                        // Preencher os dados
                        for (int row = 0; row < listViewResultado.Items.Count; row++)
                        {
                            var item = listViewResultado.Items[row];
                            for (int col = 1; col <= listViewResultado.Columns.Count; col++)
                            {
                                worksheet.Cell(row + 2, col).Value = item.SubItems[col - 1].Text;
                            }
                        }

                        // Adicionar informações adicionais no final
                        int lastRow = listViewResultado.Items.Count + 4; // Ajuste para espaço entre dados e informações adicionais

                        worksheet.Cell(lastRow, 1).Value = "Total em Compra:";
                        worksheet.Cell(lastRow, 2).Value = lbTotalCompra.Text;
                        worksheet.Cell(lastRow + 1, 1).Value = "Peso Total (kg):";
                        worksheet.Cell(lastRow + 1, 2).Value = lbTotalPeso.Text;
                        worksheet.Cell(lastRow + 2, 1).Value = "Material Mais Comprado:";
                        worksheet.Cell(lastRow + 2, 2).Value = lbMaisComprado.Text;
                        worksheet.Cell(lastRow + 3, 1).Value = "Peso Total do Material Mais Comprado:";
                        worksheet.Cell(lastRow + 3, 2).Value = lbTotalPesoMaterialMaisComprado.Text;

                        // Formatar células como "Texto"
                        worksheet.Range(lastRow, 2, lastRow + 3, 2).Style.NumberFormat.Format = "@";

                        // Salvar o workbook
                        workbook.SaveAs(caminhoArquivo);

                        MessageBox.Show($"Relatório salvo em {caminhoArquivo}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao gerar o relatório: {ex.Message}\nStackTrace: {ex.StackTrace}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nenhum item na lista para gerar um relatório.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAbrirDestino_Click(object sender, EventArgs e)
        {
            try
            {
                // Caminho da pasta relatoriosCompra
                string caminhoPasta = Path.Combine(Application.StartupPath, "relatoriosCompra");

                // Verificar se a pasta existe
                if (Directory.Exists(caminhoPasta))
                {
                    // Abrir o explorador de arquivos na pasta relatoriosCompra
                    Process.Start("explorer.exe", caminhoPasta);
                }
                else
                {
                    MessageBox.Show("A pasta relatoriosCompra não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o explorador de arquivos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirRelat_Click(object sender, EventArgs e)
        {
            // Lógica para impressão do relatório
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirRelatorioCompra);
            pd.Print();
        }

        private void ImprimirRelatorioCompra(object sender, PrintPageEventArgs e)
        {
            // Configurações de impressão
            int linhaAtual = 2; // Margem top de 2px
            int margemInterna = 2; // Margem interna de 2px
            int alturaLinha = 10; // Altura de cada linha
            Font fonteCabecalho = new Font("Arial", 13, FontStyle.Bold);
            Font fonteTexto = new Font("Arial", 7);
            Font fonteDados = new Font("Arial", 11, FontStyle.Bold);

            // Adicione o caminho para a imagem
            string caminhoImagem = "logoRelatorio.png"; // Substitua pelo caminho real da sua imagem
            Image imagem = Image.FromFile(caminhoImagem);

            // Cabeçalho
            string cabecalho = "Relatório de Compra Geral";
            string periodoInicio = $"Até: {listViewResultado.Items[0].SubItems[5].Text}";
            string periodoFim = $"De: {listViewResultado.Items[listViewResultado.Items.Count - 1].SubItems[5].Text}";
            string cabecalhoCompleto = $"{cabecalho}\n\n{periodoFim}\n{periodoInicio}\n";


            StringFormat formatoCentralizado = new StringFormat();
            formatoCentralizado.Alignment = StringAlignment.Center;
            formatoCentralizado.LineAlignment = StringAlignment.Center;

            SizeF tamanhoCabecalho = e.Graphics.MeasureString(cabecalhoCompleto, fonteCabecalho);

            // Desenhar a imagem no topo centralizado
            int posicaoXImagem = (e.PageBounds.Width - 100) / 2; // Posição X centralizada
            e.Graphics.DrawImage(imagem, posicaoXImagem, linhaAtual, 100, 100);

            linhaAtual += 100 + margemInterna; // Altura da imagem mais a margem interna
            e.Graphics.DrawString(cabecalhoCompleto, fonteCabecalho, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, (int)tamanhoCabecalho.Height), formatoCentralizado);
            linhaAtual += (int)tamanhoCabecalho.Height + margemInterna; // Pular duas linhas após o cabeçalho

            // Larguras específicas das colunas
            int[] largurasColunas = { 20, 60, 45, 45, 40, 60 }; // Ajuste conforme necessário

            // Imprimir cabeçalhos de coluna
            int colunaAtual = margemInterna;
            for (int i = 0; i < listViewResultado.Columns.Count; i++)
            {
                // Ajuste para quebra de texto nas colunas
                var tamanhoColuna = e.Graphics.MeasureString(listViewResultado.Columns[i].Text, fonteTexto);
                e.Graphics.DrawString(listViewResultado.Columns[i].Text, fonteTexto, Brushes.Black, new Rectangle(colunaAtual, linhaAtual, largurasColunas[i], (int)tamanhoColuna.Height));
                colunaAtual += largurasColunas[i];
            }


            linhaAtual += (int)e.Graphics.MeasureString("X", fonteTexto).Height + margemInterna; // Pular uma linha após os cabeçalhos

            // Imprimir dados da lista
            foreach (ListViewItem item in listViewResultado.Items)
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
            string textoTotalCompra = $"Compra Total: {lbTotalCompra.Text}\n";
            string textoTotalPeso = $"Peso: {lbTotalPeso.Text}\n\n";
            string textoMaisComprado = $"+ Comprado: {lbMaisComprado.Text}\n";
            string textoTotalPesoMaisComprado = $"Peso + Comprado: {lbTotalPesoMaterialMaisComprado.Text}\n\n";

            // Ajuste de posição vertical
            int alturaTextoAdicional = (int)e.Graphics.MeasureString("X", fonteDados).Height + margemInterna;

            e.Graphics.DrawString(textoTotalCompra, fonteDados, Brushes.Black, new Point(margemInterna, linhaAtual));
            linhaAtual += alturaTextoAdicional;

            e.Graphics.DrawString(textoTotalPeso, fonteDados, Brushes.Black, new Point(margemInterna, linhaAtual));
            linhaAtual += alturaTextoAdicional;

            e.Graphics.DrawString(textoMaisComprado, fonteDados, Brushes.Black, new Point(margemInterna, linhaAtual));
            linhaAtual += alturaTextoAdicional;

            e.Graphics.DrawString(textoTotalPesoMaisComprado, fonteDados, Brushes.Black, new Point(margemInterna, linhaAtual));
            linhaAtual += alturaTextoAdicional;

            // Imprimir textos adicionais
            linhaAtual += margemInterna;
            string textoAdicional1 = "Sistema Desenvolvido por AIRK DIGITAL";
            string textoAdicional2 = "Atendimento WhatsApp: (11)96351-2105";
            e.Graphics.DrawString(textoAdicional1, fonteTexto, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, fonteTexto.Height), formatoCentralizado);
            linhaAtual += (int)fonteTexto.Height;

            e.Graphics.DrawString(textoAdicional2, fonteTexto, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, fonteTexto.Height), formatoCentralizado);
        }


    }
}

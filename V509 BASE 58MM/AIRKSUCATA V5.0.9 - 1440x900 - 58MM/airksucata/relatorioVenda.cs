using ClosedXML.Excel;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Drawing.Printing;
using System.Globalization;

namespace airksucata
{
    public partial class relatorioVenda : Form
    {
        // Declare a variável no nível da classe
        private List<string> pastasFiltradas = new List<string>();

        public relatorioVenda()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close(); // FECHAR FORM ATUAL
        }

        private void btnConsultarPeso_Click(object sender, EventArgs e)
        {
            // Obtém a data selecionada no dateTimePicker
            DateTime dataConsulta = dateTimePickerPeso.Value.Date;

            // Chama o método para realizar a consulta
            ConsultarPorData(dataConsulta);

            // Exibir os resultados no ListView
            ExibirResultadosNoListView();

            ConsultarPorData2(dataConsulta);
            ExibirResultadosNoListView2();
        }

        private void ConsultarPorData(DateTime dataConsulta)
        {
            // Limpa a lista antes de uma nova consulta
            pastasFiltradas.Clear();

            // Caminho base onde os relatórios estão salvos
            string baseDir = "relatorioVendaPorKg";

            // Verifica todas as pastas na baseDir
            foreach (var subDir in Directory.GetDirectories(baseDir))
            {
                // Obtém a data da pasta
                if (DateTime.TryParseExact(Path.GetFileName(subDir), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dataPasta))
                {
                    // Se a data da pasta corresponder à data de consulta, adiciona à lista
                    if (dataPasta.Date == dataConsulta)
                    {
                        pastasFiltradas.Add(subDir);
                    }
                }
            }
        }
        private void ConsultarPorData2(DateTime dataConsulta)
        {
            // Limpa a lista antes de uma nova consulta
            pastasFiltradas.Clear();

            // Caminho base onde os relatórios estão salvos
            string baseDir = "relatorioVendaPorUnid";

            // Verifica todas as pastas na baseDir
            foreach (var subDir in Directory.GetDirectories(baseDir))
            {
                // Obtém a data da pasta
                if (DateTime.TryParseExact(Path.GetFileName(subDir), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dataPasta))
                {
                    // Se a data da pasta corresponder à data de consulta, adiciona à lista
                    if (dataPasta.Date == dataConsulta)
                    {
                        pastasFiltradas.Add(subDir);
                    }
                }
            }
        }

        //AQUI É O SOBRE A CONSULTA POR UNIDADE
        private void ExibirResultadosNoListView2()
        {
            // Limpe os itens existentes no ListView
            listViewResultadoUnid.Items.Clear();

            // Adicione as pastas ao ListView
            foreach (string pasta in pastasFiltradas)
            {
                // Obtenha o nome do arquivo "AIRK_VENDAS-GERAL" dentro da pasta
                string caminhoArquivoGeral2 = Directory.GetFiles(pasta, "AIRK_VENDAS-GERAL*.json").FirstOrDefault();

                // Verifica se o arquivo existe
                if (File.Exists(caminhoArquivoGeral2))
                {
                    // Lê o conteúdo do arquivo
                    string conteudoArquivo = File.ReadAllText(caminhoArquivoGeral2);

                    // Desserializa o conteúdo do arquivo para uma lista de objetos
                    List<VendaGeral2> dadosVendas2 = JsonConvert.DeserializeObject<List<VendaGeral2>>(conteudoArquivo);

                    // Ordena os dados por data de venda (do mais recente para o mais antigo)
                    dadosVendas2 = dadosVendas2.OrderByDescending(v => v.DataVenda).ToList();

                    // Configura as colunas da ListView
                    listViewResultadoUnid.Columns.Clear();
                    listViewResultadoUnid.Columns.Add("Produto", 85);
                    listViewResultadoUnid.Columns.Add("R$ Unit", 70);
                    listViewResultadoUnid.Columns.Add("Total", 80);
                    listViewResultadoUnid.Columns.Add("Pgto", 60);
                    listViewResultadoUnid.Columns.Add("Quant", 60);
                    listViewResultadoUnid.Columns.Add("Data", 118);

                    // Adiciona os itens ao ListView
                    foreach (VendaGeral2 venda in dadosVendas2)
                    {
                        // Adiciona os dados ao ListView
                        ListViewItem item = new ListViewItem(new[] {
                    venda.Produto,
                    venda.ValorUnit,
                    venda.ValorVenda,
                    venda.FormaPagamento,
                    venda.Peso,
                    venda.DataVenda.ToString()
                });

                        // Adiciona o item ao ListView
                        listViewResultadoUnid.Items.Add(item);
                    }
                    // Após preencher o listViewResultadoUnid, calcule a soma dos valores na coluna "ValorVenda"
                    CalcularSomarValorVenda();
                    CalcularSomarQuant();
                }
            }
        }
        private void CalcularSomarValorVenda()
        {
            // Inicializa a variável para armazenar a soma
            decimal somaValorVenda = 0;

            // Itera sobre os itens no listViewResultadoUnid
            foreach (ListViewItem item in listViewResultadoUnid.Items)
            {
                // Obtém o valor na coluna "ValorVenda"
                string valorVendaStr = item.SubItems[2].Text; // 2 representa a coluna "ValorVenda"

                // Converte o valor para decimal e adiciona à soma
                if (decimal.TryParse(valorVendaStr.Replace("R$ ", ""), out decimal valorVenda))
                {
                    somaValorVenda += valorVenda;
                }
            }

            // Exibe a soma na label lbValorTotalUnit
            lbValorTotalUnit.Text = $"R$ {somaValorVenda.ToString("N2", new CultureInfo("pt-BR"))}";
        }


        private void CalcularSomarValorVenda2()
        {
            // Inicializa a variável para armazenar a soma
            decimal somaValorVenda = 0;

            // Itera sobre os itens no listViewResultadoPeso
            foreach (ListViewItem item in listViewResultadoPeso.Items)
            {
                // Obtém o valor na coluna "ValorVenda"
                string valorVendaStr = item.SubItems[2].Text; // 2 representa a coluna "ValorVenda"

                // Converte o valor para decimal e adiciona à soma
                if (decimal.TryParse(valorVendaStr.Replace("R$ ", ""), out decimal valorVenda))
                {
                    somaValorVenda += valorVenda;
                }
            }

            // Exibe a soma na label lbValorTotalUnit
            lbValorTotalKg.Text = $"R$ {somaValorVenda.ToString("N2", new CultureInfo("pt-BR"))}";
        }

        private void CalcularSomarQuant()
        {
            // Inicializa a variável para armazenar a soma
            decimal somaPeso = 0;

            // Itera sobre os itens no listViewResultadoUnid
            foreach (ListViewItem item in listViewResultadoUnid.Items)
            {
                // Obtém o valor na coluna "Peso"
                string quantStr = item.SubItems[4].Text; // 4 representa a coluna "Peso"

                // Remove "kg" e substitui vírgulas por pontos, para facilitar a conversão
                quantStr = quantStr.Replace("kg", "").Replace(",", ".");

                // Converte o valor para decimal e adiciona à soma
                if (decimal.TryParse(quantStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal quant))
                {
                    somaPeso += quant;
                }
            }

            // Exibe a soma na label lbValorTotalUnit
            lbQuantidade.Text = $"{somaPeso.ToString("N2", new CultureInfo("pt-BR"))}";
        }


        // Classe para representar a estrutura dos objetos no arquivo
        private class VendaGeral2
        {
            public string Produto { get; set; }
            public string ValorUnit { get; set; }
            public string ValorVenda { get; set; }
            public string FormaPagamento { get; set; }
            public string Peso { get; set; }
            public DateTime DataVenda { get; set; }
        }
        //============================================================
        //AQUI É O SOBRE A CONSULTA POR PESO
        private void ExibirResultadosNoListView()
        {
            // Limpe os itens existentes no ListView
            listViewResultadoPeso.Items.Clear();

            // Adicione as pastas ao ListView
            foreach (string pasta in pastasFiltradas)
            {
                // Obtenha o nome do arquivo "AIRK_VENDAS-GERAL" dentro da pasta
                string caminhoArquivoGeral = Directory.GetFiles(pasta, "AIRK_VENDAS-GERAL*.json").FirstOrDefault();

                // Verifica se o arquivo existe
                if (File.Exists(caminhoArquivoGeral))
                {
                    // Lê o conteúdo do arquivo
                    string conteudoArquivo = File.ReadAllText(caminhoArquivoGeral);

                    // Desserializa o conteúdo do arquivo para uma lista de objetos
                    List<VendaGeral> dadosVendas = JsonConvert.DeserializeObject<List<VendaGeral>>(conteudoArquivo);

                    // Ordena os dados por data de venda (do mais recente para o mais antigo)
                    dadosVendas = dadosVendas.OrderByDescending(v => v.DataVenda).ToList();

                    // Configura as colunas da ListView
                    listViewResultadoPeso.Columns.Clear();
                    listViewResultadoPeso.Columns.Add("Produto", 85);
                    listViewResultadoPeso.Columns.Add("Valor KG", 70);
                    listViewResultadoPeso.Columns.Add("Total", 80);
                    listViewResultadoPeso.Columns.Add("Pgto", 60);
                    listViewResultadoPeso.Columns.Add("Peso KG", 70);
                    listViewResultadoPeso.Columns.Add("Data", 118);

                    // Adiciona os itens ao ListView
                    foreach (VendaGeral venda in dadosVendas)
                    {
                        // Adiciona os dados ao ListView
                        ListViewItem item = new ListViewItem(new[] {
                    venda.Produto,
                    venda.ValorKg,
                    venda.ValorVenda,
                    venda.FormaPagamento,
                    venda.Peso,
                    venda.DataVenda.ToString()
                });

                        // Adiciona o item ao ListView
                        listViewResultadoPeso.Items.Add(item);
                    }
                    // Após preencher o listViewResultadoUnid, calcule a soma dos valores na coluna "ValorVenda"
                    CalcularSomarValorVenda2();
                    CalcularSomarPesoTotal();


                }
            }
        }
        private void CalcularSomarPesoTotal()
        {
            // Inicializa a variável para armazenar a soma
            decimal somaPesoTotal = 0;

            // Itera sobre os itens no listViewResultadoPeso
            foreach (ListViewItem item in listViewResultadoPeso.Items)
            {
                // Obtém o valor na coluna "Peso KG"
                string pesoStr = item.SubItems[4].Text; // 4 representa a coluna "Peso KG"

                // Remove "kg" e substitui vírgulas por pontos, para facilitar a conversão
                pesoStr = pesoStr.Replace("kg", "").Replace(",", ".");

                // Converte o valor para decimal e adiciona à soma
                if (decimal.TryParse(pesoStr, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal peso))
                {
                    somaPesoTotal += peso;
                }
            }

            // Exibe a soma na label lbPesoTotal
            lbPesoTotal.Text = $"{somaPesoTotal.ToString("N3", new CultureInfo("pt-BR"))} kg";
        }


        // Classe para representar a estrutura dos objetos no arquivo
        private class VendaGeral
        {
            public string Produto { get; set; }
            public string ValorKg { get; set; }
            public string ValorVenda { get; set; }
            public string FormaPagamento { get; set; }
            public string Peso { get; set; }
            public DateTime DataVenda { get; set; }
        }



        private void btn3d_Click(object sender, EventArgs e)
        {
            ConsultarVendasPorData(3);
        }

        private void btn7d_Click(object sender, EventArgs e)
        {
            ConsultarVendasPorData(7);
        }

        private void btn30d_Click(object sender, EventArgs e)
        {
            ConsultarVendasPorData(30);
        }

        private void btn60d_Click(object sender, EventArgs e)
        {
            ConsultarVendasPorData(60);
        }

        private void ConsultarVendasPorData(int numeroDias)
        {
            // Obtém a data atual
            DateTime dataAtual = DateTime.Now;

            // Calcula a data de início com base no número de dias
            DateTime dataInicio = dataAtual.AddDays(-numeroDias);

            // Chama o método para realizar a consulta nas duas pastas
            ConsultarPorDataEExibirResultados(dataInicio, "relatorioVendaPorUnid", listViewResultadoUnid);
            ConsultarPorDataEExibirResultadosUnid(dataInicio, "relatorioVendaPorKg", listViewResultadoPeso);
            CalcularSomarValorVenda2();
            CalcularSomarPesoTotal();
        }

        private void ConsultarPorDataEExibirResultados(DateTime dataConsulta, string nomePasta, ListView listView)
        {
            // Limpa a lista antes de uma nova consulta
            pastasFiltradas.Clear();

            // Caminho base onde os relatórios estão salvos
            string baseDir = nomePasta;

            // Verifica se a pasta base existe
            if (Directory.Exists(baseDir))
            {
                // Verifica todas as pastas na baseDir
                foreach (var subDir in Directory.GetDirectories(baseDir))
                {
                    // Obtém a data da pasta
                    if (DateTime.TryParseExact(Path.GetFileName(subDir), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dataPasta))
                    {
                        // Se a data da pasta estiver no intervalo da consulta, adiciona à lista
                        if (dataPasta.Date >= dataConsulta.Date)
                        {
                            pastasFiltradas.Add(subDir);
                        }
                    }
                }

                // Exibe os resultados na ListView
                ExibirResultadosNoListView2();
            }
        }
        private void ConsultarPorDataEExibirResultadosUnid(DateTime dataConsulta, string nomePasta, ListView listView)
        {
            // Limpa a lista antes de uma nova consulta
            pastasFiltradas.Clear();

            // Caminho base onde os relatórios estão salvos
            string baseDir = nomePasta;

            // Verifica se a pasta base existe
            if (Directory.Exists(baseDir))
            {
                // Verifica todas as pastas na baseDir
                foreach (var subDir in Directory.GetDirectories(baseDir))
                {
                    // Obtém a data da pasta
                    if (DateTime.TryParseExact(Path.GetFileName(subDir), "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime dataPasta))
                    {
                        // Se a data da pasta estiver no intervalo da consulta, adiciona à lista
                        if (dataPasta.Date >= dataConsulta.Date)
                        {
                            pastasFiltradas.Add(subDir);
                        }
                    }
                }

                // Exibe os resultados na ListView
                ExibirResultadosNoListViewUnid(listView);
            }
        }

        private void ExibirResultadosNoListViewUnid(ListView listViewUnid)
        {
            // Limpe os itens existentes no ListView
            listViewUnid.Items.Clear();

            // Adicione as pastas ao ListView
            foreach (string pasta in pastasFiltradas)
            {
                // Obtenha o nome do arquivo "AIRK_VENDAS-GERAL" dentro da pasta
                string caminhoArquivoGeral = Directory.GetFiles(pasta, "AIRK_VENDAS-GERAL*.json").FirstOrDefault();

                // Verifica se o arquivo existe
                if (File.Exists(caminhoArquivoGeral))
                {
                    // Lê o conteúdo do arquivo
                    string conteudoArquivo = File.ReadAllText(caminhoArquivoGeral);

                    // Desserializa o conteúdo do arquivo para uma lista de objetos
                    List<VendaGeral> dadosVendas = JsonConvert.DeserializeObject<List<VendaGeral>>(conteudoArquivo);

                    // Ordena os dados por data de venda (do mais recente para o mais antigo)
                    dadosVendas = dadosVendas.OrderByDescending(v => v.DataVenda).ToList();

                    // Configura as colunas da ListView
                    ConfigurarColunasListViewUnid(listViewUnid);

                    // Adiciona os itens ao ListView
                    foreach (VendaGeral venda in dadosVendas)
                    {
                        // Adiciona os dados ao ListView
                        ListViewItem item = new ListViewItem(new[] {
                    venda.Produto,
                    venda.ValorKg,
                    venda.ValorVenda,
                    venda.FormaPagamento,
                    venda.Peso,
                    venda.DataVenda.ToString()
                });

                        // Adiciona o item ao ListView
                        listViewUnid.Items.Add(item);
                    }
                }
            }
        }

        private void ConfigurarColunasListViewUnid(ListView listViewUnid)
        {
            // Limpa as colunas existentes no ListView
            listViewUnid.Columns.Clear();

            // Adiciona as colunas ao ListView
            listViewUnid.Columns.Add("Produto", 85);
            listViewUnid.Columns.Add("Valor Kg", 70);
            listViewUnid.Columns.Add("ValorVenda", 80);
            listViewUnid.Columns.Add("Pgto", 60);
            listViewUnid.Columns.Add("Peso", 70);
            listViewUnid.Columns.Add("Data", 118);

        }

        private void btnRelatorioUnit_Click(object sender, EventArgs e)
        {
            if (listViewResultadoUnid.Items.Count > 0)
            {
                try
                {
                    // Obter a data atual para criar um nome exclusivo para o arquivo Excel
                    string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string nomePasta = "relatoriodeVendaUnitaria";
                    string caminhoPasta = Path.Combine(Environment.CurrentDirectory, nomePasta);

                    // Verificar se a pasta existe; se não, criar a pasta
                    if (!Directory.Exists(caminhoPasta))
                    {
                        Directory.CreateDirectory(caminhoPasta);
                    }

                    string caminhoArquivo = Path.Combine(caminhoPasta, $"relatorioUnitario_{timestamp}.xlsx");

                    // Inicializar o workbook do ClosedXML.Excel
                    using (var workbook = new XLWorkbook())
                    {
                        // Adicionar uma planilha ao workbook
                        var worksheet = workbook.Worksheets.Add("RelatorioUnitario");

                        // Adicionar cabeçalhos
                        for (int col = 1; col <= listViewResultadoUnid.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col).Value = listViewResultadoUnid.Columns[col - 1].Text;
                            worksheet.Cell(1, col).Style.Fill.BackgroundColor = XLColor.Gray;
                            worksheet.Cell(1, col).Style.Font.Bold = true;
                        }

                        // Preencher os dados
                        for (int row = 0; row < listViewResultadoUnid.Items.Count; row++)
                        {
                            var item = listViewResultadoUnid.Items[row];
                            for (int col = 1; col <= listViewResultadoUnid.Columns.Count; col++)
                            {
                                worksheet.Cell(row + 2, col).Value = item.SubItems[col - 1].Text;
                            }
                        }

                        // Adicionar informações adicionais no final
                        int lastRow = listViewResultadoUnid.Items.Count + 4; // Ajuste para espaço entre dados e informações adicionais

                        worksheet.Cell(lastRow, 1).Value = "Total em Vendas:";
                        worksheet.Cell(lastRow, 2).Value = lbValorTotalUnit.Text;
                        worksheet.Cell(lastRow + 1, 1).Value = "Quantidade de Itens:";
                        worksheet.Cell(lastRow + 1, 2).Value = lbQuantidade.Text;

                        // Formatar células como "Texto"
                        worksheet.Range(lastRow, 2, lastRow + 1, 2).Style.NumberFormat.Format = "@";

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
                // Caminho da pasta relatoriodeVendaUnitaria
                string caminhoPasta = Path.Combine(Application.StartupPath, "relatoriodeVendaUnitaria");

                // Verificar se a pasta existe
                if (Directory.Exists(caminhoPasta))
                {
                    // Abrir o explorador de arquivos na pasta relatoriodeVendaUnitaria
                    Process.Start("explorer.exe", caminhoPasta);
                }
                else
                {
                    MessageBox.Show("A pasta relatoriodeVendaUnitaria não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o explorador de arquivos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRelatorioPeso_Click(object sender, EventArgs e)
        {
            if (listViewResultadoUnid.Items.Count > 0)
            {
                try
                {
                    // Obter a data atual para criar um nome exclusivo para o arquivo Excel
                    string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string nomePasta = "relatoriodeVendaPorPeso";
                    string caminhoPasta = Path.Combine(Environment.CurrentDirectory, nomePasta);

                    // Verificar se a pasta existe; se não, criar a pasta
                    if (!Directory.Exists(caminhoPasta))
                    {
                        Directory.CreateDirectory(caminhoPasta);
                    }

                    string caminhoArquivo = Path.Combine(caminhoPasta, $"relatorioPorPeso_{timestamp}.xlsx");

                    // Inicializar o workbook do ClosedXML.Excel
                    using (var workbook = new XLWorkbook())
                    {
                        // Adicionar uma planilha ao workbook
                        var worksheet = workbook.Worksheets.Add("RelatorioPorPeso");

                        // Adicionar cabeçalhos
                        for (int col = 1; col <= listViewResultadoPeso.Columns.Count; col++)
                        {
                            worksheet.Cell(1, col).Value = listViewResultadoPeso.Columns[col - 1].Text;
                            worksheet.Cell(1, col).Style.Fill.BackgroundColor = XLColor.Gray;
                            worksheet.Cell(1, col).Style.Font.Bold = true;
                        }

                        // Preencher os dados
                        for (int row = 0; row < listViewResultadoPeso.Items.Count; row++)
                        {
                            var item = listViewResultadoPeso.Items[row];
                            for (int col = 1; col <= listViewResultadoPeso.Columns.Count; col++)
                            {
                                worksheet.Cell(row + 2, col).Value = item.SubItems[col - 1].Text;
                            }
                        }

                        // Adicionar informações adicionais no final
                        int lastRow = listViewResultadoPeso.Items.Count + 4; // Ajuste para espaço entre dados e informações adicionais

                        worksheet.Cell(lastRow, 1).Value = "Total em Vendas:";
                        worksheet.Cell(lastRow, 2).Value = lbValorTotalKg.Text;
                        worksheet.Cell(lastRow + 1, 1).Value = "Peso Total:";
                        worksheet.Cell(lastRow + 1, 2).Value = lbPesoTotal.Text;

                        // Formatar células como "Texto"
                        worksheet.Range(lastRow, 2, lastRow + 1, 2).Style.NumberFormat.Format = "@";

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

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // Caminho da pasta relatoriodeVendaUnitaria
                string caminhoPasta = Path.Combine(Application.StartupPath, "relatoriodeVendaPorPeso");

                // Verificar se a pasta existe
                if (Directory.Exists(caminhoPasta))
                {
                    // Abrir o explorador de arquivos na pasta relatoriodeVendaUnitaria
                    Process.Start("explorer.exe", caminhoPasta);
                }
                else
                {
                    MessageBox.Show("A pasta relatoriodeVendaPorPeso não foi encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir o explorador de arquivos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimirUnitario_Click(object sender, EventArgs e)
        {
            if (listViewResultadoUnid.Items.Count > 0)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirRelatorioUnitario);
                pd.Print();
            }
            else
            {
                MessageBox.Show("Nenhum item na lista para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnImprimirPeso_Click(object sender, EventArgs e)
        {
            if (listViewResultadoPeso.Items.Count > 0)
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(ImprimirRelatorioPeso);
                pd.Print();
            }
            else
            {
                MessageBox.Show("Nenhum item na lista para imprimir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ImprimirRelatorioUnitario(object sender, PrintPageEventArgs e)
        {
            // Configurações de impressão
            int linhaAtual = 2; // Margem top de 2px
            int margemInterna = 2; // Margem interna de 2px
            int alturaLinha = 10; // Altura de cada linha
            Font fonteCabecalho = new Font("Arial", 13, FontStyle.Bold);
            Font fonteTexto = new Font("Arial", 7);
            Font fonteDados = new Font("Arial", 11, FontStyle.Bold);

            // Adicione o caminho para a imagem
            string caminhoImagem = "ecovidablack.png"; // Substitua pelo caminho real da sua imagem
            Image imagem = Image.FromFile(caminhoImagem);

            // Cabeçalho
            string cabecalho = "Relatório de Venda por Unidade";
            string periodoInicio = $"De: {listViewResultadoUnid.Items[0].SubItems[5].Text}";
            string periodoFim = $"Até: {listViewResultadoUnid.Items[listViewResultadoUnid.Items.Count - 1].SubItems[5].Text}\n";
            string cabecalhoCompleto = $"{cabecalho}\n\n{periodoInicio}\n{periodoFim}\n";

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
            int[] largurasColunas = { 65, 60, 65, 45, 50, 0 };

            // Imprimir cabeçalhos de coluna
            int colunaAtual = margemInterna;
            for (int i = 0; i < listViewResultadoUnid.Columns.Count; i++)
            {
                // Ajuste para quebra de texto nas colunas
                var tamanhoColuna = e.Graphics.MeasureString(listViewResultadoUnid.Columns[i].Text, fonteTexto);
                e.Graphics.DrawString(listViewResultadoUnid.Columns[i].Text, fonteTexto, Brushes.Black, new Rectangle(colunaAtual, linhaAtual, largurasColunas[i], (int)tamanhoColuna.Height));
                colunaAtual += largurasColunas[i];
            }

            linhaAtual += (int)e.Graphics.MeasureString("X", fonteTexto).Height + margemInterna; // Pular uma linha após os cabeçalhos

            // Imprimir dados da lista
            foreach (ListViewItem item in listViewResultadoUnid.Items)
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
            string textoTotalVendas = $"Total em Vendas: {lbValorTotalUnit.Text}\n";
            string textoQuantidade = $"Quantidade: {lbQuantidade.Text}\n";

            // Ajuste de posição vertical
            int alturaTextoAdicional = (int)e.Graphics.MeasureString("X", fonteDados).Height + margemInterna;

            e.Graphics.DrawString(textoTotalVendas, fonteDados, Brushes.Black, new Point(margemInterna, linhaAtual));
            linhaAtual += alturaTextoAdicional;

            e.Graphics.DrawString(textoQuantidade, fonteDados, Brushes.Black, new Point(margemInterna, linhaAtual));
            linhaAtual += alturaTextoAdicional;

            // Imprimir textos adicionais
            linhaAtual += margemInterna;
            Font fonteTextoAdicional = new Font("Arial", 7);
            string textoAdicional1 = "Sistema Original Desenvolvido por AIRK DIGITAL";
            string textoAdicional2 = "Atendimento Via WhatsApp: 11 96351-2105";
            e.Graphics.DrawString(textoAdicional1, fonteTextoAdicional, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, fonteTextoAdicional.Height), formatoCentralizado);
            linhaAtual += (int)fonteTextoAdicional.Height;

            e.Graphics.DrawString(textoAdicional2, fonteTextoAdicional, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, fonteTextoAdicional.Height), formatoCentralizado);


        }

        private void ImprimirRelatorioPeso(object sender, PrintPageEventArgs e)
        {
            // Configurações de impressão
            int linhaAtual = 2; // Margem top de 2px
            int margemInterna = 2; // Margem interna de 2px
            int alturaLinha = 10; // Altura de cada linha
            Font fonteCabecalho = new Font("Arial", 13, FontStyle.Bold);
            Font fonteTexto = new Font("Arial", 7);
            Font fonteDados = new Font("Arial", 11, FontStyle.Bold);

            // Adicione o caminho para a imagem
            string caminhoImagem = "ecovidablack.png"; // Substitua pelo caminho real da sua imagem
            Image imagem = Image.FromFile(caminhoImagem);

            // Cabeçalho
            string cabecalho = "Relatório de Venda por Peso";
            string periodoInicio = $"De: {listViewResultadoPeso.Items[0].SubItems[5].Text}";
            string periodoFim = $"Até: {listViewResultadoPeso.Items[listViewResultadoPeso.Items.Count - 1].SubItems[5].Text}\n";
            string cabecalhoCompleto = $"{cabecalho}\n\n{periodoInicio}\n{periodoFim}\n";

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
            int[] largurasColunas = { 65, 60, 65, 45, 50, 0 };

            // Imprimir cabeçalhos de coluna
            int colunaAtual = margemInterna;
            for (int i = 0; i < listViewResultadoPeso.Columns.Count; i++)
            {
                // Ajuste para quebra de texto nas colunas
                var tamanhoColuna = e.Graphics.MeasureString(listViewResultadoPeso.Columns[i].Text, fonteTexto);
                e.Graphics.DrawString(listViewResultadoPeso.Columns[i].Text, fonteTexto, Brushes.Black, new Rectangle(colunaAtual, linhaAtual, largurasColunas[i], (int)tamanhoColuna.Height));
                colunaAtual += largurasColunas[i];
            }

            linhaAtual += (int)e.Graphics.MeasureString("X", fonteTexto).Height + margemInterna; // Pular uma linha após os cabeçalhos

            // Imprimir dados da lista
            foreach (ListViewItem item in listViewResultadoPeso.Items)
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
            string textoTotalVendas = $"Total em Vendas: {lbValorTotalKg.Text}\n";
            string textoQuantidade = $"Peso Total: {lbPesoTotal.Text}\n";

            // Ajuste de posição vertical
            int alturaTextoAdicional = (int)e.Graphics.MeasureString("X", fonteDados).Height + margemInterna;

            e.Graphics.DrawString(textoTotalVendas, fonteDados, Brushes.Black, new Point(margemInterna, linhaAtual));
            linhaAtual += alturaTextoAdicional;

            e.Graphics.DrawString(textoQuantidade, fonteDados, Brushes.Black, new Point(margemInterna, linhaAtual));
            linhaAtual += alturaTextoAdicional;

            // Imprimir textos adicionais
            linhaAtual += margemInterna;
            Font fonteTextoAdicional = new Font("Arial", 7);
            string textoAdicional1 = "Sistema Original Desenvolvido por AIRK DIGITAL";
            string textoAdicional2 = "Atendimento Via WhatsApp: 11 96351-2105";
            e.Graphics.DrawString(textoAdicional1, fonteTextoAdicional, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, fonteTextoAdicional.Height), formatoCentralizado);
            linhaAtual += (int)fonteTextoAdicional.Height;

            e.Graphics.DrawString(textoAdicional2, fonteTextoAdicional, Brushes.Black, new Rectangle(0, linhaAtual, e.PageBounds.Width, fonteTextoAdicional.Height), formatoCentralizado);
        }

    }
}

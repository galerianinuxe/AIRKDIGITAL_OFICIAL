using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Runtime.ConstrainedExecution;
using iText.IO.Font.Constants;
using static AIRKFormInicio.AIRKMASTER;


namespace AIRKFormInicio
{
    public partial class AIRKMASTER : Form
    {

        private const string folderName = "Src"; // Nome da pasta
        private const string fileName = "clientes.json"; // Nome do arquivo
        private string filePath; // Caminho completo do arquivo

        // Classe para representar um cliente
        public class Cliente
        {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string Nome { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string Rg { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string CpfCnpj { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string NomeEmpresa { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string Endereco { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string Numero { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string Cep { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string TipoPlano { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string Bairro { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string Cidade { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string Uf { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
            public string WhatsApp { get; set; }
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        }

        private List<Cliente> ListaClientes; // Adicione esta linha para declarar a lista

        public AIRKMASTER()
        {
            InitializeComponent();

            // Substitua os TextBox por MaskedTextBox no formulário
            // Exemplo:
            MaskedTextBox txtRg = new MaskedTextBox();
            MaskedTextBox txtCpfCnpj = new MaskedTextBox();
            MaskedTextBox txtCep = new MaskedTextBox();
            MaskedTextBox txtWhats = new MaskedTextBox();

            // Configure as máscaras
            txtRg.Mask = "00.000.000-0";
            txtCpfCnpj.Mask = "000.000.000-00";
            txtCep.Mask = "00000-000";
            txtWhats.Mask = "(00) 00000-0000";

            // Popule o comboUf com UFs do Brasil
            string[] ufs = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
            comboUf.Items.AddRange(ufs);

            // Popule o comboPlanos com opções Básico e Profissional
            string[] planos = { "Básico", "Profissional" };
            comboPlanos.Items.AddRange(planos);

            // Verifique se a pasta existe e crie se necessário
            CriarPastaSeNaoExistir();

            // Construa o caminho completo do arquivo
            filePath = Path.Combine(folderName, fileName);

            // Inicialize a lista de clientes
            ListaClientes = new List<Cliente>();

            // Carregue os clientes do arquivo (se existir)
            CarregarClientes();

            // Associe o evento de clique aos botões
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            btnCadastrar.Click += BtnCadastrar_Click;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            btnSalvar.Click += BtnSalvar_Click;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            btnExcluirCliente.Click += BtnExcluirCliente_Click;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).

            // Associe o evento de seleção de item no ListView
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            lvClientes.SelectedIndexChanged += LvClientes_SelectedIndexChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).

            // Associe o evento de alteração nos TextBoxes
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtNomeCliente.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtRg.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtCpfCnpj.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtNomeEmpresa.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtEndereco.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtNumero.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtCep.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            comboPlanos.SelectedIndexChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtBairro.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtCidade.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            comboUf.SelectedIndexChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtWhats.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de referência no tipo de parâmetro não corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).

            // Desabilite o botão Cadastrar inicialmente
            btnCadastrar.Enabled = false;
        }

        private void CriarPastaSeNaoExistir()
        {
            // Verifique se a pasta não existe e crie se necessário
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            // Verifique se o TextBox não está vazio antes de adicionar à ListView
            if (!string.IsNullOrEmpty(txtNomeCliente.Text))
            {
                // Crie um novo objeto Cliente com as informações
#pragma warning disable CS8601 // Possível atribuição de referência nula.
                Cliente novoCliente = new Cliente
                {
                    Nome = txtNomeCliente.Text,
                    Rg = txtRg.Text,
                    CpfCnpj = txtCpfCnpj.Text,
                    NomeEmpresa = txtNomeEmpresa.Text,
                    Endereco = txtEndereco.Text,
                    Numero = txtNumero.Text,
                    Cep = txtCep.Text,
                    TipoPlano = comboPlanos.SelectedItem?.ToString(),
                    Bairro = txtBairro.Text,
                    Cidade = txtCidade.Text,
                    Uf = comboUf.Text,
                    WhatsApp = txtWhats.Text
                };
#pragma warning restore CS8601 // Possível atribuição de referência nula.

                // Adicione um novo item à ListView
                ListViewItem listViewItem = new ListViewItem(new[] { novoCliente.NomeEmpresa, novoCliente.Nome });
                lvClientes.Items.Add(listViewItem);

                // Adicione o cliente à lista de clientes
                AdicionarCliente(novoCliente);

                // Limpe os TextBoxes após adicionar
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, insira o nome do cliente.");
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Verifique se há um item selecionado no ListView
            if (lvClientes.SelectedItems.Count > 0)
            {
                // Obtenha o cliente associado ao item selecionado
                Cliente clienteSelecionado = ObterClientePorNome(lvClientes.SelectedItems[0].SubItems[1].Text);

                // Encontre o índice do cliente na lista
                int indiceCliente = ListaClientes.FindIndex(c => c.Nome == clienteSelecionado.Nome);

                // Verifique se o índice é válido antes de atualizar a lista
                if (indiceCliente >= 0 && indiceCliente < ListaClientes.Count)
                {
                    // Atualize os dados do cliente com os valores dos TextBoxes
                    AtualizarClienteComCampos(clienteSelecionado);

                    // Substitua o cliente existente pelo cliente atualizado
                    ListaClientes[indiceCliente] = clienteSelecionado;

                    // Salve os clientes atualizados no arquivo
                    SalvarClientes(ListaClientes);

                    // Limpe os TextBoxes após salvar
                    LimparCampos();
                    CarregarClientes();
                }
                else
                {
                    MessageBox.Show("Índice do cliente inválido.");
                }

                // Desselecione o item no ListView
                lvClientes.SelectedItems.Clear();
            }
        }



        private void BtnExcluirCliente_Click(object sender, EventArgs e)
        {
            // Verifique se há um item selecionado no ListView
            if (lvClientes.SelectedItems.Count > 0)
            {
                // Obtenha o cliente associado ao item selecionado
                Cliente clienteSelecionado = ObterClientePorNome(lvClientes.SelectedItems[0].SubItems[1].Text);

                // Remova o item selecionado do ListView
                lvClientes.SelectedItems[0].Remove();

                // Remova o cliente da lista
                ListaClientes.RemoveAll(c => c.Nome == clienteSelecionado.Nome);

                // Salve os clientes atualizados no arquivo
                SalvarClientes(ListaClientes);

                // Limpe os TextBoxes após excluir
                LimparCampos();

                // Desselecione o item no ListView
                lvClientes.SelectedItems.Clear();
            }
        }

        private void LvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique se há um item selecionado no ListView
            if (lvClientes.SelectedItems.Count > 0)
            {
                // Obtenha o cliente associado ao item selecionado
                Cliente clienteSelecionado = ObterClientePorNome(lvClientes.SelectedItems[0].SubItems[1].Text);

                // Exiba os dados do cliente nos TextBoxes
                ExibirDadosCliente(clienteSelecionado);

                // Habilite o botão Salvar
                btnCadastrar.Enabled = false;
                btnSalvar.Enabled = true;
                btnExcluirCliente.Enabled = true;
            }
            else
            {
                // Desabilite o botão Salvar se nenhum item estiver selecionado
                btnSalvar.Enabled = false;
                btnExcluirCliente.Enabled = false;
                LimparCampos();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Habilitar o botão Cadastrar se o campo NomeCliente não estiver vazio
            btnCadastrar.Enabled = !string.IsNullOrEmpty(txtNomeCliente.Text);
        }

        private void AtualizarClienteComCampos(Cliente cliente)
        {
            // Atualize os campos do cliente com os valores dos TextBoxes
            cliente.Nome = txtNomeCliente.Text;
            cliente.Rg = txtRg.Text;
            cliente.CpfCnpj = txtCpfCnpj.Text;
            cliente.NomeEmpresa = txtNomeEmpresa.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Numero = txtNumero.Text;
            cliente.Cep = txtCep.Text;
#pragma warning disable CS8601 // Possível atribuição de referência nula.
            cliente.TipoPlano = comboPlanos.SelectedItem?.ToString();
#pragma warning restore CS8601 // Possível atribuição de referência nula.
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Uf = comboUf.Text;
            cliente.WhatsApp = txtWhats.Text;
        }

        private void LimparCampos()
        {
            // Limpe todos os campos do formulário
            txtNomeCliente.Clear();
            txtRg.Clear();
            txtCpfCnpj.Clear();
            txtNomeEmpresa.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            comboPlanos.SelectedIndex = -1;
            txtBairro.Clear();
            txtCidade.Clear();
            comboUf.SelectedIndex = -1;
            txtWhats.Clear();

            // Desabilite o botão Salvar
            btnSalvar.Enabled = false;
            btnExcluirCliente.Enabled = false;
        }

        private void AdicionarCliente(Cliente novoCliente)
        {
            // Adicione o novo cliente à lista
            ListaClientes.Add(novoCliente);

            // Salve a lista atualizada no arquivo
            SalvarClientes(ListaClientes);
        }

        private void SalvarClientes(List<Cliente> clientes)
        {
            // Converta a lista para JSON e salve no arquivo
            string json = JsonSerializer.Serialize(clientes);
            File.WriteAllText(filePath, json);
        }

        private void CarregarClientes()
        {
            lvClientes.Items.Clear();
            // Carregue os clientes do arquivo JSON
            ListaClientes = CarregarClientesDoArquivo();

            // Adicione os clientes à ListView
            foreach (Cliente cliente in ListaClientes)
            {
                ListViewItem listViewItem = new ListViewItem(new[] { cliente.NomeEmpresa, cliente.Nome });
                lvClientes.Items.Add(listViewItem);
            }
        }

        private List<Cliente> CarregarClientesDoArquivo()
        {
            // Carregue os clientes do arquivo JSON
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
#pragma warning disable CS8603 // Possível retorno de referência nula.
                return JsonSerializer.Deserialize<List<Cliente>>(json);
#pragma warning restore CS8603 // Possível retorno de referência nula.
            }

            return new List<Cliente>();
        }

        private Cliente ObterClientePorNome(string nomeCliente)
        {
            // Carregue a lista de clientes do arquivo
            List<Cliente> clientes = CarregarClientesDoArquivo();

            // Encontre o cliente com o nome correspondente
            Cliente clienteEncontrado = clientes.Find(c => c.Nome == nomeCliente);

            if (clienteEncontrado == null)
            {
                // Trate o caso em que nenhum cliente foi encontrado
                MessageBox.Show("Cliente não encontrado.");
            }

            return clienteEncontrado;
        }



        private void ExibirDadosCliente(Cliente cliente)
        {
            // Exiba os dados do cliente nos TextBoxes
            txtNomeCliente.Text = cliente.Nome;
            txtRg.Text = cliente.Rg;
            txtCpfCnpj.Text = cliente.CpfCnpj;
            txtNomeEmpresa.Text = cliente.NomeEmpresa;
            txtEndereco.Text = cliente.Endereco;
            txtNumero.Text = cliente.Numero;
            txtCep.Text = cliente.Cep;
            comboPlanos.SelectedItem = cliente.TipoPlano;
            txtBairro.Text = cliente.Bairro;
            txtCidade.Text = cliente.Cidade;
            comboUf.Text = cliente.Uf;
            txtWhats.Text = cliente.WhatsApp;
        }

        private void AIRKMASTER_Load(object sender, EventArgs e)
        {
            // Configure as colunas do ListView
            lvClientes.View = View.Details;
            lvClientes.Columns.Add("Empresa", 250);
            lvClientes.Columns.Add("Cliente", 250);

        }

        private void btnGerarContrato_Click(object sender, EventArgs e)
        {
            // Verifique se há um item selecionado no ListView
            if (lvClientes.SelectedItems.Count > 0)
            {
                // Obtenha o cliente associado ao item selecionado
                Cliente clienteSelecionado = ObterClientePorNome(lvClientes.SelectedItems[0].SubItems[1].Text);

                // Gere o contrato em formato PDF
                GerarContratoLocacaoPDF(clienteSelecionado);
            }
            else
            {
                MessageBox.Show("Selecione um cliente para gerar o contrato.");
            }
        }

        private void GerarContratoLocacaoPDF(Cliente cliente)
        {
            try
            {
                // Caminho do arquivo PDF
                string caminhoDoPDF = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Src", "contrato", $"{cliente.Nome}_ContratoLocacao.pdf");

                // Criar um novo documento PDF
                using (var writer = new PdfWriter(caminhoDoPDF))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        // Criar um layout para o documento
                        var document = new Document(pdf);

                        // Definir o tamanho da fonte para 8 pontos
                        var tamanhoFonte = 8;

                        // Adicionar o conteúdo formatado ao documento
                        AdicionarConteudoFormatado(document, cliente);

                        // Adicionar assinaturas ao final do documento
                        AdicionarAssinaturas(document, cliente, tamanhoFonte);


                    }
                }

                MessageBox.Show($"Contrato gerado com sucesso!");// Caminho do PDF: {caminhoDoPDF}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao gerar o contrato: {ex.Message}");
            }
        }

        private void AdicionarConteudoFormatado(Document document, Cliente cliente)
        {
            // Adicionar título
            document.Add(new Paragraph("CONTRATO DE LOCAÇÃO DE SISTEMA DIGITAL")
                .SetBold()
                .SetTextAlignment(TextAlignment.CENTER));

            // Adicionar partes envolvidas
            document.Add(new Paragraph("\n1. PARTES ENVOLVIDAS:\n").SetBold());

            // Adicionar LOCADOR
            document.Add(new Paragraph("LOCADOR:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Rick Siqueira Costa, portador do RG: 39.246.288-6 e CPF 484.715.578-51, residente à Rua Ipê Amarelo, 37 - Jd Pinheiros - São Bernardo do Campo, CEP 09854-670, Telefone/WhatsApp: (11) 96351-2105, E-mail: galerianinuxe@gmail.com"));

            // Adicionar LOCATÁRIO
            document.Add(new Paragraph("\nLOCATÁRIO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph($"{cliente.Nome}, portador do RG: {cliente.Rg} e CPF {cliente.CpfCnpj}, residente à {cliente.Endereco}, {cliente.Numero} - {cliente.Bairro} - {cliente.Cidade}, CEP {cliente.Cep}, UF {cliente.Uf} Telefone/WhatsApp: {cliente.WhatsApp}"));
            // Adicionar OBJETO DO CONTRATO
            document.Add(new Paragraph("\n2. OBJETO DO CONTRATO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("O Locador concorda em fornecer ao Locatário o acesso e uso exclusivo do sistema digital denominado \"Controle de Compra AIRKSUCATA\", conforme especificações detalhadas no ANEXO A."));

            // Adicionar PERÍODO DE LOCAÇÃO E PAGAMENTO
            document.Add(new Paragraph("\n3. PERÍODO DE LOCAÇÃO E PAGAMENTO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("3.1. O presente contrato terá uma duração mínima de 365 dias, com pagamento mensal de R$ 100,00 durante 12 meses."));
            document.Add(new Paragraph("3.2. O pagamento do primeiro mês deverá ser efetuado imediatamente após a instalação do sistema no computador do Locatário ou entrega dos equipamentos com o sistema instalado."));
            document.Add(new Paragraph("3.3. Os pagamentos subsequentes deverão ser realizados até o dia 10 de cada mês."));
            document.Add(new Paragraph("3.4. O prazo de vencimento é de 5 dias após o dia de pagamento."));
            document.Add(new Paragraph("3.5. Caso o pagamento não seja efetuado até o 5º dia após a data de vencimento, o sistema será automaticamente desativado. O Locatário deverá contatar o Locador para a obtenção de um novo acesso válido."));
            document.Add(new Paragraph("3.6. O pagamento poderá ser efetuado via boleto, PIX ou cartão de crédito."));

            // Adicionar SUPORTE E ATUALIZAÇÕES
            document.Add(new Paragraph("\n4. SUPORTE E ATUALIZAÇÕES:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("4.1. O Locatário em dia com os pagamentos tem direito a suporte técnico de segunda a sábado, das 8h às 18h, e às futuras atualizações do sistema sem custo adicional."));

            // Adicionar ACESSO E EQUIPAMENTOS
            document.Add(new Paragraph("\n5. ACESSO E EQUIPAMENTOS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("5.1. O acesso ao sistema é disponibilizado exclusivamente para 1 (um) computador. A obtenção de acessos adicionais implica em custo adicional de R$ 100,00 por mês."));
            document.Add(new Paragraph("5.2. O Locatário é responsável pela compra dos equipamentos necessários para a utilização do sistema, conforme especificações detalhadas no ANEXO B."));

            // Adicionar QUEBRA DE CONTRATO
            document.Add(new Paragraph("\n6. QUEBRA DE CONTRATO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("6.1. Caso o Locatário deseje rescindir o contrato antes do término do prazo acordado, será aplicada uma taxa de quebra de contrato no valor de 60% do montante total dos meses restantes do contrato."));
            document.Add(new Paragraph("6.2. A taxa de quebra de contrato deverá ser paga em até 7 dias corridos após o cancelamento, podendo ser parcelada em até 6 vezes no cartão de crédito ou paga via PIX ou boleto bancário."));

            // Adicionar RESTRIÇÕES DE USO
            document.Add(new Paragraph("\n7. RESTRIÇÕES DE USO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("7.1. A cópia e distribuição do sistema do ANEXO A para terceiros sem autorização expressa do Locador são proibidas e podem ser consideradas crime."));

            // Adicionar CONDIÇÕES GERAIS
            document.Add(new Paragraph("\n8. CONDIÇÕES GERAIS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("8.1. Este contrato será regido pelas leis do Brasil, e qualquer disputa será resolvida no tribunal competente de São Bernardo do Campo."));
            document.Add(new Paragraph("8.2. Este contrato pode ser alterado mediante acordo escrito entre as partes."));

            // Adicionar ANEXO A
            document.Add(new Paragraph("\nANEXO A: ESPECIFICAÇÕES DO SISTEMA")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("O Sistema de Controle de Compra AIRKSUCATA tem como objetivo agilizar o processo de compra de materiais por peso."));
            document.Add(new Paragraph("Segue todas as funcionalidades do sistema:"));
            document.Add(new Paragraph("Registrar pedidos contendo cada material pesado na balança, sendo:"));
            document.Add(new Paragraph("Nome do material;"));
            document.Add(new Paragraph("Valor do KG;"));
            document.Add(new Paragraph("Acréscimo R$ por KG;"));
            document.Add(new Paragraph("Nome do cliente;"));
            document.Add(new Paragraph("Peso Total;"));
            document.Add(new Paragraph("Total a Pagar;"));
            document.Add(new Paragraph("Data e Hora;"));
            document.Add(new Paragraph("Número de registro."));
            document.Add(new Paragraph("Efetua reimpressão de comprovantes de compras efetuadas através da data ou número de registro."));
            document.Add(new Paragraph("É possível efetuar venda de materiais por PESO ou UNIDADE, cada venda é salva em registros para consultas futuras."));
            document.Add(new Paragraph("Painel administrativo contendo:"));
            document.Add(new Paragraph("4.1 Edição de Materiais: Nome, Valor Kg."));
            document.Add(new Paragraph("4.2 Relatórios de Venda: Imprime relatório por data de venda por PESO ou UNIDADE."));
            document.Add(new Paragraph("4.3 Relatórios de Compra: Imprime o relatório de compra por data."));

            // Adicionar ANEXO B
            document.Add(new Paragraph("\nANEXO B: EQUIPAMENTOS NECESSÁRIOS")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("01 COMPUTADOR BÁSICO COM SISTEMA OPERACIONAL WINDOWS 10 64BITS - R$ 850,00"));
            document.Add(new Paragraph("01 IMPRESSORA TÉRMICA NÃO FISCAL DE 80MM DE SAÍDA - R$ 450,00"));
            document.Add(new Paragraph("01 MONITOR TOUCHSCREEN A PARTIR DE 15 POLEGADAS (NÃO NECESSITA MOUSE E TECLADO) - R$ 1850"));
            document.Add(new Paragraph("ou 01 MONITOR NORMAL A PARTIR DE 15 POLEGADAS (NECESSÁRIO USO DO MOUSE) - R$ 350"));
            document.Add(new Paragraph("Estes equipamentos podem ser comprados pelo locatário diretamente conosco com garantia de 1 ano em cada equipamento ou podem ser adquiridos pelo fornecedor que o locatário preferir."));

            // Adicionar ENCERRAMENTO DO CONTRATO
            document.Add(new Paragraph("\n9. ENCERRAMENTO DO CONTRATO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));

            // Adicionar VIGÊNCIA E RENOVAÇÃO
            document.Add(new Paragraph("9.1. VIGÊNCIA E RENOVAÇÃO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Este contrato terá início na data de assinatura e terá uma duração mínima de 365 dias. Após esse período, as partes podem acordar a renovação, mediante acordo escrito. Caso nenhuma das partes manifeste o desejo de encerrar o contrato, ele será renovado automaticamente por períodos adicionais de 365 dias."));

            // Adicionar ALTERAÇÕES CONTRATUAIS
            document.Add(new Paragraph("\n9.2. ALTERAÇÕES CONTRATUAIS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Quaisquer alterações a este contrato devem ser feitas por escrito e assinadas por ambas as partes. Alterações podem incluir, mas não estão limitadas a, prazos de pagamento, condições de suporte e atualizações, ou especificações do sistema."));

            // Adicionar COMUNICAÇÕES
            document.Add(new Paragraph("\n9.3. COMUNICAÇÕES:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("As comunicações entre as partes podem ser realizadas por e-mail, telefone ou correspondência física. Ambas as partes concordam em informar prontamente a outra parte sobre qualquer alteração nas informações de contato."));

            // Adicionar RESOLUÇÃO DE CONFLITOS
            document.Add(new Paragraph("\n9.4. RESOLUÇÃO DE CONFLITOS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Eventuais disputas relacionadas a este contrato serão resolvidas por negociação entre as partes. Se a negociação não for bem-sucedida, as partes concordam em recorrer à mediação, e, se necessário, à arbitragem, de acordo com as leis do Brasil. O foro competente para resolver quaisquer disputas será o tribunal de São Bernardo do Campo."));

            // Adicionar LEI APLICÁVEL
            document.Add(new Paragraph("\n9.5. LEI APLICÁVEL:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Este contrato será regido e interpretado de acordo com as leis do Brasil."));

            // Adicionar ACORDO INTEGRAL
            document.Add(new Paragraph("\n9.6. ACORDO INTEGRAL:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Este contrato constitui o entendimento integral entre as partes e substitui todos os acordos ou entendimentos anteriores, sejam verbais ou escritos."));

            // Adicionar ASSINATURAS
            document.Add(new Paragraph("\n9.7. ASSINATURAS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("As partes concordam em revisar este contrato antes da assinatura e manter cópias assinadas para seus registros."));

            // Adicionar TESTEMUNHAS
            document.Add(new Paragraph("\n9.8. TESTEMUNHAS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("As partes concordam que as assinaturas podem ser testemunhadas por indivíduos independentes, caso necessário."));

            // Adicionar NOTIFICAÇÕES
            document.Add(new Paragraph("\n9.9. NOTIFICAÇÕES:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Notificações formais ou correspondências legais devem ser enviadas para os endereços e-mails ou físicos especificados na Seção 1 deste contrato. Ambas as partes concordam em informar a outra parte sobre qualquer alteração nos endereços fornecidos."));

            // Adicionar ENCERRAMENTO DO CONTRATO
            document.Add(new Paragraph("\n9.10. ENCERRAMENTO DO CONTRATO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Na rescisão do contrato, o Locatário concorda em devolver quaisquer propriedades do Locador em sua posse, incluindo, mas não se limitando a, cópias do sistema digital e documentação relacionada."));

            // Adicionar CONCORDÂNCIA
            document.Add(new Paragraph("\n9.11. CONCORDÂNCIA:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Ambas as partes declaram sua compreensão e concordância com os termos e condições estabelecidos neste contrato."));

            // Adicionar ASSINATURAS
            //AdicionarAssinaturas(document, cliente, tamanhoFonte); // Certifique-se de que 'cliente' está definido e é uma instância válida de Cliente


            //document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
        }

        private void AdicionarAssinaturas(Document document, Cliente cliente, float tamanhoFonte)
        {
            // Adicionar assinatura do LOCADOR
            document.Add(new Paragraph("\nLOCADOR:")
            .SetBold()
            .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Assinatura: _______________________"));
            document.Add(new Paragraph("Nome: RICK SIQUEIRA COSTA"));
            document.Add(new Paragraph("Data: ____________"));
            // Adicionar assinatura do LOCATÁRIO
            document.Add(new Paragraph("\nLOCATÁRIO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Assinatura: _______________________"));
            document.Add(new Paragraph($"Nome: {cliente.Nome}"));
            document.Add(new Paragraph("Data: ____________"));

            // Adicionar assinatura do LOCADOR
            document.Add(new Paragraph("\nTESTEMUNHA 1:")
            .SetBold()
            .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Assinatura: _______________________"));
            document.Add(new Paragraph("Nome: ___________________"));
            document.Add(new Paragraph("Data: ____________"));
            // Adicionar assinatura do LOCATÁRIO
            document.Add(new Paragraph("\nTESTEMUNHA 2:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Assinatura: _______________________"));
            document.Add(new Paragraph($"Nome: ___________________"));
            document.Add(new Paragraph("Data: ____________"));
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            // Cria uma instância do formulário que você deseja abrir
            AIRKAjusteDados formAjusteDados = new AIRKAjusteDados();

            // Exibe o formulário
            formAjusteDados.Show();
        }
    }
}

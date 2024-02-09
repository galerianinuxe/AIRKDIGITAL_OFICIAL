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
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string Nome { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string Rg { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string CpfCnpj { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string NomeEmpresa { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string Endereco { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string Numero { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string Cep { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string TipoPlano { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string Bairro { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string Cidade { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string Uf { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
#pragma warning disable CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
            public string WhatsApp { get; set; }
#pragma warning restore CS8618 // O campo n�o anul�vel precisa conter um valor n�o nulo ao sair do construtor. Considere declar�-lo como anul�vel.
        }

        private List<Cliente> ListaClientes; // Adicione esta linha para declarar a lista

        public AIRKMASTER()
        {
            InitializeComponent();

            // Substitua os TextBox por MaskedTextBox no formul�rio
            // Exemplo:
            MaskedTextBox txtRg = new MaskedTextBox();
            MaskedTextBox txtCpfCnpj = new MaskedTextBox();
            MaskedTextBox txtCep = new MaskedTextBox();
            MaskedTextBox txtWhats = new MaskedTextBox();

            // Configure as m�scaras
            txtRg.Mask = "00.000.000-0";
            txtCpfCnpj.Mask = "000.000.000-00";
            txtCep.Mask = "00000-000";
            txtWhats.Mask = "(00) 00000-0000";

            // Popule o comboUf com UFs do Brasil
            string[] ufs = { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" };
            comboUf.Items.AddRange(ufs);

            // Popule o comboPlanos com op��es B�sico e Profissional
            string[] planos = { "B�sico", "Profissional" };
            comboPlanos.Items.AddRange(planos);

            // Verifique se a pasta existe e crie se necess�rio
            CriarPastaSeNaoExistir();

            // Construa o caminho completo do arquivo
            filePath = Path.Combine(folderName, fileName);

            // Inicialize a lista de clientes
            ListaClientes = new List<Cliente>();

            // Carregue os clientes do arquivo (se existir)
            CarregarClientes();

            // Associe o evento de clique aos bot�es
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            btnCadastrar.Click += BtnCadastrar_Click;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            btnSalvar.Click += BtnSalvar_Click;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            btnExcluirCliente.Click += BtnExcluirCliente_Click;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).

            // Associe o evento de sele��o de item no ListView
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            lvClientes.SelectedIndexChanged += LvClientes_SelectedIndexChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).

            // Associe o evento de altera��o nos TextBoxes
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtNomeCliente.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtRg.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtCpfCnpj.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtNomeEmpresa.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtEndereco.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtNumero.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtCep.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            comboPlanos.SelectedIndexChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtBairro.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtCidade.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            comboUf.SelectedIndexChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
#pragma warning disable CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).
            txtWhats.TextChanged += TextBox_TextChanged;
#pragma warning restore CS8622 // A nulidade de tipos de refer�ncia no tipo de par�metro n�o corresponde ao delegado de destino (possivelmente devido a atributos de nulidade).

            // Desabilite o bot�o Cadastrar inicialmente
            btnCadastrar.Enabled = false;
        }

        private void CriarPastaSeNaoExistir()
        {
            // Verifique se a pasta n�o existe e crie se necess�rio
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            // Verifique se o TextBox n�o est� vazio antes de adicionar � ListView
            if (!string.IsNullOrEmpty(txtNomeCliente.Text))
            {
                // Crie um novo objeto Cliente com as informa��es
#pragma warning disable CS8601 // Poss�vel atribui��o de refer�ncia nula.
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
#pragma warning restore CS8601 // Poss�vel atribui��o de refer�ncia nula.

                // Adicione um novo item � ListView
                ListViewItem listViewItem = new ListViewItem(new[] { novoCliente.NomeEmpresa, novoCliente.Nome });
                lvClientes.Items.Add(listViewItem);

                // Adicione o cliente � lista de clientes
                AdicionarCliente(novoCliente);

                // Limpe os TextBoxes ap�s adicionar
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Por favor, insira o nome do cliente.");
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Verifique se h� um item selecionado no ListView
            if (lvClientes.SelectedItems.Count > 0)
            {
                // Obtenha o cliente associado ao item selecionado
                Cliente clienteSelecionado = ObterClientePorNome(lvClientes.SelectedItems[0].SubItems[1].Text);

                // Encontre o �ndice do cliente na lista
                int indiceCliente = ListaClientes.FindIndex(c => c.Nome == clienteSelecionado.Nome);

                // Verifique se o �ndice � v�lido antes de atualizar a lista
                if (indiceCliente >= 0 && indiceCliente < ListaClientes.Count)
                {
                    // Atualize os dados do cliente com os valores dos TextBoxes
                    AtualizarClienteComCampos(clienteSelecionado);

                    // Substitua o cliente existente pelo cliente atualizado
                    ListaClientes[indiceCliente] = clienteSelecionado;

                    // Salve os clientes atualizados no arquivo
                    SalvarClientes(ListaClientes);

                    // Limpe os TextBoxes ap�s salvar
                    LimparCampos();
                    CarregarClientes();
                }
                else
                {
                    MessageBox.Show("�ndice do cliente inv�lido.");
                }

                // Desselecione o item no ListView
                lvClientes.SelectedItems.Clear();
            }
        }



        private void BtnExcluirCliente_Click(object sender, EventArgs e)
        {
            // Verifique se h� um item selecionado no ListView
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

                // Limpe os TextBoxes ap�s excluir
                LimparCampos();

                // Desselecione o item no ListView
                lvClientes.SelectedItems.Clear();
            }
        }

        private void LvClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique se h� um item selecionado no ListView
            if (lvClientes.SelectedItems.Count > 0)
            {
                // Obtenha o cliente associado ao item selecionado
                Cliente clienteSelecionado = ObterClientePorNome(lvClientes.SelectedItems[0].SubItems[1].Text);

                // Exiba os dados do cliente nos TextBoxes
                ExibirDadosCliente(clienteSelecionado);

                // Habilite o bot�o Salvar
                btnCadastrar.Enabled = false;
                btnSalvar.Enabled = true;
                btnExcluirCliente.Enabled = true;
            }
            else
            {
                // Desabilite o bot�o Salvar se nenhum item estiver selecionado
                btnSalvar.Enabled = false;
                btnExcluirCliente.Enabled = false;
                LimparCampos();
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Habilitar o bot�o Cadastrar se o campo NomeCliente n�o estiver vazio
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
#pragma warning disable CS8601 // Poss�vel atribui��o de refer�ncia nula.
            cliente.TipoPlano = comboPlanos.SelectedItem?.ToString();
#pragma warning restore CS8601 // Poss�vel atribui��o de refer�ncia nula.
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.Uf = comboUf.Text;
            cliente.WhatsApp = txtWhats.Text;
        }

        private void LimparCampos()
        {
            // Limpe todos os campos do formul�rio
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

            // Desabilite o bot�o Salvar
            btnSalvar.Enabled = false;
            btnExcluirCliente.Enabled = false;
        }

        private void AdicionarCliente(Cliente novoCliente)
        {
            // Adicione o novo cliente � lista
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

            // Adicione os clientes � ListView
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
#pragma warning disable CS8603 // Poss�vel retorno de refer�ncia nula.
                return JsonSerializer.Deserialize<List<Cliente>>(json);
#pragma warning restore CS8603 // Poss�vel retorno de refer�ncia nula.
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
                MessageBox.Show("Cliente n�o encontrado.");
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
            // Verifique se h� um item selecionado no ListView
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

                        // Adicionar o conte�do formatado ao documento
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
            // Adicionar t�tulo
            document.Add(new Paragraph("CONTRATO DE LOCA��O DE SISTEMA DIGITAL")
                .SetBold()
                .SetTextAlignment(TextAlignment.CENTER));

            // Adicionar partes envolvidas
            document.Add(new Paragraph("\n1. PARTES ENVOLVIDAS:\n").SetBold());

            // Adicionar LOCADOR
            document.Add(new Paragraph("LOCADOR:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Rick Siqueira Costa, portador do RG: 39.246.288-6 e CPF 484.715.578-51, residente � Rua Ip� Amarelo, 37 - Jd Pinheiros - S�o Bernardo do Campo, CEP 09854-670, Telefone/WhatsApp: (11) 96351-2105, E-mail: galerianinuxe@gmail.com"));

            // Adicionar LOCAT�RIO
            document.Add(new Paragraph("\nLOCAT�RIO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph($"{cliente.Nome}, portador do RG: {cliente.Rg} e CPF {cliente.CpfCnpj}, residente � {cliente.Endereco}, {cliente.Numero} - {cliente.Bairro} - {cliente.Cidade}, CEP {cliente.Cep}, UF {cliente.Uf} Telefone/WhatsApp: {cliente.WhatsApp}"));
            // Adicionar OBJETO DO CONTRATO
            document.Add(new Paragraph("\n2. OBJETO DO CONTRATO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("O Locador concorda em fornecer ao Locat�rio o acesso e uso exclusivo do sistema digital denominado \"Controle de Compra AIRKSUCATA\", conforme especifica��es detalhadas no ANEXO A."));

            // Adicionar PER�ODO DE LOCA��O E PAGAMENTO
            document.Add(new Paragraph("\n3. PER�ODO DE LOCA��O E PAGAMENTO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("3.1. O presente contrato ter� uma dura��o m�nima de 365 dias, com pagamento mensal de R$ 100,00 durante 12 meses."));
            document.Add(new Paragraph("3.2. O pagamento do primeiro m�s dever� ser efetuado imediatamente ap�s a instala��o do sistema no computador do Locat�rio ou entrega dos equipamentos com o sistema instalado."));
            document.Add(new Paragraph("3.3. Os pagamentos subsequentes dever�o ser realizados at� o dia 10 de cada m�s."));
            document.Add(new Paragraph("3.4. O prazo de vencimento � de 5 dias ap�s o dia de pagamento."));
            document.Add(new Paragraph("3.5. Caso o pagamento n�o seja efetuado at� o 5� dia ap�s a data de vencimento, o sistema ser� automaticamente desativado. O Locat�rio dever� contatar o Locador para a obten��o de um novo acesso v�lido."));
            document.Add(new Paragraph("3.6. O pagamento poder� ser efetuado via boleto, PIX ou cart�o de cr�dito."));

            // Adicionar SUPORTE E ATUALIZA��ES
            document.Add(new Paragraph("\n4. SUPORTE E ATUALIZA��ES:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("4.1. O Locat�rio em dia com os pagamentos tem direito a suporte t�cnico de segunda a s�bado, das 8h �s 18h, e �s futuras atualiza��es do sistema sem custo adicional."));

            // Adicionar ACESSO E EQUIPAMENTOS
            document.Add(new Paragraph("\n5. ACESSO E EQUIPAMENTOS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("5.1. O acesso ao sistema � disponibilizado exclusivamente para 1 (um) computador. A obten��o de acessos adicionais implica em custo adicional de R$ 100,00 por m�s."));
            document.Add(new Paragraph("5.2. O Locat�rio � respons�vel pela compra dos equipamentos necess�rios para a utiliza��o do sistema, conforme especifica��es detalhadas no ANEXO B."));

            // Adicionar QUEBRA DE CONTRATO
            document.Add(new Paragraph("\n6. QUEBRA DE CONTRATO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("6.1. Caso o Locat�rio deseje rescindir o contrato antes do t�rmino do prazo acordado, ser� aplicada uma taxa de quebra de contrato no valor de 60% do montante total dos meses restantes do contrato."));
            document.Add(new Paragraph("6.2. A taxa de quebra de contrato dever� ser paga em at� 7 dias corridos ap�s o cancelamento, podendo ser parcelada em at� 6 vezes no cart�o de cr�dito ou paga via PIX ou boleto banc�rio."));

            // Adicionar RESTRI��ES DE USO
            document.Add(new Paragraph("\n7. RESTRI��ES DE USO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("7.1. A c�pia e distribui��o do sistema do ANEXO A para terceiros sem autoriza��o expressa do Locador s�o proibidas e podem ser consideradas crime."));

            // Adicionar CONDI��ES GERAIS
            document.Add(new Paragraph("\n8. CONDI��ES GERAIS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("8.1. Este contrato ser� regido pelas leis do Brasil, e qualquer disputa ser� resolvida no tribunal competente de S�o Bernardo do Campo."));
            document.Add(new Paragraph("8.2. Este contrato pode ser alterado mediante acordo escrito entre as partes."));

            // Adicionar ANEXO A
            document.Add(new Paragraph("\nANEXO A: ESPECIFICA��ES DO SISTEMA")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("O Sistema de Controle de Compra AIRKSUCATA tem como objetivo agilizar o processo de compra de materiais por peso."));
            document.Add(new Paragraph("Segue todas as funcionalidades do sistema:"));
            document.Add(new Paragraph("Registrar pedidos contendo cada material pesado na balan�a, sendo:"));
            document.Add(new Paragraph("Nome do material;"));
            document.Add(new Paragraph("Valor do KG;"));
            document.Add(new Paragraph("Acr�scimo R$ por KG;"));
            document.Add(new Paragraph("Nome do cliente;"));
            document.Add(new Paragraph("Peso Total;"));
            document.Add(new Paragraph("Total a Pagar;"));
            document.Add(new Paragraph("Data e Hora;"));
            document.Add(new Paragraph("N�mero de registro."));
            document.Add(new Paragraph("Efetua reimpress�o de comprovantes de compras efetuadas atrav�s da data ou n�mero de registro."));
            document.Add(new Paragraph("� poss�vel efetuar venda de materiais por PESO ou UNIDADE, cada venda � salva em registros para consultas futuras."));
            document.Add(new Paragraph("Painel administrativo contendo:"));
            document.Add(new Paragraph("4.1 Edi��o de Materiais: Nome, Valor Kg."));
            document.Add(new Paragraph("4.2 Relat�rios de Venda: Imprime relat�rio por data de venda por PESO ou UNIDADE."));
            document.Add(new Paragraph("4.3 Relat�rios de Compra: Imprime o relat�rio de compra por data."));

            // Adicionar ANEXO B
            document.Add(new Paragraph("\nANEXO B: EQUIPAMENTOS NECESS�RIOS")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("01 COMPUTADOR B�SICO COM SISTEMA OPERACIONAL WINDOWS 10 64BITS - R$ 850,00"));
            document.Add(new Paragraph("01 IMPRESSORA T�RMICA N�O FISCAL DE 80MM DE SA�DA - R$ 450,00"));
            document.Add(new Paragraph("01 MONITOR TOUCHSCREEN A PARTIR DE 15 POLEGADAS (N�O NECESSITA MOUSE E TECLADO) - R$ 1850"));
            document.Add(new Paragraph("ou 01 MONITOR NORMAL A PARTIR DE 15 POLEGADAS (NECESS�RIO USO DO MOUSE) - R$ 350"));
            document.Add(new Paragraph("Estes equipamentos podem ser comprados pelo locat�rio diretamente conosco com garantia de 1 ano em cada equipamento ou podem ser adquiridos pelo fornecedor que o locat�rio preferir."));

            // Adicionar ENCERRAMENTO DO CONTRATO
            document.Add(new Paragraph("\n9. ENCERRAMENTO DO CONTRATO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));

            // Adicionar VIG�NCIA E RENOVA��O
            document.Add(new Paragraph("9.1. VIG�NCIA E RENOVA��O:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Este contrato ter� in�cio na data de assinatura e ter� uma dura��o m�nima de 365 dias. Ap�s esse per�odo, as partes podem acordar a renova��o, mediante acordo escrito. Caso nenhuma das partes manifeste o desejo de encerrar o contrato, ele ser� renovado automaticamente por per�odos adicionais de 365 dias."));

            // Adicionar ALTERA��ES CONTRATUAIS
            document.Add(new Paragraph("\n9.2. ALTERA��ES CONTRATUAIS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Quaisquer altera��es a este contrato devem ser feitas por escrito e assinadas por ambas as partes. Altera��es podem incluir, mas n�o est�o limitadas a, prazos de pagamento, condi��es de suporte e atualiza��es, ou especifica��es do sistema."));

            // Adicionar COMUNICA��ES
            document.Add(new Paragraph("\n9.3. COMUNICA��ES:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("As comunica��es entre as partes podem ser realizadas por e-mail, telefone ou correspond�ncia f�sica. Ambas as partes concordam em informar prontamente a outra parte sobre qualquer altera��o nas informa��es de contato."));

            // Adicionar RESOLU��O DE CONFLITOS
            document.Add(new Paragraph("\n9.4. RESOLU��O DE CONFLITOS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Eventuais disputas relacionadas a este contrato ser�o resolvidas por negocia��o entre as partes. Se a negocia��o n�o for bem-sucedida, as partes concordam em recorrer � media��o, e, se necess�rio, � arbitragem, de acordo com as leis do Brasil. O foro competente para resolver quaisquer disputas ser� o tribunal de S�o Bernardo do Campo."));

            // Adicionar LEI APLIC�VEL
            document.Add(new Paragraph("\n9.5. LEI APLIC�VEL:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Este contrato ser� regido e interpretado de acordo com as leis do Brasil."));

            // Adicionar ACORDO INTEGRAL
            document.Add(new Paragraph("\n9.6. ACORDO INTEGRAL:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Este contrato constitui o entendimento integral entre as partes e substitui todos os acordos ou entendimentos anteriores, sejam verbais ou escritos."));

            // Adicionar ASSINATURAS
            document.Add(new Paragraph("\n9.7. ASSINATURAS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("As partes concordam em revisar este contrato antes da assinatura e manter c�pias assinadas para seus registros."));

            // Adicionar TESTEMUNHAS
            document.Add(new Paragraph("\n9.8. TESTEMUNHAS:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("As partes concordam que as assinaturas podem ser testemunhadas por indiv�duos independentes, caso necess�rio."));

            // Adicionar NOTIFICA��ES
            document.Add(new Paragraph("\n9.9. NOTIFICA��ES:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Notifica��es formais ou correspond�ncias legais devem ser enviadas para os endere�os e-mails ou f�sicos especificados na Se��o 1 deste contrato. Ambas as partes concordam em informar a outra parte sobre qualquer altera��o nos endere�os fornecidos."));

            // Adicionar ENCERRAMENTO DO CONTRATO
            document.Add(new Paragraph("\n9.10. ENCERRAMENTO DO CONTRATO:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Na rescis�o do contrato, o Locat�rio concorda em devolver quaisquer propriedades do Locador em sua posse, incluindo, mas n�o se limitando a, c�pias do sistema digital e documenta��o relacionada."));

            // Adicionar CONCORD�NCIA
            document.Add(new Paragraph("\n9.11. CONCORD�NCIA:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Ambas as partes declaram sua compreens�o e concord�ncia com os termos e condi��es estabelecidos neste contrato."));

            // Adicionar ASSINATURAS
            //AdicionarAssinaturas(document, cliente, tamanhoFonte); // Certifique-se de que 'cliente' est� definido e � uma inst�ncia v�lida de Cliente


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
            // Adicionar assinatura do LOCAT�RIO
            document.Add(new Paragraph("\nLOCAT�RIO:")
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
            // Adicionar assinatura do LOCAT�RIO
            document.Add(new Paragraph("\nTESTEMUNHA 2:")
                .SetBold()
                .SetTextAlignment(TextAlignment.LEFT));
            document.Add(new Paragraph("Assinatura: _______________________"));
            document.Add(new Paragraph($"Nome: ___________________"));
            document.Add(new Paragraph("Data: ____________"));
        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            // Cria uma inst�ncia do formul�rio que voc� deseja abrir
            AIRKAjusteDados formAjusteDados = new AIRKAjusteDados();

            // Exibe o formul�rio
            formAjusteDados.Show();
        }
    }
}

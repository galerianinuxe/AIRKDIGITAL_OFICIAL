using MySql.Data.MySqlClient;

namespace airksucata
{
    public partial class FormAddMaterial : Form
    {
        private string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";
        //private int previousValue = 0;

        // Lista para armazenar histórico de valores
        private List<decimal> valueHistory = new List<decimal>();

        public FormAddMaterial()
        {
            InitializeComponent();
            txtNomematerial.ReadOnly = true; // Define txtNomematerial como somente leitura
            txtValorkg.ReadOnly = true; // Define txtValorkg como somente leitura
            timerUpdateValues.Tick += timerUpdateValues_Tick;

            txtNomematerial.Leave += txtNomematerial_Leave;

            btnExcluir.Enabled = false;


            //timerUpdateValues.Start();
            LoadMaterialButtons();
        }


        private void LoadMaterialButtons()
        {
            btnExcluir.Enabled = false; //DESATIVA O BOTÃO EXCLUIR
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT id, nome, valorporkg FROM materiais ORDER BY nome";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataReader reader = command.ExecuteReader();

                    int row = 0;
                    int col = 0;
                    int maxButtonsPerRow = 8;

                    while (reader.Read())
                    {
                        string nome = reader.GetString("nome");
                        decimal valorPorKg = reader.GetDecimal("valorporkg");

                        CreateMaterialButton(row, col, nome, btnsMateriais2, valorPorKg);

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


        private void CreateMaterialButton(int row, int col, string nome, Panel panel, decimal valorPorKg)
        {
            Button newButton = new Button();

            newButton.Text = nome;
            newButton.Width = 157;
            newButton.Height = 35;
            newButton.BackColor = Color.FromArgb(0, 140, 0);
            newButton.ForeColor = Color.White;
            newButton.Font = new Font("Arial", 9, FontStyle.Bold);
            newButton.FlatStyle = FlatStyle.Flat;
            newButton.FlatAppearance.BorderSize = 0;
            newButton.Margin = new Padding(1);
            newButton.Padding = new Padding(1);
            newButton.TextAlign = ContentAlignment.MiddleCenter;
            newButton.TextImageRelation = TextImageRelation.TextAboveImage;
            newButton.Location = new Point(col * (newButton.Width + 2), row * (newButton.Height + 2));
            newButton.Click += (sender, e) => MaterialButton_Click(nome, valorPorKg);

            panel.Controls.Add(newButton);
        }

        private Button? selectedButton = null;

        private void MaterialButton_Click(string nome, decimal valorPorKg)
        {
            // Remova a borda de qualquer botão selecionado anteriormente
            if (selectedButton != null)
            {
                selectedButton.FlatAppearance.BorderSize = 0;
                selectedButton.BackColor = Color.FromArgb(0, 140, 0);
            }

            // Atualiza os campos de texto com os valores
            txtNomematerial.Text = nome;
            txtValorkg.Text = valorPorKg.ToString("0.00");

            // Define a borda para o botão atualmente selecionado
            Button clickedButton = GetButtonByName(nome);
            if (clickedButton != null)
            {
                // Define a borda para o botão atualmente selecionado
                clickedButton.FlatAppearance.BorderSize = 1;
                clickedButton.FlatAppearance.BorderColor = Color.Lime;
                clickedButton.BackColor = Color.FromArgb(0, 40, 0);

                // Armazena o botão selecionado
                selectedButton = clickedButton;

                // Habilita o botão Excluir, pois um item está selecionado
                btnExcluir.Enabled = true;
            }
        }

        private Button? GetButtonByName(string nome)
        {
            foreach (Control control in btnsMateriais2.Controls)
            {
                if (control is Button button && button.Text == nome)
                {
                    return button;
                }
            }
            return null;
        }

        private void btnAddValor_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                // Extrair o valor do botão, remover o símbolo "R$" e converter para decimal
                decimal valorDoBotao = decimal.Parse(clickedButton.Text.Replace("+R$", "").Trim());

                // Verificar se o valor em txtValorkg pode ser convertido para decimal
                if (decimal.TryParse(txtValorkg.Text, out decimal valorAtual))
                {
                    // Armazenar o valor atual no histórico antes de atualizar
                    valueHistory.Add(valorAtual);

                    // Somar o valor do botão ao valor atual
                    decimal novoValor = valorAtual + valorDoBotao;

                    // Atualizar o campo txtValorkg com o novo valor formatado
                    txtValorkg.Text = novoValor.ToString("0.00");
                }
                else
                {
                    MessageBox.Show("Valor inválido em txtValorkg.");
                }
            }
        }

        private void btnCorrigir_Click(object sender, EventArgs e)
        {
            // Verificar se há valores no histórico
            if (valueHistory.Count > 0)
            {
                // Obter o último valor do histórico
                decimal ultimoValor = valueHistory[valueHistory.Count - 1];

                // Remover o último valor do histórico
                valueHistory.RemoveAt(valueHistory.Count - 1);

                // Atualizar o campo txtValorkg com o último valor
                txtValorkg.Text = ultimoValor.ToString("0.00");
            }
            else
            {
                //MessageBox.Show("Não há ações para desfazer.");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            // Define o valor de txtValorkg como 0.00
            txtValorkg.Text = "0,00";
        }


        private void ClearMaterialButtons(Panel panel)
        {
            panel.Controls.Clear();
        }

        // Dentro da classe FormAddMaterial
        //BOTÃO DE SALVAR VALOR DO MATERIAL//
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Extrai os valores dos campos de texto
            string novoNome = txtNomematerial.Text; // Novo nome que você deseja salvar
            decimal valorPorKg;

            if (decimal.TryParse(txtValorkg.Text, out valorPorKg))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Atualize o nome do material no banco de dados
                        string queryUpdateNome = "UPDATE materiais SET nome = @novoNome, valorporkg = @valorPorKg WHERE nome = @nome";
                        MySqlCommand commandUpdateNome = new MySqlCommand(queryUpdateNome, connection);
                        commandUpdateNome.Parameters.AddWithValue("@novoNome", novoNome);
                        commandUpdateNome.Parameters.AddWithValue("@valorPorKg", valorPorKg);
                        commandUpdateNome.Parameters.AddWithValue("@nome", selectedButton.Text); // Use o nome anteriormente selecionado

                        int rowsAffected = commandUpdateNome.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Atualização bem-sucedida, você pode mostrar uma mensagem de sucesso se desejar.
                        }
                        else
                        {
                            // Não houve registros atualizados, você pode mostrar uma mensagem de erro se desejar.
                        }

                        // Feche o formulário atual
                        //this.Close();

                        // Abre novamente o FormAddMaterial
                        //FormAddMaterial formAddMaterial = new FormAddMaterial();
                        //formAddMaterial.ShowDialog();

                        // Limpa os botões existentes antes de carregar novos botões
                        ClearMaterialButtons(btnsMateriais2);

                        // Carrega os novos botões
                        LoadMaterialButtons();


                    }
                    catch (Exception ex)
                    {
                        // Manipule exceções, como exibir uma mensagem de erro
                        MessageBox.Show("Erro ao salvar alterações: " + ex.Message);
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecione um material antes de salvar.");// Valor inválido em txtValorkg, você pode mostrar uma mensagem de erro se desejar.
            }
        }





        private void FormAddMaterial_FormClosed(object sender, FormClosedEventArgs e)
        {
            timerUpdateValues.Stop(); // Para o Timer ao fechar o formulário
        }
        private void timerUpdateValues_Tick(object sender, EventArgs e)
        {
            // Chame o método que atualiza os valores dos botões e do campo de texto
            UpdateMaterialValues();
        }
        private void UpdateMaterialValues()
        {
            // Atualize os valores dos botões
            LoadMaterialButtons();

            // Atualize o campo txtValorkg se um botão de material estiver selecionado
            if (!string.IsNullOrEmpty(txtNomematerial.Text))
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "SELECT valorporkg FROM materiais WHERE nome = @nome";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@nome", txtNomematerial.Text);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal valorPorKg = Convert.ToDecimal(result);
                            txtValorkg.Text = valorPorKg.ToString("0.00");
                        }
                        else
                        {
                            txtValorkg.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar valor: " + ex.Message);
                    }
                }
            }
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "Q";
        }
        private void btnW_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "W";
        }
        private void btnE_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "E";
        }
        private void btnR_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "R";
        }
        private void btnT_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "T";
        }
        private void btnY_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "Y";
        }
        private void btnU_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "U";
        }
        private void btnI_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "I";
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "O";
        }
        private void btnP_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "P";
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "A";
        }
        private void btnS_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "S";
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "D";
        }
        private void btnF_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "F";
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "G";
        }
        private void btnH_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "H";
        }
        private void btnJ_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "J";
        }
        private void btnK_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "K";
        }
        private void btnL_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "L";
        }
        private void btnÇ_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "Ç";
        }
        private void btnZ_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "Z";
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "X";
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "C";
        }
        private void btnV_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "V";
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "B";
        }
        private void btnN_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "N";
        }
        private void btnM_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "M";
        }


        private void btnSpace_Click_1(object sender, EventArgs e)
        {
            txtNomematerial.Text += " ";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string textoAtual = txtNomematerial.Text;

            if (!string.IsNullOrEmpty(textoAtual))
            {
                // Remove o último caractere do texto
                textoAtual = textoAtual.Substring(0, textoAtual.Length - 1);

                // Atualiza o texto no controle txtNomematerial
                txtNomematerial.Text = textoAtual;
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "0";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "4";
        }

        private void a_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "9";
        }

        private void txtNomematerial_Leave(object sender, EventArgs e)
        {
            // Obtém o texto atual do TextBox
            string texto = txtNomematerial.Text.Trim();

            // Verifica se o texto não está vazio
            if (!string.IsNullOrEmpty(texto))
            {
                // Divide o texto em palavras e formata a primeira letra de cada palavra para maiúscula
                string[] palavras = texto.Split(' ');
                for (int i = 0; i < palavras.Length; i++)
                {
                    if (!string.IsNullOrEmpty(palavras[i]))
                    {
                        char[] letras = palavras[i].ToCharArray();
                        letras[0] = char.ToUpper(letras[0]);
                        palavras[i] = new string(letras);
                    }
                }

                // Reconstroi o texto com as palavras formatadas
                string textoFormatado = string.Join(" ", palavras);

                // Define o texto formatado de volta no TextBox
                txtNomematerial.Text = textoFormatado;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text = "";
        }

        private void btnPonto_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += ".";
        }

        private void btnTraço_Click(object sender, EventArgs e)
        {
            txtNomematerial.Text += "-";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string novoNome = "zZ-EDITAR";
            decimal valorPorKg = 0.00m;
            string detalhes = "Sem descrição";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "INSERT INTO materiais (nome, valorporkg, detalhes) VALUES (@nome, @valorPorKg, @detalhes)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", novoNome);
                    command.Parameters.AddWithValue("@valorPorKg", valorPorKg);
                    command.Parameters.AddWithValue("@detalhes", detalhes);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Inserção bem-sucedida, você pode mostrar uma mensagem de sucesso se desejar.
                        //MessageBox.Show("Registro adicionado com sucesso!");
                    }
                    else
                    {
                        // Não houve registros adicionados, você pode mostrar uma mensagem de erro se desejar.
                        //MessageBox.Show("Erro ao adicionar registro.");
                    }
                }
                catch (Exception ex)
                {
                    // Manipule exceções, como exibir uma mensagem de erro
                    //MessageBox.Show("Erro ao adicionar registro: " + ex.Message);
                }
            }

            // Atualize os botões de materiais após a adição
            LoadMaterialButtons();


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se um material está selecionado
            if (selectedButton != null)
            {
                string nomeMaterialSelecionado = selectedButton.Text;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM materiais WHERE nome = @nome";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@nome", nomeMaterialSelecionado);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Remoção bem-sucedida, você pode mostrar uma mensagem de sucesso se desejar.
                            //MessageBox.Show("Registro excluído com sucesso!");

                            // Limpe os campos de texto
                            txtNomematerial.Text = "";
                            txtValorkg.Text = "";
                            // Feche o formulário atual
                            this.Close();

                            // Abre novamente o FormAddMaterial
                            FormAddMaterial formAddMaterial = new FormAddMaterial();
                            formAddMaterial.ShowDialog();

                        }
                        else
                        {
                            // Não houve registros excluídos, você pode mostrar uma mensagem de erro se desejar.
                            //MessageBox.Show("Erro ao excluir registro.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manipule exceções, como exibir uma mensagem de erro
                        //MessageBox.Show("Erro ao excluir registro: " + ex.Message);
                    }
                }
            }
            else
            {
                // Mostrar uma mensagem de aviso se nenhum material estiver selecionado
                //MessageBox.Show("Nenhum material selecionado. Selecione um material antes de excluir.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Fecha o formulário atual

            // Abre novamente o FormAddMaterial
            AIRKAlertaEdicaoMaterial formAlertMaterial = new AIRKAlertaEdicaoMaterial();
            formAlertMaterial.ShowDialog();
        }
    }
}

using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;

namespace airksucata
{
    public partial class formReimprimir : Form
    {
        public formReimprimir()
        {
            InitializeComponent();
        }

        private void formReimprimir_Load(object sender, EventArgs e)
        {
            // Nenhuma ação necessária quando o formulário é carregado
        }
        private void btn24h_Click_1(object sender, EventArgs e)
        {
            ConsultarRegistrosUltimosDias(1); // Consultar registros das últimas 24 horas
        }


        private void btn3d_Click(object sender, EventArgs e)
        {
            ConsultarRegistrosUltimosDias(3); // Consultar registros dos últimos 3 dias
        }

        private void btn7d_Click(object sender, EventArgs e)
        {
            ConsultarRegistrosUltimosDias(7); // Consultar registros dos últimos 7 dias
        }

        private void btn30d_Click(object sender, EventArgs e)
        {
            ConsultarRegistrosUltimosDias(30); // Consultar registros dos últimos 30 dias
        }
        private void btn60d_Click(object sender, EventArgs e)
        {
            ConsultarRegistrosUltimosDias(60); // Consultar registros dos últimos 30 dias
        }

        private void ConsultarRegistrosUltimosDias(int numeroDias)
        {
            imprimirPorRegistro.Items.Clear(); // Limpa o ListBox antes de adicionar novos itens

            try
            {
                string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Calcula a data/hora atual menos o número de dias especificado
                    DateTime limiteDiasAtras = DateTime.Now.AddDays(-numeroDias);

                    // Consulta SQL para obter os registros nos últimos dias
                    string query = "SELECT registro_id, dataHoraRegistro, total FROM registros WHERE dataHoraRegistro >= @limiteDiasAtras ORDER BY registro_id DESC";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@limiteDiasAtras", limiteDiasAtras);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int registroId = reader.GetInt32("registro_id");
                                decimal totalRegistro = reader.GetDecimal("total"); // Obtenha o valor exato do banco de dados
                                DateTime dataHoraRegistro = reader.GetDateTime("dataHoraRegistro");

                                // Formate o totalRegistro como "R$ 0,00"
                                string totalFormatado = totalRegistro.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

                                // Exiba os valores sem formatação
                                imprimirPorRegistro.Items.Add($"Registro: {registroId} | {dataHoraRegistro} | {totalFormatado}");
                            }
                        }
                    }




                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro ao consultar registros: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            txtNumRegistro.Text += "0";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            txtNumRegistro.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            txtNumRegistro.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            txtNumRegistro.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtNumRegistro.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            txtNumRegistro.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            txtNumRegistro.Text += "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            txtNumRegistro.Text += "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            txtNumRegistro.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            txtNumRegistro.Text += "9";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumRegistro.Text.Length > 0)
            {
                txtNumRegistro.Text = txtNumRegistro.Text.Substring(0, txtNumRegistro.Text.Length - 1);

                if (txtNumRegistro.Text.Length == 0)
                {
                    txtNumRegistro.Text = ""; // Se o campo estiver vazio, defina como valor inicial
                }
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            string numRegistro = txtNumRegistro.Text.Trim(); // Obtém o valor do txtNumRegistro

            if (!string.IsNullOrEmpty(numRegistro))
            {
                // Limpa o listBox antes de adicionar novos itens
                imprimirPorRegistro.Items.Clear();

                try
                {
                    string connectionString = "Server=localhost;Database=xlata_db;Uid=root;Pwd=;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        // Consulta SQL para obter os registros correspondentes ao numRegistro
                        string query = "SELECT registro_id, dataHoraRegistro, total FROM registros WHERE registro_id = @numRegistro";

                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@numRegistro", numRegistro);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                bool encontrouRegistros = false;

                                while (reader.Read())
                                {
                                    int registroId = reader.GetInt32("registro_id");
                                    decimal totalRegistro = reader.GetDecimal("total"); // Obtenha o valor exato do banco de dados
                                    DateTime dataHoraRegistro = reader.GetDateTime("dataHoraRegistro");
                                    // Formate o totalRegistro como "R$ 0,00"
                                    string totalFormatado = totalRegistro.ToString("C", CultureInfo.GetCultureInfo("pt-BR"));

                                    imprimirPorRegistro.Items.Add($"Registro: {registroId} | {dataHoraRegistro} | {totalFormatado}");
                                }

                                if (!encontrouRegistros)
                                {
                                    //imprimirPorRegistro.Items.Add("Nenhum registro encontrado.");
                                }
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Erro ao consultar registros: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Digite um número de registro válido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imprimirPorRegistro_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifique se há um item selecionado no listbox
            if (imprimirPorRegistro.SelectedIndex != -1)
            {
                btnViewPrint.Enabled = true; // Habilite o botão se houver um item selecionado
            }
            else
            {
                btnViewPrint.Enabled = false; // Desabilite o botão se nenhum item estiver selecionado
            }
        }
        private int ObterNumeroRegistroSelecionado()
        {
            if (imprimirPorRegistro.SelectedItem != null)
            {
                string selectedItemText = imprimirPorRegistro.SelectedItem.ToString();

                // Divida a string pelo caractere '|' para obter a parte que contém o número de registro
                string[] parts = selectedItemText.Split('|');
                if (parts.Length >= 1)
                {
                    string numeroRegistroString = parts[0].Trim();
                    // Agora, extraia apenas os dígitos da string
                    string digitString = new string(numeroRegistroString.Where(char.IsDigit).ToArray());
                    int numeroRegistro;
                    if (int.TryParse(digitString, out numeroRegistro))
                    {
                        return numeroRegistro;
                    }
                }
            }
            return -1; // Valor padrão caso não seja possível obter o número de registro
        }



        private void btnViewPrint_Click(object sender, EventArgs e)
        {
            // Obtenha o "registro_id" do item selecionado no ListBox
            int numeroRegistroSelecionado = ObterNumeroRegistroSelecionado();

            if (numeroRegistroSelecionado != -1)
            {
                // Abra o formComprovanteRelatorio passando o "registro_id"
                formComprovanteRelatorio formRelatorio = new formComprovanteRelatorio(numeroRegistroSelecionado);
                formRelatorio.Show();
            }
            else
            {
                MessageBox.Show("Selecione um item na lista!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}

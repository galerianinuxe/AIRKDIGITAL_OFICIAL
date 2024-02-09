﻿using System.Globalization;

namespace airksucata
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();

        }

        private void acessar_Click(object sender, EventArgs e)
        {
            string username = txtUser2.Text;
            string password = txtPass.Text;

            if (ValidateCredentials(username, password))
            {
                // Login bem-sucedido
                // Fechar o formulário de login
                //this.Close();

                // Abrir o formulário do sistema
                formSistema sistema = new formSistema();
                sistema.ShowDialog(); // Exibir o formulário de sistema como uma janela modal
            }
            else
            {
                MessageBox.Show("Dados incorretos");
            }
        }


        private bool ValidateCredentials(string username, string password)
        {
            string filePath = username + ".arq";
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    if (lines.Length == 1)
                    {
                        string[] parts = lines[0].Split(new[] { ',' }, StringSplitOptions.TrimEntries);

                        if (parts.Length == 2)
                        {
                            string storedUsername = parts[0];
                            string storedPassword = parts[1];

                            // Use o seguinte trecho para depuração
                            Console.WriteLine("Stored Username: " + storedUsername);
                            Console.WriteLine("Stored Password: " + storedPassword);
                            Console.WriteLine("Entered Password: " + password);

                            if (password == storedPassword)
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro ao validar credenciais: " + ex.Message);
                }
            }

            return false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            formCadastro cadastroForm = new formCadastro(); // Substitua "CadastroForm" pelo nome real do formulário de cadastro
            cadastroForm.ShowDialog(); // Exibir o formulário de cadastro como uma janela modal
        }

        private void fecharTudo_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Close();
            }


            // Encerrar threads ou tarefas em execução
            // Encerrar conexões de banco de dados
            // Limpar recursos personalizados
            // Limpar objetos não gerenciados

            Application.Exit(); // Encerrar o aplicativo completamente
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                Application.OpenForms[i].Close();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPass.Text += "8";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtPass.Text += "7";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtPass.Text += "6";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtPass.Text += "5";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtPass.Text += "4";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            txtPass.Text += "3";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            txtPass.Text += "2";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            txtPass.Text += "1";
        }



        public void atualizarPass()
        {
            // Limpar campos

            txtPass.Text = "";

        }
        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            atualizarPass();
            // Realiza a verificação
            // Caso contrário, mantém lbAcesso invisível
            lbAcesso.Visible = false;
            lbAguardando.Visible = true;

        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            // Adiciona o texto ao txtPass
            txtPass.Text += "airkdigital-wpp:11952785087-direitosreservados-marcaregistrada";

            // Realiza a verificação
            VerificarAcesso();
        }

        private void VerificarAcesso()
        {
            // Caminho do arquivo
            string caminhoArquivo = "acrcomercial.arq";

            try
            {
                // Lê o conteúdo do arquivo
                string conteudoArquivo = File.ReadAllText(caminhoArquivo);

                // Verifica se o conteúdo de txtPass está presente no conteúdo do arquivo
                if (conteudoArquivo.Contains(txtPass.Text))
                {
                    // Se a verificação for bem-sucedida, torna lbAcesso visível
                    lbAcesso.Visible = true;
                    lbAguardando.Visible = false;
                }
                else
                {
                    // Caso contrário, mantém lbAcesso invisível
                    lbAcesso.Visible = false;
                    lbAguardando.Visible = true;

                }
            }
            catch (Exception ex)
            {
                // Trate exceções, se necessário
                //MessageBox.Show("FALTOU LG >>>>: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("PERÍODO DE TESTE OU PLANO EXPIRADO.\nCHAME O DESENVOLVEDOR ATRAVÉS\nDO WHATSAPP: (11) 96351-2105");
            }
        }

        private void formLogin_Load(object sender, EventArgs e)
        {
            VerificarExclusaoArquivos7dias();
            VerificarExclusaoArquivos35dias();
        }
        private void VerificarExclusaoArquivos7dias()
        {
            try
            {
                string[] arquivos = Directory.GetFiles(Directory.GetCurrentDirectory(), "date30d_*.arq");

                foreach (string arquivo in arquivos)
                {
                    string nomeArquivo = Path.GetFileNameWithoutExtension(arquivo);
                    string dataPart = nomeArquivo.Substring(nomeArquivo.IndexOf("_") + 1);

                    if (DateTime.TryParseExact(dataPart, "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataArquivo))
                    {
                        TimeSpan diferencaTempo = DateTime.Now - dataArquivo;
                        int diasRestantes = (int)(7 - diferencaTempo.TotalDays);

                        if (diasRestantes <= 3)
                        {
                            // Aviso: Seu plano vence em 5 dias
                            MessageBox.Show($"SEU PERÍODO DE TESTE VAI VENCER\nEM MENOS DE 3 DIAS.");
                        }

                        if (diferencaTempo.TotalDays > 7)
                        {
                            // Excluir todos os arquivos com a extensão ".arq"
                            string[] arquivosParaExcluir = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.arq");

                            foreach (string arquivoParaExcluir in arquivosParaExcluir)
                            {
                                File.Delete(arquivoParaExcluir);
                                Console.WriteLine($"Arquivo {arquivoParaExcluir} excluído. Tempo decorrido: {diferencaTempo.TotalSeconds} segundos.");
                                MessageBox.Show("PERÍODO DE TESTE OU PLANO EXPIRADO.\nCHAME O DESENVOLVEDOR ATRAVÉS\nDO WHATSAPP: (11) 96351-2105");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Arquivo {arquivo} não foi excluído. Tempo decorrido: {diferencaTempo.TotalHours} horas.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar e excluir arquivos: {ex.Message}");
            }
        }

        private void VerificarExclusaoArquivos35dias()
        {
            try
            {
                string[] arquivos = Directory.GetFiles(Directory.GetCurrentDirectory(), "date30d_*.arq");

                foreach (string arquivo in arquivos)
                {
                    string nomeArquivo = Path.GetFileNameWithoutExtension(arquivo);
                    string dataPart = nomeArquivo.Substring(nomeArquivo.IndexOf("_") + 1);

                    if (DateTime.TryParseExact(dataPart, "yyyyMMddHHmmss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataArquivo))
                    {
                        TimeSpan diferencaTempo = DateTime.Now - dataArquivo;
                        int diasRestantes = (int)(35 - diferencaTempo.TotalDays);

                        if (diasRestantes <= 5)
                        {
                            // Aviso: Seu plano vence em 5 dias
                            MessageBox.Show($"SEU PERÍODO MENSAL VAI VENCER\nEM MENOS DE 5 DIAS.");
                        }

                        if (diferencaTempo.TotalDays > 35)
                        {
                            // Excluir todos os arquivos com a extensão ".arq"
                            string[] arquivosParaExcluir = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.arq");

                            foreach (string arquivoParaExcluir in arquivosParaExcluir)
                            {
                                File.Delete(arquivoParaExcluir);
                                Console.WriteLine($"Arquivo {arquivoParaExcluir} excluído. Tempo decorrido: {diferencaTempo.TotalSeconds} segundos.");
                                MessageBox.Show("PERÍODO DE TESTE OU PLANO EXPIRADO.\nCHAME O DESENVOLVEDOR ATRAVÉS\nDO WHATSAPP: (11) 96351-2105");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Arquivo {arquivo} não foi excluído. Tempo decorrido: {diferencaTempo.TotalHours} horas.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao verificar e excluir arquivos: {ex.Message}");
            }
        }

    }
}
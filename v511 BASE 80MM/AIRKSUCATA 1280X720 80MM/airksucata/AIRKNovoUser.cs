namespace airksucata
{
    public partial class formCadastro : Form
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string novoUsuario = txtNovoUser.Text;
            string novaSenha = txtNovaSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (!string.IsNullOrEmpty(novoUsuario) && !string.IsNullOrEmpty(novaSenha) && novaSenha == confirmarSenha)
            {
                if (CadastrarUsuario(novoUsuario, novaSenha))
                {
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    SalvarUsuarioEmArquivo(novoUsuario, novaSenha); // Salvar usuário em um arquivo .txt
                    Close(); // Fechar o formulário após o cadastro
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o usuário.");
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome de usuário, a senha e confirme a senha corretamente.");
            }
        }

        private bool CadastrarUsuario(string username, string password)
        {
            // Código para cadastrar no banco de dados ou fazer outras ações de cadastro
            return true;
        }

        private void SalvarUsuarioEmArquivo(string username, string password)
        {
            // Especifique o caminho completo onde deseja salvar o arquivo
            string filePath = "login.user";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine(username + "," + " " + password);
                }

                MessageBox.Show("Usuário salvo em: " + filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao salvar usuário em arquivo: " + ex.Message);
            }
        }







        private void btnTeste_Click(object sender, EventArgs e) //GERA TESTE DE 7 DIAS
        {
            string novoUsuario = txtNovoUser.Text;
            string novaSenha = txtNovaSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (!string.IsNullOrEmpty(novoUsuario) && !string.IsNullOrEmpty(novaSenha) && novaSenha == confirmarSenha)
            {
                if (CadastrarUsuarioTeste(novoUsuario, novaSenha))
                {
                    MessageBox.Show("Teste cadastrado com sucesso!");
                    SalvarUsuarioEmArquivo(novoUsuario, novaSenha); // Salvar usuário em um arquivo .txt
                    CriarNovoArquivoComDataHoraAtual7Dias(); // Criar novo arquivo com data e hora atual
                    Close(); // Fechar o formulário após o cadastro
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o usuário.");
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome de usuário, a senha e confirme a senha corretamente.");
            }
        }

        private void btnTeste30d_Click(object sender, EventArgs e) //GERA TESTE DE 30 DIAS
        {
            string novoUsuario = txtNovoUser.Text;
            string novaSenha = txtNovaSenha.Text;
            string confirmarSenha = txtConfirmarSenha.Text;

            if (!string.IsNullOrEmpty(novoUsuario) && !string.IsNullOrEmpty(novaSenha) && novaSenha == confirmarSenha)
            {
                if (CadastrarUsuarioTeste(novoUsuario, novaSenha))
                {
                    MessageBox.Show("Teste cadastrado com sucesso!");
                    SalvarUsuarioEmArquivo(novoUsuario, novaSenha); // Salvar usuário em um arquivo .txt
                    CriarNovoArquivoComDataHoraAtual30Dias(); // Criar novo arquivo com data e hora atual
                    Close(); // Fechar o formulário após o cadastro
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o usuário.");
                }
            }
            else
            {
                MessageBox.Show("Preencha o nome de usuário, a senha e confirme a senha corretamente.");
            }
        }
        private void CriarNovoArquivoComDataHoraAtual30Dias()
        {
            string dataHoraAtual = DateTime.Now.ToString("yyyyMMddHHmmss");
            string novoArquivoPath = $"date30d_{dataHoraAtual}.arq";

            try
            {
                using (StreamWriter writer = new StreamWriter(novoArquivoPath))
                {
                    writer.WriteLine("Conteúdo criptografado.");
                }

                MessageBox.Show($"Novo arquivo criado em: {novoArquivoPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar novo arquivo: {ex.Message}");
            }
        }

        private void CriarNovoArquivoComDataHoraAtual7Dias()
        {
            string dataHoraAtual = DateTime.Now.ToString("yyyyMMddHHmmss");
            string novoArquivoPath = $"date7d_{dataHoraAtual}.arq";

            try
            {
                using (StreamWriter writer = new StreamWriter(novoArquivoPath))
                {
                    writer.WriteLine("Conteúdo criptografado.");
                }

                MessageBox.Show($"Novo arquivo criado em: {novoArquivoPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao criar novo arquivo: {ex.Message}");
            }
        }

        private bool CadastrarUsuarioTeste(string username, string password)
        {
            // Código para cadastrar no banco de dados ou fazer outras ações de cadastro
            return true;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace AIRKFormInicio
{
    public partial class AIRKAjusteDados : Form
    {
        public AIRKAjusteDados()
        {
            InitializeComponent();
        }

        private void btnImgPrincipal_Click(object sender, EventArgs e)
        {
            // Cria um novo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Define os filtros para o tipo de arquivo que pode ser selecionado (por exemplo, imagens)
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";

            // Verifica se o usuário selecionou um arquivo e se clicou em OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtém o caminho do arquivo selecionado
                    string caminhoDaImagem = openFileDialog.FileName;

                    // Exibe a imagem no PictureBox
                    picImgPrincipal.Image = new System.Drawing.Bitmap(caminhoDaImagem);
                }
                catch (Exception ex)
                {
                    // Exibe uma mensagem de erro caso ocorra algum problema ao carregar a imagem
                    MessageBox.Show("Ocorreu um erro ao carregar a imagem: " + ex.Message);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Salvar a imagem
                SalvarImagem();

                //Salvar imagem comprovante
                SalvarImagemComprovante();

                //Salvar imagem relatorio
                SalvarImagemRelatorios();

                // Salvar o valor do txtNomeEmpresa
                SalvarTexto(txtNomeEmpresa.Text, "nomeEmpresa.txt");

                // Salvar o valor do txtUltimoUpdate
                SalvarTexto(txtUltimoUpdate.Text, "ultimoUpdate.airk");

                // Salvar o valor do txtVersion
                SalvarTexto(txtVersion.Text, "version.airk");

                // Salvar o valor do txtContato
                SalvarDadosComprovante(txtContato.Text, "contato.ink");

                // Salvar o valor do txtLocal
                SalvarDadosComprovante(txtLocal.Text, "local.ink");

                // Salvar o valor do txtContato
                SalvarDadosComprovanteVisual(txtContato.Text, "contatoEmpresa.txt");

                // Salvar o valor do txtLocal
                SalvarDadosComprovanteVisual(txtLocal.Text, "localEmpresa.txt");

                // Salvar o valor do txtLocal
                SalvarDadosComprovanteVisual(txtNomeEmpresa.Text, "nomeEmpresa.txt");

                // Exibir mensagem de sucesso
                MessageBox.Show("Dados salvos com sucesso.");
            }
            catch (Exception ex)
            {
                // Exibir mensagem de erro
                MessageBox.Show("Ocorreu um erro ao salvar os dados: " + ex.Message);
            }
        }

        private void SalvarImagem()
        {
            if (picImgPrincipal.Image != null)
            {
                string pastaBase = Path.Combine(Application.StartupPath, "baseGeral");
                string pastaAjustes = Path.Combine(pastaBase, "ajustesGerais");
                string caminhoArquivo = Path.Combine(pastaAjustes, "logoPrincipal.png");

                if (!Directory.Exists(pastaAjustes))
                {
                    Directory.CreateDirectory(pastaAjustes);
                }

                using (Bitmap imagem = new Bitmap(picImgPrincipal.Image))
                {
                    imagem.Save(caminhoArquivo, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            else
            {
                MessageBox.Show("Não há imagem para salvar.");
            }
        }

        private void SalvarImagemComprovante()
        {
            if (picImgPrincipal.Image != null)
            {
                string pastaBase = Path.Combine(Application.StartupPath, "baseGeral");
                string pastaAjustes = Path.Combine(pastaBase, "dadosComprovanteVisual");
                string caminhoArquivo = Path.Combine(pastaAjustes, "logoComprovante.png");

                if (!Directory.Exists(pastaAjustes))
                {
                    Directory.CreateDirectory(pastaAjustes);
                }

                using (Bitmap imagem = new Bitmap(picImgComprovante.Image))
                {
                    imagem.Save(caminhoArquivo, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            else
            {
                MessageBox.Show("Não há imagem para salvar.");
            }
        }

        private void SalvarImagemRelatorios()
        {
            if (picImgPrincipal.Image != null)
            {
                string pastaBase = Path.Combine(Application.StartupPath, "baseGeral");
                string caminhoArquivo = Path.Combine(pastaBase, "logoRelatorio.png");

                if (!Directory.Exists(pastaBase))
                {
                    Directory.CreateDirectory(pastaBase);
                }

                using (Bitmap imagem = new Bitmap(picImgComprovante.Image))
                {
                    imagem.Save(caminhoArquivo, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            else
            {
                MessageBox.Show("Não há imagem para salvar.");
            }
        }




        private void SalvarTexto(string texto, string nomeArquivo)
        {
            string caminhoArquivo = Path.Combine(Application.StartupPath, "baseGeral", "ajustesGerais", nomeArquivo);
            File.WriteAllText(caminhoArquivo, texto);

        }

        private void SalvarDadosComprovante(string texto, string nomeArquivo)
        {

            string caminhoDadosComprovanteFisico = Path.Combine(Application.StartupPath, "baseGeral", "dadosComprovante", nomeArquivo);
            File.WriteAllText(caminhoDadosComprovanteFisico, texto);
        }

        private void SalvarDadosComprovanteVisual(string texto, string nomeArquivo)
        {

            string caminhoDadosComprovanteVisual = Path.Combine(Application.StartupPath, "baseGeral", "dadosComprovanteVisual", nomeArquivo);
            File.WriteAllText(caminhoDadosComprovanteVisual, texto);
        }

        private void AIRKAjusteDados_Load(object sender, EventArgs e)
        {
            try
            {
                string pastaBase = Path.Combine(Application.StartupPath, "baseGeral");
                string pastaAjustes = Path.Combine(pastaBase, "ajustesGerais");
                string pastaComprovanteFisico = Path.Combine(pastaBase, "dadosComprovante");
                string pastaComprovanteVisual = Path.Combine(pastaBase, "dadosComprovanteVisual");

                // Verifica se a pasta baseGeral/ajustesGerais existe
                if (Directory.Exists(pastaAjustes))
                {
                    // Carrega a imagem se o arquivo logoPrincipal.png existir
                    //string caminhoLogo = Path.Combine(pastaAjustes, "logoPrincipal.png");
                    //if (File.Exists(caminhoLogo))
                    //{
                    //    picImgPrincipal.Image = Image.FromFile(caminhoLogo);
                    //}

                    // Carrega o texto se o arquivo nomeEmpresa.txt existir
                    string caminhoNomeEmpresa = Path.Combine(pastaAjustes, "nomeEmpresa.txt");
                    if (File.Exists(caminhoNomeEmpresa))
                    {
                        txtNomeEmpresa.Text = File.ReadAllText(caminhoNomeEmpresa);
                    }

                    // Carrega o texto se o arquivo ultimoUpdate.airk existir
                    string caminhoUltimoUpdate = Path.Combine(pastaAjustes, "ultimoUpdate.airk");
                    if (File.Exists(caminhoUltimoUpdate))
                    {
                        txtUltimoUpdate.Text = File.ReadAllText(caminhoUltimoUpdate);
                    }

                    // Carrega o texto se o arquivo version.airk existir
                    string caminhoVersion = Path.Combine(pastaAjustes, "version.airk");
                    if (File.Exists(caminhoVersion))
                    {
                        txtVersion.Text = File.ReadAllText(caminhoVersion);
                    }

                    // Carrega o texto se o arquivo contato.inks existir
                    string caminhoDadosComprovanteFisico = Path.Combine(pastaComprovanteFisico, "contato.ink");
                    if (File.Exists(caminhoDadosComprovanteFisico))
                    {
                        txtContato.Text = File.ReadAllText(caminhoDadosComprovanteFisico);
                    }
                    // Carrega o texto se o arquivo local.inks existir
                    string caminhoContato = Path.Combine(pastaComprovanteFisico, "local.ink");
                    if (File.Exists(caminhoContato))
                    {
                        txtLocal.Text = File.ReadAllText(caminhoContato);
                    }

                    // Carrega o texto se o arquivo contatoEmpresa.txt existir
                    string caminhoDadosComprovanteVisual = Path.Combine(pastaComprovanteVisual, "contatoEmpresa.txt");
                    if (File.Exists(caminhoDadosComprovanteVisual))
                    {
                        txtContato.Text = File.ReadAllText(caminhoDadosComprovanteVisual);
                    }
                }
                else
                {
                    // Exibe uma mensagem se a pasta não existir
                    MessageBox.Show("A pasta não existe.");
                }
            }
            catch (Exception ex)
            {
                // Exibe uma mensagem de erro caso ocorra algum problema ao carregar os dados
                MessageBox.Show("Ocorreu um erro ao carregar os dados: " + ex.Message);
            }
        }

        private void btnImgComprovante_Click(object sender, EventArgs e)
        {
            // Cria um novo OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Define os filtros para o tipo de arquivo que pode ser selecionado (por exemplo, imagens)
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos os Arquivos|*.*";

            // Verifica se o usuário selecionou um arquivo e se clicou em OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Obtém o caminho do arquivo selecionado
                    string caminhoDaImagem = openFileDialog.FileName;

                    // Exibe a imagem no PictureBox
                    picImgComprovante.Image = new System.Drawing.Bitmap(caminhoDaImagem);
                }
                catch (Exception ex)
                {
                    // Exibe uma mensagem de erro caso ocorra algum problema ao carregar a imagem
                    MessageBox.Show("Ocorreu um erro ao carregar a imagem: " + ex.Message);
                }
            }
        }

        private void btnCopiarTudo_Click(object sender, EventArgs e)
        {
            try
            {
                string pastaBaseGeral = Path.Combine(Application.StartupPath, "baseGeral");

                if (!Directory.Exists(pastaBaseGeral))
                {
                    MessageBox.Show("A pasta baseGeral não existe.");
                    return;
                }

                // Abre o Windows Explorer na pasta baseGeral
                Process.Start("explorer.exe", pastaBaseGeral);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao abrir a pasta baseGeral: " + ex.Message);
            }
        }
    }
}

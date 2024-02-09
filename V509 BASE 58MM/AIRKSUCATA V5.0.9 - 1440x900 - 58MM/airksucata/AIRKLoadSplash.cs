namespace airksucata
{
    public partial class AIRKLoadSplash : Form
    {
        private List<string> frases = new List<string>
{
    "\"Acredite em você e em seu poder de realizar\".",
    "\"Supere obstáculos e conquiste vitórias\".",
    "\"Mantenha-se firme, mesmo quando parecer impossível\".",
    "\"Sonhe grande e alcance ainda mais alto\".",
    "\"Seja a mudança que deseja ver no mundo\".",
    "\"A persistência é a chave do sucesso\".",
    "\"Nunca desista, não importa o que aconteça\".",
    "\"Cada dia é uma nova oportunidade\".",
    "\"Faça hoje o que os outros não querem fazer\".",
    "\"A paixão é o combustível do sucesso\".",
    "\"O futuro pertence aos que acreditam em seus sonhos\".",
    "\"Transforme desafios em oportunidades\".",
    "\"Grandes conquistas começam com pequenas ações\".",
    "\"Acredite na magia de seus próprios sonhos\".",
    "\"Visualize seu sucesso e torne-o realidade\".",
    "\"Celebre suas vitórias, por menores que sejam\".",
    "\"Siga seu coração, ele conhece o caminho\".",
    "\"Cultive uma mentalidade positiva\".",
    "\"Encontre a alegria na jornada da vida\".",
    "\"O sucesso começa fora da zona de conforto\".",
    "\"Nunca é tarde demais para começar de novo\".",
    "\"A ação é o primeiro passo em direção ao sucesso\".",
    "\"Seja gentil, porque a gentileza nunca sai de moda\".",
    "\"Cada dia é uma dádiva, aproveite ao máximo\".",
    "\"A gratidão transforma o que temos em suficiente\".",
    "\"Inspire-se na beleza do mundo que o rodeia\".",
    "\"A felicidade está nas coisas simples da vida\".",
    "\"O conhecimento é a chave para a compreensão\".",
    "\"Aprenda com o passado e foque no presente\".",
    "\"A evolução é o resultado de desafios superados\".",
    "\"Você é mais forte do que imagina\".",
    "\"Mantenha-se fiel aos seus princípios\".",
    "\"Cada fracasso é uma lição valiosa\".",
    "\"O amor é a força mais poderosa do universo\".",
    "\"A empatia constrói conexões verdadeiras\".",
    "\"Aceite as mudanças como oportunidades\".",
    "\"A humildade é a base da grandeza\".",
    "\"O equilíbrio é essencial para uma vida plena\".",
    "\"A jornada é tão importante quanto o destino\".",
    "\"A confiança em si mesmo é a chave para tudo\".",
    "\"O poder da mente é ilimitado\".",
    "\"Seja grato pelo que você é e pelo que tem\".",
    "\"A simplicidade é a essência da vida feliz\".",
    "\"Aprenda com as críticas, mas não deixe que o afetem\".",
    "\"O sucesso não tem limites, vá além\".",
    "\"A excelência é uma busca constante\".",
    "\"Você é o autor da sua história\".",
    "\"Aprenda com o presente, planeje o futuro\".",
    "\"A perseverança é o segredo de todo sucesso\".",
    "\"A compaixão torna o mundo mais bonito\".",
    "\"A motivação vem de dentro de você\".",
    "\"Aja com integridade em tudo que faz\".",
    "\"O amor próprio é a base de tudo\".",
    "\"A amizade é um tesouro precioso\".",
    "\"A simplicidade é a chave da felicidade\".",
    "\"O respeito é a base de todos os relacionamentos\".",
    "\"O perdão liberta o coração\".",
    "\"O sucesso é construído com esforço e dedicação\".",
    "\"A criatividade é a alma da inovação\".",
    "\"O sorriso é o seu melhor acessório\".",
    "\"A paciência é uma virtude valiosa\".",
    "\"A natureza é uma fonte de inspiração infinita\".",
    "\"A honestidade é a melhor política\".",
    "\"O conhecimento é a chave para a liberdade\".",
    "\"A compreensão é a base de toda a harmonia\".",
    "\"A gratidão é o caminho para a felicidade\".",
    "\"A perseverança leva à conquista\".",
    "\"A coragem é a força que supera o medo\".",
    "\"A esperança é a luz que guia o caminho\".",
    "\"A fé move montanhas\".",
    "\"A determinação é a chave para o sucesso\".",
    "\"A sabedoria vem da experiência\".",
    "\"A autenticidade é a sua marca registrada\".",
    "\"A confiança é o alicerce de todos os relacionamentos\".",
    "\"A solidariedade é a força que une as pessoas\".",
    "\"A gentileza é uma linguagem universal\".",
    "\"A resiliência é a capacidade de se adaptar e crescer\".",
    "\"A sinceridade é o vínculo da verdade\".",
    "\"A responsabilidade é o caminho da maturidade\".",
    "\"A liberdade é o direito de ser você mesmo\".",
    "\"A igualdade é o princípio de um mundo melhor\".",
    "\"A justiça é a base da sociedade\".",
    "\"A bondade é um presente que pode ser compartilhado\".",
    "\"A emulação é a busca da excelência\".",
    "\"A curiosidade é o desejo de aprender e crescer\".",
    "\"A ambição é a busca do seu potencial máximo\".",
    "\"A perseverança é a chave para vencer desafios\".",
    "\"A criatividade é a expressão da alma\".",
    "\"A determinação é o combustível da conquista\".",
    "\"A gratidão é a chave da felicidade\".",
    "\"A paciência é a virtude da sabedoria\".",
    "\"A compaixão é o alicerce da empatia\".",
    "\"A generosidade é a essência da humanidade\".",
    "\"A tolerância é o respeito pelas diferenças\".",
    "\"A humildade é a base do crescimento\".",
    "\"A autoconfiança é o segredo do sucesso\".",
    "\"A ousadia é o primeiro passo em direção aos sonhos\".",
    "\"A liberdade é o direito de ser você mesmo\".",
    "\"A coragem é a força que supera o medo\".",
    "\"A fé é a luz que guia o caminho\"."
};


        private int fraseIndex = 0;
        private string indiceFilePath = "fraseIndex.txt";

        public AIRKLoadSplash()
        {
            InitializeComponent();

            // Centralizar o label no form
            labelFrase.Anchor = AnchorStyles.None;
            //labelFrase.MaximumSize = new Size(550, 0); // Defina a largura máxima desejada, como 550 (ajuste conforme necessário)

            // Ler o índice da última frase exibida a partir do arquivo
            if (File.Exists(indiceFilePath))
            {
                int.TryParse(File.ReadAllText(indiceFilePath), out fraseIndex);
            }

            // Iniciar o timer
            timer1.Start();

            // Exibir a próxima frase ao abrir o formulário
            ExibirProximaFrase();
        }

        private void ExibirProximaFrase()
        {
            if (fraseIndex < frases.Count)
            {
                labelFrase.Text = frases[fraseIndex];
                fraseIndex++;
            }
            else
            {
                // Todas as frases foram exibidas, volte para a primeira
                fraseIndex = 0;
                labelFrase.Text = frases[fraseIndex];
                fraseIndex++;
            }

            // Salvar o índice da frase atual no arquivo
            File.WriteAllText(indiceFilePath, fraseIndex.ToString());
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //MessageBox.Show("Evento Tick disparado!");
            panel2.Width += 2;
            if (panel2.Width >= 629)
            {
                timer1.Stop();
                formLogin login = new formLogin();
                login.Show();
                this.Hide();
            }
        }
    }
}

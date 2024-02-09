namespace airksucata
{
    public partial class AIRKLoadSplash : Form
    {
        private List<string> frases = new List<string>
{
    "\"Acredite em voc� e em seu poder de realizar\".",
    "\"Supere obst�culos e conquiste vit�rias\".",
    "\"Mantenha-se firme, mesmo quando parecer imposs�vel\".",
    "\"Sonhe grande e alcance ainda mais alto\".",
    "\"Seja a mudan�a que deseja ver no mundo\".",
    "\"A persist�ncia � a chave do sucesso\".",
    "\"Nunca desista, n�o importa o que aconte�a\".",
    "\"Cada dia � uma nova oportunidade\".",
    "\"Fa�a hoje o que os outros n�o querem fazer\".",
    "\"A paix�o � o combust�vel do sucesso\".",
    "\"O futuro pertence aos que acreditam em seus sonhos\".",
    "\"Transforme desafios em oportunidades\".",
    "\"Grandes conquistas come�am com pequenas a��es\".",
    "\"Acredite na magia de seus pr�prios sonhos\".",
    "\"Visualize seu sucesso e torne-o realidade\".",
    "\"Celebre suas vit�rias, por menores que sejam\".",
    "\"Siga seu cora��o, ele conhece o caminho\".",
    "\"Cultive uma mentalidade positiva\".",
    "\"Encontre a alegria na jornada da vida\".",
    "\"O sucesso come�a fora da zona de conforto\".",
    "\"Nunca � tarde demais para come�ar de novo\".",
    "\"A a��o � o primeiro passo em dire��o ao sucesso\".",
    "\"Seja gentil, porque a gentileza nunca sai de moda\".",
    "\"Cada dia � uma d�diva, aproveite ao m�ximo\".",
    "\"A gratid�o transforma o que temos em suficiente\".",
    "\"Inspire-se na beleza do mundo que o rodeia\".",
    "\"A felicidade est� nas coisas simples da vida\".",
    "\"O conhecimento � a chave para a compreens�o\".",
    "\"Aprenda com o passado e foque no presente\".",
    "\"A evolu��o � o resultado de desafios superados\".",
    "\"Voc� � mais forte do que imagina\".",
    "\"Mantenha-se fiel aos seus princ�pios\".",
    "\"Cada fracasso � uma li��o valiosa\".",
    "\"O amor � a for�a mais poderosa do universo\".",
    "\"A empatia constr�i conex�es verdadeiras\".",
    "\"Aceite as mudan�as como oportunidades\".",
    "\"A humildade � a base da grandeza\".",
    "\"O equil�brio � essencial para uma vida plena\".",
    "\"A jornada � t�o importante quanto o destino\".",
    "\"A confian�a em si mesmo � a chave para tudo\".",
    "\"O poder da mente � ilimitado\".",
    "\"Seja grato pelo que voc� � e pelo que tem\".",
    "\"A simplicidade � a ess�ncia da vida feliz\".",
    "\"Aprenda com as cr�ticas, mas n�o deixe que o afetem\".",
    "\"O sucesso n�o tem limites, v� al�m\".",
    "\"A excel�ncia � uma busca constante\".",
    "\"Voc� � o autor da sua hist�ria\".",
    "\"Aprenda com o presente, planeje o futuro\".",
    "\"A perseveran�a � o segredo de todo sucesso\".",
    "\"A compaix�o torna o mundo mais bonito\".",
    "\"A motiva��o vem de dentro de voc�\".",
    "\"Aja com integridade em tudo que faz\".",
    "\"O amor pr�prio � a base de tudo\".",
    "\"A amizade � um tesouro precioso\".",
    "\"A simplicidade � a chave da felicidade\".",
    "\"O respeito � a base de todos os relacionamentos\".",
    "\"O perd�o liberta o cora��o\".",
    "\"O sucesso � constru�do com esfor�o e dedica��o\".",
    "\"A criatividade � a alma da inova��o\".",
    "\"O sorriso � o seu melhor acess�rio\".",
    "\"A paci�ncia � uma virtude valiosa\".",
    "\"A natureza � uma fonte de inspira��o infinita\".",
    "\"A honestidade � a melhor pol�tica\".",
    "\"O conhecimento � a chave para a liberdade\".",
    "\"A compreens�o � a base de toda a harmonia\".",
    "\"A gratid�o � o caminho para a felicidade\".",
    "\"A perseveran�a leva � conquista\".",
    "\"A coragem � a for�a que supera o medo\".",
    "\"A esperan�a � a luz que guia o caminho\".",
    "\"A f� move montanhas\".",
    "\"A determina��o � a chave para o sucesso\".",
    "\"A sabedoria vem da experi�ncia\".",
    "\"A autenticidade � a sua marca registrada\".",
    "\"A confian�a � o alicerce de todos os relacionamentos\".",
    "\"A solidariedade � a for�a que une as pessoas\".",
    "\"A gentileza � uma linguagem universal\".",
    "\"A resili�ncia � a capacidade de se adaptar e crescer\".",
    "\"A sinceridade � o v�nculo da verdade\".",
    "\"A responsabilidade � o caminho da maturidade\".",
    "\"A liberdade � o direito de ser voc� mesmo\".",
    "\"A igualdade � o princ�pio de um mundo melhor\".",
    "\"A justi�a � a base da sociedade\".",
    "\"A bondade � um presente que pode ser compartilhado\".",
    "\"A emula��o � a busca da excel�ncia\".",
    "\"A curiosidade � o desejo de aprender e crescer\".",
    "\"A ambi��o � a busca do seu potencial m�ximo\".",
    "\"A perseveran�a � a chave para vencer desafios\".",
    "\"A criatividade � a express�o da alma\".",
    "\"A determina��o � o combust�vel da conquista\".",
    "\"A gratid�o � a chave da felicidade\".",
    "\"A paci�ncia � a virtude da sabedoria\".",
    "\"A compaix�o � o alicerce da empatia\".",
    "\"A generosidade � a ess�ncia da humanidade\".",
    "\"A toler�ncia � o respeito pelas diferen�as\".",
    "\"A humildade � a base do crescimento\".",
    "\"A autoconfian�a � o segredo do sucesso\".",
    "\"A ousadia � o primeiro passo em dire��o aos sonhos\".",
    "\"A liberdade � o direito de ser voc� mesmo\".",
    "\"A coragem � a for�a que supera o medo\".",
    "\"A f� � a luz que guia o caminho\"."
};


        private int fraseIndex = 0;
        private string indiceFilePath = "fraseIndex.txt";

        public AIRKLoadSplash()
        {
            InitializeComponent();

            // Centralizar o label no form
            labelFrase.Anchor = AnchorStyles.None;
            //labelFrase.MaximumSize = new Size(550, 0); // Defina a largura m�xima desejada, como 550 (ajuste conforme necess�rio)

            // Ler o �ndice da �ltima frase exibida a partir do arquivo
            if (File.Exists(indiceFilePath))
            {
                int.TryParse(File.ReadAllText(indiceFilePath), out fraseIndex);
            }

            // Iniciar o timer
            timer1.Start();

            // Exibir a pr�xima frase ao abrir o formul�rio
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

            // Salvar o �ndice da frase atual no arquivo
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

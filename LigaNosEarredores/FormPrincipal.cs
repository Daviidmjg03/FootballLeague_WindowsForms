using BibiliotecaLigaNos;

namespace LigaNosEarredores
{
    /// <summary>
    /// Classe principal que representa o formul�rio principal da aplica��o.
    /// </summary>
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Lista de jogos dispon�veis na aplica��o.
        /// </summary>
        public List<Jogos> listaJogos { get; set; }

        /// <summary>
        /// Lista de clubes dispon�veis na aplica��o.
        /// </summary>
        public List<Clubes> listaClubes { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();
            listaJogos = new List<Jogos>();
            listaClubes = new List<Clubes>();
            ConfigurarMenuStrip();
        }

        public List<Jogos> GetListaJogos()
        {
            return listaJogos;
        }

        public List<Clubes> GetListaClubes()
        {
            return listaClubes;
        }

        /// <summary>
        /// Configura o menu strip adicionando um item de menu "Cr�ditos" que exibe informa��es sobre o desenvolvedor ao ser clicado.
        /// </summary>
        private void ConfigurarMenuStrip()
        {
            MenuStrip menuStrip1 = new MenuStrip();
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Cr�ditos");

            menuItem.Click += (sender, e) =>
            {
                MostrarInformacoes();
            };

            menuStrip1.Items.Add(menuItem);
            Controls.Add(menuStrip1);
        }

        /// <summary>
        /// Exibe uma caixa de mensagem com informa��es sobre o desenvolvedor.
        /// </summary>
        private void MostrarInformacoes()
        {
            string nome = "David Gon�alves";
            string versao = "1.6";
            string data = DateTime.Now.ToShortDateString();

            MessageBox.Show($"Nome: {nome}\nVers�o: {versao}\nData: {data}", "Informa��es", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Evento acionado ao clicar no bot�o "Clubes", abre o formul�rio para criar clubes.
        /// </summary>
        private void btnClubes_Click(object sender, EventArgs e)
        {
            ClubesForms ClubeForms = new ClubesForms();
            ClubeForms.Show();
        }

        /// <summary>
        /// Evento acionado ao clicar no bot�o "Jogos", abre o formul�rio para criar jogos.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            JogosForms jogosForms = new JogosForms();
            jogosForms.Show();
        }

        /// <summary>
        /// Evento acionado ao clicar no bot�o "Estat�sticas", abre o formul�rio para exibir estat�sticas dos clubes.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            EstatisticasForms estatisticasForms = new EstatisticasForms(listaClubes);
            estatisticasForms.Show();
        }
    }
}
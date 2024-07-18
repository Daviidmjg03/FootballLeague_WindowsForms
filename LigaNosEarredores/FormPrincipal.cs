using BibiliotecaLigaNos;

namespace LigaNosEarredores
{
    /// <summary>
    /// Classe principal que representa o formulário principal da aplicação.
    /// </summary>
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Lista de jogos disponíveis na aplicação.
        /// </summary>
        public List<Jogos> listaJogos { get; set; }

        /// <summary>
        /// Lista de clubes disponíveis na aplicação.
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
        /// Configura o menu strip adicionando um item de menu "Créditos" que exibe informações sobre o desenvolvedor ao ser clicado.
        /// </summary>
        private void ConfigurarMenuStrip()
        {
            MenuStrip menuStrip1 = new MenuStrip();
            ToolStripMenuItem menuItem = new ToolStripMenuItem("Créditos");

            menuItem.Click += (sender, e) =>
            {
                MostrarInformacoes();
            };

            menuStrip1.Items.Add(menuItem);
            Controls.Add(menuStrip1);
        }

        /// <summary>
        /// Exibe uma caixa de mensagem com informações sobre o desenvolvedor.
        /// </summary>
        private void MostrarInformacoes()
        {
            string nome = "David Gonçalves";
            string versao = "1.6";
            string data = DateTime.Now.ToShortDateString();

            MessageBox.Show($"Nome: {nome}\nVersão: {versao}\nData: {data}", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Clubes", abre o formulário para criar clubes.
        /// </summary>
        private void btnClubes_Click(object sender, EventArgs e)
        {
            ClubesForms ClubeForms = new ClubesForms();
            ClubeForms.Show();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Jogos", abre o formulário para criar jogos.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            JogosForms jogosForms = new JogosForms();
            jogosForms.Show();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Estatísticas", abre o formulário para exibir estatísticas dos clubes.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            EstatisticasForms estatisticasForms = new EstatisticasForms(listaClubes);
            estatisticasForms.Show();
        }
    }
}
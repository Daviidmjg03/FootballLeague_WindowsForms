using BibiliotecaLigaNos;

namespace LigaNosEarredores
{
    public partial class EstatisticasForms : Form
    {
        //private List<Jogos> jogos; 
        private List<Clubes> clubes; 

        /// <summary>
        /// Construtor da classe EstatisticasForms.
        /// Inicializa o formulário e atribui a lista de clubes fornecida.
        /// </summary>
        /// <param name="listaClubes">Lista de clubes a ser exibida nas estatísticas.</param>
        public EstatisticasForms(List<Clubes> listaClubes)
        {
            InitializeComponent();
            clubes = listaClubes;
            //jogos = listaJogos;
        }

        /// <summary>
        /// Inicializa a lista de clubes na ListBox.
        /// </summary>
        private void InitLista()
        {
            listBoxClassificacao.Items.Clear();
            listBoxClassificacao.DataSource = clubes;
            listBoxClassificacao.DisplayMember = "EstatisticasClube";
        }

        /// <summary>
        /// Evento ao carregar o formulário.
        /// Carrega os dados dos clubes a partir de ficheiros e inicializa a lista.
        /// </summary>
        private void EstatisticasForms_Load(object sender, EventArgs e)
        {
            CarregarFicheiros.CarregarClubes(clubes, @"Clubes.txt");
            CarregarFicheiros.CarregarClubesID(@"IdClubes.txt");
            InitLista();
        }

        /// <summary>
        /// Evento ao clicar no botão de classificação geral.
        /// Exibe os clubes ordenados pela classificação geral.
        /// </summary>
        private void btnClassificacaoGeral_Click(object sender, EventArgs e)
        {
            listBoxClassificacao.DataSource = clubes;
            listBoxClassificacao.DisplayMember = "EstatisticasClube";
        }

        /// <summary>
        /// Evento ao clicar no botão de golos.
        /// Exibe os clubes ordenados pelo número de golos marcados e sofridos.
        /// </summary>
        private void btnGolos_Click(object sender, EventArgs e)
        {
            var clubesOrdenados = clubes.OrderByDescending(c => c.golosMarcados)
                                .ThenBy(c => c.golosSofridos)
                                .ToList();

            listBoxClassificacao.DataSource = null;
            listBoxClassificacao.DataSource = clubesOrdenados;
            listBoxClassificacao.DisplayMember = "EstatisticasGolos";

            if (clubesOrdenados.Count > 0)
            {
                listBoxClassificacao.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Evento executado ao clicar no botão "Classificação".
        /// Ordena os clubes pela Classificação Geral e atualiza a lista na ListBox.
        /// </summary>
        /// <param name="sender">O objeto que desencadeou o evento.</param>
        /// <param name="e">Os argumentos do evento.</param>
        private void btnClasssificacao_Click(object sender, EventArgs e)
        {
            var clubesOrdenados = clubes.OrderByDescending(c => c.ClassificaoGeral).ToList();

            listBoxClassificacao.DataSource = clubesOrdenados;
            listBoxClassificacao.DisplayMember = "EstatisticasClassificacao";

            if (clubesOrdenados.Count > 0)
            {
                listBoxClassificacao.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Evento ao clicar no botão de vitórias.
        /// Exibe os clubes ordenados pelo número de vitórias em casa e fora.
        /// </summary>
        private void btnVitorias_Click(object sender, EventArgs e)
        {
            var clubesOrdenados = clubes.OrderByDescending(c => c.vitoriasCasa)
                                        .ThenByDescending(c => c.vitoriasFora)
                                        .ToList();

            listBoxClassificacao.DataSource = null;
            listBoxClassificacao.DataSource = clubesOrdenados;
            listBoxClassificacao.DisplayMember = "EstatisticasVitorias";

            if (clubesOrdenados.Count > 0)
            {
                listBoxClassificacao.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Evento ao clicar no botão de derrotas.
        /// Exibe os clubes ordenados pelo número de derrotas.
        /// </summary>
        private void btnDerrotas_Click(object sender, EventArgs e)
        {
            var clubesOrdenados = clubes.OrderByDescending(c => c.derrotas)
                                 .ToList();

            listBoxClassificacao.DataSource = null;
            listBoxClassificacao.DataSource = clubesOrdenados;
            listBoxClassificacao.DisplayMember = "EstatisticasDerrotas";

            if (clubesOrdenados.Count > 0)
            {
                listBoxClassificacao.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Evento ao clicar no botão de cancelar.
        /// Fecha o formulário atual.
        /// </summary>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

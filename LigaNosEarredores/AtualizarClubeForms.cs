using BibiliotecaLigaNos;

namespace LigaNosEarredores
{
    /// <summary>
    /// Formulário para atualizar os dados de um clube.
    /// </summary>
    public partial class AtualizarClubeForms : Form
    {
        int ClassificaoGeral;
        int jogosRealizados;
        int golosMarcados;
        int golosSofridos;
        int vitoriasCasa;
        int vitoriasFora;
        int empates;
        int derrotas;
        int idClube;

        /// <summary>
        /// Clube atualizado após as alterações.
        /// </summary>
        public Clubes ClubeAtualizado { get; private set; }

        /// <summary>
        /// Construtor do formulário para atualizar um clube.
        /// </summary>
        /// <param name="clube">Objeto Clubes a ser atualizado.</param>
        public AtualizarClubeForms(Clubes clube)
        {
            InitializeComponent();
            textBoxNomeClube.Text = clube.NomeClube;
            textBoxCidadeClube.Text = clube.Cidade;
            textBoxEstadioClube.Text = clube.NomeEstadio;
            textBoxAnoFundacao.Text = clube.AnoFundacao.ToString();
            textBoxTrofeus.Text = clube.Trofeus.ToString();
            ClassificaoGeral = clube.ClassificaoGeral;
            jogosRealizados = clube.jogosRealizados;
            golosMarcados = clube.golosMarcados;
            golosSofridos = clube.golosSofridos;
            vitoriasCasa = clube.vitoriasCasa;
            vitoriasFora = clube.vitoriasFora;
            empates = clube.empates;
            derrotas = clube.derrotas;
            idClube = clube.IdClube;
        }

        /// <summary>
        /// Evento acionado ao clicar no botão de atualizar.
        /// </summary>
        /// <param name="sender">Objeto que enviou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNomeClube.Text;
            string cidade = textBoxCidadeClube.Text;
            string estadio = textBoxEstadioClube.Text;
            int anoFundacao = int.Parse(textBoxAnoFundacao.Text);
            int trofeus = int.Parse(textBoxTrofeus.Text);

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cidade) && !string.IsNullOrEmpty(estadio))
            {
                ClubeAtualizado = new Clubes(nome, cidade, estadio, anoFundacao, trofeus, ClassificaoGeral, jogosRealizados, golosMarcados, golosSofridos, vitoriasCasa, vitoriasFora, empates, derrotas, idClube);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
        }

        /// <summary>
        /// Evento acionado ao clicar no botão de cancelar.
        /// </summary>
        /// <param name="sender">Objeto que enviou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

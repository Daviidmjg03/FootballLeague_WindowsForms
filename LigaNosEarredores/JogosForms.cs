using BibiliotecaLigaNos;
using System.Linq;

namespace LigaNosEarredores
{
    /// <summary>
    /// Formulário para criar jogos e estatísticas dos clubes.
    /// </summary>
    public partial class JogosForms : Form
    {
        List<Jogos> jogos;
        List<Clubes> clubes;
        Clubes casa;
        Clubes fora;
        int IdClubes;
        int IdJogos = 1;

        public JogosForms()
        {
            InitializeComponent();
            jogos = new List<Jogos>();
            clubes = new List<Clubes>();
        }

        /// <summary>
        /// Atualiza as comboboxes de seleção de clube (casa e fora) com os nomes dos clubes disponíveis.
        /// </summary>
        private void AtualizarComboboxes()
        {
            comboBoxCasa.Items.Clear();
            comboBoxFora.Items.Clear();

            foreach (var clube in clubes)
            {
                comboBoxCasa.Items.Add(clube.NomeClube);
                comboBoxFora.Items.Add(clube.NomeClube);
            }
        }

        /// <summary>
        /// Adiciona um novo clube à lista de clubes e atualiza as comboboxes.
        /// </summary>
        public void AdicionarClube(string nome, string cidade, string estadio, int anoFundacao, int trofeus, int classificaoG, int jogosR, int GolosM, int GolosS, int VitoriasC, int VitoriasF, int empates, int derrotas, int idClube)
        {
            clubes.Add(new Clubes(nome, cidade, estadio, anoFundacao, trofeus, classificaoG, jogosR, GolosM, GolosS, VitoriasC, VitoriasF, empates, derrotas, idClube));
            GuardarFicheiros.GravarClubes(clubes, @"Clubes.txt");
            AtualizarComboboxes();
        }

        /// <summary>
        /// Adiciona um novo jogo à lista de jogos e atualiza as estatísticas dos clubes envolvidos.
        /// </summary>
        private bool AdicionarJogo(Clubes casa, Clubes fora, DateTime data, int golosCasa, int golosFora)
        {
            if (jogos.Any(j =>
                j.Data.Date == data.Date &&
                ((j.Casa == casa && j.Fora == fora) ||
                 (j.Casa == fora && j.Fora == casa))))
            {
                MessageBox.Show($"Já existe um jogo entre {casa.NomeClube} e {fora.NomeClube} na data {data.ToShortDateString()}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            jogos.Add(new Jogos(IdJogos++, casa, fora, data, golosCasa, golosFora));
            bool empate = golosCasa == golosFora;
            bool casaVenceu = golosCasa > golosFora;

            if (empate)
            {
                casa.AtualizarEstatisticas(golosCasa, golosFora, false, true);
                fora.AtualizarEstatisticas(golosFora, golosCasa, false, false);
                MessageBox.Show($"Empate! {casa.NomeClube} {golosCasa} - {golosFora} {fora.NomeClube}");
            }
            else
            {
                casa.AtualizarEstatisticas(golosCasa, golosFora, casaVenceu, true);
                fora.AtualizarEstatisticas(golosFora, golosCasa, !casaVenceu, false);

                string equipaVencedora = casaVenceu ? casa.NomeClube : fora.NomeClube;
                string equipaPerdedora = casaVenceu ? fora.NomeClube : casa.NomeClube;
                int pontosDaEquipaVencedora = casaVenceu ? golosCasa : golosFora;
                int pontosDaEquipaPerdedora = casaVenceu ? golosFora : golosCasa;

                MessageBox.Show($"{equipaVencedora} ganhou por {pontosDaEquipaVencedora} - {equipaPerdedora} {pontosDaEquipaPerdedora}");
            }

            AtualizarInfo();
            return true;
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Adicionar Jogo".
        /// Valida os campos de entrada e adiciona um novo jogo.
        /// </summary>
        private void btnAdicionarJogo_Click(object sender, EventArgs e)
        {
            DateTime data = dateTimePickerData.Value;

            if (comboBoxCasa.SelectedItem is string nomeCasa &&
                comboBoxFora.SelectedItem is string nomeFora &&
                int.TryParse(textBoxGolosCasa.Text, out int golosCasa) &&
                int.TryParse(textBoxGolosFora.Text, out int golosFora))
            {
                casa = clubes.FirstOrDefault(c => c.NomeClube == nomeCasa);
                fora = clubes.FirstOrDefault(c => c.NomeClube == nomeFora);

                if (casa == null || fora == null)
                {
                    MessageBox.Show("Por favor, selecione clubes válidos.");
                    return;
                }

                if (AdicionarJogo(casa, fora, data, golosCasa, golosFora))
                {
                    SalvarDados();
                    GuardarFicheiros.GravarClubes(clubes, @"Clubes.txt");
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos com valores válidos.");
            }
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Atualizar Jogo".
        /// Abre o formulário para atualizar informações de um jogo selecionado na lista.
        /// </summary>
        private void btnAtualizarJogo_Click(object sender, EventArgs e)
        {
            if (listBoxJogos.SelectedIndex != -1)
            {
                int indiceSelecionado = listBoxJogos.SelectedIndex;
                Jogos jogoSelecionado = jogos[indiceSelecionado];
                AtualizarJogosForms atualizarJogoForm = new AtualizarJogosForms(jogoSelecionado, jogos);

                if (atualizarJogoForm.ShowDialog() == DialogResult.OK)
                {
                    DateTime novaData = atualizarJogoForm.JogoAtualizado.Data;

                    if (novaData.Date < DateTime.Now.Date)
                    {
                        MessageBox.Show("Não é permitido alterar a data do jogo para uma data anterior ao dia atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (jogos.Any(j =>
                        j.IdJogo != jogoSelecionado.IdJogo &&
                        j.Data.Date == novaData.Date &&
                        ((j.Casa == atualizarJogoForm.JogoAtualizado.Casa && j.Fora == atualizarJogoForm.JogoAtualizado.Fora) ||
                         (j.Casa == atualizarJogoForm.JogoAtualizado.Fora && j.Fora == atualizarJogoForm.JogoAtualizado.Casa))))
                    {
                        MessageBox.Show($"Já existe um jogo entre {atualizarJogoForm.JogoAtualizado.Casa.NomeClube} e {atualizarJogoForm.JogoAtualizado.Fora.NomeClube} na data {novaData.ToShortDateString()}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    jogos[indiceSelecionado] = atualizarJogoForm.JogoAtualizado;
                    SalvarDados();
                    AtualizarInfo();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um jogo para atualizar.");
            }
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Cancelar Jogo".
        /// Remove um jogo selecionado da lista de jogos.
        /// </summary>
        private void btnCancelarJogo_Click(object sender, EventArgs e)
        {
            if (listBoxJogos.SelectedIndex != -1)
            {
                int indiceSelecionado = listBoxJogos.SelectedIndex;
                jogos.RemoveAt(indiceSelecionado);
                SalvarDados();
                AtualizarInfo();
            }
            else
            {
                MessageBox.Show("Por favor, selecione um jogo para cancelar.");
            }
        }

        /// <summary>
        /// Atualiza a lista de jogos na listBox.
        /// </summary>
        private void AtualizarInfo()
        {
            listBoxJogos.Items.Clear();
            var jogosOrdenados = jogos.OrderByDescending(j => j.GolosEmCasa + j.GolosFora);

            foreach (var jogo in jogosOrdenados)
            {
                listBoxJogos.Items.Add(jogo);
            }
        }

        /// <summary>
        /// Evento acionado ao selecionar um jogo na listBox.
        /// Obtém o jogo selecionado para visualização ou edição.
        /// </summary>
        private void listBoxJogos_Click(object sender, EventArgs e)
        {
            if (listBoxJogos.SelectedItem == null)
            {
                return;
            }

            Jogos jogoSelecionado = (Jogos)listBoxJogos.SelectedItem;
        }

        /// <summary>
        /// Carrega os dados iniciais da aplicação, como clubes e jogos, a partir de ficheiros de texto.
        /// </summary>
        private void CarregarDados()
        {
            CarregarFicheiros.CarregarClubes(clubes, @"Clubes.txt");
            IdClubes = CarregarFicheiros.CarregarClubesID(@"IdClubes.txt");
            CarregarFicheiros.CarregarJogos(jogos, clubes, @"Jogos.txt");
            IdJogos = CarregarFicheiros.CarregarJogosID(@"IdJogos.txt");

            if (jogos.Count > 0)
            {
                IdJogos = jogos.Max(j => j.IdJogo) + 1;
            }
        }

        /// <summary>
        /// Evento de carregamento do formulário JogosForms.
        /// Carrega os dados iniciais e atualiza as comboboxes e lista de jogos.
        /// </summary>
        private void JogosForms_Load(object sender, EventArgs e)
        {
            CarregarDados();
            AtualizarComboboxes();
            AtualizarInfo();
        }

        /// <summary>
        /// Salva os dados da aplicação, como clubes e jogos, em ficheiros de texto.
        /// </summary>
        private void SalvarDados()
        {
            GuardarFicheiros.GravarJogosID(IdJogos, @"IdJogos.txt");
            GuardarFicheiros.GravarJogos(jogos, @"Jogos.txt");
            GuardarFicheiros.GravarClubes(clubes, @"Clubes.txt");
        }

        /// <summary>
        /// Evento acionado ao fechar o formulário JogosForms.
        /// Salva os dados antes de fechar o formulário.
        /// </summary>
        private void JogosForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvarDados();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Fechar".
        /// Fecha o formulário JogosForms.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}

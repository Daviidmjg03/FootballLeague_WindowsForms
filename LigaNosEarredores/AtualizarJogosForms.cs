using BibiliotecaLigaNos;
using System;

namespace LigaNosEarredores
{
    /// <summary>
    /// Formulário para atualizar os dados de um jogo.
    /// </summary>
    public partial class AtualizarJogosForms : Form
    {
        /// <summary>
        /// Propriedade para armazenar o jogo atualizado.
        /// </summary>
        public Jogos JogoAtualizado { get; private set; }
        private List<Jogos> jogos;

        /// <summary>
        /// Construtor da classe, recebe um objeto Jogos para inicializar o formulário.
        /// </summary>
        /// <param name="jogo">Objeto Jogos a ser atualizado.</param>
        public AtualizarJogosForms(Jogos jogo, List<Jogos> listaDeJogos)
        {
            InitializeComponent();
            dateTimePickerJogos.Value = jogo.Data;
            JogoAtualizado = jogo;
            jogos = listaDeJogos;
        }

        /// <summary>
        /// Evento acionado ao clicar no botão de atualizar.
        /// </summary>
        /// <param name="sender">Objeto que enviou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime novaData = dateTimePickerJogos.Value;

            // Validação para não permitir datas anteriores ao dia atual
            if (novaData.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Não é permitido alterar a data do jogo para uma data anterior ao dia atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            JogoAtualizado.Data = novaData;

            bool existeConflito = jogos.Any(j =>
                j.IdJogo != JogoAtualizado.IdJogo &&
                j.Data.Date == JogoAtualizado.Data.Date &&
                ((j.Casa == JogoAtualizado.Casa && j.Fora == JogoAtualizado.Fora) ||
                (j.Casa == JogoAtualizado.Fora && j.Fora == JogoAtualizado.Casa)));

            if (existeConflito)
            {
                MessageBox.Show("Já existe um jogo agendado para esta data com as mesmas equipas.",
                    "Conflito de Agendamento",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Evento acionado ao clicar no botão de cancelar.
        /// </summary>
        /// <param name="sender">Objeto que enviou o evento.</param>
        /// <param name="e">Argumentos do evento.</param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}


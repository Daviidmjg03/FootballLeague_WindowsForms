namespace BibiliotecaLigaNos
{
    /// <summary>
    /// Classe que representa os clubes de futebol.
    /// </summary>
    public class Clubes
    {
        /// <summary>
        /// Propriedades.
        /// </summary>
        public int IdClube { get; set; }
        public string NomeClube { get; set; }
        public string Cidade { get; set; }
        public string NomeEstadio { get; set; }
        public int AnoFundacao { get; set; }
        public int Trofeus { get; set; }
        public int ClassificaoGeral { get; set; }
        public int jogosRealizados { get; set; }
        public int golosMarcados { get; set; }
        public int golosSofridos { get; set; }
        public int vitoriasCasa { get; set; }
        public int vitoriasFora { get; set; }
        public int empates { get; set; }
        public int derrotas { get; set; }

        /// <summary>
        /// Construtor da classe.
        /// </summary>
        public Clubes(string nome, string cidade, string estadio, int anoFundacao, int trofeus, int classificaoG, int jogosR, int GolosM, int GolosS, int VitoriasC, int VitoriasF,
            int empate, int derrota,
            int idClube = 0)
        {
            IdClube = idClube;
            NomeClube = nome;
            Cidade = cidade;
            NomeEstadio = estadio;
            AnoFundacao = anoFundacao;
            Trofeus = trofeus;
            ClassificaoGeral = classificaoG;
            jogosRealizados = jogosR;
            golosMarcados = GolosM;
            golosSofridos = GolosS;
            vitoriasCasa = VitoriasC;
            vitoriasFora = VitoriasF;
            empates = empate;
            derrotas = derrota;
        }

        /// <summary>
        /// Atualiza as estatísticas do clube com base no resultado de um jogo.
        /// </summary>
        /// <param name="golosM">Número de golos marcados no jogo.</param>
        /// <param name="golosS">Número de golos sofridos no jogo.</param>
        /// <param name="venceu">Indica se o clube venceu o jogo.</param>
        /// <param name="jogouEmCasa">Indica se o clube jogou em casa.</param>
        public void AtualizarEstatisticas(int golosM, int golosS, bool venceu, bool jogouEmCasa)
        {
            jogosRealizados++;
            golosMarcados += golosM;
            golosSofridos += golosS;

            if (venceu)
            {
                if (jogouEmCasa)
                {
                    vitoriasCasa++;
                    ClassificaoGeral += 3;
                }
                else
                {
                    vitoriasFora++;
                    ClassificaoGeral += 3;
                }
            }
            else if (!venceu)
            {
                derrotas++;
            }
            else if (!venceu && golosM == golosS)
            {
                ClassificaoGeral += 1;
                empates++;
            }
        }
        /// <summary>
        /// Retorna uma descrição formatada do clube.
        /// </summary>
        public string DescricaoClube
        {
            get
            {
                return $"Clube: {NomeClube}    Cidade: {Cidade}    Estádio: {NomeEstadio}    AnoFundação: {AnoFundacao}    Trofeus: {Trofeus}";
            }
        }
        /// <summary>
        /// Retorna as estatísticas do clube.
        /// </summary>
        public string EstatisticasClassificacao
        {
            get
            {
                return $"Clube: {NomeClube}, Jogos Realizados: {jogosRealizados}, Classificação Geral: {ClassificaoGeral}";
            }
        }

        /// <summary>
        /// Retorna as estatísticas detalhadas do clube.
        /// </summary>
        public string EstatisticasClube
        {
            get
            {
                return $"Clube: {NomeClube}, Classificacão: {ClassificaoGeral}, Jogos: {jogosRealizados}, Golos M: {golosMarcados}, " +
                   $"Golos Sfds: {golosSofridos}, " +
                   $"Vitórias Casa: {vitoriasCasa}, " +
                   $"Vitórias Fora: {vitoriasFora}, " +
                   $"Empates: {empates}, " +
                   $"Derrotas: {derrotas}";
            }
        }
        /// <summary>
        /// Retorna as estatísticas de golos do clube.
        /// </summary>
        public string EstatisticasGolos
        {
            get
            {
                return $"Clube: {NomeClube}, Golos Marcados: {golosMarcados}, Golos Sofridos: {golosSofridos}";
            }
        }

        /// <summary>
        /// Retorna as estatísticas de vitórias do clube.
        /// </summary>
        public string EstatisticasVitorias
        {
            get
            {
                return $"Clube: {NomeClube}, Vitórias em Casa: {vitoriasCasa}, Vitórias Fora: {vitoriasFora}";
            }
        }

        /// <summary>
        /// Retorna as estatísticas de derrotas do clube.
        /// </summary>
        public string EstatisticasDerrotas
        {
            get
            {
                return $"Clube: {NomeClube}, Derrotas: {derrotas}";
            }
        }

        /// <summary>
        /// Sobrescrita do método ToString() para retornar uma representação textual do objeto.
        /// </summary>
        /// <returns>Uma representação textual do clube.</returns>
        public override string ToString()
        {
            return $"{NomeClube} - {Cidade} - {NomeEstadio} - {AnoFundacao} - {Trofeus}";
        }
    }
}
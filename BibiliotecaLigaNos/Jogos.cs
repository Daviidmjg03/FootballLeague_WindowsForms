using System;
using System.Data;

namespace BibiliotecaLigaNos
{
    /// <summary>
    /// Classe que representa um jogo de futebol.
    /// </summary>
    public class Jogos
    {
        /// <summary>
        /// Propriedades.
        /// </summary>
        public int IdJogo { get; set; }
        public Clubes Casa { get; set; }
        public Clubes Fora { get; set; }
        public int GolosEmCasa { get; set; }
        public int GolosFora { get; set; }
        public DateTime Data { get; set; }

        /// <summary>
        /// Construtor da classe Jogos.
        /// </summary>
        public Jogos(int idJogo, Clubes casa, Clubes fora, DateTime data, int golosEmCasa, int golosFora)
        {
            IdJogo = idJogo;
            Casa = casa;
            Fora = fora;
            GolosEmCasa = golosEmCasa;
            GolosFora = golosFora;
            Data = data;
        }

        /// <summary>
        /// Propriedade de apenas leitura que retorna uma descrição formatada do jogo.
        /// </summary>
        public string DescricaoJogos
        {
            get
            {
                return $"Jogo: {IdJogo}, Equipa Casa: {Casa},Equipa Fora: {Fora}, Golos Casa: {GolosEmCasa}, Golos Fora: {GolosFora}";
            }
        }

        /// <summary>
        /// Sobrescrita do método ToString() para retornar uma representação textual do jogo.
        /// </summary>
        public override string ToString()
        {
            return $"Equipa C: {Casa} | Equipa F: {Fora}, Resultado: {GolosEmCasa} - {GolosFora}, realizado em: {Data.ToString("dd/MM/yyyy")}";

        }
    }
}

using System;

namespace BibiliotecaLigaNos
{
    /// <summary>
    /// Classe responsável pela gravação de ficheiros.
    /// </summary>
    public class GuardarFicheiros
    {
        /// <summary>
        /// Método para gravar o ID total de clubes num ficheiro.
        /// </summary>
        /// <param name="contaClubes">Número total de clubes.</param>
        /// <param name="caminhoContaClubes">Caminho do ficheiro onde será gravado o número de clubes.</param>
        public static void GravarClubesID(int contaClubes, string caminhoContaClubes)
        {
            using (StreamWriter writer = new StreamWriter(caminhoContaClubes))
            {
                writer.WriteLine(contaClubes);
            }
        }

        /// <summary>
        /// Método para gravar os dados dos clubes num ficheiro CSV.
        /// </summary>
        /// <param name="clubes">Lista de clubes a serem gravados.</param>
        /// <param name="filePath">Caminho do ficheiro onde os dados serão gravados.</param>
        public static void GravarClubes(List<Clubes> clubes, string filePath)
        {
            var lines = clubes.Select(c => $"{c.NomeClube};{c.Cidade};{c.NomeEstadio};{c.AnoFundacao};{c.Trofeus};{c.ClassificaoGeral};{c.jogosRealizados};{c.golosMarcados};{c.golosSofridos};{c.vitoriasCasa};{c.vitoriasFora};{c.empates};{c.derrotas};{c.IdClube}");
            File.WriteAllLines(filePath, lines);
        }

        /// <summary>
        /// Método para gravar o ID total de jogos num ficheiro.
        /// </summary>
        /// <param name="contaJogos">Número total de jogos.</param>
        /// <param name="caminhoContaJogos">Caminho do ficheiro onde será gravado o número de jogos.</param>
        public static void GravarJogosID(int contaJogos, string caminhoContaJogos)
        {
            using (StreamWriter writer = new StreamWriter(caminhoContaJogos))
            {
                writer.WriteLine(contaJogos);
            }
        }

        /// <summary>
        /// Método para gravar os dados dos jogos num ficheiro CSV.
        /// </summary>
        /// <param name="jogos">Lista de jogos a serem gravados.</param>
        /// <param name="filePath">Caminho do ficheiro onde os dados serão gravados.</param>
        public static void GravarJogos(List<Jogos> jogos, string filePath)
        {
            if (jogos != null && jogos.Any())
            {
                var lines = jogos.Select(j => $"{j.IdJogo};{j.Casa.IdClube};{j.Fora.IdClube};{j.Data:yyyy-MM-dd};{j.GolosEmCasa};{j.GolosFora}");
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                throw new InvalidOperationException("A lista de jogos está vazia.");
            }
        }
    }
}

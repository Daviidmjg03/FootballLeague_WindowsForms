using System;
using System.Globalization;

namespace BibiliotecaLigaNos
{
    public class CarregarFicheiros
    {
        /// <summary>
        /// Método para carregar o ID dos clubes a partir de um ficheiro.
        /// </summary>
        /// <param name="caminhoIDClubes">O caminho do ficheiro que contém o ID dos clubes.</param>
        /// <returns>O ID dos clubes se a conversão for bem-sucedida, caso contrário, retorna 1.</returns>
        public static int CarregarClubesID(string caminhoIDClubes)
        {
            if (File.Exists(caminhoIDClubes))
            {
                string texto = File.ReadAllText(caminhoIDClubes);
                if (int.TryParse(texto, out int IdClubes))
                {
                    return IdClubes;
                }
            }
            return 1;
        }

        /// <summary>
        /// Método para carregar os dados dos clubes a partir de um ficheiro CSV.
        /// </summary>
        /// <param name="clubes">Lista onde os dados dos clubes serão carregados.</param>
        /// <param name="filePath">O caminho do ficheiro CSV que contém os dados dos clubes.</param>
        public static void CarregarClubes(List<Clubes> clubes, string filePath)
        {
            if (File.Exists(filePath))
            {
                var linhas = File.ReadAllLines(filePath);
                foreach (var linha in linhas)
                {
                    var partes = linha.Split(';');
                    if (partes.Length == 14)
                    {
                        var clube = new Clubes(
                    partes[0],
                    partes[1],
                    partes[2],
                    int.Parse(partes[3]),
                    int.Parse(partes[4]),
                    int.Parse(partes[5]),
                    int.Parse(partes[6]),
                    int.Parse(partes[7]),
                    int.Parse(partes[8]),
                    int.Parse(partes[9]),
                    int.Parse(partes[10]),
                    int.Parse(partes[11]),
                    int.Parse(partes[12]),
                    int.Parse(partes[13])
                );
                        clubes.Add(clube);
                    }
                }
            }
        }

        /// <summary>
        /// Método para carregar o ID dos jogos a partir de um ficheiro.
        /// </summary>
        /// <param name="caminhoIDJogos">O caminho do ficheiro que contém o ID dos jogos.</param>
        /// <returns>O ID dos jogos se a conversão for bem-sucedida, caso contrário, retorna 1.</returns>
        public static int CarregarJogosID(string caminhoIDJogos)
        {
            if (File.Exists(caminhoIDJogos))
            {
                string texto = File.ReadAllText(caminhoIDJogos);
                if (int.TryParse(texto, out int IdJogo))
                {
                    return IdJogo;
                }
            }
            return 1;
        }

        /// <summary>
        /// Método para carregar os dados dos jogos a partir de um ficheiro CSV.
        /// </summary>
        /// <param name="jogos">Lista onde os dados dos jogos serão carregados.</param>
        /// <param name="clubes">Lista de clubes para referência cruzada dos IDs dos clubes.</param>
        /// <param name="filePath">O caminho do ficheiro CSV que contém os dados dos jogos.</param>
        public static void CarregarJogos(List<Jogos> jogos, List<Clubes> clubes, string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var linhas = File.ReadAllLines(filePath);
                    foreach (var linha in linhas)
                    {
                        var partes = linha.Split(';');
                        if (partes.Length == 6)
                        {
                            if (DateTime.TryParseExact(partes[3], "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data))
                            {
                                Clubes clubeCasa = clubes.FirstOrDefault(c => c.IdClube == int.Parse(partes[1]));
                                Clubes clubeFora = clubes.FirstOrDefault(c => c.IdClube == int.Parse(partes[2]));

                                if (clubeCasa != null && clubeFora != null)
                                {
                                    var jogo = new Jogos(
                                        int.Parse(partes[0]),
                                        clubeCasa,
                                        clubeFora,
                                        data,
                                        int.Parse(partes[4]),
                                        int.Parse(partes[5])
                                    );
                                    jogos.Add(jogo);
                                }
                                else
                                {
                                    Console.WriteLine($"Clube(s) não encontrado(s) para o jogo: {partes[1]} vs {partes[2]}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Data inválida para o jogo: {linha}");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Linha inválida no ficheiro: {linha}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Ficheiro não encontrado: {filePath}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao carregar jogos: {ex.Message}");
            }
        }
    }
}
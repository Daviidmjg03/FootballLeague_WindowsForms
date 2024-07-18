using System;

namespace BibiliotecaLigaNos
{
    /// <summary>
    /// Classe que representa um utilizador.
    /// </summary>
    public class Utilizador
    {
        public string Username { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Construtor da classe Utilizador.
        /// </summary>
        /// <param name="username">Nome de utilizador.</param>
        /// <param name="password">Palavra-passe do utilizador.</param>
        /// <exception cref="ArgumentNullException">Lança uma exceção se o nome de utilizador ou a palavra-passe forem nulos ou vazios.</exception>
        public Utilizador(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentNullException(nameof(username), "O nome de utilizador não pode estar vazio.");

            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException(nameof(password), "A password não pode estar vazia.");

            Username = username;
            Password = password;
        }
    }
}

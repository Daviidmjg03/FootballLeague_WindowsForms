using BibiliotecaLigaNos;
using System;

namespace LigaNosEarredores
{
    /// <summary>
    /// Formulário de login para autenticar utilizadores.
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;

            textBoxUsername.KeyPress += new KeyPressEventHandler(LoginForm_KeyPress);
            textBoxPassword.KeyPress += new KeyPressEventHandler(LoginForm_KeyPress);
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Login".
        /// Verifica as credenciais inseridas e permite o acesso ao formulário principal se forem válidas.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha ambos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username == "David" && password == "cinel123")
            {
                FormPrincipal mainForm = new FormPrincipal();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou password inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Evento acionado ao clicar no botão "Fechar".
        /// Fecha o formulário de login.
        /// </summary>
        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                PerformLogin();
            }
        }

        /// <summary>
        /// Método para verificar credenciais e efetuar o login.
        /// </summary>
        private void PerformLogin()
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, preencha ambos os campos.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (username == "David" && password == "cinel123")
            {
                FormPrincipal mainForm = new FormPrincipal();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Nome de utilizador ou password inválidos.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}




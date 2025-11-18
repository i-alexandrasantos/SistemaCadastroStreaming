using System;

namespace SistemaCadastroStreaming
{
    public abstract class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            DefinirSenha(senha);

        }

        private void DefinirSenha(string senha)
        {
            if (senha.Length >= 3)
            {
                Senha = senha;
            }
            else
            {
                Console.WriteLine("A senha precisa ter no mínimo 6 caracteres.");
            }
        }

        public abstract void ExibirInformacao();
    }
}

using System;

namespace SistemaCadastroStreaming
{
    public class UsuarioComum : Usuario
    {
        public UsuarioComum(string nome, string email, string senha) : base(nome, email, senha) { }

        public override void ExibirInformacao()
        {
            Console.WriteLine($"Usuário {Nome} e E-mail {Email}.");
        }
    }
}

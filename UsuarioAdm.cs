using System;

namespace SistemaCadastroStreaming
{
    public class UsuarioAdm : Usuario
    {
        
        public UsuarioAdm(string nome, string email, string senha) : base(nome, email, senha) { }

        public override void ExibirInformacao()
        {
            Console.WriteLine($"Usuário Administrador {Nome}.");
            Console.WriteLine("");
        }

        public void RedefinirSenha(Usuario usuario)
        {
            Console.WriteLine($"Senha do usuário {usuario.Nome}. Redefinida com sucesso pelo admin {Nome}");
            Console.WriteLine("");
        }
    }
}

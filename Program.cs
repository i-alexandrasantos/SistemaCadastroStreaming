using System;

namespace SistemaCadastroStreaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = new Sistema();

            UsuarioAdm usuarioAdm = new UsuarioAdm("Alexandra", "ale@sistema.com", "1234");
            UsuarioComum usuarioComum = new UsuarioComum("Ravena", "ravena@sistema.com", "4567");

            sistema.AdicionarUsuario(usuarioAdm);
            sistema.AdicionarUsuario(usuarioComum);

            sistema.ListarUsuarios();

            Console.WriteLine("");
            Console.WriteLine("--- Cadastro de Filmes ---");

            //Filme novoFilme = new Filme();


            Console.WriteLine("Quantos filmes serão cadastrados? ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            sistema.AdicionarFilme(quantidade);
            sistema.ListarFilmes();
             
        }
    }
}

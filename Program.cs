using System;

namespace SistemaCadastroStreaming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = new Sistema();
            Filme filme = new Filme("Anastasia", "Filme", "Infantil", 1998);
            Filme novoFilme = new Filme("La La Land", "Musical", "Filme", 2023);

            Console.WriteLine("--- Informações dos Usuários ---");

            UsuarioAdm usuarioAdm = new UsuarioAdm("Alexandra", "ale@sistema.com", "1234");
            UsuarioComum usuarioComum = new UsuarioComum("Ravena", "ravena@sistema.com", "4567");

            sistema.AdicionarUsuario(usuarioAdm);
            sistema.AdicionarUsuario(usuarioComum);

            sistema.ListarUsuarios();

            Console.WriteLine("--- Cadastro de Filmes ---");

            filme.AdicionarFilme(filme);
            filme.AdicionarFilme(novoFilme);
            filme.ListarFilmes();

            /*Console.WriteLine("Insira o nome do filme: ");
            string nomeFilme = filme.Nome;
            nomeFilme = Console.ReadLine();

            Console.WriteLine($"Filme {filme.Nome}, cadastrado.");*/

        }
    }
}

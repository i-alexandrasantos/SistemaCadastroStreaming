using System;
using System.Collections.Generic;
using System.IO;

namespace SistemaCadastroStreaming
{
    public class Sistema
    {
        public List<Usuario> Usuarios = new List<Usuario>();

        public void AdicionarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
            Console.WriteLine($"Usuário {usuario.Nome} adicionado ao sistema.");
            Console.WriteLine("");
        }

        public Usuario BuscarUsuario(string email)
        {
            foreach (var usuario in Usuarios)
            {
                if (usuario.Email == email) 
                {
                    return usuario;
                }
            }
            return null;
        }

        public void RemoverUsuario(string email)
        {
            Usuario usuario = BuscarUsuario(email);
            if (usuario != null)
            {
                Usuarios.Remove(usuario);
                Console.WriteLine($"Usuário {usuario.Nome} removido.");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado");
            }
        }

        public void ListarUsuarios()
        {
            foreach(var usuario in Usuarios)
            {
                usuario.ExibirInformacao();
            }
        }

        //Filmes
        public List<Filme> Filmes = new List<Filme>();
      
        public void AdicionarFilme(int quantidade)
        {
            
            Console.WriteLine("-- Cadastro de Filme --");

            int i = 1;

            while (i <= quantidade)
            {
                Filme filme = new Filme();

                Console.WriteLine("Insira o nome do Filme: ");
                filme.Nome = Console.ReadLine();


                Console.WriteLine("Insira o gênero: ");
                filme.Genero = Console.ReadLine();

                Console.WriteLine("Insira o ano de Lançamento: ");
                filme.AnoLancamento = Convert.ToInt32(Console.ReadLine());

                Filmes.Add(filme);

                Console.WriteLine("--");

                i++;
            }

        }

        public void ListarFilmes()
        {
            foreach (var filme in Filmes)
            {
                Console.WriteLine($"Filme Cadastrado - {filme.Nome}");
            }
        }
    }
}

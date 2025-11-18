using System;
using System.Collections.Generic;

namespace SistemaCadastroStreaming
{
    public class Filme
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Genero { get; set; }
        public int AnoLancamento { get; set; }


        public Filme(string nome, string tipo, string genero, int anoLancamento)
        {
            Nome = nome;    
            Tipo = tipo;
            Genero = genero;
            AnoLancamento = anoLancamento;
        }

        public List<Filme> Filmes = new List<Filme>();

        //Cadastro novo filme
        public void AdicionarFilme(Filme filme)
        {
            Filmes.Add(filme);
            Console.WriteLine("");
            Console.WriteLine($"Filme {filme.Nome} adicionado com sucesso.");
            Console.WriteLine($"{filme.Nome} | {filme.Genero} | {filme.AnoLancamento} | {filme.Tipo}");
        }

        public void ListarFilmes()
        {
            foreach(var filme in Filmes)
            {
                Console.WriteLine($"Filme Cadastrado - {filme.Nome}");
            }
        }

    }
}

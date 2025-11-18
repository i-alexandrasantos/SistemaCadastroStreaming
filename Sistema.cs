using System;
using System.Collections.Generic;

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
    }
}

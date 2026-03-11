using System;
using System.Collections.Generic;

class Program
{
    static List<Usuario> usuarios = new List<Usuario>();
    static int contadorId = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSistema de Cadastro");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Buscar usuário");
            Console.WriteLine("4 - Remover usuário");
            Console.WriteLine("5 - Sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarUsuario();
                    break;

                case "2":
                    ListarUsuarios();
                    break;

                case "3":
                    BuscarUsuario();
                    break;

                case "4":
                    RemoverUsuario();
                    break;

                case "5":
                    return;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }

    static void CadastrarUsuario()
    {
        Usuario usuario = new Usuario();

        usuario.Id = contadorId++;

        Console.Write("Nome: ");
        usuario.Nome = Console.ReadLine();

        Console.Write("Email: ");
        usuario.Email = Console.ReadLine();

        usuarios.Add(usuario);

        Console.WriteLine("Usuário cadastrado com sucesso!");
    }

    static void ListarUsuarios()
    {
        foreach (var usuario in usuarios)
        {
            Console.WriteLine($"{usuario.Id} - {usuario.Nome} - {usuario.Email}");
        }
    }

    static void BuscarUsuario()
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();

        foreach (var usuario in usuarios)
        {
            if (usuario.Nome.Contains(nome))
            {
                Console.WriteLine($"{usuario.Id} - {usuario.Nome} - {usuario.Email}");
            }
        }
    }

    static void RemoverUsuario()
    {
        Console.Write("Digite o ID do usuário: ");
        int id = int.Parse(Console.ReadLine());

        usuarios.RemoveAll(u => u.Id == id);

        Console.WriteLine("Usuário removido.");
    }
}

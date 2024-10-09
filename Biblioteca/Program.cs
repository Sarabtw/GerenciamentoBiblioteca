using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static LiteralEncoder<Livro> catalogo = new List<Livro>();

    static void Main(string[] args)
    {
        CarregarCatalogo();

        while(true)
        {
            Console.WriteLine("\nMenu Biblioteca:");
            Console.WriteLine("1. Cadastrar livro");
            Console.WriteLine("2. Consultar catálogo");
            Console.WriteLine("3. Emprestar livro");
            Console.WriteLine("4. Devolver livro");
            Console.WriteLine("5. Salvar e sair");
            string opcao = Console.ReadLine();

        switch(opcao)
        {
            case "1":
            CadastrarLivro();
            break;

            case "2":
            ConsultarCatalogo();
            break;

            case "3":
            EmprestarLivro();
            break;

            case "4":
            DevolverLivro();
            break;

            case "5":
            SalvarCatalogo();
            return;
            default;
            Console.WriteLine("Opção inválida. ");
            break;
            

        }    

    }
}

static void CadastrarLivro()
{
    Console.Write("Título: ");
    string titulo = Console.ReadLine();

    Console.Write("Autor: ")
    string autor = Console.ReadLine();

    Console.Write("Quantidade disponível: ");
    int quantidade = int.Parse(Console.ReadLine());

  
}

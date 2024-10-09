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
    }
}

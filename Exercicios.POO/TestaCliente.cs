using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{
    class TestaCliente
    {
        private static void Main_()
        {
            Cliente c1 = new Cliente();
            c1.nome = "Gustavo";
            c1.codigo = 1;

            Cliente c2 = new Cliente();
            c2.nome = "Abc123";
            c2.codigo = 2;

            System.Console.WriteLine(c1.nome);
            System.Console.WriteLine(c1.codigo);

            System.Console.WriteLine(c2.nome);
            System.Console.WriteLine(c2.codigo);

            Console.Read();
        }
    }
}

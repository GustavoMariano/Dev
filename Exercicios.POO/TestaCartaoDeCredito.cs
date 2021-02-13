using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{
    class TestaCartaoDeCredito
    {
        private static void Main_()
        {
            CartaoDeCredito cdc1 = new CartaoDeCredito(114532543);
            cdc1.dataDeValidade = "12/17";

            CartaoDeCredito cdc2 = new CartaoDeCredito(098765676);
            cdc2.dataDeValidade = "12/18";


            Cliente c = new Cliente();
            c.codigo = 234324;
            c.nome = "Gustavo Mariano";

            cdc2.cliente = c;

            Console.WriteLine(cdc1.numero);
            Console.WriteLine(cdc1.dataDeValidade);
            Console.WriteLine("\n");
            Console.WriteLine(cdc2.numero);
            Console.WriteLine(cdc2.dataDeValidade);
            Console.WriteLine(cdc2.cliente.nome);
        }
    }
}
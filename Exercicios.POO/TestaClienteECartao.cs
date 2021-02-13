using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{
    class TestaClienteECartao
    {
        public static void Main_()
        {
            CartaoDeCredito cdc = new CartaoDeCredito(11111);
            cdc.dataDeValidade = "12/18";


            Cliente c = new Cliente();
            c.codigo = 234324;
            c.nome = "Gustavo Mariano";

            cdc.cliente = c;

            Console.WriteLine(cdc.numero);
            Console.WriteLine(cdc.dataDeValidade);
            Console.WriteLine(cdc.cliente.nome);
        }
    }
}

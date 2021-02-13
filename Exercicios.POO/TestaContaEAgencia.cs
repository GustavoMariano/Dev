using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{ 
    class TestaContaEAgencia
    {
        private static void Main_()
        {
            Agencia a = new Agencia(123123);
            a.numero = 2314324;

            ContaEAgencia c1 = new ContaEAgencia();
            c1.numero = 1234;
            c1.saldo = 1000;
            c1.limite = 500;

            c1.agencia = a;

            Console.WriteLine("Numero da conta: " + c1.numero);
            Console.WriteLine("Saldo: " + c1.saldo);
            Console.WriteLine("Limite: " + c1.limite);
            Console.WriteLine("Numero da agencia: " + c1.agencia.numero);
        }
    }
}

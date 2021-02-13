using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{
    class TestaMetodoTransfere
    {
        public static void Main_()
        {
            Conta origem = new Conta();
            origem.saldo = 1000;

            Conta destino = new Conta();

            Console.WriteLine(origem.saldo);
            Console.WriteLine(destino.saldo);

            origem.Transfere(destino, 500);

            Console.WriteLine(origem.saldo);
            Console.WriteLine(destino.saldo);
        }
    }
}

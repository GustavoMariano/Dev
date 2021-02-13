using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{
    class TestaAgencia
    {
        private static void Main_()
        {
            Agencia ag1 = new Agencia(321);

            Agencia ag2 = new Agencia(223);

            Console.WriteLine(ag1.numero);
            Console.WriteLine(ag2.numero);
        }
    }
}

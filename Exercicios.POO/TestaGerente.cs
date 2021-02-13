using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{
    class TestaGerente
    {
        public static void Main_()
        {
            Gerente gerente = new Gerente();
            gerente.nome = "Gustavo";
            gerente.salario = 1000;
            Console.WriteLine(gerente.salario);

            gerente.AumentoSalario();

            Console.WriteLine("1000 * 1.1  =  " + gerente.salario);
            gerente.AumentoSalario(0.3);
            Console.WriteLine("1100 * 1.3  =  " + gerente.salario);
        }
    }
}
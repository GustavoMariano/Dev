using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{
    class TestaConta
    {
        private static void Main_()
        {
            Agencia a = new Agencia(123);
            Conta c = new Conta(a);

            c.Deposita(1000);
            c.ImprimeExtrato();
            c.Saca(100);
            c.ImprimeExtrato();

            double saldoDisponivel = c.ConsultaSaldoDisponivel();

            Console.WriteLine(" Agencia: " + a.numero);
            Console.WriteLine(" SALDO DISPONÍVEL: " + saldoDisponivel);
        }
    }
}

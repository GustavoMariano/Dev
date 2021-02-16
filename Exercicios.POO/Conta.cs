using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{
    class Conta
    {
        public int numero;
        public double limite;
        public double saldo;
        public Agencia agencia;

        //public Conta()
        //{
        //    this.agencia = agencia;
        //}

        public Conta(Agencia agencia)
        {
            this.agencia = agencia;
        }

        public void Deposita(double valor)
        {
            this.saldo += valor;
        }

        public void Transfere(Conta destino, double valor)
        {
            this.saldo -= valor;
            destino.saldo += valor;
        }

        public void Saca(double valor)
        {
            this.saldo -= valor;
        }

        public void ImprimeExtrato()
        {
            Console.WriteLine(" SALDO: " + this.saldo);
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.saldo + this.limite;
        }

    }
}

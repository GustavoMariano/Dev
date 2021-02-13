using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{
    public class CartaoDeCredito
    {
        public int numero;
        public string dataDeValidade;
        public Cliente cliente;

        public CartaoDeCredito(int numero)
        {
            this.numero = numero;
        }
    }
}
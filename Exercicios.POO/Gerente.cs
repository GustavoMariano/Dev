using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios.POO
{
    class Gerente
    {
        public string nome;
        public double salario;

        public void AumentoSalario()
        {
            this.AumentoSalario(0.1);
        }

        public void AumentoSalario(double taxa)
        {
            this.salario += this.salario * taxa;
        }
    }
}

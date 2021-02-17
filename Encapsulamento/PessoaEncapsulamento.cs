using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    class PessoaEncapsulamento
    {
        private double salario;
        private string nome;

        public string AlteraNome
        {
            get{return this.nome;}
            set{this.nome = value;}
        }

        public double AlteraSalario
        {
            get
            {
                return this.salario;
            }
            set
            {
                this.salario = value;
            }
        }
    }
}

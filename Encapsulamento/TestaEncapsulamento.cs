using System;

namespace Encapsulamento
{
    class TestaEncapsulamento
    {
        private static void Main(string[] args)
        {
            PessoaEncapsulamento pessoa = new PessoaEncapsulamento();

            Console.WriteLine("Digite o Nome: ");
            pessoa.AlteraNome = Console.ReadLine();

            Console.WriteLine("Digite o salario do "+ pessoa.AlteraNome + ":");
            pessoa.AlteraSalario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O salário do "+ pessoa.AlteraNome +" é: " + pessoa.AlteraSalario);
        }
    }
}

using System;

namespace Maior.Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int maior =0;

            for (int i = 0; i < 5; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (var numero in numeros)
            {
                for (int i = 0; i < 5; i++)
                {
                    if(maior < numeros[i])
                    {
                        maior = numero;
                    }
                }
                
            }
            Console.WriteLine("\n"+ maior);
        }
    }
}

using System;

namespace ExericiosDeArray
{
     class Program
     {
          private static void Main()
          {
              String[] nomes = new string[] { "a", "z", "c", "aa", "bc", "cb", };


            //Linhas comentadas = ordenar array(strings de A a Z e numéricos do menor para o maior).

            //Array.Sort(nomes);
            //foreach (string ordenado in nomes)
            //{
            //    Console.WriteLine(ordenado);
            //}

            String[] nomes2 = new string[6];

            nomes.CopyTo(nomes2, 0);

            foreach (string nome in nomes2)
            {
                Console.WriteLine(nome);
            }
        }
     }    
}

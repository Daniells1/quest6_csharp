/*
 Para se preparar para os outros problemas, vamos fazer um teste. Dado um número X, 
retorne o menor número par maior do que X.

Entrada
Uma linha contendo um número  0 < X < 107.

Saída
Uma linha contendo a resposta do problema.
 */
using System;


namespace quest6_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sif;
            while ((sif = Console.ReadLine()) != null)
            {
                int N = int.Parse(sif);
                if (N % 2 == 0)
                {
                    Console.WriteLine(N + 2);
                }
                else
                {
                    Console.WriteLine(N + 1);
                }

            }
        }
    }
}
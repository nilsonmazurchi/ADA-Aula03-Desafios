using System;

namespace CalculoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidadeNumeros = 10;
            int soma = 0;
            int menor = int.MaxValue;

            for (int i = 0; i < quantidadeNumeros; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número:");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    // Calcula a soma dos números
                    soma += numero;

                    // Verifica se o número é menor que o menor número atual
                    if (numero < menor)
                    {
                        menor = numero;
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um número inteiro válido.");
                    i--; // Decrementa o contador para repetir a entrada deste número
                }
            }

            // Calcula a média
            double media = (double)soma / quantidadeNumeros;

            // Exibe os resultados
            Console.WriteLine($"Média dos números: {media:F2}");
            Console.WriteLine($"Soma dos números: {soma}");
            Console.WriteLine($"Menor número inserido: {menor}");
        }
    }
}

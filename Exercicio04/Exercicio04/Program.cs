using System;

namespace ContagemNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, quantidadeNumeros = 0, soma = 0, numerosPares = 0;

            Console.WriteLine("Digite números inteiros(digite 0 para encerrar):");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Por favor, insira um número válido.");
                }

                if (numero != 0)
                {
                    quantidadeNumeros++;
                    soma += numero;

                    if (numero % 2 == 0)
                    {
                        numerosPares++;
                    }
                }

            } while (numero != 0);

            Console.WriteLine($"Quantidade de números lidos: {quantidadeNumeros}");
            Console.WriteLine($"Soma dos números: {soma}");
            Console.WriteLine($"Quantidade de números pares: {numerosPares}");
        }
    }
}

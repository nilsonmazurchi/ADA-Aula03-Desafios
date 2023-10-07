using System;

namespace SomaElementosVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];
            int[] C = new int[10];

            // Preencher os vetores A e B com valores aleatórios (para fins de exemplo)
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                A[i] = random.Next(1, 101); // Números de 1 a 100
                B[i] = random.Next(1, 101); // Números de 1 a 100
            }

            // Calcular os elementos do vetor C
            for (int i = 0; i < 10; i++)
            {
                C[i] = A[i] + B[9 - i];
            }

            // Exibir os vetores A, B e C
            Console.WriteLine("Vetor A: " + string.Join(", ", A));
            Console.WriteLine("Vetor B: " + string.Join(", ", B));
            Console.WriteLine("Vetor C: " + string.Join(", ", C));
        }
    }
}

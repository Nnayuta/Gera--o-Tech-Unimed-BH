using System;
using Colecoes.Helper;


// Ctrl + . Automaticamente abre o menu para 'import'
namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5] { 6, 3, 8, 1, 9 };

            int[] arrayCopia = new int[10];

            int valorProcurado = 5;
            bool existe = op.Existe(array, valorProcurado);

            if (existe)
            {
                System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            }
            else
            {
                System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            }

            // System.Console.WriteLine("Array Original:");
            // op.ImprimirArray(array);

            // op.OrdenarBubbleSort(ref array);
            // op.OrdenarPorClasseArray(ref array);

            // System.Console.WriteLine("Array Ordenado:");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia:");
            // op.ImprimirArray(arrayCopia);

            // op.CopiarArrayPorClasseArray(ref array, ref arrayCopia);

            // System.Console.WriteLine("Array depois da cópia:");
            // op.ImprimirArray(arrayCopia);


            // Array multidimencional

            // int[,] matriz = new int[4, 2]
            // {
            //     { 8,  8 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200 }
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i,j]);
            //     }
            // }

            // foreach (var item in matriz)
            // {
            //     Console.WriteLine(item);
            // }

            // Array de inteiros
            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");
            // arrayInteiros[3] = 30;

            // System.Console.WriteLine("Array pelo for");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Array pelo foreach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }



        }
    }
}
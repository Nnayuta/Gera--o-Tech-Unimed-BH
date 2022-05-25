using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        //Quando recebemos por referencia trabalhamos com a propria variavel
        //Sem criar uma nova

        public void OrdenarBubbleSort(ref int[] array)
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void ImprimirArray(int[] array)
        {
            // Transforma o array em uma linha separado por virgula
            var linha = string.Join(", ", array);

            System.Console.WriteLine(linha);
        }

        public void OrdenarPorClasseArray(ref int[] array)
        {
            Array.Sort(array);
        }

        public void CopiarArrayPorClasseArray(ref int[] array, ref int[] arrayDestino)
        {
            //1° Array para copiar | 2 Array de destino | 3 Quantos elementos copiar 
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor)
        {
            // Retorna um 'bool' se o valor existe dentro do array buscando pelo array
            // inteiro e verifica se o 'valor' existe
            return Array.Exists(array, elemento => elemento == valor);
        }
    }
}
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
                    if (array[j] > array[j + 1]){
                        temp = array[j + 1];
                        array[j + 1 ] = array[j];
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
    }
}
/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
internal class Program
{
    private static void Main(string[] args)
    {
        int[] InitArray(int dimension)
        {
            int[] arr = new int[dimension];
            Random rnd = new Random();
            for (int i = 0; i < dimension; i++)
            {
                arr[i] = rnd.Next(1, 100);
            }
            return arr;
        }
        // печатаем массив
        int[] array = InitArray(6);
        Console.WriteLine(string.Join(", ", array));

        //Поиск нечетных чисел в массиве
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 1)
                count++;
        }

        //Печать итога
        Console.WriteLine($"из {array.Length} чисел, {count} нечетных");
    }
}
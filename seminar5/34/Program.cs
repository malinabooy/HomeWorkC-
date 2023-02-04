/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
// инициализируем массив
int[] InitArray(int dimension)
{
    int[] arr = new int[dimension];
    Random rnd = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(99,1000);
    }
    return arr;
}
// печатаем массив
int[] array = InitArray(6);
Console.WriteLine(string.Join(", ", array));

//34 и 36 задачи почти одинаковые поэтому ->
//Поиск четных и нечетных чисел в массиве
(int, int) FindCount(int [] array)
{
    int evenCount = 0;
    int oddCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0)
        evenCount++;
    else 
        oddCount++;
    }
    return(evenCount,oddCount);
}

//Печать итога
(int even, int odd) = FindCount(array);
Console.WriteLine($"из {array.Length} чисел, {even} четных и {odd} нечетных");

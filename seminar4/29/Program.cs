/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
int[] getNumbers()
{
    string[] arr;
    int[] correctArray = new int[8];
    while (true)
    {
        Console.Write("Через запятую введите 8 целых чисел: ");
        arr = Console.ReadLine()!.Split(',');
        if (arr.Length == 8)
        {
            int value;
            bool allCorrect = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (int.TryParse(arr[i], out value))
                    correctArray[i] = value;
                else
                {
                    Console.WriteLine("Введенные данные не являются числами!");
                    allCorrect = false;
                    break;
                }
            }
            if(allCorrect)
                return correctArray;
        }
        else
            Console.WriteLine("Введено не 8 элементов!");
    }
}

int[] Array = getNumbers();
Console.Write($"Получаем массив: [{string.Join(", ", Array)}]");

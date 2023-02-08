/*
...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int GetNumber(string message)
{
    int result =0;

    while (true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("Вы ввелин не корректное число. Повторите ввод"); 
    }

    return result;
}

int GetUniqNumber(int[] newMatrix)
{
    int nextNumber;
    do
    {
        nextNumber = new Random().Next(1, 100);
    }
    while (newMatrix[nextNumber] != 0);
    newMatrix[nextNumber] = 1;
    return nextNumber;
}

int [,,] InitMatrix(int x, int y, int z, int [] newMatrix)
{
    int [,,] matrix = new int [x, y, z];
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                matrix[i, j, k] = GetUniqNumber(newMatrix);
            }
        }
    }
    return matrix;
}

void PrintMatrix(int [,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine("Page №: " +(i+1));
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($" {matrix[i,j,k]} " + (i,j,k));
            }
            Console.WriteLine();
        }
    }
}

int x = GetNumber("Введите X: ");
int y = GetNumber("Введите Y: ");
int z = GetNumber("Введите Z: ");
int [] newMatrix = new int [10000];
int [,,] matrix = InitMatrix(x, y, z, newMatrix);
PrintMatrix(matrix);
Console.WriteLine();
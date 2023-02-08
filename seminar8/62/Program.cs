/*
 Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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

int [,] SprayMatrix (int [,] matrix)
{
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i,j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matrix.GetLength(1) - 1)
            j--;
        else    
            i--;
    }
    return matrix;
}


void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] / 10 <= 0)
                Console.Write($" {matrix[i,j]} ");

            else Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine(); 
        
            
    }
}

int rows = GetNumber("Введите количество строк(столбцов) для квадратной матрицы: ");
int columns = rows;
int [,] matrix = new int[rows,columns];
SprayMatrix(matrix);
PrintMatrix(matrix);
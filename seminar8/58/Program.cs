/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int [,] InitMatrix(int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

//Результатом умножения матриц A(m×)n и B(n×k) будет матрица C(m×k) такая, что элемент матрицы C, 
//стоящий в i-той строке и j-том столбце (cij), равен сумме произведений элементов i-той строки 
//матрицы A на соответствующие элементы j-того столбца матрицы B
void MultiplyMatrix(int [,] matrixOne, int [,] matrixTwo, int [,] finalMatrix)
{
    //Две матрицы можно перемножить между собой тогда и только тогда, когда количество 
    //столбцов первой матрицы равно количеству строк второй матрицы.
    if (matrixOne.GetLength(0) == matrixTwo.GetLength(1))
        for (int i = 0; i < matrixOne.GetLength(0); i++)
        {   
            for (int j = 0; j < matrixTwo.GetLength(1); j++)
            {
                for (int l = 0; l < matrixTwo.GetLength(0); l++)
                {
                    finalMatrix [i,j] += matrixOne[i,l] * matrixTwo[l,j];
                }
            }
        }
    else
        Console.WriteLine("Две матрицы можно перемножить между собой тогда и только тогда,когда количество столбцов первой матрицы равно количеству строк второй матрицы.");
}

int rows = GetNumber("Введите количество строк для первой матрицы: ");
int columns = GetNumber("Введите количество столбцов для первой матрицы: ");
int rowsTwo = GetNumber("Введите количество строк для второй матрицы: ");
int columnsTwo = GetNumber("Введите количество столбцов для второй матрицы: ");

Console.WriteLine();
Console.WriteLine("Первая матрица:");
int [,] matrixOne = InitMatrix(rows, columns);
PrintMatrix(matrixOne);

Console.WriteLine();
Console.WriteLine("Вторая матрица:");
int [,] matrixTwo = InitMatrix(rowsTwo, columnsTwo);
PrintMatrix(matrixTwo);

int [,] finalMatrix = new int[matrixOne.GetLength(0),matrixTwo.GetLength(1)];
MultiplyMatrix(matrixOne, matrixTwo, finalMatrix);

Console.WriteLine();
Console.WriteLine("Произведение массивов:");
PrintMatrix(finalMatrix);
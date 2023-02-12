/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int GetNaturalNumber(string message)
{
  int result = 0;

  while (true)
  {
    Console.Write(message);

    if (int.TryParse(Console.ReadLine(), out result) && result > 0)
    {
      break;
    }
    else
    {
      Console.WriteLine("Ввели не число или некорректное число. Повторите ввод!");
    }
  }

  return result;
}

int SumNumbers(int M, int N)
{
    int res = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        res = M + SumNumbers(M, N);
        return res;
    }
}

void SumFromMToN(int M, int N)
{
    Console.Write(SumNumbers(M - 1, N));
}

Console.WriteLine();
int M = GetNaturalNumber("Введите число M: ");
int N = GetNaturalNumber("Введите число N: ");
SumFromMToN(M, N);
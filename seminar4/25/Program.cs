/*
Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int GetNumberOne(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}

int GetNumberTwo(string message)
{
    int result = 0;
    
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}

void DegreeNumber(int a, int b)
{
    int degree = 1;
    
    for (int i = 1; i <= b; i++)
    {
        degree = degree*a;
    }
    Console.WriteLine($"{a} в степени {b} = {degree}");
}

int a = GetNumberOne("Введите число A:");
int b = GetNumberTwo("Введите число B:");
DegreeNumber(a,b);

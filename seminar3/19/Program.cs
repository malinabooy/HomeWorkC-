/*Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

Console.WriteLine("Введите число:");
string number = Console.ReadLine();
int length = number.Length;

if (length == 5)
{
    if (number[0] == number[4] && number[1] == number[3] )
    {
        Console.WriteLine($"{number} - Palindrom");
    }
    else
    {
        Console.WriteLine($"{number} - NOT Palindrom");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}




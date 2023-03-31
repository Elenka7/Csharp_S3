// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number >= 10000 && number < 100000)
{
    if (number % 10 == number / 10000 % 10)
    {
        if (number /10 % 10 == number / 1000 % 10)
        {
            Console.WriteLine($"Число {number} являетя полиндромом.");
        }
    }
    else
    {
        Console.WriteLine($"Число {number} не полиндромом.");
    }
}
else
{
    Console.WriteLine("Введенное число не является пятизначным.");
}
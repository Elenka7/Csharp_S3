// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число больше 1: ");
int num = int.Parse(Console.ReadLine()!);

if (num >= 1)
{
    for (double cube = 1; cube <= num; cube++)
    {
        Console.Write(Math.Pow(cube, 3) + ", ");
    }
}
else
{
    Console.Write("Введено неверное число.");
}
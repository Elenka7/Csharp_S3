// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними
// в 3D пространстве.
Console.WriteLine("Введите координату точки XA: ");
int xa = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату точки YA: ");
int ya = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату точки ZA: ");
int za = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату точки XB: ");
int xb = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату точки YB: ");
int yb = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату точки ZB: ");
int zb = int.Parse(Console.ReadLine()!);

double sqrX = Math.Pow((xb -xa), 2);

double sqrY = Math.Pow((yb -ya), 2);

double sqrZ = Math.Pow((zb -za), 2);

Console.WriteLine($"Расстояние между  точками А и В равно {Math.Round(Math.Sqrt(sqrX + sqrY + sqrZ), 2)}");
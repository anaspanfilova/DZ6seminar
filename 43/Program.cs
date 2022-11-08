// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Intersection(double b1, double b2, double k1, double k2)
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine($"Данные прямые совподают");
    }
    else if (k1 == k2)
    {
        Console.WriteLine($"Данные прямые параллельны");
    }
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k2 * x + b2;
        x = Math.Round(x, 2);
        y = Math.Round(y, 2);
        Console.WriteLine($"Точки пересечения: ({x}; {y})");
    }
}

Console.Clear();
Console.WriteLine("Введите число b1: ");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b2: ");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число k2: ");
double k2 = double.Parse(Console.ReadLine()!);

Intersection(b1, k1, b2, k2);
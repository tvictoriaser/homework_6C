// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double PointOfIntersection(double a, double b, double c, double d)
{
    if ((a == b) && (c == d)) Console.Write("Прямые совпадают");
    else if (a == b) Console.Write("Прямые параллельны");
    else
    {
        double x = (d - c) / (a - b);
        double y = a * x + c;
        Console.Write($"Точка пересечения двух прямых -> ({x},{y})");
    }
    return 0;
}

PointOfIntersection(k1,k2,b1,b2);

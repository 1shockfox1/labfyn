public class Program
{
    static double vich(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
    static void Main(string[] args)
    {

        Console.WriteLine("Введите координаты первой вершины x1 :");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты первой вершины y1 :");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты второй вершины x2:");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты второй вершины y2:");
        double y2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите координаты третьей вершины x3 :");
        double x3 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите координаты второй вершины y3:");
        double y3 = double.Parse(Console.ReadLine());

        double a = vich(x2, y2, x3, y3);
        double b = vich(x1, y1, x3, y3);
        double c = vich(x1, y1, x2, y2);


        if (a == b && b == c)
        {
            Console.WriteLine("Треугольник равносторонний.");
        }
        else if (a == b || b == c || a == c)
        {
            Console.WriteLine("Треугольник равнобедренный.");
        }
        else if (IsRightTriangle(a, b, c))
        {
            Console.WriteLine("Треугольник прямоугольный.");
        }
        else
        {
            Console.WriteLine("Треугольник обычный.");
        }
    }


    static bool IsRightTriangle(double a, double b, double c)
    {

        double max = Math.Max(a, Math.Max(b, c));


        if (max == a)
            return Math.Abs(a * a - (b * b + c * c)) < 1e-10;
        else if (max == b)
            return Math.Abs(b * b - (a * a + c * c)) < 1e-10;
        else
            return Math.Abs(c * c - (a * a + b * b)) < 1e-10;
    }

}
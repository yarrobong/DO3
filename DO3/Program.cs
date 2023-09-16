using System;

class Program
{
    static void Main()
    {
        double x1 = 3.0; 
        double x2 = 4.0;
        double x3 = 5.0;
        double v0 = 6.0;
        double t = 7.0;
        double a = 8.0;
        double m = 9.0;
        double v = 10.0;
        double g = 9.81; 
        double h = 11.0;
        double R1 = 12.0;
        double R2 = 13.0;
        double b = 14.0;
        double c = 15.0;
        double y = 16.0;
        double m1 = 17.0;
        double m2 = 18.0;
        double r = 19.0;
        double I = 20.0;
        double R = 21.0;
        double d = 23.0;
        double x = 24.0;

        Console.WriteLine("А) " + Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2)));
        Console.WriteLine("Б) " + (x1 * x2 + x1 * x3 + x2 * x3));
        Console.WriteLine("В) " + (v0 * t + (a * Math.Pow(t, 2)) / 2));
        Console.WriteLine("Г) " + (m * Math.Pow(v, 2) / 2 + m * g * h));
        Console.WriteLine("Д) " + (1 / R1 + 1 / R2));
        Console.WriteLine("Е) " + (m * g * Math.Cos(a)));
        Console.WriteLine("Ж) " + (2 * Math.PI * R));
        Console.WriteLine("З) " + (Math.Pow(b, 2) - 4 * a * c));
        Console.WriteLine("И) " + (y * m1 * m2 / Math.Pow(r, 2)));
        Console.WriteLine("К) " + (Math.Pow(I, 2) * R));
        Console.WriteLine("Л) " + (a * b * Math.Sin(c)));
        Console.WriteLine("М) " + (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(c))));
        Console.WriteLine("Н) " + ((a * d + b * c) / (a * d)));
        Console.WriteLine("О) " + (Math.Sqrt(1 - Math.Pow(Math.Sin(x), 2))));
        Console.WriteLine("П) " + (1 / Math.Sqrt(a * Math.Pow(x, 2) + b * x + c)));
        Console.WriteLine("Р) " + ((Math.Sqrt(x + 1) + Math.Sqrt(x - 1)) / (2 * Math.Sqrt(x))));
        Console.WriteLine("С) " + (Math.Abs(x) + Math.Abs(x + 1)));
        Console.WriteLine("Т) " + (Math.Abs(1 - Math.Abs(x))));
    }
}

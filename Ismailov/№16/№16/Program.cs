Console.WriteLine("Введите a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите c");
double c = Convert.ToDouble(Console.ReadLine());
double D = Math.Sqrt((b * b) - (4 * a * c));

if (D == 0)
{
    Console.WriteLine("D=0,уровнение имеет 1 корень:");
    double x = -b / (2 * a);
    Console.WriteLine("x = {0}", x);
}
else if (D > 0)
{
    double x1, x2;
    x1 = (-b + D) / (2 * a);
    x2 = (-b - D) / (2 * a);
    Console.WriteLine("D={0}, x1={1}, x2={2}", D, x1, x2);
}
else
{
    Console.WriteLine("D<0,уравнение не имеет решения");
}
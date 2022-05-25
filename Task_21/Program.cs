// Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Введите Координаты A: ");
    Console.Write("xa= ");
    double xa = Convert.ToDouble(Console.ReadLine());
    Console.Write("ya= ");
    double ya = Convert.ToDouble(Console.ReadLine());
    Console.Write("za= ");
    double za = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите Координаты B: ");
    Console.Write("xb= ");
    double xb = Convert.ToDouble(Console.ReadLine());
    Console.Write("yb= ");
    double yb = Convert.ToDouble(Console.ReadLine());
    Console.Write("zb= ");
    double zb = Convert.ToDouble(Console.ReadLine());
    //double sum = (xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za);
    double sum = Math.Pow((xb - xa), 2) + Math.Pow((yb - ya), 2) + Math.Pow((zb - za), 2);
    double result = Math.Sqrt(sum);
    double n = Math.Round(result, 2);
    Console.WriteLine($"Расстояние равно {n}");
    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}
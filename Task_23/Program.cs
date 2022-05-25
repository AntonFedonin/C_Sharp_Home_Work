// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Введите число N");
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine($"Число{i,3}| Куб{Math.Pow(i, 3),4}");
    }
    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}
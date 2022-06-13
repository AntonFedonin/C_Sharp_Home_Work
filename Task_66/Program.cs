// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());


void GetSum(int a, int b, int sum)
{
    if (a > b)
    {
        Console.WriteLine(sum);
        return;
    }

    if (a <= b)
    {
        sum += a;
        GetSum(a + 1, b, sum);
    }
}
GetSum(m, n, 0);

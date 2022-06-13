// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.WriteLine("Введите число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());

int Akkerman(int a, int b)
{
    if (a == 0)
    {
        return b + 1;
    }
    else if ((a > 0) && (b == 0))
    {
        return Akkerman(a - 1, 1);
    }
    else if ((a > 0) && (b > 0))
    {
        return Akkerman(a - 1, Akkerman(a, b - 1));
    }
    else
        return b + 1;
}
Console.WriteLine(Akkerman(m, n));

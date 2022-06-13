// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
NaturalNum(n);
void NaturalNum(int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNum(num - 1);
}
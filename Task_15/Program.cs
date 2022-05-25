
// Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.

Console.Clear();
Console.WriteLine("Введите номер дня недели: ");
int n = int.Parse(Console.ReadLine());
if (n > 7 || n < 1)
    Console.WriteLine("Ошибка ввода");
else
    Console.WriteLine(n < 6 ? $"Нет" : "Да");
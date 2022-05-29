// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей
// цифры нет.

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
string str = n.ToString();
// string n = (Console.ReadLine());
if (n <= 99)
    Console.WriteLine("Нет третьей цифры");
else
    Console.WriteLine(str[2]);
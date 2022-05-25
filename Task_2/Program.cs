//Напишите программу, которая на вход
//принимает два числа и выдаёт, 
//какое число большее, а
//какое меньшее.

Console.Clear();
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
int max = a;
if (b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);

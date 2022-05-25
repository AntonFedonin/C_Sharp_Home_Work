//Напишите программу, которая принимает на
//вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine(max);

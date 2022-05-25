// Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трёхзначное число -> ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine(n % 100 / 10);

// int[] array = new int[3];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = int.Parse(Console.ReadLine()); 
// }
// Console.WriteLine(array[1]);

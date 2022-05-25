// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
int digit = 0;
while (n > 0)
{
    digit = n % 10;
    sum = sum + digit;
    n = n / 10;
}
Console.WriteLine($"Сумма чисел равна {sum}");


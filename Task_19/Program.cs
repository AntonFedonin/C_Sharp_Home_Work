﻿// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Введите пятизначное число");
    var n = Console.ReadLine();
    int lenth = n.Length;
    if (lenth <= 3 || lenth > 5)
    {
        Console.WriteLine("Введено не корректное значение");
    }
    else if (n[0] == n[4] && n[1] == n[3])
        Console.WriteLine("Данное число палиндром");
    else
        Console.WriteLine("Данное число НЕ палиндром");
    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}
// Андрей, здравствуйте! Задам вопрос здесь.
// В интернете нашёл способ начать выполнение программы 
// заново или звершить её и столкнулся с такой проблемой.
// При вводе с клавиатуры "Y" программа выполняется заново,
// а завершается нажатием любой клавиши, не только "N".
// Вопрос, как сделать так, чтобы программа завершалась
// только нажатием клавиши "N"? Прошу ответить на платформе
// GB. Спасибо!







﻿//Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка)
Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
bool result = a % 2 > 0;
Console.WriteLine(result ? "Нет": "Да");

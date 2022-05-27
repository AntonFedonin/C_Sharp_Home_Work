// Задача 41. Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Введите числа через пробел, затем нажмите Enter");
    int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count += 1;
    }
    Console.WriteLine(count);
    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}
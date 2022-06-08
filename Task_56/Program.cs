// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.
bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Задайте прямоугольный массив");
    Console.WriteLine("ВНИМАНИЕ! Колличество строк и столбцов не должны быть равны!");
    Console.WriteLine();
    Console.Write("Введите колличество строк: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    int b = int.Parse(Console.ReadLine());
    int[,] GetArray(int a, int b)
    {
        int[,] array = new int[a, b];
        Random rndNum = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rndNum.Next(10);
            }
        }
        return array;
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    int GetLine(int[,] array)
    {

        int sum = 0, sum1 = 0, sum2 = 0;
        int index = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum2 = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum2 += array[i, j];
            }
            if (sum2 < sum1)
            {
                sum = sum2;
                index = i;
            }
            sum1 = sum2;
        }
        index += 1;
        return index;
    }
    if (a == b)
    {
        Console.WriteLine();
        Console.WriteLine("Колличество строк и столбцов не должны быть равны!");
        Console.WriteLine("Попробуем ещё раз? y/n");
        run = Console.ReadKey().Key == ConsoleKey.Y;
    }
    else
    {
        int[,] arr = GetArray(a, b);
        PrintArray(arr);
        int i = GetLine(arr);
        Console.WriteLine();
        Console.WriteLine($"Минимальная сумма элементов в строке № {i}");
        Console.WriteLine("Попробуем ещё раз? y/n");
        run = Console.ReadKey().Key == ConsoleKey.Y;
    }

}

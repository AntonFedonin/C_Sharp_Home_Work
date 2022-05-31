// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
bool run = true;
while (run)
{
    Console.Clear();
    Console.Write("Введите колличество строк: ");
    int lines = int.Parse(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    int columns = int.Parse(Console.ReadLine());

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
    int GetSum(int[,] array, int find)
    {
        int sum = 0;
        int i = 0;
        int j = 0;
        while (i < array.GetLength(0) - 1
               || j < array.GetLength(1) - 1)
        {
            sum += array[i, j];
            i++;
            j++;
        }
        return array[i,j];
    }

    int[,] arr = GetArray(lines, columns);
    PrintArray(arr);
    int sum = GetSum(arr);
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов равна {sum}");
    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}
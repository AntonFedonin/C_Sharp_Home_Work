// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
bool run = true;
while (run)
{
    Console.Clear();
    Console.Write("Введите колличество строк: ");
    int lines = int.Parse(Console.ReadLine());
    Console.Write("Введите колличество столбцов: ");
    int columns = int.Parse(Console.ReadLine());

    double[,] GetArray(int a, int b)
    {
        double[,] array = new double[a, b];
        Random rndNum = new Random();
        double upper = -9, lower = 9;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = Math.Round
                (lower + (rndNum.NextDouble() * (upper - lower)),1);
            }
        }
        return array;
    }

    void PrintArray(double[,] array)
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

    double[,] arr = GetArray(lines, columns);
    PrintArray(arr);
    Console.WriteLine();
    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}
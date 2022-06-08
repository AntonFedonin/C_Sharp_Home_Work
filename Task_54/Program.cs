// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
bool run = true;
while (run)
{
    Console.Clear();
    Console.Write("Задайте колличество строк: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Задайте колличество столбцов: ");
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
    int[,] SortArray(int[,] array)
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int temp = 0;
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] < array[i, k + 1])
                    {
                        temp = array[i, k];
                        array[i, k] = array[i, k + 1];
                        array[i, k + 1] = temp;
                    }
                }
            }
        }
        return array;
    }
    int[,] arr = GetArray(a, b);
    Console.WriteLine("Исходный массив:");
    PrintArray(arr);
    Console.WriteLine();
    int[,] sortArr = SortArray(arr);
    Console.WriteLine("Отсортированный массив:");
    PrintArray(sortArr);
    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}



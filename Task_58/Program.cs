// Задача 58*: Задайте две матрицы. Напишите программу, которая будет
// *находить произведение двух матриц.
bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("ВНИМАНИЕ! При умножении матриц колличество строк первой матрицы и столбцов второй должны быть равны!");
    Console.WriteLine();
    Console.Write("Задайте колличество строк первой матрицы: ");
    int firstRow = int.Parse(Console.ReadLine());
    Console.Write("Задайте колличество столбцов первой матрицы: ");
    int firstColl = int.Parse(Console.ReadLine());
    Console.Write("Задайте колличество строк второй матрицы: ");
    int secondRow = int.Parse(Console.ReadLine());
    Console.Write("Задайте колличество столбцов второй матрицы: ");
    int secondColl = int.Parse(Console.ReadLine());
    int[,] GetArray(int a, int b)
    {
        int[,] array = new int[a, b];
        Random rndNum = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = rndNum.Next(1, 10);
            }
        }
        return array;
    }
    int[,] ProductArray(int[,] firstArray, int[,] secondArray)
    {
        int[,] prodArr = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int k = 0; k < secondArray.GetLength(0); k++)
                {
                    prodArr[i, j] += firstArray[i, k] * secondArray[k, j];
                }
            }
        }
        return prodArr;
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
    if (firstRow != secondColl)
    {
        Console.WriteLine();
        Console.WriteLine("Умножение невозможно");
        Console.WriteLine("Попробуем ещё раз? y/n");
        run = Console.ReadKey().Key == ConsoleKey.Y;
    }
    else
    {
        Console.WriteLine();
        int[,] arr1 = GetArray(firstRow, firstColl);
        int[,] arr2 = GetArray(secondRow, secondColl);
        int[,] productArr = ProductArray(arr1, arr2);
        PrintArray(arr1);
        Console.WriteLine();
        PrintArray(arr2);
        Console.WriteLine();
        Console.WriteLine("Произведение матриц равно:");
        PrintArray(productArr);
        Console.WriteLine("Поропробуем ещё раз? y/n");
        run = Console.ReadKey().Key == ConsoleKey.Y;
    }
}
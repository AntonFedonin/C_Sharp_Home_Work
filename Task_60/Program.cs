// Задача 60: Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.
Console.Clear();
Console.Write("Введите колличество массивов: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите колличество строк: ");
int b = int.Parse(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int c = int.Parse(Console.ReadLine());
int[,,] GetArray(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    Random rndNum = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rndNum.Next(10, 100);
            }
        }
    }
    return array;
}
int[,,] ReplaceArrayElemet(int[,,] array)
{
    Random rndNum = new Random();
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (j > 0 && k > 0)
                    temp = array[i, j, k];

            }
        }
    }
    return array;
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($"Page №: {i + 1}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.WriteLine($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
int[,,] array = GetArray(a, b, c);
// ReplaceArrayElemet(array);
Console.WriteLine();
PrintArray(array);
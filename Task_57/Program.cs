// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
// Доп. задача 2.
Console.Clear();
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
void GetDictionary(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int find = array[i, j];
            count = 0;
            for (int k = 0; k < array.GetLength(0); k++)
            {
                for (int n = 0; n < array.GetLength(1); n++)
                {
                    if (find == array[k, n])
                        count++;
                }
            }
            Console.WriteLine($"{array[i, j]} повторяется {count} раз");
        }
    }

}
Console.WriteLine();
int[,] arr = GetArray(a, b);
PrintArray(arr);
Console.WriteLine();
GetDictionary(arr);
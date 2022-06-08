// Задача 62: Заполните спирально массив 4 на 4.
int a = 4;
int b = 4;

int[,] GetArray(int a, int b)
{
    int[,] array = new int[a, b];
    int n = 1;
    int i = 0;
    int j = 0;
    while (j < array.GetLength(0))
    {
        array[i, j] = n;
        n++;
        j++;
    }
    j = 3;
    i = 1;
    while (i < array.GetLength(1))
    {
        array[i, j] = n;
        n++;
        i++;
    }
    i = 3;
    j = 2;
    while (j >= 0)
    {
        array[i, j] = n;
        n++;
        j--;
    }
    i = 2;
    j = 0;
    while (i > 0)
    {
        array[i, j] = n;
        n++;
        i--;
    }
    i = 1;
    j = 1;
    while (j < array.GetLength(0) - 1)
    {
        array[i, j] = n;
        n++;
        j++;
    }
    i = 2;
    j = 2;
    while (j > 0)
    {
        array[i, j] = n;
        n++;
        j--;
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
int[,] arr = GetArray(a, b);
PrintArray(arr);


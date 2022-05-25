// Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Clear();
Console.WriteLine("Укажите размер массива");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
void FillArray(int[] collection)
{
    int length = collection.Length;
    Console.WriteLine("Заполните массив");
    for (int i = 0; i < length; i++)
    {
        collection[i] = int.Parse(Console.ReadLine());
    }
}
void PrintArray(int[] col)
{
    int size = col.Length;
    Console.Write("Массив: [");

    for (int i = 0; i < size; i++)
    {
        if (i < (size - 1))
            Console.Write($"{col[i]}" + $", ");
        else
            Console.Write($"{col[i]}");
    }
    Console.Write("]");

}

FillArray(array);
PrintArray(array);

// Console.WriteLine("Заполните эллементы массива через пробел");
// int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
// Console.Write(string.Join(' ', nums));


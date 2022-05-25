// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76
bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Укажите размер массива");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    var newRnd = new Random();
    int FindMax(int[] newArr)
    {
        int max = newArr[0];
        for (int i = 0; i < newArr.Length; i++)
        {
            if (newArr[i] > max)
                max = newArr[i];
        }
        return max;
    }
    int FindMin(int[] newArr)
    {
        int min = newArr[0];
        for (int i = 0; i < newArr.Length; i++)
        {
            if (newArr[i] < min)
                min = newArr[i];
        }
        return min;
    }
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = newRnd.Next(-10, 11);

        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    int diff = FindMax(array) - FindMin(array);
    Console.WriteLine($"Разница между max и min {diff}");

    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}
// Андрей, здравствуйте! Переделал задачу с помощью методов. Работает.
// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2
bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Укажите размер массива");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    int count = 0;
    var newRnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = newRnd.Next(100, 1000);

        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count += 1;
    }
    Console.WriteLine(count);

    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}

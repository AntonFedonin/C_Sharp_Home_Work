// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Укажите размер массива");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    int sum = 0;
    var newRnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = newRnd.Next(-100, 101);

        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    for (int i = 1; i < array.Length; i += 2)
    {

        sum += array[i];
    }
    Console.WriteLine(sum);

    Console.WriteLine("Попробуем ещё раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}
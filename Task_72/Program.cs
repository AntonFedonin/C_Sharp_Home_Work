// Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные
// представления нескольких чисел (без разделителя). В массиве data хранится
// информация о количестве бит, которые занимают числа из массива info.
// Напишите программу, которая составит массив десятичных представлений чисел
// массива data с учётом информации из массива info.
// 25 мин
// входные данные:
// - data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// - info = {2, 3, 3, 1 }
// выходные данные:
// - 1, 7, 0, 1

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };

void Convert(int[] arr, int[] arr2, int n, double sum, int count)
{
    if (n >= arr2.Length)
        Console.WriteLine(sum + " ");
    return;

    int pow = arr2[n];
    for (int i = count; i < (count + info[n]); i++)
    {
        sum = sum + arr[i] * Math.Pow(2, pow - 1);
        pow -= 1;
    }
    Convert(arr, arr2, n, sum, count += arr2[n]);

}
Convert(data, info, 0, 0, 0);
// int count = 0;
// for (int n = 0; n < info.Length; n++)
// {
//     int pow = info[n];
//     double sum = 0;
//     for (int i = count; i < (count + info[n]); i++)
//     {
//         sum = sum + data[i] * Math.Pow(2, pow - 1);
//         pow -= 1;
//     }
//     count += info[n];
//     Console.Write(sum + " ");
// }
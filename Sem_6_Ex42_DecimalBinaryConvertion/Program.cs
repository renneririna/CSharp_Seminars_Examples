// Задача 42
// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

Console.Clear();

// решение с красивым выводом, тоже через массив

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = InitArray(num);

Console.WriteLine($"{num} -> {String.Join(" ", array)}");

int[] InitArray(int num)
{
    int temp = num;
    int count = 0;
    while (temp > 0)
    {
        temp = temp / 2;
        count++;
    }
    int[] array = new int[count];
    int i = array.Length - 1;
    while (num > 0)
    {
        array[i] = num % 2;
        num = num / 2;
        i--;
    }
    return array;
}

// // решение через массив (без красивого вывода)
// int PROG()
// {
//     int num = 45;
//     int count = 0;
//     int temp = num;
//     while (temp > 0)
//     {
//         count++;
//         temp /= 2;
//     }
//     int[] mass = new int[count];
//     int i = mass.Length - 1;
//     while (num > 0)
//     {
//         mass[i] = num % 2;
//         num /= 2;
//         i--;
//     }
//     Console.WriteLine(string.Join(" ", mass));
//     return 0;
// }
// PROG();
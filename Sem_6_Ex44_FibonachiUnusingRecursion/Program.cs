// Задача 44
// Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = Fibonachi(num);

Console.WriteLine($"{num} -> {String.Join(" ", array)}");

int[] Fibonachi(int num)
{
    int k1 = 0, k2 = 1;
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < num; i++)
    {
        array[i] = k1 + k2;
        k2 = k1;
        k1 = array[i];
    }
    return array;
}
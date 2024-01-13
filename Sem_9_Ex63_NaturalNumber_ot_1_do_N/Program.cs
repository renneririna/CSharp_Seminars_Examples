// Задача 63
// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"
Console.Clear();

Console.Write("Введите число: ");
int value = int.Parse(Console.ReadLine() ?? "");

Console.Write($"N = {value} -> {GetNum(1, value)}");

string GetNum(int start, int end)
{
    if (start == end)
        return start.ToString();
    return start + ", " + GetNum(start + 1, value);
}

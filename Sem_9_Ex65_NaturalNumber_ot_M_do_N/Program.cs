// Задача 65
// Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Clear();

Console.Write("Введите число M: ");
int start = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число N: ");
int end = int.Parse(Console.ReadLine() ?? "");

Console.Write($"M = {start}; N = {end} -> {GetNum(start, end)}");

string GetNum(int start, int end)
{
    if (start == end)
        return start.ToString();
    return start + ", " + GetNum(start + 1, end);
}


// Задача 69
// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Clear();

Console.Write("Введите число A: ");
int number = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите число B: ");
int rank = int.Parse(Console.ReadLine() ?? "");

Console.Write($"A = {number}; B = {rank} -> {rekurs(number, rank)}");

int rekurs(int number, int rank)
{
    if (rank == 0)
        return 1;
    if (rank == 1)
        return number;

    return number * rekurs(number, rank - 1);
}



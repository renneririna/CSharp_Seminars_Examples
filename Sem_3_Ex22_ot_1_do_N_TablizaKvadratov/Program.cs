// Задача 22
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4.

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");
int count = 0;

Console.Write($"{number} -> ");

while (count != number - 1)
{  
    count++;
    Console.Write($"{count*count}, ");
}
count++;
Console.Write($"{count*count}. ");
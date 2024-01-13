// Задача 12
// Напишите программу, которая будет принмать на вход два числа и выводить
// является ли 2-е число кратное 1-му числу.
// Если 2-е число кратно 1-му, то программа выводит остаток от деления.
// Пример:
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Clear();
Console.Write("Введите первое целое число: ");
string userInput1 = Console.ReadLine() ??"";
int a = int.Parse(userInput1);

Console.Write("Введите второе целое число: ");
string userInput2 = Console.ReadLine() ??"";
int b = int.Parse(userInput2);

if (a % b == 0)
{
    Console.WriteLine($"{a}, {b} -> кратное");
}
else
{
    Console.WriteLine($"{a}, {b} -> не кратное, остаток от деления {a % b}");
}


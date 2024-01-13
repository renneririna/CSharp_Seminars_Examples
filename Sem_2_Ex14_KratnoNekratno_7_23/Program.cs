﻿// Задача 14
// Напишите программу, которая принимает на вход число и проверяет
// кратно ли оно одновременно 7 и 23.
// Пример:
// 14 -> нет
// 161 -> да

Console.Clear();
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ??"";
int num = int.Parse(userInput);

if (num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine($"{num} -> да");
}
else
{
    Console.WriteLine($"{num} -> нет");
}

// Дословно, если остаток от деления на 7 равен 0 и 
// при этом остаток отделения на 23 тоже равен 0, 
// то выводим "да", если хотя бы одно условие не выолняется, то выводит "нет"
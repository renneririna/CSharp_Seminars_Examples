﻿// Задача 30
// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();

Console.Write("["); // выводим открывающую квадратну скобку массива
int count = 0; // затем создаем переменную count счетчик
while (count < 7) // и в цикле организовываем счетчик, пока счетчик меньше 7
{
    count++; // увеличиваем счетчик
    Console.Write(new Random().Next(0, 2)); // генерируем каждый раз новое число в диапазоне от 0 до 1(2-1 всегда в .Next)
    Console.Write(", "); // выводим запятую с пробелом, чтобы отделить цифры друг от друга
}
Console.Write(new Random().Next(0, 2));
Console.Write("]");
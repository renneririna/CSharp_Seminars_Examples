﻿// Задача 11
// Напишите программу, которая выводит случайное трёхзначное число 
//и удаляет вторую цифру этого числа.
// Пример:
// 456 -> 46
// 782 -> 72
// 918 -> 98


Console.Clear();
int num = new Random().Next(100, 1000);
int a1 = num / 100; // получаем первую цифру
int a3 = num % 10; // получаем третью цифру
int res = a1 * 10 + a3;

Console.WriteLine($"{num} -> {res}");
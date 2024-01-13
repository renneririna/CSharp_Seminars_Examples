// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21


Console.Clear();

Console.Write("Введите х точки А: ");
int dotAx = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите y точки А: ");
int dotAy = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите х точки B: ");
int dotBx = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите y точки B: ");
int dotBy = int.Parse(Console.ReadLine() ?? "");

double distance = Math.Sqrt((dotBx-dotAx)*(dotBx-dotAx)+(dotBy-dotAy)*(dotBy-dotAy));
Console.WriteLine($"Расстояние между точками на плоскости равно {distance:f2}");
Console.WriteLine("Или вывод как в примере");
Console.WriteLine($"A({dotAx}, {dotAy}); B({dotBx}, {dotBy}) -> {distance:f2}");
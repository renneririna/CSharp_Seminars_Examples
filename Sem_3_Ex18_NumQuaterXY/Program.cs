// Задача 18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// -------------------------- Начало программы ---------------------------------
Console.Clear();
Console.Write("Введите номер четверти ");
int number = int.Parse(Console.ReadLine() ?? "");

if (number == 1)
{
    Console.WriteLine("X > 0, Y > 0");
}
else if (number == 2)
{
    Console.WriteLine("X < 0, Y < 0");
}
else if (number == 3)
{
    Console.WriteLine("X < 0, Y < 0");
}
else if (number == 2)
{
    Console.WriteLine("X < 0, Y < 0");
}
else
{
    Console.WriteLine("Ошибка ввода!");
}
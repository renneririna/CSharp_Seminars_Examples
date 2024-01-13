// Задача 3
// Напишите программу, которая будет выдавать название дня недели по заданному номеру
// Пример:
// 3 -> среда
// 5 -> пятница

Console.Clear();
Console.Write("Введите число: ");
string userInput = Console.ReadLine() ?? "";
int userNumber = int.Parse(userInput);
switch (userNumber)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;

    case 2:
        Console.WriteLine("Вторник");
        break;

    case 3:
        Console.WriteLine("Среда");
        break;

    case 4:
        Console.WriteLine("Четверг");
        break;

    case 5:
        Console.WriteLine("Пятница");
        break;

    case 6:
        Console.WriteLine("Суббота");
        break;

    case 7:
        Console.WriteLine("Воскресенье");
        break;

    default:
        Console.WriteLine("Такого дня недели не существует");
        break;
}
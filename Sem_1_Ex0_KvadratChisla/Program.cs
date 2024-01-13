// Задача 0
// Напишите программу, которая на вход принимает число и выдаёт его квадрат
// (число умноженое само на себя)
// Пример:
// 4 -> 16
// -3 -> 9
// -7 -> 49

Console.Clear();
Console.Write("Введите целое число: ");
string userInput = Console.ReadLine() ??"";
int userNumber = int.Parse(userInput);

int result = userNumber*userNumber;

Console.WriteLine($"{userNumber} -> {result}");
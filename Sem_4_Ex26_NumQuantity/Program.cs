// Задача 26
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Clear();
// 1. Input - организация ввода данных
int A = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");

// 2. Calculations - решение задачи, вычисление
int result = CountNumber(A);

// 3. Output - формирование вывода
Console.WriteLine($"{A} -> {result}");

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int CountNumber(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}



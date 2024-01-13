// Задача 24
// Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А	
// 4 -> 10 (1+2+3+4=10)
// 7 -> 28
// 8 -> 36

// // Решение из презентации
// Console.Clear();
// int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
// int sumNumbers = GetSumNumbers(num);
// Console.WriteLine($"{num} -> {sumNumbers}");
// // Выводит в консоль сообщение message,
// // преобразовывает введённую пользователем строку в число типа int.
// // В случае ошибки выводит в консоль сообщение errorMessage
// int GetNumberFromUser(string message, string errorMessage)
// {
//     while (true)
//     {
//         Console.Write(message);
//         bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
//         if (isCorrect)
//             return userNumber;
//         Console.WriteLine(errorMessage);
//     }
// }
// // Возвращает сумму чисел от 1 до number
// int GetSumNumbers(int number)
// {
//     int sum = 0;
//     while (number > 0)
//     {
//         sum += number;
//         number--;
//     }
//     return sum;
// }

// Решение из семинара

Console.Clear();
// 1. Input - организация ввода данных
int A = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");

// 2. Calculations - решение задачи, вычисление
int sumNumbers = GetSumNumbers(A);

// 3. Output - формирование вывода
Console.WriteLine($"{A} -> {sumNumbers}");


int GetSumNumbers(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number;
        number--;
    }
    return sum;
}

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

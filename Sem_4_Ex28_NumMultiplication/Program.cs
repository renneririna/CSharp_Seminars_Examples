// Задача 28
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// с маленькими цифрами
Console.Clear();
// int A = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
// int result = ProdNumbers(A);
// Console.WriteLine($"{A} -> {result}");

// int GetNumberFromUser(string message, string errorMessage)
// {
//     while (true)
//     {
//         Console.Write(message);
//         if (int.TryParse(Console.ReadLine(), out int userNumber))
//             return userNumber;
//         Console.WriteLine(errorMessage);
//     }
// }

// int ProdNumbers(int number)
// {
//     int prod = 1;
//     while (number > 0)
//     {
//         prod *= number;
//         number--;
//     }
//     return prod;
// }

// с большими цифрами
int A = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
ulong result = ProdNumbers((ulong) A);
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

ulong ProdNumbers(ulong number)
{
    ulong prod = 1;
    while (number > 0)
    {
        prod = prod * number;
        number--;
    }
    return prod;
}
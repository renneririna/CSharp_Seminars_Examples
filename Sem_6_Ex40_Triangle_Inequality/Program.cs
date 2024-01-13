// Задача 40
// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// (Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.)

Console.Clear();

int number1 = GetNumberFromUser("Введите длину первой стороны: ", "ошибка ввода");
int number2 = GetNumberFromUser("Введите длину второй стороны: ", "ошибка ввода");
int number3 = GetNumberFromUser("Введите длину третьей стороны: ", "ошибка ввода");

ExistTriangle(number1, number2, number3);

bool ExistTriangle(int n1, int n2, int n3)
{
    if (n1 < n2 + n3 && n2 < n1 + n3 && n3 < n1 + n2)
    {
        Console.WriteLine($"{n1}, {n2}, {n3} -> такой треуголник существует");
    }
    else Console.WriteLine($"{n1}, {n2}, {n3} -> такой треуголник НЕ существует");
    return true;
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
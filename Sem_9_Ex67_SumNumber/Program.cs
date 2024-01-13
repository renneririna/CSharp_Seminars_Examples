// Задача 67
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

//int a = Convert.ToInt32(Console.ReadLine()); без красивого приглашения ко вводу

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "");

int rekurs(int a)
{
    if (a == 0)
        return 0;
    return a % 10 + rekurs(a / 10);
}

Console.Write($"{a} -> {rekurs(a)}");
// Задача 33
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

Console.Clear();
int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите минимальное число: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите максимальное число: ", "Ошибка ввода!");

int[] array = GetArray(size, minValue, maxValue);

Console.WriteLine(String.Join(" ", array));

int number = GetNumberFromUser("Введите число: ", "Ошибка ввода!");
bool isFinded = IsExists(number, array);
Console.WriteLine($"{number}; массив [{String.Join(" ", array)}] -> {(isFinded? "да":"нет")}");

bool IsExists(int num, int[] arr)
{
    foreach (int elem in arr)
    {
        if (elem == num)
            return true;
    }
    return false;
}
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
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
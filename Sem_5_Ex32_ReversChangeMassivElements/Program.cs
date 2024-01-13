// Задача 32
// Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.Clear();
int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите минимальное число: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите максимальное число: ", "Ошибка ввода!");

int[] array = GetArray(size, minValue, maxValue);

Console.WriteLine(String.Join(" ", array));
ChangeSign(array);

Console.WriteLine(String.Join(" ", array));

void ChangeSign(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
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